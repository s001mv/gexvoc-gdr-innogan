using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Recolecta : Notificable,IClaseBase,IControlStock
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {                     
            RecolectaData.Insertar(this);
            Movimiento.GenerarMovimiento(TipoOperacion.Insercion, this);            
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            Movimiento.GenerarMovimiento(TipoOperacion.Actualizacion, this);
            RecolectaData.Actualizar(this);          
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
          
            Movimiento.GenerarMovimiento(TipoOperacion.Borrado, this);
            RecolectaData.Eliminar(this);          
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Recolecta();
                    break;
                case TipoContexto.Modificacion:
                    rtno = RecolectaData.GetRecolectaOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Recolecta a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Recolecta con el id especificado.</returns>
        public static Recolecta Buscar(int id)
        {
            return RecolectaData.GetRecolecta(id);
        }

        /// <summary>
        /// Obtiene los/las Recolecta que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Recolecta> Buscar(int? idForraje, int? idParcela, int? cantidad, DateTime? fechaMayorIgual, DateTime? fechaMenorIgual)
        {
            return RecolectaData.GetRecolectas(idForraje,idParcela,cantidad,fechaMayorIgual,fechaMenorIgual);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Recolecta
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Recolecta> Buscar()
        {
            return RecolectaData.GetRecolectas(null,null,null,null,null);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        /// <summary>
        /// Devuelve el nombre de la parcela.
        /// </summary>
        public string DescParcela
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Parcela != null)
                    rtno = this.Parcela.Nombre;
                return rtno;
            }
        
        }
        /// <summary>
        /// Devuelve el nombre del producto en este caso del tipo forraje.
        /// </summary>
        public string DescForraje
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Forraje != null)
                    rtno = this.Forraje.Descripcion;
                return rtno;
            }
        
        }
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        

        #endregion

        #region CONTROL DE STOCK
            public decimal? CantidadAnterior { get; set; }     
            partial void OnCantidadChanging(decimal value) { CantidadAnterior = this.Cantidad; }
            public int? IdForrajeAnterior { get; set; }
            partial void OnIdForrajeChanging(int value){IdForrajeAnterior = this.IdForraje;}
            public int? IdParcelaAnterior { get; set; }
            partial void OnIdParcelaChanging(int value){IdParcelaAnterior=this.IdParcela;}
            public DateTime? FechaAnterior { get; set; }
            partial void OnFechaChanging(DateTime value){FechaAnterior = this.Fecha;}


            /// <summary>
            /// Convierto la clase actual a partir de sus valores actuales en clases del tipo 'MovimientoDefinicion'
            /// susceptibles de crear stock.
            /// Esta conversión se lleva a cabo en Movimiento.GenerarMovimiento(TipoOperacion operacion,object clase) 
            /// que es llamada cada vez que se confirma una operación en clase que implementa la interface IControlStock.
            /// Nota: NO se debe llamar esplicitamente a este método.
            /// </summary>
            /// <param name="operacion"></param>
            /// <returns></returns>
            public List<MovimientoDefinicion> ToMovimiento(TipoOperacion operacion)
            {
                List<MovimientoDefinicion> lstMovimientos = new List<MovimientoDefinicion>();

                MovimientoDefinicion movimiento = new MovimientoDefinicion();
                movimiento.Operacion = operacion;

               
                Parcela parcela = Parcela.Buscar(this.IdParcela);

                movimiento.Identificacion = this.Id.ToString();
                movimiento.Tipo = TiposMovimientos.RECOLECTA_FINCAS;
                movimiento.IdProducto = this.IdForraje;
                movimiento.Cantidad = this.Cantidad;
                movimiento.FechaEfecto = this.Fecha;

                //Calculo la cantidad correcta, pues depende de la extension de la parcela.
                if (parcela != null)//Multiplico la cantidad de kg/ha por la cantidad de ha que tiene la parcela.                
                    movimiento.Cantidad *= parcela.Extension;


                if (operacion == TipoOperacion.Borrado)
                    movimiento.Cantidad *= -1;//Cambio de signo a la cantidad ya que el borrado de la tabla Recolecta resta stock.

                //Establecer valores a las variables con sufijo _Anterior (cambiantes)
                if (operacion == TipoOperacion.Actualizacion)
                {
                    movimiento.IdProductoAnterior = this.IdForrajeAnterior ?? this.IdForraje;
                    movimiento.CantidadAnterior = this.CantidadAnterior ?? this.Cantidad;
                    movimiento.FechaEfectoAnterior = this.FechaAnterior ?? this.Fecha;

                    //Calculo la cantidad Anterior correcta, pues depende de la extension de la parcela.
                    Parcela parcelaAnterior = Parcela.Buscar(this.IdParcelaAnterior ?? this.IdParcela);
                    if (parcelaAnterior != null)//Multiplico la cantidad de kg/ha por la cantidad de ha que tiene la parcela.                
                        movimiento.CantidadAnterior *= parcelaAnterior.Extension;

                    movimiento.CantidadAnterior *= -1;//Cambio de signo a la cantidad anterior ya que la Recolecta Anterior se resta del stock.
                }

                lstMovimientos.Add(movimiento);
                return lstMovimientos;
            }
        #endregion


    }
}
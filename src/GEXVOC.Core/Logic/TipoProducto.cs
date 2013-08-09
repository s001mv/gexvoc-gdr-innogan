using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class TipoProducto : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            ValidarLogica(TipoOperacion.Insercion);
            TipoProductoData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);            
            TipoProductoData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);            
            TipoProductoData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new TipoProducto();
                    break;
                case TipoContexto.Modificacion:
                    rtno = TipoProductoData.GetTipoProductoOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una TipoProducto a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>TipoProducto con el id especificado.</returns>
        public static TipoProducto Buscar(int id)
        {
            return TipoProductoData.GetTipoProducto(id);
        }

        /// <summary>
        /// Obtiene los/las TipoProducto que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<TipoProducto> Buscar(string descripcion,Boolean? familia,Boolean? sistema)
        {
            return TipoProductoData.GetTiposProductos(descripcion, familia, sistema);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo TipoProducto
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<TipoProducto> Buscar()
        {
            return TipoProductoData.GetTiposProductos(string.Empty,null,null);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
        ///// </summary>
        //public string DescProvincia { get { return this.Municipio.Provincia.Descripcion; } }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        public List<Familia> lstFamilias
        {
            get { return Logic.Familia.Buscar(this.Id,string.Empty,null); }

        }
        public List<Producto> lstProductos
        {
            get { return Logic.Producto.BuscarProductosSinFamilia(this.Id, string.Empty,null,null); }

        }



        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        /// <summary>
        /// Lanza una excepción en caso de que se intente modificar o eliminar un TipoProducto marcado en la base de datos como de sistema. 
        /// (Se debe cumplir: TipoProducto.Sistema=True)
        /// </summary>
        private void ValidarLogica(TipoOperacion operacion)
        {
            if (operacion== TipoOperacion.Borrado || operacion== TipoOperacion.Actualizacion)
            {
                if (this.Sistema != null && (bool)this.Sistema)
                    throw new LogicException("El tipo de producto: '" + this.Descripcion + "' no se puede cambiar ni eliminar porque forma parte del sistema");                           
                        
            }
        
        }

      

        #endregion


    }
}
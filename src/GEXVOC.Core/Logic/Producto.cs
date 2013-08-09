using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Producto : IClaseBase
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
            ProductoData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            ProductoData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            ProductoData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Producto();
                    break;
                case TipoContexto.Modificacion:
                    rtno = ProductoData.GetProductoOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Producto a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Producto con el id especificado.</returns>
        public static Producto Buscar(int id)
        {
            return ProductoData.GetProducto(id);
        }

        /// <summary>
        /// Obtiene los/las Producto que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Producto> Buscar(int? idTipo,int? idFamilia,string descripcion,decimal? supresionLeche,decimal? supresionCarne,bool? sistema)
        {
            return ProductoData.GetProductos(idTipo, idFamilia, descripcion, supresionLeche, supresionCarne, sistema);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Producto
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Producto> Buscar()
        {
            return ProductoData.GetProductos(null,null,string.Empty,null,null,null);
        }

        public static List<Producto> BuscarProductosSinFamilia(int? idTipo,  string descripcion, decimal? supresionLeche, decimal? supresionCarne)
        {
            return ProductoData.GetProductosSinFamilia(idTipo, descripcion, supresionLeche, supresionCarne);
        }

        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
        ///// </summary>
        //public string DescProvincia { get { return this.Municipio.Provincia.Descripcion; } }

        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Familia a la que pertenece el elemento
        ///// </summary>
        public string DescFamilia
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Familia != null)
                    rtno = this.Familia.Descripcion;

                return rtno;
            }
        }
        public string DescAmpliada
        {
            get
            {
                string rtno = string.Empty;
                if (this != null)
                {
                    if (this.Familia != null)
                        rtno = this.Descripcion + " - FAMILIA: " + this.Familia.Descripcion;
                    else
                        rtno = this.Descripcion;
                }

                return rtno;
            }
        }



        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.

        /// <summary>
        /// Devuelve la lista de composiciones que utilizan un determinado producto.
        /// </summary>
        public List<Composicion> lstComposionAlimenticia
        { get { return Composicion.Buscar(null, this.Id, null); } }
        public List<ProHig> lstProHig
        { get { return Logic.ProHig.Buscar(null,this.Id,null); } }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        private void ValidarLogica(TipoOperacion operacion)
        {
            if (operacion == TipoOperacion.Actualizacion || operacion == TipoOperacion.Borrado)
            {
                if (this.Sistema != null && (bool)this.Sistema)
                    throw new LogicException("El Producto: '" + this.Descripcion + "' no puede ser cambiado ni eliminado porque forma parte del sistema");

            }

            if (operacion == TipoOperacion.Borrado)
            {
                if (this.lstComposionAlimenticia.Count > 0)
                    throw new LogicException("No se puede eliminar este producto ya que está incluido en alguna composición alimenticia");                
                if (Logic.Compra.ProductoExistenteEnCompras(this.Id))
                    throw new LogicException("No se puede eliminar este producto porque ha sido utilizado en alguna compra.");
                if (Logic.Venta.ProductoExistenteEnVentas(this.Id))
                    throw new LogicException("No se puede eliminar este producto porque ha sido utilizado en alguna venta.");
                if (Logic.Stock.ProductoExistenteEnStocks(this.Id))
                    throw new LogicException("No se puede eliminar este producto porque ha sido utilizado en stocks.");
                if (Logic.HistMedicamento.ProductoExistenteEnHistMedicamentos(this.Id))
                    throw new LogicException("No se puede eliminar este medicamento porque ha sido utilizado en el Historial de Medicamentos.");
                if (Logic.Receta.ProductoExistenteEnRecetas(this.Id))
                    throw new LogicException("No se puede eliminar este medicamento porque ha sido utilizado en alguna receta.");
                if (Logic.ProHig.Buscar(null,this.Id,null).Count>0)
                    throw new LogicException("No se puede eliminar el producto: "  + this.Descripcion +  " ya que está incluido en algún Tratamiento de Higiene.");
                if (Logic.ProPro.Buscar(null, this.Id, null).Count > 0)
                    throw new LogicException("No se puede eliminar el producto: " + this.Descripcion + " ya que está incluido en algún Tratamiento de Profilaxis.");
                if (Transformacion.Buscar(this.Id).Count > 0)
                    throw new LogicException("No se puede eliminar el producto: " + this.Descripcion + " ya que está incluido en algún proceso de producción.");                
            }
        }

        #endregion
    }
}
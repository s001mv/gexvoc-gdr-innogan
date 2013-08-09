using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class ProductoQuimico : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            ProductoQuimicoData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ProductoQuimicoData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ProductoQuimicoData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;

            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new ProductoQuimico();//Es una insercion
                    break;
                case TipoContexto.Modificacion:
                    rtno = ProductoQuimicoData.GetProductoQuimicoOP(this.Id);//Es una modificacion
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una ProductoQuimico a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>ProductoQuimico con el id especificado.</returns>
        public static ProductoQuimico Buscar(int id)
        {
            return ProductoQuimicoData.GetProductoQuimico(id);
        }

        /// <summary>
        /// Obtiene los/las ProductoQuimico que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<ProductoQuimico> Buscar(string descripcion)
        {
            return ProductoQuimicoData.GetProductoQuimicos(descripcion);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo ProductoQuimico
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<ProductoQuimico> Buscar()
        {
            return ProductoQuimicoData.GetProductoQuimicos(string.Empty);
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


        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        #endregion


    }
}
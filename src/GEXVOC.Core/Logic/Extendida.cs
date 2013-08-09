using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Extendida : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            ExtendidaData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ExtendidaData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ExtendidaData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Extendida();
                    break;
                case TipoContexto.Modificacion:
                    rtno = ExtendidaData.GetExtendidaOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Extendida a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Extendida con el id especificado.</returns>
        public static Extendida Buscar(int id)
        {
            return ExtendidaData.GetExtendida(id);
        }

        /// <summary>
        /// Obtiene los/las Extendida que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Extendida> Buscar(int? idLactacion, decimal? proteina, decimal? extracto, decimal? leche, decimal? lactosa, decimal? grasa, decimal? proteinaNorm, decimal? extractoNorm, decimal? lecheNorm, decimal? lactosaNorm, decimal? grasaNorm, decimal? proteinaExt, decimal? extractoExt, decimal? lecheExt, decimal? lactosaExt, decimal? grasaExt)
        {
            return ExtendidaData.GetExtendidas(idLactacion,proteina,extracto,leche,lactosa,grasa,proteinaNorm,extractoNorm,lecheNorm,lactosaNorm,grasaNorm,proteinaExt,extractoExt,lecheExt,lactosaExt,grasaExt);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Extendida
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Extendida> Buscar()
        {
            return ExtendidaData.GetExtendidas(null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null);
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
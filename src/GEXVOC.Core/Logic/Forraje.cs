using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Forraje : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            ForrajeData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ForrajeData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ForrajeData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Forraje();//Es una insercion
                    break;
                case TipoContexto.Modificacion:
                    rtno = ForrajeData.GetForrajeOP(this.Id);//Es una modificacion
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Forraje a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Forraje con el id especificado.</returns>
        public static Forraje Buscar(int id)
        {
            return ForrajeData.GetForraje(id);
        }

        /// <summary>
        /// Obtiene los/las Forraje que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Forraje> Buscar(string descripcion)
        {
            return ForrajeData.GetForrajes(descripcion);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Forraje
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Forraje> Buscar()
        {
            return ForrajeData.GetForrajes(string.Empty);
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
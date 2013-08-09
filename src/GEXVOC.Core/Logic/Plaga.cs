using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Plaga : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            PlagaData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            PlagaData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            PlagaData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Plaga();//Es una insercion
                    break;
                case TipoContexto.Modificacion:
                    rtno = PlagaData.GetPlagaOP(this.Id);//Es una modificacion
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Plaga a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Plaga con el id especificado.</returns>
        public static Plaga Buscar(int id)
        {
            return PlagaData.GetPlaga(id);
        }

        /// <summary>
        /// Obtiene los/las Plaga que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Plaga> Buscar(string descripcion)
        {
            return PlagaData.GetPlagas(descripcion);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Plaga
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Plaga> Buscar()
        {
            return PlagaData.GetPlagas(string.Empty);
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
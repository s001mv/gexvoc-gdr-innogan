using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Semilla : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            SemillaData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            SemillaData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            SemillaData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Semilla();
                    break;
                case TipoContexto.Modificacion:
                    rtno = SemillaData.GetSemillaOP(this.Id);
                    break;
            }
            return rtno;
        }


        /// <summary>
        /// Obtiene un/una Semilla a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Semilla con el id especificado.</returns>
        public static Semilla Buscar(int id)
        {
            return SemillaData.GetSemilla(id);
        }

        /// <summary>
        /// Obtiene los/las Semilla que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Semilla> Buscar(int? idFamilia,string descripcion)
        {
            return SemillaData.GetSemillas(idFamilia,descripcion);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Semilla
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Semilla> Buscar()
        {
            return SemillaData.GetSemillas(null,string.Empty);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
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
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        #endregion


    }
}
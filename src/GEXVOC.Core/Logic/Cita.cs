using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Cita : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            CitaData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            CitaData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            CitaData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Cita();
                    break;
                case TipoContexto.Modificacion:
                    rtno = CitaData.GetCitaOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Cita a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Cita con el id especificado.</returns>
        public static Cita Buscar(int id)
        {
            return CitaData.GetCita(id);
        }

        /// <summary>
        /// Obtiene los/las Cita que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Cita> Buscar(int? idExplotacion, int? idContacto, DateTime? fechaMayorIgual,DateTime? fechaMenorIgual, string lugar, string tema)
        {
            return CitaData.GetCitas(idExplotacion,idContacto,fechaMayorIgual,fechaMenorIgual,lugar,tema);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Cita
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Cita> Buscar()
        {
            return CitaData.GetCitas(null,null,null,null,string.Empty,string.Empty);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        /// <summary>
        /// Propiedad que devuelve la descripción de la explotación.
        /// </summary>
        public string DescExplotacion
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Explotacion != null)
                    rtno = this.Explotacion.Nombre;
                return rtno;
            }

        }
        /// <summary>
        /// Propiedad que devuelve el nombre del contacto.
        /// </summary>
        public string DescContacto
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Contacto != null)
                    rtno = this.Contacto.Nombre;
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
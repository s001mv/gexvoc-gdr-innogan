using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class StatusControl : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            StatusControlData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            StatusControlData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            if (lstControlLeche.Count > 0)
                throw new LogicException("No se puede realizar la eliminación ya que el status está asociado a un control.");
            StatusControlData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
               IClaseBase rtno=null;           

                switch (Modo)
                {
                    case TipoContexto.Insercion:
                        rtno = new StatusControl();
                        break;
                    case TipoContexto.Modificacion:
                        rtno = StatusControlData.GetStatusControlOP(this.Id);
                        break;
                }
                return rtno;

        }


        /// <summary>
        /// Obtiene un/una StatusControl a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>StatusControl con el id especificado.</returns>
        public static StatusControl Buscar(int id)
        {
            return StatusControlData.GetStatusControl(id);
        }

        /// <summary>
        /// Obtiene los/las StatusControl que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<StatusControl> Buscar(string codigo,string descripcion)
        {
            return StatusControlData.GetStatusControls(codigo,descripcion);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo StatusControl
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<StatusControl> Buscar()
        {
            return StatusControlData.GetStatusControls(string.Empty,string.Empty);
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
        /// <summary>
        /// Devuelve los controles asociados a un status control.
        /// </summary>
        public List<ControlLeche> lstControlLeche
        { get { return ControlLecheData.GetControlesLeche(null, this.Id, null, null, null, null, null, null); } }


        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        #endregion


    }
}
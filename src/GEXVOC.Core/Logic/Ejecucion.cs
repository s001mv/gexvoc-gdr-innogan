using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Ejecucion : IClaseBase
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
            EjecucionData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            EjecucionData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            EjecucionData.Eliminar(this);
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;

            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Ejecucion();
                    break;
                case TipoContexto.Modificacion:
                    rtno = EjecucionData.GetEjecucionOP(this.Id);
                    break;
            }

            return rtno;
        }

        /// <summary>
        /// Obtiene una plantilla a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Plantilla con el id especificado.</returns>
        public static Ejecucion Buscar(int id)
        {
            return EjecucionData.GetEjecucion(id);
        }

        /// <summary>
        /// Obtiene las plantillas que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param> 
        /// <param name="fecha">Fecha.</param>  
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Ejecucion> Buscar(int? idPlantilla, DateTime? fecha)
        {
            return EjecucionData.GetEjecuciones(idPlantilla, fecha);
        }

        /// <summary>
        /// Obtiene todos los registros de máquinas.
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Ejecucion> Buscar()
        {
            return EjecucionData.GetEjecuciones(null, null);
        }

        #endregion

        #region PROPIEDADES PERSONALIZADAS
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        /// <summary>
        /// Valida la lógica de negocio, concluye si la operacion es admitida.
        /// </summary>
        /// <param name="operacion">Operación realizada.</param>
        private void ValidarLogica(TipoOperacion operacion) { }

        #endregion
    }
}

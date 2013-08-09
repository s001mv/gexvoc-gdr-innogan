using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Zona : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        #endregion

        #region  ACTUALIZACIÓN DE DATOS

        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            this.IdExplotacion = Configuracion.Explotacion.Id;

            ValidarLogica(TipoOperacion.Insercion);
            ZonaData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            ZonaData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            ZonaData.Eliminar(this);
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;

            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Zona();
                    break;
                case TipoContexto.Modificacion:
                    rtno = ZonaData.GetZonaOP(this.Id);
                    break;
            }

            return rtno;
        }

        /// <summary>
        /// Obtiene una máquina a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Máquina con el id especificado.</returns>
        public static Zona Buscar(int id)
        {
            return ZonaData.GetZona(id);
        }

        /// <summary>
        /// Obtiene las zonas que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="idExplotacion">Id de la explotación seleccionada.</param>
        /// <param name="descripcion">Descripción.</param>  
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Zona> Buscar(int idExplotacion, string descripcion)
        {
            return ZonaData.GetZonas(idExplotacion, descripcion);
        }

        /// <summary>
        /// Obtiene las zonas que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="descripcion">Descripción.</param>  
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Zona> Buscar(string descripcion)
        {
            return ZonaData.GetZonas(Configuracion.Explotacion.Id, descripcion);
        }

        /// <summary>
        /// Obtiene todos los registros de zonas.
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Zona> Buscar()
        {
            return ZonaData.GetZonas(Configuracion.Explotacion.Id, string.Empty);
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
        private void ValidarLogica(TipoOperacion operacion)
        {
            if (operacion == TipoOperacion.Borrado && Core.Logic.PlaZon.Buscar(null, this.Id, null, null).Count > 0)
                throw new LogicException("La zona '" + this.Descripcion + "' ha sido/está siendo utilizada en un proceso.");
        }

        #endregion
    }
}
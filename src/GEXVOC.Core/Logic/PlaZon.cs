using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class PlaZon : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        #endregion

        #region  ACTUALIZACIÓN DE DATOS

        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            this.FechaInicio = DateTime.Now;

            ValidarLogica(TipoOperacion.Insercion);
            PlaZonData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            PlaZonData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            if (!this.Plantilla.Ejecutada)
            {
                ValidarLogica(TipoOperacion.Borrado);
                PlaZonData.Eliminar(this);
            }
            else
            {
                PlaZon Zona = PlaZon.Buscar(this.IdPlantilla, this.IdZona, this.FechaInicio);
                Zona.FechaFin = DateTime.Now;
                PlaZonData.Actualizar(Zona);
            }
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;

            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new PlaZon();
                    break;
                case TipoContexto.Modificacion:
                    rtno = PlaZonData.GetPlaZonOP(this.IdPlantilla, this.IdZona, this.FechaInicio);
                    break;
            }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una PlaZon a partir de su id.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="fechaEjecucion">Fecha de ejecución.</param>
        /// <returns>PlaVet con el id especificado.</returns>
        public static List<PlaZon> Buscar(int idPlantilla, DateTime fechaEjecucion)
        {
            return PlaZonData.GetPlaZon(idPlantilla, fechaEjecucion);
        }

        /// <summary>
        /// Obtiene un/una PlaZon a partir de su id.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idZona">Id de la zona.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <returns>PlaZon con el id especificado.</returns>
        public static PlaZon Buscar(int idPlantilla, int idZona, DateTime fechaInicio)
        {
            return PlaZonData.GetPlaZon(idPlantilla, idZona, fechaInicio);
        }

        /// <summary>
        /// Obtiene los/las PlaZon que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idZona">Id de la zona.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <param name="fechaFin">Fecha de fin.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<PlaZon> Buscar(int? idPlantilla, int? idZona, DateTime? fechaInicio, DateTime? fechaFin)
        {
            return PlaZonData.GetPlaZon(idPlantilla, idZona, fechaInicio, fechaFin);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo PlaZon
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<PlaZon> Buscar()
        {
            return PlaZonData.GetPlaZon(null, null, null, null);
        }

        /// <summary>
        /// Obtiene los registros PlaZon actuales de la plantilla.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <returns>PlaVet actuales.</returns>
        public static List<PlaZon> BuscarActuales(int idPlantilla)
        {
            return PlaZonData.GetActuales(idPlantilla);
        }

        #endregion

        #region PROPIEDADES PERSONALIZADAS

        public int Id
        {
            get { return this.IdPlantilla; }
            set { }
        }

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la plantilla.
        ///// </summary>
        public string DescPlantilla
        {
            get
            {
                string rtno = string.Empty;

                if (this != null && this.Plantilla != null)
                    rtno = this.Plantilla.Descripcion.ToString();

                return rtno;
            }
        }

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la zona.
        ///// </summary>
        public string DescZona
        {
            get
            {
                string rtno = string.Empty;

                if (this != null && this.Zona != null)
                    rtno = this.Zona.Descripcion.ToString();

                return rtno;
            }
        }

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
            if (operacion == TipoOperacion.Insercion)
            {
                PlaZon PZ = PlaZonData.GetPlaZonActual(this.IdPlantilla, this.IdZona);

                if (PZ != null)
                    throw new LogicException("La zona '" + PZ.DescZona + "' ya está asignada al proceso '" + PZ.DescPlantilla + "'."); 
            }
        }

        #endregion
    }
}

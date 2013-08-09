using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class PlaMaq : IClaseBase
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
            PlaMaqData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            PlaMaqData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            if (!this.Plantilla.Ejecutada)
            {
                ValidarLogica(TipoOperacion.Borrado);
                PlaMaqData.Eliminar(this);
            }
            else
            {
                PlaMaq Maquina = PlaMaq.Buscar(this.IdPlantilla, this.IdMaquinaria, this.FechaInicio);
                Maquina.FechaFin = DateTime.Now;
                PlaMaqData.Actualizar(Maquina);
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
                    rtno = new PlaMaq();
                    break;
                case TipoContexto.Modificacion:
                    rtno = PlaMaqData.GetPlaMaqOP(this.IdPlantilla, this.IdMaquinaria, this.FechaInicio);
                    break;
            }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una PlaMaq a partir de su id.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="fechaEjecucion">Fecha de ejecución.</param>
        /// <returns>PlaMaq con el id especificado.</returns>
        public static List<PlaMaq> Buscar(int idPlantilla, DateTime fechaEjecucion)
        {
            return PlaMaqData.GetPlaMaq(idPlantilla, fechaEjecucion);
        }

        /// <summary>
        /// Obtiene un/una PlaMaq a partir de su id.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idMaquinaria">Id de la máquina.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <returns>PlaMaq con el id especificado.</returns>
        public static PlaMaq Buscar(int idPlantilla, int idMaquinaria, DateTime fechaInicio)
        {
            return PlaMaqData.GetPlaMaq(idPlantilla, idMaquinaria, fechaInicio);
        }

        /// <summary>
        /// Obtiene los/las PlaMaq que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idMaquinaria">Id de la máquina.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <param name="fechaFin">Fecha de fin.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<PlaMaq> Buscar(int? idPlantilla, int? idMaquinaria, DateTime? fechaInicio, DateTime? fechaFin)
        {
            return PlaMaqData.GetPlaMaq(idPlantilla, idMaquinaria, fechaInicio, fechaFin);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo PlaMaq
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<PlaMaq> Buscar()
        {
            return PlaMaqData.GetPlaMaq(null, null, null, null);
        }

        /// <summary>
        /// Obtiene los registros PlaMaq actuales de la plantilla.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <returns>PlaVet actuales.</returns>
        public static List<PlaMaq> BuscarActuales(int idPlantilla)
        {
            return PlaMaqData.GetActuales(idPlantilla);
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
        ///// Propiedad que devuelve la descripción de la máquina.
        ///// </summary>
        public string DescMaquina
        {
            get
            {
                string rtno = string.Empty;

                if (this != null && this.Maquinaria != null)
                    rtno = this.Maquinaria.Descripcion.ToString();

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
                PlaMaq PM = PlaMaqData.GetPlaMaqActual(this.IdPlantilla, this.IdMaquinaria);

                if (PM != null)
                    throw new LogicException("La máquina '" + PM.DescMaquina + "' ya está asignada al proceso '" + PM.DescPlantilla + "'.");
            }
        }

        #endregion
    }
}

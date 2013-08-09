using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class PlaVet : IClaseBase
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
            PlaVetData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            PlaVetData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            if (!this.Plantilla.Ejecutada)
            {
                ValidarLogica(TipoOperacion.Borrado);
                PlaVetData.Eliminar(this);
            }
            else
            {
                PlaVet Empleado = PlaVet.Buscar(this.IdPlantilla, this.IdPersonal, this.FechaInicio);
                Empleado.FechaFin = DateTime.Now;
                PlaVetData.Actualizar(Empleado);
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
                    rtno = new PlaVet();
                    break;
                case TipoContexto.Modificacion:
                    rtno = PlaVetData.GetPlaVetOP(this.IdPlantilla, this.IdPersonal, this.FechaInicio);
                    break;
            }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una PlaVet a partir de su id.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="fechaEjecucion">Fecha de ejecución.</param>
        /// <returns>PlaVet con el id especificado.</returns>
        public static List<PlaVet> Buscar(int idPlantilla, DateTime fechaEjecucion)
        {
            return PlaVetData.GetPlaVet(idPlantilla, fechaEjecucion);
        }

        /// <summary>
        /// Obtiene un/una PlaVet a partir de su id.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idPersonal">Id del personal.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <returns>PlaVet con el id especificado.</returns>
        public static PlaVet Buscar(int idPlantilla, int idPersonal, DateTime fechaInicio)
        {
            return PlaVetData.GetPlaVet(idPlantilla, idPersonal, fechaInicio);
        }

        /// <summary>
        /// Obtiene los/las PlaVet que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idPersonal">Id del personal.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <param name="fechaFin">Fecha de fin.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<PlaVet> Buscar(int? idPlantilla, int? idPersonal, DateTime? fechaInicio, DateTime? fechaFin)
        {
            return PlaVetData.GetPlaVet(idPlantilla, idPersonal, fechaInicio, fechaFin);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo PlaVet
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<PlaVet> Buscar()
        {
            return PlaVetData.GetPlaVet(null, null, null, null);
        }

        /// <summary>
        /// Obtiene los registros PlaVet actuales de la plantilla.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <returns>PlaVet actuales.</returns>
        public static List<PlaVet> BuscarActuales(int idPlantilla)
        {
            return PlaVetData.GetActuales(idPlantilla);
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
        ///// Propiedad que devuelve la descripción del empleado.
        ///// </summary>
        public string DescEmpleado
        {
            get
            {
                string rtno = string.Empty;

                if (this != null && this.Veterinario != null)
                {
                    rtno = this.Veterinario.Nombre;

                    if (!string.IsNullOrEmpty(this.Veterinario.Apellidos))
                        rtno += " " + this.Veterinario.Apellidos;
                }

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
                PlaVet PV = PlaVetData.GetPlaVetActual(this.IdPlantilla, this.IdPersonal);

                if (PV != null)
                    throw new LogicException("El empleado '" + PV.DescEmpleado + "' ya está asignado al proceso '" + PV.DescPlantilla + "'.");
            }
        }

        #endregion
    }
}

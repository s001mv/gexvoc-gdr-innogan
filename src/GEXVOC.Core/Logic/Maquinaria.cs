using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Maquinaria : IClaseBase
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
            MaquinariaData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            MaquinariaData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            MaquinariaData.Eliminar(this);
        }
        
        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;

            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Maquinaria();
                    break;
                case TipoContexto.Modificacion:
                    rtno = MaquinariaData.GetMaquinariaOP(this.Id);
                    break;
            }

            return rtno;
        }

        /// <summary>
        /// Obtiene una máquina a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Máquina con el id especificado.</returns>
        public static Maquinaria Buscar(int id)
        {
            return MaquinariaData.GetMaquinaria(id);
        }

        /// <summary>
        /// Obtiene las máquinas que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="descripcion">Descripción.</param>  
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Maquinaria> Buscar(int idExplotacion, string descripcion)
        {
            return MaquinariaData.GetMaquinas(idExplotacion, descripcion);
        }

        /// <summary>
        /// Obtiene las máquinas que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="descripcion">Descripción.</param>  
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Maquinaria> Buscar(string descripcion)
        {
            return MaquinariaData.GetMaquinas(Configuracion.Explotacion.Id, descripcion);
        }

        /// <summary>
        /// Obtiene todos los registros de máquinas.
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Maquinaria> Buscar()
        {
            return MaquinariaData.GetMaquinas(Configuracion.Explotacion.Id, string.Empty);
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
            if (operacion == TipoOperacion.Borrado && Core.Logic.PlaMaq.Buscar(null, this.Id, null, null).Count > 0)
                throw new LogicException("La máquina '" + this.Descripcion + "' ha sido/está siendo utilizada en un proceso.");
        }

        #endregion
    }
}
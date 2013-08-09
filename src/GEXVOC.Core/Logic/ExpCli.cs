using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class ExpCli : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        #endregion

        #region  ACTUALIZACIÓN DE DATOS

        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            ComprobarExistenciaDuplicados();
            ExpCliData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {          
            ExpCliData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ExpCliData.Eliminar(this);
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;       

            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new ExpCli();
                    break;
                case TipoContexto.Modificacion:
                    rtno = ExpCliData.GetExpCliOP(this.IdExplotacion, this.IdCliente);
                    break;
            }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una ExpCli a partir de su id.
        /// </summary>
        /// <returns>ExpCli con el id especificado.</returns>
        public static ExpCli Buscar(int idExplotacion, int idCliente)
        {
            return ExpCliData.GetExpCli(idExplotacion, idCliente);
        }

        /// <summary>
        /// Obtiene los/las ExpCli que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<ExpCli> Buscar(int? idExplotacion, int? idCliente, DateTime? fechaInicio, DateTime? fechaFin)
        {
            return ExpCliData.GetExpClis(idExplotacion, idCliente, fechaInicio, fechaFin);
        }

        #endregion

        #region PROPIEDADES PERSONALIZADAS

        public string DescCliente { 
            get 
            {
                string rtno = string.Empty;

                if (this != null && this.Cliente != null)
                    rtno = this.Cliente.Nombre;

                return rtno;
            } 
        }

        public int Id
        {
            get { return this.IdCliente; }
            set { }
        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
        
        void ComprobarExistenciaDuplicados()
        {
            if (ExpCli.Buscar(this.IdExplotacion, this.IdCliente, null, null).Count != 0)
                throw new LogicException("La relación entre la explotación: '" + Explotacion.Buscar(this.IdExplotacion).Nombre + "' y el Cliente: '" + Cliente.Buscar(this.IdCliente).Nombre + "' ya existe y no puede ser duplicada.");
        }

        #endregion
    }
}
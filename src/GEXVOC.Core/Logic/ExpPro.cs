using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class ExpPro : IClaseBase
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
            ExpProData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ExpProData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ExpProData.Eliminar(this);
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;       

            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new ExpPro();
                    break;
                case TipoContexto.Modificacion:
                    rtno = ExpProData.GetExpProOP(this.IdExplotacion, this.IdProveedor);
                    break;
            }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una ExpPro a partir de su id.
        /// </summary>
        /// <returns>ExpPro con el id especificado.</returns>
        public static ExpPro Buscar(int idExplotacion, int idProveedor)
        {
            return ExpProData.GetExpPro(idExplotacion, idProveedor);
        }

        /// <summary>
        /// Obtiene los/las ExpPro que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<ExpPro> Buscar(int? idExplotacion, int? idProveedor, DateTime? fechaInicio, DateTime? fechaFin)
        {
            return ExpProData.GetExpPros(idExplotacion, idProveedor, fechaInicio, fechaFin);
        }

        #endregion

        #region PROPIEDADES PERSONALIZADAS

        ///// <summary>
        ///// Descripción del proveedor.
        ///// </summary>
        public string DescProveedor { 
            get 
            {
                string rtno = string.Empty;

                if (this != null && this.Proveedor != null)
                    rtno = this.Proveedor.Nombre;

                return rtno;
            } 
        }

        public int Id
        {
            get { return this.IdProveedor; }
            set { }
        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        void ComprobarExistenciaDuplicados()
        {
            if (ExpPro.Buscar(this.IdExplotacion, this.IdProveedor, null, null).Count != 0)
                throw new LogicException("La relación entre la Explotación: '" + Explotacion.Buscar(this.IdExplotacion).Nombre + "' y el Proveedor: '" + Proveedor.Buscar(this.IdProveedor).Nombre + "' ya existe y no puede ser duplicada.");
        }

        #endregion
    }
}
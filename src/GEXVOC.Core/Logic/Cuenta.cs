using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Cuenta : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            CuentaData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            CuentaData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            CuentaData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Cuenta();
                    break;
                case TipoContexto.Modificacion:
                    rtno = CuentaData.GetCuentaOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Cuenta a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Cuenta con el id especificado.</returns>
        public static Cuenta Buscar(int id)
        {
            return CuentaData.GetCuenta(id);
        }

        /// <summary>
        /// Obtiene los/las Cuenta que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Cuenta> Buscar(int? idTitular,string banco,string sucursal,string numero)
        {
            return CuentaData.GetCuentas(idTitular,banco,sucursal,numero);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Cuenta
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Cuenta> Buscar()
        {
            return CuentaData.GetCuentas(null, string.Empty, string.Empty,string.Empty);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
        ///// </summary>
        //public string DescProvincia { get { return this.Municipio.Provincia.Descripcion; } }

        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Titular a la que pertenece el elemento
        ///// </summary>
        public string DescTitular
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Titular != null)
                    rtno = this.Titular.NombreCompleto;

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class ConformacionCanal : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            ConformacionCanalData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ConformacionCanalData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ConformacionCanalData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new ConformacionCanal();
                    break;
                case TipoContexto.Modificacion:
                    rtno = ConformacionCanalData.GetConformacionCanalOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una ConformacionCanal a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>ConformacionCanal con el id especificado.</returns>
        public static ConformacionCanal Buscar(int id)
        {
            return ConformacionCanalData.GetConformacionCanal(id);
        }

        /// <summary>
        /// Obtiene los/las ConformacionCanal que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<ConformacionCanal> Buscar(char? codigo, string descripcion,string detalle)
        {
            return ConformacionCanalData.GetConformacionesCanal(codigo, descripcion, detalle);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo ConformacionCanal
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<ConformacionCanal> Buscar()
        {
            return ConformacionCanalData.GetConformacionesCanal(null,string.Empty,string.Empty);
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


        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        #endregion


    }
}

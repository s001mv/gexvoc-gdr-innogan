using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Racion : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            RacionData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            RacionData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            if (this.lstComposicion.Count>0)            
                throw new LogicException("No es posible eliminar la ración: " + this.Descripcion + " porque tiene al menos una composición.");
            
            RacionData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;          
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Racion();
                    break;
                case TipoContexto.Modificacion:
                    rtno = RacionData.GetRacionOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Racion a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Racion con el id especificado.</returns>
        public static Racion Buscar(int id)
        {
            return RacionData.GetRacion(id);
        }

        /// <summary>
        /// Obtiene los/las Racion que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Racion> Buscar(string descripcion,decimal? peso)
        {
            return RacionData.GetRaciones(descripcion,peso);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Racion
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Racion> Buscar()
        {
            return RacionData.GetRaciones(string.Empty,null);
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

        public List<Composicion> lstComposicion
        {
            get { return Composicion.Buscar(this.Id,null,null); }

        }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
     
        #endregion


    }
}
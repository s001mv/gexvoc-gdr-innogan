using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class TipoEnfermedad : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            TipoEnfermedadData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            TipoEnfermedadData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            if (lstEnfermedad.Count > 0)
                throw new LogicException("No se puede realizar la eliminación ya que el tipo está asociado a una enfermedad.");

            TipoEnfermedadData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;      

              switch (Modo)
                {
                    case TipoContexto.Insercion:
                        rtno = new TipoEnfermedad();
                        break;
                    case TipoContexto.Modificacion:
                        rtno = TipoEnfermedadData.GetTipoEnfermedadOP(this.Id);
                        break;
                }
                return rtno;


        }


        /// <summary>
        /// Obtiene un/una TipoEnfermedad a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>TipoEnfermedad con el id especificado.</returns>
        public static TipoEnfermedad Buscar(int id)
        {
            return TipoEnfermedadData.GetTipoEnfermedad(id);
        }

        /// <summary>
        /// Obtiene los/las TipoEnfermedad que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<TipoEnfermedad> Buscar(string descripcion)
        {
            return TipoEnfermedadData.GetTiposEnfermedades(descripcion);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo TipoEnfermedad
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<TipoEnfermedad> Buscar()
        {
            return TipoEnfermedadData.GetTiposEnfermedades(string.Empty);
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
        /// <summary>
        /// Obtiene las enfermedades de un determinado tipo.
        /// </summary>
        public List<Enfermedad> lstEnfermedad
        { get { return Enfermedad.Buscar(this.Id, string.Empty); } }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        #endregion


    }
}

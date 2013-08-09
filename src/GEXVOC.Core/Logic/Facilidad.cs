using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Facilidad : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            FacilidadData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            FacilidadData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            if (lstParto.Count == 0)
            {
                if (this.Sistema == null || this.Sistema.Value == false)
                    FacilidadData.Eliminar(this);
                else
                    throw new LogicException("No se puede realizar la eliminación ya que el tipo es necesario para el correcto funcionamiento del sistema.");
            }
            if (lstParto.Count > 0)
                throw new LogicException("No se puede realizar la eliminación ya que el tipo está asociado a un parto.");

        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno=null;

            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Facilidad();//Es una insercion
                    break;
                case TipoContexto.Modificacion:
                    rtno = FacilidadData.GetFacilidadOP(this.Id);//Es una modificacion
                    break;
            }
            return rtno;
        }


        /// <summary>
        /// Obtiene un/una Facilidad a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Facilidad con el id especificado.</returns>
        public static Facilidad Buscar(int id)
        {
            return FacilidadData.GetFacilidad(id);
        }

        /// <summary>
        /// Obtiene los/las Facilidad que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Facilidad> Buscar(string descripcion,Boolean? sistema)
        {
            return FacilidadData.GetFacilidades(descripcion, sistema);
        }

        public static List<Facilidad> Buscar()
        {
            return FacilidadData.GetFacilidades(string.Empty, null);
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
        /// Devuelve los partos asociados a un tipo de facilidad de parto.
        /// </summary>
        public List<Parto> lstParto
        { get { return PartoData.GetPartos(null, null, this.Id,null,null,null,null, null); } }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        #endregion


    }
}
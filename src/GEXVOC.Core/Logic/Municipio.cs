using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Municipio : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            MunicipioData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            MunicipioData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            if (lstExplotacion.Count > 0)
                throw new LogicException("No se puede eliminar el Municipio ya que está asociado a una explotación");

            MunicipioData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        { 
               IClaseBase rtno=null;           
                switch (Modo)
                {
                    case TipoContexto.Insercion:
                        rtno = new Municipio();//Es una insercion
                        break;
                    case TipoContexto.Modificacion:
                        rtno = MunicipioData.GetMunicipioOP(this.Id);//Es una modificacion
                        break;
                }
                return rtno;

        }


        /// <summary>
        /// Obtiene un/una Municipio a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Municipio con el id especificado.</returns>
        public static Municipio Buscar(int id)
        {
            return MunicipioData.GetMunicipio(id);
        }

        /// <summary>
        /// Obtiene los/las Municipio que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Municipio> Buscar(string codigo,string descripcion, int? idProvincia)
        {

            return MunicipioData.GetMunicipios(codigo, descripcion, idProvincia);
        }
        public static List<Municipio> Buscar()
        {
            return MunicipioData.GetMunicipios(string.Empty, string.Empty, null);
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
        /// Devuelve la colección de explotaciones pertenecientes a un municipio.
        /// </summary>
        public List<Explotacion> lstExplotacion
        {
            get { return ExplotacionData.GetExplotaciones(string.Empty,string.Empty,string.Empty,null,this.Id,null); }
        }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        #endregion


    }
}
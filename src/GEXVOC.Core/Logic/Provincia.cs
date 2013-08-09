using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;


namespace GEXVOC.Core.Logic
{
    public partial class Provincia : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            ProvinciaData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ProvinciaData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {

            if (lstMunicipio.Count > 0)            
                throw new LogicException("No se puede eliminar la provincia ya que tiene municipios asociados");
            

            ProvinciaData.Eliminar(this);
         
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
               IClaseBase rtno=null;
                switch (Modo)
                {
                    case TipoContexto.Insercion:
                        rtno = new Provincia();//Es una insercion
                        break;
                    case TipoContexto.Modificacion:
                        rtno = ProvinciaData.GetProvinciaOP(this.Id);//Es una modificacion
                        break;
                }
                return rtno;

        }


        /// <summary>
        /// Obtiene un/una Provincia a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Provincia con el id especificado.</returns>
        public static Provincia Buscar(int id)
        {
            return ProvinciaData.GetProvincia(id);
        }

        /// <summary>
        /// Obtiene los/las Provincia que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Provincia> Buscar(string codigo, string descripcion)
        {
            return ProvinciaData.GetProvincias(codigo, descripcion);
        }

        public static List<Provincia> Buscar()
        {
            return ProvinciaData.GetProvincias(string.Empty, string.Empty);
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
        /// Devuelve la colección de municipios asociados a una provincia.
        /// </summary>
        public List<Municipio> lstMunicipio
        {
            get { return MunicipioData.GetMunicipios(string.Empty, string.Empty, this.Id); }
            
        }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
   
     
        #endregion


    }
}
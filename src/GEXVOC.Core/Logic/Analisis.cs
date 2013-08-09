using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Analisis : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            AnalisisData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            AnalisisData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            AnalisisData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Analisis();
                    break;
                case TipoContexto.Modificacion:
                    rtno = AnalisisData.GetAnalisisOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Analisis a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Analisis con el id especificado.</returns>
        public static Analisis Buscar(int id)
        {
            return AnalisisData.GetAnalisis(id);
        }

        /// <summary>
        /// Obtiene los/las Analisis que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Analisis> Buscar(int? idTipoAnalisis, int? idAnimal, int? idLaboratorio, DateTime? fecha, string registro, Boolean? filiacion)
        {
            return AnalisisData.GetAnalisis(idTipoAnalisis,idAnimal,idLaboratorio,fecha,registro,filiacion);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Analisis
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Analisis> Buscar()
        {
            return AnalisisData.GetAnalisis(null,null,null,null,string.Empty,null);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        /// <summary>
        /// Propiedad que devuelve la descripcion del tipo de analisis para mostrar en el DataGrid.
        /// </summary>
        public string DescTipo
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Tipo != null)
                    rtno = this.Tipo.Descripcion;
                return rtno;

            }
        }
        /// <summary>
        /// Propiedad que devuelve el nombre del animal.
        /// </summary>
        public string DescAnimal
        {
            get 
            {
                string rtno = string.Empty;
                if (this != null && this.Animal != null)
                    rtno = this.Animal.Nombre;
                return rtno;
            
            }
        
        }
        /// <summary>
        /// Propiedad que devuelve el nombre del laboratorio.
        /// </summary>
        public string DescLaboratorio
        {

            get 
            {
                string rtno = string.Empty;
                if (this != null && this.Laboratorio != null)
                    rtno = this.Laboratorio.Nombre;
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

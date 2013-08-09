using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Combinacion : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            CombinacionData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            CombinacionData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            CombinacionData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Combinacion();
                    break;
                case TipoContexto.Modificacion:
                    rtno = CombinacionData.GetCombinacionOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Combinacion a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Combinacion con el id especificado.</returns>
        public static Combinacion Buscar(int id)
        {
            return CombinacionData.GetCombinacion(id);
        }

        /// <summary>
        /// Obtiene los/las Combinacion que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Combinacion> Buscar(int? idMarcador1, int? idMarcador2, string grupo, string riesgo)
        {
            return CombinacionData.GetCombinaciones(idMarcador1,idMarcador2,grupo,riesgo);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Combinacion
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Combinacion> Buscar()
        {
            return CombinacionData.GetCombinaciones(null,null,string.Empty,string.Empty);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        public string DescMarcador1
        {
            get 
            {
                string rtno = string.Empty;
                if (this != null && this.Marcador1 != null)
                    rtno = this.Marcador1.Marcador1;
                return rtno;
            
            }
        }

        public string DescMarcador2
        {
            get 
            {
                string rtno = string.Empty;
                if (this != null && this.Marcador2 != null)
                    rtno = this.Marcador2.Marcador1;
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

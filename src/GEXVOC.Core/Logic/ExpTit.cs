using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class ExpTit : IClaseBase
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
            ExpTitData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {          
            ExpTitData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ExpTitData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;       

            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new ExpTit();//Es una insercion
                    break;
                case TipoContexto.Modificacion:
                    rtno = ExpTitData.GetExpTitOP(this.IdExplotacion, this.IdTitular);//Es una modificacion
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una ExpTit a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>ExpTit con el id especificado.</returns>
        public static ExpTit Buscar(int idExplotacion,int idTitular)
        {
            return ExpTitData.GetExpTit(idExplotacion, idTitular);
        }

        /// <summary>
        /// Obtiene los/las ExpTit que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<ExpTit> Buscar(int? idExplotacion, int? idTitular, DateTime? fechaInicio, DateTime? fechaFin)
        {
            return ExpTitData.GetExpTits(idExplotacion, idTitular, fechaInicio, fechaFin);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo ExpTit
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        //public static List<ExpTit> Buscar()
        //{
        //    return ExpTitData.GetExpTits(string.Empty);
        //}



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
        ///// </summary>
        public string DescTitular { 
            get 
            {
                string rtno = string.Empty;
                if (this != null && this.Titular != null)
                    rtno = this.Titular.Nombre;
                return rtno;
            } 
        
        }
        public int Id
        {
            get { return this.IdTitular; }
            set { }

        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
        void ComprobarExistenciaDuplicados()
        {
        
            if (ExpTit.Buscar(this.IdExplotacion, this.IdTitular,null,null).Count != 0)//Busco a ver si existe un registro con los valores que voy a añadir
            {
                throw new LogicException("La relación entre la explotación: '" + Explotacion.Buscar(this.IdExplotacion).Nombre + "' y el Titular: '" + Titular.Buscar(this.IdTitular).Nombre + " " + Titular.Buscar(this.IdTitular).Apellidos + "' ya existe y no puede ser duplicada.");
               
            }
            
            
            //return rtno;
        }
        #endregion


    }
}
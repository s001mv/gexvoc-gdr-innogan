using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class ExpEsp : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            this.ComprobarExistenciaDuplicados();
            ExpEspData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
          throw new NotImplementedException();
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ExpEspData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
                switch (Modo)
                {
                    case TipoContexto.Insercion:
                        rtno = new ExpEsp();
                        break;     
                    case TipoContexto.Modificacion:
                        rtno = ExpEspData.GetExpEspOP(this.IdEspecie, this.IdExplotacion);
                        break;     

                }
                return rtno;

        }

        /// <summary>
        /// Obtiene un/una ExpEsp a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>ExpEsp con el id especificado.</returns>
        public static ExpEsp Buscar(int id)
        {
            return ExpEspData.GetExpEsp(id);
        }

        /// <summary>
        /// Obtiene los/las ExpEsp que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<ExpEsp> Buscar(int? idExplotacion, int? idEspecie)
        {
            return ExpEspData.GetExpEsp(idExplotacion, idEspecie);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo ExpEsp
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        //public static List<ExpEsp> Buscar()
        //{
        //    return ExpEspData.GetExpEsps(string.Empty);
        //}



        #endregion   

       

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
            public string DescExplotacion
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.Explotacion !=null)
                        rtno = this.Explotacion.Nombre;

                    return rtno;
                }
            }
            public string DescEspecie
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.Especie != null)
                        rtno = this.Especie.Descripcion;

                    return rtno;
                }
            }

            public int Id
            {
                get { return this.IdEspecie; }
                set{}
                
            }
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
            void ComprobarExistenciaDuplicados()
            {
                //List<ExpEsp> Lista=ExpEsp.Buscar(this.IdExplotacion, this.IdEspecie);
                //if (Lista.Count != 0)//Busco a ver si existe un registro con los valores que voy a añadir
                //    throw new LogicException("La relación entre la explotación : '" + Lista.First().DescExplotacion + "' y la Especie: '" + Lista.First().DescEspecie + "' ya existe y no puede ser duplicada.");

                //#OPTIMO Más optimizado pero menos informativo
                if (ExpEsp.Buscar(this.IdExplotacion, this.IdEspecie).Count != 0)//Busco a ver si existe un registro con los valores que voy a añadir
                    throw new LogicException("La relación entre la Explotación y la Especie, ya existe y no puede ser duplicada.");
            }

            partial void OnValidate(System.Data.Linq.ChangeAction action)
            {
                //throw new NotImplementedException();
            }
        #endregion

    }
}
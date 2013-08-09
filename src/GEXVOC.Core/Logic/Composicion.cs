using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    /// <summary>
    /// Provee la funcionalidad de composiciones    
    /// </summary>
    public partial class Composicion : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            ValidarRacion();
            ValidarDuplicados();
            ValidarPorcentaje();           
            ComposicionData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarRacion();
            ValidarPorcentaje();
            ValidarRacion();
            ComposicionData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            
            ValidarRacion();
            ComposicionData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Composicion();
                    break;
                case TipoContexto.Modificacion:
                    rtno = ComposicionData.GetComposicionOP(this.IdRacion, this.IdAlimento);
                    break;  
                default:
                    rtno=null;
                    break;  
            }
    
            //IClaseBase rtno = null;
            //if (this.IdRacion != 0 && this.IdAlimento!=0)
            //    rtno = ComposicionData.GetComposicionOP(this.IdRacion,this.IdAlimento);//Es una modificacion                           
            
            //if (rtno==null)
            //    rtno = new Composicion();//Es una insercion

            return rtno;
        }


        /// <summary>
        /// Obtiene un/una Composicion a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Composicion con el id especificado.</returns>
        public static Composicion Buscar(int idRacion,int idAlimento)
        {
            return ComposicionData.GetComposicion(idRacion,idAlimento);
        }

        /// <summary>
        /// Obtiene los/las Composicion que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Composicion> Buscar(int? idRacion, int? idAlimento,decimal? porcentaje)
        {
            return ComposicionData.GetComposiciones(idRacion,idAlimento,porcentaje);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Composicion
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Composicion> Buscar()
        {
            return ComposicionData.GetComposiciones(null,null,null);
        }

         public int Id
        {
            get { return this.IdAlimento; }
            set { }

        }

        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
        ///// </summary>
        //public string DescProvincia { get { return this.Municipio.Provincia.Descripcion; } }


         
         ///// <summary>
         ///// Propiedad que devuelve la descripción de el/la Alimento a la que pertenece el elemento
         ///// </summary>
         public string DescAlimento
         {
             get
             {
                 string rtno = string.Empty;
                 if (this != null && this.Alimento != null)
                     rtno = this.Alimento.Descripcion;

                 return rtno;
             }
         }

         
         ///// <summary>
         ///// Propiedad que devuelve la descripción de el/la Familia a la que pertenece el elemento
         ///// </summary>
         public string DescFamilia
         {
             get
             {
                 string rtno = string.Empty;
                 if (this != null && this.Alimento != null && this.Alimento.Familia!=null)
                     rtno = this.Alimento.Familia.Descripcion;

                 return rtno;
             }
         }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.

         
        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

            /// <summary>
            /// Lanza una excepción si se intentan añadir o modificar elementos para un IdRacion concreto
            /// que superen el porcentaje (100%)
            /// Se utiliza en inserciones y modificaciones.
            /// </summary>
            void ValidarPorcentaje()          
            {
                 decimal porcentaje=0;
                 List<Composicion>lstComposiciones= Composicion.Buscar(this.IdRacion, null, null);
                 foreach (var item in lstComposiciones)             
                     if (item.IdAlimento != this.IdAlimento)
                         porcentaje += item.Porcentaje;
                 porcentaje += this.Porcentaje;

                 if (porcentaje > 100)
                     throw new LogicException("El porcentaje por ración no puede superar el 100%, el proceso no puede ser completado.");
                 
            }

             
            /// <summary>
            /// Lanza una excepción si se detecta un registro con el mismo IdRacion e IdAlimento que uno existente.
            /// Solo es utilizada en la insercion, ya que no es posible modificar idracion ni idalimento por ser parte de la clave
            /// </summary>
            void ValidarDuplicados()
            {
                 List<Composicion> lstComposiciones = Composicion.Buscar(this.IdRacion, this.IdAlimento, null);
                 if (lstComposiciones.Count != 0)
                     throw new LogicException("La relación entre la ración y el alimento ya existe");
             
            }

            /// <summary>
            /// Lanza una escepcion si la ración esta siendo utilizada en alguna asignacion alimimenticia, ya que en este caso
            /// no es posible añadir, borrar ni eliminar composiciones a esta racion.
            /// </summary>
            void ValidarRacion()
            {
                List<Asignacion> lstAsignaciones = Asignacion.Buscar(this.IdRacion, null, null, null, null, null);
                if (lstAsignaciones.Count != 0)
                    throw new LogicException("No es posible la operación, porque la ración se encuentra bloqueada por haber sido utilizada en alguna asignación");
                            
            }


        #endregion


    }
}
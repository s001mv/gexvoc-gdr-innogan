using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class TipoInseminacion : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            ValidarLogica(TipoOperacion.Insercion);
            TipoInseminacionData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            TipoInseminacionData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            if(lstInseminacion.Count==0)
            {
                if (this.Sistema == null || this.Sistema.Value == false)
                    TipoInseminacionData.Eliminar(this);
                else
                    throw new LogicException("No se puede realizar la eliminación ya que el tipo es necesario para el correcto funcionamiento del sistema.");

            }
            if (lstInseminacion.Count > 0)
                throw new LogicException("No se puede realizar la eliminación ya que el tipo tiene inseminaciones asociadas");
  
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno=null;           
                switch (Modo)
                {
                    case TipoContexto.Insercion:
                        rtno = new TipoInseminacion();
                        break;
                    case TipoContexto.Modificacion:
                        rtno = TipoInseminacionData.GetTipoInseminacionOP(this.Id);
                        break;
                }
                return rtno;

        }


        /// <summary>
        /// Obtiene un/una TipoInseminacion a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>TipoInseminacion con el id especificado.</returns>
        public static TipoInseminacion Buscar(int id)
        {
            return TipoInseminacionData.GetTiposInseminaciones(id);
        }

        /// <summary>
        /// Obtiene los/las TipoInseminacion que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<TipoInseminacion> Buscar(string descripcion,bool? sistema)
        {
            return TipoInseminacionData.GetTiposInseminaciones(descripcion, sistema);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo TipoInseminacion
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<TipoInseminacion> Buscar()
        {
            return TipoInseminacionData.GetTiposInseminaciones(string.Empty,null);
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
        /// Devuelve todas las inseminaciones pertenecientes a un tipo de inseminación.
        /// </summary>
        public List<Inseminacion> lstInseminacion
        { get { return InseminacionData.GetInseminaciones(null, null, this.Id,  null, null, null, null, null); } }


        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
        private void ValidarLogica(TipoOperacion operacion)
        {
            if (operacion==TipoOperacion.Borrado || operacion==TipoOperacion.Actualizacion)
            {
                if (this.Sistema!=null && (bool)this.Sistema)                
                throw new LogicException("El tipo de inseminación: '" + this.Descripcion + "' no se puede cambiar ni eliminar porque forma parte del sistema");                                   
                
            }
        }

    

        #endregion


    }
}
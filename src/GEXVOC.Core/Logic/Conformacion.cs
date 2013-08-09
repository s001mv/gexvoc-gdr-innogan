using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Conformacion : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            ConformacionData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ConformacionData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            if (lstParto.Count > 0)
                throw new LogicException("No se puede realizar la eliminación ya que la conformación está asociada a un parto.");

            ConformacionData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
               IClaseBase rtno=null;  


                switch (Modo)
                {
                    case TipoContexto.Insercion:
                        rtno = new Conformacion();//Es una insercion
                        break;
                    case TipoContexto.Modificacion:
                        rtno = ConformacionData.GetConformacionOP(this.Id);//Es una modificacion
                        break;
                    default:
                        rtno = null;
                        break;
                }
                return rtno;

        }


        /// <summary>
        /// Obtiene un/una Conformacion a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Conformacion con el id especificado.</returns>
        public static Conformacion Buscar(int id)
        {
            return ConformacionData.GetConformacion(id);
        }

        /// <summary>
        /// Obtiene los/las Conformacion que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Conformacion> Buscar(string descripcion)
        {
            return ConformacionData.GetConformaciones(descripcion);
        }
        public static List<Conformacion> Buscar()
        {
            return ConformacionData.GetConformaciones(string.Empty);
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
        /// Devuelve las partos asociados a una determinada conformación.
        /// </summary>
        public List<Parto> lstParto
        { get { return PartoData.GetPartos(null,  null, this.Id,null,null, null,null, null); } }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        #endregion


    }
}

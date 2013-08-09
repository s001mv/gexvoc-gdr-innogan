using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Enfermedad : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            EnfermedadData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            EnfermedadData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            EnfermedadData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;     

            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Enfermedad();//Es una insercion
                    break;
                case TipoContexto.Modificacion:
                    rtno = EnfermedadData.GetEnfermedadOP(this.Id);//Es una modificacion
                    break;                
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Enfermedad a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Enfermedad con el id especificado.</returns>
        public static Enfermedad Buscar(int id)
        {
            return EnfermedadData.GetEnfermedad(id);
        }

        /// <summary>
        /// Obtiene los/las Enfermedad que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Enfermedad> Buscar(int? idTipo, string descripcion)
        {
            return EnfermedadData.GetEnfermedades(idTipo,descripcion);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Enfermedad
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Enfermedad> Buscar()
        {
            return EnfermedadData.GetEnfermedades(null,string.Empty);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        /// <summary>
        /// Propiedad que devuelve la descripción del tipo de enfermedad.
        /// </summary>
        public string DescTipoEnfermedad
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Tipo != null)
                    rtno = this.Tipo.Descripcion;
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

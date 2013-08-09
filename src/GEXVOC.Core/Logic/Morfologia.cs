using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Morfologia : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            MorfologiaData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            MorfologiaData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            MorfologiaData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
             IClaseBase rtno=null;       

                switch (Modo)
                {
                    case TipoContexto.Insercion:
                        rtno = new Morfologia();
                        break;
                    case TipoContexto.Modificacion:
                        rtno = MorfologiaData.GetMorfologiaOP(this.Id);
                        break;
                }
                return rtno;

        }


        /// <summary>
        /// Obtiene un/una Morfologia a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Morfologia con el id especificado.</returns>
        public static Morfologia Buscar(int id)
        {
            return MorfologiaData.GetMorfologia(id);
        }
        public static List<Morfologia> Buscar(int? id,int? idAnimal)
        {
            return MorfologiaData.GetMorfologias(id, idAnimal);
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


        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        #endregion


    }
}
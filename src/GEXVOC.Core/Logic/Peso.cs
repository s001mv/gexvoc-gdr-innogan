using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Peso : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            PesoData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            PesoData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            PesoData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;

            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Peso();
                    break;
                case TipoContexto.Modificacion:
                    rtno = PesoData.GetPesoOP(this.Id);
                    break;
            }
            return rtno;


        }


        /// <summary>
        /// Obtiene un/una Peso a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Peso con el id especificado.</returns>
        public static Peso Buscar(int id)
        {
            return PesoData.GetPeso(id);
        }

        /// <summary>
        /// Obtiene los/las Peso que coinciden con los criterios de búsqueda.
        /// </summary>       
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Peso> Buscar(int? idAnimal, decimal? peso, DateTime? fecha, int? idMomento,bool? modificable)
        {
                return PesoData.GetPesos( idAnimal,  peso, fecha,idMomento, modificable);
        }

        public static List<Peso> Buscar(int? idAnimal, decimal? peso, DateTime? fechaInicio,DateTime? fechaFin, int? idMomento, bool? modificable)
        {
            return PesoData.GetPesos(idAnimal, peso, fechaInicio,fechaFin, idMomento, modificable);
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
        ///// Propiedad que devuelve la descripción de el/la Momento a la que pertenece el elemento
        ///// </summary>
        public string DescMomentoPeso
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Momento != null)
                    rtno = this.Momento.Descripcion;

                return rtno;
            }
        }
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

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        #endregion


    }
}
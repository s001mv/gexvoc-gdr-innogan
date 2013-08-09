using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Raza : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            RazaData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            RazaData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            if (lstAnimal.Count > 0)
                throw new LogicException("No se puede realizar la eliminación ya que la raza tiene animales asociados.");

            RazaData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
               IClaseBase rtno=null;             
                switch (Modo)
                {
                    case TipoContexto.Insercion:
                        rtno = new Raza();
                        break;
                    case TipoContexto.Modificacion:
                        rtno = RazaData.GetRazaOP(this.Id);
                        break;
                }
                return rtno;


        }


        /// <summary>
        /// Obtiene un/una Raza a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Raza con el id especificado.</returns>
        public static Raza Buscar(int id)
        {
            return RazaData.GetRaza(id);
        }
        

        /// <summary>
        /// Obtiene los/las Raza que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Raza> Buscar(string descripcion, int? idEspecie)
        {

            return RazaData.GetRazas(descripcion, idEspecie);
        }

        public static List<Raza> Buscar()
        {
            return RazaData.GetRazas(string.Empty,null);
        }


        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
        ///// </summary>
        //public string DescProvincia { get { return this.Municipio.Provincia.Descripcion; } }

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
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.
        /// <summary>
        /// Devuelve la lista de los animales pertenecientes a una raza.
        /// </summary>
        public List<Animal> lstAnimal
        { get { return Logic.Animal.Buscar(null,   this.Id, null, null, null, null,  string.Empty, string.Empty, string.Empty, string.Empty, null, null, null, null,null,null); } }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        #endregion


    }
}

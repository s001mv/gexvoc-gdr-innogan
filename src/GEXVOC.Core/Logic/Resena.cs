using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Resena : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            ResenaData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ResenaData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ResenaData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Resena();
                    break;
                case TipoContexto.Modificacion:
                    rtno = ResenaData.GetResenaOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Resena a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Resena con el id especificado.</returns>
        public static Resena Buscar(int id)
        {
            return ResenaData.GetResena(id);
        }

        /// <summary>
        /// Obtiene los/las Resena que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Resena> Buscar(int? idAnimal, int? idVeterinario, string lugar, DateTime? fecha)
        {
            return ResenaData.GetResenas(idAnimal,idVeterinario,lugar,fecha);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Resena
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Resena> Buscar()
        {
            return ResenaData.GetResenas(null,null,string.Empty,null);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID
        /// <summary>
        /// Propiedad que nos devuelve el nombre del animal para mostrar en el DataGrid.
        /// </summary>
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
        /// <summary>
        /// Propiedad que nos devuelve el nombre del Personal para mostrar en el DataGrid.
        /// </summary>
        public string DescPersonal
        {
            get 
            {
                string rtno = string.Empty;
                if (this != null && this.Veterinario != null)
                    rtno = this.Veterinario.Nombre;
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

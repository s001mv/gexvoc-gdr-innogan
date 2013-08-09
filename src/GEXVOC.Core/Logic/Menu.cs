using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Menu : IClaseBase
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
            MenuData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            MenuData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            
            ValidarLogica(TipoOperacion.Borrado);

            //Antes de borrar un elemento tengo que borrar todos los que dependen de el.
            List<Menu> lstMenusDependientes = Menu.Buscar(null, this.Id, null, string.Empty);
            foreach (Menu item in lstMenusDependientes)
                item.Eliminar();

            MenuData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Menu();
                    break;
                case TipoContexto.Modificacion:
                    rtno = MenuData.GetMenuOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Menu a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Menu con el id especificado.</returns>
        public static Menu Buscar(int id)
        {
            return MenuData.GetMenu(id);
        }

        /// <summary>
        /// Obtiene los/las Menu que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Menu> Buscar(int? idModulo,int? idMenuSuperior,int? orden,string texto)
        {
            return MenuData.GetMenus(idModulo,idMenuSuperior,orden,texto);
        }
        public static List<Menu> BuscarPadres(int? idModulo, int? orden, string texto)
        {
            return MenuData.GetMenusPadres(idModulo, orden, texto);
        }


        /// <summary>
        /// Obtiene todos los registros del tipo Menu
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Menu> Buscar()
        {
            return MenuData.GetMenus(null,null,null,string.Empty);
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
        /// <summary>
        /// Valida la lógica de negocio, concluye si la operacion es admitida.
        /// </summary>
        /// <param name="operacion">Operación en curso que se debe validar.</param>
        private void ValidarLogica(TipoOperacion operacion)
        {//Añadir código de validación
        }

        #endregion


    }
}
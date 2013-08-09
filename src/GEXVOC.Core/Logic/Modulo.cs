using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Modulo : IClaseBase
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
            ModuloData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            ModuloData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);

          
            //Antes eliminar el modulo, eliminamos todos los menus asociados a el.
            //Para esto es suficiente con eliminar los padres, ya que el menú al eliminarse, elimina antes todos sus hijos.
            List<Core.Logic.Menu> lstMenu = Core.Logic.Menu.BuscarPadres(this.Id, null, string.Empty);
            foreach (Core.Logic.Menu item in lstMenu)
                item.Eliminar();
            
            ModuloData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Modulo();
                    break;
                case TipoContexto.Modificacion:
                    rtno = ModuloData.GetModuloOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Modulo a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Modulo con el id especificado.</returns>
        public static Modulo Buscar(int id)
        {
            return ModuloData.GetModulo(id);
        }

        /// <summary>
        /// Obtiene los/las Modulo que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Modulo> Buscar(int? idPrincipal,string descripcion)
        {
            return ModuloData.GetModulos(idPrincipal,descripcion);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Modulo
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Modulo> Buscar()
        {
            return ModuloData.GetModulos(null,string.Empty);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Principal a la que pertenece el elemento
        ///// </summary>
        public string DescPrincipal
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Principal != null)
                    rtno = this.Principal.Descripcion;

                return rtno;
            }
        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.

        public List<Menu> lstMenus
        {
            get 
            {
                return Logic.Menu.Buscar(this.Id,null,null,string.Empty);                
            }
        }
        public List<Proceso> lstProcesos
        {
            get
            {
                return Logic.Proceso.Buscar(this.Id,string.Empty,string.Empty,null);
            }
        }

        #endregion
        public Dictionary<string, Menu> lstMenusPermitidosPropios
        {
            get
            {
                Dictionary<string, Menu> lstrtno = new Dictionary<string, Menu>();
                List<Menu> lstMenusAsociados = this.lstMenus;
                foreach (Menu item in lstMenusAsociados)
                    try
                    {
                        lstrtno.Add(item.Texto, item);
                    }
                    catch (Exception)
                    {
                        Traza.RegistrarError("Se ha detectado una entrada duplicada en el administrador de menús");
                        //throw;
                    }
                    

                return lstrtno;
            }
        }
        public Dictionary<string, Menu> lstMenusPermitidosHeredados
        {
            get
            {
                Dictionary<string, Menu> lstrtno = new Dictionary<string, Menu>();
                if (this.IdPrincipal!=null)
                    CargarMenusModulo(lstrtno, Modulo.Buscar((int)this.IdPrincipal));

                return lstrtno;
            }
        }


        public Dictionary<string, Menu> lstMenusPermitidos
        {
            get
            {
                Dictionary<string, Menu> lstrtno = new Dictionary<string, Menu>();
                CargarMenusModulo(lstrtno, this);


                return lstrtno;
            }
        }
        void CargarMenusModulo(Dictionary<string, Menu> lstMenu, Modulo modulo)
        {
            if (modulo.IdPrincipal != null)//Aplico la recursibidad si el modulo depende de algun otro módulo.                
                CargarMenusModulo(lstMenu, Modulo.Buscar((int)modulo.IdPrincipal));

            foreach (Menu mnu in modulo.lstMenus)
            {
                try
                {
                    lstMenu.Add(mnu.Texto, mnu);
                }
                catch (Exception)
                {
                    //No pasa nada si ya esta añadido
                }

            }
        }

        public Dictionary<string, Proceso> lstProcesosPermitidos
        {
            get
            {
                Dictionary<string, Proceso> lstrtno = new Dictionary<string, Proceso>();
                CargarProcesosModulo(lstrtno, this);
                return lstrtno;
            }
        }

        public Dictionary<string, Proceso> lstProcesosPermitidosHeredados
        {
            get
            {
                Dictionary<string, Proceso> lstrtno = new Dictionary<string, Proceso>();
                if (this.IdPrincipal != null)
                    CargarProcesosModulo(lstrtno, Modulo.Buscar((int)this.IdPrincipal));

                return lstrtno;
            }
        }

     
        void CargarProcesosModulo(Dictionary<string, Proceso> lstProcesos, Modulo modulo)
        {
            if (modulo.IdPrincipal != null)//Aplico la recursibidad si el modulo depende de algun otro módulo.                
                CargarProcesosModulo(lstProcesos, Modulo.Buscar((int)modulo.IdPrincipal));

            foreach (Proceso proc in modulo.lstProcesos)
            {
                try
                {
                    lstProcesos.Add(proc.IdentificacionProceso, proc);
                }
                catch (Exception)
                {
                    //No pasa nada si ya esta añadido
                }
            }
        }


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
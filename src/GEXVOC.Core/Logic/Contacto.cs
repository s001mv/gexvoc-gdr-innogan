using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Contacto : IClaseBase
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
            ContactoData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            ContactoData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            ContactoData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Contacto();
                    break;
                case TipoContexto.Modificacion:
                    rtno = ContactoData.GetContactoOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Contacto a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Contacto con el id especificado.</returns>
        public static Contacto Buscar(int id)
        {
            return ContactoData.GetContacto(id);
        }

        /// <summary>
        /// Obtiene los/las Contacto que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Contacto> Buscar(int? idExplotacion, int? idTipo,string nombre, string direccion, string telefono,string movil, string email)
        {
            return ContactoData.GetContactos(idExplotacion, idTipo,nombre, direccion, telefono,movil, email);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Contacto
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Contacto> Buscar()
        {
            return ContactoData.GetContactos(null,null,string.Empty,string.Empty,string.Empty,string.Empty,string.Empty);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Contacto Automáticos (Generados automaticamente por el sistema)
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla que tengan valor TRUE en la columna automático.></returns>
        public static Dictionary<string,Contacto> BuscarAutomaticos()
        {
            return ContactoData.GetContactosAutomaticos();
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
        ///// Propiedad que devuelve la descripción de el/la Tipo a la que pertenece el elemento
        ///// </summary>
        public string DescTipo
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.TipoContacto != null)
                    rtno = this.TipoContacto.Descripcion;

                return rtno;
            }
        }

        bool _PermitirCambio = false;
        /// <summary>
        /// Se utiliza para permitir en ocasiones la actualización o el borrado.
        /// Hay 2 tipos de contactos, lo que crea el usuario directamente, y los que se generan automaticamente 
        /// a partir de clientes y proveedores. Estos ultimos no pueden ser borrados ni actualizados por el usuario.
        /// Esta propiedad se encarga de permitir estas acciones en las ocasiones para permitir el funcionamiento correcto de la
        /// herramienta de sincronización.
        /// </summary>
        public bool PermitirCambio
        {
            get { return _PermitirCambio; }
            set { _PermitirCambio = value; }
        }


        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.

        public List<Cita> lstCitas
        {
            get { return Logic.Cita.Buscar(null,this.Id,null,null,string.Empty,string.Empty); }

        }


        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
       
        private void ValidarLogica(TipoOperacion operacion)
        {//Añadir código de validación
            if ((operacion == TipoOperacion.Borrado || operacion == TipoOperacion.Actualizacion) && !PermitirCambio)
            {
                if (this.Automatico != null && this.Automatico!=string.Empty)
                    throw new LogicException("El contacto: '" + this.Nombre + "' no se puede cambiar ni eliminar porque pertenece a un elemento generado de manera automática.\n" +
                        "Para poder editar este contacto, debe editarlo en el mantenimiento correspondiente y a continuación ejecutar la Herramientas->Sincronizar Contactos.");

            }
            if (operacion== TipoOperacion.Borrado)
            {
                List<Cita> lstCitas=this.lstCitas;
                if (lstCitas != null && lstCitas.Count > 0)
                    throw new LogicException("No es posible eliminar el Contacto: " + this.Nombre + " porque tiene citas.");
                    
                
                
            }


        }

        #endregion


    }
}

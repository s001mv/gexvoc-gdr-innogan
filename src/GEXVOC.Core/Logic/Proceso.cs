using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Proceso : IClaseBase
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
            ProcesoData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            ProcesoData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            ProcesoData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Proceso();
                    break;
                case TipoContexto.Modificacion:
                    rtno = ProcesoData.GetProcesoOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Proceso a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Proceso con el id especificado.</returns>
        public static Proceso Buscar(int id)
        {
            return ProcesoData.GetProceso(id);
        }

        /// <summary>
        /// Obtiene los/las Proceso que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Proceso> Buscar(int? idModulo,string nombre,string formulario,bool? valorBoolInicial)
        {
            return ProcesoData.GetProcesos(idModulo,nombre,formulario,valorBoolInicial);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Proceso
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Proceso> Buscar()
        {
            return ProcesoData.GetProcesos(null, string.Empty, string.Empty,null);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
        ///// </summary>
        //public string DescProvincia { get { return this.Municipio.Provincia.Descripcion; } }

      
        public string IdentificacionProceso
        {
            get 
            {
               return (this.Formulario??string.Empty) + "." + this.Nombre;
            }           
        }
        string _Descripcion = string.Empty;

        /// <summary>
        /// Se utiliza para obtener un detalle del proceso, en ocasiones obtenemos esta informacion por reflexión para establecer información
        /// detallada, esta información se tomará del atributo personalizado ProcesoDescripcion.
        /// Si la información de descripción no se ha inicializado, la propiedad retorna el nombre del formulario.
        /// </summary>
        public string Descripcion
        {
            get {
                if (_Descripcion==string.Empty)               
                    return Formulario;                
                else                
                    return _Descripcion; 
            }
            set { _Descripcion = value; }
        }
        string _Clasificacion = string.Empty;
        public string Clasificacion
        {
            get
            {
                if (_Clasificacion == string.Empty)
                    return this.Nombre;
                else
                    return _Clasificacion;
            }
            set { _Clasificacion = value; }
        }







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
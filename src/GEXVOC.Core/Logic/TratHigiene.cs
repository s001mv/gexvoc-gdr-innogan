using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class TratHigiene : Notificable,IClaseBase
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
            TratHigieneData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            TratHigieneData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            TratHigieneData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new TratHigiene();
                    break;
                case TipoContexto.Modificacion:
                    rtno = TratHigieneData.GetTratHigieneOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una TratHigiene a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>TratHigiene con el id especificado.</returns>
        public static TratHigiene Buscar(int id)
        {
            return TratHigieneData.GetTratHigiene(id);
        }

        /// <summary>
        /// Obtiene los/las TratHigiene que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<TratHigiene> Buscar(int? idPlan,int? idExplotacion,string detalle,DateTime? fechaInicio,DateTime? fechaFin)
        {
            return TratHigieneData.GetTratHigiene(idPlan,idExplotacion,detalle,fechaInicio,fechaFin);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo TratHigiene
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<TratHigiene> Buscar()
        {
            return Buscar(null,null,string.Empty,null,null);
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
        ///// Propiedad que devuelve la descripción de el/la PlanHigiene a la que pertenece el elemento
        ///// </summary>
        public string DescPlanHigiene
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.PlanHigiene != null)
                    rtno = this.PlanHigiene.Descripcion;

                return rtno;
            }
        }

        public string DescTratHigiene 
        {
            get
            {
                string rtno = string.Empty;
                if (this != null)
                    rtno = this.FechaInicio.ToShortDateString() + " - " + this.DescPlanHigiene;

                return rtno;
            }
        
        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.

        public List<ProHig> lstProHig
        {
            get { return Logic.ProHig.Buscar(this.Id, null, null); }
        }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
        /// <summary>
        /// Valida la lógica de negocio, concluye si la operacion es admitida.
        /// </summary>
        /// <param name="operacion">Operación en curso que se debe validar.</param>
        private void ValidarLogica(TipoOperacion operacion)
        {//Añadir código de validación
            if (operacion== TipoOperacion.Insercion)            
                if (this.IdExplotacion == 0)//Establezo el valor por defecto para el campo explotacion si no esta especificado, lo tomo de configuracion.
                    this.IdExplotacion = Configuracion.Explotacion.Id;

            if (operacion ==  TipoOperacion.Borrado)
            {
                //Añado la funcionalidad de borrado en cascada para ProHig

                //En el borrado debo borrar antes los datos relacionados en la tabla ProHig
                //Este borrado es un poco diferente del de los demás pq la clase que se elimina es una clase Notificable
                //esto implica que si por cada uno de los elementos que borro, éste notifica algo, debo guardar esas notificaciones
                //y mostrarlas al final del proceso
                MensajeNotificarVarios = string.Empty;
                List<ProHig> lstProHigBorrar = lstProHig;
                foreach (ProHig item in lstProHigBorrar)
                {
                    item.Notificar += NotificarVarios;//Asigno el evento notificar del hijo que borro a notificar varios del padre (Se hereda de Notificable)
                    item.Eliminar();
                }
                //Genero la notificacion en el padre
                MensajeNotificar = new ResultadoOperacion() { Mensaje = MensajeNotificarVarios , OperacionCorrecta=true};
                
            }
        }

        partial void OnFechaFinChanged()
        {
            if (FechaFin!=null && FechaFin<FechaInicio)            
                throw new LogicException("La fecha fin no puede ser menor a la fecha de inicio");
            
        }

       

        #endregion


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class TratProfilaxis : Notificable,IClaseBase
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

            //Valor predenterminado idExplotacion
            if (this.IdExplotacion == 0)
                this.IdExplotacion = Configuracion.Explotacion.Id;

            TratProfilaxisData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            TratProfilaxisData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            TratProfilaxisData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new TratProfilaxis();
                    break;
                case TipoContexto.Modificacion:
                    rtno = TratProfilaxisData.GetTratProfilaxisOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una TratProfilaxis a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>TratProfilaxis con el id especificado.</returns>
        public static TratProfilaxis Buscar(int id)
        {
            return TratProfilaxisData.GetTratProfilaxis(id);
        }

        /// <summary>
        /// Obtiene los/las TratProfilaxis que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<TratProfilaxis> Buscar(int? idExplotacion,int? idPrograma, string detalle, DateTime? fecha)
        {
            return TratProfilaxisData.GetTratProfilaxis(idExplotacion,idPrograma, detalle, fecha);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo TratProfilaxis
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<TratProfilaxis> Buscar()
        {
            return Buscar(null,null,string.Empty,null);
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
        ///// Propiedad que devuelve la descripción de el/la Programa a la que pertenece el elemento
        ///// </summary>
        public string DescPrograma
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Programa != null)
                    rtno = this.Programa.Descripcion;

                return rtno;
            }
        }

        public string DescTratProfilaxis
        {
            get
            {
                string rtno = string.Empty;
                if (this != null)
                    rtno = this.Fecha.ToShortDateString() + " - " + this.DescPrograma;

                return rtno;
            }

        }


        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        public List<ProPro> lstProPro
        {
            get { return Logic.ProPro.Buscar(this.Id, null, null); }
        }
        public List<AniPro> lstAniPro
        {
            get { return Logic.AniPro.Buscar(this.Id, null); }
        }



        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
        /// <summary>
        /// Valida la lógica de negocio, concluye si la operacion es admitida.
        /// </summary>
        /// <param name="operacion">Operación en curso que se debe validar.</param>
        private void ValidarLogica(TipoOperacion operacion)
        {//Añadir código de validación
            if (operacion == TipoOperacion.Borrado)
            {
                //Añado la funcionalidad de borrado en cascada, Si elimino un registro del tipo TratProfilaxis, se eliminan todos los 
                //registros de la tabla ProPro relacionados.

                //En el borrado debo borrar antes los datos relacionados en la tabla ProPro
                //Este borrado es un poco diferente del de los demás pq la clase que se elimina es una clase Notificable
                //esto implica que si por cada uno de los elementos que borro, éste notifica algo, debo guardar esas notificaciones
                //y mostrarlas al final del proceso
                List<ProPro> lstProProBorrar = lstProPro;
                foreach (ProPro item in lstProProBorrar)
                {
                    item.Notificar += NotificarVarios;//Asigno el evento notificar del hijo que borro a notificar varios del padre (Se hereda de Notificable)
                    item.Eliminar();
                }
                //Genero la notificacion en el padre
                MensajeNotificar = new ResultadoOperacion() { Mensaje = MensajeNotificarVarios, OperacionCorrecta = true };

                //Añado la funcionalidad de borrado en cascada, AniPro
                List<AniPro> lstAniProBorrar = lstAniPro;
                foreach (AniPro item in lstAniProBorrar)
                    item.Eliminar();

            }
        }

        #endregion

    }
}
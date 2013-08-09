using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class DiagInseminacion : IClaseBase
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
            DiagInseminacionData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            DiagInseminacionData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            DiagInseminacionData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new DiagInseminacion();
                    break;
                case TipoContexto.Modificacion:
                    rtno = DiagInseminacionData.GetDiagInseminacionOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una DiagInseminacion a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>DiagInseminacion con el id especificado.</returns>
        public static DiagInseminacion Buscar(int id)
        {
            return DiagInseminacionData.GetDiagInseminacion(id);
        }

        /// <summary>
        /// Obtiene los/las DiagInseminacion que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<DiagInseminacion> Buscar(int? idHembra,int? idTipo, DateTime? fecha,Boolean? resultado,Boolean? modificable)
        {
            return DiagInseminacionData.GetDiagInseminaciones(idHembra, idTipo, fecha, resultado, modificable);
        }

        public static List<DiagInseminacion> Buscar(int? idHembra, DateTime? fechaInicio,DateTime? fechaFin)
        {
            return DiagInseminacionData.GetDiagInseminaciones(idHembra, fechaInicio,fechaFin );
        }

        /// <summary>
        /// Obtiene todos los registros del tipo DiagInseminacion
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<DiagInseminacion> Buscar()
        {
            return DiagInseminacionData.GetDiagInseminaciones(null,null,null,null,null);
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
                if (this != null && this.TipoDiagnostico != null)
                    rtno = this.TipoDiagnostico.Descripcion;

                return rtno;
            }
        }

        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Hembra a la que pertenece el elemento
        ///// </summary>
        public string DescHembra
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Animal != null)
                    rtno = this.Animal.Nombre;

                return rtno;
            }
        }

        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la DescResultado a la que pertenece el elemento
        ///// </summary>
        public string DescResultado
        {
            get
            {
                string rtno = string.Empty;
                if (this != null)
                    rtno = this.Resultado ? "Positivo" : "Negativo";
                    

                return rtno;
            }
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

            ///Implemento la lógica para impedir que se pueda crear un diagnótico de gestacion sin inseminaciones anteriores.
            if (operacion== TipoOperacion.Insercion || operacion== TipoOperacion.Actualizacion)
            {
                Animal hembra = Animal.Buscar(this.IdAnimal);
                if (hembra != null && FechaAnterior.HasValue)
                {
                    bool CubricionAbierta=false;
                    DateTime? UltimaFechaInseminacionCubricion = null;
                    DateTime? UltimaFechaPartoAborto = null;

                    UltimaFechaInseminacionCubricion = hembra.UltimaFechaInseminacion_Cubricion(hembra.Id, ref CubricionAbierta);                      
                    UltimaFechaPartoAborto=hembra.UltimaFechaParto_Aborto(hembra.Id);

                    if (UltimaFechaInseminacionCubricion != null)
                    {
                        if (UltimaFechaPartoAborto != null && UltimaFechaInseminacionCubricion < UltimaFechaPartoAborto)
                            throw new LogicException("La hembra " + hembra.Nombre + " no ha sido inseminada o cubierta desde su último parto o aborto.");
                        if (UltimaFechaInseminacionCubricion>this.Fecha)
                            throw new LogicException("El diagnóstico de gestación para la hembra: " + hembra.Nombre + " debe ser posterior a la última fecha de inseminación/cubrición que correponde con: " + UltimaFechaInseminacionCubricion.Value.ToShortDateString() + ".");
                    }
                    else
                        throw new LogicException("La hembra " + hembra.Nombre + " debe estar inseminada o cubierta para asignarle un diagnóstico de gestación.");
                    
                }
                
            }
        }

        DateTime? FechaAnterior = null;
        partial void OnFechaChanging(DateTime value)
        {
            FechaAnterior = this.Fecha;
        }
        #endregion


    }
}
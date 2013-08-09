using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class TipoDiagnostico : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            TipoDiagnosticoData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            TipoDiagnosticoData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            if (lstDiagInseminacion.Count == 0)
            {
                if (this.Sistema == null || this.Sistema.Value == false)
                    TipoDiagnosticoData.Eliminar(this);

                else
                    throw new LogicException("No se puede realizar la eliminación ya que el tipo es necesario para el correcto funcionamiento del sistema.");
            }
            if (lstDiagInseminacion.Count > 0)
                throw new LogicException("No se puede realizar la eliminación ya que el tipo está asociado a un diagnóstico.");
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
             IClaseBase rtno=null; 
                switch (Modo)
                {
                    case TipoContexto.Insercion:
                        rtno = new TipoDiagnostico();
                        break;
                    case TipoContexto.Modificacion:
                        rtno = TipoDiagnosticoData.GetTipoDiagnosticoOP(this.Id);
                        break;
                }
                return rtno;


        }


        /// <summary>
        /// Obtiene un/una TipoDiagnostico a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>TipoDiagnostico con el id especificado.</returns>
        public static TipoDiagnostico Buscar(int id)
        {
            return TipoDiagnosticoData.GetTipoDiagnostico(id);
        }

        /// <summary>
        /// Obtiene los/las TipoDiagnostico que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<TipoDiagnostico> Buscar(string descripcion)
        {
            return TipoDiagnosticoData.GetTipoDiagnosticos(descripcion);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo TipoDiagnostico
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<TipoDiagnostico> Buscar()
        {
            return TipoDiagnosticoData.GetTipoDiagnosticos(string.Empty);
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
        /// <summary>
        /// Devuelve todos los diagnósticos pertenecientes a un tipo de diagnóstico.
        /// </summary>
        public List<DiagInseminacion> lstDiagInseminacion
        { get { return DiagInseminacionData.GetDiagInseminaciones(null,this.Id, null, null, null); } }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        #endregion


    }
}
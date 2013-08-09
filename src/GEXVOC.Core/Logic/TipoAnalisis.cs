using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class TipoAnalisis : IClaseBase
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
            TipoAnalisisData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            TipoAnalisisData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            TipoAnalisisData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new TipoAnalisis();
                    break;
                case TipoContexto.Modificacion:
                    rtno = TipoAnalisisData.GetTipoAnalisisOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una TipoAnalisis a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>TipoAnalisis con el id especificado.</returns>
        public static TipoAnalisis Buscar(int id)
        {
            return TipoAnalisisData.GetTipoAnalisis(id);
        }

        /// <summary>
        /// Obtiene los/las TipoAnalisis que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<TipoAnalisis> Buscar(string descripcion)
        {
            return TipoAnalisisData.GetTipoAnalisis(descripcion);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo TipoAnalisis
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<TipoAnalisis> Buscar()
        {
            return TipoAnalisisData.GetTipoAnalisis(string.Empty);
        }

        public static List<TipoAnalisis> BuscarDinamico(string descripcion)
        {
            return Buscar(descripcion);
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
        
        //Nos muestra la lista de Marcadores para cada tipo de analisis.
        public List<Marcador> lstMarcadores
        {
            get { return Marcador.Buscar(this.Id, null, string.Empty); }
        }
        public List<Analisis> lstAnalisis
        {
            get { return AnalisisData.GetAnalisis(this.Id, null, null, null, string.Empty, null); }
        }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        private void ValidarLogica(TipoOperacion operacion)
        {
            if (operacion == TipoOperacion.Borrado)
            {
                if (lstMarcadores!=null && this.lstMarcadores.Count > 0)
                    throw new LogicException("No se puede eliminar este Tipo de Análisis ya que se está utilizando en algun registro.");
                if (lstMarcadores != null && this.lstAnalisis.Count > 0)
                    throw new LogicException("No se puede eliminar este Tipo de Análisis ya que se está utilizando en algun registro.");
            }
        }
        #endregion


    }
}

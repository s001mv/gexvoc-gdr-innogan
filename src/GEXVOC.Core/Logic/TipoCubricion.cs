using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class TipoCubricion : IClaseBase
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
            TipoCubricionData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            TipoCubricionData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            
            ValidarLogica(TipoOperacion.Borrado);
            
            TipoCubricionData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new TipoCubricion();
                    break;
                case TipoContexto.Modificacion:
                    rtno = TipoCubricionData.GetTipoCubricionOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una TipoCubricion a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>TipoCubricion con el id especificado.</returns>
        public static TipoCubricion Buscar(int id)
        {
            return TipoCubricionData.GetTipoCubricion(id);
        }

        /// <summary>
        /// Obtiene los/las TipoCubricion que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<TipoCubricion> Buscar(string descripcion)
        {
            return TipoCubricionData.GetTipoCubricions(descripcion);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo TipoCubricion
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<TipoCubricion> Buscar()
        {
            return TipoCubricionData.GetTipoCubricions(string.Empty);
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
            if (operacion== TipoOperacion.Borrado)
            {
                List<Cubricion> lstCubriciones = Logic.Cubricion.Buscar(null, this.Id, null, null);

                if (lstCubriciones.Count() > 0)                
                    throw new LogicException("No es posible eliminar el Tipo de cubrición: " + this.Descripcion + 
                                             " porque está siendo utilizado en (al menos una) cubrición.");
            }
        }

        #endregion


    }
}
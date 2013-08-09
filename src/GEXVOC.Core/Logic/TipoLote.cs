using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class TipoLote : IClaseBase
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
            TipoLoteData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            TipoLoteData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            TipoLoteData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new TipoLote();
                    break;
                case TipoContexto.Modificacion:
                    rtno = TipoLoteData.GetTipoLoteOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una TipoLote a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>TipoLote con el id especificado.</returns>
        public static TipoLote Buscar(int id)
        {
            return TipoLoteData.GetTipoLote(id);
        }

        /// <summary>
        /// Obtiene los/las TipoLote que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<TipoLote> Buscar(string descripcion, bool? sistema)
        {
            return TipoLoteData.GetTipoLote(descripcion, sistema);
        }
        public static List<TipoLote> BuscarDinamico(string descripcion, bool? sistema)
        {
            return Buscar(descripcion, sistema);
        }


        ///<summary>
        ///Obtiene todos los registros del tipo TipoLote        
        ///</summary>
        ///<returns>Devuelve todos los registros de la tabla></returns>
        public static List<TipoLote> Buscar()
        {
            return Buscar(null, null);
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
            if (operacion == TipoOperacion.Borrado || operacion == TipoOperacion.Actualizacion)
                if (this.Sistema ?? false)
                    throw new LogicException("El tipo de Lote: '" + this.Descripcion + "' no se puede cambiar ni eliminar porque forma parte de los datos requeridos por el sistema.");

        }

        #endregion


    }
}
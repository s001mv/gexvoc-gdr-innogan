using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class TipoParto : IClaseBase
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
            TipoPartoData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            TipoPartoData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {

            ValidarLogica(TipoOperacion.Borrado);

            if (lstParto.Count > 0)
                throw new LogicException("Nos se puede realizar la eliminación ya que el tipo está asociado a un parto.");

        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
             IClaseBase rtno=null;             
                switch (Modo)
                {
                    case TipoContexto.Insercion:
                        rtno = new TipoParto();
                        break;
                    case TipoContexto.Modificacion:
                        rtno = TipoPartoData.GetTipoPartoOP(this.Id);
                        break;
                }
                return rtno;

        }


        /// <summary>
        /// Obtiene un/una TipoParto a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>TipoParto con el id especificado.</returns>
        public static TipoParto Buscar(int id)
        {
            return TipoPartoData.GetTipoParto(id);
        }

        /// <summary>
        /// Obtiene los/las TipoParto que coinciden con los criterios de búsqueda.
        /// </summary>       
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<TipoParto> Buscar(string descripcion,Boolean? sistema)
        {
            return TipoPartoData.GetTiposPartos(descripcion, sistema);
        }

        public static List<TipoParto> Buscar()
        {
            return TipoPartoData.GetTiposPartos(string.Empty, null);
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
        /// Devuelve los partos asociados a un tipo de parto.
        /// </summary>
        public List<Parto> lstParto
        { get { return PartoData.GetPartos(null, this.Id, null,null,null,null,null,null); } }


        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
        private void ValidarLogica(TipoOperacion operacion)
        {
            if (operacion == TipoOperacion.Borrado || operacion == TipoOperacion.Actualizacion)
            {
                if (this.Sistema != null && (bool)this.Sistema)
                    throw new LogicException("El tipo de parto: '" + this.Descripcion + "' no se puede cambiar ni eliminar porque forma parte del sistema");

            }
        }

        #endregion


    }
}

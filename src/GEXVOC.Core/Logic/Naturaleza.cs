using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Naturaleza : IClaseBase
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
            NaturalezaData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            NaturalezaData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            NaturalezaData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Naturaleza();
                    break;
                case TipoContexto.Modificacion:
                    rtno = NaturalezaData.GetNaturalezaOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Naturaleza a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Naturaleza con el id especificado.</returns>
        public static Naturaleza Buscar(int id)
        {
            return NaturalezaData.GetNaturaleza(id);
        }

        /// <summary>
        /// Obtiene los/las Naturaleza que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Naturaleza> Buscar(string descripcion,bool? sistema)
        {
            return NaturalezaData.GetNaturalezas(descripcion, sistema);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Naturaleza
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Naturaleza> Buscar()
        {
            return NaturalezaData.GetNaturalezas(string.Empty,null);
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

        private void ValidarLogica(TipoOperacion operacion)
        {
            if (operacion== TipoOperacion.Actualizacion || operacion== TipoOperacion.Borrado)
            {
                if (this.Sistema != null && (bool)this.Sistema)
                    throw new LogicException("La naturaleza: '" + this.Descripcion + "' no se puede cambiar ni eliminar porque forma parte del sistema");
                
            }
            
        }
        #endregion


    }
}
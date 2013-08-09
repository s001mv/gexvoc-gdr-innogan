using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Familia : IClaseBase
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
            FamiliaData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            FamiliaData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            FamiliaData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Familia();
                    break;
                case TipoContexto.Modificacion:
                    rtno = FamiliaData.GetFamiliaOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Familia a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Familia con el id especificado.</returns>
        public static Familia Buscar(int id)
        {
            return FamiliaData.GetFamilia(id);
        }

        /// <summary>
        /// Obtiene los/las Familia que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Familia> Buscar(int? idTipo, string descripcion, bool? sistema)
        {
            return FamiliaData.GetFamilias(idTipo,descripcion,sistema);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Familia
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Familia> Buscar()
        {
            return Buscar(null, null, null);
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

        public List<Producto> lstProductos
        {
            get { return Logic.Producto.Buscar(null,this.Id,string.Empty,null,null,null); }
        }
        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
        private void ValidarLogica(TipoOperacion operacion)
        {
            if (operacion == TipoOperacion.Borrado || operacion == TipoOperacion.Actualizacion)
            {
                if (this.Sistema != null && (bool)this.Sistema)
                    throw new LogicException("La Familia: '" + this.Descripcion + "' no se puede cambiar ni eliminar porque forma parte del sistema.");

            }

        }

        #endregion


    }
}
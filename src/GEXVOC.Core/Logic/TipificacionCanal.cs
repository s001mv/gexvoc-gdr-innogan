using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class TipificacionCanal : IClaseBase
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
            TipificacionCanalData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            TipificacionCanalData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            TipificacionCanalData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new TipificacionCanal();
                    break;
                case TipoContexto.Modificacion:
                    rtno = TipificacionCanalData.GetTipificacionCanalOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una TipificacionCanal a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>TipificacionCanal con el id especificado.</returns>
        public static TipificacionCanal Buscar(int id)
        {
            return TipificacionCanalData.GetTipificacionCanal(id);
        }

        /// <summary>
        /// Obtiene los/las TipificacionCanal que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<TipificacionCanal> Buscar(int? idAnimal, int? idConformacion, int? idCategoria, DateTime? fechaMayorIgual, DateTime? fechaMenorIgual)
        {
            return TipificacionCanalData.GetTipificacionesCanal(idAnimal,idConformacion,idCategoria,fechaMayorIgual,fechaMenorIgual);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo TipificacionCanal
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<TipificacionCanal> Buscar()
        {
            return TipificacionCanalData.GetTipificacionesCanal(null,null,null,null,null);
        }


        public static TipificacionCanal BuscarAnimal(int idAnimal)
        {
            return TipificacionCanalData.GetTipificacionCanalAnimal(idAnimal);
        }

        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        
        /// <summary>
        /// Propiedad que devuelve el nombre del animal.
        /// </summary>
        public string DescAnimal
        {
            get 
            {
                string rtno = string.Empty;
                if (this != null && this.Animal != null)
                    rtno = this.Animal.Nombre;
                return rtno;
            }
        
        }
        /// <summary>
        /// Propiedad que devuelve la descripción de la conformación de la canal.
        /// </summary>
        public string DescConformacion
        {
            get 
            {
                string rtno = string.Empty;
                if (this != null && this.Conformacion != null)
                    rtno = this.Conformacion.Descripcion;
                return rtno;
            }
        }
        /// <summary>
        /// Propiedad que devuelve la categoría del animal.
        /// </summary>
        public string DescCategoria
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Categoria != null)
                    rtno = this.Categoria.Descripcion;
                return rtno;
            }
        }
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
        private void ValidarLogica(TipoOperacion operacion)
        {//Añadir código de validación
            ////if (operacion == TipoOperacion.Insercion)
            ////{
            ////    Animal animal = Animal.Buscar(this.IdAnimal);
            ////    if (animal != null)
            ////    {
            ////        if (animal.BajaAnimal() == null)
            ////            throw new LogicException("El animal: " + animal.Nombre + " no ha sido dado de baja, por tanto " +
            ////                                     "no es posible asignar su Tipificación a la canal");
            ////    }

            ////}
        }

        partial void OnFechaChanged()
        {
            if (IdAnimal > 0)
            {
                Animal animal = Animal.Buscar(this.IdAnimal);
                if (Fecha < animal.FechaNacimiento)
                    throw new LogicException("La fecha de la Tipificación a la canal debe ser mayor a la fecha de nacimiento del animal.");


            }
            else
                throw new LogicException("La fecha de Tipificación a la Canal no puede ser validada porque no es posible acceder al animal.\r" +
                    "Asegúrese de que el animal esta guardado correctamente antes de establecerle información referente a su Tipificación a la Canal.");


        }

        #endregion
     

    }
}

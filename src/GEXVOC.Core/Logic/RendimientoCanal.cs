using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class RendimientoCanal : IClaseBase
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
            RendimientoCanalData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            RendimientoCanalData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            RendimientoCanalData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new RendimientoCanal();
                    break;
                case TipoContexto.Modificacion:
                    rtno = RendimientoCanalData.GetRendimientoCanalOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una RendimientoCanal a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>RendimientoCanal con el id especificado.</returns>
        public static RendimientoCanal Buscar(int id)
        {
            return RendimientoCanalData.GetRendimientoCanal(id);
        }

        /// <summary>
        /// Obtiene los/las RendimientoCanal que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<RendimientoCanal> Buscar(int? idAnimal, decimal? rendimiento, DateTime? fechaMayorIgual, DateTime? fechaMenorIgual)
        {
            return RendimientoCanalData.GetRendimientosCanal(idAnimal,rendimiento,fechaMayorIgual,fechaMenorIgual);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo RendimientoCanal
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<RendimientoCanal> Buscar()
        {
            return RendimientoCanalData.GetRendimientosCanal(null,null,null,null);
        }

        public static RendimientoCanal BuscarAnimal(int idAnimal)
        {
            return RendimientoCanalData.GetRendimientoCanalAnimal(idAnimal);
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
            ////                                     "no es posible asignar su Rendimiento a la canal");
            ////    }

            ////}
        }

        partial void OnFechaChanged()
        {
            if (IdAnimal > 0)
            {
                Animal animal = Animal.Buscar(this.IdAnimal);
                if (Fecha < animal.FechaNacimiento)
                    throw new LogicException("La fecha de Rendimiento a la Canal debe ser mayor a la fecha de nacimiento del animal.");


            }
            else
                throw new LogicException("La fecha de Rendimiento a la Canal no puede ser validada porque no es posible acceder al animal.\r" + 
                    "Asegúrese de que el animal esta guardado correctamente antes de establecerle información referente a su Rendimiento a la Canal.");


        }
        #endregion


    }
}
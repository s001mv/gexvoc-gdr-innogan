using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class TipoPersonal : IClaseBase
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
            TipoPersonalData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            TipoPersonalData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            TipoPersonalData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new TipoPersonal();
                    break;
                case TipoContexto.Modificacion:
                    rtno = TipoPersonalData.GetTipoPersonalOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una TipoPersonal a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>TipoPersonal con el id especificado.</returns>
        public static TipoPersonal Buscar(int id)
        {
            return TipoPersonalData.GetTipoPersonal(id);
        }

        /// <summary>
        /// Obtiene los/las TipoPersonal que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<TipoPersonal> Buscar(string descripcion)
        {
            return TipoPersonalData.GetTipoPersonals(descripcion);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo TipoPersonal
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<TipoPersonal> Buscar()
        {
            return TipoPersonalData.GetTipoPersonals(string.Empty);
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

            if (operacion==TipoOperacion.Borrado)
            {
                List<Veterinario> lstVeterinarios = Logic.Veterinario.Buscar(null,string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, null, this.Id);
                if (lstVeterinarios!=null && lstVeterinarios.Count>0)                
                    throw new LogicException("El Tipo de Personal: " + this.Descripcion + " no puede ser borrado porque existen veterinarios asociados a dicho tipo.");

                
                
            }
        }

        #endregion


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class ExpMod : IClaseBase
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
            ExpModData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            ExpModData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            ExpModData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new ExpMod();
                    break;
                case TipoContexto.Modificacion:
                    rtno = ExpModData.GetExpModOP(this.IdExplotacion,this.IdModulo);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una ExpMod a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>ExpMod con el id especificado.</returns>
        public static ExpMod Buscar(int idExplotacion,int idModulo)
        {
            return ExpModData.GetExpMod(idExplotacion,idModulo);
        }

        /// <summary>
        /// Obtiene los/las ExpMod que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<ExpMod> Buscar(int? idExplotacion,int? idModulo)
        {
            return ExpModData.GetExpMod(idExplotacion,idModulo);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo ExpMod
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<ExpMod> Buscar()
        {
            return ExpModData.GetExpMod(null,null);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Modulo a la que pertenece el elemento
        ///// </summary>
        public string DescModulo
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Modulo != null)
                    rtno = this.Modulo.Descripcion;

                return rtno;
            }
        }

        public int Id
        {
            get { return this.IdModulo; }
            set { }

        }
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
            if (operacion== TipoOperacion.Insercion)
            {
                if (ExpMod.Buscar(this.IdExplotacion, this.IdModulo)!=null)//Busco a ver si existe un registro con los valores que voy a añadir
                throw new LogicException("La relación entre la Explotación y el Módulo, ya existe y no puede ser duplicada.");
            }
        }

        #endregion


    }
}
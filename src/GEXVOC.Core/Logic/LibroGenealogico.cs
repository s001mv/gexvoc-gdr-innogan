using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class LibroGenealogico : IClaseBase
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
            LibroGenealogicoData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            LibroGenealogicoData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            LibroGenealogicoData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new LibroGenealogico();
                    break;
                case TipoContexto.Modificacion:
                    rtno = LibroGenealogicoData.GetLibroGenealogicoOP(this.Id);
                    break;
            }

            return rtno;
        }

        public static LibroGenealogico BuscarAnimal(int idAnimal)
        {
            return LibroGenealogicoData.GetLibroAnimal(idAnimal);
        }
       
        #endregion

        #region PROPIEDADES PERSONALIZADAS

        #endregion

        #region FUNCIONALIDAD AÑADIDA

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        /// <summary>
        /// Valida la lógica de negocio, concluye si la operacion es admitida.
        /// </summary>
        /// <param name="operacion">Operación en curso que se debe validar.</param>
        private void ValidarLogica(TipoOperacion operacion)
        {
        }

        #endregion
    }
}

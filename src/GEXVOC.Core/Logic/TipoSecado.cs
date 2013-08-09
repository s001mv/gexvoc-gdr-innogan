using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class TipoSecado : IClaseBase
    {

        /// <summary>
        /// Normal Estimado.
        /// </summary>
        public const int IdNormalEstimado = 2;

        /// <summary>
        /// Estimado por Vacaciones.
        /// </summary>
        public const int Idhembravacaciones = 3;

        /// <summary>
        /// Parto o aborto sin período de secado.
        /// </summary>
        public const int IdPartoSinLactacion = 4;

        /// <summary>
        /// Aborto seguido de lactación.
        /// </summary>
        public const int IdAbortoConLactacion = 5;


        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            TipoSecadoData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            VerificarTipoSecado();
            TipoSecadoData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            VerificarTipoSecado();
            if (lstSecado.Count == 0)
            {
                if (this.Sistema == null || this.Sistema.Value == false)
                    TipoSecadoData.Eliminar(this);
                else
                    throw new LogicException("No se puede realizar la eliminación ya que el tipo es necesario para el correcto funcionamiento del sistema.");
            }
            if (lstSecado.Count > 0)
                throw new LogicException("No se puede realizar la eliminación ya que el tipo está asociado a un secado");

           
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
             IClaseBase rtno=null;            

                switch (Modo)
                {
                    case TipoContexto.Insercion:
                        rtno = new TipoSecado();
                        break;
                    case TipoContexto.Modificacion:
                        rtno = TipoSecadoData.GetTipoSecadoOP(this.Id);
                        break;
                }
                return rtno;

        }


        /// <summary>
        /// Obtiene un/una TipoSecado a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>TipoSecado con el id especificado.</returns>
        public static TipoSecado Buscar(int id)
        {
            return TipoSecadoData.GetTipoSecado(id);
        }

        /// <summary>
        /// Obtiene los/las TipoSecado que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<TipoSecado> Buscar(string descripcion,Boolean? sistema)
        {
            return TipoSecadoData.GetTipoSecados(descripcion,sistema);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo TipoSecado
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<TipoSecado> Buscar()
        {
            return TipoSecadoData.GetTipoSecados(string.Empty,null);
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
        /// Devuelve los secados pertenecientes a un tipo de secado.
        /// </summary>
        public List<Secado> lstSecado
        { get { return SecadoData.GetSecados(this.Id, null,null, null, null); } }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        /// <summary>
        /// Lanza una excepción en caso de que se intente modificar o eliminar un TipoSecado marcado en la base de datos como de sistema. 
        /// (Se debe cumplir: TipoSecado.Sistema=True)
        /// </summary>
        void VerificarTipoSecado()
        {
            if (this.Sistema != null && (bool)this.Sistema)
                throw new LogicException("El tipo de secado: '" + this.Descripcion + "' no se puede cambiar ni eliminar porque forma parte del sistema");

        }

        #endregion


    }
}
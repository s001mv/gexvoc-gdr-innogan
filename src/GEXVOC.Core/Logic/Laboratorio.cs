using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Laboratorio : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            LaboratorioData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            LaboratorioData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            Boolean TransacionPropia = false;
            try
            {
                TransacionPropia = BDController.IniciarTransaccion();
                List<MuestraControl> lstMuestraControl = this.lstMuestraControles;
                foreach (MuestraControl item in lstMuestraControl)
                    item.Eliminar();
                LaboratorioData.Eliminar(this);
                if (TransacionPropia)
                    BDController.FinalizarTransaccion(true);
            }
            catch (Exception ex)
            {
                if (TransacionPropia)
                    BDController.FinalizarTransaccion(false);
                Traza.RegistrarError(ex);
                throw new LogicException(ex.Message);
            }
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;

              switch (Modo)
               {
                   case TipoContexto.Insercion:
                       rtno = new Laboratorio();
                       break;
                   case TipoContexto.Modificacion:
                       rtno = LaboratorioData.GetLaboratorioOP(this.Id);
                       break;
               }
               return rtno;
                    

        }


        /// <summary>
        /// Obtiene un/una Laboratorio a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Laboratorio con el id especificado.</returns>
        public static Laboratorio Buscar(int id)
        {
            return LaboratorioData.GetLaboratorio(id);
        }

        /// <summary>
        /// Obtiene los/las Laboratorio que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Laboratorio> Buscar(string nombre,string direccion, string telefono)
        {
            return LaboratorioData.GetLaboratorios(nombre,direccion,telefono);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Laboratorio
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Laboratorio> Buscar()
        {
            return LaboratorioData.GetLaboratorios(string.Empty,string.Empty,string.Empty);
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
        /// Devuelve las muestras y controles asociados a un laboratorio.
        /// </summary>
        public List<MuestraControl> lstMuestraControles
        { get { return MuestraControlData.GetMuestraControles(null, this.Id, null, null, null, null, null, null, null, null,null,null,null); } }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        #endregion


    }
}

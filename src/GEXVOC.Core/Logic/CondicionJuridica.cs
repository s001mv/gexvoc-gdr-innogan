using System;
using GEXVOC.Core.Data;
using System.Collections.Generic;

namespace GEXVOC.Core.Logic
{
    /// <summary>
    /// Representa una condición jurídica.
    /// </summary>
    public partial class CondicionJuridica : IClaseBase
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar, Actualizar, Eliminar)

        /// <summary>
        /// Guarda la condición jurídica.
        /// </summary>
        public void Insertar()
        {
            CondicionJuridicaData.Insertar(this);
        }

        /// <summary>
        /// Actualiza la condición jurídica.
        /// </summary>
        public void Actualizar()
        {
            CondicionJuridicaData.Actualizar(this);
        }

        /// <summary>
        /// Elimina la condición jurídica.
        /// </summary>
        public void Eliminar()
        {
            if (lstExplotacion.Count>0)
                throw new LogicException("No se puede realizar la eliminacion de la C. Jurídica seleccionada porque está asociada a una explotación");
            CondicionJuridicaData.Eliminar(this);
            //Boolean TransacionPropia = false;
            //try
            //{
            //    TransacionPropia = BDController.IniciarTransaccion();
            //    foreach (Explotacion explotacion in GEXVOC.Core.Logic.Explotacion.Buscar(string.Empty, string.Empty, string.Empty, null, null, this))
            //        explotacion.Eliminar();
            //    CondicionJuridicaData.Eliminar(this);
            //    if (TransacionPropia)
            //        BDController.FinalizarTransaccion(true);
            //}
            //catch (Exception ex)
            //{
            //    if (TransacionPropia)
            //        BDController.FinalizarTransaccion(false);
            //    Traza.RegistrarError(ex);
            //    throw new LogicException(ex.Message);
            //}
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)
        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
                IClaseBase rtno=null;              

                switch (Modo)
                {
                    case TipoContexto.Insercion:
                        rtno = new CondicionJuridica();//Es una insercion
                        break;
                    case TipoContexto.Modificacion:
                        rtno = CondicionJuridicaData.GetCondicionJuridicaOP(this.Id);//Es una modificacion
                        break;
                    default:
                        rtno = null;
                        break;
                }
                return rtno;


        }

        /// <summary>
        /// Obtiene todas las condiciones jurídicas del sistema.
        /// </summary>
        /// <returns>Condiciones jurídicas del sistema.</returns>
        public static List<CondicionJuridica> Buscar()
        {
            return CondicionJuridicaData.GetCondicionesJuridicas(string.Empty);
        }
        /// <summary>
        /// Obtiene las condiciones jurídicas segun los criterios de busqueda.
        /// </summary>
        /// <param name="condicionJuridica">Condición jurídica</param>
        /// <returns></returns>
        public static List<CondicionJuridica> Buscar(string condicionJuridica)
        {
            return CondicionJuridicaData.GetCondicionesJuridicas(condicionJuridica);
        }
        public static List<CondicionJuridica> BuscarDinamico(string condicionJuridica)
        {
            return CondicionJuridicaData.GetCondicionesJuridicas(condicionJuridica);
        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        /// <summary>
        /// Devuelve las explotaciones que están asociadas a una determinada Condición juridica.
        /// </summary>
        public List<Explotacion> lstExplotacion
        { get { return ExplotacionData.GetExplotaciones(string.Empty, string.Empty, string.Empty, null, null, this.Id); } }

        #endregion
    }   
}

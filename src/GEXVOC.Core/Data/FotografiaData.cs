using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class FotografiaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Fotografia">Fotografia a insertar.</param>
        public static void Insertar(Fotografia Fotografia)
        {
            BDController.BDOperaciones.Fotografia.InsertOnSubmit(Fotografia);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Fotografia">Fotografia a actualizar.</param>
        public static void Actualizar(Fotografia Fotografia)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Fotografia">Fotografia a eliminar.</param>
        public static void Eliminar(Fotografia Fotografia)
        {
            Fotografia ObjBorrar = GetFotografiaOP(Fotografia.Id);
            BDController.BDOperaciones.Fotografia.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Fotografia GetFotografiaOP(int id)
        {
            Fotografia rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Fotografia.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Fotografia a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Fotografia GetFotografia(int id)
        {
            Fotografia Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Fotografia.Single(E => E.Id == id);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;
        }    
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

    }
}
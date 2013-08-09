using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class EnfermedadData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Enfermedad">Enfermedad a insertar.</param>
        public static void Insertar(Enfermedad Enfermedad)
        {
            BDController.BDOperaciones.Enfermedades.InsertOnSubmit(Enfermedad);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Enfermedad">Enfermedad a actualizar.</param>
        public static void Actualizar(Enfermedad Enfermedad)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Enfermedad">Enfermedad a eliminar.</param>
        public static void Eliminar(Enfermedad Enfermedad)
        {
            Enfermedad ObjBorrar = GetEnfermedadOP(Enfermedad.Id);
            BDController.BDOperaciones.Enfermedades.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Enfermedad GetEnfermedadOP(int id)
        {
            Enfermedad rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Enfermedades.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Enfermedad a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Enfermedad GetEnfermedad(int id)
        {
            Enfermedad Obj = null;

            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                 Obj = BD.Enfermedades.Single(E => E.Id == id);
                 Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception)
            { }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }          
            return Obj;
        }

        /// <summary>
        /// Obtiene los/las Enfermedad que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Enfermedad> GetEnfermedades(int? idTipo,string descripcion)
        {
            List<Enfermedad> lista = null;

            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Enfermedad> Consulta = BD.Enfermedades;
                if (idTipo != null)
                    Consulta = Consulta.Where(E => E.IdTipo == idTipo);
                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                Funciones.DescubrirPropiedades(Consulta);
                Consulta = Consulta.OrderBy(E => E.Tipo.Descripcion).ThenBy(E=>E.Descripcion);//Ordenacion Inicial

                lista = Consulta.ToList();
            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }         
            return lista;
        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class LaboratorioData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Laboratorio">Laboratorio a insertar.</param>
        public static void Insertar(Laboratorio Laboratorio)
        {
            BDController.BDOperaciones.Laboratorios.InsertOnSubmit(Laboratorio);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Laboratorio">Laboratorio a actualizar.</param>
        public static void Actualizar(Laboratorio Laboratorio)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Laboratorio">Laboratorio a eliminar.</param>
        public static void Eliminar(Laboratorio Laboratorio)
        {
            Laboratorio ObjBorrar = GetLaboratorioOP(Laboratorio.Id);
            BDController.BDOperaciones.Laboratorios.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Laboratorio GetLaboratorioOP(int id)
        {
            Laboratorio rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Laboratorios.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Laboratorio a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Laboratorio GetLaboratorio(int id)
        {
            Laboratorio Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Laboratorios.Single(E => E.Id == id);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception)
            { //throw; 
            }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;
        }

      
        /// <summary>
        /// Obtiene los/las Laboratorio que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Laboratorio> GetLaboratorios(string nombre, string direccion, string telefono)
        {
            List<Laboratorio> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Laboratorio> Consulta = BD.Laboratorios;

                if (!string.IsNullOrEmpty(nombre))
                    Consulta = Consulta.Where(E => E.Nombre.Contains(nombre));
                if (!string.IsNullOrEmpty(direccion))
                    Consulta = Consulta.Where(E => E.Direccion.Contains(direccion));
                if (!string.IsNullOrEmpty(telefono))
                    Consulta = Consulta.Where(E => E.Telefono.Contains(telefono));

                Consulta = Consulta.OrderBy(E => E.Nombre);//Ordenacion Inicial

                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                                                          //(estas propiedades se utilizan habitualmente en los grids)
                lista = Consulta.ToList();
            }
            catch (Exception) { throw; }
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
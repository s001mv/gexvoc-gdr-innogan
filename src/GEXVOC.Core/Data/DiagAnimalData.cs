using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class DiagAnimalData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="DiagAnimal">DiagAnimal a insertar.</param>
        public static void Insertar(DiagAnimal DiagAnimal)
        {
            BDController.BDOperaciones.DiagsAnimales.InsertOnSubmit(DiagAnimal);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="DiagAnimal">DiagAnimal a actualizar.</param>
        public static void Actualizar(DiagAnimal DiagAnimal)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="DiagAnimal">DiagAnimal a eliminar.</param>
        public static void Eliminar(DiagAnimal DiagAnimal)
        {
            DiagAnimal ObjBorrar = GetDiagAnimalOP(DiagAnimal.Id);
            BDController.BDOperaciones.DiagsAnimales.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static DiagAnimal GetDiagAnimalOP(int id)
        {
            DiagAnimal rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.DiagsAnimales.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una DiagAnimal a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static DiagAnimal GetDiagAnimal(int id)
        {
            DiagAnimal Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.DiagsAnimales.Single(E => E.Id == id);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception)
            {  }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;
        }

        /// <summary>
        /// Obtiene los/las DiagAnimal que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<DiagAnimal> GetDiagAnimales(int? idAnimal, int? idVeterinario,DateTime? fechaMayorIgual, DateTime? fechaMenorIgual,int? idEnfermedad)
        {
            List<DiagAnimal> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<DiagAnimal> Consulta = BD.DiagsAnimales;

                Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idAnimal != null)
                    Consulta = Consulta.Where(E => E.IdAnimal==idAnimal);
                if (idVeterinario != null)
                    Consulta = Consulta.Where(E => E.IdVeterinario == idVeterinario);
                if (fechaMayorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha >= fechaMayorIgual);
                if (fechaMenorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha <= fechaMenorIgual);
                if (idEnfermedad.HasValue)
                    Consulta = Consulta.Where(E => E.IdEnfermedad == idEnfermedad);

                Consulta = Consulta.OrderByDescending(E => E.Fecha);//Ordenacion Inicial
                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                //(estas propiedades se utilizan habitualmente en los grids)
                Funciones.DescubrirPropiedades(Consulta, "IdTipo");
                lista = Consulta.ToList();//Convierte la consulta en una lista
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
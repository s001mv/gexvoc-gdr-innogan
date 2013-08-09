using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class GastoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Gasto">Gasto a insertar.</param>
        public static void Insertar(Gasto Gasto)
        {
            BDController.BDOperaciones.Gastos.InsertOnSubmit(Gasto);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Gasto">Gasto a actualizar.</param>
        public static void Actualizar(Gasto Gasto)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Gasto">Gasto a eliminar.</param>
        public static void Eliminar(Gasto Gasto)
        {
            Gasto ObjBorrar = GetGastoOP(Gasto.Id);
            BDController.BDOperaciones.Gastos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Gasto GetGastoOP(int id)
        {
            Gasto rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Gastos.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Gasto a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Gasto GetGasto(int id)
        {
            Gasto Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Gastos.Single(E => E.Id == id);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception)
            {}
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;
        }

      
        /// <summary>
        /// Obtiene los/las Gasto que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Gasto> GetGastos(int? idNaturaleza, int? idExplotacion, int? idAnimal, int? idTratamiento, int? idReceta, int? idParcela, int? idAsignacion, int? idSiembra, int? idAbonado, int? idTratParcela, string detalle, DateTime? fechaMayorIgual, DateTime? fechaMenorIgual, decimal? importe,decimal? total,int? idInseminacion)
        {
            List<Gasto> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Gasto> Consulta = BD.Gastos;

                if (idNaturaleza != null)
                    Consulta = Consulta.Where(E => E.IdNaturaleza == idNaturaleza);
                if (idExplotacion != null)
                    Consulta = Consulta.Where(E => E.IdExplotacion == idExplotacion);
                else
                    Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);
                if (idAnimal != null)
                    Consulta = Consulta.Where(E => E.IdAnimal == idAnimal);
                if (idTratamiento != null)
                    Consulta = Consulta.Where(E => E.IdTratamiento == idTratamiento);
                if (idReceta != null)
                    Consulta = Consulta.Where(E => E.IdReceta == idReceta);
                if (idParcela != null)
                    Consulta = Consulta.Where(E => E.IdParcela == idParcela);
                if (idAsignacion != null)
                    Consulta = Consulta.Where(E => E.IdAsignacion == idAsignacion);
                if (idSiembra != null)
                    Consulta = Consulta.Where(E => E.IdSiembra == idSiembra);
                if (idAbonado != null)
                    Consulta = Consulta.Where(E => E.IdAbonado == idAbonado);
                if (idTratParcela != null)
                    Consulta = Consulta.Where(E => E.IdTratParcela == idTratParcela);
                if (detalle != string.Empty)
                    Consulta = Consulta.Where(E => E.Detalle.Contains(detalle));
                if (fechaMayorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha >= fechaMayorIgual);
                if (fechaMenorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha <= fechaMenorIgual);
                if (importe != null)
                    Consulta = Consulta.Where(E => E.Importe == importe);
                if (total != null)
                    Consulta = Consulta.Where(E => E.Total == total);
                if (idInseminacion != null)
                    Consulta = Consulta.Where(E => E.IdInseminacion == idInseminacion);

                Consulta = Consulta.OrderByDescending(E => E.Fecha);//Ordenacion Inicial
                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                //(estas propiedades se utilizan habitualmente en los grids)
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


        /// <summary>
        /// Obtiene los/las Gasto que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Gasto> GetGastosTratamientos(int? idTratProfilaxis,int?idProducto,int?idTratHigiene )
        {
            List<Gasto> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Gasto> Consulta = BD.Gastos;

                if (idTratProfilaxis != null)
                    Consulta = Consulta.Where(E => E.IdTratProfilaxis == idTratProfilaxis);
                if (idProducto != null)
                    Consulta = Consulta.Where(E => E.IdProducto == idProducto);
                if (idTratHigiene != null)
                    Consulta = Consulta.Where(E => E.IdTratHigiene == idTratHigiene);

                Consulta = Consulta.OrderByDescending(E => E.Fecha);//Ordenacion Inicial
                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                //(estas propiedades se utilizan habitualmente en los grids)
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


        public static bool AnimalExistenteEnGastos(int idAnimal)
        {
            bool rtno = false;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                rtno = !(BD.Gastos.Where(E => E.IdAnimal == idAnimal).Count() == 0);
            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return rtno;

        }

        #endregion

    }
}

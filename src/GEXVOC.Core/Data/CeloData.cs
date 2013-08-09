using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class CeloData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Celo">Celo a insertar.</param>
        public static void Insertar(Celo Celo)
        {
            BDController.BDOperaciones.Celos.InsertOnSubmit(Celo);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Celo">Celo a actualizar.</param>
        public static void Actualizar(Celo Celo)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Celo">Celo a eliminar.</param>
        public static void Eliminar(Celo Celo)
        {
            Celo ObjBorrar = GetCeloOP(Celo.Id);
            BDController.BDOperaciones.Celos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Celo GetCeloOP(int id)
        {
            Celo rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Celos.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Celo a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Celo GetCelo(int id)
        {
            Celo Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Celos.Single(E => E.Id == id);
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
        /// Obtiene los/las Celo que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Celo> GetCelos(int? idHembra,int? idVeterinario,DateTime? fecha)
        {
            List<Celo> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Celo> Consulta = BD.Celos;
                Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idHembra != null)
                    Consulta = Consulta.Where(E => E.IdHembra==idHembra);
                if (idVeterinario != null)
                    Consulta = Consulta.Where(E => E.IdVeterinario == idVeterinario);
                if (fecha != null)
                    Consulta = Consulta.Where(E => E.Fecha.Date == fecha.Value.Date);


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
        public static List<Celo> GetCelos(int? idHembra, int? idVeterinario, DateTime? fechaInicio,DateTime? fechaFin)
        {
            List<Celo> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Celo> Consulta = BD.Celos;
                Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idHembra != null)
                    Consulta = Consulta.Where(E => E.IdHembra == idHembra);
                if (idVeterinario != null)
                    Consulta = Consulta.Where(E => E.IdVeterinario == idVeterinario);
                if (fechaInicio.HasValue)
                    Consulta = Consulta.Where(E => E.Fecha.Date >= fechaInicio.Value.Date);
                if (fechaFin.HasValue)
                    Consulta = Consulta.Where(E => E.Fecha.Date <= fechaFin.Value.Date);


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
        public static List<Celo> GetCelosMenores(int idHembra, int idCelo)
        {
            List<Celo> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Celo> Consulta = BD.Celos;
                
                Consulta = Consulta.Where(E => E.IdHembra == idHembra);              
                Consulta = Consulta.Where(E => E.Id < idCelo);


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


        #endregion

    }
}
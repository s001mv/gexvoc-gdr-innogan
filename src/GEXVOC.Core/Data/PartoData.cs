using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class PartoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Parto">Parto a insertar.</param>
        public static void Insertar(Parto Parto)
        {
            BDController.BDOperaciones.Partos.InsertOnSubmit(Parto);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Parto">Parto a actualizar.</param>
        public static void Actualizar(Parto Parto)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Parto">Parto a eliminar.</param>
        public static void Eliminar(Parto Parto)
        {
            Parto ObjBorrar = GetPartoOP(Parto.Id);
            BDController.BDOperaciones.Partos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Parto GetPartoOP(int id)
        {
            Parto rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Partos.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Parto a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Parto GetParto(int id)
        {
            Parto Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Partos.Single(E => E.Id == id);
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
        /// Obtiene los/las Parto que coinciden con los criterios de búsqueda.
        /// </summary>
         /// <summary>
        /// Obtiene los/las Parto que coinciden con los criterios de búsqueda.
        /// </summary>
         public static List<Parto> GetPartos(int? idHembra,int? idTipo, int?idFacilidad,int? vivos, int? muertos,DateTime? fechaMayorIgual, DateTime? fechaMenorIgual,Boolean? modificable)
            {
                List<Parto> lista = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    IQueryable<Parto> Consulta = BD.Partos;

                    Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                    if (idHembra != null)
                        Consulta = Consulta.Where(E => E.IdHembra==idHembra);
                    if (idTipo != null)
                        Consulta = Consulta.Where(E => E.IdTipo == idTipo); 
                    if (idFacilidad != null)
                        Consulta = Consulta.Where(E => E.IdFacilidad == idFacilidad);
                    if (vivos != null)
                        Consulta = Consulta.Where(E => E.Vivos == vivos);
                    if (muertos != null)
                        Consulta = Consulta.Where(E => E.Muertos == muertos);
                    if (fechaMayorIgual != null)
                        Consulta = Consulta.Where(E => E.Fecha >= fechaMayorIgual);
                    if (fechaMenorIgual != null)
                        Consulta = Consulta.Where(E => E.Fecha <= fechaMenorIgual);
                    if (modificable != null)
                        Consulta = Consulta.Where(E => E.Modificable == modificable);                

                    Consulta = Consulta.OrderByDescending(E => E.Fecha);//Ordenacion Inicial

                    Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                                                              //(estas propiedades se utilizan habitualmente en los grids)
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

         public static List<Inseminacion> GetInseminaciones(int idParto)
         {           
             List<Inseminacion> rtno = null;
             GEXVOCDataContext BD = BDController.NuevoContexto;
             try
             {
                var Consulta = from p in BD.Inseminaciones
                                from o in p.InsPar
                                where (o.IdParto == idParto)
                                orderby  (p.Fecha) descending

                                select (p);
                 Funciones.DescubrirPropiedades(Consulta);
                 rtno = Consulta.ToList();
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

         public static List<Parto> GetPartosMenores(int idHembra, int idParto)
         {
             List<Parto> lista = null;
             GEXVOCDataContext BD = BDController.NuevoContexto;
             try
             {

                 IQueryable<Parto> Consulta = BD.Partos;

                 Consulta = Consulta.Where(E => E.IdHembra == idHembra);
                 Consulta = Consulta.Where(E => E.Id < idParto);


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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class LoteAnimalData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="LoteAnimal">LoteAnimal a insertar.</param>
        public static void Insertar(LoteAnimal LoteAnimal)
        {
            BDController.BDOperaciones.LotesAnimales.InsertOnSubmit(LoteAnimal);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="LoteAnimal">LoteAnimal a actualizar.</param>
        public static void Actualizar(LoteAnimal LoteAnimal)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="LoteAnimal">LoteAnimal a eliminar.</param>
        public static void Eliminar(LoteAnimal LoteAnimal)
        {
            LoteAnimal ObjBorrar = GetLoteAnimalOP(LoteAnimal.Id);
            BDController.BDOperaciones.LotesAnimales.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static LoteAnimal GetLoteAnimalOP(int id)
        {
            LoteAnimal rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.LotesAnimales.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una LoteAnimal a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static LoteAnimal GetLoteAnimal(int id)
        {
            LoteAnimal Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.LotesAnimales.Single(E => E.Id == id);
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
        /// Obtiene los/las LoteAnimal que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<LoteAnimal> GetLotesAnimales(int? idExplotacion,string descripcion,
                                                        DateTime? fechaAlta,DateTime? fechaBaja,int? idParidera,int? idTipo)
        {
            List<LoteAnimal> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<LoteAnimal> Consulta = BD.LotesAnimales;
                if (idExplotacion !=null)
                    Consulta = Consulta.Where(E => E.IdExplotacion == idExplotacion);              
                if (!string.IsNullOrEmpty(descripcion))
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));              
                if (fechaAlta != null)
                    Consulta = Consulta.Where(E => E.FechaAlta == fechaAlta);
                if (fechaBaja != null)
                    Consulta = Consulta.Where(E => E.FechaBaja == fechaBaja);
                if (idParidera.HasValue)
                    Consulta = Consulta.Where(E => E.IdParidera == idParidera);
                if (idTipo.HasValue)
                    Consulta = Consulta.Where(E => E.IdTipo == idTipo);


                Consulta = Consulta.OrderBy(E => E.Descripcion);//Ordenacion Inicial
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

        public static List<Animal> GetAnimales(int idLote)
        {

            List<Animal> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                var Consulta = from p in BD.Animales
                               from o in p.AniLot
                               where (o.IdLote == idLote)
                               orderby (p.DIB)
                               select (p);
                Funciones.DescubrirPropiedades(Consulta);
                lista = Consulta.ToList();
            }
            catch (Exception)
            {throw;}
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return lista;
          
              
            

           
        }

       
        #endregion

    }
}
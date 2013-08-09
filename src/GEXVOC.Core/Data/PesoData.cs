using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class PesoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

            /// <summary>
            /// Inserta un registro.
            /// </summary>
            /// <param name="Peso">Peso a insertar.</param>
            public static void Insertar(Peso Peso)
            {

                try
                {
                    BDController.BDOperaciones.Pesos.InsertOnSubmit(Peso);
                    BDController.BDOperaciones.SubmitChanges();
                }
                catch (Exception)
                {
                    Peso = new Peso();
                    throw;
                }
                   
              
                
            }

            /// <summary>
            /// Actualiza un registro.
            /// </summary>
            /// <param name="Peso">Peso a actualizar.</param>
            public static void Actualizar(Peso Peso)
            {
                BDController.BDOperaciones.SubmitChanges();
            }

            /// <summary>
            /// Elimina un registro.
            /// </summary>
            /// <param name="Peso">Peso a eliminar.</param>
            public static void Eliminar(Peso Peso)
            {

                Peso ObjBorrar = GetPesoOP(Peso.Id);

                BDController.BDOperaciones.Pesos.DeleteOnSubmit(ObjBorrar);
                BDController.BDOperaciones.SubmitChanges();
            }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

            public static Peso GetPesoOP(int id)
            {
                return BDController.BDOperaciones.Pesos.Single(E => E.Id == id);
            }

        /// <summary>
        /// Obtiene un/una Peso a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
            public static Peso GetPeso(int id)
            {

                Peso Obj = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    Obj = BD.Pesos.Single(E => E.Id == id);
                    Funciones.DescubrirPropiedades(Obj);
                }
                catch (Exception){ }
                finally
                {
                    if (!BDController.TransaccionActiva)
                        BD.Dispose();
                }

                return Obj;
                
            }

        /// <summary>
        /// Obtiene los/las Peso que coinciden con los criterios de búsqueda.
        /// </summary>
            public static List<Peso> GetPesos(int? idAnimal, decimal? peso,DateTime? fecha,int? idMomento,bool? modificable)
            {
                List<Peso> lista = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    IQueryable<Peso> Consulta = BD.Pesos;
                    Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                    if (idAnimal != null)
                        Consulta = Consulta.Where(E => E.IdAnimal == idAnimal);

                    if (peso != null)
                        Consulta = Consulta.Where(E => E.Peso1 == peso);

                    if (fecha != null)
                        Consulta = Consulta.Where(E => E.Fecha == fecha);

                    if (idMomento != null)
                        Consulta = Consulta.Where(E => E.IdMomento == idMomento);

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

            public static List<Peso> GetPesos(int? idAnimal, decimal? peso, DateTime? fechaInicio,DateTime? fechaFin, int? idMomento, bool? modificable)
            {
                List<Peso> lista = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    IQueryable<Peso> Consulta = BD.Pesos;
                    Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                    if (idAnimal != null)
                        Consulta = Consulta.Where(E => E.IdAnimal == idAnimal);

                    if (peso != null)
                        Consulta = Consulta.Where(E => E.Peso1 == peso);

                    if (fechaInicio.HasValue)
                        Consulta = Consulta.Where(E => E.Fecha >= fechaInicio);

                    if (fechaFin.HasValue)
                        Consulta = Consulta.Where(E => E.Fecha <= fechaFin);

                    if (idMomento != null)
                        Consulta = Consulta.Where(E => E.IdMomento == idMomento);

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



        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de Peso
        //Estos elementos proveen de nuevas características.


        #endregion

    }
}


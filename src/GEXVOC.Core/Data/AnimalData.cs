using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;
using System.Data.Linq.SqlClient;

namespace GEXVOC.Core.Data
{
    public class AnimalData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Animal">Animal a insertar.</param>
        public static void Insertar(Animal Animal)
        {
            BDController.BDOperaciones.Animales.InsertOnSubmit(Animal);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Animal">Animal a actualizar.</param>
        public static void Actualizar(Animal Animal)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Animal">Animal a eliminar.</param>
        public static void Eliminar(Animal Animal)
        {
            Animal ObjBorrar = GetAnimalOP(Animal.Id);
            BDController.BDOperaciones.Animales.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Animal GetAnimalOP(int id)
        {
            Animal rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Animales.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Animal a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Animal GetAnimal(int id)
        {
            Animal Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Animales.Single(E => E.Id == id);
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
        /// Obtiene un/una Animal a partir de su CI.
        /// </summary>
        /// <param name="CI">CIentificador principal.</param>
        public static Animal GetAnimal(string CI)
        {
            Animal Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Animales.SingleOrDefault(E => E.DIB == CI);
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
        /// Obtiene los/las Animal que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Animal> GetAnimales(int? id, int? idRaza,int? idEstado,int? idTalla,int? idConformacion,int? idExplotacion,string DIB,
                                               string crotal, string tatuaje,string nombre, DateTime? fechaNacimiento, char? sexo,Boolean? testaje,
                                               Boolean? aptoNovillas, Boolean? mostrarBajas, int? idEspecie)
        {
            List<Animal> ListaObj=null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Animal> Consulta = BD.Animales;
                if (id != null)
                    Consulta = Consulta.Where(E => E.Id == id);                
                if (idRaza != null)
                    Consulta = Consulta.Where(E => E.IdRaza == idRaza);
                if (idEstado != null)
                    Consulta = Consulta.Where(E => E.IdEstado == idEstado);
                if (idTalla != null)
                    Consulta = Consulta.Where(E => E.IdTalla == idTalla);
                if (idConformacion != null)
                    Consulta = Consulta.Where(E => E.IdConformacion == idConformacion);
                if (idExplotacion != null)
                    Consulta = Consulta.Where(E => E.IdExplotacion == idExplotacion);              
                if (!string.IsNullOrEmpty(DIB))
                    Consulta = Consulta.Where(E => E.DIB.Contains(DIB));
                if (!string.IsNullOrEmpty(crotal))
                    Consulta = Consulta.Where(E => E.Crotal.Contains(crotal));
                if (!string.IsNullOrEmpty(tatuaje))
                    Consulta = Consulta.Where(E => E.Tatuaje.Contains(tatuaje));
                if (!string.IsNullOrEmpty(nombre))
                    Consulta = Consulta.Where(E => E.Nombre.Contains(nombre));                 
                if (fechaNacimiento != null)
                    Consulta = Consulta.Where(E => E.FechaNacimiento == fechaNacimiento);           
                if (sexo != null)
                    Consulta = Consulta.Where(E => E.Sexo == sexo);
                if (testaje != null)
                    Consulta = Consulta.Where(E => E.Testaje == testaje);
                if (aptoNovillas != null)
                    Consulta = Consulta.Where(E => E.AptoNovillas == aptoNovillas);          
                if ((mostrarBajas??false))
                    Consulta = Consulta.Where(E => E.Baja.Count == 1);
                else
                    Consulta = Consulta.Where(E => E.Baja.Count == 0);
                if (idEspecie != null)
                    Consulta = Consulta.Where(E => E.Raza.IdEspecie == idEspecie);              
                
                //if (fechaAlta != null)
                //    Consulta = Consulta.Where(E => E.FechaAlta == fechaAlta);
                //if (fechaBaja != null)
                //    Consulta = Consulta.Where(E => E.FechaBaja == fechaBaja);


                Consulta = Consulta.OrderBy(E => E.DIB);

                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                                                          //(estas propiedades se utilizan habitualmente en los grids)
                ListaObj = Consulta.ToList();

            }
            catch (Exception)
            {throw;}
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            
            return ListaObj;

           
        }
        public static List<Animal> GetAnimales(int? idExplotacion,int? idEspecie, Boolean? mostrarBajas)
        {
            List<Animal> ListaObj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Animal> Consulta = BD.Animales;
             
               
                if (idExplotacion != null)
                    Consulta = Consulta.Where(E => E.IdExplotacion == idExplotacion);
                if (idEspecie != null)
                    Consulta = Consulta.Where(E => E.Raza.IdEspecie == idEspecie);
                if (!(mostrarBajas ?? false))
                    Consulta = Consulta.Where(E => E.Baja.Count == 0);
                //    Consulta = Consulta.Where(E => E.Baja.Count == 1);
                //else
                //    Consulta = Consulta.Where(E => E.Baja.Count == 0);

              
                Consulta = Consulta.OrderBy(E => E.DIB);

                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                //(estas propiedades se utilizan habitualmente en los grids)
                ListaObj = Consulta.ToList();

            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }

            return ListaObj;


        }
        public static List<Animal> GetAnimales(string CI, string crotal, string  nombre)
        {
            List<Animal> ListaObj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Animal> Consulta = BD.Animales;


                if (!string.IsNullOrEmpty(CI))
                    Consulta = Consulta.Where(E => E.DIB == CI);
                if (!string.IsNullOrEmpty(crotal))
                    Consulta = Consulta.Where(E => E.Crotal == crotal);
                if (!string.IsNullOrEmpty(nombre))
                    Consulta = Consulta.Where(E => E.Nombre == nombre);                
            


                Consulta = Consulta.OrderBy(E => E.DIB);

                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                //(estas propiedades se utilizan habitualmente en los grids)
                ListaObj = Consulta.ToList();

            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }

            return ListaObj;


        }
        public static List<Animal> GetAnimales(int? idExplotacion,int? idEspecie,
                                               string nombre, string tatuaje, string crotal, 
                                               string CI,int? idEstado,char? sexo,bool? externo)
        {
            List<Animal> ListaObj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Animal> Consulta = BD.Animales;


                if (idExplotacion != null)
                    Consulta = Consulta.Where(E => E.IdExplotacion == idExplotacion);
                if (idEspecie != null)
                    Consulta = Consulta.Where(E => E.Raza.IdEspecie == idEspecie);           
                if (!string.IsNullOrEmpty(nombre))
                    Consulta = Consulta.Where(E => E.Nombre.Contains(nombre));
                if (!string.IsNullOrEmpty(tatuaje))
                    Consulta = Consulta.Where(E => E.Tatuaje.Contains(tatuaje));
                if (!string.IsNullOrEmpty(crotal))
                    Consulta = Consulta.Where(E => E.Crotal.Contains(crotal));
                if (!string.IsNullOrEmpty(CI))
                    Consulta = Consulta.Where(E => E.DIB.Contains(CI));
                if (idEstado != null)
                    Consulta = Consulta.Where(E => E.IdEstado == idEstado);
                if (sexo != null)
                    Consulta = Consulta.Where(E => E.Sexo == sexo);
                if (externo != null)
                    Consulta = Consulta.Where(E => (E.Externo ?? false) == externo);


                Consulta = Consulta.OrderBy(E => E.DIB);

                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                //(estas propiedades se utilizan habitualmente en los grids)
                ListaObj = Consulta.ToList();

            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }

            return ListaObj;


        }


        public static List<LoteAnimal> GetLotes(int idAnimal)
        {
            List<LoteAnimal> rtno = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                var Consulta = from p in BD.LotesAnimales
                               from o in p.AniLot
                               where (o.IdAnimal == idAnimal)
                               //orderby (p.Descripcion)
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
        public static List<TratEnfermedad> GetTratamientos(int idAnimal)
        {
            List<TratEnfermedad> rtno = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                var Consulta = from p in BD.TratsEnfermedades                               
                               where (p.DiagAnimal.IdAnimal == idAnimal)                                                             
                               select (p);
                Funciones.DescubrirPropiedades(Consulta);
                rtno = Consulta.OrderByDescending(E=>E.Fecha).ToList();
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
        public static List<Cubricion> GetCubriciones(int idAnimal)
        {
            List<Cubricion> rtno = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                var Consulta = from c in BD.Cubriciones
                               from p in BD.LotesAnimales
                               where (c.IdLote == p.Id)
                               from o in p.AniLot
                               orderby (o.FechaFin)
                               where (o.IdAnimal == idAnimal)
                               select (c);
                // Consulta = Consulta.OrderByDescending(E => E.FechaInicio).ThenBy(E => E.FechaFin);


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



        /// <summary>
        /// Obtiene los/las Animal que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Animal> GetAnimalesAmpliado(int? id, int? idRaza, int? idEstado, int? idTalla, int? idConformacion, int? idExplotacion, string DIB,
                                               string crotal, string tatuaje, string nombre, DateTime? fechaNacimiento, char? sexo, Boolean? testaje,
                                               Boolean? aptoNovillas, Boolean? mostrarBajas, int? idEspecie,
            int? idTipoAlta,DateTime? fechaAlta,string detalleAlta,
            int? idTipoBaja, DateTime? fechaBaja, string detalleBaja,Boolean? incluirExternos)
        {
            List<Animal> ListaObj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Animal> Consulta = BD.Animales;
                if (id != null)
                    Consulta = Consulta.Where(E => E.Id == id);             
                if (idRaza != null)
                    Consulta = Consulta.Where(E => E.IdRaza == idRaza);
                if (idEstado != null)
                    Consulta = Consulta.Where(E => E.IdEstado == idEstado);
                if (idTalla != null)
                    Consulta = Consulta.Where(E => E.IdTalla == idTalla);
                if (idConformacion != null)
                    Consulta = Consulta.Where(E => E.IdConformacion == idConformacion);
                if (idExplotacion != null)
                    Consulta = Consulta.Where(E => E.IdExplotacion == idExplotacion);
                if (!string.IsNullOrEmpty(DIB))
                    Consulta = Consulta.Where(E => E.DIB.Contains(DIB));
                if (!string.IsNullOrEmpty(crotal))
                    Consulta = Consulta.Where(E => E.Crotal.Contains(crotal));
                if (!string.IsNullOrEmpty(tatuaje))
                    Consulta = Consulta.Where(E => E.Tatuaje.Contains(tatuaje));
                if (!string.IsNullOrEmpty(nombre))
                    Consulta = Consulta.Where(E => E.Nombre.Contains(nombre));             
                if (fechaNacimiento != null)
                    Consulta = Consulta.Where(E => E.FechaNacimiento == fechaNacimiento);
                if (sexo != null)
                    Consulta = Consulta.Where(E => E.Sexo == sexo);
                if (testaje != null)
                    Consulta = Consulta.Where(E => E.Testaje == testaje);
                if (aptoNovillas != null)
                    Consulta = Consulta.Where(E => E.AptoNovillas == aptoNovillas);
             
                if ((mostrarBajas ?? false))
                    Consulta = Consulta.Where(E => E.Baja.Count == 1);
                else
                    Consulta = Consulta.Where(E => E.Baja.Count == 0);

                if (idEspecie != null)
                    Consulta = Consulta.Where(E => E.Raza.IdEspecie == idEspecie);

                ///Filtros por Alta
                if (idTipoAlta != null)
                    Consulta = Consulta.Where(E => E.Alta.First().IdTipo == idTipoAlta);
                if (fechaAlta != null)
                    Consulta = Consulta.Where(E => E.Alta.First().Fecha == fechaAlta);
                if (!string.IsNullOrEmpty(detalleAlta))
                    Consulta = Consulta.Where(E => E.Alta.First().Detalle.Contains(detalleAlta));

                ///Filtros por Baja
                if (idTipoBaja != null)                
                    Consulta = Consulta.Where(E => E.Baja.First().IdTipo == idTipoBaja);
                if (fechaBaja != null)
                    Consulta = Consulta.Where(E => E.Baja.First().Fecha == fechaBaja);
                if (!string.IsNullOrEmpty(detalleBaja))
                    Consulta = Consulta.Where(E => E.Baja.First().Detalle.Contains(detalleBaja));

                if (incluirExternos.HasValue && incluirExternos.Value==false)
                {
                        Consulta = Consulta.Where(E => (E.Externo??false)==false);
                }

                Consulta = Consulta.OrderBy(E => E.Nombre);

                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                //(estas propiedades se utilizan habitualmente en los grids)
                ListaObj = Consulta.ToList();

            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }

            return ListaObj;


        }

        public static List<Animal> GetHijos(string dibMadre)
        {
            List<Animal> ListaObj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                var Consulta = from A in BD.Animales
                               from L in A.LibroGenealogico
                               where L.Madre == dibMadre
                               orderby A.FechaNacimiento
                               select A;

                Funciones.DescubrirPropiedades(Consulta);

                ListaObj = Consulta.ToList();
            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }

            return ListaObj;
        }
       
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion



    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GEXVOC.Core.Logic;
using System.Configuration;



namespace GEXVOC.Core.Data
{
    /// <summary>
    /// Realiza el acceso a datos para las operaciones con explotaciones.
    /// </summary>
    public class ExplotacionData
    {

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)
        
            /// <summary>
            /// Obtiene una explotación a partir de su id.
            /// </summary>
            /// <param name="id">Id de la explotación.</param>
            public static Explotacion GetExplotacion(int id)
            {
                Explotacion Obj = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    Obj = BD.Explotaciones.Single(E => E.Id == id);
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

            public static Explotacion GetExplotacionOP(int id){
                return BDController.BDOperaciones.Explotaciones.Single(E => E.Id == id);
            }

           

            public static List<Explotacion> GetExplotaciones(string cea, string nombre, string direccion, int? idProvincia, int? idMunicipio,
                    int? idCjuridica)
            {

                List<Explotacion> listaRtno=null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    IQueryable<Explotacion> Consulta = BD.Explotaciones;

                    if (cea != String.Empty)
                        Consulta = Consulta.Where(E => E.CEA.Contains(cea));

                    if (nombre != String.Empty)
                        Consulta = Consulta.Where(E => E.Nombre.Contains(nombre));

                    if (direccion != String.Empty)
                        Consulta = Consulta.Where(E => E.Direccion.Contains(direccion));

                    if (idProvincia != null)
                        Consulta = Consulta.Where(E => E.Municipio.IdProvincia == idProvincia);

                    if (idMunicipio != null)
                        Consulta = Consulta.Where(E => E.IdMunicipio == idMunicipio);

                    if (idCjuridica != null)
                        Consulta = Consulta.Where(E => E.IdCJuridica == idCjuridica);

                    Consulta = Consulta.OrderBy(E => E.CEA);//Ordenacion Inicial

                    Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                                                              //(estas propiedades se utilizan habitualmente en los grids)
                    Funciones.DescubrirPropiedades(Consulta,"IdProvincia");
                    
                    listaRtno = Consulta.ToList();
                }
                catch (Exception)
                { throw; }
                finally
                {
                    if (!BDController.TransaccionActiva)
                        BD.Dispose();
                }
                               
                return listaRtno;
            }


            /// <summary>
            /// Obtiene los titulares de una explotación dada
            /// </summary>
            /// <param name="idExplotacion">Identificador de la Explotación</param>
            /// <returns>IQueryable<Titular></returns>
            public static List<Titular> GetTitulares(int idExplotacion)
            {
                ///Para obtener los titulares de una explotación, tenemos que tener en cuenta
                ///la relación que enlaza Explotaciones y Titulares.
                ///Puesto que en este caso la relación es N:N, dicha relación la establece una tercera tabla (ExpTit)
                ///Para obtnener entonces los Titulares de una explotación tenemos que obtener los Titulares
                ///que cuyo id se encuentre en la tabla (ExpTit) y tengan a su vez como idexplotacion la explotacion a tratar
                ///Si vemos la consulta real lo vemos mas claro (Esta es la sintaxis que ejecuta LINQ):
                //      SELECT TTitular.*
                //      FROM Titular AS TTitular, ExpTit AS TExpTit
                //      WHERE (TExpTit.IdExplotacion = @parametroIdExplotacion) AND (TExpTit.IdTitular = TTitular.Id)
                List<Titular> rtno=null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    var Consulta = from p in BD.Titulares
                                   from o in p.ExpTit
                                   where (o.IdExplotacion == idExplotacion)
                                   orderby (p.Nombre)
                                   select (p);
                    
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
            public static List<Especie> GetEspecies(int idExplotacion)
            {
            
                List<Especie> rtno = null;


                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                   var Consulta = from p in BD.Especies
                                   from o in p.ExpEsp
                                   where (o.IdExplotacion == idExplotacion)
                                   orderby (p.Descripcion)
                                   select (p);

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
            public static List<Modulo> GetModulos(int idExplotacion)
            {

                List<Modulo> rtno = null;


                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    var Consulta = from p in BD.Modulos
                                   from o in p.ExpMod
                                   where (o.IdExplotacion == idExplotacion)
                                   orderby (p.Descripcion)
                                   select (p);

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


            public static List<Cliente> GetClientes(int idExplotacion, string nombre, string direccion, string cp, string dni, string telefono, DateTime? fechaAlta, DateTime? fechaBaja)
            {
                ///Para obtener los Clientes de una explotación, tenemos que tener en cuenta
                ///la relación que enlaza Explotaciones y Clientees.
                ///Puesto que en este caso la relación es N:N, dicha relación la establece una tercera tabla (ExpCli)
                ///Para obtnener entonces los Clientees de una explotación tenemos que obtener los Clientees
                ///que cuyo id se encuentre en la tabla (ExpCli) y tengan a su vez como idexplotacion la explotacion a tratar
                ///Si vemos la consulta real lo vemos mas claro (Esta es la sintaxis que ejecuta LINQ):
                //      SELECT TCliente.*
                //      FROM Cliente AS TCliente, ExpCli AS TExpCli
                //      WHERE (TExpTit.IdExplotacion = @parametroIdExplotacion) AND (TExpCli.IdCliente = TCliente.Id)
                List<Cliente> rtno = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    var Consulta = from p in BD.Clientes
                                   from o in p.ExpCli
                                   where (o.IdExplotacion == idExplotacion)
                                   orderby (p.Nombre)
                                   select (p);

                    if (!string.IsNullOrEmpty(nombre))
                        Consulta = Consulta.Where(E => E.Nombre.Contains(nombre));
                    if (!string.IsNullOrEmpty(direccion))
                        Consulta = Consulta.Where(E => E.Direccion.Contains(direccion));
                    if (!string.IsNullOrEmpty(cp))
                        Consulta = Consulta.Where(E => E.CP.Contains(cp));
                    if (!string.IsNullOrEmpty(dni))
                        Consulta = Consulta.Where(E => E.DNI.Contains(dni));
                    if (!string.IsNullOrEmpty(telefono))
                        Consulta = Consulta.Where(E => E.Telefono.Contains(telefono));
                    if (fechaAlta.HasValue)
                        Consulta = Consulta.Where(E => E.FechaAlta == fechaAlta);
                    if (fechaBaja.HasValue)
                        Consulta = Consulta.Where(E => E.FechaBaja == fechaBaja);


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


            public static List<Proveedor> GetProveedores(int idExplotacion, string nombre, string direccion, string cp, string dni, string telefono, DateTime? fechaAlta, DateTime? fechaBaja)
            {
                ///Para obtener los Proveedors de una explotación, tenemos que tener en cuenta
                ///la relación que enlaza Explotaciones y Proveedores.
                ///Puesto que en este caso la relación es N:N, dicha relación la establece una tercera tabla (ExpPro)
                ///Para obtnener entonces los Proveedores de una explotación tenemos que obtener los Proveedores
                ///que cuyo id se encuentre en la tabla (ExpPro) y tengan a su vez como idexplotacion la explotacion a tratar
                ///Si vemos la consulta real lo vemos mas claro (Esta es la sintaxis que ejecuta LINQ):
                //      SELECT TProveedor.*
                //      FROM Proveedor AS TProveedor, ExpPro AS TExpCli
                //      WHERE (TExpPro.IdExplotacion = @parametroIdExplotacion) AND (ExpPro.IdProveedor = TProveedor.Id)
                List<Proveedor> rtno = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    var Consulta = from p in BD.Proveedores
                                   from o in p.ExpPro
                                   where (o.IdExplotacion == idExplotacion)
                                   orderby (p.Nombre)
                                   select (p);

                    if (!string.IsNullOrEmpty(nombre))
                        Consulta = Consulta.Where(E => E.Nombre.Contains(nombre));
                    if (!string.IsNullOrEmpty(direccion))
                        Consulta = Consulta.Where(E => E.Direccion.Contains(direccion));
                    if (!string.IsNullOrEmpty(cp))
                        Consulta = Consulta.Where(E => E.CP.Contains(cp));
                    if (!string.IsNullOrEmpty(dni))
                        Consulta = Consulta.Where(E => E.DNI.Contains(dni));
                    if (!string.IsNullOrEmpty(telefono))
                        Consulta = Consulta.Where(E => E.Telefono.Contains(telefono));
                    if (fechaAlta.HasValue)
                        Consulta = Consulta.Where(E => E.FechaAlta == fechaAlta);
                    if (fechaBaja.HasValue)
                        Consulta = Consulta.Where(E => E.FechaBaja == fechaBaja);


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

            public static List<Titular> GetTitulares(int idExplotacion, string nombre, string apellidos, string direccion, string cp, string dni, string telefono, DateTime? fechaNacimiento, DateTime? fechaAlta, DateTime? fechaBaja)
            {
                List<Titular> rtno = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;

                try
                {
                    var Consulta = from P in BD.Titulares
                                   from T in P.ExpTit
                                   where P.Id == T.IdTitular && T.IdExplotacion == idExplotacion
                                   orderby P.Apellidos, P.Nombre
                                   select P;

                    if (!string.IsNullOrEmpty(nombre))
                        Consulta = Consulta.Where(E => E.Nombre.Contains(nombre));
                    if (!string.IsNullOrEmpty(apellidos))
                        Consulta = Consulta.Where(E => E.Apellidos.Contains(apellidos));
                    if (!string.IsNullOrEmpty(direccion))
                        Consulta = Consulta.Where(E => E.Direccion.Contains(direccion));
                    if (!string.IsNullOrEmpty(cp))
                        Consulta = Consulta.Where(E => E.CP.Contains(cp));
                    if (!string.IsNullOrEmpty(dni))
                        Consulta = Consulta.Where(E => E.DNI.Contains(dni));
                    if (!string.IsNullOrEmpty(telefono))
                        Consulta = Consulta.Where(E => E.Telefono.Contains(telefono));
                    if (fechaNacimiento.HasValue)
                        Consulta = Consulta.Where(E => E.FechaNacimiento == fechaNacimiento);
                    if (fechaAlta.HasValue)
                        Consulta = Consulta.Where(E => E.FechaAlta == fechaAlta);
                    if (fechaBaja.HasValue)
                        Consulta = Consulta.Where(E => E.FechaBaja == fechaBaja);

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

        #endregion

        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

            /// <summary>
            /// Inserta una explotación.
            /// </summary>
            /// <param name="explotacion">Explotación a insertar.</param>
            public static void Insertar(Explotacion explotacion)
            {
                BDController.BDOperaciones.Explotaciones.InsertOnSubmit(explotacion);
                BDController.BDOperaciones.SubmitChanges();
            }

            /// <summary>
            /// Actualiza una explotación.
            /// </summary>
            /// <param name="explotacion">Explotación a actualizar.</param>
            public static void Actualizar(Explotacion explotacion)
            {
                BDController.BDOperaciones.SubmitChanges();
            }

            /// <summary>
            /// Elimina una explotación.
            /// </summary>
            /// <param name="explotacion">Explotación a eliminar.</param>
            public static void Eliminar(Explotacion explotacion)
            {
                Explotacion ObjBorrar = BDController.BDOperaciones.Explotaciones.Single(c => c.Id == explotacion.Id);

                BDController.BDOperaciones.Explotaciones.DeleteOnSubmit(ObjBorrar);
                BDController.BDOperaciones.SubmitChanges();
                
            }
            


        #endregion
    }
}

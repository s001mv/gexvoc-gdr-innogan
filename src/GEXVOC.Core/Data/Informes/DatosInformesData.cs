using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Informes;

namespace GEXVOC.Core.Data
{
    public static class DatosInformesData
    {
        #region ANIMALES

        public static List<Animal> AnimalesImproductivos(int? idEspecie, DateTime? fechaInforme)
        {
            List<Animal> ListaObj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Animal> Consulta = BD.Animales;
                Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);  //Que perteneza a la explotación activa
                Consulta = Consulta.Where(E => E.Sexo == char.Parse("H"));                        //Que sean hembras.
                Consulta = Consulta.Where(E => E.Parto.Count == 0);                               //Que no tengan ningun parto.
                Consulta = Consulta.Where(E => E.Baja.Count == 0);                                //Que no se encuentren de baja.
                Consulta = Consulta.Where(E => !(E.Externo ?? false));                              //Que no sea externo a la explotación
                Consulta = Consulta.Where(E => E.FechaNacimiento.AddMonths(30) <= (fechaInforme ?? DateTime.Today));//Que tengan mas de 30 meses con respecto a la fecha del informe.

                if (idEspecie.HasValue)//Filtro por especie.
                    Consulta = Consulta.Where(E => E.Raza.IdEspecie == idEspecie);


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


        #endregion

        #region PRODUCCION

            #region LECHE

                public static List<Animal> HembrasLactacionXIntervalo(int idEspecie, DateTime fechaInicio, DateTime fechaFin)
                {
                    List<Animal> ListaObj = null;
                    GEXVOCDataContext BD = BDController.NuevoContexto;

                    try
                    {
                        var Consulta = (from A in BD.Animales
                                        from L in A.Lactacion
                                        where A.Id == L.IdHembra
                                        && A.IdExplotacion == Configuracion.Explotacion.Id
                                        && A.Raza.IdEspecie == idEspecie
                                        && A.Sexo == char.Parse("H")
                                        && A.Baja.Count == 0
                                        && !(A.Externo ?? false)
                                        && (L.FechaInicio <= fechaInicio && (L.FechaFin == null || L.FechaFin.Value >= fechaInicio))
                                        || (L.FechaInicio <= fechaFin && (L.FechaFin == null || L.FechaFin.Value >= fechaFin))
                                        || (L.FechaInicio >= fechaInicio && L.FechaInicio <= fechaFin)
                                        orderby A.Nombre
                                        select A).Distinct();

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

                public static List<Animal> HembrasMuestraXIntervalo(List<Animal> animales, DateTime fechaInicio, DateTime fechaFin)
                {
                    List<Animal> ListaObj = null;
                    GEXVOCDataContext BD = BDController.NuevoContexto;

                    try
                    {
                        var Consulta = (from A in BD.Animales
                                        from L in A.Lactacion
                                        from C in L.ControlLeche
                                        from M in C.MuestraControl
                                        where A.Id == L.IdHembra && L.Id == C.IdLactacion && C.Id == M.IdControl
                                        && animales.Contains(A)
                                        && M.Fecha >= fechaInicio && M.Fecha <= fechaFin
                                        orderby A.Nombre
                                        select A).Distinct();

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

            #region CARNE
                public struct IC
                {
                    public int IdAnimal;
                    public decimal KgAlimentoAsignaciones;
                    public decimal KgAlimentoPastoreo;
                    public Peso UltimoPeso;
                    public decimal ValorIC 
                    {
                        get 
                        {
                            decimal rtno=0;
                            decimal TotalKgAlimento = KgAlimentoAsignaciones + KgAlimentoPastoreo;
                            if (UltimoPeso!=null && UltimoPeso.Peso1!=0)                            
                                rtno = TotalKgAlimento / UltimoPeso.Peso1;
                            
                            return rtno;
                        }                                           
                    }
                    
                }
                public static IC ICAnimal(int idAnimal, DateTime? fechaInicio, DateTime? fechaFin)
                {
                    IC rtno = new IC();
                    rtno.IdAnimal = idAnimal;


                    GEXVOCDataContext BD = BDController.NuevoContexto;
                    try
                    {

                        //Obtengo el último peso
                        Peso UltimoPeso = null;
                        IQueryable<Peso> ConsultaUltimoPeso = BD.Pesos.Where(E=>E.IdAnimal==idAnimal);
                        if (fechaInicio.HasValue)
                            ConsultaUltimoPeso = ConsultaUltimoPeso.Where(E => E.Fecha >= fechaInicio);
                        if (fechaFin.HasValue)
                            ConsultaUltimoPeso = ConsultaUltimoPeso.Where(E => E.Fecha <= fechaFin);

                        UltimoPeso = ConsultaUltimoPeso.OrderByDescending(E => E.Fecha).FirstOrDefault();
                        Funciones.DescubrirPropiedades(UltimoPeso);
                            
                        rtno.UltimoPeso = UltimoPeso;              
                        //Nota: Ultimo peso puede valer nulo, hay que tener cuidado a la hora de utilizar la struct IC
                        

                        //Obtengo el valor para kgAlimentoAsignaciones que se busca en la tabla asignaciones
                        IQueryable<Asignacion> ConsultaAsignacion = BD.Asignaciones;
                        ConsultaAsignacion = ConsultaAsignacion.Where(E => E.IdAnimal == idAnimal);

                        if (fechaInicio.HasValue)
                            ConsultaAsignacion = ConsultaAsignacion.Where(E => E.FechaInicio >= fechaInicio);
                        if (fechaFin.HasValue)
                            ConsultaAsignacion = ConsultaAsignacion.Where(E => (E.FechaFin ?? E.FechaInicio) <= fechaFin);

                        if (ConsultaAsignacion.Count()>0) //(Solo hago la operacion si encontramos registros en la consulta.                    
                            rtno.KgAlimentoAsignaciones = ConsultaAsignacion.Sum(E => E.Racion.Peso * (E.Porcentaje / 100));                      

                    
                        var Pastoreo = from p in BD.Pastoreos
                                       join o in BD.AniLot
                                       on p.IdLote equals o.IdLote                                        
                                       where o.IdAnimal == idAnimal                                     
                                       select p;

                        if (fechaInicio.HasValue)
                            Pastoreo = Pastoreo.Where(E => E.FechaInicio >= fechaInicio);
                        if (fechaFin.HasValue)
                            Pastoreo = Pastoreo.Where(E => (E.FechaFin ?? E.FechaInicio) <= fechaFin );


                        ///Voy a calcular el total en kg de alimento en pastoreo para el animal en una sola consulta
                        ///La fórmula para el cáculo sería la siguiente:
                        ///Si  (Pastoreo.Total) //Si la cantidad puesta en pastoreo se refiere a la cantidad total
                        ///     KgAlimentoPastoreo = Pastoreo.Cantidad / Nº Animales en el lote
                        ///SiNo //La cantidad es una cantidad diaria no el total (en este caso siempre existe fechaFin
                        ///     KgAlimentoPastoreo = (Pastoreo.Cantidad * DiasEntre(Pastoreo.FechaFin,Pastoreo.FechaInicio)) / Nº Animales en el Lote

                        if (Pastoreo.Count() > 0)
                            rtno.KgAlimentoPastoreo = Pastoreo.Sum(E => (E.Total ?? false) ?
                                    ((E.Cantidad ?? 0) / E.LoteAnimal.AniLot.Count) :
                                    (((E.Cantidad ?? 0) * (E.FechaFin.Value - E.FechaInicio).Days) / E.LoteAnimal.AniLot.Count));                     


                    }
                    catch (Exception)
                    { }
                    finally
                    {
                        if (!BDController.TransaccionActiva)
                            BD.Dispose();
                    }

                    
                    return rtno;
                }

            #endregion


        #endregion

        #region ALIMENTACION

                public static List<Movimiento> ControlDeStockDeAlimentacion(int? idTipoProducto, int? idFamiliaProducto, 
                                                                        int? idProducto, int? idMacho, string origen, 
                                                                        DateTime? fechaInicial, DateTime? fechaFinal)
            {
                List<Movimiento> lista = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {

                    IQueryable<Movimiento> Consulta = BD.Movimiento;
                    Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);
             
                    if (idTipoProducto.HasValue)
                        Consulta = Consulta.Where(E => E.Producto.IdTipo == idTipoProducto);
                    if (idFamiliaProducto.HasValue)
                        Consulta = Consulta.Where(E => E.Producto.IdFamilia == idFamiliaProducto);
                    if (idProducto.HasValue)
                        Consulta = Consulta.Where(E => E.IdProducto == idProducto);
                    if (idMacho.HasValue)
                        Consulta = Consulta.Where(E => E.IdMacho == idMacho);
                    if (!string.IsNullOrEmpty(origen))
                        Consulta = Consulta.Where(E => E.Origen == origen);
                    if (fechaInicial != null)
                        Consulta = Consulta.Where(E => E.FechaEfecto >= fechaInicial);
                    if (fechaFinal != null)
                        Consulta = Consulta.Where(E => E.FechaEfecto <= fechaFinal);
                   

                    //Consulta = Consulta.OrderByDescending(E => E.Fecha);//Ordenacion Inicial
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

        #region SANIDAD
            public static List<Animal> ConsultaMorbilidad(int idEspecie, DateTime? fechaInicio, DateTime? fechaFin,int? idEstado)
            {
                List<Animal> ListaObj = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    IQueryable<Animal> Consulta = BD.Animales;
                    Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);  //Que perteneza a la explotación activa                        
                    Consulta = Consulta.Where(E => !(E.Externo ?? false));                            //Que no sea externo a la explotación                        
                    Consulta = Consulta.Where(E => E.Raza.IdEspecie == idEspecie);

                    if (idEstado.HasValue)
                        Consulta = Consulta.Where(E => E.IdEstado == idEstado);

                    if (fechaFin.HasValue)
                        Consulta = Consulta.Where(E => E.Alta.First().Fecha <= fechaFin);

                    if (fechaInicio.HasValue)
                        Consulta = Consulta.Where(E => E.Baja.First().Fecha >= fechaInicio | E.Baja.Count == 0);                       


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

            public static List<Animal> PrevalenciaEnfermedades(DateTime? fechaInicio, DateTime? fechaFin)
            {
                List<Animal> ListaObj = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    IQueryable<Animal> Consulta = BD.Animales;
                    Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);  //Que perteneza a la explotación activa                        
                    Consulta = Consulta.Where(E => !(E.Externo ?? false));                            //Que no sea externo a la explotación                        
                   

                    if (fechaFin.HasValue)
                        Consulta = Consulta.Where(E => E.Alta.First().Fecha <= fechaFin);

                    if (fechaInicio.HasValue)
                        Consulta = Consulta.Where(E => E.Baja.First().Fecha >= fechaInicio | E.Baja.Count == 0);


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
        
            #region MORTALIDAD

                public static int Muerte_Nacimimiento(int? idEspecie,DateTime? fechaInicio, DateTime? fechaFin)
                {
                    int rtno = 0;
                    List<Parto> ListaObj = null;
                    GEXVOCDataContext BD = BDController.NuevoContexto;
                    try
                    {
                        IQueryable<Parto> Consulta = BD.Partos;
                        Consulta = Consulta.Where(E => E.Animal.IdExplotacion==Configuracion.Explotacion.Id);

                        if (idEspecie.HasValue)
                            Consulta = Consulta.Where(E => E.Animal.Raza.IdEspecie == idEspecie);

                        if (fechaInicio.HasValue)
                            Consulta = Consulta.Where(E => E.Fecha >= fechaInicio);

                        if (fechaFin.HasValue)
                            Consulta = Consulta.Where(E => E.Fecha <= fechaFin);

                        //Consulta = Consulta.OrderBy(E => E.Fecha);
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
                    if (ListaObj!=null)
                        foreach (Parto item in ListaObj)                    
                            rtno += item.Muertos??0;





                    return rtno;
                }
                public static int Total_Nacimimientos(int? idEspecie, DateTime? fechaInicio, DateTime? fechaFin)
                {
                    int rtno = 0;
                    List<Parto> ListaObj = null;
                    GEXVOCDataContext BD = BDController.NuevoContexto;
                    try
                    {
                        IQueryable<Parto> Consulta = BD.Partos;
                        Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                        if (idEspecie.HasValue)
                            Consulta = Consulta.Where(E => E.Animal.Raza.IdEspecie == idEspecie);

                        if (fechaInicio.HasValue)
                            Consulta = Consulta.Where(E => E.Fecha >= fechaInicio);

                        if (fechaFin.HasValue)
                            Consulta = Consulta.Where(E => E.Fecha <= fechaFin);
                        
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
                    if (ListaObj != null)
                        foreach (Parto item in ListaObj)
                            rtno += (item.Vivos ?? 0) + (item.Muertos??0);

                    return rtno;
                }
                public static List<Animal> Muerte_Perinatal(int? idEspecie,DateTime? fechaInicio, DateTime? fechaFin)
                {  
                    List<Animal> ListaObj = null;
                    GEXVOCDataContext BD = BDController.NuevoContexto;
                    try
                    {
                        IQueryable<Animal> Consulta = BD.Animales;
                        Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);
                        Consulta = Consulta.Where(E => E.Baja.Count>0);
                        Consulta = Consulta.Where(E => E.Baja.First().Fecha <= E.Alta.First().Fecha.AddDays(15));
                        if (idEspecie.HasValue)
                            Consulta = Consulta.Where(E => E.Raza.IdEspecie == idEspecie);


                        if (fechaInicio.HasValue)
                            Consulta = Consulta.Where(E => E.Alta.First().Fecha >= fechaInicio);
                        if (fechaFin.HasValue)
                            Consulta = Consulta.Where(E => E.Baja.First().Fecha <= fechaFin);                   


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
                public static List<Animal> Muerte_Destete(int? idEspecie,DateTime? fechaInicio, DateTime? fechaFin)
                {
                    List<Animal> ListaObj = null;
                    GEXVOCDataContext BD = BDController.NuevoContexto;
                    try
                    {
                        IQueryable<Animal> Consulta = BD.Animales;
                        Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);
                        Consulta = Consulta.Where(E => E.FechaDestete.HasValue);
                        Consulta = Consulta.Where(E => E.Baja.Count > 0);
                        if (idEspecie.HasValue)
                            Consulta = Consulta.Where(E => E.Raza.IdEspecie == idEspecie);


                        //La fecha de baja debe ser mayor que 15 dias despues de la fecha de alta (de lo contrario sería una muerte perinatal)
                        Consulta = Consulta.Where(E => E.Baja.First().Fecha > E.Alta.First().Fecha.AddDays(15));
                        //La fecha de baja debe ser menor o igual a la fecha del destete + (15 dias)
                        Consulta = Consulta.Where(E => E.Baja.First().Fecha  <= E.FechaDestete.Value.AddDays(15));

                        if (fechaInicio.HasValue)
                            Consulta = Consulta.Where(E => E.Alta.First().Fecha >= fechaInicio);
                        if (fechaFin.HasValue)
                            Consulta = Consulta.Where(E => E.Baja.First().Fecha <= fechaFin);

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
                public static List<Animal> Muerte_PostDestete(int? idEspecie,DateTime? fechaInicio, DateTime? fechaFin)
                {
                    List<Animal> ListaObj = null;
                    GEXVOCDataContext BD = BDController.NuevoContexto;
                    try
                    {
                        IQueryable<Animal> Consulta = BD.Animales;
                        Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);
                        Consulta = Consulta.Where(E => E.FechaDestete.HasValue);
                        Consulta = Consulta.Where(E => E.Baja.Count > 0);

                        if (idEspecie.HasValue)
                            Consulta = Consulta.Where(E => E.Raza.IdEspecie == idEspecie);

                        //La fecha de baja debe ser mayor que la fecha de destete + 15 días
                        Consulta = Consulta.Where(E => E.Baja.First().Fecha > E.FechaDestete.Value.AddDays(15));                   

                        if (fechaInicio.HasValue)
                            Consulta = Consulta.Where(E => E.Alta.First().Fecha >= fechaInicio);
                        if (fechaFin.HasValue)
                            Consulta = Consulta.Where(E => E.Baja.First().Fecha <= fechaFin);

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
            #endregion

                
            public static List<TratEnfermedad> AnimalesEnTratamiento(DateTime? fechaInicio, DateTime? fechaFin)
                {
                    List<TratEnfermedad> ListaObj = null;
                    GEXVOCDataContext BD = BDController.NuevoContexto;
                    try
                    {
                        IQueryable<TratEnfermedad> Consulta = BD.TratsEnfermedades;
                        Consulta = Consulta.Where(E => E.DiagAnimal.Animal.IdExplotacion == Configuracion.Explotacion.Id);  //Que perteneza a la explotación activa                        

                        //Nota: Hay que prestar atención al filtro por fechas, ya que no se mostrarán solo los tratamientos que entren en este intervalo, puesto que el intervalo lo que define es la busqueda de animales que tengan un tratamiento dentro del intervalo específico, pero dicho tratamiento puede durar más que el propio intervalo del filtro y debe seguir mostrandose a pesar de todo.
                        //Para solucionar este problema, el filtro que se aplica será el siguiente:
                        //La fecha del tratamiento debe estar entre (FInicio - Duracion Tratamiento) y (FFin + Duración Tratamiento)

                        if (fechaInicio.HasValue)
                            Consulta = Consulta.Where(E => E.Fecha>=fechaInicio.Value.AddDays((E.Duracion>1000?0:E.Duracion) * -1));
                        if (fechaFin.HasValue)
                            Consulta = Consulta.Where(E => E.Fecha <= fechaFin.Value.AddDays(E.Duracion > 1000 ? 0 : E.Duracion));
                        
                    
                        Consulta = Consulta.OrderByDescending(E => E.Fecha);
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
        #endregion

        #region REPRODUCCIÓN

            #region ESTADÍSTICAS DE FERTILIDAD

            public static List<Inseminacion> UltimasInseminacionesXIntervalo(int idExplotacion, int idEspecie, DateTime inicio, DateTime fin)
            {
                List<Inseminacion> ListaObj = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;

                try
                {
                    var Consulta = from A in BD.Animales
                                   from I in A.Inseminacion1
                                   where A.IdExplotacion == idExplotacion
                                   && A.Raza.IdEspecie == idEspecie
                                   && I.Fecha >= inicio && I.Fecha <= fin
                                   && I.Fecha == (from N in A.Inseminacion1
                                                  where I.Id == N.Id
                                                  select N.Fecha).Max()
                                   orderby I.Fecha
                                   select I;

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

            #region PARTOS

            public static List<Parto> UltimosPartosXIntervalo(int idExplotacion, int idEspecie, DateTime inicio, DateTime fin)
            {
                List<Parto> ListaObj = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;

                try
                {
                    var Consulta = from A in BD.Animales
                                   from P in A.Parto
                                   where A.IdExplotacion == idExplotacion
                                   && A.Raza.IdEspecie == idEspecie
                                   && P.Fecha >= inicio && P.Fecha <= fin
                                   && P.Numero == (from M in A.Parto
                                                   where P.Id == M.Id
                                                   select M.Numero).Max()
                                   orderby P.Fecha
                                   select P;

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

            public static List<Parto> PartosXIntervalo(int idExplotacion, int idEspecie, DateTime inicio, DateTime fin)
            {
                List<Parto> ListaObj = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;

                try
                {
                    var Consulta = from A in BD.Animales
                                   from P in A.Parto
                                   where A.IdExplotacion == idExplotacion
                                   && A.Raza.IdEspecie == idEspecie
                                   && P.Fecha >= inicio && P.Fecha <= fin
                                   orderby P.Fecha
                                   select P;

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

            public static List<Aborto> AbortosXIntervalo(int idExplotacion, int idEspecie, DateTime inicio, DateTime fin)
            {
                List<Aborto> ListaObj = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;

                try
                {
                    var Consulta = from A in BD.Animales
                                   from B in A.Aborto
                                   where A.IdExplotacion == idExplotacion
                                   && A.Raza.IdEspecie == idEspecie
                                   && B.Fecha >= inicio && B.Fecha <= fin
                                   orderby B.Fecha
                                   select B;

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

            public static List<Animal> HembrasXEdadIntervalo(int idExplotacion, int idEspecie, int? edadInicio, int? edadFin, DateTime inicio, DateTime fin)
            {
                List<Animal> ListaObj = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;

                try
                {
                    var Consulta = from A in BD.Animales
                                   where A.IdExplotacion == idExplotacion
                                   && A.Raza.IdEspecie == idEspecie
                                   && A.Sexo == char.Parse("H")
                                   && !(A.Externo ?? false)
                                   && A.Alta.First().Fecha <= fin
                                   && A.Baja.Count == 0 || A.Baja.First().Fecha >= inicio
                                   select A;

                    if (edadInicio != null)
                        Consulta = Consulta.Where(A => Convert.ToInt32((fin.Subtract(A.FechaNacimiento).Days / 30)) >= edadInicio);

                    if (edadFin != null)
                        Consulta = Consulta.Where(A => Convert.ToInt32(fin.Subtract(A.FechaNacimiento).Days / 30) <= edadFin);

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

            public static List<Animal> AnimalesNacidosGenealogia(int? idLote, DateTime? fechaInicio, DateTime? fechaFin,int? idEspecie)
            {
                List<Animal> ListaObj = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    if (idLote.HasValue)
                    {
                        ///Busco todos los animales cuyos padres se encuentren en el lote especificado
                        ///tambien aplico el filtro entre fechas segun su nacimiento.
                        
                        ///Obtengo los animales del lote especificado
                        ///Nota: hay que tener en cuenta que el lote puede ser una paridera, con lo que debo
                        ///obtener los animales de cada uno de los lotes asociados a la misma.
                        var AniLot = from p in BD.Animales
                                  join o in BD.AniLot                                      
                                  on p.Id equals o.IdAnimal
                                  where o.IdLote == idLote.Value | o.LoteAnimal.IdParidera == idLote
                                  select p;

                        if (idEspecie.HasValue)//Permito filtrar por la especie
                            AniLot = AniLot.Where(E => E.Raza.IdEspecie == idEspecie);

                        
                        ///Obtengo los animales que tengan genealogía cuya madre se encuentre en la anterior consulta
                        var Consulta = from a in BD.Animales
                                       from p in AniLot
                                       where a.LibroGenealogico.Count == 1
                                       where a.LibroGenealogico.First().Madre == p.DIB
                                       select (a);

                           
                        if (fechaInicio.HasValue)
                            Consulta = Consulta.Where(E => E.FechaNacimiento >= fechaInicio);
                        if (fechaFin.HasValue)
                            Consulta = Consulta.Where(E => E.FechaNacimiento <= fechaFin);                       

                        Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                        //(estas propiedades se utilizan habitualmente en los grids)
                        ListaObj = Consulta.ToList();
                    }
                    else
                    {
                        //Busco todos los animales de la explotacion que hayan nacido en el rango de fechas especificado.
                        IQueryable<Animal> Consulta = BD.Animales;
                        Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);
                        Consulta = Consulta.Where(E => !(E.Externo ?? false));//Que sea interno de la explotacion                        


                        if (fechaInicio.HasValue)
                            Consulta = Consulta.Where(E => E.FechaNacimiento >= fechaInicio);
                        if (fechaFin.HasValue)
                            Consulta = Consulta.Where(E => E.FechaNacimiento <= fechaFin);
                        if (idEspecie.HasValue)//Permito filtrar por la especie
                            Consulta = Consulta.Where(E => E.Raza.IdEspecie == idEspecie);


                        Consulta = Consulta.OrderBy(E => E.Nombre);
                        Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                        //(estas propiedades se utilizan habitualmente en los grids)
                        ListaObj = Consulta.ToList();                    
                    }
                    
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (!BDController.TransaccionActiva)
                        BD.Dispose();
                }
                

              
                    
                return ListaObj;
                
            }

            public static List<Animal> AnimalesDestetados(int? idLote, DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie)
            {
                List<Animal> ListaObj = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    if (idLote.HasValue)
                    {
                        ///Busco todos los animales cuyos padres se encuentren en el lote especificado
                        ///tambien aplico el filtro entre fechas segun su nacimiento.

                        ///Obtengo los animales del lote especificado
                        ///Nota: hay que tener en cuenta que el lote puede ser una paridera, con lo que debo
                        ///obtener los animales de cada uno de los lotes asociados a la misma.
                        var AniLot = from p in BD.Animales
                                     join o in BD.AniLot
                                     on p.Id equals o.IdAnimal
                                     where o.IdLote == idLote.Value | o.LoteAnimal.IdParidera == idLote
                                     select p;

                        if (idEspecie.HasValue)//Permito filtrar por la especie
                            AniLot = AniLot.Where(E => E.Raza.IdEspecie == idEspecie);


                        ///Obtengo los animales que tengan genealogía cuya madre se encuentre en la anterior consulta
                        var Consulta = from a in BD.Animales
                                       from p in AniLot
                                       where a.LibroGenealogico.Count == 1
                                       where a.LibroGenealogico.First().Madre == p.DIB
                                       where a.FechaDestete.HasValue
                                       select (a);
                       
                            
                       

                        if (fechaInicio.HasValue)
                            Consulta = Consulta.Where(E => E.FechaDestete >= fechaInicio);
                        if (fechaFin.HasValue)
                            Consulta = Consulta.Where(E => E.FechaDestete <= fechaFin);

                        Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                        //(estas propiedades se utilizan habitualmente en los grids)
                        ListaObj = Consulta.ToList();
                    }
                    else
                    {
                        //Busco todos los animales de la explotacion que hayan nacido en el rango de fechas especificado.
                        IQueryable<Animal> Consulta = BD.Animales;
                        Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);
                        Consulta = Consulta.Where(E => !(E.Externo ?? false));//Que sea interno de la explotacion
                        Consulta = Consulta.Where(E => E.FechaDestete.HasValue);


                        if (fechaInicio.HasValue)
                            Consulta = Consulta.Where(E => E.FechaDestete >= fechaInicio);
                        if (fechaFin.HasValue)
                            Consulta = Consulta.Where(E => E.FechaDestete <= fechaFin);
                        if (idEspecie.HasValue)//Permito filtrar por la especie
                            Consulta = Consulta.Where(E => E.Raza.IdEspecie == idEspecie);


                        Consulta = Consulta.OrderBy(E => E.Nombre);
                        Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                        //(estas propiedades se utilizan habitualmente en los grids)
                        ListaObj = Consulta.ToList();
                    }

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (!BDController.TransaccionActiva)
                        BD.Dispose();
                }




                return ListaObj;

            }

            public static List<Animal> HijosDeUnLote(int idLote,int? idEspecie)             
            {
                List<Animal> ListaObj = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                ///Busco todos los animales cuyos padres se encuentren en el lote especificado
                ///tambien aplico el filtro entre fechas segun su nacimiento.

                ///Obtengo los animales del lote especificado
                ///Nota: hay que tener en cuenta que el lote puede ser una paridera, con lo que debo
                ///obtener los animales de cada uno de los lotes asociados a la misma.
                var AniLot = from p in BD.Animales
                             join o in BD.AniLot
                             on p.Id equals o.IdAnimal
                             where o.IdLote == idLote | o.LoteAnimal.IdParidera == idLote
                             where p.IdExplotacion == Configuracion.Explotacion.Id
                             select p;

                if (idEspecie.HasValue)//Permito filtrar por la especie
                    AniLot = AniLot.Where(E => E.Raza.IdEspecie == idEspecie);


                ///Obtengo los animales que tengan genealogía cuya madre se encuentre en la anterior consulta
                var Consulta = from a in BD.Animales
                               from p in AniLot                               
                               where a.LibroGenealogico.Count == 1
                               where a.LibroGenealogico.First().Madre == p.DIB
                               select (a);


                ListaObj = Consulta.ToList();
                return ListaObj;
            }


            public static List<Animal> AnimalesDeUnLote(int idLote, int? idEspecie)
            {
                List<Animal> ListaObj = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                ///Busco todos los animales cuyos padres se encuentren en el lote especificado
                ///tambien aplico el filtro entre fechas segun su nacimiento.

                ///Obtengo los animales del lote especificado
                ///Nota: hay que tener en cuenta que el lote puede ser una paridera, con lo que debo
                ///obtener los animales de cada uno de los lotes asociados a la misma.
                var AniLot = from p in BD.Animales
                             join o in BD.AniLot
                             on p.Id equals o.IdAnimal
                             where o.IdLote == idLote | o.LoteAnimal.IdParidera == idLote
                             where p.IdExplotacion == Configuracion.Explotacion.Id
                             select p;

                if (idEspecie.HasValue)//Permito filtrar por la especie
                    AniLot = AniLot.Where(E => E.Raza.IdEspecie == idEspecie);

                ListaObj = AniLot.ToList();
                return ListaObj;
            }
            public struct DatosProlificidad 
            {
                public int idAnimal;
                public int vivos;
                public int muertos;
                public int partos;
                public int abortos;
            }

            public static DatosProlificidad ProlificidadAnimal(int idAnimal, DateTime? fechaInicio, DateTime? fechaFin) 
            {
                DatosProlificidad  rtno= new DatosProlificidad();
                rtno.idAnimal = idAnimal;

             
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    IQueryable<Parto> ConsultaPartos = BD.Partos;
                    ConsultaPartos = ConsultaPartos.Where(E => E.IdHembra == idAnimal);

                    if (fechaInicio.HasValue)
                        ConsultaPartos = ConsultaPartos.Where(E => E.Fecha >= fechaInicio);
                    if (fechaFin.HasValue)
                        ConsultaPartos = ConsultaPartos.Where(E => E.Fecha <= fechaFin);



                  
                    rtno.vivos = ConsultaPartos.Sum(E => E.Vivos ?? 0);
                    rtno.muertos = ConsultaPartos.Sum(E => E.Muertos ?? 0);
                    rtno.partos = ConsultaPartos.Count();

                    IQueryable<Aborto> ConsultaAbortos = BD.Abortos;
                    ConsultaAbortos = ConsultaAbortos.Where(E => E.IdHembra == idAnimal);

                    if (fechaInicio.HasValue)
                        ConsultaPartos = ConsultaPartos.Where(E => E.Fecha >= fechaInicio);
                    if (fechaFin.HasValue)
                        ConsultaPartos = ConsultaPartos.Where(E => E.Fecha <= fechaFin);

                    
                    rtno.abortos = ConsultaAbortos.Count();


               
                }
                catch (Exception)
                { }
                finally
                {
                    if (!BDController.TransaccionActiva)
                        BD.Dispose();
                }
                return rtno;            
            }
          
            public static List<Parto>  MuerteNacimiento(int? idLote, DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie)
            {
                List<Parto> ListaObj = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    if (idLote.HasValue)
                    {
                        ///Busco todos los animales cuyos padres se encuentren en el lote especificado
                        ///tambien aplico el filtro entre fechas segun su nacimiento.

                        ///Obtengo los animales del lote especificado
                        ///Nota: hay que tener en cuenta que el lote puede ser una paridera, con lo que debo
                        ///obtener los animales de cada uno de los lotes asociados a la misma.
                        var AniLot = from p in BD.Animales
                                     join o in BD.AniLot
                                     on p.Id equals o.IdAnimal
                                     where o.IdLote == idLote.Value | o.LoteAnimal.IdParidera == idLote
                                     where p.IdExplotacion==Configuracion.Explotacion.Id
                                     select p;


                        if (idEspecie.HasValue)//Permito filtrar por la especie
                            AniLot = AniLot.Where(E => E.Raza.IdEspecie == idEspecie);


                        ///Obtengo los animales que tengan genealogía cuya madre se encuentre en la anterior consulta
                        var Consulta = from a in BD.Partos
                                       join p in AniLot
                                       on a.IdHembra equals p.Id
                                       where a.Muertos.HasValue & a.Muertos.Value>0
                                       select (a);


                        if (fechaInicio.HasValue)
                            Consulta = Consulta.Where(E => E.Fecha >= fechaInicio);
                        if (fechaFin.HasValue)
                            Consulta = Consulta.Where(E => E.Fecha <= fechaFin);

                        Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                        //(estas propiedades se utilizan habitualmente en los grids)
                        ListaObj = Consulta.ToList();
                    }
                    else
                    {
                        //Busco todos los animales de la explotacion que hayan nacido en el rango de fechas especificado.
                        IQueryable<Parto> Consulta = BD.Partos;
                        Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);                                                 
                        Consulta = Consulta.Where(E => E.Muertos.HasValue & E.Muertos.Value>0);
                        Consulta = Consulta.Where(E => !(E.Animal.Externo ?? false));//Que sea interno de la explotacion
                       
                        
                        if (fechaInicio.HasValue)
                            Consulta = Consulta.Where(E => E.Fecha >= fechaInicio);
                        if (fechaFin.HasValue)
                            Consulta = Consulta.Where(E => E.Fecha <= fechaFin);
                        if (idEspecie.HasValue)//Permito filtrar por la especie
                            Consulta = Consulta.Where(E => E.Animal.Raza.IdEspecie == idEspecie);

                        Consulta = Consulta.OrderByDescending(E => E.Fecha);
                        Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                        //(estas propiedades se utilizan habitualmente en los grids)
                        ListaObj = Consulta.ToList();
                    }

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (!BDController.TransaccionActiva)
                        BD.Dispose();
                }




                return ListaObj;

            }
            public static List<Animal> MuertePerinatal(int? idLote, DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie)
            {
                List<Animal> ListaObj = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    if (idLote.HasValue)
                    {                       
                        ///Me aprobecho de la consulta que tengo hecha en  Muerte_Perinatal y simplemente 
                        ///establezo la restricción de que los animales de dicha consulta sean hijos del lote especifico, de lo 
                        ///contrario no tiene sentido que los muestre.
                        var Consulta = from p in DatosInformesData.Muerte_Perinatal(idEspecie, fechaInicio, fechaFin)
                                       join o in HijosDeUnLote(idLote.Value, idEspecie)                                                                                                                       
                                       on p.Id equals o.Id                                
                                       select (p);
                            
                        ListaObj = Consulta.ToList();
                    }
                    else
                    {
                        ListaObj = DatosInformesData.Muerte_Perinatal(idEspecie, fechaInicio, fechaFin);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (!BDController.TransaccionActiva)
                        BD.Dispose();
                }

                return ListaObj;

            }
            public static List<Animal> MuerteDestete(int? idLote, DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie)
            {
                List<Animal> ListaObj = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    if (idLote.HasValue)
                    {
                        ///Me aprobecho de la consulta que tengo hecha en  Muerte_Perinatal y simplemente 
                        ///establezo la restricción de que los animales de dicha consulta sean hijos del lote especifico, de lo 
                        ///contrario no tiene sentido que los muestre.
                        var Consulta = from p in DatosInformesData.Muerte_Destete(idEspecie, fechaInicio, fechaFin)
                                       join o in HijosDeUnLote(idLote.Value, idEspecie)
                                       on p.Id equals o.Id
                                       select (p);

                        ListaObj = Consulta.ToList();
                    }
                    else
                    {
                        ListaObj = DatosInformesData.Muerte_Destete(idEspecie, fechaInicio, fechaFin);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (!BDController.TransaccionActiva)
                        BD.Dispose();
                }

                return ListaObj;

            }
            public static List<Animal> MuertePostDestete(int? idLote, DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie)
            {
                List<Animal> ListaObj = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    if (idLote.HasValue)
                    {
                        ///Me aprobecho de la consulta que tengo hecha en  Muerte_Perinatal y simplemente 
                        ///establezo la restricción de que los animales de dicha consulta sean hijos del lote especifico, de lo 
                        ///contrario no tiene sentido que los muestre.
                        var Consulta = from p in DatosInformesData.Muerte_PostDestete(idEspecie, fechaInicio, fechaFin)
                                       join o in HijosDeUnLote(idLote.Value, idEspecie)
                                       on p.Id equals o.Id
                                       select (p);

                        ListaObj = Consulta.ToList();
                    }
                    else
                    {
                        ListaObj = DatosInformesData.Muerte_PostDestete(idEspecie, fechaInicio, fechaFin);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (!BDController.TransaccionActiva)
                        BD.Dispose();
                }

                return ListaObj;

            }

            /// <summary>
            /// Retorna los animales que han estado vigentes en las condiciones del filtro.
            /// Nota: puede ser que aparezan animales que ya estan de baja, pero que han estado activos en alguna parte del intervalo del filtro.
            /// </summary>
            /// <param name="fechaInicio">Inicio del Intervalo</param>
            /// <param name="fechaFin">Fin del Intervalo</param>
            /// <param name="idEspecie">>Especie por la que se ha de filtrar</param>
            /// <returns></returns>
            public static List<Animal> AnimalesActivos(DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie)
            {
                List<Animal> ListaObj =null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    IQueryable<Animal> Consulta = BD.Animales;
                    Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);  //Que perteneza a la explotación activa                        
                    Consulta = Consulta.Where(E => !(E.Externo ?? false));    //Que no sea externo a la explotación                        

                    if (idEspecie.HasValue)                    
                        Consulta = Consulta.Where(E => E.Raza.IdEspecie == idEspecie); 
                    if (fechaFin.HasValue)
                        Consulta = Consulta.Where(E => E.Alta.First().Fecha <= fechaFin);
                    if (fechaInicio.HasValue)
                        Consulta = Consulta.Where(E => E.Baja.First().Fecha >= fechaInicio | E.Baja.Count == 0);

                    Consulta = Consulta.OrderBy(E => E.Nombre);                   
                
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

            /// <summary>
            /// Retorna el nº de Hembras que han tenido su primer parto en el intervalo especifico
            /// </summary>
            /// <param name="fechaInicio">Inicio del Intervalo</param>
            /// <param name="fechaFin">Fin del Intervalo</param>
            /// <param name="idEspecie">>Especie por la que se ha de filtrar</param>
            /// <returns></returns>
            public static List<Parto> Primiparas(DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie)
            {
             
                List<Parto> rtno = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    IQueryable<Parto> Consulta = BD.Partos;
                    Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);  //Que perteneza a la explotación activa                        
                    Consulta = Consulta.Where(E => E.Numero==1); //Solo los partos que sean nº 1 (primiparas)
                    
                   
                    if (idEspecie.HasValue)
                        Consulta = Consulta.Where(E => E.Animal.Raza.IdEspecie == idEspecie);                    
                    if (fechaInicio.HasValue)
                        Consulta = Consulta.Where(E => E.Fecha >= fechaInicio );
                    if (fechaFin.HasValue)
                        Consulta = Consulta.Where(E => E.Fecha <= fechaFin);

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
            public static List<Parto> Multiparas(DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie)
            {

                List<Parto> rtno = null;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    IQueryable<Parto> Consulta = BD.Partos;
                    Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);  //Que perteneza a la explotación activa                        
                    Consulta = Consulta.Where(E => E.Numero > 1); //Solo los partos que sean nº 1 (primiparas)


                    if (idEspecie.HasValue)
                        Consulta = Consulta.Where(E => E.Animal.Raza.IdEspecie == idEspecie);
                    if (fechaInicio.HasValue)
                        Consulta = Consulta.Where(E => E.Fecha >= fechaInicio);
                    if (fechaFin.HasValue)
                        Consulta = Consulta.Where(E => E.Fecha <= fechaFin);

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
            /// Los retorna el nº de partos que se han producido satifaciendo las condiciones del filtro
            /// </summary>
            /// <param name="fechaInicio">Inicio del Intervalo</param>
            /// <param name="fechaFin">Fin del Intervalo</param>
            /// <param name="idEspecie">Especie por la que se ha de filtrar</param>
            /// <returns></returns>
            public static int NumPartos(DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie)
            {
                int rtno = 0;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    IQueryable<Parto> Consulta = BD.Partos;
                    Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);  //Que perteneza a la explotación activa                        
                    Consulta = Consulta.Where(E => !(E.Animal.Externo ?? false));

                    if (idEspecie.HasValue)
                        Consulta = Consulta.Where(E => E.Animal.Raza.IdEspecie == idEspecie);
                    if (fechaInicio.HasValue)
                        Consulta = Consulta.Where(E => E.Fecha >= fechaInicio);
                    if (fechaFin.HasValue)
                        Consulta = Consulta.Where(E => E.Fecha <= fechaFin);

                    rtno = Consulta.Count();

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
            /// Los retorna el nº de abortos que se han producido satifaciendo las condiciones del filtro
            /// </summary>
            /// <param name="fechaInicio">Inicio del Intervalo</param>
            /// <param name="fechaFin">Fin del Intervalo</param>
            /// <param name="idEspecie">Especie por la que se ha de filtrar</param>
            /// <returns></returns>
            public static int NumAbortos(DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie)
            {
                int rtno = 0;
                GEXVOCDataContext BD = BDController.NuevoContexto;
                try
                {
                    IQueryable<Aborto> Consulta = BD.Abortos;
                    Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);  //Que perteneza a la explotación activa                        
                    Consulta = Consulta.Where(E => !(E.Animal.Externo ?? false));

                    if (idEspecie.HasValue)
                        Consulta = Consulta.Where(E => E.Animal.Raza.IdEspecie == idEspecie);
                    if (fechaInicio.HasValue)
                        Consulta = Consulta.Where(E => E.Fecha >= fechaInicio);
                    if (fechaFin.HasValue)
                        Consulta = Consulta.Where(E => E.Fecha <= fechaFin);

                    rtno = Consulta.Count();

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

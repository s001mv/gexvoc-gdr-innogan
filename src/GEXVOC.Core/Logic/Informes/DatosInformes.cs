using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Informes;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public static class DatosInformes
    {
        #region FUNCIONES GENERALES
        /// <summary>
        /// Esta función se encarga de inicializar los valores de una fila con las propiedades
        /// de un objeto del tipo iclasebase que coinciden con el nombre de sus columnas.
        ///     Ej: Fila["Nombre"]=ClaseBase.Nombre
        /// </summary>
        /// <param name="clasebase">Origen de los datos (Tipo IClaseBase)</param>
        /// <param name="fila">Destino de los datos (Tipo DataRow)</param>
        public static void ClaseBaseToRow(IClaseBase clasebase, System.Data.DataRow fila)
        {
            if (clasebase == null)
                throw new ArgumentException("La ClaseBase debe terner un valor", "clasebase");
            if (fila == null)
                throw new ArgumentException("La Fila debe terner un valor", "fila");

            foreach (System.Data.DataColumn item in fila.Table.Columns)
            {
                try
                {
                    System.Reflection.PropertyInfo propiedad = clasebase.GetType().GetProperty(item.ColumnName);
                    if (propiedad != null)
                    {
                        object valor = propiedad.GetValue(clasebase, null);
                        if (valor != null)
                            fila[item.ColumnName] = valor;
                    }
                }
                catch (Exception ex)
                { Traza.RegistrarError(ex); }



            }

        }

        #endregion

        #region INFORMES / ANIMALES
        public static ListadoAnimalesDS ListadoAnimales(int? id, int? idRaza, int? idEstado, int? idTalla, int? idConformacion, int? idExplotacion, string DIB,
                                                string crotal, string tatuaje, string nombre, DateTime? fechaNacimiento, char? sexo, Boolean? testaje,
                                                Boolean? aptoNovillas, Boolean? mostrarBajas, int? idEspecie,
                                                int? idTipoAlta, DateTime? fechaAlta, string detalleAlta,
                                                int? idTipoBaja, DateTime? fechaBaja, string detalleBaja,Boolean? incluirExternos)
        {
            ListadoAnimalesDS datos = new ListadoAnimalesDS();
            List<Animal> lstAnimales = Animal.BuscarAmpliado(id, idRaza, idEstado, idTalla, idConformacion, idExplotacion, DIB,
                                                   crotal, tatuaje, nombre, fechaNacimiento, sexo, testaje,
                                                   aptoNovillas, mostrarBajas, idEspecie,
                                                   idTipoAlta, fechaAlta, detalleAlta,
                                                   idTipoBaja, fechaBaja, detalleBaja, incluirExternos);
            foreach (Animal animal in lstAnimales)
            {
                ///Pueden exitir casos en los que externo e identificado valen nulll
                ///Si es este caso significa que dichos valores están a Falso
                ///En esta asignación fuerzo esta característica para que salgan en el listado como Si/No puesto que si 
                ///el campo se encuentra a null por defecto no tendría representación
                if (!animal.Externo.HasValue) animal.Externo = false;
                if (!animal.Identificado.HasValue) animal.Identificado = false;

                ListadoAnimalesDS.AnimalRow fila = datos.Animal.NewAnimalRow();
                
                ClaseBaseToRow(animal, fila);
                datos.Animal.AddAnimalRow(fila);
            }


            return datos;
        }

        public static AnimalesImproductivosDS AnimalesImproductivos(int? idEspecie, DateTime fechaInforme)
        {
            AnimalesImproductivosDS datos = new AnimalesImproductivosDS();
            foreach (Animal animal in DatosInformesData.AnimalesImproductivos(idEspecie, fechaInforme))
            {
                AnimalesImproductivosDS.AnimalesImproductivosRow fila = datos.AnimalesImproductivos.NewAnimalesImproductivosRow();
                ClaseBaseToRow(animal, fila);

                TimeSpan Span = fechaInforme.Subtract(animal.FechaNacimiento);
                fila.MesesSinParto = Span.TotalDays / 30; //Aproximación de meses.

                datos.AnimalesImproductivos.AddAnimalesImproductivosRow(fila);

            }
            return datos;
        }
        public static HistorialDeEnfermedadesDS HistorialEnfermedades(DateTime? fechaInicio, DateTime? fechaFin, int? idPersonal, int? idEnfermedad, List<Animal> lstAnimales)
        {
            HistorialDeEnfermedadesDS datos = new HistorialDeEnfermedadesDS();
            int TotalDiagnosticos = 0;

            foreach (Animal animal in lstAnimales)
            {
                HistorialDeEnfermedadesDS.AnimalRow FilaAnimal = datos.Animal.NewAnimalRow();

                ClaseBaseToRow(animal, FilaAnimal);
                datos.Animal.AddAnimalRow(FilaAnimal);

                List<DiagAnimal> lstDiagnosticos = DiagAnimal.Buscar(animal.Id, idPersonal, fechaInicio, fechaFin, idEnfermedad);
                TotalDiagnosticos += lstDiagnosticos.Count;

                foreach (DiagAnimal diag in lstDiagnosticos)
                {
                    HistorialDeEnfermedadesDS.DiagnosticoRow FilaDiag = datos.Diagnostico.NewDiagnosticoRow();
                    ClaseBaseToRow(diag, FilaDiag);
                    datos.Diagnostico.AddDiagnosticoRow(FilaDiag);


                    foreach (TratEnfermedad trat in diag.lstTratEnfermedad)
                    {
                        HistorialDeEnfermedadesDS.TratEnfermedadRow FilaTrat = datos.TratEnfermedad.NewTratEnfermedadRow();
                        ClaseBaseToRow(trat, FilaTrat);
                        datos.TratEnfermedad.AddTratEnfermedadRow(FilaTrat);

                        foreach (Receta receta in trat.lstRecetas)
                        {
                            HistorialDeEnfermedadesDS.RecetaRow FilaReceta = datos.Receta.NewRecetaRow();
                            ClaseBaseToRow(receta, FilaReceta);
                            datos.Receta.AddRecetaRow(FilaReceta);
                        }
                    }
                }

            }

            if (TotalDiagnosticos == 0)
                throw new LogicException("Informe sin datos");

            return datos;
        }


        #region FICHA DEL ANIMAL

            public static FichaAnimalDS FichaAnimal(int idAnimal, DateTime? fechaInicio, DateTime? fechaFin)
            {
                return FichaAnimal(Animal.Buscar(idAnimal), fechaInicio, fechaFin);

            }
            public static FichaAnimalDS FichaAnimal(Animal animal, DateTime? fechaInicio, DateTime? fechaFin)
            {
                if (animal == null)
                    throw new ArgumentException("Debe especificar un animal válido", "animal");

                FichaAnimalDS datos = new FichaAnimalDS();

                //PREPARO LOS DATOS DEL INFORME PRINCIPAL
                FichaAnimalDS.AnimalRow fila = datos.Animal.NewAnimalRow();
                DatosInformes.ClaseBaseToRow(animal, fila);//Asignamos las propiedades comunes

                //Si tiene fotografía la cargamos como un array de bytes.
                if (animal.ImagenCargada != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(animal.ImagenCargada.ToArray());
                    fila.Fotografia = ms.ToArray();
                }
                datos.Animal.AddAnimalRow(fila);//Añadimos la fila ya preparada

                return datos;
            }


            public static CelosDS Celos(int idAnimal, DateTime? fechaInicio, DateTime? fechaFin)
            {

                CelosDS datos = new CelosDS();
                List<Celo> lstCelos = Celo.Buscar(idAnimal, null, fechaInicio, fechaFin);
                foreach (Celo celo in lstCelos)
                {
                    CelosDS.CeloRow fila = datos.Celo.NewCeloRow();
                    ClaseBaseToRow(celo, fila);
                    datos.Celo.AddCeloRow(fila);
                }
                return datos;
            }
            public static SincCelosDS SincCelos(int idAnimal, DateTime? fechaInicio, DateTime? fechaFin)
            {

                SincCelosDS datos = new SincCelosDS();
                List<SincronizacionCelo> lstCelos = SincronizacionCelo.Buscar(idAnimal, fechaInicio, fechaFin);
                foreach (SincronizacionCelo SincCelo in lstCelos)
                {
                    SincCelosDS.SincronizacionCeloRow fila = datos.SincronizacionCelo.NewSincronizacionCeloRow();
                    ClaseBaseToRow(SincCelo, fila);
                    if (SincCelo.FechaColocacion.HasValue)
                        fila.DescTipo = "ESPONJA";
                    if (SincCelo.FechaInyeccion.HasValue)
                        fila.DescTipo = "INYECCIÓN HORMONAL";


                    datos.SincronizacionCelo.AddSincronizacionCeloRow(fila);
                }
                return datos;
            }
            public static InseminacionesDS Inseminaciones(int idAnimal, DateTime? fechaInicio, DateTime? fechaFin)
            {

                InseminacionesDS datos = new InseminacionesDS();
                List<Inseminacion> lstInseminaciones = Inseminacion.Buscar(idAnimal, fechaInicio, fechaFin);
                foreach (Inseminacion inseminacion in lstInseminaciones)
                {
                    InseminacionesDS.InseminacionRow fila = datos.Inseminacion.NewInseminacionRow();
                    ClaseBaseToRow(inseminacion, fila);
                    datos.Inseminacion.AddInseminacionRow(fila);
                }
                return datos;
            }

            public static DiagGestacionDS DiagGestacion(int idAnimal, DateTime? fechaInicio, DateTime? fechaFin)
            {

                DiagGestacionDS datos = new DiagGestacionDS();
                List<DiagInseminacion> lstDiagInseminaciones = DiagInseminacion.Buscar(idAnimal, fechaInicio, fechaFin);
                foreach (DiagInseminacion diagnostico in lstDiagInseminaciones)
                {
                    DiagGestacionDS.DiagInseminacionRow fila = datos.DiagInseminacion.NewDiagInseminacionRow();
                    ClaseBaseToRow(diagnostico, fila);
                    datos.DiagInseminacion.AddDiagInseminacionRow(fila);
                }
                return datos;
            }

            public static PartosDS Partos(int idAnimal, DateTime? fechaInicio, DateTime? fechaFin)
            {

                PartosDS datos = new PartosDS();
                List<Parto> lstPartos = Parto.Buscar(idAnimal,null,null,null,null, fechaInicio, fechaFin,null);
                foreach (Parto parto in lstPartos)
                {
                    PartosDS.PartoRow fila = datos.Parto.NewPartoRow();
                    ClaseBaseToRow(parto, fila);
                    datos.Parto.AddPartoRow(fila);
                }
                return datos;
            }

            public static AbortosDS Abortos(int idAnimal, DateTime? fechaInicio, DateTime? fechaFin)
            {

                AbortosDS datos = new AbortosDS();
                List<Aborto> lstAbortos = Aborto.Buscar(idAnimal, null,  fechaInicio, fechaFin);
                foreach (Aborto aborto in lstAbortos)
                {
                    AbortosDS.AbortoRow fila = datos.Aborto.NewAbortoRow();
                    ClaseBaseToRow(aborto, fila);
                    datos.Aborto.AddAbortoRow(fila);
                }
                return datos;
            }

            public static LactacionesDS Lactaciones(int idAnimal, DateTime? fechaInicio, DateTime? fechaFin)
            {

                LactacionesDS datos = new LactacionesDS();
                List<Lactacion> lstLactaciones = Lactacion.Buscar(idAnimal, fechaInicio, fechaFin,null);
                if (lstLactaciones == null || lstLactaciones.Count == 0)
                    throw new LogicException("Informe sin datos");

                foreach (Lactacion lactacion in lstLactaciones)
                {
                    LactacionesDS.LactacionRow fila = datos.Lactacion.NewLactacionRow();
                    ClaseBaseToRow(lactacion, fila);
                    datos.Lactacion.AddLactacionRow(fila);

                    List<ControlLeche> lstControles = ControlLeche.Buscar(lactacion.Id, fechaInicio, fechaFin);
                    foreach (ControlLeche controlleche in lstControles)
                    {
                        LactacionesDS.ControlRow filaControl = datos.Control.NewControlRow();
                        ClaseBaseToRow(controlleche, filaControl);
                        datos.Control.AddControlRow(filaControl);
                    }
                }
                return datos;
            }

            public static SecadosDS Secados(int idAnimal, DateTime? fechaInicio, DateTime? fechaFin)
            {

                SecadosDS datos = new SecadosDS();
                List<Secado> lstSecados = Secado.Buscar(null,null,idAnimal, fechaInicio, fechaFin,null);
                foreach (Secado secado in lstSecados)
                {
                    SecadosDS.SecadoRow fila = datos.Secado.NewSecadoRow();
                    ClaseBaseToRow(secado, fila);
                    datos.Secado.AddSecadoRow(fila);
                }
                return datos;
            }
            public static PesosDS Pesos(int idAnimal, DateTime? fechaInicio, DateTime? fechaFin)
            {

                PesosDS datos = new PesosDS();
                List<Peso> lstPesos = Peso.Buscar(idAnimal,null, fechaInicio, fechaFin, null,null);
                foreach (Peso peso in lstPesos)
                {
                    PesosDS.PesoRow fila = datos.Peso.NewPesoRow();
                    ClaseBaseToRow(peso, fila);
                    datos.Peso.AddPesoRow(fila);
                }
                return datos;
            }

            public static CondicionesCorporalesDS CondicionesCorporales(int idAnimal, DateTime? fechaInicio, DateTime? fechaFin)
            {

                CondicionesCorporalesDS datos = new CondicionesCorporalesDS();
                List<CondicionCorporal> lstCondicionesCorporales = CondicionCorporal.Buscar(idAnimal, null, fechaInicio, fechaFin);
                foreach (CondicionCorporal condicioncorporal in lstCondicionesCorporales)
                {
                    CondicionesCorporalesDS.CondicionCorporalRow fila = datos.CondicionCorporal.NewCondicionCorporalRow();
                    ClaseBaseToRow(condicioncorporal, fila);
                    datos.CondicionCorporal.AddCondicionCorporalRow(fila);
                }
                return datos;
            }

            public static InformacionCanalDS InformacionCanal(int idAnimal, DateTime? fechaInicio, DateTime? fechaFin)
            {

                InformacionCanalDS datos = new InformacionCanalDS();
                InformacionCanalDS.InformacionCanalRow filaCanal = datos.InformacionCanal.NewInformacionCanalRow();


                RendimientoCanal rendimiento = Logic.RendimientoCanal.Buscar(idAnimal, null, fechaInicio, fechaFin).FirstOrDefault();
                if (rendimiento != null)
                {
                    filaCanal.IdRendimiento = rendimiento.Id;
                    filaCanal.RendimientoFecha = rendimiento.Fecha;
                    filaCanal.RendimientoRendimiento = rendimiento.Rendimiento;
                }

                EngrasamientoCanal engrasamiento = Logic.EngrasamientoCanal.Buscar(idAnimal, null, fechaInicio, fechaFin).FirstOrDefault();
                if (engrasamiento != null)
                {
                    filaCanal.IdEngrasamiento = engrasamiento.Id;
                    filaCanal.EngrasamientoFecha = engrasamiento.Fecha;
                    filaCanal.EngrasamientoDescTipo = engrasamiento.DescTipo;
                }
                TipificacionCanal Tipificacion = Logic.TipificacionCanal.Buscar(idAnimal,null,null, fechaInicio, fechaFin).FirstOrDefault();
                if (Tipificacion != null)
                {
                    filaCanal.IdTipificacion = Tipificacion.Id;
                    filaCanal.TipificacionFecha = Tipificacion.Fecha;
                    filaCanal.TipificacionDescCategoria = Tipificacion.DescCategoria;
                    filaCanal.TipificacionDescConformacion = Tipificacion.DescConformacion;
                }


             
                if (rendimiento==null && engrasamiento==null && Tipificacion==null)                
                    throw new LogicException("Informe sin datos");
                
                datos.InformacionCanal.AddInformacionCanalRow(filaCanal);      
                return datos;
            }
           
        #endregion
        


        #endregion

        #region INFORMES / ALIMENTACION

        public static ControlDeStockDeAlimentacionDS ControlDeStockDeAlimentacion(int? idTipoProducto, int? idFamiliaProducto,
                                                                                  int? idProducto, int? idMacho, string origen,
                                                                                  DateTime? fechaInicial, DateTime? fechaFinal) 
        {
            ControlDeStockDeAlimentacionDS datos = new ControlDeStockDeAlimentacionDS();

            List<Movimiento> lstMovimientos=DatosInformesData.ControlDeStockDeAlimentacion(idTipoProducto,idFamiliaProducto,
                                                                                             idProducto,idMacho,origen,
                                                                                             fechaInicial,fechaFinal);
            if (lstMovimientos.Count == 0)
                throw new LogicException("Informe sin datos");

            foreach (Movimiento movimiento in lstMovimientos)
            {
                ControlDeStockDeAlimentacionDS.MovimientoRow fila = datos.Movimiento.NewMovimientoRow();
                ClaseBaseToRow(movimiento, fila);

                datos.Movimiento.AddMovimientoRow(fila);
            }
            return datos;
        
        }
        public static ConsumosDS Consumos(int? idAnimal, DateTime? fechaInicial, DateTime? fechaFinal)
        {
            ConsumosDS datos = new ConsumosDS();
            List<Animal> lstAnimales = Animal.Buscar(idAnimal,null,null,null,null,Configuracion.Explotacion.Id,null,null,null,null,null,null,null,null, false,null);
            if (lstAnimales==null || lstAnimales.Count==0)            
                   throw new LogicException("Informe sin datos");
            
            foreach (Animal item in lstAnimales)
            {

                ConsumosDS.AnimalRow fila = datos.Animal.NewAnimalRow();
                ClaseBaseToRow(item, fila);

                datos.Animal.AddAnimalRow(fila);
            }
            return datos;

        }

        public static ConsumosAsignacionDS ConsumosAsignacion(int? idAnimal, DateTime? fechaInicial, DateTime? fechaFinal,int? idRacion)
        {
            ConsumosAsignacionDS datos = new ConsumosAsignacionDS();
            List<Asignacion> lstAsignaciones = Asignacion.Buscar(idRacion, idAnimal, fechaInicial, fechaFinal);
            foreach (Asignacion item in lstAsignaciones)
            {

                ConsumosAsignacionDS.AsignacionRow fila = datos.Asignacion.NewAsignacionRow();
                ClaseBaseToRow(item, fila);

                datos.Asignacion.AddAsignacionRow(fila);
            }
            return datos;

        }

        public static ConsumosProduccionDS ConsumosProduccion(int? idAnimal, DateTime? fechaInicial, DateTime? fechaFinal)
        {
            ConsumosProduccionDS datos = new ConsumosProduccionDS();
            List<Lactacion> lstLactaciones = Lactacion.Buscar(idAnimal, fechaInicial, fechaFinal);
            foreach (Lactacion item in lstLactaciones)
            {

                ConsumosProduccionDS.LactacionRow fila = datos.Lactacion.NewLactacionRow();
                ClaseBaseToRow(item, fila);


                try
                {   //Obtengo el total de leche producida en la lactacion
                    List<ControlLeche> lstcontrolleche = item.lstControlesLeche;
                    fila.TotalLeche = lstcontrolleche.Sum(E => E.LecheManana + E.LecheTarde + E.LecheNoche) ?? decimal.Zero;
                }
                catch (Exception)
                {
                    fila.TotalLeche = decimal.Zero;
                }

                datos.Lactacion.AddLactacionRow(fila);
            }
            return datos;

        }

      
        #endregion

        #region INFORMES / SANIDAD
        public static ConsultaMorbilidadDS ConsultaMorbilidad(int idEspecie,DateTime? fechaInicio, DateTime? fechaFin,int? idEstado) 
        {
            ConsultaMorbilidadDS datos = new ConsultaMorbilidadDS();

            List<Animal> lstAnimales = DatosInformesData.ConsultaMorbilidad(idEspecie, fechaInicio, fechaFin, idEstado);                
            if (lstAnimales==null || lstAnimales.Count==0)
                    throw new LogicException ("Informe sin datos");

	        foreach (Animal item in lstAnimales)
            {
                ConsultaMorbilidadDS.AnimalRow fila = datos.Animal.NewAnimalRow();
                ClaseBaseToRow(item, fila);

                fila.Enfermo = Animal.AnimalEnfermoEntreFechas(item.Id, fechaInicio, fechaFin);
                fila.DescEnfermo = fila.Enfermo? "Enfermos" : "Sanos";
                if (fila.DescEstado==string.Empty)                
                    fila.DescEstado = "(Sin Estado)";
                
                
                datos.Animal.AddAnimalRow(fila);
            }
           
            return datos;        
        }
        public static PrevalenciaEnfermedadesDS PrevalenciaEnfermedades(int? idEnfermedad, DateTime? fechaInicio, DateTime? fechaFin)
        {
            PrevalenciaEnfermedadesDS datos = new PrevalenciaEnfermedadesDS();

            foreach (Animal item in DatosInformesData.PrevalenciaEnfermedades(fechaInicio, fechaFin))
            {
                PrevalenciaEnfermedadesDS.AnimalRow fila = datos.Animal.NewAnimalRow();
                ClaseBaseToRow(item, fila);

                datos.Animal.AddAnimalRow(fila);
            }

            List<DiagAnimal> lstDiag = DiagAnimal.Buscar(null, null, fechaInicio, fechaFin, idEnfermedad);
            foreach (DiagAnimal item in lstDiag)
            {
                PrevalenciaEnfermedadesDS.DiagAnimalRow fila = datos.DiagAnimal.NewDiagAnimalRow();
                ClaseBaseToRow(item, fila);
                if (fila.DescEnfermedad == string.Empty)
                    fila.DescEnfermedad = "(ENF. SIN DEFINIR)";

                datos.DiagAnimal.AddDiagAnimalRow(fila);
            }
            return datos;
        }
        public static ConsultaMortalidadDS ConsultaMortalidad(int? idEspecie, DateTime? fechaInicio, DateTime? fechaFin)
        {
            ConsultaMortalidadDS datos = new ConsultaMortalidadDS();

            if (idEspecie.HasValue)
            {
                Especie especie = Especie.Buscar(idEspecie.Value);
                Mortalidad_CargarDatosEspecie(especie, fechaInicio, fechaFin, datos);
            }
            else//Como no he recibido informacion de la espece, cargo los datos de todas las especies de la explotación.            
                foreach (Especie item in Configuracion.Explotacion.lstEspecies)
                    Mortalidad_CargarDatosEspecie(item, fechaInicio, fechaFin, datos);


            return datos;
        }

        private static void Mortalidad_CargarDatosEspecie(Especie especie, DateTime? fechaInicio, DateTime? fechaFin, ConsultaMortalidadDS datos)
        {
            if (especie == null)
                throw new ArgumentException("Se requiere una especie válida", "especie");
            if (datos == null)
                throw new ArgumentException("Se requiere un dataset del tipo ConsultaMortalidadDS válido", "datos");

            ConsultaMortalidadDS.MortalidadRow fila = datos.Mortalidad.NewMortalidadRow();
            
            fila.Total_Nacimientos = DatosInformesData.Total_Nacimimientos(especie.Id, fechaInicio, fechaFin);
            fila.Mortalidad_Nacimiento = DatosInformesData.Muerte_Nacimimiento(especie.Id, fechaInicio, fechaFin);
            fila.Mortalidad_Perinatal = DatosInformesData.Muerte_Perinatal(especie.Id, fechaInicio, fechaFin).Count;           
            fila.Mortalidad_Destete = DatosInformesData.Muerte_Destete(especie.Id, fechaInicio, fechaFin).Count;         
            fila.Mortalidad_PostDestete = DatosInformesData.Muerte_PostDestete(especie.Id, fechaInicio, fechaFin).Count;
            fila.DescEspecie = especie.Descripcion;
            datos.Mortalidad.AddMortalidadRow(fila);
        }

        public static AnimalesEnTratamientoDS AnimalesEnTratamiento(DateTime? fechaInicio,DateTime? fechaFin)
        {
            AnimalesEnTratamientoDS datos = new AnimalesEnTratamientoDS();

            List<TratEnfermedad> lstTratamientos = DatosInformesData.AnimalesEnTratamiento(fechaInicio, fechaFin);
            if (lstTratamientos==null || lstTratamientos.Count() == 0)
                throw new LogicException("Informe sin datos");

            foreach (TratEnfermedad tratamiento in lstTratamientos)
            {
                AnimalesEnTratamientoDS.TratEnfermedadRow fila = datos.TratEnfermedad.NewTratEnfermedadRow();
                ClaseBaseToRow(tratamiento, fila);
                datos.TratEnfermedad.AddTratEnfermedadRow(fila);

                
                //Añado la información del Diagnostico si no esta añadido
                if (datos.DiagAnimal.Where(E => E.Id == tratamiento.IdDiagnostico).Count() == 0)
                {
                    AnimalesEnTratamientoDS.DiagAnimalRow filaDiagnostico = datos.DiagAnimal.NewDiagAnimalRow();
                    DiagAnimal diagAnimal = DiagAnimal.Buscar(tratamiento.IdDiagnostico);
                    ClaseBaseToRow(diagAnimal, filaDiagnostico);
                    datos.DiagAnimal.AddDiagAnimalRow(filaDiagnostico);

                    //Añado la información del Animal si no esta añadido
                    if (datos.Animal.Where(E => E.Id == tratamiento.DiagAnimal.IdAnimal).Count() == 0)
                    {
                        AnimalesEnTratamientoDS.AnimalRow filaAnimal = datos.Animal.NewAnimalRow();
                        Animal animal = Animal.Buscar(diagAnimal.IdAnimal);
                        ClaseBaseToRow(animal, filaAnimal);
                        datos.Animal.AddAnimalRow(filaAnimal);
                    }
                }

                //Añado la informacion de las recetas
                foreach (Receta receta in tratamiento.lstRecetas)
                {
                    AnimalesEnTratamientoDS.RecetaRow filaReceta = datos.Receta.NewRecetaRow();
                    ClaseBaseToRow(receta, filaReceta);
                    datos.Receta.AddRecetaRow(filaReceta);
                }

            }
            
            return datos;
        }
        

        #endregion

        #region INFORMES / PRODUCCIÓN

            #region LECHE

                public static List<Animal> HembrasLactacionXIntervalo(int idEspecie, DateTime fechaInicio, DateTime fechaFin)
                {
                    return DatosInformesData.HembrasLactacionXIntervalo(idEspecie, fechaInicio, fechaFin);
                }

                public static List<Animal> HembrasMuestraXIntervalo(List<Animal> animales, DateTime fechaInicio, DateTime fechaFin)
                {
                    return DatosInformesData.HembrasMuestraXIntervalo(animales, fechaInicio, fechaFin);
                }

            #endregion

            #region CARNE
                public static IndicesConversionDS IndicesConversion(List<Animal> listaAnimales,int? idLote, DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie, int? idAnimal)
                {
                    List<Animal> lstAnimales = null;
                    if (listaAnimales == null || listaAnimales.Count == 0)
                    {

                        if (idLote.HasValue)
                            lstAnimales = DatosInformesData.AnimalesDeUnLote(idLote.Value, idEspecie);
                        else
                            lstAnimales = Animal.Buscar(idAnimal, null, null, null, null, Configuracion.Explotacion.Id, null, null, null, null, null, null, null, null, false, idEspecie);


                    }
                    else
                        lstAnimales = listaAnimales;
                
                    if (lstAnimales == null || lstAnimales.Count == 0)
                        throw new LogicException("Informe sin datos");

                    IndicesConversionDS datos = new IndicesConversionDS();
                    foreach (Animal animal in lstAnimales)
                    {                        
                        if (animal.FechaDestete.HasValue)//Solo tienen sentido los indices de conversion desde la fecha del destete
                        {
                            DatosInformesData.IC icAnimal = DatosInformesData.ICAnimal(animal.Id, fechaInicio, fechaFin);

                            ////Para poder seguir con el informe, es necesario que el animal tenga al menos un peso, de lo contrario no tiene sentido seguir.
                            if (icAnimal.UltimoPeso!=null)
                            {
                                IndicesConversionDS.AnimalRow filaanimal = datos.Animal.NewAnimalRow();
                                ClaseBaseToRow(animal, filaanimal);

                                if (icAnimal.UltimoPeso != null)
                                {
                                    filaanimal.FUltimaPesada = icAnimal.UltimoPeso.Fecha;
                                    filaanimal.KPeso = icAnimal.UltimoPeso.Peso1;
                                }
                                filaanimal.KAlimentoAsignaciones = icAnimal.KgAlimentoAsignaciones;
                                filaanimal.KAlimentoPastoreo = icAnimal.KgAlimentoPastoreo;
                                filaanimal.IC = icAnimal.ValorIC;


                                datos.Animal.AddAnimalRow(filaanimal);                                                    
                            }                                  
                        }                        
                    }

                    if (datos.Animal.Count == 0)
                        throw new LogicException("Informe sin datos");

                    return datos;
                }
                public static GMDDS GMD(List<Animal> listaAnimales,int? idLote,DateTime? fechaInicio,DateTime? fechaFin,int? idEspecie,int? idAnimal)
                {
                    List<Animal> lstAnimales = null;
                    if (listaAnimales == null || listaAnimales.Count == 0)
                    {
                        if (idLote.HasValue)
                            lstAnimales = DatosInformesData.AnimalesDeUnLote(idLote.Value, idEspecie);
                        else
                            lstAnimales = Animal.Buscar(idAnimal, null, null, null, null, Configuracion.Explotacion.Id, null, null, null, null, null, null, null, null, false, idEspecie);
                    }
                    else
                        lstAnimales = listaAnimales;

                    if (lstAnimales==null || lstAnimales.Count==0)                    
                        throw new LogicException("Informe sin datos");
                    

                    GMDDS datos = new GMDDS();
                    foreach (Animal animal in lstAnimales)
                    {
                        GMDDS.AnimalRow filaanimal = datos.Animal.NewAnimalRow();
                        ClaseBaseToRow(animal, filaanimal);
                        

                        Peso pesoanterior = null;
                        List<Peso> lstPesos = Peso.Buscar(animal.Id, null, fechaInicio, fechaFin, null, null);
                        foreach (Peso peso in lstPesos)
                        {
                            GMDDS.PesoRow filapeso = datos.Peso.NewPesoRow();
                            ClaseBaseToRow(peso, filapeso);
                            //Calculo el campo GMD a partir de la pesada anterior
                            if (pesoanterior!=null)
                            {                                
                                TimeSpan diferencia = peso.Fecha.Subtract(pesoanterior.Fecha);
                                filapeso.GMD = (peso.Peso1 - pesoanterior.Peso1) / (decimal)diferencia.TotalDays;
                            }
                            pesoanterior = peso;
                            datos.Peso.AddPesoRow(filapeso);
                        }

                        if (lstPesos!=null && lstPesos.Count>0)                        
                            datos.Animal.AddAnimalRow(filaanimal);
                    }

                    if (datos.Animal.Count==0)                    
                        throw new LogicException("Informe sin datos");
                    
                    return datos;
                }
            #endregion

        #endregion

        #region INFORMES / REPRODUCCION

                #region ESTADÍSTICAS DE FERTILIDAD

                public static List<Inseminacion> UltimasInseminacionesXIntervalo(int idExplotacion, int idEspecie, DateTime inicio, DateTime fin)
                {
                    return DatosInformesData.UltimasInseminacionesXIntervalo(idExplotacion, idEspecie, inicio, fin);
                }

                #endregion

                #region PARTOS

                public static List<Parto> UltimosPartosXIntervalo(int idExplotacion, int idEspecie, DateTime inicio, DateTime fin)
                {
                    return DatosInformesData.UltimosPartosXIntervalo(idExplotacion, idEspecie, inicio, fin);
                }

                public static List<Parto> PartosXIntervalo(int idExplotacion, int idEspecie, DateTime inicio, DateTime fin)
                {
                    return DatosInformesData.PartosXIntervalo(idExplotacion, idEspecie, inicio, fin);
                }

                public static List<Aborto> AbortosXIntervalo(int idExplotacion, int idEspecie, DateTime inicio, DateTime fin)
                {
                    return DatosInformesData.AbortosXIntervalo(idExplotacion, idEspecie, inicio, fin);
                }

                public static List<Animal> HembrasXEdadIntervalo(int idExplotacion, int idEspecie, int? edadInicio, int? edadFin, DateTime inicio, DateTime fin)
                {
                    return DatosInformesData.HembrasXEdadIntervalo(idExplotacion, idEspecie, edadInicio, edadFin, inicio, fin);
                }

                public static IntervaloPartosDS IntervaloPartos(List<Animal> lstAnimales, DateTime fechaInicio, DateTime fechaFin)
                {
                    ///Comprobar argumentos
                    if (lstAnimales == null)
                        throw new ArgumentException("Es necesaria una lista de animales debidamente formada.", "lstAnimales");


                    IntervaloPartosDS Datos = new IntervaloPartosDS();

                    IntervaloPartosDS.AnimalRow AnimalRow = null;
                    foreach (Animal Hembra in lstAnimales)
                    {
                        AnimalRow = Datos.Animal.NewAnimalRow();

                        AnimalRow.Id = Hembra.Id;
                        AnimalRow.Nombre = "Animal: " + Hembra.Nombre;

                        Datos.Animal.AddAnimalRow(AnimalRow);

                        IntervaloPartosDS.PartoRow PartoRow = null;
                        List<Parto> Partos = Hembra.lstPartos.OrderBy(P => P.Numero).ToList();
                        for (int i = 0; i < Partos.Count; i++)
                        {
                            if (Partos[i].Fecha >= fechaInicio && Partos[i].Fecha <= fechaFin)
                            {
                                PartoRow = Datos.Parto.NewPartoRow();

                                PartoRow.IdHembra = Hembra.Id;
                                PartoRow.Numero = Partos[i].Numero;
                                PartoRow.Fecha = Partos[i].Fecha;

                                if (Partos[i].Numero == 1)
                                    AnimalRow.Edad = Partos[i].Fecha.Subtract(Hembra.FechaNacimiento).Days / 30;
                                else
                                    PartoRow.Intervalo = Partos[i].Fecha.Subtract(Partos[i - 1].Fecha).Days;

                                Datos.Parto.AddPartoRow(PartoRow);
                            }
                        }

                        Partos = null;
                    }
                    return Datos;
                }

           #endregion

            public static ProlificidadDS Prolificidad(List<Animal> listaAnimales,int? idLote, DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie)
            {
                ProlificidadDS datos = new ProlificidadDS();
                List<Animal> lstAnimales = null;
                if (listaAnimales == null || listaAnimales.Count == 0)
                {
                    if (idLote.HasValue)                    
                        lstAnimales = DatosInformesData.AnimalesDeUnLote(idLote.Value, idEspecie);                   
                    else                    
                        lstAnimales = Animal.Buscar(null, null, null, null, null, Configuracion.Explotacion.Id, null, null, null, null, null, char.Parse("H"), null, null, false, idEspecie);                    
                }
                else
                    lstAnimales = listaAnimales;                

                if (lstAnimales == null || lstAnimales.Count == 0)
                    throw new LogicException("Informe sin datos");
                    

                foreach (Animal item in lstAnimales)
                {
                    ProlificidadDS.AnimalRow fila = datos.Animal.NewAnimalRow();
                    //De cada uno de los animales obtenemos las estadísticas de prolificidad, pero solo 
                    //agregaremos al informe los animales que hayan tenido algun parto.
                    //Daría igual que existiesen abortos y no partos (no se contaria, pues el índice divide por partos y no puede ser 0.
                    DatosInformesData.DatosProlificidad prolificidad=DatosInformesData.ProlificidadAnimal(item.Id, fechaInicio, fechaFin);
                    if (prolificidad.partos != 0)
                    {
                        ClaseBaseToRow(item, fila);
                        fila.NVivos = prolificidad.vivos;
                        fila.NMuertos = prolificidad.muertos;
                        fila.NPartos = prolificidad.partos;
                        fila.NAbortos = prolificidad.abortos;
                        datos.Animal.AddAnimalRow(fila);                        
                    }
                }
                if (datos.Animal.Count==0)                
                    throw new LogicException("Informe sin datos.");

                
                return datos;
            }

            public static AnimalesNacidosGenealogiaDS AnimalesNacidosGenealogia(int? idLote,DateTime? fechaInicio,DateTime? fechaFin,int? idEspecie,ref List<Animal> lstAnimales)
            {
                AnimalesNacidosGenealogiaDS datos = new AnimalesNacidosGenealogiaDS();
                lstAnimales = DatosInformesData.AnimalesNacidosGenealogia(idLote, fechaInicio, fechaFin, idEspecie);
                if (lstAnimales == null || lstAnimales.Count == 0)
                    throw new LogicException("Informe sin datos");

                foreach (Animal animal in lstAnimales)
                {
                    AnimalesNacidosGenealogiaDS.AnimalRow filaAnimal = datos.Animal.NewAnimalRow();
                    ClaseBaseToRow(animal, filaAnimal);
                    datos.Animal.AddAnimalRow(filaAnimal);
                }
                return datos;
            }

            public static GenealogiaAnimalDS Genealogia(List<Animal> lstAnimales)
            {
                ///Comprobar argumentos
                if (lstAnimales == null)
                    throw new ArgumentException("Es necesaria una lista de animales debidamente formada.", "lstAnimales");

                GenealogiaAnimalDS datos = new GenealogiaAnimalDS();

                foreach (Animal animal in lstAnimales)
                {
                    GenealogiaAnimalDS.AnimalRow filaAnimal = datos.Animal.NewAnimalRow();
                    ClaseBaseToRow(animal, filaAnimal);

                    Animal.LGenealogicoCompleto lgenealogico = Animal.CargarLGenealogicoCompleto(animal);

                        //Animal a tratar
           
                    //DATOS PADRE            
                    filaAnimal.Padre = lgenealogico.Padre;

                    //(abuelos paternos)
                    filaAnimal.PadrePadre = lgenealogico.PadrePadre;
                    filaAnimal.MadrePadre = lgenealogico.MadrePadre;

               
                    //bisabuelos paternos padre
                    filaAnimal.AbueloPaternoPadre = lgenealogico.AbueloPaternoPadre;
                    filaAnimal.AbuelaPaternoPadre = lgenealogico.AbuelaPaternoPadre;

                    //bisabuelos paternos madre
                    filaAnimal.AbueloPaternoMadre = lgenealogico.AbueloPaternoMadre;
                    filaAnimal.AbuelaPaternoMadre = lgenealogico.AbuelaPaternoMadre;            
                    
                    //DATOS MADRE
                    filaAnimal.Madre = lgenealogico.Madre;
                    
                    //Abuelos maternos
                    filaAnimal.PadreMadre = lgenealogico.PadreMadre;
                    filaAnimal.MadreMadre = lgenealogico.MadreMadre;


                    //bisabuelos maternos padre
                    filaAnimal.AbueloMaternoPadre = lgenealogico.AbueloMaternoPadre;
                    filaAnimal.AbuelaMaternoPadre = lgenealogico.AbuelaMaternoPadre;

                    //bisabuelos maternos madre
                    filaAnimal.AbueloMaternoMadre = lgenealogico.AbueloMaternoMadre;
                    filaAnimal.AbuelaMaternoMadre = lgenealogico.AbuelaMaternoMadre;
              
                    
                    datos.Animal.AddAnimalRow(filaAnimal);

                }
                return datos;
            }

            public static AnimalesDestetadosDS AnimalesDestetados(int? idLote, DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie)
            {
                AnimalesDestetadosDS datos = new AnimalesDestetadosDS();
                List<Animal> lstAnimales = DatosInformesData.AnimalesDestetados(idLote, fechaInicio, fechaFin, idEspecie);

                if (lstAnimales == null || lstAnimales.Count == 0)
                    throw new LogicException("Informe sin datos");

                foreach (Animal animal in lstAnimales)
                {
                    AnimalesDestetadosDS.AnimalRow filaAnimal = datos.Animal.NewAnimalRow();
                    ClaseBaseToRow(animal, filaAnimal);
                    datos.Animal.AddAnimalRow(filaAnimal);
                }

                return datos;           
            }

            public static AnimalesMuertosDS AnimalesMuertos(int? idLote, DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie)
            {
                AnimalesMuertosDS datos = new AnimalesMuertosDS();

            
                return datos;
            }

            public static MuerteNacimientoDS MuerteNacimiento(int? idLote, DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie)
            {
                MuerteNacimientoDS datos = new MuerteNacimientoDS();

                List<Parto> lstPartos = DatosInformesData.MuerteNacimiento(idLote, fechaInicio, fechaFin, idEspecie);

                if (lstPartos == null || lstPartos.Count == 0)
                    throw new LogicException("Informe sin datos");

                foreach (Parto parto in lstPartos)
                {
                    MuerteNacimientoDS.PartoRow filaparto = datos.Parto.NewPartoRow();
                    ClaseBaseToRow(parto, filaparto);
                    datos.Parto.AddPartoRow(filaparto);
                }

                return datos;
            }

            public static MuerteDS MuertePerinatal(int? idLote, DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie)
            {
                MuerteDS datos = new MuerteDS();

                List<Animal> lstAnimales = DatosInformesData.MuertePerinatal(idLote, fechaInicio, fechaFin, idEspecie);

                if (lstAnimales == null || lstAnimales.Count == 0)
                    throw new LogicException("Informe sin datos");

                foreach (Animal animal in lstAnimales)
                {
                    //Datos referentes al animal.
                    MuerteDS.AnimalRow FilaAnimal = datos.Animal.NewAnimalRow();
                    ClaseBaseToRow(animal, FilaAnimal);

                    //Datos referentes al libro genealógico
                    LibroGenealogico libro = animal.LibroAnimal();
                    if (libro!=null)                    
                        FilaAnimal.DescMadre = libro.Madre;

                    //Añado el animal
                    datos.Animal.AddAnimalRow(FilaAnimal);
                        
                    //Datos referentes a la baja
                    Baja baja = animal.BajaAnimal();
                    if (baja != null)
                    {
                        MuerteDS.BajaRow FilaBaja = datos.Baja.NewBajaRow();
                        ClaseBaseToRow(baja, FilaBaja);
                        //Añado la Baja
                        datos.Baja.AddBajaRow(FilaBaja);
                    }
                }

                return datos;
            }
            public static MuerteDS MuerteDestete(int? idLote, DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie)
            {
                MuerteDS datos = new MuerteDS();

                List<Animal> lstAnimales = DatosInformesData.MuerteDestete(idLote, fechaInicio, fechaFin, idEspecie);

                if (lstAnimales == null || lstAnimales.Count == 0)
                    throw new LogicException("Informe sin datos");

                foreach (Animal animal in lstAnimales)
                {
                    //Datos referentes al animal.
                    MuerteDS.AnimalRow FilaAnimal = datos.Animal.NewAnimalRow();
                    ClaseBaseToRow(animal, FilaAnimal);

                    //Datos referentes al libro genealógico
                    LibroGenealogico libro = animal.LibroAnimal();
                    if (libro != null)
                        FilaAnimal.DescMadre = libro.Madre;

                    //Añado el animal
                    datos.Animal.AddAnimalRow(FilaAnimal);

                    //Datos referentes a la baja
                    Baja baja = animal.BajaAnimal();
                    if (baja != null)
                    {
                        MuerteDS.BajaRow FilaBaja = datos.Baja.NewBajaRow();
                        ClaseBaseToRow(baja, FilaBaja);
                        //Añado la Baja
                        datos.Baja.AddBajaRow(FilaBaja);
                    }
                }

                return datos;
            }
            public static MuerteDS MuertePostDestete(int? idLote, DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie)
            {
                MuerteDS datos = new MuerteDS();

                List<Animal> lstAnimales = DatosInformesData.MuertePostDestete(idLote, fechaInicio, fechaFin, idEspecie);

                if (lstAnimales == null || lstAnimales.Count == 0)
                    throw new LogicException("Informe sin datos");

                foreach (Animal animal in lstAnimales)
                {
                    //Datos referentes al animal.
                    MuerteDS.AnimalRow FilaAnimal = datos.Animal.NewAnimalRow();
                    ClaseBaseToRow(animal, FilaAnimal);

                    //Datos referentes al libro genealógico
                    LibroGenealogico libro = animal.LibroAnimal();
                    if (libro != null)
                        FilaAnimal.DescMadre = libro.Madre;

                    //Añado el animal
                    datos.Animal.AddAnimalRow(FilaAnimal);

                    //Datos referentes a la baja
                    Baja baja = animal.BajaAnimal();
                    if (baja != null)
                    {
                        MuerteDS.BajaRow FilaBaja = datos.Baja.NewBajaRow();
                        ClaseBaseToRow(baja, FilaBaja);
                        //Añado la Baja
                        datos.Baja.AddBajaRow(FilaBaja);
                    }
                }

                return datos;
            }

            public static CapacidadMaternalDS CapacidadMaternal(List<Animal> lstAnimales) 
            {
                ///Comprobar argumentos
                if (lstAnimales == null)
                    throw new ArgumentException("Es necesaria una lista de animales debidamente formada.", "lstAnimales");

                CapacidadMaternalDS datos = new CapacidadMaternalDS();

                CapacidadMaternalDS.AnimalRow AnimalRow = null;
                foreach (Animal animal in lstAnimales)            
                {
                    AnimalRow = datos.Animal.NewAnimalRow();
                    ClaseBaseToRow(animal, AnimalRow);                   
                    AnimalRow.Nacimiento = animal.FechaNacimiento;

                    datos.Animal.AddAnimalRow(AnimalRow);
                    AnimalRow = null;

                    CapacidadMaternalDS.HijoRow HijoRow = null;
                    List<Peso> Pesos = null;
                    foreach (Animal Hijo in animal.lstHijos)
                    {
                        Pesos = Peso.Buscar(Hijo.Id, null, null, Configuracion.MomentoPesoSistema(Configuracion.MomentosPesoSistema.DESTETE).Id, null);

                        if (Hijo.FechaDestete.HasValue && Pesos.Count == 1)
                        {
                            HijoRow = datos.Hijo.NewHijoRow();

                            HijoRow.IdMadre = animal.Id;
                            HijoRow.Nombre = Hijo.Nombre;
                            HijoRow.Destete = Hijo.FechaDestete.Value;
                            HijoRow.Peso = Pesos[0].Peso1;
                            HijoRow.Indice = Pesos[0].Peso1 / Hijo.FechaDestete.Value.Subtract(Hijo.FechaNacimiento).Days;

                            datos.Hijo.AddHijoRow(HijoRow);
                        }

                        HijoRow = null;
                    }

                    Pesos = null;            
                }

                return datos;
            }

            public static EvolucionAnualDS EvolucionAnual(DateTime? fechaInicio, DateTime? fechaFin, int? idEspecie,bool mostrarDatosProdCarne)
            {
                

                EvolucionAnualDS datos = new EvolucionAnualDS();
                EvolucionAnualDS.EvolucionRow filaevolucion = datos.Evolucion.NewEvolucionRow();

                ///Calculo en Nº de Animales actvivos en el intervalo.
                filaevolucion.NAnimales = DatosInformesData.AnimalesActivos(fechaInicio, fechaFin, idEspecie).Count;
             
                ///Calculo el nº animales nacidos
                decimal TotalAnimalesNacidos = DatosInformesData.Total_Nacimimientos(idEspecie, fechaInicio, fechaFin);                
                filaevolucion.NAnimalesNacidos = (int)TotalAnimalesNacidos;

                ///Calculo en nº de primíparas, hembras de primer parto.
                List<Parto> lstPartosPrimiparas = DatosInformesData.Primiparas(fechaInicio, fechaFin, idEspecie);
                filaevolucion.NPrimiparas = lstPartosPrimiparas.Count;

                ///Calculamos los Datos Mortalidad:
                ///     % Mortalidad al Nacimiento
                ///     % Mortalidad Perinatal
                ///     % Mortalidad al Destete.                  
                decimal MuertosNacimiento = DatosInformesData.Muerte_Nacimimiento(idEspecie, fechaInicio, fechaFin);                    
                decimal MuertosPerinatal = DatosInformesData.Muerte_Perinatal(idEspecie, fechaInicio, fechaFin).Count;                    
                decimal MuertosDestete = DatosInformesData.Muerte_Destete(idEspecie, fechaInicio, fechaFin).Count;

                if (TotalAnimalesNacidos!=0)                 
                {
                    filaevolucion.PorcentajeMortalidadNacimiento =(MuertosNacimiento / TotalAnimalesNacidos) *100;
                    filaevolucion.PorcentajeMortalidadPerinatal = (MuertosPerinatal  / TotalAnimalesNacidos) *100;
                    filaevolucion.PorcentajeMortalidadDestete =   (MuertosDestete    / TotalAnimalesNacidos) *100;
                }

             
                
                ///Calculo Num Animales destetados y Media Edad al destete
                List<Animal> lstAnimalesDestetados = DatosInformesData.AnimalesDestetados(null, fechaInicio, fechaFin, idEspecie);
                filaevolucion.NAnimalesDestetados = lstAnimalesDestetados.Count;
                if (lstAnimalesDestetados.Count!=0)
                {
                    decimal? sumaEdades = lstAnimalesDestetados.Sum(E => (E.FechaDestete.Value - E.FechaNacimiento).Days);
                    filaevolucion.MediaEdadDestete = (sumaEdades ?? 0) / lstAnimalesDestetados.Count; 
                }
               

                ///Calculo la Media de GMD 
                GMDDS gmd=GMD(null,null, fechaInicio, fechaFin, idEspecie, null);
                if (gmd.Peso.Where(E => !E.IsGMDNull()).Count() != 0)
                {
                    decimal? SumaGMD = gmd.Peso.Where(E=>!E.IsGMDNull()).Sum(E => E.GMD);
                    filaevolucion.MediaGMD = (SumaGMD ?? 0) / gmd.Peso.Where(E => !E.IsGMDNull()).Count();                    
                }

                ///Calculo la Media Intervalo partos
                IntervaloPartosDS intervaloPartos = IntervaloPartos(DatosInformesData.AnimalesActivos(fechaInicio, fechaFin, idEspecie), (DateTime)fechaInicio, (DateTime)fechaFin);
                if (intervaloPartos.Parto.Where(E => !E.IsIntervaloNull()).Count() != 0)
                {
                    decimal? SumaIntevalo = intervaloPartos.Parto.Where(E => !E.IsIntervaloNull()).Sum(E => E.Intervalo);
                    filaevolucion.MediaIntervaloEntrePartos = (SumaIntevalo ?? 0) / intervaloPartos.Parto.Where(E => !E.IsIntervaloNull()).Count();
                }

                ///Calculo el % Abortos con respecto al total partos+abortos
                decimal NPartos=DatosInformesData.NumPartos(fechaInicio,fechaFin,idEspecie);
                decimal NAbortos=DatosInformesData.NumAbortos(fechaInicio,fechaFin,idEspecie);
                if ((NPartos+NAbortos)!=0)
                {
                    filaevolucion.PorcentajeAbortos = (NAbortos / (NPartos+NAbortos))*100;
                }

                ///Calculo el % de Perdidas de Productividad
                ///[porcentaje de muertos (al nacemento, perinatal y destete) respecto al total de nacidos]
                decimal TotalMuertos = MuertosNacimiento + MuertosPerinatal + MuertosDestete;
                if (TotalAnimalesNacidos!=0)                
                    filaevolucion.PorcentajePerdidasProductividad = (TotalMuertos / TotalAnimalesNacidos) * 100;

                if (mostrarDatosProdCarne)
                {
                    //Calculo la media de edad al primer parto
                    decimal SumaEdades = 0;                    
                    if (lstPartosPrimiparas.Count>0)
                    {
                        foreach (Parto item in lstPartosPrimiparas)
                        {
                            try
                            {
                                SumaEdades += (item.Fecha.Subtract(Animal.Buscar(item.IdHembra).FechaNacimiento)).Days;
                            }
                            catch (Exception) { }
                        }
                        filaevolucion.MediaEdad1erParto=(SumaEdades/lstPartosPrimiparas.Count);
                    }

                    ///Calcula la media de los intervalos entre partos entre 1º-2º
                    if (intervaloPartos.Parto.Where(E => !E.IsIntervaloNull()&E.Numero==2).Count() != 0)
                    {
                        decimal? SumaIntevalo = intervaloPartos.Parto.Where(E => !E.IsIntervaloNull() & E.Numero == 2).Sum(E => E.Intervalo);
                        filaevolucion.MediaIntervaloPartos12 = (SumaIntevalo ?? 0) / intervaloPartos.Parto.Where(E => !E.IsIntervaloNull() & E.Numero == 2).Count();
                    }
                    ///Calcula la media de los intervalos entre partos entre 2º-3º
                    if (intervaloPartos.Parto.Where(E => !E.IsIntervaloNull() & E.Numero == 3).Count() != 0)
                    {
                        decimal? SumaIntevalo = intervaloPartos.Parto.Where(E => !E.IsIntervaloNull() & E.Numero == 3).Sum(E => E.Intervalo);
                        filaevolucion.MediaIntervaloPartos23 = (SumaIntevalo ?? 0) / intervaloPartos.Parto.Where(E => !E.IsIntervaloNull() & E.Numero == 3).Count();
                    }
                    ///Calcula la media de los intervalos entre partos entre 3º-4º
                    if (intervaloPartos.Parto.Where(E => !E.IsIntervaloNull() & E.Numero == 4).Count() != 0)
                    {
                        decimal? SumaIntevalo = intervaloPartos.Parto.Where(E => !E.IsIntervaloNull() & E.Numero == 4).Sum(E => E.Intervalo);
                        filaevolucion.MediaIntervaloPartos34 = (SumaIntevalo ?? 0) / intervaloPartos.Parto.Where(E => !E.IsIntervaloNull() & E.Numero == 4).Count();
                    }
                    ///Calcula la media de los intervalos entre partos +4º
                    if (intervaloPartos.Parto.Where(E => !E.IsIntervaloNull() & E.Numero > 4).Count() != 0)
                    {
                        decimal? SumaIntevalo = intervaloPartos.Parto.Where(E => !E.IsIntervaloNull() & E.Numero > 4).Sum(E => E.Intervalo);
                        filaevolucion.MediaIntervaloPartos4Mas = (SumaIntevalo ?? 0) / intervaloPartos.Parto.Where(E => !E.IsIntervaloNull() & E.Numero > 4).Count();
                    }

                    ///Calculo la media del indice maternal de las primiparas
                    List<Animal> lstAnimalesCalcularCM =new List<Animal>();
                    foreach (Parto item in lstPartosPrimiparas)
                    {
                        try
                        {
                            lstAnimalesCalcularCM.Add(Animal.Buscar(item.IdHembra));
                        }
                        catch (Exception){}                        
                    }
                    CapacidadMaternalDS cm=DatosInformes.CapacidadMaternal(lstAnimalesCalcularCM);
                    if (cm.Hijo.Count() != 0)
                    {
                        decimal? SumaCM = cm.Hijo.Sum(E => E.Indice);
                        filaevolucion.MediaIndiceMaternalPrimiparas = (SumaCM ?? 0) / cm.Hijo.Count();
                    }

                    ///Calculo la media del indice maternal de las multiparas
                    List<Animal> lstAnimalesCalcularCMM = new List<Animal>();
                    List<Parto> lstMultiparas=DatosInformesData.Multiparas(fechaInicio,fechaFin,idEspecie);
                    foreach (Parto item in lstMultiparas)
                    {
                        try
                        {
                            if (!lstAnimalesCalcularCMM.Exists(E=>E.Id==item.IdHembra))                            
                                lstAnimalesCalcularCMM.Add(Animal.Buscar(item.IdHembra));
                        }
                        catch (Exception) { }                       
                    }
                    CapacidadMaternalDS cmm = DatosInformes.CapacidadMaternal(lstAnimalesCalcularCMM);
                    if (cmm.Hijo.Count() != 0)
                    {
                        decimal? SumaCMM = cmm.Hijo.Sum(E => E.Indice);
                        filaevolucion.MediaIndiceMaternalMultiparas = (SumaCMM ?? 0) / cmm.Hijo.Count();
                    }


	                 
                   
                }

                
                
              
                datos.Evolucion.AddEvolucionRow(filaevolucion);
             
                return datos;
            }



        #endregion
    }
}

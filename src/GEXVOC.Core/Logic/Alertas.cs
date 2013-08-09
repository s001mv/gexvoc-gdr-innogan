using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public class Alertas
    {
        /// <summary>
        /// Colección de incidencias a mostrar al usuario posterior al arranque de la aplicación.
        /// </summary>
        public static Dictionary<string, object> alertas = new Dictionary<string, object>();

        /// <summary>
        /// Realiza la carga de alertas.
        /// </summary>
        public void CargarAlertas()
        {
            try
            {
                BDController.InicializarBDOperaciones();
                alertas.Clear();

                alertas.Add("Enfermas", AlertarEnfermas());
                alertas.Add("Secadas", AlertarSecadas());
                CargarParidasDiagnosticos();
            }
            catch (Exception ex)
            {
                Traza.RegistrarError("En carga de alertas. Detalle: " + ex.Message);
            }
            finally
            {
                BDController.FinalizarBDOperaciones();            
            }
        }

        /// <summary>
        /// Animales (enfermos ó con un tratamiento) que se encuentran en supresión de leche ó carne en función de la fecha del sistema.
        /// </summary>
        /// <returns></returns>
        private List<AlertarEnfermas> AlertarEnfermas()
        {
        
            List<AlertarEnfermas> lista = new List<AlertarEnfermas>();
            
            List<TratEnfermedad> lstTratEnfermedad = TratEnfermedadData.TratamientosConSupresion(DateTime.Today);
                
                //Solo nos interesan los tratenfermedad cuyos animales se encuentren en supresión actualmente.
                foreach (TratEnfermedad item in lstTratEnfermedad)
                {
                    ///Calculo el texto a poner en el campo supresion
                    string supresion = item.SupresionCarne.HasValue ? "Carne" : string.Empty;
                    if (string.IsNullOrEmpty(supresion))
                        supresion = item.SupresionLeche.HasValue ? "Leche" : string.Empty;
                    else
                        supresion = supresion + " | " + (item.SupresionLeche.HasValue ? "Leche" : string.Empty);

                    ///Calculo el texto a poner en el campo fecha fin supresión
                    string fecha = item.SupresionCarne.HasValue ? item.Fecha.AddDays((int)item.SupresionCarne.Value).ToShortDateString() : string.Empty;
                    if (string.IsNullOrEmpty(fecha))
                        fecha = item.SupresionLeche.HasValue ? item.Fecha.AddDays((int)item.SupresionLeche.Value).ToShortDateString() : string.Empty;
                    else
                        fecha = fecha + " | " + (item.SupresionLeche.HasValue ? item.Fecha.AddDays((int)item.SupresionLeche.Value).ToShortDateString() : string.Empty);

                    lista.Add(new AlertarEnfermas() { CI = item.DescAnimal, Enfermedad = item.DescEnfermedad, FechaFinSupresion = fecha, Supresion = supresion ,Tag=item});
               
                }	    
            return lista;
        }      

        /// <summary>
        /// Alerta sobre animales próximos a ser secados (por ejemplo, vacas que hayan estén a 10 días del secado (fecha de último parto más 305 días).        /// 
        /// </summary>
        /// <returns></returns>
        private List<AlertarSecadas> AlertarSecadas()
        {
            List<AlertarSecadas> lista = new List<AlertarSecadas>();

          
            //Obtengo las hembras de la explotación
            List<Animal> lstAnimales=Animal.Buscar(null,null,null,null,null,Configuracion.Explotacion.Id,null,null,null,null,null,char.Parse("H"),null,null,false,null);

            foreach (Animal animal in lstAnimales)
            {
               DateTime? FUltimoPartoAborto=animal.UltimaFechaParto_Aborto(animal.Id);
               if (FUltimoPartoAborto.HasValue && !Animal.TieneSecadoPosterior(animal.Id, FUltimoPartoAborto.Value))	            
               {
                   //La hembra tiene partos o abortos y no tiene un secado posterior a dichos partos.      
                   ////Console.WriteLine("Dias Normal Estimado -10 : " +  FUltimoPartoAborto.Value.AddDays((int)Configuracion.ObtenerValorInt(Claves.DiasNormalEstimado, animal.DescIdEspecie) - 10).ToShortDateString());
                   ////Console.WriteLine("Dias Normal Estimado: " + FUltimoPartoAborto.Value.AddDays((int)Configuracion.ObtenerValorInt(Claves.DiasNormalEstimado, animal.DescIdEspecie)).ToShortDateString());
                   ////Console.WriteLine("Resta: " +  FUltimoPartoAborto.Value.AddDays((int)Configuracion.ObtenerValorInt(Claves.DiasNormalEstimado, animal.DescIdEspecie)).Subtract(DateTime.Today).Days.ToString());

                   if (DateTime.Today>=FUltimoPartoAborto.Value.AddDays((int)(Configuracion.ObtenerValorInt(Claves.DiasNormalEstimado,animal.DescIdEspecie)??0)-10) &&
                       DateTime.Today <= FUltimoPartoAborto.Value.AddDays((int)(Configuracion.ObtenerValorInt(Claves.DiasNormalEstimado, animal.DescIdEspecie)??0)))
                    
                        lista.Add(new AlertarSecadas() { CI = animal.Nombre, FechaParto = FUltimoPartoAborto.Value, Dias = FUltimoPartoAborto.Value.AddDays((int)Configuracion.ObtenerValorInt(Claves.DiasNormalEstimado, animal.DescIdEspecie)).Subtract(DateTime.Today).Days,Tag=animal });                    

            		 
	            
               }                            
            }         

            return lista;
        }

        /// <summary>
        /// Ha sido una manera de optimizar la carga, puesto que ambas utilizan datos comunes.
        /// Paridas:  Alerta sobre fecha prevista de parto (por ejemplo, fecha de última inseminación más 270 días)
        /// Diagnosticos: Alerta sobre diagnóstico de inseminación (por ejemplo, fecha de última inseminación más 42 días).
        /// </summary>
        void CargarParidasDiagnosticos() 
        {
            List<AlertarParidas> listaParidas = new List<AlertarParidas>();
            List<AlertarDiagnosticos> listaDiagnosticos = new List<AlertarDiagnosticos>();
     
            List<Animal> lstAnimales = Animal.Buscar(null, null, null, null, null, Configuracion.Explotacion.Id, null, null, null, null, null, char.Parse("H"), null, null, false, null);


            foreach (Animal animal in lstAnimales)
            {
                bool cubricionAbierta = false;
                DateTime? FUltimaInseminacionCubricion = animal.UltimaFechaInseminacion_Cubricion(animal.Id, ref cubricionAbierta);

                ///Cargo la lista de las paridas
                if (FUltimaInseminacionCubricion.HasValue &&
                        (!Animal.TienePartoPosterior(animal.Id, FUltimaInseminacionCubricion.Value) &&
                         !Animal.TieneAbortoPosterior(animal.Id, FUltimaInseminacionCubricion.Value)))
                {
                    //La hembra tiene inseminaciones o cubriciones y no tiene partos ni abortos posteriores.
                    int MinimoGestacion = Configuracion.ObtenerValorInt(Claves.DiasMinimoGestacion, animal.DescIdEspecie) ?? 0;
                    int MaximoGestacion = Configuracion.ObtenerValorInt(Claves.DiasMaximoGestacion, animal.DescIdEspecie) ?? 0;

                    //Añado a las alertas todas las hembras que cumplan con:
                    //hoy debe estar entre (fecha ultima inseminación o cubrición + Mínimo) y (fecha ultima inseminación o cubrición + Máximo)
                    if (DateTime.Today >= FUltimaInseminacionCubricion.Value.AddDays(MinimoGestacion) &&
                        DateTime.Today <= FUltimaInseminacionCubricion.Value.AddDays(MaximoGestacion))
                        listaParidas.Add(new AlertarParidas() { CI = animal.Nombre, FechaInseminacion = FUltimaInseminacionCubricion.Value, Tag = animal, Dias = DateTime.Today.Subtract(FUltimaInseminacionCubricion.Value).Days });
                }

                ///Cargo la lista de los diagnosticos.
                if (FUltimaInseminacionCubricion.HasValue &&
                    !Animal.TieneDiagnosticoPosterior(animal.Id, FUltimaInseminacionCubricion.Value))
                {
                    int InicioAlertaDiagnostico = Configuracion.ObtenerValorInt(Claves.DiasAlertaDiagnosticoInicio, animal.DescIdEspecie) ?? 0;
                    int FinAlertaDiagnostico = Configuracion.ObtenerValorInt(Claves.DiasAlertaDiagnosticoFin, animal.DescIdEspecie) ?? 0;
                    if (DateTime.Today >= FUltimaInseminacionCubricion.Value.AddDays(InicioAlertaDiagnostico) &&
                        DateTime.Today <= FUltimaInseminacionCubricion.Value.AddDays(FinAlertaDiagnostico))
                        listaDiagnosticos.Add(new AlertarDiagnosticos() { CI = animal.Nombre, FechaInseminacion = FUltimaInseminacionCubricion.Value, Tag = animal, Dias = DateTime.Today.Subtract(FUltimaInseminacionCubricion.Value).Days });


                }    
    
            }

            alertas.Add("Paridas", listaParidas);
            alertas.Add("Diagnosticos", listaDiagnosticos);
 
        }

        /// <summary>
        /// Avisa de la existencia de alertas a mostrar al usuario.
        /// </summary>
        /// <returns>Existencia de alertas a mostrar.</returns>
        public static bool HayAlertas()
        {           
            return ((((List<AlertarEnfermas>)alertas["Enfermas"]).Count > 0)   ||
                    (((List<AlertarSecadas>)alertas["Secadas"]).Count > 0)     ||
                    (((List<AlertarParidas>)alertas["Paridas"]).Count > 0)     ||
                    (((List<AlertarDiagnosticos>)alertas["Diagnosticos"]).Count > 0)
                   );
                  
        }
    }
}

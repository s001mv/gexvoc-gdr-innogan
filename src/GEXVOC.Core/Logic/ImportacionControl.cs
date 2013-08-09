using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using GEXVOC.Core.Reflection;
using System.Linq;

namespace GEXVOC.Core.Logic
{
    public class ImportacionControl
    {
        
      
        /// <summary>
        /// Animal
        /// </summary>
        public string CI { get; set; }

        /// <summary>
        /// Lactacion
        /// </summary>
        public int? NumLactacion { get; set; }
        public DateTime? FechaInicioLactacion { get; set; }
        public DateTime? FechaFinLactacion { get; set; }

        /// <summary>
        /// Control
        /// </summary>         
        public int? NumControl { get; set; }
        public DateTime? FechaControl { get; set; }
        public string EstadoControl { get; set; }
        public string EstadoOrdeno { get; set; }
        public decimal? LManana { get; set; }
        public decimal? LTarde { get; set; }
        public decimal? LNoche { get; set; }

        /// <summary>
        /// Muestra Control (Análisis)
        /// </summary>
        public string Laboratorio { get; set; }
        public DateTime? FechaMuestra { get; set; }
        public decimal? RtoCelular { get; set; }
        public decimal? Grasa { get; set; }
        public decimal? Urea { get; set; }
        public decimal? Proteina { get; set; }
        public decimal? Lactosa { get; set; }
        public decimal? ExtractoSeco { get; set; }
        public decimal? ExtractoSecoMagro { get; set; }
        public decimal? ExtractoQuesero { get; set; }
        public decimal? LinealPto { get; set; }
        public decimal? Germenes { get; set; }
        public decimal? PtoCrioscopico { get; set; }
        public bool? Inhibidores { get; set; }

        public void ImportarSTR(StringDictionary strDefControl) 
        {

            if (strDefControl!=null)
            {
                Reflection.Reflection.AsignarValoresAPropiedades(strDefControl, this); 

                if (strDefControl.Count != 25)                
                    throw new LogicException("Los datos de la cadena, no tienen la estructura adecuada. Detalle: La estructura debe estar compuesta por 25 columnas\nConsulte el manual para obtener información de la estructura adecuada.");

                Animal animal = Animal.Buscar(CI);
                if (animal == null)
                    throw new LogicException("No se ha encontrado el animal con el C.I.: " + CI + ", el proceso no puede continuar.");
                else
                {

                    BD.IniciarBDOperaciones();
                    BD.IniciarTransaccion();
                    try
                    {


                        ///-----------LACTACIÓN----------------
                        ///Puede ser manual o automática:
                        ///a) Manual (Se nos envían los parámetros NumLactacion y FechaInicioLactacion
                        ///b) Automática. (No se envían dichos valores, por tanto cuando creamos el control se creará automáticamente la lactación).
                        bool CrearLactacion = false;

                        
                        //Comprobamos los valores mínimos, de 
                        if (NumLactacion.HasValue && FechaInicioLactacion.HasValue)
                        { ///a) Manual
                            Lactacion UltimaLactacion = animal.UltimaLactacion();
                            if (UltimaLactacion != null)
                            {//Tenemos al menos una lactación

                                ///Comprobamos que la que la lactacion dada de alta no es mayor que la que se nos envía.                       
                                if (UltimaLactacion.Numero > NumLactacion)
                                    throw new LogicException("El animal con el C.I.: " + CI + ", tiene una lactación más reciente que la que se intenta importar.");
                                if (UltimaLactacion.Numero < NumLactacion)//Hay que crear una lactacion
                                    CrearLactacion = true;
                                if (UltimaLactacion.Numero == NumLactacion)
                                {
                                    if (FechaInicioLactacion.Value != UltimaLactacion.FechaInicio)
                                        throw new LogicException("Las fechas de inicio de la lactación nº " + NumLactacion.ToString() + " no se corresponden.\n" +
                                            "Fecha Almacenada: " + UltimaLactacion.FechaInicio.ToShortDateString() + ",Fecha Importar: " + FechaInicioLactacion.Value.ToShortDateString());

                                    /////////¿Que hacer con fecha fin si está valorada?
                                    /////////¿Hay que hacer un secado?
                                    /////////Pero despues de importar el control.
                                    //////if (this.FechaFinLactacion.HasValue)
                                    //////    CerrarLactacion = true;
                                    //FRAN: POR AHORA CON ESTA INFORMACIÓN SE HA DECIDIDO NO HACER NADA, LA LACTACIÓN
                                    //DEBE SER CERRADA POR LOS PROCESOS NORMALES COMO EL SECADO
                                }


                            }
                            else//El animal no tiene ninguna lactación, debemos crear la lactación.
                                CrearLactacion = true;

                            if (CrearLactacion)
                            {
                                ///Antes de crear la lactacion debo asegurarme de cerrar una existente si existe
                                Lactacion lactacionExistente = animal.UltimaLactacionAbierta();
                                //existe una lactación abierta y hay un nuevo parto o aborto con lactación ya que esto
                                //puede ocurrir porque en inseminación no podemos controlar que tenga un secado o que 
                                //no hubiese apertura de lactación para hacer la inseminación porque el ciclo (I-P-C-S)
                                //en algunos casos finaliza en el parto o aborto.

                                if (lactacionExistente != null && (lactacionExistente.FechaInicio < animal.UltimaFechaParto_Aborto(animal.Id)) && (animal.UltimaFechaParto_Aborto(animal.Id) < FechaInicioLactacion.Value))
                                {
                                    Secado secado = new Secado();
                                    secado.IdHembra = animal.Id;
                                    secado.Fecha = lactacionExistente.UltimoControl().Fecha;
                                    secado.Insertar(); //Al insertar un secado se cierra la lactación abierta.                                    
                                }

                                Lactacion lactacion = new Lactacion();
                                lactacion.IdHembra = animal.Id;
                                lactacion.FechaInicio = FechaInicioLactacion.Value;                                
                                lactacion.Insertar();
                                if (lactacion.Numero!=NumLactacion)
                                    throw new LogicException("El nº proporcionado (" + NumLactacion + ") para la lactación no se corresponde con el nº adecuado (" + lactacion.Numero+ ")");

                            }
                        }
                        //else seria el caso b) en el que no haremos nada, pues le dejaremos la labor de tratamiento de la lactación a los controles.

                        

                        ///-----------CONTROL----------------
                        ///          -STATUS CONTROL-
                        if (string.IsNullOrEmpty(this.EstadoControl))                        
                            throw new LogicException("El campo Estado Control es obligatorio. Proceso cancelado");
                        
                        StatusControl statuscontrol=StatusControl.Buscar(null,this.EstadoControl).FirstOrDefault();
                        if (statuscontrol==null)
                        {
                            statuscontrol = new StatusControl();
                            statuscontrol.Codigo = "00";
                            statuscontrol.Descripcion = this.EstadoControl;
                            statuscontrol.Insertar();                            
                        }

                        ///          -STATUS ORDEÑO-
                        StatusOrdeno statusordeno = StatusOrdeno.Buscar(this.EstadoControl).FirstOrDefault();
                        if (statusordeno == null)
                        {
                            statusordeno = new StatusOrdeno();                          
                            statusordeno.Descripcion = this.EstadoOrdeno;
                            statusordeno.Insertar();
                        }

                        ///          -CONTROL-                        
                        /// Comprobar los valores requeridos:
                        if (statuscontrol == null || statuscontrol.Id == 0)
                            throw new LogicException("El Estado Control no es reconocido. Proceso cancelado");
                        if (!FechaControl.HasValue)
                            throw new LogicException("El Campo Fecha Control es requerido. Proceso cancelado");                        

                        ControlLeche control = new ControlLeche();
                        control.IdHembra = animal.Id;
                        control.IdControl = statuscontrol.Id;
                        control.IdOrdeno = statusordeno.Id;
                        control.Fecha = FechaControl.Value;
                        if (this.LManana.HasValue)
                            control.LecheManana = this.LManana.Value;
                        if (this.LTarde.HasValue)
                            control.LecheTarde = this.LTarde.Value;
                        if (this.LNoche.HasValue)
                            control.LecheNoche = this.LNoche.Value;
                        control.Insertar();
                        if (control.Numero != NumControl)
                            throw new LogicException("El nº proporcionado (" + NumControl + ") para el control no se corresponde con el nº adecuado (" + control.Numero + ")");



                        ///-----------ANÁLISIS----------------
                        if (!string.IsNullOrEmpty(this.Laboratorio) && this.FechaMuestra.HasValue)
                        {
                            ///          -LABORATORIO-               
                            ///          
                            Laboratorio laboratorio = Core.Logic.Laboratorio.Buscar(this.Laboratorio,null,null).FirstOrDefault();
                            if (laboratorio == null)
                            {
                                laboratorio = new Laboratorio();
                                laboratorio.Nombre = this.Laboratorio;
                                laboratorio.Insertar();
                            }

                            ///Tenemos los datos mínimos para crear un análisis.
                            /// Comprobar los valores requeridos:

                            if (laboratorio == null || laboratorio.Id == 0)
                                throw new LogicException("El Laboratorio no es reconocido. Proceso cancelado");

                            MuestraControl muestra = new MuestraControl();
                            muestra.IdControl = control.Id;
                            muestra.IdLaboratorio = laboratorio.Id;
                            muestra.Fecha = this.FechaMuestra.Value;
                            muestra.RctoCelular = this.RtoCelular;
                            muestra.Grasa = this.Grasa;
                            muestra.Urea = this.Urea;
                            muestra.Proteina = this.Proteina;
                            muestra.Lactosa = this.Lactosa;
                            muestra.ExtractoSeco = this.ExtractoSeco;
                            muestra.ExtractoSecoMagro = this.ExtractoSecoMagro;
                            muestra.ExtractoQuesero = this.ExtractoQuesero;
                            muestra.LinealPto = this.LinealPto;
                            muestra.Germenes = this.Germenes;
                            muestra.PuntoCrioscopico = this.PtoCrioscopico;
                            muestra.Ionhibidores = this.Inhibidores;
                            muestra.Insertar();                            
                        }

                        /////////////-----------CERRAR LACTACION----------------
                        /////////////-----------ESTE PROCESO POR AHORA NO SE ACTIVARÁ----------------
                        //////////if (CerrarLactacion)//Tengo que cerrar la lactación
                        //////////{
                        //////////    Lactacion ultimalactacion = animal.UltimaLactacionAbierta();
                        //////////    ultimalactacion.FechaFin = this.FechaFinLactacion.Value;
                        //////////    ultimalactacion.Actualizar();                           
                            
                            
                        //////////}

                        BD.FinalizarTransaccion(true);
                        BD.FinalizarBDOperaciones();
                    }
                    catch (Exception)
                    {
                        BD.FinalizarTransaccion(false);
                        BD.FinalizarBDOperaciones();
                        throw;
                    }
                }


                
                        
                                

            }        
        
        }

      

    }
}

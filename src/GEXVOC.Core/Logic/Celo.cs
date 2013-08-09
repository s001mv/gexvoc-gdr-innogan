using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Celo : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        
           
        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        	/// <summary>
        	/// Guarda (Crea un nuevo registro).
        	/// </summary>
        	public void Insertar(){
    			ValidarLogica(TipoOperacion.Insercion);
            	CeloData.Insertar(this);            
        	}

        	/// <summary>
        	/// Actualiza (Modifica un registro existente).
        	/// </summary>
	        public void Actualizar(){
				ValidarLogica(TipoOperacion.Actualizacion);
            	CeloData.Actualizar(this);
			}

        	/// <summary>
        	/// Elimina un registro existente.
        	/// </summary>
       	 	public void Eliminar(){
				ValidarLogica(TipoOperacion.Borrado);
            	CeloData.Eliminar(this);            
        	}
       
			
        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        	public IClaseBase CargarContextoOperacion(TipoContexto Modo){ 
                IClaseBase rtno=null;
			    switch (Modo)
                {
                	case TipoContexto.Insercion:
                    	rtno = new Celo();
	                    break;
    	            case TipoContexto.Modificacion:
        	            rtno = CeloData.GetCeloOP(this.Id);
            	        break;               
            	}             
                return rtno;
            	
        	}


            /// <summary>
            /// Obtiene un/una Celo a partir de su id.
            /// </summary>
            /// <param name="id">Id.</param>
            /// <returns>Celo con el id especificado.</returns>
            public static Celo Buscar(int id){
                return CeloData.GetCelo(id);
            }

            /// <summary>
            /// Obtiene los/las Celo que coinciden con los criterios de búsqueda.
            /// </summary>
            /// <param name="nombre">Nombre.</param>  
            /// <param name="provincia">Provincia.</param>
            /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
            public static List<Celo> Buscar(int? idHembra,int? idVeterinario,DateTime? fecha)
            {
                return CeloData.GetCelos(idHembra, idVeterinario,fecha);
            }
            public static List<Celo> Buscar(int? idHembra, int? idVeterinario, DateTime? fechaInicio,DateTime? fechaFin)
            {
                return CeloData.GetCelos(idHembra, idVeterinario, fechaInicio, fechaFin);
            }

			/// <summary>
    	    /// Obtiene todos los registros del tipo Celo
	        /// </summary>
        	/// <returns>Devuelve todos los registros de la tabla></returns>
            public static List<Celo> Buscar()
            {
                return CeloData.GetCelos(null,null,null);
            }

       
        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

            ///// <summary>
            ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
            ///// </summary>
            //public string DescProvincia { get { return this.Municipio.Provincia.Descripcion; } }

            
            ///// <summary>
            ///// Propiedad que devuelve la descripción de el/la Animal a la que pertenece el elemento
            ///// </summary>


            
            ///// <summary>
            ///// Comienzo del intervalo entre celos que debe cumplirse.
            ///// Nos indica que no se podra dar de alta un celo de un animal en los dias aqui establecidos contando a partir
            ///// del último celo.
            ///// Valor de configuración.
            ///// </summary>
            //private int IntervaloCelosInicio = Convert.ToInt32(Configuracion.Parametros["IntervaloCelosInicio"]);
            ///// <summary>
            ///// Fin del intervalo entre celos que debe cumplirse.
            ///// Nos indica que no se podra dar de alta un celo de un animal con una fecha superior a la fecha del ultimo celo 
            ///// + los dias aqui establecidos.
            ///// Valor de configuración.
            ///// </summary>
            //private int IntervaloCelosFin = Convert.ToInt32(Configuracion.Parametros["IntervaloCelosFin"]);


            /// <summary>
            /// Propiedad que devuelve el nombre del animal ala que pertenece el celo
            /// </summary>
            public string DescAnimal
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.Animal != null)
                        rtno = this.Animal.Nombre;

                    return rtno;
                }
            }
            /// <summary>
            /// Propiedad que devuelve la descripción de el/la Personal al que pertenece el elemento
            /// </summary>
            public string DescPersonal
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.Veterinario != null)
                        rtno = this.Veterinario.NombreCompleto;

                    return rtno;
                }
            }
      
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.
      

        #endregion

        

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
			/// <summary>
        	/// Valida la lógica de negocio, concluye si la operacion es admitida.
        	/// </summary>
        	/// <param name="operacion">Operación en curso que se debe validar.</param>
        	private void ValidarLogica(TipoOperacion operacion)
			{
                if (operacion==TipoOperacion.Insercion || operacion== TipoOperacion.Actualizacion)
                {
                      
                    Animal animal = Animal.Buscar(this.IdHembra);
                    ///Comprobar que la fecha del celo no se mayor que la fecha de nacimiento del animal
                
                    if (animal!=null)                                    
                        if (this.Fecha < animal.FechaNacimiento)                        
                            throw new LogicException("La fecha del celo debe ser superior a la fecha de nacimiento del animal.");

                    List<Celo> lstCelos = null;
                    if (this.Id != 0)//Es una modificacion, en la modificacion solo comparamos con la lista menor del id a modificar.                     
                        lstCelos = CeloData.GetCelosMenores(this.IdHembra, this.Id);
                    else//Es una insercion, comparamos con toda la lista de celos.
                        lstCelos = animal.lstCelos;
                    if (lstCelos != null && (lstCelos.Where(E => E.Fecha.Date == this.Fecha.Date).Count() > 0))
                        throw new LogicException("No es posible la asignación de la fecha (" + this.Fecha.ToShortDateString() + ") al celo, porque ya existe otro celo con esta fecha."); 

                    
                }

                
           
                //Añadir código de validación
                if (operacion== TipoOperacion.Actualizacion || operacion== TipoOperacion.Borrado)//Impedimos la modificacion o borrado de todos los celos que no sean el último.
                {
                    Animal animal = Animal.Buscar(this.IdHembra);
                    
                    List<Celo> lstCelos = animal.lstCelos;
                    if (lstCelos!=null && lstCelos.Count>0)
                    {
                        Celo UltimoCelo = lstCelos.OrderByDescending(E => E.Fecha).First();

                        if (UltimoCelo.Id>this.Id)
                            throw new LogicException ("Solo se puede editar o borrar el último celo introducido, el resto de las operaciones se encuentran restringidas.");                        
                           
                        
                    }
                    
                   
                    
                }
            }

      

        /// <summary>
        /// Comprobamos que la fecha sea correcta, que se encuentre en el rango que corresponde.
        /// Si es una modidicacion se comprueba solo con las inseminaciones anteriores (para validar la actual)
        /// Nota: Existe una pequeña posibilidad de que no se correspondan las fechas, si modificas una anterior, pues la posterior puede ser
        /// que se encuente todavia en rango o no, por ahora esto esta restringido en validar logica impidiedo que se modifiquen los celos
        /// que no sean el ultimo.
        /// 
        /// Una fecha de celo debe estar comprendida entre un rango configurable de fechas (normalmente 18-24) desde su predecesora.
        /// Esta regla se rompe ante un parto u aborto, ya que en este caso podremos dar de alta celos con total libertad.
        /// Esta validación se aplica desde el primer celo despues de parto u aborto.
        /// 
        /// Notas: Esta validacion de lógica puede estar capturada en los formularios para permitir igualmente la operación, en funcion de
        /// la pregunta correspondiente al usuario.
        /// </summary>
        partial void OnFechaChanged()
        {

                DateTime fechaComprobar = this.Fecha;

                if (IdHembra == 0)
                    throw new LogicException("Es necesario asignar el animal antes de hacer la asiganacion de la fecha");

                Animal animal = Animal.Buscar(this.IdHembra);                   
                

                 List<Celo> lstCelos=null;
                 if (this.Id != 0)//Es una modificacion, en la modificacion solo comparamos con la lista menor del id a modificar.                     
                     lstCelos = CeloData.GetCelosMenores(this.IdHembra, this.Id);
                 else//Es una insercion, comparamos con toda la lista de celos.
                     lstCelos = animal.lstCelos;
                

                if (lstCelos != null && lstCelos.Count > 0)
                {

                    DateTime? UltimaFechaParto_Aborto = animal.UltimaFechaParto_Aborto(this.IdHembra);

                    Celo UltimoCelo = null;
                    try
                    {
                        UltimoCelo= lstCelos.OrderByDescending(E => E.Fecha).First();
                    }
                    catch (Exception)
                    {   }
                    if (UltimoCelo!=null)
                    {
                        //Comprobar si el celo es el primero, Si el ultimo celo tiene una fecha posterior al ultimo parto u aborto

                        if (UltimaFechaParto_Aborto == null || UltimaFechaParto_Aborto>UltimoCelo.Fecha)//Seguimos las comprobaciones si en caso de no ser el primer celo despues de la fecha del ultimo parto-aborto
                        {
                            if (fechaComprobar.Date < UltimoCelo.Fecha.Date.AddDays(animal.IntervaloCelosInicio) || fechaComprobar.Date > UltimoCelo.Fecha.Date.AddDays(animal.IntervaloCelosFin))
                                {
                                    throw new LogicException("No es posible asignar la fecha de celo: " + fechaComprobar.ToShortDateString()
                                        + " al animal: " + animal.Nombre + "\rCausa: El siguiente celo para este animal debe tener una fecha comprendida entre: " +
                                        UltimoCelo.Fecha.AddDays(animal.IntervaloCelosInicio).ToShortDateString() + " y " + UltimoCelo.Fecha.AddDays(animal.IntervaloCelosFin).ToShortDateString());
                                }  
                        }
                    }
                    
                    
                }
            }

         
        #endregion


    }
}
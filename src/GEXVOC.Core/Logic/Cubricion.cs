using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Cubricion : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        
           
        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        	/// <summary>
        	/// Guarda (Crea un nuevo registro).
        	/// </summary>
        	public void Insertar(){
    			ValidarLogica(TipoOperacion.Insercion);
            	CubricionData.Insertar(this);            
        	}

        	/// <summary>
        	/// Actualiza (Modifica un registro existente).
        	/// </summary>
	        public void Actualizar(){
				ValidarLogica(TipoOperacion.Actualizacion);
            	CubricionData.Actualizar(this);
			}

        	/// <summary>
        	/// Elimina un registro existente.
        	/// </summary>
       	 	public void Eliminar(){
                ValidarLogica(TipoOperacion.Borrado);

                Boolean TransacionPropia = false;
                TransacionPropia = BDController.IniciarTransaccion();
                try
                {
                    //ELIMINO LOS REGISTROS RELACIONADOS DE LA TABLA ESTANCIAS.
                    List<Estancia> lstEstancias = this.lstEstancias;
                    foreach (Estancia item in lstEstancias)
                        item.Eliminar();

                    CubricionData.Eliminar(this);

                    if (TransacionPropia)
                        BDController.FinalizarTransaccion(true);
                }
                catch (Exception ex)
                {
                    if (TransacionPropia)
                        BDController.FinalizarTransaccion(false);

                    Traza.RegistrarError(ex);
                    throw new LogicException(ex.Message);
                }


				
                
        	}
       
			
        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        	public IClaseBase CargarContextoOperacion(TipoContexto Modo){ 
                IClaseBase rtno=null;
			    switch (Modo)
                {
                	case TipoContexto.Insercion:
                    	rtno = new Cubricion();
	                    break;
    	            case TipoContexto.Modificacion:
        	            rtno = CubricionData.GetCubricionOP(this.Id);
            	        break;               
            	}             
                return rtno;
            	
        	}


            /// <summary>
            /// Obtiene un/una Cubricion a partir de su id.
            /// </summary>
            /// <param name="id">Id.</param>
            /// <returns>Cubricion con el id especificado.</returns>
            public static Cubricion Buscar(int id){
                return CubricionData.GetCubricion(id);
            }

            /// <summary>
            /// Obtiene los/las Cubricion que coinciden con los criterios de búsqueda.
            /// </summary>
            /// <param name="nombre">Nombre.</param>  
            /// <param name="provincia">Provincia.</param>
            /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
            public static List<Cubricion> Buscar(int? idLote,int? idTipo,DateTime? fechaInicio,DateTime? fechaFin)
            {
                return CubricionData.GetCubriciones( idLote,idTipo, fechaInicio, fechaFin);
            }

			/// <summary>
    	    /// Obtiene todos los registros del tipo Cubricion
	        /// </summary>
        	/// <returns>Devuelve todos los registros de la tabla></returns>
 			public static List<Cubricion> Buscar()
            {
                return CubricionData.GetCubriciones(null,null,null,null);
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
            ///// Propiedad que devuelve la descripción de el/la Lote a la que pertenece el elemento
            ///// </summary>
            public string DescLote
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.LoteAnimal != null)
                        rtno = this.LoteAnimal.Descripcion;

                    return rtno;
                }
            }
            public string Identificacion
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null)
                        rtno = FechaInicio.ToShortDateString() + " " + DescLote;

                    return rtno;
                }
            }

            
            ///// <summary>
            ///// Propiedad que devuelve la descripción de el/la Tipo a la que pertenece el elemento
            ///// </summary>
            public string DescTipo
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.TipoCubricion != null)
                        rtno = this.TipoCubricion.Descripcion;

                    return rtno;
                }
            }
      
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.

            public List<Estancia> lstEstancias
            {
                get { return Logic.Estancia.Buscar(this.Id,null,null,null); }

            }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
			/// <summary>
        	/// Valida la lógica de negocio, concluye si la operacion es admitida.
        	/// </summary>
        	/// <param name="operacion">Operación en curso que se debe validar.</param>
        	private void ValidarLogica(TipoOperacion operacion)
			{
                ///Notas: 
                ///       - No es necesario controlar que en las modificaciones exista más de una fecha fin vacía, ya que solo se permite
                ///         modificar la ultima cubrición, y no es posible insertar ninguna nueva a no ser que no existan fechas fin vacías.
                ///

                //Impedimos que se modifiquen o borren todos aquellos registros que no sean el último introducido
                if (operacion == TipoOperacion.Actualizacion || operacion == TipoOperacion.Borrado)//Impedimos la modificacion o borrado de todas las cubriciones que no sean la último.
                {
                    List<Cubricion> lstCubriciones = Cubricion.Buscar(this.IdLote,null,null,null);
                    if (lstCubriciones != null && lstCubriciones.Count > 0)
                    {
                        Cubricion UltimaCubricion = lstCubriciones.OrderByDescending(E => E.FechaInicio).First();
                        if (UltimaCubricion.Id > this.Id)
                            throw new LogicException("Solo se puede modificar o borrar la última cubrición introducida para este lote, el resto de las operaciones se encuentran restringidas.");
                    }

                    ///Fran
                    ///Se quita la restricción pq se puede dar el caso de que creemos un parto con una cubricion abierta.
                    ///Y despues tengamos que modificarla para establecerle una fecha fin (para poder meter otro parto posterior)
                    ///Podría ser interesante en este caso, permitir unicamente cambiar la fecha finç
                    ///(La restricción continua activa en el caso del borrado)
                    ///----------------------------------------------------------------------------------------------------------
                    //////////COMPROBAR QUE NO SE ELIMINE NI MODIFIQUEN CUBRICIONES CON ANIMALES CON PARTOS U ABORTOS POSTERIORES.
                    ////////string mensajeError = string.Empty;
                    ////////LoteAnimal lote = LoteAnimal.Buscar(this.IdLote);

                    ////////foreach (Animal item in lote.lstAnimales)
                    ////////{

                    ////////    if (Animal.TienePartoPosterior(item.Id, this.FechaInicio) || Animal.TieneAbortoPosterior(item.Id, this.FechaInicio))
                    ////////    {
                    ////////        mensajeError += "La hembra: " + item.Nombre + " tiene un parto posterior, la modificación  de la cubrición no es posible en esta circunstancia.\r";
                    ////////        continue;
                    ////////    }
                    ////////    if (Animal.TieneAbortoPosterior(item.Id, this.FechaInicio))
                    ////////    {
                    ////////        mensajeError += "La hembra: " + item.Nombre + " tiene un aborto posterior, la modificación  de la cubrición no es posible en esta circunstancia.\r";
                    ////////        continue;
                    ////////    }
                    ////////}
                    ////////if (mensajeError != string.Empty)
                    ////////    throw new LogicException(mensajeError);

                }
                if (operacion == TipoOperacion.Borrado)//Impedimos la modificacion o borrado de todas las cubriciones que no sean la último.
                {
                    //COMPROBAR QUE NO SE ELIMINE NI MODIFIQUEN CUBRICIONES CON ANIMALES CON PARTOS U ABORTOS POSTERIORES.
                    string mensajeError = string.Empty;
                    LoteAnimal lote = LoteAnimal.Buscar(this.IdLote);

                    foreach (Animal item in lote.lstAnimales)
                    {

                        if (Animal.TienePartoPosterior(item.Id, this.FechaInicio) || Animal.TieneAbortoPosterior(item.Id, this.FechaInicio))
                        {
                            mensajeError += "La hembra: " + item.Nombre + " tiene un parto posterior, el borrado de la cubrición no es posible en esta circunstancia.\r";
                            continue;
                        }
                        if (Animal.TieneAbortoPosterior(item.Id, this.FechaInicio))
                        {
                            mensajeError += "La hembra: " + item.Nombre + " tiene un aborto posterior, el borrado de la cubrición no es posible en esta circunstancia.\r";
                            continue;
                        }
                    }
                    if (mensajeError != string.Empty)
                        throw new LogicException(mensajeError);
                }

                ////////if (operacion== TipoOperacion.Actualizacion)
                ////////{
                ////////      string mensajeError = string.Empty;
                ////////      LoteAnimal lote = LoteAnimal.Buscar(this.IdLote);

                ////////      foreach (Animal item in lote.lstAnimales)
                ////////      {

                ////////          if (Animal.TienePartoPosterior(item.Id, this.FechaInicio) || Animal.TieneAbortoPosterior(item.Id, this.FechaInicio))
                ////////          {
                ////////              mensajeError += "La hembra: " + item.Nombre + " tiene un parto posterior, la modificación  de la cubrición no es posible en esta circunstancia.\r";
                ////////              continue;
                ////////          }
                ////////          if (Animal.TieneAbortoPosterior(item.Id, this.FechaInicio))
                ////////          {
                ////////              mensajeError += "La hembra: " + item.Nombre + " tiene un aborto posterior, la modificación  de la cubrición no es posible en esta circunstancia.\r";
                ////////              continue;
                ////////          }
                ////////      }
                ////////      if (mensajeError != string.Empty)
                ////////          throw new LogicException(mensajeError);

                    
                ////////}
            
                if (operacion== TipoOperacion.Insercion )//Comprobar que todos los animales del lote pueden ser añadidos a la cubricion
                {

                    //Comprobar que no existan se inserte ninguna cubricion si existe alguna sin fecha fin.
                    List<Cubricion> lstCubriciones = CubricionData.GetCubricionesSinFechaFin(this.IdLote);
                    if (lstCubriciones != null && lstCubriciones.Count > 0)
                        throw new LogicException("No es posible insertar la cubrición, porque existe una cubrición sin fecha fin para este lote.");



                    LoteAnimal lote = LoteAnimal.Buscar(this.IdLote);
                  
                    
                    string mensajeError = string.Empty;
                    foreach (Animal item in lote.lstAnimales)
                    {
                        if (Animal.TienePartoPosterior(item.Id, this.FechaInicio) || Animal.TieneAbortoPosterior(item.Id, this.FechaInicio))
                        {
                            mensajeError += "La hembra: " + item.Nombre + " tiene un parto posterior, la inserción  de la cubrición no es posible en esta circunstancia.\r";
                            continue;
                        }
                        if (Animal.TieneAbortoPosterior(item.Id, this.FechaInicio))
                        {
                            mensajeError += "La hembra: " + item.Nombre + " tiene un aborto posterior, la inserción  de la cubrición no es posible en esta circunstancia.\r";
                            continue;
                        }


                        // La cubricion no puede efectuarse hasta pasados 25 días (parametrizables) de la fecha de parto.
                        Parto ultimoparto = item.UltimoParto();
                        if (ultimoparto != null)
                        {
                            DateTime FPostParto = ultimoparto.Fecha.AddDays(item.PeriodoPostParto);
                            if (this.FechaInicio < FPostParto)
                            {
                                mensajeError += "La fecha Inicio de la cubrición para la hembra " + item.Nombre + " debe ser superior al " + FPostParto.AddDays(-1).ToShortDateString() + " porque debe ser respetado el período postparto.\r";
                                continue;
                            }
                        }
                        //**//
                        bool CubricionAbierta = false;
                        DateTime? FechaUltimaInseCubri = item.UltimaFechaInseminacion_Cubricion(item.Id, ref CubricionAbierta);
                        //Comprobar que no introduzco una cubricion anterior a la ultima fecha de inseminacion o cubricion.
                        if (FechaUltimaInseCubri != null)
                        {
                            if (this.FechaInicio <= FechaUltimaInseCubri)
                            {
                                mensajeError += "La fecha de cubrición para la hembra " + item.Nombre + " debe ser superior al " + ((DateTime)FechaUltimaInseCubri).AddDays(1).ToShortDateString() + " porque existen cubriciones o inseminaciones anteriores.\r";
                                continue;
                            }
                        }
                      
	
                    }
                    if (mensajeError != string.Empty)
                        throw new LogicException(mensajeError);

                }

                //////if (operacion== TipoOperacion.Borrado)
                //////{
                //////    //Comprobamos que no se pueda borrar la cubrición si alguno de los animales de la misma ha tenido partos posteriores a 
                //////    //la fecha de esta.
                //////    LoteAnimal lote = LoteAnimal.Buscar(this.IdLote);
                //////    string mensajeError = string.Empty;
                //////    foreach (Animal hembra in lote.lstAnimales)
                //////    {
                //////        if (Animal.TienePartoPosterior(hembra.Id, this.FechaInicio))
                //////        {
                //////            mensajeError += "La hembra: " + hembra.Nombre + " tiene un parto posterior.\r";
                //////            continue;
                //////        }
                //////        if (Animal.TieneAbortoPosterior(hembra.Id, this.FechaInicio))
                //////        {
                //////            mensajeError += "La hembra: " + hembra.Nombre + " tiene un aborto posterior.\r";
                //////            continue;
                //////        }
                //////    }
                //////    if (mensajeError != string.Empty)
                //////        throw new LogicException("No es posible eliminar la Cubrición, Causas:\r" + mensajeError);                  
                    
                //////}

               
              
            

            }

            partial void OnFechaFinChanged()
            {
                if (this.FechaFin<this.FechaInicio)                
                   throw new LogicException ("La fecha fin debe ser posterior o igual a la fecha inicio, nunca anterior");       
             
                //Compruebo que la fecha fin no pueda ser menor a ninguna de las fechas inicio ni fin de las estancias incluidas en esta
                foreach(Estancia item in lstEstancias)
                {
                    if ((item.FechaFin !=null && item.FechaFin > this.FechaFin) || item.FechaInicio>this.FechaFin)
                        throw new LogicException("La fecha fin no es válida, debe ser mayor o igual a cualquiera de las fechas " + 
                    " incluidas en las Estancias de esta cubrición.");                           
                
                }


                //compruebo que la fecha fin no pueda ser mayor que la fecha fin del lote
                LoteAnimal lote = LoteAnimal.Buscar(this.IdLote);
                if (lote.FechaBaja!=null)
                    if (this.FechaFin > lote.FechaBaja)
                        throw new LogicException("La fecha fin no es válida, debe ser menor o igual a la fecha de baja del lote: " + ((DateTime)lote.FechaBaja).ToShortDateString());                    
                
               
            }
            partial void OnFechaInicioChanged()
            {
                if (this.FechaInicio > this.FechaFin)
                    throw new LogicException("La fecha inicio debe ser anterior o igual a la fecha inicio, nunca posterior.");   

              

                foreach (Cubricion item in Cubricion.Buscar(this.IdLote,null, null, null))
                    if ((this.FechaInicio < item.FechaFin) && this.Id != item.Id)
                        throw new LogicException("La fecha inicio de la cubrición para el lote seleccionado no es válida,Causa:\r"
                                                + "La fecha inicio de la  cubrición debe ser mayor o igual que cualquiera de las fechas fin anteriores.\r"
                                                + "La última fecha encontrada es: " + ((DateTime)item.FechaFin).ToShortDateString());	                       

                //Compruebo que la feha inicio no pueda ser menor que ninguna de las fechas de inicio de las estancias incluidas en esta cubricion
                foreach (Estancia item in lstEstancias)
                {
                    if (item.FechaInicio < this.FechaInicio)
                        throw new LogicException("La fecha inicio no es válida, debe ser mayor o igual a cualquiera de las fechas de inicio " +
                    " incluidas en las Estancias de esta cubrición.");

                }

                //compruebo que la fecha inicio no pueda ser menor que la fecha inicio del lote
                LoteAnimal lote = LoteAnimal.Buscar(this.IdLote);
                if (this.FechaInicio < lote.FechaAlta)
                    throw new LogicException("La fecha inicio no es válida, debe ser mayor o igual a la fecha de alta del lote: " + lote.FechaAlta.ToShortDateString());
                if (lote.FechaBaja!=null)                
                    if (this.FechaInicio > lote.FechaBaja)
                        throw new LogicException("La fecha inicio no es válida, debe ser menor o igual a la fecha de baja del lote: " + ((DateTime)lote.FechaBaja).ToShortDateString());                    
                
                    
                
                
               
            }



       


         
        #endregion

        


    }
}
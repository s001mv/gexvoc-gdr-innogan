using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;


namespace GEXVOC.Core.Logic
{
    public partial class Receta : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        
           
        #endregion

        void CrearHistMedicamento() 
        {

            int? idEspecie = null;
            TratEnfermedad tratamiento = TratEnfermedad.Buscar(this.IdTratamiento);
            DiagAnimal diagnostico = null;
            Animal animal = null;

            if (tratamiento != null)
            {
                diagnostico = DiagAnimal.Buscar(tratamiento.IdDiagnostico);
                if (diagnostico != null)
                    animal = Animal.Buscar(diagnostico.IdAnimal);
            }

            if (animal != null)
                idEspecie = animal.DescIdEspecie;

            if (diagnostico!=null && diagnostico.IdEnfermedad !=null && idEspecie!=null)
            {
                List<HistMedicamento> lsthistorial = HistMedicamento.Buscar(idEspecie, diagnostico.IdEnfermedad, this.IdMedicamento);
                if (lsthistorial == null || lsthistorial.Count == 0)
                {
                    HistMedicamento historial = new HistMedicamento();
                    historial.IdEnfermedad = (int)diagnostico.IdEnfermedad;
                    historial.IdEspecie = (int)idEspecie;
                    historial.IdMedicamento = this.IdMedicamento;
                    historial.Insertar();
                
                }
            }
             

        }

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Si tengo un gasto asociado, sincroniza el importe del gasto con el importe de la receta.
        /// Si no tengo gasto asociado y el importe de la receta es != de '0' añado el gasto.        
        /// </summary>
        void ActualizarGasto()         
        {

            List<Gasto> lstgasto = Logic.Gasto.Buscar(null, null, null, null, this.Id, null, null, null, null, null, string.Empty, null, null, null,null,null);
                if (lstgasto == null || lstgasto.Count == 0)
                {
                    if (this.Importe != 0)
                    {
                        Gasto gasto = new Gasto();
                        gasto.IdTratamiento = this.IdTratamiento;
                        gasto.IdExplotacion = Configuracion.Explotacion.Id;
                        gasto.Importe = this.Importe;
                        gasto.Total = this.Importe;
                        gasto.IdNaturaleza = Configuracion.NaturalezaGastoSistema(Configuracion.NaturalezasGastosSistema.DIAGNOSTICO_ENFERMEDAD_ANIMAL).Id;
                        gasto.Fecha = this.Fecha;

                        if (this.Id > 0)
                        {
                            gasto.IdReceta = this.Id;
                            gasto.Insertar();
                        }
                        else
                            this.Gasto.Add(gasto);

                    }
                }
                else//Existe un gasto enlazado a la receta
                {
                    Gasto gasto = lstgasto.First();
                    if (this.Importe != 0)//Actualizo el importe del gasto con el actual
                    {
                        gasto = (Gasto)gasto.CargarContextoOperacion(TipoContexto.Modificacion);
                        gasto.Importe = this.Importe;
                        gasto.Total = this.Importe;
                        gasto.Actualizar();

                    }
                    else//Si el importe es nulo, implica que el gasto debe ser eliminado
                        gasto.Eliminar();
                    
                
                }
           
        }

        	/// <summary>
        	/// Guarda (Crea un nuevo registro).
        	/// </summary>
        	public void Insertar(){
    			ValidarLogica(TipoOperacion.Insercion);
                
                     Boolean TransacionPropia = false;

                     try//Iniciando la logica de negocio en el borrado.
                     {
                         TransacionPropia = BDController.IniciarTransaccion();

                         CrearHistMedicamento();
                         ActualizarGasto();
                         RecetaData.Insertar(this);

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

        	/// <summary>
        	/// Actualiza (Modifica un registro existente).
        	/// </summary>
	        public void Actualizar(){
				ValidarLogica(TipoOperacion.Actualizacion);

                Boolean TransacionPropia = false;

                try//Iniciando la logica de negocio en el borrado.
                {
                    TransacionPropia = BDController.IniciarTransaccion();

                    ActualizarGasto();
                    CrearHistMedicamento();
                    RecetaData.Actualizar(this);

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

        	/// <summary>
        	/// Elimina un registro existente.
        	/// </summary>
       	 	public void Eliminar(){
				ValidarLogica(TipoOperacion.Borrado);



                //Elimino los gastos que pueda tener asociados a esta receta. (Solo debería existir uno como mucho)
                List<Gasto> lstgastos = Logic.Gasto.Buscar(null, null, null, null, this.Id, null, null, null, null, null, string.Empty, null, null, null,null,null);
                foreach (Gasto item in lstgastos)                
                    item.Eliminar();  
                



            	RecetaData.Eliminar(this);            
        	}
       
			
        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        	public IClaseBase CargarContextoOperacion(TipoContexto Modo){ 
                IClaseBase rtno=null;
			    switch (Modo)
                {
                	case TipoContexto.Insercion:
                    	rtno = new Receta();
	                    break;
    	            case TipoContexto.Modificacion:
        	            rtno = RecetaData.GetRecetaOP(this.Id);
            	        break;               
            	}             
                return rtno;
            	
        	}


            /// <summary>
            /// Obtiene un/una Receta a partir de su id.
            /// </summary>
            /// <param name="id">Id.</param>
            /// <returns>Receta con el id especificado.</returns>
            public static Receta Buscar(int id){
                return RecetaData.GetReceta(id);
            }

           


            /// <summary>
            /// Obtiene los/las Receta que coinciden con los criterios de búsqueda.
            /// </summary>
            /// <param name="nombre">Nombre.</param>  
            /// <param name="provincia">Provincia.</param>
            /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
            public static List<Receta> Buscar(int? idTratamiento, int? idMedicamento, string dosis, int? duracion,decimal? importe,DateTime? fecha)
            {
                return RecetaData.GetRecetas(idTratamiento, idMedicamento, dosis, duracion, importe, fecha);
            }

            /// <summary>
            /// Obtiene todos los registros del tipo Receta
            /// </summary>
            /// <returns>Devuelve todos los registros de la tabla></returns>
            public static List<Receta> Buscar()
            {
                return RecetaData.GetRecetas(null, null, string.Empty, null,null,null);
            }



            #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
        ///// </summary>
        //public string DescProvincia { get { return this.Municipio.Provincia.Descripcion; } }
        //public int Id
        //{
        //    get { return this.IdMedicamento; }
        //    set { }

        //}


        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Medicamento a la que pertenece el elemento
        ///// </summary>
        public string DescMedicamento
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Producto != null)
                    rtno = this.Producto.Descripcion;

                return rtno;
            }
        }


        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Identificacion a la que pertenece el elemento
        ///// </summary>
        public string DescIdentificacion
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Producto != null)
                    rtno = this.Fecha.ToShortDateString() + " - " + this.Producto.Descripcion;

                return rtno;
            }
        }
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.
        public static bool ProductoExistenteEnRecetas(int idProducto)
        {return RecetaData.ProductoExistenteEnRecetas(idProducto);}

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
        /// <summary>
        /// Valida la lógica de negocio, concluye si la operacion es admitida.
        /// </summary>
        /// <param name="operacion">Operación en curso que se debe validar.</param>
        private void ValidarLogica(TipoOperacion operacion)
        {//Añadir código de validación
            //if (operacion == TipoOperacion.Insercion)
            //{
            //    Receta receta = Receta.Buscar(this.Id);
            //    if (receta != null)
            //        throw new LogicException("No es posible insertar el medicamento seleccionado porque ya se encuentra en el tratamiento.");


            //    //validar que no se pueda duplicar la clave
            //}


            //Si el medicamento a insertar tiene supresion de leche o carne, y el número de dias es mayor a los dias
            //en supresion que tiene el tratamiento, debemos actualizar esta cifra
            if (operacion == TipoOperacion.Insercion)
            {
                Producto medicamento = Producto.Buscar(this.IdMedicamento);
                TratEnfermedad tratamiento = TratEnfermedad.Buscar(this.IdTratamiento);
                tratamiento = (TratEnfermedad)tratamiento.CargarContextoOperacion(TipoContexto.Modificacion);

                if (medicamento.SupresionLeche != null)
                {
                    if (tratamiento.SupresionLeche == null)
                        tratamiento.SupresionLeche = medicamento.SupresionLeche;
                    else if (tratamiento.SupresionLeche < medicamento.SupresionLeche)
                        tratamiento.SupresionLeche = medicamento.SupresionLeche;
                }
                if (medicamento.SupresionCarne != null)
                {
                    if (tratamiento.SupresionCarne == null)
                        tratamiento.SupresionCarne = medicamento.SupresionCarne;
                    else if (tratamiento.SupresionCarne < medicamento.SupresionCarne)
                        tratamiento.SupresionCarne = medicamento.SupresionCarne;
                }

            }
        }


        partial void OnDuracionChanged()
        {
            if (this.IdTratamiento != 0)
            {
                TratEnfermedad tratamiento = TratEnfermedad.Buscar(this.IdTratamiento);
                if (tratamiento.Duracion < this.Duracion)
                    throw new LogicException("En una receta no es posible especificar una duración superior a la del tratamiento que la contiene.");



            }

        }

        #endregion


    }
}
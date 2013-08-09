using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Inseminacion : Notificable,IClaseBase,IControlStock,IControlGasto
    {
        
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
                ValidarLogica(TipoOperacion.Insercion);


                //Actualizo el nº de inseminacion
            Animal hembra=Animal.Buscar(this.IdHembra);
            this.Numero=Inseminacion.BuscarInseminacionesLibres(hembra.Id, hembra.UltimaFechaParto_Aborto(hembra.Id)).Count + 1;
            

                InseminacionData.Insertar(this);

                if (IdTipo == Configuracion.TipoInseminacionSistema(Configuracion.TiposInseminacionSistema.INSEMINACIÓN_ARTIFICIAL).Id)
                {                   
                    Movimiento.GenerarMovimiento(TipoOperacion.Insercion, this);                    
                    Logic.Gasto.GenerarGasto(TipoOperacion.Insercion, this);
                    //decimal PVP = ControlStock((decimal)this.Dosis);
                    //ControlGasto(TipoOperacion.Insercion, PVP);
                }

           

        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            
                ValidarLogica(TipoOperacion.Actualizacion);

           
                if (IdTipo == Configuracion.TipoInseminacionSistema(Configuracion.TiposInseminacionSistema.INSEMINACIÓN_ARTIFICIAL).Id)
                {
                    Movimiento.GenerarMovimiento(TipoOperacion.Actualizacion, this);
                    Logic.Gasto.GenerarGasto(TipoOperacion.Actualizacion, this);
                    //decimal PVP = ControlStock((decimal)this.Dosis);
                    //ControlGasto(TipoOperacion.Insercion, PVP);
                }

                InseminacionData.Actualizar(this);
    
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
         

                if (IdTipo == Configuracion.TipoInseminacionSistema(Configuracion.TiposInseminacionSistema.INSEMINACIÓN_ARTIFICIAL).Id)
                {
                    Movimiento.GenerarMovimiento(TipoOperacion.Borrado, this);
                    Logic.Gasto.GenerarGasto(TipoOperacion.Borrado, this);
                    //ControlStock((decimal)this.Dosis * -1);
                    //ControlGasto(TipoOperacion.Borrado, null);
                }

                InseminacionData.Eliminar(this);
               
        }

        //public ResultadoOperacion NotificarMensaje { get; set;}


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
               IClaseBase rtno=null;
               switch (Modo)
               {
                   case TipoContexto.Insercion:
                       rtno = new Inseminacion();
                       break;
                   case TipoContexto.Modificacion:
                       rtno = InseminacionData.GetInseminacionOP(this.Id);
                       break;
               }
               return rtno;
        }


        /// <summary>
        /// Obtiene un/una Inseminacion a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Inseminacion con el id especificado.</returns>
        public static Inseminacion Buscar(int id)
        {
            return InseminacionData.GetInseminacion(id);
        }
        public static Inseminacion BuscarOP(int id)
        {
            return InseminacionData.GetInseminacionOP(id);
        }

        /// <summary>
        /// Obtiene los/las Inseminacion que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Inseminacion> Buscar(int? idMacho, int? idHembra, int? idTipo, int? idVeterinario, 
                                                         int? idEmbrion, int? dosis, DateTime? fecha,Boolean? modificable)
        {
            return InseminacionData.GetInseminaciones(idMacho,idHembra,idTipo,idVeterinario,idEmbrion,dosis,fecha,modificable);
        }

        public static List<Inseminacion> Buscar(int? idHembra, DateTime? fechaInicio,DateTime? fechaFin)
        {
            return InseminacionData.GetInseminaciones(idHembra, fechaInicio,fechaFin);
        }

      

        /// <summary>
        /// Obtiene todos los registros del tipo Inseminacion
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Inseminacion> Buscar()
        {
            return InseminacionData.GetInseminaciones(null,null,null,null,null,null,null,null);
        }

        public static List<Inseminacion> BuscarInseminacionesLibres(int? idHembra,DateTime? fechaMayorDe)
        {
            return InseminacionData.GetInseminacionesLibres(idHembra, fechaMayorDe);
        }




        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        /// <summary>
        /// Propiedad que devuelve la descripción del Tipo de Inseminación.
        /// </summary>
        public string DescTipo { 
            get 
            {
                string rtno = string.Empty;
                if (this !=null && this.TipoInseminacion!=null)
                    rtno = this.TipoInseminacion.Descripcion;
                
                return rtno;
            } 
        }
        /// <summary>
        /// Propiedad que devuelve el nombre del animal Hembra.
        /// </summary>
        public string DescHembra { 
            get 
            {
                string rtno = string.Empty;
                if (this != null && this.Animal1 != null)
                    rtno = this.Animal1.Nombre;

                return rtno;

            }
        }      
        /// <summary>
        /// Propiedad que devuelve el nombre del animal Macho.
        /// </summary>
        public string DescMacho
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Animal2 != null)
                    rtno = this.Animal2.Nombre;

                return rtno;

            }
        }

        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Veterinario a la que pertenece el elemento
        ///// </summary>
        public string DescVeterinario
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Veterinario != null)
                    rtno = this.Veterinario.NombreCompleto;

                return rtno;
            }
        }

        /// <summary>
        /// Días establecidos entre un parto y una nueva inseminación.
        /// </summary>
        //private int PeriodoPostParto = Convert.ToInt32(Configuracion.Parametros["PeriodoInseminacionPostParto"]);


        #endregion

        #region FUNCIONALIDAD AÑADIDA

        /// <summary>
        /// Diagnóstico de gestación asociado a la inseminación.
        /// </summary>
        public DiagInseminacion DiagPositivo
        {
            get
            {
                List<DiagInseminacion> Diagnosticos = new List<DiagInseminacion>();

                List<Inseminacion> Inseminaciones = Animal.Buscar(this.IdHembra).lstInseminaciones.Where(I => I.Numero == this.Numero + 1).ToList();

                if (Inseminaciones.Count == 1)
                    Diagnosticos = DiagInseminacionData.GetDiagInseminaciones(this.IdHembra, this.Fecha, Inseminaciones[0].Fecha, true);
                else
                    Diagnosticos = DiagInseminacionData.GetDiagInseminaciones(this.IdHembra, this.Fecha, null, true);

                if (Diagnosticos.Count == 1)
                    return Diagnosticos[0];
                else
                    return null;
            }
        }
        
        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
        /// <summary>
        /// Valida la lógica de negocio, concluye si la operacion es admitida
        /// </summary>
        /// <param name="eliminar"></param>
        private void ValidarLogica(TipoOperacion operacion)
        {
            Animal hembra = Animal.Buscar(this.IdHembra);

            //Impedimos que se modifiquen o borren todos aquellos registros que no sean el último introducido
            if (operacion == TipoOperacion.Actualizacion || operacion == TipoOperacion.Borrado)
            {
                List<Inseminacion> lstInseminaciones = hembra.lstInseminaciones;
                if (lstInseminaciones != null && lstInseminaciones.Count > 0)
                {
                    Inseminacion UltimaInseminacion = lstInseminaciones.OrderByDescending(E => E.Id).First();
                    if (UltimaInseminacion.Id > this.Id)
                        throw new LogicException("Solo se puede modificar o borrar la última inseminación introducida para el animal: " + hembra.Nombre + " , el resto de las operaciones se encuentran restringidas.");
                }
            }


            if (operacion == TipoOperacion.Insercion || operacion == TipoOperacion.Actualizacion)
            {
                if (Animal.TienePartoPosterior(this.IdHembra, this.Fecha) || Animal.TieneAbortoPosterior(this.IdHembra, this.Fecha))             
                    throw new LogicException ("La hembra: " + hembra.Nombre + " tiene un parto posterior, la inserción o actualización de la inseminación no es posible en esta circunstancia.");
                if ( Animal.TieneAbortoPosterior(this.IdHembra, this.Fecha))
                    throw new LogicException("La hembra: " + hembra.Nombre + " tiene un aborto posterior, la inserción o actualización de la inseminación no es posible en esta circunstancia.");

                        
                // La inseminación no puede efectuarse hasta pasados 25 días (parametrizables) de la fecha de parto.
                Parto ultimoparto = hembra.UltimoParto();
                if (ultimoparto!=null )
                {
                    DateTime FPostParto = ultimoparto.Fecha.AddDays(hembra.PeriodoPostParto);
                    if (this.Fecha < FPostParto)
                        throw new LogicException("La fecha de inseminación para la hembra " + hembra.Nombre + " debe ser superior al " + FPostParto.AddDays(-1).ToShortDateString() + " porque debe ser respetado el período postparto.");                    

                }
                bool cubricionAbierta = false;
                DateTime? FechaUltimaInseCubri = hembra.UltimaFechaInseminacion_Cubricion(this.IdHembra, ref cubricionAbierta);
                if (cubricionAbierta && operacion== TipoOperacion.Insercion)
                    throw new LogicException("La hembra: " + hembra.Nombre + " tiene una cubrición sin fecha fin, no es posible realizar la inseminación.");

                //Comprobar que no introduzco una inseminacion anterior a la ultima fecha de inseminacion o cubricion.
                if (FechaUltimaInseCubri!=null)
                {
                    if ((this.Fecha <= FechaUltimaInseCubri && operacion == TipoOperacion.Insercion))
                        throw new LogicException("La fecha de inseminación para la hembra " + hembra.Nombre + " debe ser superior al " + ((DateTime)FechaUltimaInseCubri).AddDays(1).ToShortDateString() + " porque existen cubriciones o inseminaciones anteriores.");                                           
                }
                
            }
            else if (operacion == TipoOperacion.Borrado)
            {
                //List<DiagInseminacion> lstDiagInseminaciones = this.lstDiagInseminacion;
                //if (lstDiagInseminaciones != null && lstDiagInseminaciones.Count > 0)
                //    throw new LogicException("La inseminación no puede ser borrada porque tiene Diagnósticos.");

                // No se puede borrar inseminaciones de una hembra con partos posteriores.
                if (Animal.TienePartoPosterior(this.IdHembra, this.Fecha))
                    throw new LogicException("No es posible eliminar la Inseminación porque la hembra: " + hembra.Nombre + " tiene un parto posterior.");

                if (Animal.TieneAbortoPosterior(this.IdHembra, this.Fecha))
                    throw new LogicException("No es posible eliminar la Inseminación porque la hembra: " + hembra.Nombre + " tiene un aborto posterior.");

            }

            if (operacion== TipoOperacion.Actualizacion)
            {   //Compruebo que cuando actualizo un registro
                //Si la fecha es inferior a aguna de las otras inseminaciones, cancelo la actualizacion
                //Pq cambiar la fecha en una inseminacion por otra anterior implicaría reenumerarlas (campo nº) y esto esta restringido.
                if (hembra != null)
                {                    
                    List<Inseminacion> lstInseminacionesLibres = Inseminacion.BuscarInseminacionesLibres(hembra.Id, hembra.UltimaFechaParto_Aborto(hembra.Id));
                    if (lstInseminacionesLibres.Where(E => E.Fecha >= this.Fecha & E.Id != this.Id).Count() > 0)
                        throw new LogicException("No es posible asignar la fecha: " + this.Fecha.ToShortDateString() + " a la inseminación para la hembra: " + hembra.Nombre + " porque ya tiene inseminaciones con fechas iguales o posteriores.");
                }
            }
          
        }

        partial void OnIdHembraChanged()
        {//Comprobar la condicion corporal en la inseminacion

            Animal hembra = Animal.Buscar(this.IdHembra);
            List<CondicionCorporal> lstCondCorp = hembra.lstCondicionesCorporales;
            if (lstCondCorp!=null && lstCondCorp.Count>0)
            {
                CondicionCorporal UltimaCondCorp = lstCondCorp.OrderByDescending(E => E.Fecha).First();
                TipoCondicion tipoCondCorp = TipoCondicion.Buscar(UltimaCondCorp.IdTipo);
                if (!tipoCondCorp.Apta)
                    throw new LogicException ("La hembra: " + hembra.Nombre + " no tiene una condición corporal apta para ser inseminada");                                  
                

            }

            
        }

        //private int? IdTipoAnterior = null;

        /// <summary>
        /// Controla en cambio de tipo para las tareas con stock y gasto asociado.
        /// </summary>
        partial void OnIdTipoChanging(int value)
        {
            //TipoAnterior = this.IdTipo;
            if (this.IdTipo!=0)
             throw new LogicException("No es posible modificar el Tipo de Insemianción una vez creado el registro."); 
        }

        //private int? HembraAnterior = null;

        ///// <summary>
        ///// Controla en cambio de hembra para las tareas con stock y gasto asociado.
        ///// </summary>
        //partial void OnIdHembraChanging(int value)
        //{
        //    HembraAnterior = this.IdHembra;
        //}

        //private DateTime? FechaAnterior = null;

        ///// <summary>
        ///// Controla en cambio de fecha para las tareas con stock y gasto asociado.
        ///// </summary>
        //partial void OnFechaChanging(DateTime value)
        //{
        //    FechaAnterior = this.Fecha;
        //}

        //private int? DosisAnterior = null;

        ///// <summary>
        ///// Controla en cambio de dosis para las tareas con stock y gasto asociado.
        ///// </summary>
        //partial void OnDosisChanging(int? value)
        //{
        //    DosisAnterior = this.Dosis;
        //}

        //public decimal ControlStock(decimal cantidad)
        //{
            
        //    decimal PVP = decimal.Zero;
        //    //Stock stockMacho = null;
        //    //List<Stock> lststock = Stock.Buscar(null, null, this.IdMacho, null);

        //    //if (lststock != null && lststock.Count() > 0)
        //    //    stockMacho = lststock.OrderByDescending(E => E.Fecha).First();

        //    //try
        //    //{
        //    //    if (stockMacho != null)
        //    //    {
        //    //        stockMacho = (Stock)stockMacho.CargarContextoOperacion(TipoContexto.Modificacion);

        //    //        if (stockMacho.Cantidad >= cantidad)
        //    //        {
        //    //            PVP = stockMacho.Precio;

        //    //            stockMacho.Cantidad -= cantidad;
        //    //            stockMacho.Actualizar();
        //    //        }
        //    //        else
        //    //            throw new LogicException("No hay suficiente stock para realizar esa operación, quedan: " + stockMacho.Cantidad.ToString());
        //    //    }
        //    //    else
        //    //        throw new LogicException("No hay stock de semen del macho activo");
        //    //}
        //    //finally
        //    //{
        //    //    stockMacho = null;
        //    //}

        //    return PVP;
        //}

        ///// <summary>
        ///// Controla el gasto producido por la inseminación.
        ///// </summary>
        ///// <param name="operacion">Operación realizada con la inseminación.</param>
        ///// <param name="importe">Importe del gasto asociado.</param>
        //private void ControlGasto(TipoOperacion operacion, decimal? importe)
        //{
        //    switch (operacion)
        //    {
        //        case TipoOperacion.Insercion:
        //            new Gasto
        //            {
        //                IdExplotacion = Configuracion.Explotacion.Id,
        //                IdNaturaleza = Configuracion.NaturalezaGastoSistema(Configuracion.NaturalezasGastosSistema.INSEMINACION).Id,
        //                IdAnimal = this.IdHembra,
        //                Fecha = this.Fecha,
        //                Importe = importe.Value * this.Dosis.Value

        //            }.Insertar();

        //            break;
        //        case TipoOperacion.Borrado:
        //            Gasto.Buscar(Configuracion.NaturalezaGastoSistema(Configuracion.NaturalezasGastosSistema.INSEMINACION).Id,
        //                Configuracion.Explotacion.Id, HembraAnterior ?? this.IdHembra, null, null, null, null, null, null, null, string.Empty, FechaAnterior ?? this.Fecha, FechaAnterior ?? this.Fecha, null,null)[0].Eliminar();

        //            break;
        //        case TipoOperacion.Actualizacion:
        //            int Artificial = Configuracion.TipoInseminacionSistema(Configuracion.TiposInseminacionSistema.INSEMINACIÓN_ARTIFICIAL).Id;

        //            if (TipoAnterior != null && TipoAnterior.Value == Artificial && this.IdTipo != Artificial)
        //                ControlGasto(TipoOperacion.Borrado, importe);
        //            else if (TipoAnterior != null && TipoAnterior.Value != Artificial && this.IdTipo == Artificial)
        //                ControlGasto(TipoOperacion.Insercion, importe);
        //            else if (TipoAnterior == null && this.IdTipo == Artificial)
        //            {
        //                Gasto G = Gasto.Buscar(Configuracion.NaturalezaGastoSistema(Configuracion.NaturalezasGastosSistema.INSEMINACION).Id,
        //                    Configuracion.Explotacion.Id, HembraAnterior ?? this.IdHembra, null, null, null, null, null, null, null, string.Empty, FechaAnterior ?? this.Fecha, FechaAnterior ?? this.Fecha, null,null)[0];

        //                G.IdAnimal = this.IdHembra;
        //                G.Fecha = this.Fecha;
        //                G.Importe = importe.Value * this.Dosis.Value;

        //                G.Actualizar();
        //            }

        //            break;
        //    }
        //}


        partial void OnFechaChanged()
        {
            if (Fecha.Date > DateTime.Today && !Configuracion.PermitirRegistrosFuturos)            
                throw new LogicException("No esta permitido establecer una fecha de inseminación posterior a la fecha del sistema.");                
            
        }

        #endregion

        #region CONTROL DE STOCK
            //Preservar los valores anteriores
            public int? DosisAnterior { get; set; }            
            partial void OnDosisChanging(int? value) { DosisAnterior = this.Dosis; }
            public int? IdMachoAnterior { get; set; }
            partial void OnIdMachoChanging(int value) { IdMachoAnterior = this.IdMacho; }
            public int? IdHembraAnterior { get; set; }
            partial void OnIdHembraChanging(int value) { IdHembraAnterior = this.IdHembra; }       
            public DateTime? FechaAnterior { get; set; }
            partial void OnFechaChanging(DateTime value) { FechaAnterior = this.Fecha; }


            /// <summary>
            /// Convierto la clase actual a partir de sus valores actuales en clases del tipo 'MovimientoDefinicion'
            /// susceptibles de crear stock.
            /// Esta conversión se lleva a cabo en Movimiento.GenerarMovimiento(TipoOperacion operacion,object clase) 
            /// que es llamada cada vez que se confirma una operación en clase que implementa la interface IControlStock.
            /// Nota: NO se debe llamar esplicitamente a este método.
            /// </summary>
            /// <param name="operacion"></param>
            /// <returns></returns>
            public List<MovimientoDefinicion> ToMovimiento(TipoOperacion operacion)
            {
                List<MovimientoDefinicion> lstMovimientos = new List<MovimientoDefinicion>();

                MovimientoDefinicion movimiento = new MovimientoDefinicion();
                movimiento.Operacion = operacion;

                if (this.Dosis == null)//No tiene sentido llevar el stock sin dosis                
                  throw new LogicException("La Inseminación proporcionada no tiene un valor de dosis válido para gestionar el stock.");



                movimiento.Identificacion = this.Id.ToString();
                movimiento.Tipo = TiposMovimientos.INSEMINACION;
                movimiento.IdMacho = this.IdMacho;
                movimiento.Cantidad = (int)this.Dosis;
                movimiento.FechaEfecto = this.Fecha;
                movimiento.IdProducto = Configuracion.ProductoSistema(Configuracion.ProductosSistema.PAJUELA_PROPIA).Id;


                if (operacion == TipoOperacion.Insercion || operacion == TipoOperacion.Actualizacion)
                    movimiento.Cantidad *= -1;//Cambio de signo a la cantidad ya que las inserciones y actualizaciones de la tabla Simbra restan stock.

                //Establecer valores a las variables con sufijo _Anterior (cambiantes)
                if (operacion == TipoOperacion.Actualizacion)
                {
                    movimiento.IdProductoAnterior = Configuracion.ProductoSistema(Configuracion.ProductosSistema.PAJUELA_PROPIA).Id;
                    movimiento.IdMachoAnterior = this.IdMachoAnterior ?? this.IdMacho;
                    movimiento.CantidadAnterior = this.DosisAnterior ?? (int)this.Dosis;
                    movimiento.FechaEfectoAnterior = this.FechaAnterior ?? this.Fecha;
                }


                lstMovimientos.Add(movimiento);
                return lstMovimientos;
            }

        #endregion

        #region CONTROL DE GASTOS
            /// <summary>
            /// Convierto la clase actual a partir de sus valores actuales en una clase del tipo 'GastoDefinicion'
            /// Esta conversión se lleva a cabo en Gasto.GenerarGasto(TipoOperacion,objecto clase)
            /// que es llamada cada vez que se confirma una operación en clase que implementa la interface IControlGasto.
            /// Nota: NO se debe llamar esplicitamente a este método.
            /// </summary>
            /// <param name="operacion"></param>
            /// <returns></returns>
            public GastoDefinicion ToGasto(TipoOperacion operacion)
            {   //Cargar la lista de gastos y asignar la variable GastoActual
                GastoDefinicion gasto = new GastoDefinicion();

                if (this.Dosis == null)//Si la inseminación no tiene valorada la dosis no tiene sentido asignar el gasto.                
                    throw new LogicException("La inseminación no tiene valorada la dosis, no tiene sentido asignar el gasto");

                if (operacion == TipoOperacion.Actualizacion || operacion == TipoOperacion.Borrado)
                {
                    gasto.lstGastos = Logic.Gasto.Buscar(null, null, null, null, null, null, null, null, null, null, string.Empty, null, null, null, null, this.Id);
                    if (gasto.lstGastos != null && gasto.lstGastos.Count > 0)
                        gasto.GastoActual = gasto.lstGastos.First();

                }

                if (operacion == TipoOperacion.Insercion || operacion == TipoOperacion.Actualizacion)
                {
                    gasto.IdNaturaleza = Configuracion.NaturalezaGastoSistema(Configuracion.NaturalezasGastosSistema.INSEMINACION).Id;
                    gasto.IdAnimal = this.IdHembra;
                    gasto.IdMacho = this.IdMacho;
                    gasto.IdProducto = Configuracion.ProductoSistema(Configuracion.ProductosSistema.PAJUELA_PROPIA).Id;
                    gasto.Fecha = this.Fecha;
                    gasto.IdInseminacion = this.Id;

                    //Valores para el correcto cálculo del importe                  
                    gasto.Cantidad = Convert.ToDecimal((int)this.Dosis);
                }
                if (operacion == TipoOperacion.Actualizacion)
                {
                    gasto.IdProductoAnterior = Configuracion.ProductoSistema(Configuracion.ProductosSistema.PAJUELA_PROPIA).Id;
                    gasto.IdMachoAnterior = this.IdMachoAnterior;
                    gasto.IdAnimalAnterior = this.IdHembraAnterior;
                    if (this.DosisAnterior != null)
                        gasto.CantidadAnterior = Convert.ToDecimal((int)this.DosisAnterior);
                }



                return gasto;
            }
        #endregion
    }
}
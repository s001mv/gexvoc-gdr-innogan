using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;


namespace GEXVOC.UI
{
    public partial class EditInseminacion : GEXVOC.UI.GenericEdit
    {
        int DosisIniciales = 0;

        #region CONSTRUCTOR E INICIALIZACIONES REQUERIDAS
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public EditInseminacion()
        {
            InitializeComponent();
        }

       /// <summary>
       /// Sobrecarga del Constructor que nos permite inicializar un formulario 
       /// GenericEdit con los datos propios del formulario.
       /// </summary>
       /// <param name="modo">Modo de Apertura del Formulario Edit</param>
       /// <param name="ClaseBase">Clase Base sobre la que actúa el formulario Edit.</param>
        public EditInseminacion(Modo modo, Inseminacion ClaseBase):base (modo, ClaseBase)
        {
            InitializeComponent();
           

        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        

        public Inseminacion ObjetoBase { get { return (Inseminacion)this.ClaseBase; } }

        int? _ValorFijoIdHembra = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe aparecer con el combo de la hembra fijo y con el animal que corresponde 
        /// con el Id especificado aqui.
        /// </summary>
        public int? ValorFijoIdHembra
        {
            get { return _ValorFijoIdHembra; }
            set
            {
                if (value != null)
                {
                    this.cmbHembra.ClaseActiva = Animal.Buscar((int)value);
                    this.cmbHembra.ReadOnly = true;                    
                }
                else
                    this.cmbHembra.ReadOnly = false;

                _ValorFijoIdHembra = value;
            }
        }
        int? _ValorFijoIdMacho = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe aparecer con el combo de la hembra fijo y con el animal que corresponde 
        /// con el Id especificado aqui.
        /// </summary>
        public int? ValorFijoIdMacho
        {
            get { return _ValorFijoIdMacho; }
            set
            {
                

                _ValorFijoIdMacho = value;
            }
        }

        #endregion

        #region FUNCIONES SOBREESCRITAS
        protected override void Guardar()
        {
            if (ModoActual == Modo.GuardarMultiple)
            {
                if (ValidarControles())
                {
                    IniciarContextoOperacion();

                    string mensajeError = string.Empty;
                    this.MensajeNotificarVarios = string.Empty;
                    int OperacionesCorrectas = 0;
                    int OperacionesIncorrectas = 0;
                    foreach (Animal item in cmbHembra.Items)
                    {
                        try
                        {

                            Inseminacion inseminacion = new Inseminacion();
                            try
                            {
                                inseminacion.IdHembra = item.Id;
                            }
                            catch (LogicException lgex)
                            {
                                DialogResult rdo = MessageBox.Show(lgex.Message +
                                                  "\r¿Desea insertar la inseminación a pesar de las advertencias?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                
                                if (rdo != DialogResult.Yes)
                                    throw;
                                
                            }                         

                      

                            //DiagInseminacion Obj = ProcesarDiagInseminacion();  //Ya tengo el objeto DiagInseminacion creado o actualizado.

                            Generic.ControlAClaseBase(inseminacion, "IdTipo", cmbTipo);                     
                            Generic.ControlAClaseBase(inseminacion, "IdMacho", cmbMacho);
                            Generic.ControlAClaseBase(inseminacion, "IdVeterinario", cmbPersonal);
                            Generic.ControlAClaseBase(inseminacion, "IdEmbrion", cmbEmbrion);
                            Generic.ControlAClaseBase(inseminacion, "Fecha", txtFecha);
                            Generic.ControlAClaseBase(inseminacion, "Dosis", txtDosis);

                            //this.ObjetoBase.IdDiagnostico = Obj.Id;

                            if (inseminacion.GetType().GetInterface(typeof(INotificable).Name) != null)
                                ((INotificable)inseminacion).Notificar += new EventHandler<NotificableEventArgs>(this.NotificarVarios); 

                            inseminacion.Insertar();
                            OperacionesCorrectas += 1;
                        }
                        catch (Exception ex)
                        {
                            OperacionesIncorrectas += 1;
                            mensajeError += ex.Message + "\r";

                        }

                    }
                    FinalizarContextoOperacion();

                    if (!string.IsNullOrEmpty(MensajeNotificarVarios))//Si se han producido notificaciones de una clase del tipo INotificable, las muestro                        
                        Principal.Mostrar_Mensaje(this.MensajeNotificarVarios);

                    if (mensajeError != string.Empty)
                    {
                        Generic.AvisoAdvertencia("Se han producido errores en un total de (" + ((int)OperacionesCorrectas + OperacionesIncorrectas) + ") Operaciones => " +
                                                "(" + OperacionesCorrectas + ") Correctas y (" + OperacionesIncorrectas + ") Incorrectas.\r" +
                                                "Resumen e Información adicional: \r" +
                                                  mensajeError);
                        
                    }
                    
                    this.Close();


                }
            }
            else
            {
                base.Guardar();
            }






            //base.Guardar();
        }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)



        protected override void ClaseBaseAControles()
        {

            ////Datos de Diagnostico
            //DiagInseminacion Obj = DiagInseminacion.Buscar(this.ObjetoBase.IdDiagnostico);            
            //chkResultado.Checked = Obj.Resultado;
            //this.cmbTipoDiagnostico.SelectedValue = Obj.IdTipo;
            //Generic.DatetimeAControl(txtFechaDiagnostico, Obj.Fecha);


            //Datos de Inseminación
            
            cmbTipo.Enabled = false;//No permito cambiar el combo tipo en una inseminacion creada.
            
            cmbTipo.SelectedValue = this.ObjetoBase.IdTipo;              
            cmbHembra.ClaseActiva = Animal.Buscar(this.ObjetoBase.IdHembra);
            this.ClaseBaseAcontrol(this.ObjetoBase, "IdMacho", cmbMacho);
            //cmbMacho.ClaseActiva = Animal.Buscar(this.ObjetoBase.IdMacho);
            if (this.ObjetoBase.IdEmbrion!=null)
                cmbEmbrion.ClaseActiva = Animal.Buscar((int)this.ObjetoBase.IdEmbrion);
            if (this.ObjetoBase.Dosis != null)
            {
                txtDosis.Text = this.ObjetoBase.Dosis.ToString();
                DosisIniciales = this.ObjetoBase.Dosis.Value;
            }
            
            cmbPersonal.ClaseActiva = Veterinario.Buscar(this.ObjetoBase.IdVeterinario);
            Generic.DatetimeAControl(txtFecha, this.ObjetoBase.Fecha);

                    

        }

        protected override void ControlesAClaseBase()
        {

            //DiagInseminacion Obj = ProcesarDiagInseminacion();  //Ya tengo el objeto DiagInseminacion creado o actualizado.

            ControlAClaseBase(ObjetoBase, "IdTipo", cmbTipo);          

            ControlAClaseBase(ObjetoBase, "IdMacho", cmbMacho);
            ControlAClaseBase(ObjetoBase, "IdVeterinario", cmbPersonal);
            ControlAClaseBase(ObjetoBase, "IdEmbrion", cmbEmbrion);
            ControlAClaseBase(ObjetoBase, "Fecha", txtFecha);
            ControlAClaseBase(ObjetoBase, "Dosis", txtDosis);

        
            try
            {
                this.ObjetoBase.IdHembra = cmbHembra.IdClaseActiva;
            }
            catch (LogicException le)
            {
                DialogResult rdo = MessageBox.Show(le.Message +
                                  "\r¿Desea insertar la inseminación a pesar de las advertencias?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rdo != DialogResult.Yes)
                {
                    cmbHembra.Focus();
                    throw new LogicException("No se ha insertado la inseminación porque la hembra no cumple con los requisitos apropiados");
                }
            }
           

            //Generic.ControlAClaseBase(ObjetoBase, "IdHembra", cmbHembra);

            //this.ObjetoBase.IdDiagnostico = Obj.Id;
        }

        
        /////// <summary>
        /////// Crea o actualiza el diaginseminacion de la inseminacion en curso (se utiliza en ControlesAClaseBase)
        /////// para asegurarnos de tener un elemento diaginseminacion válido y actualizado antes de terminar la actualizacion de la inseminacion.
        /////// </summary>
        /////// <returns></returns>
        ////private DiagInseminacion ProcesarDiagInseminacion()
        ////{
        ////    DiagInseminacion Obj = null;
        ////    //Primero tengo que crear el DiagInseminacion 
        ////    //para poder asignarselo a la inseminacion
        ////    if (this.ModoActual == Modo.Guardar)
        ////        Obj = new DiagInseminacion();
        ////    if (this.ModoActual == Modo.Actualizar)
        ////        Obj = DiagInseminacion.BuscarOP(this.ObjetoBase.IdDiagnostico);
            

        ////    //Binding///
        ////    Obj.Resultado = chkResultado.Checked;
        ////    if (chkResultado.Checked)            
        ////        Obj.IdTipo = Generic.ControlAInt(cmbTipoDiagnostico);
        ////    else
        ////        Obj.IdTipo = 0;//La logica se encargara de poner el valor por defecto
            
        ////    Obj.Fecha = Generic.ControlADatetime(this.txtFechaDiagnostico);


        ////    if (this.ModoActual == Modo.Guardar)
        ////        Obj.Insertar();            
        ////    if (this.ModoActual == Modo.Actualizar)
        ////        Obj.Actualizar();
            


        ////    return Obj;
        ////}
        /// <summary>
        /// Validación de los Controles, se produce antes de actualizar la ClaseBase.
        /// </summary>
        /// <returns>Controles válidos (Si/No)</returns>
        protected override bool Validar()
        {
            bool Rtno = true;
            //this.ErrorProvider.Clear();
            if (cmbHembra.DataSource == null && cmbHembra.ClaseActiva==null)
            {
                Generic.PonerError(this.ErrorProvider, cmbHembra, "Es necesario que existan animales en selección");
                Rtno = false;
            }

            if (!Generic.ControlValorado(new Control[] {txtFecha,cmbPersonal,cmbMacho, cmbTipo },  this.ErrorProvider))
                Rtno = false;


            if (!Generic.ControlDatosCorrectos(this.txtFecha,  this.ErrorProvider,  typeof(System.DateTime), true))
                Rtno = false;
       
            if (cmbTipo.SelectedValue!=null)
            {
                if ((int)cmbTipo.SelectedValue==Configuracion.TipoInseminacionSistema(Configuracion.TiposInseminacionSistema.INSEMINACIÓN_ARTIFICIAL).Id)                
                    if (!Generic.ControlDatosCorrectos(this.txtDosis, this.ErrorProvider, typeof(int), true)) Rtno = false;

                if ((int)cmbTipo.SelectedValue == Configuracion.TipoInseminacionSistema(Configuracion.TiposInseminacionSistema.TRANSPLANTE_EMBRIONARIO).Id)
                    if (!Generic.ControlValorado(this.cmbEmbrion, this.ErrorProvider)) Rtno = false;
    
                
            }

          

            return Rtno;

        }



        #endregion
                
        #region CARGAS COMUNES

            protected override void CargarCombos()
            {
                this.CargarCombo(cmbTipo, TipoInseminacion.Buscar());
                this.CargarCombo(cmbMacho, "Nombre", Animal.Buscar(null, null, null, null, null, null, null, null, null, null, null, char.Parse("M"), null, null, null, null, null));
            }
            protected override void CargarValoresDefecto()
            {
                Generic.DatetimeAControl(this.txtFecha, DateTime.Now.Date);
                if (this.ValorFijoIdMacho!=null)
                {
                    this.cmbMacho.SelectedValue = this.ValorFijoIdMacho;
                    this.cmbMacho.Enabled = false;
                }                    
                else
                    this.cmbMacho.Enabled = true;

                

               // Generic.DatetimeAControl(this.txtFechaDiagnostico, DateTime.Now.Date);

                //if (this.ObjetoBase.IdHembra > 0)//Si lanzamos el formulario con una hembra en concreto (por ejemplo desde el grid inseminaciones
                ////de una vaca concreta), seleccionamos esa hembra e impedimos que se cambie el valor
                //{
                //    this.cmbHembra.ClaseActiva = Animal.Buscar(this.ObjetoBase.IdHembra);
                //    btnBuscarHembra.Enabled = false;
                //}


            }
            //protected override void CargarGrids()
            //{
            //    this.dtgDiagInseminacion.DataSource = this.ObjetoBase.lstDiagInseminacion;
            //    base.CargarGrids();
            //}
        #endregion

        //#region GRID - DIAGNÓSTICO
        //    private void ModificarDiagnosticoInseminacion()
        //    {

        //        if (this.dtgDiagInseminacion.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
        //        {

        //            DiagInseminacion ObjActualizar = (DiagInseminacion)this.dtgDiagInseminacion.CurrentRow.DataBoundItem;
        //            this.LanzarFormulario(new EditDiagInseminacion(Modo.Actualizar, ObjActualizar) { ValorFijoIdInseminacion = this.ObjetoBase.Id }, this.dtgDiagInseminacion);

        //        }
        //    }

        //    private void tsbNuevoDiagnostico_Click(object sender, EventArgs e)
        //    {
        //        if (ModoActual == Modo.Actualizar)
        //        {
        //            DiagInseminacion ObjCrear = new DiagInseminacion();
        //            this.LanzarFormulario(new EditDiagInseminacion(Modo.Guardar, ObjCrear) { ValorFijoIdInseminacion = this.ObjetoBase.Id }, dtgDiagInseminacion);

        //        }
        //    }
        //    private void tsbModificarDiagnostico_Click(object sender, EventArgs e)
        //    {
        //        ModificarDiagnosticoInseminacion();
        //    }
        //    private void tsbEliminarDiagnostico_Click(object sender, EventArgs e)
        //    {
        //        this.EliminarObjGrid(this.dtgDiagInseminacion, "Va a eliminar los diagnosticos.\r¿Esta usted seguro de que desea continuar?");
        //    }
        //    private void dtgDiagInseminacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //    {
        //        ModificarDiagnosticoInseminacion();
        //    }            
        //#endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarHembra_Click(object sender, EventArgs e)
            {

                //this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbHembra) { ValorSexoFijo = Convert.ToChar("H") });

                if (ModoActual == Modo.GuardarMultiple)
                {
                    SelectorAnimales frmSelectorAnimales = new SelectorAnimales(Modo.Consultar, (List<Animal>)this.cmbHembra.DataSource, Convert.ToChar("H"));
                    this.LanzarFormulario(frmSelectorAnimales);


                    if (frmSelectorAnimales.LstAnimalesSeleccionadosRtno != null)
                    {
                        this.cmbHembra.DataSource = frmSelectorAnimales.LstAnimalesSeleccionadosRtno;
                        this.cmbHembra.Text = "(" + frmSelectorAnimales.LstAnimalesSeleccionadosRtno.Count + ") Elementos en selección";
                    }

                }
                else
                    this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbHembra) { ValorSexoFijo = Convert.ToChar("H") });





            }

            private void btnBuscarEmbrion_Click(object sender, EventArgs e)
            {

                this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbEmbrion) { ValorSexoFijo = Convert.ToChar("H") });
            }

            private void btnBuscarPersonal_Click(object sender, EventArgs e)
            {


                this.LanzarFormularioConsulta(new FindPersonal(Modo.Consultar, this.cmbPersonal));

            }

            private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
            {


                if (cmbTipo.SelectedValue != null)
                {
                    int TipoInseminacion = (int)cmbTipo.SelectedValue;

                    if (TipoInseminacion == Configuracion.TipoInseminacionSistema(Configuracion.TiposInseminacionSistema.TRANSPLANTE_EMBRIONARIO).Id)// == "Transplante embrionario")
                        pnlEmbrion.Enabled = true;
                    else
                    {
                        cmbEmbrion.Tag = null;
                        cmbEmbrion.Text = "";
                        pnlEmbrion.Enabled = false;
                    }
                    if (TipoInseminacion == Configuracion.TipoInseminacionSistema(Configuracion.TiposInseminacionSistema.INSEMINACIÓN_ARTIFICIAL).Id)//(cmbTipo.Text == "Inseminación Artificial")
                        pnlArtificial.Enabled = true;

                    else
                    {
                        txtDosis.Text = "";
                        pnlArtificial.Enabled = false;
                    }

                }



            }
        
        #endregion

            


       

  

        

        
       
        
    }
}

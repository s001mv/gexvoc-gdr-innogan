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
    public partial class EditSincronizacionCelo : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditSincronizacionCelo()
        {
            InitializeComponent();
        }
        public EditSincronizacionCelo(Modo modo, SincronizacionCelo ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }

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
        #endregion


        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public SincronizacionCelo ObjetoBase { get { return (SincronizacionCelo)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

        protected override void ClaseBaseAControles()
        {
            if (_ValorFijoIdHembra == null)
                this.cmbHembra.ClaseActiva = Animal.Buscar(this.ObjetoBase.IdHembra);
            if (this.ObjetoBase.IdVeterinario!=null)
                this.cmbPersonal.ClaseActiva = Veterinario.Buscar((int)this.ObjetoBase.IdVeterinario);

            


            if (this.ObjetoBase.FechaColocacion!=null)            
                TipoSincronizacion = TiposSincronizaciones.Esponja;
            if (this.ObjetoBase.FechaInyeccion != null)
                TipoSincronizacion = TiposSincronizaciones.Inyeccion;

            
            ClaseBaseAcontrol(this.ObjetoBase, "FechaColocacion", txtFechaColocacion);
            ClaseBaseAcontrol(this.ObjetoBase, "FechaInyeccion", txtFechaInyeccion);
            ClaseBaseAcontrol(this.ObjetoBase, "FechaPrevision", txtFechaPrevision);
            ClaseBaseAcontrol(this.ObjetoBase, "FechaRetirada", txtFechaRetirada);


        }

        protected override void ControlesAClaseBase()
        {

            ControlAClaseBase(this.ObjetoBase, "IdHembra", cmbHembra);
            ControlAClaseBase(this.ObjetoBase, "IdVeterinario", cmbPersonal);

            if (TipoSincronizacion== TiposSincronizaciones.Esponja)//Paso a la clase los valores referentes al tipo de sincronizacion "esponja"
            {
                ControlAClaseBase(this.ObjetoBase, "FechaColocacion", txtFechaColocacion);
                ControlAClaseBase(this.ObjetoBase, "FechaRetirada", txtFechaRetirada);
                this.ObjetoBase.FechaInyeccion = null;
            }
            if (TipoSincronizacion == TiposSincronizaciones.Inyeccion)//Paso a la clase los valores referentes al tipo de sincronizacion "Inyección"
            {
                ControlAClaseBase(this.ObjetoBase, "FechaInyeccion", txtFechaInyeccion);
                this.ObjetoBase.FechaColocacion = null;
                this.ObjetoBase.FechaRetirada = null;

            }

            ControlAClaseBase(this.ObjetoBase, "FechaPrevision", txtFechaPrevision);
            

        }



        ///// <summary>
        ///// Validación de los Controles, se produce antes de actualizar la ClaseBase.
        ///// </summary>
        ///// <returns>Controles válidos (Si/No)</returns>
        protected override bool Validar()
        {
            bool Rtno = true;
            this.ErrorProvider.Clear();
          
            if (!Generic.ControlValorado(new Control[] { cmbHembra,cmbPersonal }, this.ErrorProvider))
                Rtno = false;

          
          
            if (!Generic.ControlDatosCorrectos(txtFechaPrevision, this.ErrorProvider, typeof(DateTime), false)) Rtno = false;


            //Una de las fechas colocacion o inyeccion debe estar valorada.

            if (TipoSincronizacion == TiposSincronizaciones.Inyeccion)
            {
                if (!Generic.ControlDatosCorrectos(txtFechaInyeccion, this.ErrorProvider, typeof(DateTime), true)) Rtno = false;                
                
            }

            if (TipoSincronizacion == TiposSincronizaciones.Esponja)
            {
                if (!Generic.ControlDatosCorrectos(txtFechaColocacion, this.ErrorProvider, typeof(DateTime), true)) Rtno = false;
                if (!Generic.ControlDatosCorrectos(txtFechaRetirada, this.ErrorProvider, typeof(DateTime), false)) Rtno = false;               
            }
            


            return Rtno;

        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            if (ModoActual==Modo.GuardarMultiple)
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

      


        /// <summary>
        /// Se ha tenido que sobreescribir guardar, para dar la funcionalidad de inserción en lotes    
        /// </summary>
        protected override void Guardar()
        {
            if (ModoActual == Modo.GuardarMultiple)
            {
                if (ValidarControles())
                {
                    IniciarContextoOperacion();

                    string mensajeError = string.Empty;
                    int OperacionesCorrectas = 0;
                    int OperacionesIncorrectas = 0;

                    foreach (Animal item in cmbHembra.Items)
                    {
                        try
                        {

                            SincronizacionCelo sincronizacion = new SincronizacionCelo();
                            sincronizacion.IdHembra = item.Id;

                            if (TipoSincronizacion == TiposSincronizaciones.Esponja)
                            {                             
                                Generic.ControlAClaseBase(sincronizacion, "FechaColocacion", txtFechaColocacion);                            
                                Generic.ControlAClaseBase(sincronizacion, "FechaRetirada", txtFechaRetirada);
                                sincronizacion.FechaInyeccion = null;
                            }
                            if (TipoSincronizacion == TiposSincronizaciones.Inyeccion)
                            {  
                                Generic.ControlAClaseBase(sincronizacion, "FechaInyeccion", txtFechaInyeccion);
                                sincronizacion.FechaColocacion = null;
                                sincronizacion.FechaRetirada = null;
                            }
                            
                          
                            Generic.ControlAClaseBase(sincronizacion, "FechaPrevision", txtFechaPrevision);
                            

                            sincronizacion.IdVeterinario = cmbPersonal.IdClaseActiva;

                            sincronizacion.Insertar();
                            OperacionesCorrectas += 1;
                        }
                        catch (Exception ex)
                        {
                            OperacionesIncorrectas += 1;
                            mensajeError += ex.Message + "\r";

                        }

                    }
                    FinalizarContextoOperacion();

                    if (mensajeError != string.Empty)
                        Generic.AvisoAdvertencia("Se han producido errores en un total de (" + ((int)OperacionesCorrectas + OperacionesIncorrectas) + ") Operaciones => " +
                                                "(" + OperacionesCorrectas + ") Correctas y (" + OperacionesIncorrectas + ") Incorrectas.\r" +
                                                "Resumen e Información adicional: \r" +
                                                  mensajeError);

                    this.Close();

                }
            }
            else
            {
                base.Guardar();
            }


            //base.Guardar();
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEsponja.Checked)
                TipoSincronizacion = TiposSincronizaciones.Esponja;
            else
                TipoSincronizacion = TiposSincronizaciones.Inyeccion;

        }

        public enum TiposSincronizaciones {Inyeccion,Esponja}

        private TiposSincronizaciones _TipoSincronizacion;

        public TiposSincronizaciones TipoSincronizacion
        {
            get { return _TipoSincronizacion; }
            set {
                
                switch (value)
                {
                    case TiposSincronizaciones.Inyeccion:
                        if (!rdbInyeccion.Checked)
                            rdbInyeccion.Checked = true;
                        
                        pnlInjeccion.Visible = true;
                        pnlInjeccion.Enabled = true;
                        pnlEsponja.Visible = false;
                        pnlEsponja.Enabled = false;


                        txtFechaInyeccion.Focus();                                    
                        break;
                    case TiposSincronizaciones.Esponja:
                        if (!rdbEsponja.Checked)
                            rdbEsponja.Checked = true;

                        pnlInjeccion.Visible = false;
                        pnlInjeccion.Enabled = false;
                        pnlEsponja.Visible = true;
                        pnlEsponja.Enabled = true;

                        txtFechaColocacion.Focus();
                        break;
                    
                }
                _TipoSincronizacion = value; 
            }
        }

        private void EditSincronizacionCelo_Load(object sender, EventArgs e)
        {
            if (ModoActual==Modo.Guardar || ModoActual== Modo.GuardarMultiple)
            {//Valor por defecto para la propiedad TipoSincronizacion.
                TipoSincronizacion = TiposSincronizaciones.Esponja;
            }
        }

        private void btnBuscarPersonal_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindPersonal(Modo.Consultar, this.cmbPersonal));
        }     

    }
}
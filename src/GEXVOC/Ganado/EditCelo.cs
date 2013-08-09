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
    public partial class EditCelo : GEXVOC.UI.GenericEdit
    {

        #region CONTRUCTORES
        public EditCelo()
        {
            InitializeComponent();
        }
        public EditCelo(Modo modo, Celo ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Celo ObjetoBase { get { return (Celo)this.ClaseBase; } }

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

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

        protected override void ClaseBaseAControles()
        {
            if (_ValorFijoIdHembra == null)
                this.cmbHembra.ClaseActiva = Animal.Buscar(this.ObjetoBase.IdHembra);

            if (this.ObjetoBase.IdVeterinario!=null)            
                this.cmbPersonal.ClaseActiva = Veterinario.Buscar((int)this.ObjetoBase.IdVeterinario);

            DateTime fecha = this.ObjetoBase.Fecha;
            txtFecha.Text = fecha.ToShortDateString();
            txtHora.Text = fecha.ToString("HH:mm");       

            
        }

        protected override void ControlesAClaseBase()
        {
            Generic.ControlAClaseBase(this.ObjetoBase, "IdHembra", cmbHembra);
            Generic.ControlAClaseBase(this.ObjetoBase, "IdVeterinario", cmbPersonal);
            DateTime fecha;
            if (Generic.ControlValorado(txtHora))
                fecha = Convert.ToDateTime(txtFecha.Text + " " + txtHora.Text);
            else
                fecha = Generic.ControlADatetime(txtFecha);

            
           // this.ObjetoBase.Fecha = fecha;
            try
            {
                this.ObjetoBase.Fecha = fecha;// this.ObjetoBase.ValidarFechaCelo(this.ObjetoBase.Fecha, this.ObjetoBase.IdHembra);
            }
            catch (LogicException le)
            {
                DialogResult rdo = MessageBox.Show(le.Message +
                                  "\r¿Desea insertar el celo a pesar de las advertencias?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rdo != DialogResult.Yes)
                {
                    txtFecha.Focus();
                    throw new LogicException("No se ha insertado el celo porque no cumple con las especificaciones de configuración");
                }            
            }
            catch (Exception)
            {
                throw;
            }

            
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

                            Celo celo = new Celo();                            
                            celo.IdHembra = item.Id;
                            DateTime fecha = Convert.ToDateTime(txtFecha.Text + " " + txtHora.Text);
                            //celo.Fecha = fecha;
                            try
                            {
                                celo.Fecha = fecha;
                            }
                            catch (LogicException lgex)
                            {
                                DialogResult rdo = MessageBox.Show(lgex.Message +
                                                  "\r¿Desea insertar el celo a pesar de las advertencias?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rdo != DialogResult.Yes)
                                {
                                    txtFecha.Focus();
                                    throw ;//new LogicException("No se ha insertado el celo porque no cumple con las especificaciones de configuración");
                                }
                            }                         
                            celo.IdVeterinario = cmbPersonal.IdClaseActiva;

                            celo.Insertar();
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



        /// <summary>
        /// Validación de los Controles, se produce antes de actualizar la ClaseBase.
        /// </summary>
        /// <returns>Controles válidos (Si/No)</returns>
        protected override bool Validar()
        {
            bool Rtno = true;
            this.ErrorProvider.Clear();
            if (!Generic.ControlValorado(new Control[] { cmbHembra,txtFecha,txtHora,cmbPersonal }, this.ErrorProvider))
                Rtno = false;            
            if (!Generic.ControlDatosCorrectos(txtFecha, this.ErrorProvider,typeof(DateTime),true)) Rtno = false;
            if (!Generic.ControlDatosCorrectos(txtHora, this.ErrorProvider, typeof(DateTime), false)) Rtno = false;          
            
            

            return Rtno;

        }

        #endregion

        #region CARGAS COMUNES
            protected override void CargarValoresDefecto()
            {
                Generic.DatetimeAControl(this.txtFecha, DateTime.Now.Date);
                this.txtHora.Text = DateTime.Now.ToString("HH:mm");
                 
            }
        #endregion

        #region FUNCIONAMIENTO GENERAL
            /// <summary>
            /// Lanza el formulario de busqueda de personal en modo consulta.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnBuscarPersonal_Click(object sender, EventArgs e)
            {
                 this.LanzarFormularioConsulta(new FindPersonal(Modo.Consultar, this.cmbPersonal));
            }        

            private void btnBuscarAnimal_Click(object sender, EventArgs e)
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
        #endregion
    }
     

      


}
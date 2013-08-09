using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Data;
using GEXVOC.UI.Clases;


namespace GEXVOC.UI
{
    public partial class EditControlesMuestras : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public EditControlesMuestras()
        {
            InitializeComponent();
                    

        }
        public EditControlesMuestras(Modo modo, MuestraControl ClaseBase):base (modo,ClaseBase)
        {
            InitializeComponent();
          
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO

        /// <summary>
        /// Es una propiedad tipada que nos devuelve una clase base sobre la que actua el formulario Edit.
        /// El tipo es el del formulario, pero implementa una interface IClaseBase.
        /// </summary>
        public MuestraControl ObjetoBase
        { 
        get{return (MuestraControl) ClaseBase;}
            set { ClaseBase = value; }

        }


        #endregion

        #region BINDING (Intercambio de datos entre la clase base y los controles del formulario)
        protected override void ClaseBaseAControles()
        {
            cmbExplotacion.SelectedItem = this.ObjetoBase.ControlLeche.Lactacion.Hembra.Explotacion;
            Generic.DatetimeAControl(txtFechaControles, this.ObjetoBase.ControlLeche.Fecha);
            cmbStatusOrdeno.SelectedItem = this.ObjetoBase.ControlLeche.StatusOrdeno;
            cmbStatusControl.SelectedItem = this.ObjetoBase.ControlLeche.StatusControl;
            txtManhana.Text = this.ObjetoBase.ControlLeche.LecheManana.ToString();
            txtTarde.Text = this.ObjetoBase.ControlLeche.LecheTarde.ToString();
            txtNoche.Text = this.ObjetoBase.ControlLeche.LecheNoche.ToString();
            cmbLaboratorio.SelectedItem = this.ObjetoBase.Laboratorio;
            Generic.DatetimeAControl(txtFechaAnalisis, this.ObjetoBase.Fecha);
            txtRctoCelular.Text = this.ObjetoBase.RctoCelular.ToString();
            txtGrasa.Text = this.ObjetoBase.Grasa.ToString();
            txtUrea.Text = this.ObjetoBase.Urea.ToString();
            txtProteina.Text = this.ObjetoBase.Proteina.ToString();
            txtLactosa.Text = this.ObjetoBase.Lactosa.ToString();
            txtExtractoSeco.Text = this.ObjetoBase.ExtractoSeco.ToString();
            txtLinealPto.Text = this.ObjetoBase.LinealPto.ToString();
            base.ClaseBaseAControles();
        }
        protected override void ControlesAClaseBase()
        {
            this.ObjetoBase.ControlLeche.Lactacion.Hembra.Explotacion = (Explotacion)cmbExplotacion.SelectedItem;
            this.ObjetoBase.ControlLeche.Fecha = Generic.ControlADatetime(this.txtFechaControles);
            this.ObjetoBase.ControlLeche.StatusControl = (StatusControl)cmbStatusControl.SelectedItem;
            this.ObjetoBase.ControlLeche.StatusOrdeno = (StatusOrdeno)cmbStatusOrdeno.SelectedItem;
            this.ObjetoBase.ControlLeche.LecheManana = Convert.ToDecimal(txtManhana.Text);
            this.ObjetoBase.ControlLeche.LecheTarde = Convert.ToDecimal(txtTarde.Text);
            this.ObjetoBase.ControlLeche.LecheNoche = Convert.ToDecimal(txtNoche.Text);
            this.ObjetoBase.Laboratorio = (Laboratorio)cmbLaboratorio.SelectedItem;
            this.ObjetoBase.Fecha = Generic.ControlADatetime(this.txtFechaAnalisis);
            this.ObjetoBase.RctoCelular = Convert.ToDecimal(txtRctoCelular.Text);
            this.ObjetoBase.Grasa = Convert.ToDecimal(txtGrasa.Text);
            this.ObjetoBase.Urea = Convert.ToDecimal(txtUrea.Text);
            this.ObjetoBase.Proteina = Convert.ToDecimal(txtProteina.Text);
            this.ObjetoBase.Lactosa = Convert.ToDecimal(txtLactosa.Text);
            this.ObjetoBase.ExtractoSeco = Convert.ToDecimal(txtExtractoSeco.Text);
            this.ObjetoBase.LinealPto = Convert.ToDecimal(txtLinealPto.Text);
         
        }

        protected override bool Validar()
        {
            bool Rtno = true;
            this.ErrorProvider.Clear();
            if (!Generic.ControlValorado(cmbExplotacion, this.ErrorProvider))
                Rtno = false;
            if (grpControles.Enabled)
            {
                if (!Generic.ControlDatosCorrectos(this.txtFechaControles,  this.ErrorProvider, "El valor introducido no es del tipo fecha", typeof(System.DateTime), true))
                    Rtno = false;
                if (Validacion.EsNumero(txtManhana, false) && Validacion.EsNumero(txtTarde, false) && Validacion.EsNumero(txtNoche, false))
                    Rtno = false;
            }
            if (grpAnalisis.Enabled)
            {
                if (!Generic.ControlDatosCorrectos(this.txtFechaAnalisis,  this.ErrorProvider, "El valor introducido no es del tipo fecha", typeof(System.DateTime), true))
                    Rtno = false;
                if (Validacion.EsNumero(txtRctoCelular, false) && Validacion.EsNumero(txtGrasa, false) && Validacion.EsNumero(txtUrea, false) && Validacion.EsNumero(txtProteina, false) && Validacion.EsNumero(txtLactosa, false) && Validacion.EsNumero(txtExtractoSeco, false) && Validacion.EsNumero(txtLinealPto, false))
                    Rtno = false;
            }
            return Rtno;

        }

        #endregion


        #region CARGAS COMUNES

        protected override void CargarCombos()
        {
            this.cmbStatusControl.DataSource =StatusControl.Buscar();
            this.cmbStatusControl.DisplayMember = "Descripcion";
            this.cmbStatusControl.SelectedIndex = -1;

            this.cmbStatusOrdeno.DataSource = StatusOrdeno.Buscar();
            this.cmbStatusOrdeno.DisplayMember = "Descripcion";
            this.cmbStatusOrdeno.SelectedIndex = -1;
            
        }
        protected override void CargarValoresDefecto()
        {
            Generic.DatetimeAControl(txtFechaControles, DateTime.Now.Date);
        }
        

        #endregion

        private void btnBuscarExplotacion_Click(object sender, EventArgs e)
        {
           this.LanzarFormularioConsulta( new FindExplotaciones(Modo.Consultar, this.cmbExplotacion));
        }

        private void rdbControles_CheckedChanged(object sender, EventArgs e)
        {
            grpControles.Enabled = true;
            Generic.LimpiarControles(grpAnalisis);
            grpAnalisis.Enabled = false;
            if (dtgControlesMuestras.SelectedRows.Count > 0)
            {
                ClaseBaseAControles();
                cmbStatusOrdeno.Focus();

            }
        }

        private void rdbAnalisis_CheckedChanged(object sender, EventArgs e)
        {
            grpAnalisis.Enabled = true;
            if (txtFechaAnalisis.Text == "") txtFechaAnalisis.Text = DateTime.Today.ToShortDateString();

            Generic.LimpiarControles(grpControles);
            grpControles.Enabled = false;
            if (dtgControlesMuestras.SelectedRows.Count > 0)
            {
                ClaseBaseAControles();
                cmbLaboratorio.Focus();
            }
        }

        private void rdbControlesAnalisis_CheckedChanged(object sender, EventArgs e)
        {
            grpControles.Enabled = true;
            grpAnalisis.Enabled = true;
            if (txtFechaAnalisis.Text == "") txtFechaAnalisis.Text = DateTime.Today.ToShortDateString();
            if (dtgControlesMuestras.SelectedRows.Count > 0)
            {
                ClaseBaseAControles();
                cmbStatusOrdeno.Focus();
            }

        }

        

        






    }
}

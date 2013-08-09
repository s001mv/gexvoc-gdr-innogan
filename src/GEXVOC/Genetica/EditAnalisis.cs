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
    public partial class EditAnalisis : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditAnalisis()
        {
            InitializeComponent();
        }
        public EditAnalisis(Modo modo, Analisis ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Analisis ObjetoBase { get { return (Analisis)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

        protected override void DefinirListaBinding()
        {
            cmbAnimal.TipoDatos = typeof(Animal);
            cmbLaboratorio.TipoDatos = typeof(Laboratorio);
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTipo", true, cmbTipoAnalisis, lblTipoAnalisis));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdAnimal", true, cmbAnimal, lblAnimal));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdLaboratorio", true, cmbLaboratorio, lblLaboratorio));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, txtFecha, lblFecha));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Registro", false, this.txtRegistro, lblRegistro));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FiliacionCompatible", false, chkFiliacion, lblFiliaciónCompatible));
        }     

        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga el combo del formulario.
        /// </summary>
        protected override void CargarCombos()
        {
            cmbTipoAnalisis.CargarCombo();
        }
        /// <summary>
        /// Carga la fecha actual por defecto en el formulario.
        /// </summary>
        protected override void CargarValoresDefecto()
        {
            Generic.DatetimeAControl(txtFecha, DateTime.Now.Date);
        }

        #endregion

        #region FUNCIONAMIENTO GENERAL
        /// <summary>
        /// Lanza el formulario de busqueda de animal en modo consulta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, cmbAnimal));

        }
        /// <summary>
        /// Lanza el formulario de busqueda de laboratorio en modo consulta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarLaboratorio_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindLaboratorios(Modo.Consultar, cmbLaboratorio));
        }

        #endregion

        #region COMBOS
        private void cmbTipoAnalisis_CargarContenido(object sender, EventArgs e)
        {
            this.CargarCombo(cmbTipoAnalisis, "Descripcion", "Id", TipoAnalisis.Buscar());
        }
        private void cmbTipoAnalisis_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
        {
            
               TipoAnalisis ObjetoBase = new TipoAnalisis();                 
                GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ObjetoBase);
                frmLanzar.Titulo = "Tipos Análisis Genéticos";
                frmLanzar.NumColumnas = 2;
                frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción") { ValorDefecto=e.TextoCrear});

                CrearNuevoElementoCombo(frmLanzar, sender);                 
        }

        private void cmbLaboratorio_CrearNuevo(object sender, EventArgs e)
        {

            Laboratorio ObjetoBase = new Laboratorio();
            EditLaboratorios editLaboratorio = new EditLaboratorios(Modo.Guardar, ObjetoBase);

            CrearNuevoElementoCombo(editLaboratorio, sender);

        }
        #endregion
    

    }
}
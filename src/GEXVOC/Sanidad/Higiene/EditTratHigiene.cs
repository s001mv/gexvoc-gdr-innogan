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
    public partial class EditTratHigiene : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditTratHigiene()
        {
            InitializeComponent();
        }
        public EditTratHigiene(Modo modo, TratHigiene ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public TratHigiene ObjetoBase { get { return (TratHigiene)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)        

        protected override void DefinirListaBinding()
        {
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdPlan", true, this.cmbPlanHigiene, lblPlan));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Detalle", false, this.txtDetalle, lblDetalle));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaInicio", true, this.txtFechaInicio, lblFechaInicio));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaFin", false, this.txtFechaFin, lblFechaFin));

            base.DefinirListaBinding();
        }

        ////protected override void ClaseBaseAControles()
        ////{
        ////    Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
        ////}

        ////protected override void ControlesAClaseBase()
        ////{

        ////    Generic.ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
        ////}



        /////// <summary>
        /////// Validación de los Controles, se produce antes de actualizar la ClaseBase.
        /////// </summary>
        /////// <returns>Controles válidos (Si/No)</returns>
        ////protected override bool Validar()
        ////{
        ////    bool Rtno = true;
        ////    this.ErrorProvider.Clear();
        ////    if (!Generic.ControlValorado(new Control[] { txtDescripcion }, this.ErrorProvider))
        ////        Rtno = false;


        ////    return Rtno;

        ////}



        #endregion

        #region CARGAS COMUNES
        protected override void CargarCombos()
        {
            cmbPlanHigiene.CargarCombo();
        }

        protected override void CargarGrids()
        {
            this.dtgProHig.DataSource = this.ObjetoBase.lstProHig;
        }

        #endregion

        #region GRID - PROHIG
        private void NuevoProHig()
        {
            if (ModoActual == Modo.Actualizar)
            {
                ProHig ObjCrear = new ProHig();
                this.LanzarFormulario(new EditProHig(Modo.Guardar, ObjCrear) { ValorFijoIdTratHigiene = this.ObjetoBase.Id }, dtgProHig);

            }
        }
        private void ModificarProHig()
        {

            if (this.dtgProHig.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
            {
                ProHig ObjActualizar = (ProHig)this.dtgProHig.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditProHig(Modo.Actualizar, ObjActualizar), this.dtgProHig);
            }
        }
        private void tsbNuevoProHig_Click(object sender, EventArgs e)
        {
            NuevoProHig();
        }
        private void tsbModificarProHig_Click(object sender, EventArgs e)
        {
            ModificarProHig();
        }
        private void tsbEliminarProHig_Click(object sender, EventArgs e)
        {
            this.EliminarObjGrid(this.dtgProHig, "Va a eliminar la asociación del producto.\r¿Esta usted seguro de que desea continuar?");
        }
        private void dtgProHig_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarProHig();
        }
        #endregion   

        #region COMBOS
            private void cmbPlanHigiene_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(this.cmbPlanHigiene, PlanHigiene.Buscar());
            }
            private void cmbPlanHigiene_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                
             
                PlanHigiene ObjetoBase = new PlanHigiene();
                GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ObjetoBase);
                frmLanzar.Titulo = "Plan de Higiene";
                frmLanzar.NumColumnas = 2;
                frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción") { ValorDefecto=e.TextoCrear});

                CrearNuevoElementoCombo(frmLanzar, sender);

                ////Poner en el formulario PlanHigiene si es necesario
                ////public string Descripcion { get { return txtDescripcion.Text; } set { txtDescripcion.Text = value; } }
            }
        #endregion

    }
}
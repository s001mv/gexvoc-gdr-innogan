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
    public partial class EditPastoreo : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
            public EditPastoreo()
            {
                InitializeComponent();
            }
            public EditPastoreo(Modo modo, Pastoreo ClaseBase)
                : base(modo, ClaseBase)
            {
                InitializeComponent();
            }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            public Pastoreo ObjetoBase { get { return (Pastoreo)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

            protected override void DefinirListaBinding()
            {
                cmbLote.TipoDatos = typeof(LoteAnimal);
                cmbParcela.TipoDatos = typeof(Parcela);
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdParcela", true, this.cmbParcela, lblParcela));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdLote", true, this.cmbLote, lblLote));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaInicio", true, this.txtFechaInicio, lblFechaInicio));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaFin", false, this.txtFechaFin, lblFechaFin));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Cantidad", true, this.txtCantidad, lblCantidad));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Total", false, this.chkTotal, null));


                base.DefinirListaBinding();
            }

        
        #endregion

        #region CARGAS COMUNES
            protected override void CargarValoresDefecto()
            {
                Generic.DatetimeAControl(txtFechaInicio, DateTime.Today);
            }

        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarParcela_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindParcela(Modo.Consultar, cmbParcela));
            }

            private void btnBuscarLote_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindLoteAnimal(Modo.Consultar, cmbLote) { ValorFijoParidera=false});
            }
        #endregion

        #region COMBOS
            private void cmbParcela_CrearNuevo(object sender, EventArgs e)
            {
                
                Parcela ObjetoBase = new Parcela();
                EditParcela editParcela = new EditParcela(Modo.Guardar, ObjetoBase);                

                CrearNuevoElementoCombo(editParcela, sender);                
            }

            private void cmbLote_CrearNuevo(object sender, EventArgs e)
            {
                
                LoteAnimal ObjetoBase = new LoteAnimal();
                EditLoteAnimal editLoteAnimal = new EditLoteAnimal(Modo.Guardar, ObjetoBase);                

                CrearNuevoElementoCombo(editLoteAnimal, sender);

            }
        #endregion

    }
}
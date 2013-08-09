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
    public partial class EditTipoCondicion : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditTipoCondicion()
        {
            InitializeComponent();
        }
        public EditTipoCondicion(Modo modo, TipoCondicion ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public TipoCondicion ObjetoBase { get { return (TipoCondicion)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
        {
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdEspecie", true, this.cmbEspecie, lblEspecie));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Codigo", true, this.txtCodigo, lblCodigo));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Descripcion", true, this.txtDescripcion, lblDescripcion));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Detalle", false, this.txtDetalle, lblDetalle));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Apta", false, this.chkApta, lblApta));

            base.DefinirListaBinding();
        }

        

        #endregion

        #region CARGAS COMUNES
            protected override void CargarCombos()
            {
                this.CargarCombo(cmbEspecie, Especie.Buscar());
                base.CargarCombos();
            }
        #endregion
       
    }
}
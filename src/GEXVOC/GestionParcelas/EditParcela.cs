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
    public partial class EditParcela : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
            public EditParcela()
            {
                InitializeComponent();
            }
            public EditParcela(Modo modo, Parcela ClaseBase)
                : base(modo, ClaseBase)
            {
                InitializeComponent();

            }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Parcela ObjetoBase { get { return (Parcela)this.ClaseBase; } }
        public string Nombre { get { return txtNombre.Text; } set { txtNombre.Text = value; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTitular", true, this.cmbTitular, lblTitular));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Nombre", true, txtNombre, lblNombre));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Poligono", false, txtPoligono, lblPoligono));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Extension", true, txtExtension, lblExtension));
            }
        #endregion

        #region CARGAS COMUNES
            protected override void CargarCombos()
        {

            CargarCombo(cmbTitular, "NombreCompleto", Configuracion.Explotacion.lstTitulares);          

            base.CargarCombos();
        }
        #endregion

    }
}

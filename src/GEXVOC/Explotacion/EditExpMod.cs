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
    public partial class EditExpMod : GEXVOC.UI.GenericEdit
    {        
        #region CONTRUCTORES
        public EditExpMod()
        {
            InitializeComponent();
        }
        public EditExpMod(Modo modo, ExpMod ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public ExpMod ObjetoBase { get { return (ExpMod)this.ClaseBase; } }

        int? _ValorIdExplotacionFijo = null;

        public int? ValorIdExplotacionFijo
        {
            get { return _ValorIdExplotacionFijo; }
            set { _ValorIdExplotacionFijo = value; }
        }

        #endregion        

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
        {
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdExplotacion", true, this.cmbExplotacion, lblExplotacion));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdModulo", true, this.cmbModulo, lblModulo));            
            

            base.DefinirListaBinding();
        }


        
        #endregion

        #region CARGAS COMUNES
            /// <summary>
            /// Carga los Valores por defecto del Formulario
            /// </summary>
            protected override void CargarValoresDefecto()
            {
                if (ValorIdExplotacionFijo != null)
                {
                    this.cmbExplotacion.SelectedValue = this.ValorIdExplotacionFijo;
                    this.cmbExplotacion.Enabled = false;

                }


            }
                        
            protected override void CargarCombos()
            {
                CargarCombo(cmbExplotacion,"Nombre", Explotacion.Buscar());
                CargarCombo(cmbModulo, Modulo.Buscar());                
            }
       #endregion
    }
}

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
    public partial class VisorMovimientos : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public VisorMovimientos()
        {
            InitializeComponent();
        }
        public VisorMovimientos(Modo modo, Movimiento ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region CARGAS COMUNES
            void cargarMovimientos() 
            {
                this.dtgMovimientos.DataSource = Movimiento.Buscar();
            }
            private void VisorMovimientos_Load(object sender, EventArgs e)
            {
                this.btnGuardar.Visible = false;
                cargarMovimientos();
            }
            private void btnRecargar_Click(object sender, EventArgs e)
            {
                cargarMovimientos();
            }
        #endregion
    }
}

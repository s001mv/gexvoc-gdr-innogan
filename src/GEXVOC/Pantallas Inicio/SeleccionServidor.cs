using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Data;
using GEXVOC.Core.Registro;

namespace GEXVOC.UI
{
    public partial class SeleccionServidor : Form
    {
        #region CONSTRUCTORES
            public SeleccionServidor()
            {
                InitializeComponent();
                txtNombreInstancia.Text = Registro.GetSetting("InstanciaServidor");
            }

        #endregion

        #region FUNCIONAMIENTO GENERAL

            private void btnSeleccionar_Click(object sender, EventArgs e)
            {            
                //Quito el error si lo tiene
                errorProvider1.SetError(txtNombreInstancia,string.Empty);

                if (txtNombreInstancia.Text == string.Empty)
                {
                    errorProvider1.SetError(txtNombreInstancia, "Debe especificar un valor");
                    return;
                }
                

                if (BDController.ExisteBD(GEXVOC.Core.Data.BDController.ConectionStringGEXVOC(txtNombreInstancia.Text,null)))
                {
                    Registro.SaveSetting("InstanciaServidor", txtNombreInstancia.Text);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("No ha sido posible conectarse al origen de datos con la información proporcionada.\nProporcione una información válida  o contacte con su administrador.", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreInstancia.SelectAll();
                }
            }

            private void SeleccionServidor_FormClosed(object sender, FormClosedEventArgs e)
            {
                if (DialogResult != DialogResult.OK)
                    Application.Exit();
            }

        #endregion
       
    }
}

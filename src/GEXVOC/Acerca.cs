using System;
using System.Windows.Forms;

namespace GEXVOC
{
    public partial class Acerca : Form
    {
        #region CONSTRUCTORES
        public Acerca()
        {
            InitializeComponent();
        }
        #endregion

        #region FUNCIONAMIENTO GENERAL

        private void lnkWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.coremain.es");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void Acerca_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Application.ProductVersion;
        }

    }
}

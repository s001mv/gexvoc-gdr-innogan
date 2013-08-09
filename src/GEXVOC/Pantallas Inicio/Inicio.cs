using System;
using System.Collections.Generic;
using System.Windows.Forms;

using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Controles;

namespace GEXVOC.UI
{
    public partial class Inicio : Form
    {
        #region CONSTRUCTORES
            public Inicio()
            {
                InitializeComponent();
            }

        #endregion

        #region CARGAS COMUNES
            private void Inicio_Load(object sender, EventArgs e)
            {
                CargarExplotaciones();
            }

            private void CargarExplotaciones()
            {
                
                this.cmbExplotacion.DataSource = Explotacion.Buscar();
                this.cmbExplotacion.DisplayMember = "Nombre";
                this.cmbExplotacion.ValueMember = "Id";
            }

        #endregion

        #region FUNCIONAMIENTO GENERAL

            private void btnSeleccionar_Click(object sender, EventArgs e)
            {
                    this.Close();
            }

            private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (this.cmbExplotacion.SelectedValue != null)
                    Configuracion.Explotacion = (Explotacion)cmbExplotacion.SelectedItem;
                else
                {
                    Generic.AvisoInformation("Debe seleccionar la explotación con la que desea trabajar.\rPuede registrar una explotación utilizando el asistente.");
                    e.Cancel = true;
                }
            }

            private void lnkEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                if (this.cmbExplotacion.SelectedValue != null)
                {
                    Explotacion E = (Explotacion)cmbExplotacion.SelectedItem;

                    EditExplotaciones Edicion = new EditExplotaciones(Modo.Actualizar, E);
                    Edicion.ShowDialog(this);

                    if (Edicion.DialogResult == DialogResult.OK)
                        CargarExplotaciones();

                    Edicion.Dispose();
                }
            }

            private void lnkNueva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                ////Explotacion E = new Explotacion();

                ////EditExplotaciones Edicion = new EditExplotaciones(Modo.Guardar, E);
                ////Edicion.ShowDialog(this);

                ////if (Edicion.DialogResult == DialogResult.OK)
                ////    CargarExplotaciones();

                ////Edicion.Dispose();
                Asistente asistente = new Asistente();
                asistente.ShowDialog();

                CargarExplotaciones();

            }

            private void btnSalir_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Data;
using GEXVOC.Core.Logic;

namespace GEXVOC.UI
{
    public partial class Inseminaciones : GEXVOC.UI.Principal
    {
        public Inseminaciones()
        {
            InitializeComponent();
        }

        private void Inseminaciones_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Inseminaciones mForm = (Inseminaciones)FormFactory.Obtener(Formulario.Inseminaciones);
            mForm.Hide();
        }
        public void RefrescarPantalla()
        {
            //DataGrid de Inseminaciones
            DgInseminaciones.DataSource = InseminacionesTA.ObtenerTodasInseminaciones(Program.IdExplotacion);
            DgInseminaciones.Refresh();
            /****************************************************************/
            //ComboBox de Tipo
            CbTipo.DataSource = TipoInseminacionTA.ObtenerTiposInseminaciones();
            CbTipo.DisplayMember = "Descripcion";
            CbTipo.ValueMember = "Id";
            CbTipo.Refresh();
            /****************************************************************/
            //Combobox de Hembras
            cBHembra.DataSource = AnimalTA.ObtenerAnimalesHembras(Program.IdExplotacion);
            cBHembra.DisplayMember = "Nombre";
            cBHembra.ValueMember = "Id";
            cBHembra.Refresh();
            /****************************************************************/
            //ComboBox de Machos
            cbMachos.DataSource = AnimalTA.ObtenerAnimalesMachos(Program.IdExplotacion);
            cbMachos.DisplayMember = "Nombre";
            cbMachos.ValueMember = "Id";
            cbMachos.Refresh();
            /****************************************************************/

        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            Program.MostrarCursorEspera();
            InsertarInseminacion mForm = (InsertarInseminacion)FormFactory.Obtener(Formulario.InsertarInseminacion);
            mForm.refrescar_pantalla();
            Program.OcultarCursorEspera();
            mForm.Show();
        }

        #region ordenar

        private void DgInseminaciones_MouseDown(object sender, MouseEventArgs e)
        {
            Principal.ordenar_down(sender, e);
        }

        private void DgInseminaciones_MouseUp(object sender, MouseEventArgs e)
        {
            Principal.ordenar_up(sender, e);
        }

        #endregion

        #region buscar
        private void pictureBox1_Click(object sender, EventArgs e)//Buscar
        {
            try
            {
                int IdHembra;
                int IdMacho;
                int IdTipo;
                if (TbHembra.Text == "")
                    IdHembra = 0;
                else
                    IdHembra = Convert.ToInt32(cBHembra.SelectedValue.ToString());
                if (TbMacho.Text == "")
                    IdMacho = 0;
                else
                    IdMacho = Convert.ToInt32(cbMachos.SelectedValue.ToString());
                if (TbTipo.Text == "")
                    IdTipo = 0;
                else
                    IdTipo = Convert.ToInt32(CbTipo.SelectedValue.ToString());
                DgInseminaciones.DataSource = InseminacionesTA.FiltrarInseminaciones(Dtfecha.Value.Date, IdHembra, IdMacho, IdTipo);
                DgInseminaciones.Refresh();
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
            }
        }
        #endregion

        #region combobox value change
        private void cbMachos_SelectedValueChanged(object sender, EventArgs e)
        {
            TbMacho.Text = cbMachos.Text;
        }

        private void cBHembra_SelectedValueChanged(object sender, EventArgs e)
        {
            TbHembra.Text = cBHembra.Text;
        }       
        private void CbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            TbTipo.Text = CbTipo.Text;
        }
        #endregion
    }
}




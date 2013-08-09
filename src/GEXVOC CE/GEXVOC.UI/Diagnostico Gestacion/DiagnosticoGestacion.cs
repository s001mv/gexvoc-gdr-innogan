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
    public partial class DiagnosticoGestacion : GEXVOC.UI.Principal
    {
        public DiagnosticoGestacion()
        {
            InitializeComponent();
        }

        #region refrescar
        public void Refrescar_Pantalla()
        {
            try
            {
                //Cbtipos
                CbTipo.DataSource = TipoDiagnosticoTA.ObtenerTiposDiagnosticos();
                CbTipo.DisplayMember = "Descripcion";
                CbTipo.ValueMember = "Id";
                CbTipo.Refresh();
                /***************************************************/
                //DataGrid
                dgDiagnostico.DataSource = DiagnosticoInseminacionTA.ObtenerDiagnosticoInseminacionExplotacion(Program.IdExplotacion);
                dgDiagnostico.Refresh();
                /***************************************************/
                TbHembra.Text = "";
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
            }
        }
        public void refrescar_TbHembra(string nombre)
        {
            TbHembra.Text = nombre;
        }
        #endregion       

        #region combobox y fecha changed
        private void CbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            TbTipo.Text = CbTipo.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TbFecha.Text = dtFecha.Text;
        }
        #endregion

        private void PbBuscar_Click(object sender, EventArgs e)
        {
            Program.queSeleccion = "HembrasParaDiagnostico";
            Program.MostrarCursorEspera();
            Animal mForm = (Animal)FormFactory.Obtener(Formulario.Animal);
            mForm.RefrescarPantalla("H");
            Program.OcultarCursorEspera();
            mForm.Show();
        }

        private void PbAnadir_Click(object sender, EventArgs e)
        {
            Program.MostrarCursorEspera();
            InsertarDiagnosticoGestacion mForm = (InsertarDiagnosticoGestacion)FormFactory.Obtener(Formulario.InsertarDiagnosticoGestacion);
            mForm.refrescar_pantalla();
            Program.OcultarCursorEspera();
            mForm.Show();
        }

        private void DiagnosticoGestacion_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;            
            DiagnosticoGestacion mForm = (DiagnosticoGestacion)FormFactory.Obtener(Formulario.DiagnosticoGestacion);
            mForm.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string dia;
            string mes;
            string ano;

            int IdAnimal = 0;
            int IdTipo = 0;
            string Fecha = "";
            if (TbHembra.Text != "")
                IdAnimal = Program.Embrion;
            if (TbTipo.Text == CbTipo.Text)
                IdTipo = Convert.ToInt32(CbTipo.SelectedValue.ToString());
            if (dtFecha.Value.Date.ToShortDateString() == TbFecha.Text)
            {
                dia = dtFecha.Value.Day.ToString();
                mes = dtFecha.Value.Month.ToString();
                ano = dtFecha.Value.Year.ToString();
                if (Convert.ToInt32(dia) < 10)
                    dia = "0" + dia;
                if (Convert.ToInt32(mes) < 10)
                    mes = "0" + mes;
                Fecha = mes + "/" + dia + "/" + ano + " 0:00:00 ";
                //Fecha = dtFecha.Value.Date.ToString(); 
            }

            dgDiagnostico.DataSource = DiagnosticoInseminacionTA.FiltrarDiagnosticos(IdAnimal, Fecha, IdTipo, Program.IdExplotacion);
            dgDiagnostico.Refresh();
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Data;

namespace GEXVOC.UI
{
    public partial class InsertarTratamientoEnfermedad : GEXVOC.UI.Principal
    {
        public InsertarTratamientoEnfermedad()
        {
            InitializeComponent();
        }
        public void refrescar_TbDiagnostico(string fechaanimal)
        {
            TbDiagnostico.Text = fechaanimal;
        }
        public void refrescar_pantalla()
        {
            TbDiagnostico.Text = "";          
            //Combobox de Inseminador
            CbPersonal.DataSource = VeterinarioTA.ObtenerVeterinarios(Program.IdExplotacion);
            CbPersonal.DisplayMember = "NombreComleto";
            CbPersonal.ValueMember = "Id";
            CbPersonal.Refresh();
            /****************************************************************/
            
        }

        private void InsertarTratamientoEnfermedad_Closing(object sender, CancelEventArgs e)
        {
             DialogResult r = Program.Preguntar("¿Desea guardar el tratamiento?");
             if (r == DialogResult.Yes)
             {
                 if (validar())
                 {
                     int? supreleche = null;
                     int? suprecarne = null;
                     if (TbSupreLeche.Text != "")
                         supreleche = Convert.ToInt32(TbSupreLeche.Text);
                     if (TbSupreCarne.Text != "") 
                         suprecarne = Convert.ToInt32(TbSupreCarne.Text);
                     
                         
                     TratEnfermedadTA.InsertarNueva(Program.IdDiagnosticoInsertaTratamiento, Convert.ToInt32(CbPersonal.SelectedValue.ToString()), supreleche, suprecarne, dateTimePicker1.Value.Date, Convert.ToInt32(TbDuracion.Text), TbDetalle.Text);
                     e.Cancel = true;
                     InsertarTratamientoEnfermedad mForm = (InsertarTratamientoEnfermedad)FormFactory.Obtener(Formulario.InsertarTratamientoEnfermedad);
                     mForm.Hide();
                 }
             }
             else
             {
                 e.Cancel = true;
                 InsertarTratamientoEnfermedad mForm = (InsertarTratamientoEnfermedad)FormFactory.Obtener(Formulario.InsertarTratamientoEnfermedad);
                 mForm.Hide();
             }
            
        }

        private void PbBuscaDiagnostico_Click(object sender, EventArgs e)
        {
            Program.queSeleccion = "DiagnosticosParaInsertarTratamiento";
            Program.MostrarCursorEspera();
            Diagnosticos mForm = (Diagnosticos)FormFactory.Obtener(Formulario.Diagnosticos);
            mForm.refrescar_Pantalla();
            Program.OcultarCursorEspera();
            mForm.Show(); 
        }

        private void PbBuscaPersonal_Click(object sender, EventArgs e)
        {

        }
        private bool validar()
        {

            return true;
        }
    }
}


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
    public partial class Diagnosticos : GEXVOC.UI.Principal
    {
        public Diagnosticos()
        {
            InitializeComponent();
        }
        public void refrescar_TbboxAnimal(string nombre)
        {
            TbAnimal.Text = nombre;
        }
        public void refrescar_TboxEnfermedad(string nombre)
        {
            TbEnfermedad.Text = nombre;
        }
        public void refrescar_Pantalla()
        {
            TbAnimal.Text = "";
            TbEnfermedad.Text = "";
            //Grid de diagnosticos
            dataGrid1.DataSource = DiagnosticosEnfermedades.ObtenerDiagnosticos(Program.IdExplotacion);
            dataGrid1.Refresh();
        }

        private void PbBuscarAnimal_Click(object sender, EventArgs e)
        {
            Program.MostrarCursorEspera();
            Program.queSeleccion = "todosparadiagnostico";            
            Animal mForm = (Animal)FormFactory.Obtener(Formulario.Animal);
            mForm.RefrescarPantalla("todos");
            Program.OcultarCursorEspera();
            mForm.Show(); 
        }

        private void Diagnosticos_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Diagnosticos mForm = (Diagnosticos)FormFactory.Obtener(Formulario.Diagnosticos);
            //mForm.refrescar();
            Program.OcultarCursorEspera();
            mForm.Hide();
        }

        private void PbAnadir_Click(object sender, EventArgs e)
        {
            Program.MostrarCursorEspera();
            InsertarDiagnosticoEnfermedad mForm = (InsertarDiagnosticoEnfermedad)FormFactory.Obtener(Formulario.InsertarDiagnosticoEnfermedad);
            mForm.refrescar_Pantalla();
            Program.OcultarCursorEspera();
            mForm.Show();
        }

        private void PbBuscarEnfermedad_Click(object sender, EventArgs e)
        {
            Program.queSeleccion="EnfermedadBuscarDiagnostico";            
            Program.MostrarCursorEspera();
            Enfermedades mForm = (Enfermedades)FormFactory.Obtener(Formulario.Enfermedades);
            mForm.Refrescar_Pantalla();
            Program.OcultarCursorEspera();
            mForm.Show();
        }

        private void dataGrid1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dataGrid1.DataSource;
                if (dt != null && dt.Rows.Count != 0)
                {
                    if (Program.queSeleccion == "DiagnosticosParaInsertarTratamiento")
                    {
                        int Fila = dataGrid1.BindingContext[dataGrid1.DataSource].Position;
                        string DescripcionDiagnosticoInsertaTratamiento =Convert.ToDateTime(dt.Rows[Fila]["Fecha"].ToString()).ToShortDateString() +" "+dt.Rows[Fila]["Nombre"].ToString();
                        Program.IdDiagnosticoInsertaTratamiento = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));

                        InsertarTratamientoEnfermedad mForm = (InsertarTratamientoEnfermedad)FormFactory.Obtener(Formulario.InsertarTratamientoEnfermedad);
                        mForm.refrescar_TbDiagnostico(DescripcionDiagnosticoInsertaTratamiento);
                        //InsertarInseminacion mForm = (InsertarInseminacion)FormFactory.Obtener(Formulario.InsertarInseminacion);
                        //mForm.refrescar_TbHembra(Program.NombreVaca);
                    }
                }            
             }
            catch (Exception ex)
            {
              //  Traza.Registrar(ex);
            }
        }

        private void PbFiltrar_Click(object sender, EventArgs e)
        {

            int IdAnimal=0;
            int IdEnfermedad=0;

            string diadesde;
            string mesdesde;
            string anodesde;

            string diahasta;
            string meshasta;
            string anohasta;

            string Fdesde = "";
            string FHasta = "";
            if (TbDesde.Text == dtpdesde.Text)
            {
                diadesde = dtpdesde.Value.Date.Day.ToString();
                if (Convert.ToInt32(diadesde) < 10)
                    diadesde = "0" + diadesde;
                mesdesde = dtpdesde.Value.Date.Month.ToString();
                if (Convert.ToInt32(mesdesde) < 10)
                    mesdesde = "0" + mesdesde;
                anodesde = dtpdesde.Value.Date.Year.ToString();
                Fdesde = mesdesde + "/" + diadesde + "/" + anodesde + " 0:00:00 ";
                // Fdesde = Convert.ToDateTime(dtpdesde.Value.Date.ToString()).ToString();
            }
            if (TbHasta.Text == dtphasta.Text)
            {
                diahasta = dtphasta.Value.Date.Day.ToString();
                if (Convert.ToInt32(diahasta) < 10)
                    diahasta = "0" + diahasta;
                meshasta = dtphasta.Value.Date.Month.ToString();
                if (Convert.ToInt32(meshasta) < 10)
                    meshasta = "0" + meshasta;
                anohasta = dtphasta.Value.Date.Year.ToString();
                FHasta = meshasta + "/" + diahasta + "/" + anohasta + " 0:00:00 ";
                //FHasta = Convert.ToDateTime(dtphasta.Value.Date.ToString()).ToString();
            }

            if (TbEnfermedad.Text != "")
                IdEnfermedad = Program.IdEnfermedad;
            if (TbAnimal.Text != "")
                IdAnimal = Program.IdAimalBuscaDiagnosticos;

            dataGrid1.DataSource = DiagnosticosEnfermedades.FiltrarDiagnosticos(IdAnimal, IdEnfermedad, Fdesde, FHasta, Program.IdExplotacion);

        }

        private void dtpdesde_ValueChanged(object sender, EventArgs e)
        {
            TbDesde.Text = dtpdesde.Value.Date.ToShortDateString();
        }

        private void dtphasta_ValueChanged(object sender, EventArgs e)
        {
            TbHasta.Text = dtphasta.Value.Date.ToShortDateString();
        }
    }
}


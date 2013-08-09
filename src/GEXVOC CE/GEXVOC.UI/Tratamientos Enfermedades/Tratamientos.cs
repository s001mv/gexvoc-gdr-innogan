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
    public partial class Tratamientos : GEXVOC.UI.Principal
    {
        public Tratamientos()
        {
            InitializeComponent();
        }
        public void Refrescar_TbANimal(string nombre)
        {
            tbAnimal.Text = nombre;
        }
        public void refrescar_pantalla()
        {
            try
            {
                tbAnimal.Text = "";

                dataGrid1.DataSource = TratEnfermedadTA.ObtenerTratamientoss(Program.IdExplotacion);
                dataGrid1.Refresh();
            }
            catch (Exception ex)
            {
                Program.Alertar("No se pudieron cargar los datos");
                Traza.Registrar(ex);
                    
            }
        }

        private void Tratamientos_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Tratamientos mForm = (Tratamientos)FormFactory.Obtener(Formulario.Tratamientos);
            //mForm.refrescar();
            Program.OcultarCursorEspera();
            mForm.Hide();
        }

        private void PbAnadir_Click(object sender, EventArgs e)
        {
            Program.MostrarCursorEspera();
            InsertarTratamientoEnfermedad mForm = (InsertarTratamientoEnfermedad)FormFactory.Obtener(Formulario.InsertarTratamientoEnfermedad);
            mForm.refrescar_pantalla();
            Program.OcultarCursorEspera();
            mForm.Show();
        }

        private void PbFiltra_Click(object sender, EventArgs e)
        {
            int IdAnimal=0;
            string diadesde;
            string mesdesde;
            string anodesde;

            string diahasta;
            string meshasta;
            string anohasta;

            string Fdesde= "";
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

            if(tbAnimal.Text!="")
                IdAnimal=Program.IdAnimalBuscaTrat;
            dataGrid1.DataSource = TratEnfermedadTA.FiltrarTratamientos(IdAnimal, Fdesde, FHasta, Program.IdExplotacion);
            dataGrid1.Refresh();
        }

        private void PbBuscaAnimal_Click(object sender, EventArgs e)
        {
            Program.queSeleccion = "AnimalesBuscarTrat";
            Program.MostrarCursorEspera();
            Animal mForm = (Animal)FormFactory.Obtener(Formulario.Animal);
            mForm.RefrescarPantalla("todos");
            Program.OcultarCursorEspera();
            mForm.Show();
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
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
    public partial class Secados : GEXVOC.UI.Principal
    {
        public Secados()
        {
            InitializeComponent();
        }
        public void refrescar_Pantalla()
        {
            try
            {                
                //ComboBox de Tipo
                CbTipoSecado.DataSource = TipoSecadoTA.ObtenerTiposSecados();
                CbTipoSecado.DisplayMember = "Descripcion";
                CbTipoSecado.ValueMember = "Id";
                CbTipoSecado.Refresh();
                //ComboBox de Motivo            
                CbMotivo.DataSource = MotivoTA.ObtenerMotivos();
                CbMotivo.DisplayMember = "Descripcion";
                CbMotivo.ValueMember = "Id";
                CbMotivo.Refresh();
                /****************************************************************/
                dgSecados.DataSource = SecadosTA.ObtenerTodosSecados(Program.IdExplotacion);
                dgSecados.Refresh();
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
                Program.Alertar("Error cargando los datos");                    
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InsertarSecados mForm = (InsertarSecados)FormFactory.Obtener(Formulario.InsertarSecados);
            mForm.refrescar_Pantalla();
            Program.OcultarCursorEspera();
            mForm.Show();
        }
        private void Secados_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Secados mForm = (Secados)FormFactory.Obtener(Formulario.Secados);
            mForm.Hide();
        }
        private void PbBuscarHembra_Click(object sender, EventArgs e)
        {

        }

        private void PbFiltrar_Click(object sender, EventArgs e)
        {
            string diadesde;
            string mesdesde;
            string anodesde;

            string diahasta;
            string meshasta;
            string anohasta;


            int Idtipo;
            int IdHembra;
            int IdDificultad;
            
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
        }

        private void dtpdesde_ValueChanged(object sender, EventArgs e)
        {
            TbDesde.Text = dtpdesde.Text;
        }
        private void dtphasta_ValueChanged(object sender, EventArgs e)
        {
            TbHasta.Text = dtphasta.Text;
        }
    }
}


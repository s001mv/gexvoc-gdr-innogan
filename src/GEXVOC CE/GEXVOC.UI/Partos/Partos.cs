using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Data;
using GEXVOC.Core.Logic;
using System.Globalization;


namespace GEXVOC.UI
{
    public partial class Partos : GEXVOC.UI.Principal
    {
        public Partos()
        {
            InitializeComponent();
        }
        #region Refrescar
        public void RefrescarPantalla()
        {
            //Datagrid
            DataTable partos = PartosTA.ObtenerPartosDeExplotacion(Program.IdExplotacion);
            int i = partos.Rows.Count;
            dgPartos.DataSource = partos;
            dgPartos.Refresh();
            /**************************************************************/
            //Combobox de tipo
            CBTipo.DataSource = TipoPartoTA.ObtenerTiposPartos();
            CBTipo.DisplayMember = "Descripcion";
            CBTipo.ValueMember = "Id";
            CBTipo.Refresh();
            /**************************************************************/
            //Combobox de dificultad
            CbDificultad.DataSource = FacilidadTA.ObtenerFacilidades();
            CbDificultad.DisplayMember = "Descripcion";
            CbDificultad.ValueMember = "Id";
            CbDificultad.Refresh();
            /**************************************************************/
        }
        public void Refresca_TexboxHembra(string nombre)
        {
            Tbhembra.Text = nombre;
        }
        #endregion

        private void PbBuscarHembra_Click(object sender, EventArgs e)
        {
            Program.queSeleccion = "HembrasParaPartos";
            Program.MostrarCursorEspera();
            Animal mForm = (Animal)FormFactory.Obtener(Formulario.Animal);
            mForm.RefrescarPantalla("H");
            Program.OcultarCursorEspera();
            mForm.Show();
        }

      
        #region buscar
        private void pictureBox1_Click(object sender, EventArgs e)
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
            int vivos = 0;
            int muertos = 0;
            if (TbMuertos.Text != "")
                muertos = Convert.ToInt32(TbMuertos.Text);
            if (TbVivos.Text != "")
                vivos = Convert.ToInt32(TbVivos.Text);
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
            if (TbTipo.Text == CBTipo.Text)
                Idtipo = Convert.ToInt32(CBTipo.SelectedValue.ToString());
            else
                Idtipo = 0;

            if (Tbhembra.Text != "")
                IdHembra = Program.IdHembraParaBuscarPartos;
            else
                IdHembra = 0;

            if (TbDificultad.Text == CbDificultad.Text)
                IdDificultad = Convert.ToInt32(CbDificultad.SelectedValue.ToString());
            else
                IdDificultad = 0;



            try
            {
                dgPartos.DataSource = PartosTA.FiltrarPartos(Idtipo, IdDificultad, IdHembra, vivos, muertos, Fdesde, FHasta, Program.IdExplotacion);
                dgPartos.Refresh();
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
            }
        }
        #endregion
        #region value changed
        private void CBTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            TbTipo.Text = CBTipo.Text;
        }

        private void CbDificultad_SelectedValueChanged(object sender, EventArgs e)
        {
            TbDificultad.Text = CbDificultad.Text;
        }

        private void dtphasta_ValueChanged(object sender, EventArgs e)
        {
            TbHasta.Text = dtphasta.Text;
        }

        private void dtpdesde_ValueChanged(object sender, EventArgs e)
        {
            TbDesde.Text = dtpdesde.Text;
        }
        #endregion

        private void TbVivos_TextChanged(object sender, EventArgs e)
        {
            bool es;
            if (TbVivos.Text != "")
            {
                es = Program.EsEntero(TbVivos.Text);           
               if (!es)
               {
                   Program.Informar("Escribe Solo numeros");
                   TbVivos.Text = TbVivos.Text.Substring(0, TbVivos.Text.Length - 1);
               }
           }

        }

        private void TbMuertos_TextChanged(object sender, EventArgs e)
        {
            bool es;
            if (TbMuertos.Text != "")
            {
                es = Program.EsEntero(TbMuertos.Text);

                if (!es)
                {
                    Program.Informar("Escribe Solo numeros");
                    TbMuertos.Text = TbMuertos.Text.Substring(0, TbMuertos.Text.Length - 1);
                }
            }
        }

        private void Partos_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;           
            Partos mForm = (Partos)FormFactory.Obtener(Formulario.Partos);          
            mForm.Hide();
        }

        private void pbAnadir_Click(object sender, EventArgs e)
        {
            Program.MostrarCursorEspera();
            InsertarPartoMultiples mForm = (InsertarPartoMultiples)FormFactory.Obtener(Formulario.InsertarParto);
            mForm.refrescar_pantalla();
            Program.OcultarCursorEspera();
            mForm.Show();
        }

        private void dgPartos_MouseDown(object sender, MouseEventArgs e)
        {
            ordenar_down(sender, e);
        }

        private void dgPartos_MouseUp(object sender, MouseEventArgs e)
        {
            ordenar_up(sender,e);
        }

    }
}


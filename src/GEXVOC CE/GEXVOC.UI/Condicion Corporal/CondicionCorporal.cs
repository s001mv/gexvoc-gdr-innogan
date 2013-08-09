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
    public partial class CondicionCorporal : GEXVOC.UI.Principal
    {
        public CondicionCorporal()
        {
            InitializeComponent();
        }

        public void refres_Pantalla()
        {
            //Datagrid
            dgCondicionesCorporal.DataSource = CondicionCorporalTA.Obtener(Program.IdExplotacion);
            dgCondicionesCorporal.Refresh();

            /************************************************************************/
            //Combo de especies            
            CbEspecie.DataSource = EspecieTA.ObtenerEspecies();
            CbEspecie.DisplayMember = "Descripcion";
            CbEspecie.ValueMember = "Id";            
            CbEspecie.Refresh();
            /************************************************************************/
            ////Combobox de Tipo          
            //CbTipo.DataSource = TiposCondicionesCorporales.ObtenerTipos(IdEspecie);
            //CbTipo.DisplayMember = "Descripcion";
            //CbTipo.ValueMember = "Id";
            ////CbTipo.Refresh();

            /************************************************************************/
        }

        public void refrescar_TbHembra(string nombre)
        {
            TbNombreVaca.Text = nombre;
        }

        private void PbBuscarHembra_Click(object sender, EventArgs e)
        {
            Program.queSeleccion = "HembrasParaBuscarCondicionesCorporales";
            Program.MostrarCursorEspera();
            Animal mForm = (Animal)FormFactory.Obtener(Formulario.Animal);
            mForm.RefrescarPantalla("todos");
            Program.OcultarCursorEspera();
            mForm.Show(); 
        }

        private void CondicionCorporal_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            CondicionCorporal mForm = (CondicionCorporal)FormFactory.Obtener(Formulario.CondicionCorporal);
            mForm.Hide();
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dtFecha.Text;
        }

        private void PbAandir_Click(object sender, EventArgs e)
        {
            InsertarCondicionCorporal mForm = (InsertarCondicionCorporal)FormFactory.Obtener(Formulario.InsertarCondicionCorporal);
            //mForm.refrescar_TbboxHembra(Program.NombreVacaInsertarCondicionesCorporales);
            mForm.Show();
        }

        private void CbEspecie_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CbTipo.DataSource = TiposCondicionesCorporales.ObtenerTipos(Convert.ToInt32(CbEspecie.SelectedValue.ToString()));
                CbTipo.DisplayMember = "Descripcion";
                CbTipo.ValueMember = "Id";
                CbTipo.Refresh();                
            }
            catch(Exception ex)
            {

            }
        }

        private void CbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            TbTipo.Text = CbTipo.Text;
        }

        private void PbBuscar_Click(object sender, EventArgs e)
        {
            int IdTipo;
            int IdHembra;
            string dia;
            string mes;
            string ano;
            string fecha = "";

            if(TbNombreVaca.Text!="")
                IdHembra=Program.IdHembraBuscaCondicionesCorporales;
            else
                IdHembra=0;

            if ((TbTipo.Text == CbTipo.Text) && (TbTipo.Text!=""))
                IdTipo = Convert.ToInt32(CbTipo.SelectedValue.ToString());
            else
                IdTipo = 0;

            if (textBox1.Text == dtFecha.Text)
            {
                dia = dtFecha.Value.Day.ToString();
                if (Convert.ToInt32(dia) < 10)
                    dia = "0" + dia;
                mes = dtFecha.Value.Month.ToString();
                if (Convert.ToInt32(mes) < 10)
                    mes = "0" + mes;
                ano = dtFecha.Value.Year.ToString();
                fecha= mes + "/" + dia + "/" + ano + " 0:00:00 ";
            }
            try
            {
                dgCondicionesCorporal.DataSource = CondicionCorporalTA.FiltrarCondiciones(IdTipo, IdHembra, fecha, Program.IdExplotacion);
                dgCondicionesCorporal.Refresh();
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
            }
            

        }
    }
}


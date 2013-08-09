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
    public partial class Controles : GEXVOC.UI.Principal
    {
        public Controles()
        {
            InitializeComponent();
        }
        public void Refrescar_Pantalla()
        {
            try
            {
                //Combo de especies            
                CbEspecie.DataSource = EspecieTA.ObtenerEspecies();
                CbEspecie.DisplayMember = "Descripcion";
                CbEspecie.ValueMember = "Id";
                CbEspecie.DisplayMember.Insert(2, "");
                CbEspecie.Refresh();


                //Combobox Estado Control 


                CbControl.DataSource = StatusControlTA.ObtenerStatusOrdeno();
                CbControl.DisplayMember = "Descripcion";
                CbControl.ValueMember = "Id";
                CbControl.Refresh();
                /******************************************************************************************************/

                CbOrdeño.DataSource = StatusOrdenoTA.ObtenerStatusOrdeno();
                CbOrdeño.DisplayMember = "Descripcion";
                CbOrdeño.ValueMember = "Id";
                CbOrdeño.Refresh();
                //Combobox Estado Ordeño

                DgControlesLecheros.DataSource = LechesTA.ObtenerControles(Program.IdExplotacion);
                DgControlesLecheros.Refresh();
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
                Program.Alertar("Error cargando datos");
            }

        }

        private void PbAnadir_Click(object sender, EventArgs e)
        {
            InsertarRegistroLeches mForm = (InsertarRegistroLeches)FormFactory.Obtener(Formulario.InsertarRegistroLeches);
            mForm.refrescar_Pantalla();
            mForm.Show();
        }

        private void Controles_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Controles mForm = (Controles)FormFactory.Obtener(Formulario.Controles);
            mForm.Refrescar_Pantalla();            
            mForm.Hide();   
        }

        private void PbBuscar_Click(object sender, EventArgs e)
        {
            int IdEstado=0;
            int IdControl=0;
            if (TbEstado.Text == CbOrdeño.Text)
                IdEstado = Convert.ToInt32(CbOrdeño.SelectedValue.ToString());
            if (TbControl.Text == CbControl.Text)
                IdControl = Convert.ToInt32(CbControl.SelectedValue.ToString());
            
            string dia;
            string mes;
            string ano;
            string fecha = "";
            if (TbFecha.Text != "")
            {
                dia = dtFecha.Value.Date.Day.ToString();
                if (Convert.ToInt32(dia) < 10)
                    dia = "0" + dia;
                mes = dtFecha.Value.Date.Month.ToString();
                if (Convert.ToInt32(mes) < 10)
                    mes = "0" + mes;
                ano = dtFecha.Value.Date.Year.ToString();
                fecha = mes + "/" + dia + "/" + ano + " 0:00:00 ";
                
            }
            DgControlesLecheros.DataSource = LechesTA.FiltrarLeches(fecha,IdControl,IdEstado,Program.IdExplotacion);
            DgControlesLecheros.Refresh();

        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            TbFecha.Text = dtFecha.Value.Date.ToString();
        }

        private void CbControl_SelectedValueChanged(object sender, EventArgs e)
        {
            TbControl.Text = CbControl.Text;
        }

        private void CbOrdeño_SelectedValueChanged(object sender, EventArgs e)
        {
            TbEstado.Text = CbOrdeño.Text;
        }
    }
}


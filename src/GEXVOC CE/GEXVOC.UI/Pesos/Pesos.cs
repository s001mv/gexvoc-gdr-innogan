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
    public partial class Pesos : GEXVOC.UI.Principal
    {
        public Pesos()
        {
            InitializeComponent();
        }
        public void refrescar()
        {
            //DgPesos
            dataGrid1.DataSource = PesosTA.ObtenerPesos(Program.IdExplotacion);
            dataGrid1.Refresh();
            /**************************************************************/
            //Combobox de momentos 
            CbMomento.DataSource = MomentoTA.Obtenermomentos();
            CbMomento.DisplayMember = "Descripcion";
            CbMomento.ValueMember = "Id";
            CbMomento.Refresh();
        }
        public void refrescar_TbboxHembra(string nombre)
        {
            tbHembra.Text = nombre;
        }
       

        private void pbBuscarHembra_Click(object sender, EventArgs e)
        {
            Program.queSeleccion = "AnimalBuscarPeso";
            Program.MostrarCursorEspera();
            Animal mForm = (Animal)FormFactory.Obtener(Formulario.Animal);
            mForm.RefrescarPantalla("todos");
            Program.OcultarCursorEspera();
            mForm.Show();
        }

        private void pbAnadir_Click(object sender, EventArgs e)
        {
            Program.MostrarCursorEspera();
            InsertarPeso mForm = (InsertarPeso)FormFactory.Obtener(Formulario.InsertarPeso);
            mForm.refrescar_Pantalla();
            Program.OcultarCursorEspera();
            mForm.Show();            
        }

        private void Pesos_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Pesos mForm = (Pesos)FormFactory.Obtener(Formulario.Pesos);
            mForm.Hide();
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            decimal Peso=0;
            if(Program.EsDecimal(TbPeso.Text))
                Peso=Convert.ToDecimal(TbPeso.Text.Replace(".", ","))/1;
                
            DataTable pesosfiltrados = PesosTA.FiltrarPesos(Program.IdAimalBuscaPesos, Convert.ToInt32(CbMomento.SelectedValue.ToString()),Peso,Program.IdExplotacion);
            dataGrid1.DataSource = pesosfiltrados;
        }
    }
}


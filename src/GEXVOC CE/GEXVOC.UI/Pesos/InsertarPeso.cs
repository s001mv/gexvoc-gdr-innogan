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
    public partial class InsertarPeso : GEXVOC.UI.Principal
    {
        public InsertarPeso()
        {
            InitializeComponent();
        }
        public void Refrescar_TbANimal(string nombre)
        {
            TbAnimal.Text = nombre;
        }
        public void refrescar_Pantalla()
        {
            TbAnimal.Text = "";
            //Combobox de momentos 
            cbMomento.DataSource = MomentoTA.Obtenermomentos();
            cbMomento.DisplayMember = "Descripcion";
            cbMomento.ValueMember = "Id";            
            cbMomento.Refresh();
            /****************************************************/
        }

        private void InsertarPeso_Closing(object sender, CancelEventArgs e)
        {
            DialogResult r = Program.Preguntar("¿Desea guardar el Peso?");
            if (r == DialogResult.Yes)
            {
                if (Validar())
                {
                    decimal Peso = Convert.ToDecimal(tbKg.Text.Replace(".", ","))/1;
                    PesosTA.InsertarNueva(Convert.ToInt32(cbMomento.SelectedValue.ToString()), Program.IdAnimalInsertarPeso, Peso, dtfecha.Value.Date);

                }
                else
                {
                    e.Cancel = true;
                    InsertarPeso mForm = (InsertarPeso)FormFactory.Obtener(Formulario.InsertarPeso);                    
                    mForm.Show();
                }
            }
            else
            {
                Program.MostrarCursorEspera();
                e.Cancel = true;
                InsertarPeso mForm = (InsertarPeso)FormFactory.Obtener(Formulario.InsertarPeso);
                Program.OcultarCursorEspera();
                mForm.Hide();  
            }
        }

        private bool Validar()
        {
            if (TbAnimal.Text == "")
            {
                Program.Informar("Seleccione Animal");
                return false;
            }
            if (!Program.EsDecimal(tbKg.Text))
            {
                Program.Informar("Escribe un numero decimal en el peso");
                return false;
            }
            else
            {
                return true;
            }
                 
        }

        private void PbBuscaAnimal_Click(object sender, EventArgs e)
        {
            Program.MostrarCursorEspera();
            Program.queSeleccion = "TodosParaPesos";
            Animal mForm = (Animal)FormFactory.Obtener(Formulario.Animal);
            mForm.RefrescarPantalla("todos");
            Program.OcultarCursorEspera();
            mForm.Show();
        }

        private void tbKg_TextChanged(object sender, EventArgs e)
        {
            //Program.EsEntero
        }
    }
}


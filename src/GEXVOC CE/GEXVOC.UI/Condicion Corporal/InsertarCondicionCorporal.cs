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
    public partial class InsertarCondicionCorporal : GEXVOC.UI.Principal
    {
        public InsertarCondicionCorporal()
        {
            InitializeComponent();
        }

        public void refrescar_TbboxHembra(string nombre)
        {
            TbAnimal.Text = nombre;
            refrescar_Combo();
        }
        public void refrescar_Combo()
        {
            DataTable especie;
            int IdEspecie;
            especie = AnimalTA.ObtenerEspecie(Program.IdHembraInsertarCondicionesCorporales);
            IdEspecie = Convert.ToInt32(especie.Rows[0]["IdEspecie"].ToString());
            //Combobox de momentos 

            CbTipo.DataSource = TiposCondicionesCorporales.ObtenerTipos(IdEspecie);
            CbTipo.DisplayMember = "Descripcion";
            CbTipo.ValueMember = "Id";
            //CbTipo.Refresh();
        }

        private void PbBuscarAnimal_Click(object sender, EventArgs e)
        {
            Program.queSeleccion = "HembraParaInsertarCondicionCorporal";
            Program.MostrarCursorEspera();
            Animal mForm = (Animal)FormFactory.Obtener(Formulario.Animal);
            mForm.RefrescarPantalla("H");
            Program.OcultarCursorEspera();
            mForm.Show();
        }
        private void InsertarCondicionCorporal_Closing(object sender, CancelEventArgs e)
        {

             DialogResult r = Program.Preguntar("¿Desea guardar La condicion corporal?");
             if (r == DialogResult.Yes)
             {
                 
                     if (validar())
                     {
                         CondicionCorporalTA.InsertarNueva(Convert.ToInt32(CbTipo.SelectedValue.ToString()), Program.IdHembraInsertarCondicionesCorporales, dtFecha.Value.Date);
                         e.Cancel = true;
                         InsertarCondicionCorporal mForm = (InsertarCondicionCorporal)FormFactory.Obtener(Formulario.InsertarCondicionCorporal);
                         mForm.Hide();
                     }
                     else
                     {                         
                         e.Cancel = true;
                         InsertarCondicionCorporal mForm = (InsertarCondicionCorporal)FormFactory.Obtener(Formulario.InsertarCondicionCorporal);
                         mForm.Show(); 
                     }
             }
             else
             {
                 e.Cancel = true;
                 InsertarCondicionCorporal mForm = (InsertarCondicionCorporal)FormFactory.Obtener(Formulario.InsertarCondicionCorporal);
                 mForm.Hide();
             }
        }
        private bool validar()
        {
            if (TbAnimal.Text == "")        
                 {
                     Program.Informar("Seleccione una hembra");                     
                     return false;
                 }
            else if (CbTipo.Items.Count<=0)
            {
                Program.Informar("Seleccione Tipo");                
                return false;
            }
            
            return true;
        }
    }
}


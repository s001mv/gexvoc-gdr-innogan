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
    public partial class BorrarAnimal : GEXVOC.UI.Principal
    {
        public BorrarAnimal()
        {
            InitializeComponent();
        }
        public void refrescarPantalla()
        {
            //Combo de Tipo De baja

            CbTipoBaja.DataSource = TipoBaja.ObtenerTiposDebaja();
            CbTipoBaja.DisplayMember = "Descripcion";
            CbTipoBaja.ValueMember = "Id";
            CbTipoBaja.Refresh();            
            /**********************************************************/
        }

        private void BorrarAnimal_Closing(object sender, CancelEventArgs e)
        {
            try
            {
                DialogResult r = Program.Preguntar("¿Desea confirmar que borrar el animal?");
                if (r == DialogResult.Yes)
                {
                    BajaTA.InsertarBaja(Convert.ToInt32(CbTipoBaja.SelectedValue.ToString()), Program.IdAnimal, TbDetalle.Text, dTFbaja.Value.Date);
                }
                else
                {

                }
                e.Cancel = true;
                Animal mFor1 = (Animal)FormFactory.Obtener(Formulario.Animal);
                mFor1.RefrescarPantalla("todos");                
                BorrarAnimal mForm = (BorrarAnimal)FormFactory.Obtener(Formulario.BorrarAnimal);
                mForm.Hide();
                mForm.Close();  
            }
            catch (Exception ex)
            {
                Program.Informar("no se pudo borrar el animal");
                Traza.Registrar(ex);
            }
        }
    }
}


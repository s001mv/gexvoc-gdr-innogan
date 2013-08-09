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
    public partial class SeleccionarLotes : GEXVOC.UI.Principal
    {
        public SeleccionarLotes()
        {
            InitializeComponent();
        }
        public void refrescar_Pantalla()
        {
            dglotes.DataSource = LotesTA.ObtenerLotes();
            dglotes.Refresh();
        }

        private void dglotes_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dglotes.DataSource;
                if (dt != null && dt.Rows.Count != 0)
                {

                    int Fila = dglotes.BindingContext[dglotes.DataSource].Position;
                    string Descripcion = dt.Rows[Fila]["Descripcion"].ToString();
                    Program.IdLote = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                    if (Program.dedonde == "PartosMultiples")
                    {
                        InsertarPartosMultiples mForm = (InsertarPartosMultiples)FormFactory.Obtener(Formulario.InsertarPartosMultiples);
                        mForm.refrescar_TbHembra(Descripcion);
                    }
                    else if (Program.dedonde == "Cubriciones")
                    {
                        InsertarCubricion mForm = (InsertarCubricion)FormFactory.Obtener(Formulario.InsertarCubricion);
                        mForm.refrescar_Lote(Descripcion);
                    }
                }
            }
            catch (Exception ex)
            {
                Program.Alertar("Error seleccionando");
                Traza.Registrar(ex);
            }
        }

        private void SeleccionarLotes_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            SeleccionarLotes mForm = (SeleccionarLotes)FormFactory.Obtener(Formulario.SeleccionarLotes);            
            mForm.Hide();
        }
    }
}


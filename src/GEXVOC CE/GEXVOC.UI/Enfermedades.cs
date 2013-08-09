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
    public partial class Enfermedades : GEXVOC.UI.Principal
    {
        public Enfermedades()
        {
            InitializeComponent();
        }
        public void Refrescar_Pantalla()
        {
            DgEnfermedades.DataSource = EnfermedadesTA.ObtenerTodasEnfermedades();
            DgEnfermedades.Refresh();
        }

        private void DgEnfermedades_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)DgEnfermedades.DataSource;
                if (dt != null && dt.Rows.Count != 0)
                {
                    if (Program.queSeleccion == "EnfermedadBuscarDiagnostico")
                    {
                        int Fila = DgEnfermedades.BindingContext[DgEnfermedades.DataSource].Position;
                        Program.IdEnfermedad = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                        string nombre = dt.Rows[Fila]["Descripcion"].ToString();
                        Diagnosticos mForm = (Diagnosticos)FormFactory.Obtener(Formulario.Diagnosticos);
                        mForm.refrescar_TboxEnfermedad(nombre);
                    }
                    else if (Program.queSeleccion == "EnfermedadParaInsertarDiagnostico")
                    {
                        int Fila = DgEnfermedades.BindingContext[DgEnfermedades.DataSource].Position;
                        Program.IdEnfermedad = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                        string nombre = dt.Rows[Fila]["Descripcion"].ToString();
                        InsertarDiagnosticoEnfermedad mForm = (InsertarDiagnosticoEnfermedad)FormFactory.Obtener(Formulario.InsertarDiagnosticoEnfermedad);
                        mForm.refrescar_TboxEnfermedad(nombre);
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void Enfermedades_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Enfermedades mForm = (Enfermedades)FormFactory.Obtener(Formulario.Enfermedades);
            mForm.Hide();
        }
    }
}


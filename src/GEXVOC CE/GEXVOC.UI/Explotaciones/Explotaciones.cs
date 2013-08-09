using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Data;
using GEXVOC.Core.Logic;
using System.IO;
namespace GEXVOC.UI
{
    public partial class Explotaciones : GEXVOC.UI.Principal
    {
        public Explotaciones()
        {
            InitializeComponent();
        }

        private void Explotaciones_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Explotaciones mForm = (Explotaciones)FormFactory.Obtener(Formulario.Explotaciones);           
            mForm.Hide();
        }
        public void Refrescar_Pantalla()
        {
            DgExplotaciones.DataSource = ExplotacionesTA.ObtenerTodasExplotaciones();
            DgExplotaciones.Refresh();
        }

        private void Explotaciones_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Configurador.BD))
            {
                MessageBox.Show("No tiene base de datos creada, haga click en descargar");
                Sincronizar mForm = (Sincronizar)FormFactory.Obtener(Formulario.Sincronizar);
                mForm.Show();                
            }           
        }

        private void DgExplotaciones_MouseUp(object sender, MouseEventArgs e)
        {
            ordenar_up(sender,e);
        }

        private void DgExplotaciones_MouseDown(object sender, MouseEventArgs e)
        {
            ordenar_down(sender,e);
        }


        #region seleccion de Explotacion
        //Seleccion de aNimales
        private void SeleccionExplotacion_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)DgExplotaciones.DataSource;
                if (dt != null && dt.Rows.Count != 0)
                {
                    int Fila = DgExplotaciones.BindingContext[DgExplotaciones.DataSource].Position;
                    Program.Nombre = dt.Rows[Fila]["Nombre"].ToString();
                    Program.IdExplotacion = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                    ActualizaEstado();
                }
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
            }
        }
        /*********************************/
        #endregion
    }
}


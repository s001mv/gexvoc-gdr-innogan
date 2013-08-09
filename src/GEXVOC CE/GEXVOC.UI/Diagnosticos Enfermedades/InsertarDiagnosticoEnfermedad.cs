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
    public partial class InsertarDiagnosticoEnfermedad : GEXVOC.UI.Principal
    {
        public InsertarDiagnosticoEnfermedad()
        {
            InitializeComponent();
        }
        public void refrescar_Pantalla()
        {
            TbAnimal.Text = "";
            TbEnfermedad.Text = "";
            //comboboxInseminador
            CbInseminador.DataSource = VeterinarioTA.ObtenerVeterinarios(Program.IdExplotacion);
            CbInseminador.DisplayMember = "NombreComleto";
            CbInseminador.ValueMember = "Id";
            CbInseminador.Refresh();
        }

        public void Refrescar_TbANimal(string nombre)
        {
            TbAnimal.Text = nombre;
        }
        public void refrescar_TboxEnfermedad(string nombre)
        {
            TbEnfermedad.Text = nombre;
        }
        private void InsertarDiagnosticoEnfermedad_Closing(object sender, CancelEventArgs e)
        {
            try
            {
                DialogResult r = Program.Preguntar("¿Desea guardar el diagnostico de la enfermedad?");
                if (r == DialogResult.Yes)
                {
                    if (TbAnimal.Text != "")
                    {
                        
                        int? Veterinario;
                        if (TBPersonal.Text != "")
                            Veterinario = Convert.ToInt32(CbInseminador.SelectedValue.ToString());
                        else
                            Veterinario = null;
                        
                        DiagnosticosEnfermedades.InsertarNueva(Program.IdAnimalInsertarDiagnosticos, Program.IdEnfermedad, Veterinario, tbdiagnostico.Text, DtFecha1.Value.Date);
                        InsertarDiagnosticoEnfermedad mForm = (InsertarDiagnosticoEnfermedad)FormFactory.Obtener(Formulario.InsertarDiagnosticoEnfermedad);
                        e.Cancel = true;
                        mForm.Hide();
                    }
                    else
                    {
                        Program.Informar("Seleccione Animal");
                        e.Cancel = true;
                        InsertarDiagnosticoEnfermedad mForm = (InsertarDiagnosticoEnfermedad)FormFactory.Obtener(Formulario.InsertarDiagnosticoEnfermedad);
                        mForm.Show();
                    }
                }
                else
                {
                    e.Cancel = true;
                    InsertarDiagnosticoEnfermedad mForm = (InsertarDiagnosticoEnfermedad)FormFactory.Obtener(Formulario.InsertarDiagnosticoEnfermedad);
                    mForm.Hide();
                    Diagnosticos mForm2 = (Diagnosticos)FormFactory.Obtener(Formulario.Diagnosticos);
                    mForm.refrescar_Pantalla();
                    Program.OcultarCursorEspera();
                    mForm2.Show();
                }
            }            
            catch (Exception ex)
            {
                Traza.Registrar(ex);
                Program.Alertar("No se pudo guardar");
                e.Cancel = true;
                InsertarDiagnosticoEnfermedad mForm = (InsertarDiagnosticoEnfermedad)FormFactory.Obtener(Formulario.InsertarDiagnosticoEnfermedad);
                mForm.Hide();
            }
           
        }

        private void PbBuscaAnimal_Click(object sender, EventArgs e)
        {
            Program.MostrarCursorEspera();
            Program.queSeleccion = "TodosParaDiagnosticoEnfermedad";            
            Animal mForm = (Animal)FormFactory.Obtener(Formulario.Animal);
            mForm.RefrescarPantalla("todos");
            Program.OcultarCursorEspera();
            mForm.Show();
        }
        private void PbEnfermedad_Click(object sender, EventArgs e)
        {
            Program.queSeleccion = "EnfermedadParaInsertarDiagnostico";
            Program.MostrarCursorEspera();
            Enfermedades mForm = (Enfermedades)FormFactory.Obtener(Formulario.Enfermedades);
            mForm.Refrescar_Pantalla();
            Program.OcultarCursorEspera();
            mForm.Show();
        }
        private void PBPersonal_Click(object sender, EventArgs e)
        {

        }
        private void CbInseminador_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBPersonal.Text = CbInseminador.Text;
        }
    }
}


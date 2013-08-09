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
    public partial class InsertarInseminacion : GEXVOC.UI.Principal
    {
        public InsertarInseminacion()
        {
            InitializeComponent();
        }

        #region al cerrar el formulario
        private void InsertarInseminacion_Closing(object sender, CancelEventArgs e)
        {
            DialogResult r = Program.Preguntar("¿Desea guardar la inseminacion?");
            if (r == DialogResult.Yes)
            {
                if (Validar())
                {
                    InseminacionesTA.InsertarNueva(Convert.ToInt32(CbMachos.SelectedValue.ToString()),Program.IdAnimal,Convert.ToInt32(Cbtipo.SelectedValue.ToString()),Convert.ToInt32(CbInseminador.SelectedValue.ToString()),Program.Embrion,TbDosis.Text,dtFecha.Value.Date);
                    Program.Informar("Inseminacion guardada correctamente");
                    e.Cancel = true;
                    Program.MostrarCursorEspera();
                    Inseminaciones mForm1 = (Inseminaciones)FormFactory.Obtener(Formulario.Inseminaciones);
                    mForm1.RefrescarPantalla();
                    InsertarInseminacion mForm = (InsertarInseminacion)FormFactory.Obtener(Formulario.InsertarInseminacion);
                    Program.OcultarCursorEspera();
                    mForm.Hide();
                }
                else
                {
                    e.Cancel = true;
                    InsertarInseminacion mForm = (InsertarInseminacion)FormFactory.Obtener(Formulario.InsertarInseminacion);
                    mForm.Show();
                }
            }
            else
            {
                e.Cancel = true;
                InsertarInseminacion mForm = (InsertarInseminacion)FormFactory.Obtener(Formulario.InsertarInseminacion);
                mForm.Hide();
            }

        }
        #endregion

        #region refrescar
        public void refrescar_pantalla()            
        {
            try
            {                
                /****************************************************************/
                //ComboBox de Tipo
                Cbtipo.DataSource = TipoInseminacionTA.ObtenerTiposInseminaciones();
                Cbtipo.DisplayMember = "Descripcion";
                Cbtipo.ValueMember = "Id";
                Cbtipo.Refresh();
                /****************************************************************/
                //ComboBox de Machos
                CbMachos.DataSource = AnimalTA.ObtenerAnimalesMachos(Program.IdExplotacion);
                CbMachos.DisplayMember = "Nombre";
                CbMachos.ValueMember = "Id";
                CbMachos.Refresh();
                /****************************************************************/
                //Combobox de Inseminador
                CbInseminador.DataSource = VeterinarioTA.ObtenerVeterinarios(Program.IdExplotacion);
                CbInseminador.DisplayMember = "NombreComleto";
                CbInseminador.ValueMember = "Id";
                CbInseminador.Refresh();
                /****************************************************************/
                TbHembra.Text = "";
                TbEmbrion.Text = "";
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
            }
        }
        public void refrescar_TbHembra(string nombre)
        {
            TbHembra.Text = nombre;
        }
        public void refrescar_TbEmbrion(string nombre)
        {
            TbEmbrion.Text = nombre;
        }

        #endregion
        
        #region combobox tipo cambia
        private void Cbtipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Cbtipo.SelectedValue.ToString() == "3")
            {

                TbEmbrion.Enabled = true;
                TbDosis.Enabled = false;
                pictureBox1.Enabled = true;
            }
            else
            {
                pictureBox1.Enabled = false;
                TbEmbrion.Enabled = false;
                TbDosis.Enabled = true;                
            }
        }
        #endregion

        #region validar
        private bool Validar()
        {
            if (TbHembra.Text != "")
            {
                //Logica No puede ser el mismo día
                #region mismo dia
                //No puede haber varias inseminaciones el mismo día
                /************************************************************************/
                DataTable dtNum = InseminacionesTA.ObtenerInseminacionesDiaIdVaca(dtFecha.Value.Date, Program.IdAnimal);
                if (dtNum.Rows.Count > 0)
                {
                    Program.Informar("No puede haber varías inseminaciones el mismo día.");
                    return false;
                }
                #endregion
                //No puede ser hasta x días despues del parto
                #region x días despues de parto
                //Obtengo la especie del animal para buscar la parametrizacion
                DataTable especies = AnimalTA.ObtenerEspecie(Program.IdAnimal);
                string especie = especies.Rows[0]["Especie"].ToString();
                string clave = "PeriodoInseminacionPostParto_" + especie;
                /**************************************************************************/
                //No se puede inseminar hasta X dias despues de un parto previo
                /******************************************************************/
                double PeriodoInseminacionPostParto = Convert.ToDouble(Parametrizacion.ObtenerParametrizacionPorClave(clave));
                if (PartosTA.ExistePartoEntreFechasIdVaca(dtFecha.Value.AddDays(-PeriodoInseminacionPostParto).Date,
                                                            dtFecha.Value.Date,
                                                            Program.IdAnimal).Rows.Count > 0)
                {
                    //TODO: Mensaje error
                    Program.Informar("Non se pode inseminar ata ó número de días parametrizado, despois dun parto.");
                    return false;
                }
                /******************************************************************/
                #endregion

                //no puede haber un parto o un aborto posterior
                #region parto aborto posterior
                //No se pueden Modificar/Eliminar inseminaciones con parto posterior
                /******************************************************************/
                if (PartosTA.ObtenerPartosPosterioresAFechaIdVaca(dtFecha.Value.Date, Program.IdAnimal).Rows.Count > 0)
                {
                    //TODO: Mensaje error
                    Program.Informar("No puede agregar una inseminacion a una vaca que tenga un parto posterior");
                    return false;
                }
                /******************************************************************/
                //No se puede insertar inseminacines con aborto posterior
                if (AbortosTA.ObtenerAbortosDesdeFechaIdVaca(dtFecha.Value.Date, Program.IdAnimal).Rows.Count > 0)
                {
                    Program.Informar("No puede agregar una inseminacion a una vaca que tenga un aborto posterior");
                    return false;
                }
                #endregion

                //El animal está en una cubricion sin fecha fin o en una cubricion
                #region cubricion abierta
                DataTable cubricionesAbiertas = CubricionTA.ObtenerCubricionesAbiertas(Program.IdHembrarParaInsertarPartos);
                if (cubricionesAbiertas.Rows.Count > 0)
                {
                    Program.Informar("La hembra: " + Program.NombreVacaPartos + " tiene una cubricion, pero se encuentra sin fecha fin, el proceso no puede continuar sin una fecha fin válida.");
                    return false;
                }     
                #endregion

                //no puede haber una inseminacion posterior
                #region inseminacion posterior
                /******************************************************************/
                //No se puede insertar inseminacines con inseminacion posterior
                if (InseminacionesTA.ObtenerInseminacionesDesdeFechaIddVaca(dtFecha.Value.Date, Program.IdAnimal).Rows.Count > 0)
                {
                    Program.Informar("Tiene Inseminaciones Posteriores");
                    return false;
                }
                #endregion

                #region dosis
                /******************************************************************/
                //TODO:Validar Dosis
                /******************************************************************/
                if (Cbtipo.Text == "INSEMINACIÓN ARTIFICIAL")
                {
                    if (TbDosis.Text=="")
                    {
                        Program.Informar("el campos dosis está vacio");
                        return false;
                    }

                    if (!Program.EsEntero(TbDosis.Text))
                    {
                        Program.Informar("el campo dosis debe ser numerico");
                        return false;
                    }
                }
                /******************************************************************/
                #endregion

                #region inseminador
                if (CbInseminador.Text == "")
                {
                    Program.Informar("no se puede inseminar porque no hay personal");
                    return false;
                }
                #endregion

                return true;
            }
            else
            {
                Program.Informar("Seleccione la hembra que desea inseminar");
                return false;
            }

           
        }
        #endregion

        #region mostrar formulario animales
        private void PictureBoxBuscarHembra_Click(object sender, EventArgs e)
        {
            Program.queSeleccion = "Hembras";
            Program.MostrarCursorEspera();
            Animal mForm = (Animal)FormFactory.Obtener(Formulario.Animal);
            mForm.RefrescarPantalla("H");
            Program.OcultarCursorEspera();
            mForm.Show(); 
        }       
        private void PictureboxBuscaMachos_Click(object sender, EventArgs e)
        {
            Program.MostrarCursorEspera();
            Animal mForm = (Animal)FormFactory.Obtener(Formulario.Animal);
            mForm.RefrescarPantalla("M");
            Program.OcultarCursorEspera();
            mForm.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)//Busca Embriones
        {
            Program.queSeleccion = "Embriones";
            Program.MostrarCursorEspera();
            Animal mForm = (Animal)FormFactory.Obtener(Formulario.Animal);
            mForm.RefrescarPantalla("H");
            Program.OcultarCursorEspera();
            mForm.Show(); 
        }
        #endregion


    }
}


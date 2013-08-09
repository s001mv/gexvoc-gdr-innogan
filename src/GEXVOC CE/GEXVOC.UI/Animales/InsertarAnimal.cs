using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Data;
using GEXVOC.Core.Logic;
using GEXVOC.Core;


namespace GEXVOC.UI
{
    public partial class InsertarAnimal : GEXVOC.UI.Principal
    {
        bool DIBvale = false;
        bool CrotalVale = false;
        bool Nombrevale = false;
        bool TatuajeVale = false;       
        public InsertarAnimal()
        {
            InitializeComponent();
        }
        #region Refrescar
        public void RefrescarPantalla()
        {            
            //Combo de especies
            CbEspecie.DataSource = EspecieTA.ObtenerEspecies();
            CbEspecie.DisplayMember = "Descripcion";
            CbEspecie.ValueMember = "Id";
            CbEspecie.Refresh();
            /****************************************************/ 
            //Combo de Estado
            CBEstado.DataSource = EstadoTA.ObtenerEstados();
            CBEstado.DisplayMember = "Descripcion";
            CBEstado.ValueMember = "Id";
            CBEstado.Refresh();
            /****************************************************/  
            //Combo de Talla al nacimiento
            CBTnacimiento.DataSource = TallaTA.ObtenerTallas();
            CBTnacimiento.DisplayMember = "Descripcion";
            CBTnacimiento.ValueMember = "Id";
            CBEstado.Refresh();
            /****************************************************/  
            //Combo de Conformacion Actual
            CBConformacionActual.DataSource = ConformacionActualTAcs.ObtenerConformaciones();
            CBConformacionActual.DisplayMember = "Descripcion";
            CBConformacionActual.ValueMember = "Id";
            CBConformacionActual.Refresh();
            /****************************************************/
            //Combo de Tipo de Alta
            CbTAlta.DataSource = TipoAltaTA.ObtenerTiposDeAlta();
            CbTAlta.DisplayMember = "Descripcion";
            CbTAlta.ValueMember = "Id";
            CbTAlta.Refresh();
            /****************************************************/
            //Borrar Txt            
            //TbCrotal.Text = "";
            //TbDetalle.Text = "";
            //TbDIB.Text = "";
            //TbExplotacion.Text = "";
            //TbTatuaje.Text = "";
            //TbNombre.Text = "";
            /****************************************************/
        }
        #endregion

        private void InsertarAnimal_Closing(object sender, CancelEventArgs e)
        {
            DialogResult r = Program.Preguntar("¿Desea guardar el animal?");
            if (r == DialogResult.Yes)
            {
                if (validar())
                {
                    MessageBox.Show("vale");
                    e.Cancel = true;
                    int IdExplotacion = Program.IdExplotacion;
                    AnimalTA.InsertarAnimalNuevo(Convert.ToInt32(CBRaza.SelectedValue.ToString()),Convert.ToInt32(CBTnacimiento.SelectedValue.ToString()),Convert.ToInt32(CBConformacionActual.SelectedValue.ToString()), TbDIB.Text, IdExplotacion, TbCrotal.Text, TbTatuaje.Text, TbNombre.Text, dateTimePicker1.Value.Date, CbSexo.Text,Convert.ToInt32(CBEstado.SelectedValue.ToString()));
                    AltaTa.InsertarAltaNueva(Convert.ToInt32(CbTAlta.SelectedValue.ToString()), Convert.ToInt32(AnimalTA.CalcularMaxId()) - 1, TbDetalle.Text, DTFalta.Value.Date);

                    InsertarAnimal mForm = (InsertarAnimal)FormFactory.Obtener(Formulario.InsertarAnimal);
                    mForm.Hide();
                    mForm.Close();  
                }
                else
                {
                    MessageBox.Show("no vale");
                    e.Cancel = true;
                    InsertarAnimal mForm2 = (InsertarAnimal)FormFactory.Obtener(Formulario.InsertarAnimal);
                    mForm2.RefrescarPantalla();
                }
            }
            else
            {
                e.Cancel = true;
                InsertarAnimal mForm2 = (InsertarAnimal)FormFactory.Obtener(Formulario.InsertarAnimal);
                mForm2.Hide();
                mForm2.Close();  
            }
        }

        private void CbEspecie_SelectedValueChanged(object sender, EventArgs e)
        {            
            //Combobox RAza
            try
            {
                CBRaza.DataSource = RazaTA.ObtenerRazasPorEspecie(Convert.ToInt32(CbEspecie.SelectedValue));
                CBRaza.DisplayMember = "Descripcion";
                CBRaza.ValueMember = "Id";
                CBRaza.Refresh();
                if (CbEspecie.Text == "BOVINA")
                    LDIB.Text = "CIB";
                else if (CbEspecie.Text == "CAPRINA")
                    LDIB.Text = "CIC";
                else if (CbEspecie.Text == "OVINA")
                    LDIB.Text = "CIO";
            }
            catch(Exception ex)
            {
                Traza.Registrar(ex);
            }

            /**************/
        }

        #region eventos TextChanged
        private void TbDIB_TextChanged(object sender, EventArgs e)
        {
            bool es;
            if (TbDIB.Text != "")
            {
                es = Program.EsVarCharCorrecto(TbDIB.Text);
            
                if (!es)
                {
                    Program.Informar("Escribe solo letras o numeros");
                    TbDIB.Text = TbDIB.Text.Substring(0, TbDIB.Text.Length - 1);
                    DIBvale = false;
                }
                else if (TbDIB.Text.Length > 14)
                {
                    Program.Informar("Es demasiado largo");
                    DIBvale = false;
                }
                else
                {

                    DIBvale = true;
                }
            }

        }
        private void TbCrotal_TextChanged(object sender, EventArgs e)
        {
            bool es;
            if (TbCrotal.Text != "")
            {
                es = Program.EsVarCharCorrecto(TbCrotal.Text);            
                if (!es)
                {
                    Program.Informar("Escribe solo letras o numeros");
                    TbCrotal.Text = TbCrotal.Text.Substring(0, TbCrotal.Text.Length - 1);
                    CrotalVale = false;
                }
                else if (TbCrotal.Text.Length > 4)
                {
                    Program.Informar("Es demasiado largo");
                    CrotalVale = false;
                }
                else
                {
                    CrotalVale = true;
                }
            }
        }
        private void TbNombre_TextChanged(object sender, EventArgs e)
        {
            bool es;
            if (TbNombre.Text != "")
            {
                es = Program.EsVarCharCorrecto(TbNombre.Text);

                if (!es)
                {
                    Program.Informar("Escribe solo letras o numeros");
                    TbNombre.Text = TbNombre.Text.Substring(0, TbNombre.Text.Length - 1);
                    Nombrevale = false;
                }
                else if (TbNombre.Text.Length > 50)
                {
                    Program.Informar("Es demasiado largo");
                    Nombrevale = false;
                }
                else
                {
                    Nombrevale = true;
                }
            }
        }
        private void TbTatuaje_TextChanged(object sender, EventArgs e)
        {
            bool es;
            if (TbTatuaje.Text != "")
            {
                es = Program.EsVarCharCorrecto(TbTatuaje.Text);
                if (!es)
                {
                    Program.Informar("Escribe solo letras o numeros");
                    TbTatuaje.Text = TbTatuaje.Text.Substring(0, TbTatuaje.Text.Length - 1);
                    TatuajeVale = false;
                }
                else if (TbTatuaje.Text.Length > 7)
                {
                    Program.Informar("Es demasiado largo");
                    TatuajeVale = false;
                }
                else
                {
                    TatuajeVale = true;
                }
            }
        }
        private void TbDetalle_TextChanged(object sender, EventArgs e)
        {
           /* bool es;
            es = Program.EsVarCharCorrecto(TbDetalle.Text);
            if (!es)
                Program.Informar("Escribe solo letras o numeros");
            if (TbDetalle.Text > 7)
                Program.Informar("Es demasiado largo");*/
        }
        #endregion

        private bool validar()
        {
            if ((DIBvale) && (CrotalVale) && (Nombrevale) && (TatuajeVale))
            {
                if (CbEspecie.Text == "BOVINA")
                    if (ValidarCIB(TbDIB.Text))
                        return true;
                    else
                        return false;
                else
                    return true;
            }
            else
                return false;
        }
        bool ValidarCIB(string cib)
        {
            if (string.IsNullOrEmpty(cib) || cib.Length != 14)
            {
                Program.Informar("El CIB debe ser un código de 14 caracteres");
                return false;
            }
            else
            {
                int X, A, B, C, D, E, F, G, H, I, J;

                if (!Cadenas.IsLetter(cib, 0, 2))
                {
                    Program.Informar("Los 2 primeros caracteres del CIB deben ser el código del pais en letras.");
                    return false;
                }
                if (!Cadenas.IsDigit(cib, 2, 12))
                {
                    Program.Informar("Los 12 últimos caracteres del CIB deben ser el dígitos.");
                    return false;
                }


                int? DC = null;

                ///Inicializo las variables para los calculos
                X = int.Parse(cib.Substring(3, 1));
                A = int.Parse(cib.Substring(4, 1));
                B = int.Parse(cib.Substring(5, 1));
                C = int.Parse(cib.Substring(6, 1));
                D = int.Parse(cib.Substring(7, 1));
                E = int.Parse(cib.Substring(8, 1));
                F = int.Parse(cib.Substring(9, 1));
                G = int.Parse(cib.Substring(10, 1));
                H = int.Parse(cib.Substring(11, 1));
                I = int.Parse(cib.Substring(12, 1));
                J = int.Parse(cib.Substring(13, 1));


                if (int.Parse(cib.Substring(6, 4)) >= 200)
                    DC = Cadenas.UltimoDigito((A * 1 + B * 2 + C * 3 + D * 4 + E * 5 + F * 6 + G * 7 + H * 8 + I * 9 + J).ToString());
                if (int.Parse(cib.Substring(6, 4)) < 200)
                    DC = Cadenas.UltimoDigito((A + B + C + D + E + F + G + H + I + J + 8).ToString());

                if (!DC.HasValue)
                {
                    Program.Informar("No ha sido posible calcular el Dígito de control");
                    return false;
                }
                if (DC.HasValue && DC.Value != X)
                {
                    Program.Informar("El Dígito de control propocionado (" + X.ToString() + ") no es correcto, el DC debería ser: " + DC.Value.ToString());
                    return false;
                }
                return true;
            }
        }

        
        private void InsertarAnimal_Closed(object sender, EventArgs e)
        {
           
        }
    }
}


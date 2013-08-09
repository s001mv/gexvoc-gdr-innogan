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
    public partial class Animal : GEXVOC.UI.Principal
    {
        public Animal()
        {
            InitializeComponent();
        }
        bool DIBvale;
        bool CrotalVale;
        bool Nombrevale;
        bool TatuajeVale;
        #region actualizar pantalla
        public void RefrescarPantalla(string que)
        {
            if (que == "todos")
            {
                //Datagrid de Animales
                DataTable animales = AnimalTA.ObtenerAnimalesConRazaYEspecie(Program.IdExplotacion);                
                DgAnimales.DataSource = animales;
                DgAnimales.Refresh();
                CbSexo.Enabled = true;
            }
            else if(que == "H")
            {
                DataTable animales = AnimalTA.ObtenerAnimalesHembras(Program.IdExplotacion);
                DgAnimales.DataSource = animales;
                DgAnimales.Refresh();
                CbSexo.Text = "H";
                CbSexo.Enabled = false;
            }
            else if (que == "M")
            {
                DataTable animales = AnimalTA.ObtenerAnimalesMachos(Program.IdExplotacion);
                DgAnimales.DataSource = animales;
                DgAnimales.Refresh();
                CbSexo.Enabled = false;
            }
            /**********************************************************/           
            //Combo de especies
            CbEspecie.DataSource = EspecieTA.ObtenerEspecies();
            CbEspecie.DisplayMember = "Descripcion";
            CbEspecie.ValueMember = "Id";
            CbEspecie.DisplayMember.Insert(2, "");
            CbEspecie.Refresh();
            /**********************************************************/
        }
        #endregion

        #region Botones Insertar borrar y buscar
        private void Insertar_Click(object sender, EventArgs e)
        {
            Program.MostrarCursorEspera();
            InsertarAnimal mForm = (InsertarAnimal)FormFactory.Obtener(Formulario.InsertarAnimal);
            mForm.RefrescarPantalla();
            Program.OcultarCursorEspera();
            mForm.Show();            
        }
        private void Borrar_Click(object sender, EventArgs e)
        {
            if (Program.NombreVaca != "")
            {
                DataTable animal = AnimalTA.EsModificable(Program.IdAnimal);
                if(animal.Rows[0]["Modificable"].ToString()=="True")
                {
                DialogResult r = Program.Preguntar("¿Desea Borrar el animal?");
                if (r == DialogResult.Yes)
                {
                    Program.MostrarCursorEspera();
                    BorrarAnimal mForm = (BorrarAnimal)FormFactory.Obtener(Formulario.BorrarAnimal);
                    mForm.refrescarPantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();
                }
                }
                else
                {
                    Program.Informar("El animal seleccionado no se puede eliminar");
                }
            }
            else
            {
                Program.Informar("Seleccione el Animal a dar de baja");
            }
        }
        private void buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string diadesde;
                string mesdesde;
                string anodesde;
                string FechaNac = "";
                if (TbFechaNac.Text == DtFNac.Text)
                {
                    diadesde = DtFNac.Value.Date.Day.ToString();
                    if (Convert.ToInt32(diadesde) < 10)
                        diadesde = "0" + diadesde;
                    mesdesde = DtFNac.Value.Date.Month.ToString();
                    if (Convert.ToInt32(mesdesde) < 10)
                        mesdesde = "0" + mesdesde;
                    anodesde = DtFNac.Value.Date.Year.ToString();
                    FechaNac = mesdesde + "/" + diadesde + "/" + anodesde + " 0:00:00 ";
                    // Fdesde = Convert.ToDateTime(dtpdesde.Value.Date.ToString()).ToString();
                }
                int IdRaza;
                int IdEspecie;
                
                if(TbRaza.Text=="")
                    IdRaza = 0;
                else
                    IdRaza=Convert.ToInt32(CbRaza.SelectedValue.ToString());

                if (TbEspecie.Text == "")
                    IdEspecie = 0;
                else
                    IdEspecie = Convert.ToInt32(CbEspecie.SelectedValue.ToString());

               
                DgAnimales.DataSource = AnimalTA.FiltrarAnimales(TbCIB.Text, CbSexo.Text, TbCrotal.Text, TbTatuaje.Text, FechaNac, TbNombre.Text, IdRaza, IdEspecie,Program.IdExplotacion);
                DgAnimales.Refresh();
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
            }

        }
        #endregion

        private void Animal_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Animal mForm = (Animal)FormFactory.Obtener(Formulario.Animal);
            mForm.Hide();
            mForm.Close();            
        }

        #region eventos textChanged
        private void TbCIB_TextChanged(object sender, EventArgs e)
        {
            bool es;
            if (TbCIB.Text != "")
            {
                es = Program.EsVarCharCorrecto(TbCIB.Text);
                if (!es)
                {
                    Program.Informar("Escribe solo letras o numeros");
                    DIBvale = false;
                }
                else if (TbCIB.Text.Length > 14)
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
        #endregion

        #region eventos combobox
        private void CbEspecie_SelectedValueChanged(object sender, EventArgs e)
        {
            //Combobox RAza
            try
            {
                TbEspecie.Text = CbEspecie.Text;                
                CbRaza.DataSource = RazaTA.ObtenerRazasPorEspecie(Convert.ToInt32(CbEspecie.SelectedValue));
                CbRaza.DisplayMember = "Descripcion";
                CbRaza.ValueMember = "Id";
                CbRaza.Refresh();
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
            }
            /**************/
        }
        private void CbRaza_SelectedValueChanged(object sender, EventArgs e)
        {
            TbRaza.Text = CbRaza.Text;
        }
        #endregion

        #region Ordenar
        private void DgAnimales_MouseDown(object sender, MouseEventArgs e)
        {
           Principal.ordenar_down(sender, e);
        }

        private void DgAnimales_MouseUp(object sender, MouseEventArgs e)
        {
            Principal.ordenar_up(sender, e);
        }
        #endregion

        #region seleccion de animales
        //Seleccion de aNimales
        private void DgAnimales_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)DgAnimales.DataSource;
                if (dt != null && dt.Rows.Count != 0)
                {
                    if (Program.queSeleccion == "Hembras")
                    {
                        int Fila = DgAnimales.BindingContext[DgAnimales.DataSource].Position;
                        Program.NombreVaca = dt.Rows[Fila]["Nombre"].ToString();
                        Program.IdAnimal = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                        InsertarInseminacion mForm = (InsertarInseminacion)FormFactory.Obtener(Formulario.InsertarInseminacion);
                        mForm.refrescar_TbHembra(Program.NombreVaca);
                    }
                    else if (Program.queSeleccion == "Embriones")
                    {
                        int Fila = DgAnimales.BindingContext[DgAnimales.DataSource].Position;
                        Program.NombreEmbrion = dt.Rows[Fila]["Nombre"].ToString();
                        Program.Embrion= Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                        InsertarInseminacion mForm = (InsertarInseminacion)FormFactory.Obtener(Formulario.InsertarInseminacion);
                        mForm.refrescar_TbEmbrion(Program.NombreEmbrion);
                    }
                    else if (Program.queSeleccion == "HembrasParaDiagnostico")
                    {
                        int Fila = DgAnimales.BindingContext[DgAnimales.DataSource].Position;
                        Program.NombreEmbrion = dt.Rows[Fila]["Nombre"].ToString();
                        Program.Embrion = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                        DiagnosticoGestacion mForm = (DiagnosticoGestacion)FormFactory.Obtener(Formulario.DiagnosticoGestacion);
                        mForm.refrescar_TbHembra(Program.NombreEmbrion);
                    }
                    else if (Program.queSeleccion == "HembrasInsertarDiagnostico")
                    {
                        int Fila = DgAnimales.BindingContext[DgAnimales.DataSource].Position;
                        Program.NombreEmbrion = dt.Rows[Fila]["Nombre"].ToString();
                        Program.IdhembraParaDiagnostico = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));                       
                        InsertarDiagnosticoGestacion mForm = (InsertarDiagnosticoGestacion)FormFactory.Obtener(Formulario.InsertarDiagnosticoGestacion);
                        mForm.refrescar_TbHembra(Program.NombreEmbrion);                                                                       
                    }
                    else if (Program.queSeleccion == "HembrasParaPartos")
                    {
                        int Fila = DgAnimales.BindingContext[DgAnimales.DataSource].Position;
                        Program.NombreVacaPartos = dt.Rows[Fila]["Nombre"].ToString();
                        Program.IdHembraParaBuscarPartos = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                        Partos mForm = (Partos)FormFactory.Obtener(Formulario.Partos);
                        mForm.Refresca_TexboxHembra(Program.NombreVacaPartos);
                    }
                    else if (Program.queSeleccion == "HembrasInsertarParto")
                    {
                        int Fila = DgAnimales.BindingContext[DgAnimales.DataSource].Position;
                        Program.NombreVacaPartos = dt.Rows[Fila]["Nombre"].ToString();
                        Program.IdHembrarParaInsertarPartos = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                        InsertarPartoMultiples mForm = (InsertarPartoMultiples)FormFactory.Obtener(Formulario.InsertarParto);
                        mForm.refrescar_TbHembra(Program.NombreVacaPartos);
                    }
                    else if (Program.queSeleccion == "HembrasParaBuscarCondicionesCorporales")
                    {
                        int Fila = DgAnimales.BindingContext[DgAnimales.DataSource].Position;
                        Program.NombreVacaCondicionesCorporales = dt.Rows[Fila]["Nombre"].ToString();
                        Program.IdHembraBuscaCondicionesCorporales = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                        CondicionCorporal mForm = (CondicionCorporal)FormFactory.Obtener(Formulario.CondicionCorporal);
                        mForm.refrescar_TbHembra(Program.NombreVacaCondicionesCorporales);
                    } 

                     else if (Program.queSeleccion == "HembrasParaBuscarCondicionesCorporales")
                    {
                        int Fila = DgAnimales.BindingContext[DgAnimales.DataSource].Position;
                        Program.NombreVacaCondicionesCorporales = dt.Rows[Fila]["Nombre"].ToString();
                        Program.IdHembraBuscaCondicionesCorporales = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                        CondicionCorporal mForm = (CondicionCorporal)FormFactory.Obtener(Formulario.CondicionCorporal);
                        mForm.refrescar_TbHembra(Program.NombreVacaCondicionesCorporales);
                    }
                    else if (Program.queSeleccion == "HembraParaInsertarCondicionCorporal")
                    {
                        int Fila = DgAnimales.BindingContext[DgAnimales.DataSource].Position;
                        Program.NombreVacaInsertarCondicionesCorporales = dt.Rows[Fila]["Nombre"].ToString();
                        Program.IdHembraInsertarCondicionesCorporales = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                        InsertarCondicionCorporal mForm = (InsertarCondicionCorporal)FormFactory.Obtener(Formulario.InsertarCondicionCorporal);
                        mForm.refrescar_TbboxHembra(Program.NombreVacaInsertarCondicionesCorporales);
                    }
                    else if (Program.queSeleccion == "AnimalBuscarPeso")
                    {
                        int Fila = DgAnimales.BindingContext[DgAnimales.DataSource].Position;
                        Program.NombreAnimalBuscaPesos = dt.Rows[Fila]["Nombre"].ToString();
                        Program.IdAimalBuscaPesos = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                        Pesos mForm = (Pesos)FormFactory.Obtener(Formulario.Pesos);
                        mForm.refrescar_TbboxHembra(Program.NombreAnimalBuscaPesos);
                    }
                    else if (Program.queSeleccion == "todosparadiagnostico")
                    {
                        int Fila = DgAnimales.BindingContext[DgAnimales.DataSource].Position;
                        Program.NombreAnimalBuscaDiagnosticos = dt.Rows[Fila]["Nombre"].ToString();
                        Program.IdAimalBuscaDiagnosticos = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                        Diagnosticos mForm = (Diagnosticos)FormFactory.Obtener(Formulario.Diagnosticos);
                        mForm.refrescar_TbboxAnimal(Program.NombreAnimalBuscaDiagnosticos);
                    }
                    else if (Program.queSeleccion == "TodosParaDiagnosticoEnfermedad")
                    {
                        int Fila = DgAnimales.BindingContext[DgAnimales.DataSource].Position;
                        Program.NombreAnimalInsertarDiagnosticos = dt.Rows[Fila]["Nombre"].ToString();
                        Program.IdAnimalInsertarDiagnosticos = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                        InsertarDiagnosticoEnfermedad mForm = (InsertarDiagnosticoEnfermedad)FormFactory.Obtener(Formulario.InsertarDiagnosticoEnfermedad);
                        mForm.Refrescar_TbANimal(Program.NombreAnimalInsertarDiagnosticos);
                    }
                    else if (Program.queSeleccion == "TodosParaPesos")
                    {
                        int Fila = DgAnimales.BindingContext[DgAnimales.DataSource].Position;
                        Program.NombreAnimalinsertarPesos = dt.Rows[Fila]["Nombre"].ToString();
                        Program.IdAnimalInsertarPeso = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                        InsertarPeso mForm = (InsertarPeso)FormFactory.Obtener(Formulario.InsertarPeso);
                        mForm.Refrescar_TbANimal(Program.NombreAnimalinsertarPesos);
                    }
                    else if (Program.queSeleccion == "AnimalesBuscarTrat")
                    {
                        int Fila = DgAnimales.BindingContext[DgAnimales.DataSource].Position;
                        string NombreANimal = dt.Rows[Fila]["Nombre"].ToString();
                        Program.IdAnimalBuscaTrat = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                        Tratamientos mForm = (Tratamientos)FormFactory.Obtener(Formulario.Tratamientos);
                        mForm.Refrescar_TbANimal(NombreANimal);
                    }
                    else if (Program.queSeleccion == "hembrasLeches")
                    {
                        int Fila = DgAnimales.BindingContext[DgAnimales.DataSource].Position;
                        string NombreANimal = dt.Rows[Fila]["Nombre"].ToString();
                        Program.IdAnimalInsertarLeches = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                        InsertarRegistroLeches mForm = (InsertarRegistroLeches)FormFactory.Obtener(Formulario.InsertarRegistroLeches);
                        mForm.refrescar_tbHembra(NombreANimal);
                    }
                    else if (Program.queSeleccion == "HembrasSecados")
                    {
                        int Fila = DgAnimales.BindingContext[DgAnimales.DataSource].Position;
                        string NombreANimal = dt.Rows[Fila]["Nombre"].ToString();
                        Program.IdAnimalInsertaSecado = Convert.ToInt32(Program.ConvertirObjectInteger(dt.Rows[Fila]["Id"]));
                        InsertarSecados mForm = (InsertarSecados)FormFactory.Obtener(Formulario.InsertarSecados);
                        mForm.refrescar_TbHembra(NombreANimal);
                    } 


                    


                    
                    //ActualizaEstado();
                }
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
            }
        }

        private void DtFNac_ValueChanged(object sender, EventArgs e)
        {
            TbFechaNac.Text = DtFNac.Value.Date.ToShortDateString();
        }

       
        /*********************************/
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Data;

namespace GEXVOC.UI
{
    public partial class InsertarRegistroLeches : GEXVOC.UI.Principal
    {
        public InsertarRegistroLeches()
        {
            InitializeComponent();
        }
        public void refrescar_Pantalla()
        {
            TbHembra.Text = "";
            //Combobox Estado Control 

            CbControl.DataSource = StatusControlTA.ObtenerStatusOrdeno();
            CbControl.DisplayMember = "Descripcion";
            CbControl.ValueMember = "Id";
            CbControl.Refresh();
            /******************************************************************************************************/

            CbOrdeno.DataSource = StatusOrdenoTA.ObtenerStatusOrdeno();
            CbOrdeno.DisplayMember = "Descripcion";
            CbOrdeno.ValueMember = "Id";
            CbOrdeno.Refresh();
            //Combobox Estado Ordeño
        }
        public void refrescar_tbHembra(string nombre)
        {
            TbHembra.Text = nombre;
        }

        private void InsertarRegistroLeches_Closing(object sender, CancelEventArgs e)
        {
            
            try
            {
                DialogResult r = Program.Preguntar("¿Desea guardar el Contro Lechero?");
                if (r == DialogResult.Yes)
                {
                    string TipoAperturaLactacion = Parametrizacion.tipoAperturaLactacion();
                        if (validar())
                    {
                        int IdLactacion2;
                        int IdLactacion = MirarSiHayLactacion();
                        IdLactacion2 = IdLactacion;
                        if (IdLactacion == 0)
                        {
                            //Secrea una lactacion y se inserta
                            string tipo = Parametrizacion.tipoAperturaLactacion();
                            if (tipo == "Parto")
                                IdLactacion2 = LactacionTA.InsertarNueva(Program.IdAnimalInsertarLeches, Convert.ToDateTime(Program.CalcularFechaUltimoPartoAborot(Program.IdAnimalInsertarLeches)));
                            else if (tipo == "Lactacion")
                                IdLactacion2 = LactacionTA.InsertarNueva(Program.IdAnimalInsertarLeches, dtfecha.Value.Date);
                            //Una vez creada la lactacion inserto el control lechero

                            //

                            LechesTA.InsertarNueva(Convert.ToInt32(CbControl.SelectedValue.ToString()), Convert.ToInt32(CbOrdeno.SelectedValue.ToString()), IdLactacion2, dtfecha.Value.Date, Convert.ToDecimal(textBox2.Text), Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text));

                            e.Cancel = true;
                            InsertarRegistroLeches mForm = (InsertarRegistroLeches)FormFactory.Obtener(Formulario.InsertarRegistroLeches);
                            mForm.Hide();
                        }
                        else
                        {
                            LechesTA.InsertarNueva(Convert.ToInt32(CbControl.SelectedValue.ToString()), Convert.ToInt32(CbOrdeno.SelectedValue.ToString()), IdLactacion2, dtfecha.Value.Date, Convert.ToDecimal(textBox2.Text), Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text));
                            e.Cancel = true;
                            InsertarRegistroLeches mForm = (InsertarRegistroLeches)FormFactory.Obtener(Formulario.InsertarRegistroLeches);
                            mForm.Show();
                        }
                        e.Cancel = true;
                        InsertarRegistroLeches mForm2 = (InsertarRegistroLeches)FormFactory.Obtener(Formulario.InsertarRegistroLeches);
                        mForm2.Hide();

                    }
                    else
                    {
                        e.Cancel = true;
                        InsertarRegistroLeches mForm = (InsertarRegistroLeches)FormFactory.Obtener(Formulario.InsertarRegistroLeches);
                        mForm.Show();
                    }
                }
                else
                {
                    e.Cancel = true;
                    InsertarRegistroLeches mForm = (InsertarRegistroLeches)FormFactory.Obtener(Formulario.InsertarRegistroLeches);
                    mForm.Hide();
                }
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
                Program.Informar("Hubo un error insertando");
            }
        }
       
        private void PbBuscaAnimal_Click(object sender, EventArgs e)
        {
            Program.queSeleccion = "hembrasLeches";
            Program.MostrarCursorEspera();
            Animal mForm = (Animal)FormFactory.Obtener(Formulario.Animal);
            mForm.RefrescarPantalla("H");
            Program.OcultarCursorEspera();
            mForm.Show();
        }

        public bool validar()
        {
            //Se comprueba que la fecha de control sea posterior al último parto o aborto con lactacion.
            if (Program.IdAnimalInsertarLeches != 0)
            {
                DateTime? Fecha = Program.CalcularFechaUltimoPartoAborot(Program.IdAnimalInsertarLeches);
                if (Fecha != null)
                {
                    if (Fecha > dtfecha.Value.Date)
                    {
                        Program.Informar("La fecha del control debe ser posterior al último parto o al último aborto con lactación."+Fecha.ToString());
                        return false;
                    }
                }
                else
                {
                    Program.Informar("La hembra no ha tenido un parto ni un aborto con lactación.");
                    return false;
                }
                DataTable secados = SecadosTA.ObtenerUltimoSecado(Program.IdAnimalInsertarLeches);
                if (secados.Rows.Count > 0)
                {
                    DateTime FechaSecado = Convert.ToDateTime((secados.Rows[0]["Fecha"].ToString()));
                    if (FechaSecado > Fecha)
                    {
                        Program.Informar("La hembra no ha tenido un parto ni un aborto con lactación desde el último secado.");
                        return false;
                    }
                }
                
                //Si hay una lactacion se mira la fecha de apertura de esta ultima
                //DateTime FechaAperturaLactacion;
                //Si no se crea una lactacion
            }
            else
            {
                Program.Informar("Seleccione Hembra");
                return false;
            }
            return true;
        }
        public int MirarSiHayLactacion()
        {
            //Mirar si existe una lactacion, si no existe crearla
            DateTime? Fecha = Program.CalcularFechaUltimoPartoAborot(Program.IdAnimalInsertarLeches);
            string diadesde;
            string mesdesde;
            string anodesde;

            diadesde = dtfecha.Value.Date.Day.ToString();
                if (Convert.ToInt32(diadesde) < 10)
                    diadesde = "0" + diadesde;
                mesdesde = dtfecha.Value.Date.Month.ToString();
                if (Convert.ToInt32(mesdesde) < 10)
                    mesdesde = "0" + mesdesde;
                anodesde = dtfecha.Value.Date.Year.ToString();
              string  Fdesde = mesdesde + "/" + diadesde + "/" + anodesde + " 0:00:00 ";
              DataTable DtLactaciones = LactacionTA.ObtenerLactaciones(dtfecha.Value.Date, Program.IdAnimalInsertarLeches);
              if (DtLactaciones.Rows.Count > 0)
              {
                  //Mirar Si tiene FechaFin
                  if (DtLactaciones.Rows[0]["FechaFin"].ToString() != "")
                  {
                      Program.Informar("No se puede añadir un control porque ya tiene una lactcion con fecha fin posterior al parto/aborto con lactacion");
                      return 1;                     
                  }
                  else if(DtLactaciones.Rows[0]["FechaFin"].ToString()=="")
                  {
                      return Convert.ToInt32(DtLactaciones.Rows[0]["Id"].ToString());
                  }

                  //Enviar el IdLactacion
              }
              else
              {
                  //Crearla
                  return 0;
              }
              return 0;
              
        }
        public void crearLactacion()
        {

        }
       
    }
}


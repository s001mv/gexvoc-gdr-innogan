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
    public partial class InsertarSecados : GEXVOC.UI.Principal
    {
        public InsertarSecados()
        {
            InitializeComponent();
        }

        #region refrescar pantallas
        public void refrescar_TbHembra(string nombre)
        {
            TbHembra.Text = nombre;
        }
        public void refrescar_Pantalla()
        {
            //ComboBox de Tipo
            CbTipoSecado.DataSource = TipoSecadoTA.ObtenerTiposSecados();
            CbTipoSecado.DisplayMember = "Descripcion";
            CbTipoSecado.ValueMember = "Id";
            CbTipoSecado.Refresh();
            /****************************************************************/
            //ComboBox de Motivo            
            CbMotivo.DataSource = MotivoTA.ObtenerMotivos();
            CbMotivo.DisplayMember = "Descripcion";
            CbMotivo.ValueMember = "Id";
            CbMotivo.Refresh();
            /****************************************************************/
        }
        #endregion

        private void InsertarSecados_Closing(object sender, CancelEventArgs e)
        {
             DialogResult r = Program.Preguntar("¿Desea guardar el secado?");
             if (r == DialogResult.Yes)
             {
                 if (validar())
                 {
                     
                     MessageBox.Show("si");
                     e.Cancel = true;
                     SecadosTA.InsertarNueva(Convert.ToInt32(CbTipoSecado.SelectedValue.ToString()), Convert.ToInt32(CbMotivo.SelectedValue.ToString()), Program.IdAnimalInsertaSecado, dtFecha.Value.Date);
                     InsertarSecados mForm2 = (InsertarSecados)FormFactory.Obtener(Formulario.InsertarSecados);
                     mForm2.Hide();
                 }
                 else
                 {
                     MessageBox.Show("NO");
                     e.Cancel = true;
                     InsertarSecados mForm2 = (InsertarSecados)FormFactory.Obtener(Formulario.InsertarSecados);
                     mForm2.Show();
                 }
             }
             else
             {
                 e.Cancel = true;
                 InsertarSecados mForm2 = (InsertarSecados)FormFactory.Obtener(Formulario.InsertarSecados);
                 mForm2.Hide();
             }
        }

        #region validar
        private bool validar()
        {
            if (Program.IdAnimalInsertaSecado != 0)
            {
                DataTable especies = AnimalTA.ObtenerEspecie(Program.IdAnimalInsertaSecado);
                string especie = especies.Rows[0]["Especie"].ToString();


                string clave="";
                string tipo = "";
                int IdTipo = Convert.ToInt32(CbTipoSecado.SelectedValue.ToString());
                if (IdTipo == 5)
                    tipo = "DiasAbortoConLactacion_";
                else if (IdTipo == 2)
                    tipo = "DiasNormalEstimado_";
                else if (IdTipo == 3)
                    tipo = "DiasVacaciones_";
                clave = tipo + especie;
                double PeriodoPostSecado = Convert.ToDouble(Parametrizacion.ObtenerParametrizacionPorClave(clave));
                //int dias = 0;
                //if(IdTipo==1)

                // Debe existir un parto a secar y que este sea posterior a los secados existentes.
                //Busco UltimoParto
                DateTime? FechaUltimoPartoAborto = Program.CalcularFechaUltimoParto(Program.IdAnimalInsertaSecado);

                //Busco Ultimo Secado
                DataTable secados = SecadosTA.ObtenerUltimoSecado(Program.IdAnimalInsertaSecado);
                DateTime? FechaSecado;
                FechaSecado = null;
                if (secados.Rows.Count > 0)
                {
                    FechaSecado = Convert.ToDateTime((secados.Rows[0]["Fecha"].ToString()));
                }


                DateTime? FechaUltimoLeche;
                // DateTime? fechaultimoaborto;
                DataTable DtFechaUltimoControlLeche = LechesTA.ObtenerUltimaFecha(Program.IdAnimalInsertaSecado);


                if (DtFechaUltimoControlLeche.Rows.Count > 0)
                    FechaUltimoLeche = Convert.ToDateTime(DtFechaUltimoControlLeche.Rows[0]["Fecha"].ToString());
                else
                    FechaUltimoLeche = null;

                DateTime fechacontrol = dtFecha.Value.Date;
                if (FechaUltimoPartoAborto != null)
                {
                    if (FechaSecado != null)
                    {
                        if (FechaUltimoPartoAborto > FechaSecado)
                        {
                            Program.Informar("La fecha del secado debe ser posterior al último parto. " + FechaUltimoPartoAborto.ToString());
                            return false;
                        }
                    }
                }
                else
                {
                    Program.Informar("La hembra no ha tenido ningun parto.");
                    return false;
                }

                DataTable lactacion = LactacionTA.ObtenerLactacionesAbiertas(Program.IdAnimalInsertaSecado);
                if (lactacion.Rows.Count > 0)
                {
                    if (FechaUltimoLeche != null)
                    {
                        DateTime fechaaa=Convert.ToDateTime(FechaUltimoLeche);
                        if (fechaaa > dtFecha.Value.Date)
                        {
                            Program.Informar("Hay una lactación abierta, la fecha del secado tiene que ser superior a  " + fechaaa.AddDays(PeriodoPostSecado).ToString());
                            //Se mira la fecha del secado que tiene que ser mayor que X dias 
                            //Se cierra la lactacion

                            return false;
                        }
                    }
                }
                if (FechaUltimoPartoAborto < FechaSecado)
                {
                    Program.Informar("No hay ningun parto posterior al ultimo secado");
                        return false;
                }
            }
            else
            {
                Program.Informar("Seleccione Hembra");
                return false;
            }
            return true;
            
            //// El secado debe ser posterior a todos los controles en caso de tener lactación abierta.
            //Lactacion lactacion = hembra.UltimaLactacionAbierta();//Obtener la ultima lactacion abierta (Sin fecha fin)
            //if (lactacion != null && lactacion.FechaFin != null)
            //{
            //    DateTime FUltimoControl = lactacion.UltimoControl().Fecha;
            //    if (FUltimoControl > this.Fecha)
            //        throw new LogicException("La fecha de secado debe ser superior al " + FUltimoControl.AddDays(-1).ToShortDateString());

            //}
        }
        #endregion

        private void PbBuscaHembra_Click(object sender, EventArgs e)
        {
            Program.queSeleccion = "HembrasSecados";
            Program.MostrarCursorEspera();
            Animal mForm = (Animal)FormFactory.Obtener(Formulario.Animal);
            mForm.RefrescarPantalla("H");
            Program.OcultarCursorEspera();
            mForm.Show();
        }
    }
}
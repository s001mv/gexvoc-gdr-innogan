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
    public partial class InsertarDiagnosticoGestacion : GEXVOC.UI.Principal
    {
        public InsertarDiagnosticoGestacion()
        {
            InitializeComponent();
        }
        bool resultado;
        #region refrescar pantalla
        public void refrescar_pantalla()
        {
            
            //Cbtipos
            CbTipo.DataSource = TipoDiagnosticoTA.ObtenerTiposDiagnosticos();
            CbTipo.DisplayMember = "Descripcion";
            CbTipo.ValueMember = "Id";
            CbTipo.Refresh();

            TbHembra.Text = "";
        }
        public void refrescar_TbHembra(string nombre)
        {
            TbHembra.Text = nombre;
        }
        #endregion

        #region buscar hembra
        private void pbBuscarHembra_Click(object sender, EventArgs e)
        {
            Program.queSeleccion = "HembrasInsertarDiagnostico";
            Program.MostrarCursorEspera();
            Animal mForm = (Animal)FormFactory.Obtener(Formulario.Animal);
            mForm.RefrescarPantalla("H");
            Program.OcultarCursorEspera();
            mForm.Show();
        }//buscar Hembra
        #endregion      

        #region validar
        private bool validar()
        {
            bool resultado = true;
            
            DateTime? UltimaFechaInseminacionCubricion = null; //Busco la ultima inseminacion o la ultima cubricion, lo q sea >
            DateTime? UltimaFechaPartoAborto = null; //busco parto o aborto, lo que sea mayor
            UltimaFechaPartoAborto = CalcularFechaUltimoPartoAborot(Program.IdhembraParaDiagnostico);
            UltimaFechaInseminacionCubricion = CalcularFechaUltimaInseminacionCubricion(Program.IdhembraParaDiagnostico);

            DataTable Abiertas = CubricionTA.ObtenerCubricionesAbiertas(Program.IdHembrarParaInsertarPartos);
            if (Abiertas.Rows.Count > 0)
            {
                Program.Informar("La hembra: " + Program.NombreVacaPartos + " tiene una cubricion, pero se encuentra sin fecha fin, el proceso no puede continuar sin una fecha fin válida.");
                return false;
            }


            if (UltimaFechaInseminacionCubricion != null)
            {
                if (UltimaFechaPartoAborto != null && UltimaFechaInseminacionCubricion < UltimaFechaPartoAborto)
                {
                    Program.Informar("La hembra " + Program.NombreEmbrion + " no ha sido inseminada o cubierta desde su último parto o aborto.");
                    return false;
                }
                if (UltimaFechaInseminacionCubricion > dateTimePicker1.Value.Date)
                {
                    Program.Informar("El diagnóstico de gestación para la hembra: " + Program.NombreEmbrion + " debe ser posterior a la última fecha de inseminación/cubrición que correponde con: " + UltimaFechaInseminacionCubricion.Value.ToShortDateString() + ".");
                    return false;
                }
            }
            else
            {
                Program.Informar("La hembra " + Program.NombreEmbrion + " debe estar inseminada o cubierta para asignarle un diagnóstico de gestación.");
                return false;

            }

            //Mirar Si tiene Abiertas
            

            

            return resultado;
        }
        private DateTime? CalcularFechaUltimaInseminacionCubricion(int IdHembra)
        {
            DateTime? fechaultimainseminacion = null;
            DateTime? fechaultimacubricion = null;
            DataTable ultimainseminacion = InseminacionesTA.ObtenerUltimaFechaInseminacionDeVaca(IdHembra);
            if (ultimainseminacion.Rows.Count > 0)
                fechaultimainseminacion = Convert.ToDateTime(ultimainseminacion.Rows[0]["fecha"].ToString());
            else
                fechaultimainseminacion = null;

            DataTable ultimacubricion = CubricionTA.ObtenerCubricionIdVaca(IdHembra);
            if (ultimacubricion.Rows.Count > 0)
                fechaultimacubricion = Convert.ToDateTime(ultimacubricion.Rows[0]["FechaInicio"].ToString());
            else
                fechaultimacubricion = null;
            if (fechaultimacubricion != null && fechaultimainseminacion != null)
            {
                if (fechaultimacubricion > fechaultimainseminacion)
                    return fechaultimacubricion;
                else if (fechaultimainseminacion > fechaultimacubricion)
                    return fechaultimainseminacion;
            }
            else if (fechaultimainseminacion != null && fechaultimacubricion == null)
                return fechaultimainseminacion;
            else if (fechaultimainseminacion == null && fechaultimacubricion != null)
                return fechaultimacubricion;

            return null;
        }
        private DateTime? CalcularFechaUltimoPartoAborot(int IdHembra)
        {
            DateTime? fechaultimoparto;
            DateTime? fechaultimoaborto;
            DataTable Dtfechasultimoparto = PartosTA.ObtenerFechaUltimoParto(IdHembra);
            DataTable Dtfechasultimoaborto = AbortosTA.ObtenerUltimoAborto(IdHembra);
            if (Dtfechasultimoaborto.Rows.Count > 0)
                fechaultimoaborto = Convert.ToDateTime(Dtfechasultimoaborto.Rows[0]["Fecha"].ToString());
            else
                fechaultimoaborto = null;
            if (Dtfechasultimoparto.Rows.Count > 0)
                fechaultimoparto =Convert.ToDateTime(Dtfechasultimoparto.Rows[0]["Fecha"].ToString());
            else
                fechaultimoparto = null;


            if (fechaultimoaborto != null && fechaultimoparto != null)
            {
                if (fechaultimoparto > fechaultimoaborto)
                    return fechaultimoparto;
                else if (fechaultimoaborto > fechaultimoparto)
                    return fechaultimoaborto;
            }
            else if (fechaultimoaborto != null && fechaultimoparto == null)
                return fechaultimoaborto;
            else if (fechaultimoaborto == null && fechaultimoparto != null)
                return fechaultimoparto;

            return null;

        }
#endregion

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.Text == "Negativo")
            {
                PbNegativo.Visible = false;
                pbPositivo.Visible = true;
                button1.Text = "Positivo";
                resultado = true;
            }
            else
            {
                pbPositivo.Visible = false;
                PbNegativo.Visible = true;
                button1.Text = "Negativo";
                resultado = false;
            }
        }//Negativo Positivo
        private void InsertarDiagnosticoGestacion_Closing(object sender, CancelEventArgs e)
        {
            DialogResult r = Program.Preguntar("¿Desea guardar el diagnostico?");
            if (r == DialogResult.Yes)
            {
                if (TbHembra.Text != "")
                {
                    if (validar())
                    {
                        e.Cancel = true;
                        Program.MostrarCursorEspera();
                        DiagnosticoInseminacionTA.Insertar_Nuevo(Convert.ToInt32(CbTipo.SelectedValue.ToString()), Program.IdhembraParaDiagnostico, dateTimePicker1.Value.Date, resultado, Convert.ToInt32(textBox1.Text));
                        //DiagnosticoInseminacionTA
                        InsertarDiagnosticoGestacion mForm = (InsertarDiagnosticoGestacion)FormFactory.Obtener(Formulario.InsertarDiagnosticoGestacion);
                        //mForm.RefrescarPantalla();                        
                        mForm.Hide();                       
                        DiagnosticoGestacion mForm2 = (DiagnosticoGestacion)FormFactory.Obtener(Formulario.DiagnosticoGestacion);
                        //mForm.RefrescarPantalla();
                        mForm2.Refrescar_Pantalla();
                        Program.OcultarCursorEspera();
                        mForm2.Show();
                    }
                    else
                    {
                        e.Cancel = true;
                        Program.MostrarCursorEspera();
                        InsertarDiagnosticoGestacion mForm = (InsertarDiagnosticoGestacion)FormFactory.Obtener(Formulario.InsertarDiagnosticoGestacion);
                        //mForm.RefrescarPantalla();
                        Program.OcultarCursorEspera();
                        mForm.Show();
                    }
                }
                else
                {
                    Program.Informar("Seleccione Hembra");
                    e.Cancel = true;
                    Program.MostrarCursorEspera();
                    InsertarDiagnosticoGestacion mForm = (InsertarDiagnosticoGestacion)FormFactory.Obtener(Formulario.InsertarDiagnosticoGestacion);
                    //mForm.RefrescarPantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();
                }
            }
            else
            {
                e.Cancel = true;
                Program.MostrarCursorEspera();
                InsertarDiagnosticoGestacion mForm = (InsertarDiagnosticoGestacion)FormFactory.Obtener(Formulario.InsertarDiagnosticoGestacion);
                //mForm.RefrescarPantalla();
                Program.OcultarCursorEspera();
                mForm.Hide();
            }
        }
    }
}


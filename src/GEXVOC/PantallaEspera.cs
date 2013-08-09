using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GEXVOC.UI
{
    public partial class PantallaEspera : Form
    {
        #region CONSTRUCTORES
        public PantallaEspera()
        {
            InitializeComponent();
            ActualizarLabel();
            DuracionEspecifica = false;
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES
        bool _DuracionEspecifica = false;

        public bool DuracionEspecifica
        {
            get { return _DuracionEspecifica; }
            set 
            {
                timer1.Enabled = !value;
                lblProcesados.Visible = value;
                _DuracionEspecifica = value; 
            }
        }

        int? _NumeroPasos = null;

        public int? NumeroPasos
        {
            get { return _NumeroPasos; }
            set {
                if (value!=null)                
                    DuracionEspecifica = true;

                pgbProceso.Maximum = (int)value;
                pgbProceso.Value = 0;
                _NumeroPasos = value;
                ActualizarLabel();

            }
        }
        #endregion

        #region FUNCIONAMIENTO GENERAL
        public void Avanzar() 
        {
            pgbProceso.PerformStep();
            ActualizarLabel();
            Application.DoEvents();
        }

        private void ActualizarLabel()
        {
            lblProcesados.Text = "Procesados: " + pgbProceso.Value.ToString() + " de " + pgbProceso.Maximum.ToString();
            Application.DoEvents();
        }        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgbProceso.Value < 5)
            {
                pgbProceso.Value += 1;
            }
            else
                pgbProceso.Value = 0;

            Application.DoEvents();
        }

        #endregion

    }
}

using System;
using System.Windows.Forms;

namespace GEXVOC.UI
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga de la barra según la pantalla a cargar.
        /// </summary>
        /// <param name="formulario">Formulario procesado.</param>
        public void Cargar(string formulario)
        {
            if (pbBarra.Value < pbBarra.Maximum)
            {
                lblBarra.Text = string.Format("Cargando {0}...", formulario);
                lblBarra.Refresh();
                pbBarra.Value = pbBarra.Value + 1;
            }
            else
                imgLogo.Visible = false;
        }

        /// <summary>
        /// Reinicia la pantalla.
        /// </summary>
        /// <param name="tamaño">Tamaño de la barra de proceso.</param>
        public void Iniciar(int tamaño)
        {
            lblBarra.Text = "Cargando sistema...";
            pbBarra.Minimum = 0;
            pbBarra.Maximum = tamaño - 1;
        }
    }
}
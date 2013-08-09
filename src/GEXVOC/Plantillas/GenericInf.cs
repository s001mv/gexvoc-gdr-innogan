using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.UI.Clases;



namespace GEXVOC.UI
{
    public partial class GenericInf : GEXVOC.UI.GenericMaestro
    {
        #region CONSTRUCTORES
        public GenericInf()
        {
            InitializeComponent();
        }
        #endregion

        #region FUNCIONAMIENTO GENERAL
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.Validate(true);
            Application.DoEvents();
            if (ValidarControles())
                Generar();
            Application.DoEvents();


        }
        protected virtual void Generar() { }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void GenericInf_Load(object sender, EventArgs e)
        {

        }

        private void Filtros_Resize(object sender, EventArgs e)
        {
            splitContainer2.SplitterDistance = Filtros.Height + 35;
        }
        #endregion

        #region CARGAS COMUNES
        public override void Cargar()
        {
            //Pone nos controles predefinidos en mayusculas
            Generic.PonerControlesMayusculas(this);
            CargarCombos();
            this.CargarValoresDefecto();

            this.Cargado = true;//Activo la propiedad que indica que al menos hemos ejecutado 1 vez por el método Cargar()
        }
        #endregion


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;

namespace GEXVOC.UI
{
    
    public partial class GenericEditDinamico : GEXVOC.UI.GenericEdit
    {

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="modo">Modo de apertura del formulario</param>
        /// <param name="ClaseBase">Clase Base sobre la que actúa el formulario</param>
        public GenericEditDinamico(Modo modo, IClaseBase ClaseBase)
        {
            InitializeComponent();

            this.ClaseBase = ClaseBase;

            ModoActual = modo;

        }
        public GenericEditDinamico()
        {
            InitializeComponent();

        }
        #endregion

        #region VARIABLES Y PROPIEDADES
        public int NumColumnas
        {
            get { return this.tableLayoutPanel1.ColumnCount; }
            set {
                this.tableLayoutPanel1.AutoScroll = true;
                this.tableLayoutPanel1.ColumnCount = value;
                foreach (ColumnStyle item in this.tableLayoutPanel1.ColumnStyles)                
                    item.SizeType = SizeType.AutoSize;                
               
            }
        }
        string _Titulo = string.Empty;
        public string Titulo
        {
            get { return _Titulo; }
            set {
                this.Text = value;
                _Titulo = value; 
            }
        }


        #endregion

        #region CARGAS COMUNES
        public override void Cargar()
        {
            foreach (BindingMaestro item in this.lstBinding)
            {
                this.tableLayoutPanel1.Controls.Add(item.LblAsociado);
                this.tableLayoutPanel1.Controls.Add(item.ControlAsociado);
            }

            base.Cargar();
        }

        protected override void CargarValoresDefecto()
        {

            foreach (BindingMaestro item in this.lstBinding)
            {
                if (!string.IsNullOrEmpty(item.ValorDefecto))
                    item.ControlAsociado.Text = item.ValorDefecto;
            }
        }
        #endregion

    }
}

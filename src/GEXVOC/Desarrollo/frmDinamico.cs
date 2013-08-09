using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using System.IO;
using GEXVOC.UI.Clases;

namespace GEXVOC.UI.Desarrollo
{
    public partial class frmDinamico : GenericEdit
    {
        public frmDinamico()
        {
            InitializeComponent();
        }


             /// <summary>
            /// Es una propiedad Tipada que nos devuelve la Clase Base sobre la que actúa el Formulario Edit 
            /// El tipo es popio del formulario, pero implementa siempre la interface  IClaseBase)
            /// </summary>
        public Titular ObjetoBase { get { return (Titular)this.ClaseBase; } }

        public override void Cargar()
        {


            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            foreach (ColumnStyle item in this.tableLayoutPanel1.ColumnStyles)
            {
                item.SizeType = SizeType.AutoSize;
            }
            this.ClaseBase = new Titular();
            this.ModoActual = Modo.Guardar;

            this.lstBinding.Add(new BindingMaestro(ClaseBase, "Nombre", "Nombre"));
            this.lstBinding.Add(new BindingMaestro(ClaseBase, "Apellidos", "Apellidos"));
            this.lstBinding.Add(new BindingMaestro(ClaseBase, "DNI", "D.N.I"));
            this.lstBinding.Add(new BindingMaestro(ClaseBase, "FechaAlta", "Fecha de Alta"));
            this.lstBinding.Add(new BindingMaestro(ClaseBase, "Telefono", "Teléfono"));
            this.lstBinding.Add(new BindingMaestro(ClaseBase, "Direccion", "Dirección"));


            foreach (BindingMaestro item in this.lstBinding)
            {
                this.tableLayoutPanel1.Controls.Add(item.LblAsociado);
                this.tableLayoutPanel1.Controls.Add(item.ControlAsociado);
            }



            base.Cargar();
        }
        
     

     
    }
}

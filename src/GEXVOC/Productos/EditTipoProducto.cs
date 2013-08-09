using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;

namespace GEXVOC.UI
{
    public partial class EditTipoProducto : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditTipoProducto()
        {
            InitializeComponent();
        }
        public EditTipoProducto(Modo modo, TipoProducto ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }

        public override void Cargar()
        {

            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Descripcion", true, txtDescripcion, lblDescripcion));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Familia", false, chkFamilia, lblFamilias));  

            base.Cargar();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public TipoProducto ObjetoBase { get { return (TipoProducto)this.ClaseBase; } }
        #endregion

        
    }
}
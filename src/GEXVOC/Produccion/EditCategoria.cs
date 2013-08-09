﻿using System;
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
    public partial class EditCategoria : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditCategoria()
        {
            InitializeComponent();
        }
        public EditCategoria(Modo modo, Categoria ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            public Categoria ObjetoBase { get { return (Categoria)this.ClaseBase; } }
            public string Descripcion { get { return txtDescripcion.Text; } set { txtDescripcion.Text = value; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

            protected override void DefinirListaBinding()
            {
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Descripcion", true, this.txtDescripcion, lblDescripcion));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Detalle", true, this.txtDetalle, lblDetalle));
                      
                base.DefinirListaBinding();
            }

        #endregion
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Controles;

namespace GEXVOC.UI
{
    public partial class FindTipoCompra : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindTipoCompra()
        {
            InitializeComponent();
        }
        public FindTipoCompra(Modo modo, ctlBuscarObjeto controlBusqueda)
            : base(modo, controlBusqueda)
        {
            InitializeComponent();
        }
        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera el estilo del Grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Descripcion", "T.Compra");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
            dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {

            AsignarOrigenDatos<TipoCompra>(TipoCompra.Buscar(txtDescripcion.Text));
            //dtgResultado.DataSource = TipoCompra.Buscar(txtDescripcion.Text);
        }
        /// <summary>
        /// Lanza el formulario de edición de TipoCompra en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            TipoCompra ObjetoBase = new TipoCompra();
            this.LanzarFormulario(new EditTipoCompra(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de TipoCompra en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                TipoCompra ObjetoBase = (TipoCompra)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditTipoCompra(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion
    }
}
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
    public partial class FindTipoVenta : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindTipoVenta()
        {
            InitializeComponent();
        }
        public FindTipoVenta(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("Descripcion", "T.Venta");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
            dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {

            AsignarOrigenDatos<TipoVenta>(TipoVenta.Buscar(txtDescripcion.Text));
            //dtgResultado.DataSource = TipoVenta.Buscar(txtDescripcion.Text);

        }
        /// <summary>
        /// Lanza el formulario de edición de TipoVenta en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            TipoVenta ObjetoBase = new TipoVenta();
            this.LanzarFormulario(new EditTipoVenta(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de TipoVenta en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                TipoVenta ObjetoBase = (TipoVenta)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditTipoVenta(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion
    }
}
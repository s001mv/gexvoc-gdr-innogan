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
    public partial class FindProductoQuimico : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindProductoQuimico()
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
            dtgResultado.Columns.Add("Descripcion", "Descripcion");
            dtgResultado.Columns[0].DataPropertyName = "descripcion";
            dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            dtgResultado.DataSource = Producto.Buscar(txtDescripcion.Text);
        }
        /// <summary>
        /// Lanza el formulario de edición de ProductoQuimico en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Producto ObjetoBase = new Producto();
            this.LanzarFormulario(new EditProductoQuimico(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de ProductoQuimico en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Producto ObjetoBase = (Producto)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditProductoQuimico(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion
    }
}
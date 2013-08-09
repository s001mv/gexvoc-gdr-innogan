namespace GEXVOC.UI
{
    partial class FindPlantilla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.SubBarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnEntradas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalidas = new System.Windows.Forms.ToolStripButton();
            this.btnEmpleados = new System.Windows.Forms.ToolStripButton();
            this.btnZonas = new System.Windows.Forms.ToolStripButton();
            this.btnMaquinas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEjecutar = new System.Windows.Forms.ToolStripButton();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SubBarraHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtDescripcion);
            this.pnlBusqueda.Controls.Add(this.lblDescripcion);
            this.pnlBusqueda.Location = new System.Drawing.Point(12, 53);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 74);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 133);
            this.panel1.Size = new System.Drawing.Size(610, 312);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(123, 28);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(308, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescripcion.Location = new System.Drawing.Point(51, 31);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // SubBarraHerramientas
            // 
            this.SubBarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEntradas,
            this.toolStripSeparator2,
            this.btnSalidas,
            this.btnEmpleados,
            this.btnZonas,
            this.btnMaquinas,
            this.toolStripSeparator1,
            this.btnEjecutar});
            this.SubBarraHerramientas.Location = new System.Drawing.Point(0, 25);
            this.SubBarraHerramientas.Name = "SubBarraHerramientas";
            this.SubBarraHerramientas.Size = new System.Drawing.Size(634, 25);
            this.SubBarraHerramientas.TabIndex = 9;
            // 
            // btnEntradas
            // 
            this.btnEntradas.Image = global::GEXVOC.Properties.Resources.info;
            this.btnEntradas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(70, 22);
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.ToolTipText = "Ver entradas";
            this.btnEntradas.Click += new System.EventHandler(this.btnesHorizontales_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalidas
            // 
            this.btnSalidas.Image = global::GEXVOC.Properties.Resources.info;
            this.btnSalidas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalidas.Name = "btnSalidas";
            this.btnSalidas.Size = new System.Drawing.Size(55, 22);
            this.btnSalidas.Text = "Salida";
            this.btnSalidas.ToolTipText = "Ver salida";
            this.btnSalidas.Click += new System.EventHandler(this.btnesHorizontales_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Image = global::GEXVOC.Properties.Resources.info;
            this.btnEmpleados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(78, 22);
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.ToolTipText = "Ver empleados";
            this.btnEmpleados.Click += new System.EventHandler(this.btnesHorizontales_Click);
            // 
            // btnZonas
            // 
            this.btnZonas.Image = global::GEXVOC.Properties.Resources.info;
            this.btnZonas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZonas.Name = "btnZonas";
            this.btnZonas.Size = new System.Drawing.Size(56, 22);
            this.btnZonas.Text = "Zonas";
            this.btnZonas.ToolTipText = "Ver zonas";
            this.btnZonas.Click += new System.EventHandler(this.btnesHorizontales_Click);
            // 
            // btnMaquinas
            // 
            this.btnMaquinas.Image = global::GEXVOC.Properties.Resources.info;
            this.btnMaquinas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMaquinas.Name = "btnMaquinas";
            this.btnMaquinas.Size = new System.Drawing.Size(72, 22);
            this.btnMaquinas.Text = "Máquinas";
            this.btnMaquinas.ToolTipText = "Ver máquinas";
            this.btnMaquinas.Click += new System.EventHandler(this.btnesHorizontales_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Image = global::GEXVOC.Properties.Resources.ejecutar;
            this.btnEjecutar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(67, 22);
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.ToolTipText = "Ejecutar proceso";
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // FindPlantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 475);
            this.Controls.Add(this.SubBarraHerramientas);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 312);
            this.Name = "FindPlantilla";
            this.pnlBusquedaPosicion = new System.Drawing.Point(12, 53);
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 74);
            this.Text = "Procesos";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnlBusqueda, 0);
            this.Controls.SetChildIndex(this.SubBarraHerramientas, 0);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.SubBarraHerramientas.ResumeLayout(false);
            this.SubBarraHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ToolStrip SubBarraHerramientas;
        private System.Windows.Forms.ToolStripButton btnEntradas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSalidas;
        private System.Windows.Forms.ToolStripButton btnEmpleados;
        private System.Windows.Forms.ToolStripButton btnZonas;
        private System.Windows.Forms.ToolStripButton btnMaquinas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEjecutar;
    }
}

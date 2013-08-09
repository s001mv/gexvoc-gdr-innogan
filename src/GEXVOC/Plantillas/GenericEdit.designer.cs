namespace GEXVOC.UI
{
    partial class GenericEdit
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
            this.BarraEstado = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBarraEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.Separador = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditLimpiar = new System.Windows.Forms.ToolStripButton();
            this.btnEditBuscar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.BarraEstado.SuspendLayout();
            this.BarraHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraEstado
            // 
            this.BarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado,
            this.lblBarraEstado});
            this.BarraEstado.Location = new System.Drawing.Point(0, 426);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(634, 22);
            this.BarraEstado.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 17);
            // 
            // lblBarraEstado
            // 
            this.lblBarraEstado.Name = "lblBarraEstado";
            this.lblBarraEstado.Size = new System.Drawing.Size(0, 17);
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.Separador,
            this.btnSalir,
            this.toolStripSeparator1,
            this.btnEditLimpiar,
            this.btnEditBuscar});
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(634, 25);
            this.BarraHerramientas.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::GEXVOC.Properties.Resources.guardar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(66, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.Guardar);
            // 
            // Separador
            // 
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::GEXVOC.Properties.Resources.salir;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(47, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.Salir);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEditLimpiar
            // 
            this.btnEditLimpiar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnEditLimpiar.Image = global::GEXVOC.Properties.Resources.limpiar;
            this.btnEditLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditLimpiar.Name = "btnEditLimpiar";
            this.btnEditLimpiar.Size = new System.Drawing.Size(60, 22);
            this.btnEditLimpiar.Text = "Limpiar";
            this.btnEditLimpiar.Visible = false;
            this.btnEditLimpiar.Click += new System.EventHandler(this.limpiar);
            // 
            // btnEditBuscar
            // 
            this.btnEditBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnEditBuscar.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnEditBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditBuscar.Name = "btnEditBuscar";
            this.btnEditBuscar.Size = new System.Drawing.Size(59, 22);
            this.btnEditBuscar.Text = "Buscar";
            this.btnEditBuscar.Visible = false;
            this.btnEditBuscar.Click += new System.EventHandler(this.Buscar);
            // 
            // GenericEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.BarraHerramientas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenericEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generic Edit";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator Separador;
        protected System.Windows.Forms.StatusStrip BarraEstado;
        protected System.Windows.Forms.ToolStrip BarraHerramientas;
        protected System.Windows.Forms.ToolStripButton btnGuardar;
        protected System.Windows.Forms.ToolStripButton btnSalir;
        protected System.Windows.Forms.ToolStripButton btnEditLimpiar;
        protected System.Windows.Forms.ToolStripButton btnEditBuscar;
        protected System.Windows.Forms.ToolStripStatusLabel lblEstado;
        protected System.Windows.Forms.ToolStripStatusLabel lblBarraEstado;
        
        
        
    }
}
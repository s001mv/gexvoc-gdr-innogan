namespace GEXVOC.UI
{
    partial class GenericFind
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
            this.BarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.Separador = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.dtgResultado = new System.Windows.Forms.DataGridView();
            this.pnlBusqueda = new System.Windows.Forms.GroupBox();
            this.BarraEstado = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBarraEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.BarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).BeginInit();
            this.BarraEstado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraHerramientas
            // 
            this.BarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnEliminar,
            this.Separador,
            this.btnSalir,
            this.toolStripSeparator1,
            this.btnLimpiar,
            this.btnBuscar});
            this.BarraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientas.Name = "BarraHerramientas";
            this.BarraHerramientas.Size = new System.Drawing.Size(634, 25);
            this.BarraHerramientas.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::GEXVOC.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(58, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.Nuevo);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::GEXVOC.Properties.Resources.modificar;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(70, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.Modificar);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(63, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.Eliminar);
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
            // btnLimpiar
            // 
            this.btnLimpiar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLimpiar.Image = global::GEXVOC.Properties.Resources.limpiar;
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(60, 22);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.Limpiar);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnBuscar.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.Buscar);
            // 
            // dtgResultado
            // 
            this.dtgResultado.AllowUserToAddRows = false;
            this.dtgResultado.AllowUserToDeleteRows = false;
            this.dtgResultado.AllowUserToOrderColumns = true;
            this.dtgResultado.AllowUserToResizeRows = false;
            this.dtgResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgResultado.BackgroundColor = System.Drawing.Color.White;
            this.dtgResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgResultado.Location = new System.Drawing.Point(0, 0);
            this.dtgResultado.Name = "dtgResultado";
            this.dtgResultado.ReadOnly = true;
            this.dtgResultado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgResultado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgResultado.ShowCellErrors = false;
            this.dtgResultado.ShowCellToolTips = false;
            this.dtgResultado.ShowEditingIcon = false;
            this.dtgResultado.ShowRowErrors = false;
            this.dtgResultado.Size = new System.Drawing.Size(610, 199);
            this.dtgResultado.TabIndex = 3;
            this.dtgResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgResultado_CellDoubleClick);
            this.dtgResultado.DataSourceChanged += new System.EventHandler(this.dtgResultado_DataSourceChanged);
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Location = new System.Drawing.Point(12, 31);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 182);
            this.pnlBusqueda.TabIndex = 2;
            this.pnlBusqueda.TabStop = false;
            this.pnlBusqueda.Text = "Búsqueda";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgResultado);
            this.panel1.Location = new System.Drawing.Point(12, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 199);
            this.panel1.TabIndex = 4;
            // 
            // GenericFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.BarraHerramientas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GenericFind";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generic Find";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.BarraHerramientas.ResumeLayout(false);
            this.BarraHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).EndInit();
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripSeparator Separador;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripButton btnNuevo;
        protected System.Windows.Forms.ToolStripButton btnModificar;
        protected System.Windows.Forms.ToolStripButton btnEliminar;
        protected System.Windows.Forms.ToolStripButton btnSalir;
        protected System.Windows.Forms.ToolStripButton btnLimpiar;
        protected System.Windows.Forms.ToolStripButton btnBuscar;
        protected System.Windows.Forms.ToolStrip BarraHerramientas;
        protected System.Windows.Forms.GroupBox pnlBusqueda;
        protected System.Windows.Forms.StatusStrip BarraEstado;
        protected System.Windows.Forms.ToolStripStatusLabel lblBarraEstado;
        protected System.Windows.Forms.DataGridView dtgResultado;
        protected System.Windows.Forms.Panel panel1;
    }
}
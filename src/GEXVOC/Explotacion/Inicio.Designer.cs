namespace GEXVOC.UI
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Contenedor = new GEXVOC.Core.Controles.Asistente.InfoContainer();
            this.cmbExplotacion = new System.Windows.Forms.ComboBox();
            this.lnkEditar = new System.Windows.Forms.LinkLabel();
            this.lnkNueva = new System.Windows.Forms.LinkLabel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.White;
            this.Contenedor.Controls.Add(this.cmbExplotacion);
            this.Contenedor.Controls.Add(this.lnkEditar);
            this.Contenedor.Controls.Add(this.btnSalir);
            this.Contenedor.Controls.Add(this.lnkNueva);
            this.Contenedor.Controls.Add(this.lblDescripcion);
            this.Contenedor.Controls.Add(this.btnSeleccionar);
            this.Contenedor.Image = ((System.Drawing.Image)(resources.GetObject("Contenedor.Image")));
            this.Contenedor.Location = new System.Drawing.Point(3, 3);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.PageTitle = "Bienvenido a GEXVOC";
            this.Contenedor.Size = new System.Drawing.Size(480, 388);
            this.Contenedor.TabIndex = 0;
            // 
            // cmbExplotacion
            // 
            this.cmbExplotacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbExplotacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbExplotacion.FormattingEnabled = true;
            this.cmbExplotacion.Location = new System.Drawing.Point(215, 94);
            this.cmbExplotacion.Name = "cmbExplotacion";
            this.cmbExplotacion.Size = new System.Drawing.Size(201, 21);
            this.cmbExplotacion.TabIndex = 14;
            // 
            // lnkEditar
            // 
            this.lnkEditar.AutoSize = true;
            this.lnkEditar.Location = new System.Drawing.Point(422, 97);
            this.lnkEditar.Name = "lnkEditar";
            this.lnkEditar.Size = new System.Drawing.Size(49, 13);
            this.lnkEditar.TabIndex = 13;
            this.lnkEditar.TabStop = true;
            this.lnkEditar.Text = "Editar >>";
            this.lnkEditar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditar_LinkClicked);
            // 
            // lnkNueva
            // 
            this.lnkNueva.AutoSize = true;
            this.lnkNueva.Location = new System.Drawing.Point(292, 368);
            this.lnkNueva.Name = "lnkNueva";
            this.lnkNueva.Size = new System.Drawing.Size(179, 13);
            this.lnkNueva.TabIndex = 12;
            this.lnkNueva.TabStop = true;
            this.lnkNueva.Text = "Asistente para nueva explotación >>";
            this.lnkNueva.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNueva_LinkClicked);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(187, 55);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(254, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Seleccione la explotación con la que desea trabajar:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(215, 121);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 10;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(172, 358);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 393);
            this.ControlBox = false;
            this.Controls.Add(this.Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inicio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bienvenido a GEXVOC";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.Contenedor.ResumeLayout(false);
            this.Contenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GEXVOC.Core.Controles.Asistente.InfoContainer Contenedor;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.LinkLabel lnkNueva;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.LinkLabel lnkEditar;
        private System.Windows.Forms.ComboBox cmbExplotacion;
        private System.Windows.Forms.Button btnSalir;
    }
}
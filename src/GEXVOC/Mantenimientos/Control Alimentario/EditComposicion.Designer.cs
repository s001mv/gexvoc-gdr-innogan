namespace GEXVOC.UI
{
    partial class EditComposicion
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
            this.lblSimbolo = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblAlimento = new System.Windows.Forms.Label();
            this.lblRacion = new System.Windows.Forms.Label();
            this.cmbAlimento = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAlimento = new System.Windows.Forms.Button();
            this.cmbRacion = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarRacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSimbolo
            // 
            this.lblSimbolo.AutoSize = true;
            this.lblSimbolo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSimbolo.Location = new System.Drawing.Point(159, 113);
            this.lblSimbolo.Name = "lblSimbolo";
            this.lblSimbolo.Size = new System.Drawing.Size(15, 13);
            this.lblSimbolo.TabIndex = 127;
            this.lblSimbolo.Text = "%";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(96, 110);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(57, 20);
            this.txtPorcentaje.TabIndex = 4;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPorcentaje.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPorcentaje.Location = new System.Drawing.Point(18, 113);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(72, 13);
            this.lblPorcentaje.TabIndex = 125;
            this.lblPorcentaje.Text = "Porcentaje:";
            // 
            // lblAlimento
            // 
            this.lblAlimento.AutoSize = true;
            this.lblAlimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAlimento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAlimento.Location = new System.Drawing.Point(18, 86);
            this.lblAlimento.Name = "lblAlimento";
            this.lblAlimento.Size = new System.Drawing.Size(59, 13);
            this.lblAlimento.TabIndex = 123;
            this.lblAlimento.Text = "Alimento:";
            // 
            // lblRacion
            // 
            this.lblRacion.AutoSize = true;
            this.lblRacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRacion.Location = new System.Drawing.Point(18, 56);
            this.lblRacion.Name = "lblRacion";
            this.lblRacion.Size = new System.Drawing.Size(51, 13);
            this.lblRacion.TabIndex = 120;
            this.lblRacion.Text = "Ración:";
            // 
            // cmbAlimento
            // 
            this.cmbAlimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbAlimento.btnBusqueda = this.btnBuscarAlimento;
            this.cmbAlimento.ClaseActiva = null;
            this.cmbAlimento.ControlVisible = true;
            this.cmbAlimento.DisplayMember = "Descripcion";
            this.cmbAlimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbAlimento.FormattingEnabled = true;
            this.cmbAlimento.IdClaseActiva = 0;
            this.cmbAlimento.Location = new System.Drawing.Point(96, 83);
            this.cmbAlimento.Name = "cmbAlimento";
            this.cmbAlimento.PermitirEliminar = true;
            this.cmbAlimento.PermitirLimpiar = true;
            this.cmbAlimento.ReadOnly = false;
            this.cmbAlimento.Size = new System.Drawing.Size(255, 21);
            this.cmbAlimento.TabIndex = 2;
            this.cmbAlimento.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAlimento.TipoDatos = null;
            this.cmbAlimento.ValueMember = "Id";
            this.cmbAlimento.CrearNuevo += new System.EventHandler(this.cmbAlimento_CrearNuevo);
            // 
            // btnBuscarAlimento
            // 
            this.btnBuscarAlimento.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAlimento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAlimento.Location = new System.Drawing.Point(357, 82);
            this.btnBuscarAlimento.Name = "btnBuscarAlimento";
            this.btnBuscarAlimento.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAlimento.TabIndex = 3;
            this.btnBuscarAlimento.UseVisualStyleBackColor = true;
            this.btnBuscarAlimento.Click += new System.EventHandler(this.btnBuscarAlimento_Click);
            // 
            // cmbRacion
            // 
            this.cmbRacion.BackColor = System.Drawing.SystemColors.Control;
            this.cmbRacion.btnBusqueda = this.btnBuscarRacion;
            this.cmbRacion.ClaseActiva = null;
            this.cmbRacion.ControlVisible = true;
            this.cmbRacion.DisplayMember = "Descripcion";
            this.cmbRacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbRacion.FormattingEnabled = true;
            this.cmbRacion.IdClaseActiva = 0;
            this.cmbRacion.Location = new System.Drawing.Point(96, 53);
            this.cmbRacion.Name = "cmbRacion";
            this.cmbRacion.PermitirEliminar = true;
            this.cmbRacion.PermitirLimpiar = true;
            this.cmbRacion.ReadOnly = false;
            this.cmbRacion.Size = new System.Drawing.Size(255, 21);
            this.cmbRacion.TabIndex = 0;
            this.cmbRacion.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbRacion.TipoDatos = null;
            this.cmbRacion.ValueMember = "Id";
            // 
            // btnBuscarRacion
            // 
            this.btnBuscarRacion.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarRacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarRacion.Location = new System.Drawing.Point(357, 52);
            this.btnBuscarRacion.Name = "btnBuscarRacion";
            this.btnBuscarRacion.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarRacion.TabIndex = 1;
            this.btnBuscarRacion.UseVisualStyleBackColor = true;
            this.btnBuscarRacion.Click += new System.EventHandler(this.btnBuscarRacion_Click);
            // 
            // EditComposicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 202);
            this.Controls.Add(this.btnBuscarRacion);
            this.Controls.Add(this.cmbRacion);
            this.Controls.Add(this.cmbAlimento);
            this.Controls.Add(this.btnBuscarAlimento);
            this.Controls.Add(this.lblSimbolo);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblAlimento);
            this.Controls.Add(this.lblRacion);
            this.Name = "EditComposicion";
            this.Text = "Composición";
            this.Controls.SetChildIndex(this.lblRacion, 0);
            this.Controls.SetChildIndex(this.lblAlimento, 0);
            this.Controls.SetChildIndex(this.lblPorcentaje, 0);
            this.Controls.SetChildIndex(this.txtPorcentaje, 0);
            this.Controls.SetChildIndex(this.lblSimbolo, 0);
            this.Controls.SetChildIndex(this.btnBuscarAlimento, 0);
            this.Controls.SetChildIndex(this.cmbAlimento, 0);
            this.Controls.SetChildIndex(this.cmbRacion, 0);
            this.Controls.SetChildIndex(this.btnBuscarRacion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSimbolo;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblAlimento;
        private System.Windows.Forms.Label lblRacion;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAlimento;
        private System.Windows.Forms.Button btnBuscarAlimento;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbRacion;
        private System.Windows.Forms.Button btnBuscarRacion;
    }
}
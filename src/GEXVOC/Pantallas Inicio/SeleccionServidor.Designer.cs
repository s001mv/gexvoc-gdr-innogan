namespace GEXVOC.UI
{
    partial class SeleccionServidor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionServidor));
            this.Contenedor = new GEXVOC.Core.Controles.Asistente.InfoContainer();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtNombreInstancia = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.White;
            this.Contenedor.Controls.Add(this.lblInformacion);
            this.Contenedor.Controls.Add(this.btnSalir);
            this.Contenedor.Controls.Add(this.btnSeleccionar);
            this.Contenedor.Controls.Add(this.txtNombreInstancia);
            this.Contenedor.Controls.Add(this.lblDescripcion);
            this.Contenedor.Image = ((System.Drawing.Image)(resources.GetObject("Contenedor.Image")));
            this.Contenedor.Location = new System.Drawing.Point(0, 0);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.PageTitle = "Selección de Servidor de Datos";
            this.Contenedor.Size = new System.Drawing.Size(480, 387);
            this.Contenedor.TabIndex = 1;
            // 
            // lblInformacion
            // 
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.Color.Brown;
            this.lblInformacion.Location = new System.Drawing.Point(190, 200);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(258, 116);
            this.lblInformacion.TabIndex = 17;
            this.lblInformacion.Text = resources.GetString("lblInformacion.Text");
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(172, 358);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(360, 138);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 10;
            this.btnSeleccionar.Text = "Confirmar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtNombreInstancia
            // 
            this.txtNombreInstancia.Location = new System.Drawing.Point(190, 112);
            this.txtNombreInstancia.Name = "txtNombreInstancia";
            this.txtNombreInstancia.Size = new System.Drawing.Size(245, 20);
            this.txtNombreInstancia.TabIndex = 16;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(187, 72);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(261, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Proporcione el nombre del servidor de datos.";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SeleccionServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 387);
            this.ControlBox = false;
            this.Controls.Add(this.Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SeleccionServidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor SQL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SeleccionServidor_FormClosed);
            this.Contenedor.ResumeLayout(false);
            this.Contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GEXVOC.Core.Controles.Asistente.InfoContainer Contenedor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.TextBox txtNombreInstancia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
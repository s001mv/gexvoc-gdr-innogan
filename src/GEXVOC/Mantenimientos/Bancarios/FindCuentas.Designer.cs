namespace GEXVOC.UI
{
    partial class FindCuenta
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTitular = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarTitular = new System.Windows.Forms.Button();
            this.lblTitular = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.cmbTitular);
            this.pnlBusqueda.Controls.Add(this.btnBuscarTitular);
            this.pnlBusqueda.Controls.Add(this.lblTitular);
            this.pnlBusqueda.Controls.Add(this.txtSucursal);
            this.pnlBusqueda.Controls.Add(this.lblSucursal);
            this.pnlBusqueda.Controls.Add(this.txtBanco);
            this.pnlBusqueda.Controls.Add(this.lblBanco);
            this.pnlBusqueda.Controls.Add(this.txtCuenta);
            this.pnlBusqueda.Controls.Add(this.lblCuenta);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 137);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 174);
            this.panel1.Size = new System.Drawing.Size(610, 244);
            // 
            // cmbTitular
            // 
            this.cmbTitular.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTitular.btnBusqueda = this.btnBuscarTitular;
            this.cmbTitular.ClaseActiva = null;
            this.cmbTitular.ControlVisible = true;
            this.cmbTitular.DisplayMember = "NombreCompleto";
            this.cmbTitular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbTitular.FormattingEnabled = true;
            this.cmbTitular.Location = new System.Drawing.Point(90, 24);
            this.cmbTitular.Name = "cmbTitular";
            this.cmbTitular.PermitirEliminar = true;
            this.cmbTitular.PermitirLimpiar = true;
            this.cmbTitular.ReadOnly = false;
            this.cmbTitular.Size = new System.Drawing.Size(307, 21);
            this.cmbTitular.TabIndex = 136;
            this.cmbTitular.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            // 
            // btnBuscarTitular
            // 
            this.btnBuscarTitular.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarTitular.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarTitular.Location = new System.Drawing.Point(403, 24);
            this.btnBuscarTitular.Name = "btnBuscarTitular";
            this.btnBuscarTitular.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarTitular.TabIndex = 137;
            this.btnBuscarTitular.UseVisualStyleBackColor = true;
            this.btnBuscarTitular.Click += new System.EventHandler(this.btnBuscarTitular_Click);
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitular.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitular.Location = new System.Drawing.Point(14, 28);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(39, 13);
            this.lblTitular.TabIndex = 144;
            this.lblTitular.Text = "Titular:";
            // 
            // txtSucursal
            // 
            this.txtSucursal.Location = new System.Drawing.Point(90, 104);
            this.txtSucursal.MaxLength = 100;
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(307, 20);
            this.txtSucursal.TabIndex = 140;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSucursal.Location = new System.Drawing.Point(14, 107);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(51, 13);
            this.lblSucursal.TabIndex = 143;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(90, 78);
            this.txtBanco.MaxLength = 100;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(307, 20);
            this.txtBanco.TabIndex = 139;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBanco.Location = new System.Drawing.Point(14, 81);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(41, 13);
            this.lblBanco.TabIndex = 142;
            this.lblBanco.Text = "Banco:";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(90, 52);
            this.txtCuenta.MaxLength = 23;
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(204, 20);
            this.txtCuenta.TabIndex = 138;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCuenta.Location = new System.Drawing.Point(14, 55);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(44, 13);
            this.lblCuenta.TabIndex = 141;
            this.lblCuenta.Text = "Cuenta:";
            // 
            // FindCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 244);
            this.Name = "FindCuenta";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 137);
            this.Text = "Cuentas";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbTitular;
        private System.Windows.Forms.Button btnBuscarTitular;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label lblCuenta;
    }
}

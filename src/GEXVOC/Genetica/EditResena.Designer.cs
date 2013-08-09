namespace GEXVOC.UI
{
    partial class EditResena
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
            this.cmbAnimal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.cmbPersonal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarPersonal = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gpbCaracteristicas = new System.Windows.Forms.GroupBox();
            this.txtCuerpo = new System.Windows.Forms.TextBox();
            this.lblCuerpo = new System.Windows.Forms.Label();
            this.txtExtPostDcha = new System.Windows.Forms.TextBox();
            this.lblExtPostDcha = new System.Windows.Forms.Label();
            this.txtExtrPostIzda = new System.Windows.Forms.TextBox();
            this.lblExtPostIzda = new System.Windows.Forms.Label();
            this.txtExtrAntDcha = new System.Windows.Forms.TextBox();
            this.lblExtrAntDcha = new System.Windows.Forms.Label();
            this.txtExtrAntIzda = new System.Windows.Forms.TextBox();
            this.lblExtAntIzda = new System.Windows.Forms.Label();
            this.txtCuello = new System.Windows.Forms.TextBox();
            this.lblCuello = new System.Windows.Forms.Label();
            this.txtCabeza = new System.Windows.Forms.TextBox();
            this.lblCabeza = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.gpbCaracteristicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.cmbAnimal.btnBusqueda = this.btnBuscarAnimal;
            this.cmbAnimal.ClaseActiva = null;
            this.cmbAnimal.ControlVisible = true;
            this.cmbAnimal.DisplayMember = "Nombre";
            this.cmbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.IdClaseActiva = 0;
            this.cmbAnimal.Location = new System.Drawing.Point(105, 40);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.PermitirEliminar = true;
            this.cmbAnimal.PermitirLimpiar = true;
            this.cmbAnimal.ReadOnly = false;
            this.cmbAnimal.Size = new System.Drawing.Size(168, 21);
            this.cmbAnimal.TabIndex = 0;
            this.cmbAnimal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAnimal.TipoDatos = null;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(279, 39);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 1;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.Location = new System.Drawing.Point(30, 43);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(48, 13);
            this.lblAnimal.TabIndex = 57;
            this.lblAnimal.Text = "Animal:";
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonal.Location = new System.Drawing.Point(30, 74);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(60, 13);
            this.lblPersonal.TabIndex = 58;
            this.lblPersonal.Text = "Personal:";
            // 
            // cmbPersonal
            // 
            this.cmbPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbPersonal.btnBusqueda = this.btnBuscarPersonal;
            this.cmbPersonal.ClaseActiva = null;
            this.cmbPersonal.ControlVisible = true;
            this.cmbPersonal.DisplayMember = "Nombre";
            this.cmbPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbPersonal.FormattingEnabled = true;
            this.cmbPersonal.IdClaseActiva = 0;
            this.cmbPersonal.Location = new System.Drawing.Point(105, 71);
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.PermitirEliminar = true;
            this.cmbPersonal.PermitirLimpiar = true;
            this.cmbPersonal.ReadOnly = false;
            this.cmbPersonal.Size = new System.Drawing.Size(168, 21);
            this.cmbPersonal.TabIndex = 3;
            this.cmbPersonal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbPersonal.TipoDatos = null;
            this.cmbPersonal.CrearNuevo += new System.EventHandler(this.cmbPersonal_CrearNuevo);
            // 
            // btnBuscarPersonal
            // 
            this.btnBuscarPersonal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarPersonal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarPersonal.Location = new System.Drawing.Point(279, 71);
            this.btnBuscarPersonal.Name = "btnBuscarPersonal";
            this.btnBuscarPersonal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarPersonal.TabIndex = 4;
            this.btnBuscarPersonal.UseVisualStyleBackColor = true;
            this.btnBuscarPersonal.Click += new System.EventHandler(this.btnBuscarPersonal_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(355, 43);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 61;
            this.lblFecha.Text = "Fecha:";
            // 
            // gpbCaracteristicas
            // 
            this.gpbCaracteristicas.Controls.Add(this.txtCuerpo);
            this.gpbCaracteristicas.Controls.Add(this.lblCuerpo);
            this.gpbCaracteristicas.Controls.Add(this.txtExtPostDcha);
            this.gpbCaracteristicas.Controls.Add(this.lblExtPostDcha);
            this.gpbCaracteristicas.Controls.Add(this.txtExtrPostIzda);
            this.gpbCaracteristicas.Controls.Add(this.lblExtPostIzda);
            this.gpbCaracteristicas.Controls.Add(this.txtExtrAntDcha);
            this.gpbCaracteristicas.Controls.Add(this.lblExtrAntDcha);
            this.gpbCaracteristicas.Controls.Add(this.txtExtrAntIzda);
            this.gpbCaracteristicas.Controls.Add(this.lblExtAntIzda);
            this.gpbCaracteristicas.Controls.Add(this.txtCuello);
            this.gpbCaracteristicas.Controls.Add(this.lblCuello);
            this.gpbCaracteristicas.Controls.Add(this.txtCabeza);
            this.gpbCaracteristicas.Controls.Add(this.lblCabeza);
            this.gpbCaracteristicas.Location = new System.Drawing.Point(12, 109);
            this.gpbCaracteristicas.Name = "gpbCaracteristicas";
            this.gpbCaracteristicas.Size = new System.Drawing.Size(610, 320);
            this.gpbCaracteristicas.TabIndex = 6;
            this.gpbCaracteristicas.TabStop = false;
            this.gpbCaracteristicas.Text = "Características del cuerpo del Animal";
            // 
            // txtCuerpo
            // 
            this.txtCuerpo.Location = new System.Drawing.Point(105, 30);
            this.txtCuerpo.MaxLength = 250;
            this.txtCuerpo.Name = "txtCuerpo";
            this.txtCuerpo.Size = new System.Drawing.Size(437, 20);
            this.txtCuerpo.TabIndex = 0;
            // 
            // lblCuerpo
            // 
            this.lblCuerpo.AutoSize = true;
            this.lblCuerpo.Location = new System.Drawing.Point(27, 30);
            this.lblCuerpo.Name = "lblCuerpo";
            this.lblCuerpo.Size = new System.Drawing.Size(44, 13);
            this.lblCuerpo.TabIndex = 12;
            this.lblCuerpo.Text = "Cuerpo:";
            // 
            // txtExtPostDcha
            // 
            this.txtExtPostDcha.Location = new System.Drawing.Point(183, 276);
            this.txtExtPostDcha.MaxLength = 250;
            this.txtExtPostDcha.Name = "txtExtPostDcha";
            this.txtExtPostDcha.Size = new System.Drawing.Size(359, 20);
            this.txtExtPostDcha.TabIndex = 6;
            // 
            // lblExtPostDcha
            // 
            this.lblExtPostDcha.AutoSize = true;
            this.lblExtPostDcha.Location = new System.Drawing.Point(27, 279);
            this.lblExtPostDcha.Name = "lblExtPostDcha";
            this.lblExtPostDcha.Size = new System.Drawing.Size(150, 13);
            this.lblExtPostDcha.TabIndex = 10;
            this.lblExtPostDcha.Text = "Extremidad Posterior Derecha:";
            // 
            // txtExtrPostIzda
            // 
            this.txtExtrPostIzda.Location = new System.Drawing.Point(183, 238);
            this.txtExtrPostIzda.MaxLength = 250;
            this.txtExtrPostIzda.Name = "txtExtrPostIzda";
            this.txtExtrPostIzda.Size = new System.Drawing.Size(359, 20);
            this.txtExtrPostIzda.TabIndex = 5;
            // 
            // lblExtPostIzda
            // 
            this.lblExtPostIzda.AutoSize = true;
            this.lblExtPostIzda.Location = new System.Drawing.Point(27, 241);
            this.lblExtPostIzda.Name = "lblExtPostIzda";
            this.lblExtPostIzda.Size = new System.Drawing.Size(152, 13);
            this.lblExtPostIzda.TabIndex = 8;
            this.lblExtPostIzda.Text = "Extremidad Posterior Izquierda:";
            // 
            // txtExtrAntDcha
            // 
            this.txtExtrAntDcha.Location = new System.Drawing.Point(181, 195);
            this.txtExtrAntDcha.MaxLength = 250;
            this.txtExtrAntDcha.Name = "txtExtrAntDcha";
            this.txtExtrAntDcha.Size = new System.Drawing.Size(361, 20);
            this.txtExtrAntDcha.TabIndex = 4;
            // 
            // lblExtrAntDcha
            // 
            this.lblExtrAntDcha.AutoSize = true;
            this.lblExtrAntDcha.Location = new System.Drawing.Point(27, 198);
            this.lblExtrAntDcha.Name = "lblExtrAntDcha";
            this.lblExtrAntDcha.Size = new System.Drawing.Size(145, 13);
            this.lblExtrAntDcha.TabIndex = 6;
            this.lblExtrAntDcha.Text = "Extremidad Anterior Derecha:";
            // 
            // txtExtrAntIzda
            // 
            this.txtExtrAntIzda.Location = new System.Drawing.Point(180, 153);
            this.txtExtrAntIzda.MaxLength = 250;
            this.txtExtrAntIzda.Name = "txtExtrAntIzda";
            this.txtExtrAntIzda.Size = new System.Drawing.Size(362, 20);
            this.txtExtrAntIzda.TabIndex = 3;
            // 
            // lblExtAntIzda
            // 
            this.lblExtAntIzda.AutoSize = true;
            this.lblExtAntIzda.Location = new System.Drawing.Point(27, 156);
            this.lblExtAntIzda.Name = "lblExtAntIzda";
            this.lblExtAntIzda.Size = new System.Drawing.Size(147, 13);
            this.lblExtAntIzda.TabIndex = 4;
            this.lblExtAntIzda.Text = "Extremidad Anterior Izquierda:";
            // 
            // txtCuello
            // 
            this.txtCuello.Location = new System.Drawing.Point(105, 109);
            this.txtCuello.MaxLength = 250;
            this.txtCuello.Name = "txtCuello";
            this.txtCuello.Size = new System.Drawing.Size(437, 20);
            this.txtCuello.TabIndex = 2;
            // 
            // lblCuello
            // 
            this.lblCuello.AutoSize = true;
            this.lblCuello.Location = new System.Drawing.Point(27, 112);
            this.lblCuello.Name = "lblCuello";
            this.lblCuello.Size = new System.Drawing.Size(39, 13);
            this.lblCuello.TabIndex = 2;
            this.lblCuello.Text = "Cuello:";
            // 
            // txtCabeza
            // 
            this.txtCabeza.Location = new System.Drawing.Point(105, 70);
            this.txtCabeza.MaxLength = 250;
            this.txtCabeza.Name = "txtCabeza";
            this.txtCabeza.Size = new System.Drawing.Size(437, 20);
            this.txtCabeza.TabIndex = 1;
            // 
            // lblCabeza
            // 
            this.lblCabeza.AutoSize = true;
            this.lblCabeza.Location = new System.Drawing.Point(27, 73);
            this.lblCabeza.Name = "lblCabeza";
            this.lblCabeza.Size = new System.Drawing.Size(46, 13);
            this.lblCabeza.TabIndex = 0;
            this.lblCabeza.Text = "Cabeza:";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(355, 77);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(37, 13);
            this.lblLugar.TabIndex = 64;
            this.lblLugar.Text = "Lugar:";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(422, 74);
            this.txtLugar.MaxLength = 80;
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(183, 20);
            this.txtLugar.TabIndex = 5;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(422, 43);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 2;
            this.txtFecha.Value = null;
            // 
            // EditResena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 463);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.gpbCaracteristicas);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbPersonal);
            this.Controls.Add(this.btnBuscarPersonal);
            this.Controls.Add(this.lblPersonal);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.cmbAnimal);
            this.Controls.Add(this.btnBuscarAnimal);
            this.Name = "EditResena";
            this.Text = "Reseña Genética";
            this.Controls.SetChildIndex(this.btnBuscarAnimal, 0);
            this.Controls.SetChildIndex(this.cmbAnimal, 0);
            this.Controls.SetChildIndex(this.lblAnimal, 0);
            this.Controls.SetChildIndex(this.lblPersonal, 0);
            this.Controls.SetChildIndex(this.btnBuscarPersonal, 0);
            this.Controls.SetChildIndex(this.cmbPersonal, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.gpbCaracteristicas, 0);
            this.Controls.SetChildIndex(this.lblLugar, 0);
            this.Controls.SetChildIndex(this.txtLugar, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.gpbCaracteristicas.ResumeLayout(false);
            this.gpbCaracteristicas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label lblPersonal;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbPersonal;
        private System.Windows.Forms.Button btnBuscarPersonal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox gpbCaracteristicas;
        private System.Windows.Forms.Label lblCabeza;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtExtrAntIzda;
        private System.Windows.Forms.Label lblExtAntIzda;
        private System.Windows.Forms.TextBox txtCuello;
        private System.Windows.Forms.Label lblCuello;
        private System.Windows.Forms.TextBox txtCabeza;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblExtPostDcha;
        private System.Windows.Forms.TextBox txtExtrPostIzda;
        private System.Windows.Forms.Label lblExtPostIzda;
        private System.Windows.Forms.TextBox txtExtrAntDcha;
        private System.Windows.Forms.Label lblExtrAntDcha;
        private System.Windows.Forms.TextBox txtCuerpo;
        private System.Windows.Forms.Label lblCuerpo;
        private System.Windows.Forms.TextBox txtExtPostDcha;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
    }
}

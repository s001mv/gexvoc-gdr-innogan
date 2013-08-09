namespace GEXVOC.UI
{
    partial class EditAniLot
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
            this.btnBuscarHembra = new System.Windows.Forms.Button();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.cmbLoteAnimal = new System.Windows.Forms.ComboBox();
            this.lblLoteAnimal = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.lblFecInicio = new System.Windows.Forms.Label();
            this.txtFechaFin = new System.Windows.Forms.TextBox();
            this.lblFecFin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.cmbAnimal.btnBusqueda = this.btnBuscarHembra;
            this.cmbAnimal.ClaseActiva = null;
            this.cmbAnimal.ControlVisible = true;
            this.cmbAnimal.DisplayMember = "Nombre";
            this.cmbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.Location = new System.Drawing.Point(129, 51);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.PermitirEliminar = true;
            this.cmbAnimal.PermitirLimpiar = true;
            this.cmbAnimal.ReadOnly = false;
            this.cmbAnimal.Size = new System.Drawing.Size(227, 21);
            this.cmbAnimal.TabIndex = 147;
            this.cmbAnimal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            // 
            // btnBuscarHembra
            // 
            this.btnBuscarHembra.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarHembra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarHembra.Location = new System.Drawing.Point(362, 51);
            this.btnBuscarHembra.Name = "btnBuscarHembra";
            this.btnBuscarHembra.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarHembra.TabIndex = 146;
            this.btnBuscarHembra.UseVisualStyleBackColor = true;
            this.btnBuscarHembra.Click += new System.EventHandler(this.btnBuscarHembra_Click);
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAnimal.Location = new System.Drawing.Point(30, 55);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(48, 13);
            this.lblAnimal.TabIndex = 145;
            this.lblAnimal.Text = "Animal:";
            // 
            // cmbLoteAnimal
            // 
            this.cmbLoteAnimal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLoteAnimal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLoteAnimal.FormattingEnabled = true;
            this.cmbLoteAnimal.Location = new System.Drawing.Point(129, 78);
            this.cmbLoteAnimal.Name = "cmbLoteAnimal";
            this.cmbLoteAnimal.Size = new System.Drawing.Size(254, 21);
            this.cmbLoteAnimal.TabIndex = 148;
            // 
            // lblLoteAnimal
            // 
            this.lblLoteAnimal.AutoSize = true;
            this.lblLoteAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoteAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLoteAnimal.Location = new System.Drawing.Point(30, 81);
            this.lblLoteAnimal.Name = "lblLoteAnimal";
            this.lblLoteAnimal.Size = new System.Drawing.Size(36, 13);
            this.lblLoteAnimal.TabIndex = 149;
            this.lblLoteAnimal.Text = "Lote:";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(129, 105);
            this.txtFechaInicio.MaxLength = 10;
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(101, 20);
            this.txtFechaInicio.TabIndex = 150;
            // 
            // lblFecInicio
            // 
            this.lblFecInicio.AutoSize = true;
            this.lblFecInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecInicio.Location = new System.Drawing.Point(30, 108);
            this.lblFecInicio.Name = "lblFecInicio";
            this.lblFecInicio.Size = new System.Drawing.Size(81, 13);
            this.lblFecInicio.TabIndex = 151;
            this.lblFecInicio.Text = "Fecha Inicio:";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(129, 131);
            this.txtFechaFin.MaxLength = 10;
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(101, 20);
            this.txtFechaFin.TabIndex = 152;
            // 
            // lblFecFin
            // 
            this.lblFecFin.AutoSize = true;
            this.lblFecFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecFin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecFin.Location = new System.Drawing.Point(30, 134);
            this.lblFecFin.Name = "lblFecFin";
            this.lblFecFin.Size = new System.Drawing.Size(57, 13);
            this.lblFecFin.TabIndex = 153;
            this.lblFecFin.Text = "Fecha Fin:";
            // 
            // EditAniLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(470, 197);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.lblFecFin);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.lblFecInicio);
            this.Controls.Add(this.cmbLoteAnimal);
            this.Controls.Add(this.lblLoteAnimal);
            this.Controls.Add(this.cmbAnimal);
            this.Controls.Add(this.btnBuscarHembra);
            this.Controls.Add(this.lblAnimal);
            this.Name = "EditAniLot";
            this.Text = "Animales y Lotes";
            this.PropiedadAControl += new System.EventHandler<GEXVOC.UI.PropiedadBindEventArgs>(this.EditAniLot_PropiedadAControl);
            this.Controls.SetChildIndex(this.lblAnimal, 0);
            this.Controls.SetChildIndex(this.btnBuscarHembra, 0);
            this.Controls.SetChildIndex(this.cmbAnimal, 0);
            this.Controls.SetChildIndex(this.lblLoteAnimal, 0);
            this.Controls.SetChildIndex(this.cmbLoteAnimal, 0);
            this.Controls.SetChildIndex(this.lblFecInicio, 0);
            this.Controls.SetChildIndex(this.txtFechaInicio, 0);
            this.Controls.SetChildIndex(this.lblFecFin, 0);
            this.Controls.SetChildIndex(this.txtFechaFin, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAnimal;
        private System.Windows.Forms.Button btnBuscarHembra;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.ComboBox cmbLoteAnimal;
        private System.Windows.Forms.Label lblLoteAnimal;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.Label lblFecInicio;
        private System.Windows.Forms.TextBox txtFechaFin;
        private System.Windows.Forms.Label lblFecFin;
    }
}

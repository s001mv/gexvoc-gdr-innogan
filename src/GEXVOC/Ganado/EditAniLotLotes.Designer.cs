namespace GEXVOC.UI
{
    partial class EditAniLotLotes
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
            this.lblFecFin = new System.Windows.Forms.Label();
            this.lblFecInicio = new System.Windows.Forms.Label();
            this.cmbLoteAnimal = new System.Windows.Forms.ComboBox();
            this.lblLoteAnimal = new System.Windows.Forms.Label();
            this.cmbAnimal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarHembra = new System.Windows.Forms.Button();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.txtFechaInicio = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFechaFin = new GEXVOC.Core.Controles.ctlFecha();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecFin
            // 
            this.lblFecFin.AutoSize = true;
            this.lblFecFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecFin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecFin.Location = new System.Drawing.Point(26, 133);
            this.lblFecFin.Name = "lblFecFin";
            this.lblFecFin.Size = new System.Drawing.Size(57, 13);
            this.lblFecFin.TabIndex = 157;
            this.lblFecFin.Text = "Fecha Fin:";
            // 
            // lblFecInicio
            // 
            this.lblFecInicio.AutoSize = true;
            this.lblFecInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecInicio.Location = new System.Drawing.Point(26, 107);
            this.lblFecInicio.Name = "lblFecInicio";
            this.lblFecInicio.Size = new System.Drawing.Size(81, 13);
            this.lblFecInicio.TabIndex = 155;
            this.lblFecInicio.Text = "Fecha Inicio:";
            // 
            // cmbLoteAnimal
            // 
            this.cmbLoteAnimal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLoteAnimal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLoteAnimal.FormattingEnabled = true;
            this.cmbLoteAnimal.Location = new System.Drawing.Point(125, 77);
            this.cmbLoteAnimal.Name = "cmbLoteAnimal";
            this.cmbLoteAnimal.Size = new System.Drawing.Size(121, 21);
            this.cmbLoteAnimal.TabIndex = 2;
            // 
            // lblLoteAnimal
            // 
            this.lblLoteAnimal.AutoSize = true;
            this.lblLoteAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoteAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLoteAnimal.Location = new System.Drawing.Point(26, 80);
            this.lblLoteAnimal.Name = "lblLoteAnimal";
            this.lblLoteAnimal.Size = new System.Drawing.Size(36, 13);
            this.lblLoteAnimal.TabIndex = 162;
            this.lblLoteAnimal.Text = "Lote:";
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
            this.cmbAnimal.IdClaseActiva = 0;
            this.cmbAnimal.Location = new System.Drawing.Point(125, 48);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.PermitirEliminar = true;
            this.cmbAnimal.PermitirLimpiar = false;
            this.cmbAnimal.ReadOnly = false;
            this.cmbAnimal.Size = new System.Drawing.Size(227, 21);
            this.cmbAnimal.TabIndex = 0;
            this.cmbAnimal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAnimal.TipoDatos = null;
            // 
            // btnBuscarHembra
            // 
            this.btnBuscarHembra.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarHembra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarHembra.Location = new System.Drawing.Point(358, 48);
            this.btnBuscarHembra.Name = "btnBuscarHembra";
            this.btnBuscarHembra.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarHembra.TabIndex = 1;
            this.btnBuscarHembra.UseVisualStyleBackColor = true;
            this.btnBuscarHembra.Click += new System.EventHandler(this.btnBuscarHembra_Click);
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAnimal.Location = new System.Drawing.Point(26, 52);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(48, 13);
            this.lblAnimal.TabIndex = 158;
            this.lblAnimal.Text = "Animal:";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaInicio.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaInicio.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaInicio.Location = new System.Drawing.Point(125, 104);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.ReadOnly = false;
            this.txtFechaInicio.Size = new System.Drawing.Size(88, 20);
            this.txtFechaInicio.TabIndex = 3;
            this.txtFechaInicio.Value = null;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaFin.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaFin.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaFin.Location = new System.Drawing.Point(125, 130);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.ReadOnly = false;
            this.txtFechaFin.Size = new System.Drawing.Size(88, 20);
            this.txtFechaFin.TabIndex = 4;
            this.txtFechaFin.Value = null;
            // 
            // EditAniLotLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(402, 196);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.cmbLoteAnimal);
            this.Controls.Add(this.lblLoteAnimal);
            this.Controls.Add(this.cmbAnimal);
            this.Controls.Add(this.btnBuscarHembra);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.lblFecFin);
            this.Controls.Add(this.lblFecInicio);
            this.Name = "EditAniLotLotes";
            this.Text = "Animales a lotes";
            this.Controls.SetChildIndex(this.lblFecInicio, 0);
            this.Controls.SetChildIndex(this.lblFecFin, 0);
            this.Controls.SetChildIndex(this.lblAnimal, 0);
            this.Controls.SetChildIndex(this.btnBuscarHembra, 0);
            this.Controls.SetChildIndex(this.cmbAnimal, 0);
            this.Controls.SetChildIndex(this.lblLoteAnimal, 0);
            this.Controls.SetChildIndex(this.cmbLoteAnimal, 0);
            this.Controls.SetChildIndex(this.txtFechaInicio, 0);
            this.Controls.SetChildIndex(this.txtFechaFin, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecFin;
        private System.Windows.Forms.Label lblFecInicio;
        private System.Windows.Forms.ComboBox cmbLoteAnimal;
        private System.Windows.Forms.Label lblLoteAnimal;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAnimal;
        private System.Windows.Forms.Button btnBuscarHembra;
        private System.Windows.Forms.Label lblAnimal;
        private GEXVOC.Core.Controles.ctlFecha txtFechaInicio;
        private GEXVOC.Core.Controles.ctlFecha txtFechaFin;
    }
}

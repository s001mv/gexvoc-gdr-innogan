namespace GEXVOC.UI
{
    partial class EditPersonalizarMenus
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
            this.trvMenus = new System.Windows.Forms.TreeView();
            this.lblModulo = new System.Windows.Forms.Label();
            this.cmbModulo = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarModulos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // trvMenus
            // 
            this.trvMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trvMenus.CheckBoxes = true;
            this.trvMenus.FullRowSelect = true;
            this.trvMenus.Location = new System.Drawing.Point(27, 96);
            this.trvMenus.Name = "trvMenus";
            this.trvMenus.Size = new System.Drawing.Size(585, 420);
            this.trvMenus.TabIndex = 2;
            this.trvMenus.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvMenus_AfterCheck);
            this.trvMenus.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvMenus_BeforeCheck);
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.Location = new System.Drawing.Point(29, 55);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(116, 13);
            this.lblModulo.TabIndex = 66;
            this.lblModulo.Text = "Seleccione un Módulo:";
            // 
            // cmbModulo
            // 
            this.cmbModulo.BackColor = System.Drawing.SystemColors.Control;
            this.cmbModulo.btnBusqueda = this.btnBuscarModulos;
            this.cmbModulo.ClaseActiva = null;
            this.cmbModulo.ControlVisible = true;
            this.cmbModulo.DisplayMember = "Descripcion";
            this.cmbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Location = new System.Drawing.Point(151, 52);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.PermitirEliminar = true;
            this.cmbModulo.PermitirLimpiar = true;
            this.cmbModulo.ReadOnly = false;
            this.cmbModulo.Size = new System.Drawing.Size(281, 21);
            this.cmbModulo.TabIndex = 67;
            this.cmbModulo.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbModulo.ClaseActivaChanged += new System.EventHandler<GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs>(this.cmbModulo_ClaseActivaChanged);
            // 
            // btnBuscarModulos
            // 
            this.btnBuscarModulos.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarModulos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarModulos.Location = new System.Drawing.Point(438, 52);
            this.btnBuscarModulos.Name = "btnBuscarModulos";
            this.btnBuscarModulos.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarModulos.TabIndex = 68;
            this.btnBuscarModulos.UseVisualStyleBackColor = true;
            this.btnBuscarModulos.Click += new System.EventHandler(this.btnBuscarModulos_Click);
            // 
            // EditPersonalizarMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(639, 560);
            this.Controls.Add(this.cmbModulo);
            this.Controls.Add(this.btnBuscarModulos);
            this.Controls.Add(this.lblModulo);
            this.Controls.Add(this.trvMenus);
            this.Name = "EditPersonalizarMenus";
            this.Text = "Personalización de Menús  (Según Módulo)";
            this.Controls.SetChildIndex(this.trvMenus, 0);
            this.Controls.SetChildIndex(this.lblModulo, 0);
            this.Controls.SetChildIndex(this.btnBuscarModulos, 0);
            this.Controls.SetChildIndex(this.cmbModulo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvMenus;
        private System.Windows.Forms.Label lblModulo;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbModulo;
        private System.Windows.Forms.Button btnBuscarModulos;
    }
}

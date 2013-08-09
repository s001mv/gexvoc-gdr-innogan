namespace GEXVOC.UI
{
    partial class MuestraVersion
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
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "1.0.0.1",
            "25/12/2008"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("");
            this.Contenedor = new GEXVOC.Core.Controles.Asistente.InfoContainer();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lstVersiones = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVersionDatos = new System.Windows.Forms.TextBox();
            this.txtVersionAplicacion = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.White;
            this.Contenedor.Controls.Add(this.lblMensaje);
            this.Contenedor.Controls.Add(this.btnActualizar);
            this.Contenedor.Controls.Add(this.label1);
            this.Contenedor.Controls.Add(this.lblDescripcion);
            this.Contenedor.Controls.Add(this.lstVersiones);
            this.Contenedor.Controls.Add(this.txtVersionAplicacion);
            this.Contenedor.Controls.Add(this.label2);
            this.Contenedor.Controls.Add(this.linkLabel1);
            this.Contenedor.Controls.Add(this.txtVersionDatos);
            this.Contenedor.Controls.Add(this.btnSalir);
            this.Contenedor.Image = global::GEXVOC.Properties.Resources.Lateral_gexvoc_1;
            this.Contenedor.Location = new System.Drawing.Point(0, 0);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.PageTitle = "GEXVOC (Controlador de Versiones)";
            this.Contenedor.Size = new System.Drawing.Size(473, 388);
            this.Contenedor.TabIndex = 1;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(188, 54);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(273, 70);
            this.lblMensaje.TabIndex = 22;
            this.lblMensaje.Text = "Mesaje";
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(393, 357);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(190, 139);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(94, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Versión de  Datos:";
            // 
            // lstVersiones
            // 
            this.lstVersiones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstVersiones.FullRowSelect = true;
            this.lstVersiones.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVersiones.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15});
            this.lstVersiones.Location = new System.Drawing.Point(193, 206);
            this.lstVersiones.MultiSelect = false;
            this.lstVersiones.Name = "lstVersiones";
            this.lstVersiones.ShowGroups = false;
            this.lstVersiones.ShowItemToolTips = true;
            this.lstVersiones.Size = new System.Drawing.Size(244, 63);
            this.lstVersiones.TabIndex = 19;
            this.lstVersiones.UseCompatibleStateImageBehavior = false;
            this.lstVersiones.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Versión";
            this.columnHeader1.Width = 132;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha";
            this.columnHeader2.Width = 91;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(362, 275);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Scripts necesarios para la actualización.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(392, 190);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 13);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Detalles";
            this.toolTip1.SetToolTip(this.linkLabel1, "Muestra los detalles de todas las versiones reconocidas por la aplicación.");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Versión de Aplicación:";
            // 
            // txtVersionDatos
            // 
            this.txtVersionDatos.Location = new System.Drawing.Point(326, 136);
            this.txtVersionDatos.Name = "txtVersionDatos";
            this.txtVersionDatos.ReadOnly = true;
            this.txtVersionDatos.Size = new System.Drawing.Size(111, 20);
            this.txtVersionDatos.TabIndex = 16;
            this.txtVersionDatos.TabStop = false;
            this.txtVersionDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVersionAplicacion
            // 
            this.txtVersionAplicacion.Location = new System.Drawing.Point(326, 162);
            this.txtVersionAplicacion.Name = "txtVersionAplicacion";
            this.txtVersionAplicacion.ReadOnly = true;
            this.txtVersionAplicacion.Size = new System.Drawing.Size(111, 20);
            this.txtVersionAplicacion.TabIndex = 18;
            this.txtVersionAplicacion.TabStop = false;
            this.txtVersionAplicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MuestraVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 387);
            this.ControlBox = false;
            this.Controls.Add(this.Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MuestraVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controlador de Versiones";
            this.Load += new System.EventHandler(this.Version_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MuestraVersion_FormClosed);
            this.Contenedor.ResumeLayout(false);
            this.Contenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GEXVOC.Core.Controles.Asistente.InfoContainer Contenedor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ListView lstVersiones;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtVersionAplicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVersionDatos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
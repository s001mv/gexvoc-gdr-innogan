using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;



namespace GEXVOC.UI
{
    /// <summary>
    /// Este formulario es mostrado cuando las versiones de base de datos y aplicación son distintas.
    /// Nos permite actualizar las versiónes.
    /// Siempre que es mostrado, tiene 2 maneras de cerrarse, en modo permitir cerrar o no.
    /// Permitir cerrar le permite cerrar la aplicación entera, se utiliza en el arranque cuando las versiones
    /// de base de datos y aplicación no coinciden.
    /// Siempre que se cierra dicho formulario y no se retorna true, automaticamente cierra la aplicacion.
    /// En el caso en que se muestre el formulario desde el menu principal, para obtener información, éste apertura 
    /// con permitir cerrar = false, para que no cierre la aplicación.
    /// </summary>
    public partial class MuestraVersion : Form
    {
        #region CONSTRUCTORES
        public MuestraVersion()
        {
            InitializeComponent();
        }
        #endregion

        #region FUNCIONAMIENTO GENERAL

  /// <summary>
        /// Comienza el proceso de actualizar.
        /// Si finaliza correctamente aparecerá la pantalla de seleccion de la explotación.
        /// Si no finaliza correctamente se cierra la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            //if (MessageBox.Show("Antes de comezar este proceso es conveniente hacer una copia de seguridad de los datos.\n ¿Desea abrir el formulario de copias de seguridad?","Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            //{
            //    MakeBackup frmCopiaSeguridad = new MakeBackup();
            //    frmCopiaSeguridad.PermitirRestaurar = false;

            //    //frmCopiaSeguridad
            //    frmCopiaSeguridad.ShowDialog();
            //    Application.DoEvents();   
            //}

            //Actualizar la version
            //Ejecutar los scripts cargados
            GEXVOCDataContext BD = GEXVOC.Core.Data.BDController.NuevoContexto;
            if (BD.Connection.State == System.Data.ConnectionState.Closed)
                BD.Connection.Open();
            BD.Transaction=BD.Connection.BeginTransaction();           
        
         

            foreach (ListViewItem item in lstVersiones.Items)
            {
                ElementoVersion ScriptProceso= (ElementoVersion)item.Tag;

                try
                {
                    ///Dividimos el script en tantos comandos como sentencias go tenga, ya que dichas sentecias
                    ///separan cada comando y no son compatibles en la funcion ExecuteCommand
                    string[] array = { Environment.NewLine + "GO" + Environment.NewLine };
                    foreach (string comando in ScriptProceso.Script.Split(array, StringSplitOptions.RemoveEmptyEntries))
                    {
                        int CodigoRetorno = -1;
                        CodigoRetorno=BD.ExecuteCommand(comando, new object[0]);
                        Traza.RegistrarInfo("Código de retorno: " + CodigoRetorno.ToString() + " para la sentencia: " + comando);
                    }
                }
                catch (Exception ex)
                {
                    BD.Transaction.Rollback();                   
                    BD.SubmitChanges();
                    
                    Generic.AvisoError("Se ha producido un error procesando el script de la version: " + ScriptProceso.ToString() + Environment.NewLine + "La aplicación no puede continuar, contacte con su administrador." + Environment.NewLine + "Para más información consulte el 'ErrorLog'");
                    Traza.RegistrarError(ex);
                    this.Cursor = Cursors.Default;
                    DialogResult = DialogResult.Cancel;                    
                    return;
                }               
               
            }
            BD.Transaction.Commit();
            BD.SubmitChanges();        
            BD.Dispose();
            
            //Si todo se ha ejecutado correctamente, actualizo la versión de la bd a la versión de la aplicación
            Versionado.ActualizarVersionBD();
            this.Cursor = Cursors.Default;
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Cuando cierro el formulario cierro tambien la aplicación, salvo en 2 casos
        /// 1 - Que el formulario haya sido abierto desde el mdi de la aplicacion
        /// 2 - Que el formulario haya actualizado correctamente la version de la BD.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MuestraVersion_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult!=DialogResult.OK && PermitirCerrar)            
                Application.Exit();            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDetallesVersiones frmdetalles = new frmDetallesVersiones();
            frmdetalles.ShowDialog(this);
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES
        /// <summary>
        /// Nos indica si cierra o no la aplicación cuando pulsamos el botón salir.        
        /// </summary>
        public bool PermitirCerrar{get;set;}
        #endregion

        #region CARGAS COMUNES
        private void Version_Load(object sender, EventArgs e)
        {

            
            txtVersionDatos.Text = Versionado.VersionBaseDatos.ToString();
            txtVersionAplicacion.Text = Versionado.VersionAplicacion.ToString();

            if (Versionado.VersionBaseDatos == Versionado.VersionAplicacion)
            {
                lblMensaje.Text = "La versión de los datos igual a la versión de la aplicación."
                    + Environment.NewLine + "No es necesaria ninguna actualización.";
                btnActualizar.Enabled = false;
            }
            else if (Versionado.VersionBaseDatos < Versionado.VersionAplicacion)
            {
                lblMensaje.Text = "La versión de los datos es inferior a la versión de la aplicación."
                      + Environment.NewLine + "Es necesario pulsar la opción 'Actualizar' para actualizar la versión de los datos e iniciar la aplicación.";
            }
            else if (Versionado.VersionBaseDatos > Versionado.VersionAplicacion)
            {
                lblMensaje.Text = "La versión de los datos es superior a la versión de la aplicación."
                       + Environment.NewLine + "En este caso no es posible iniciar la aplicación, debe actualizar su aplicación a la versión: " + Versionado.VersionBaseDatos.ToString() + " o contacte con su administrador";
                btnActualizar.Enabled = false;
            }

            CargarScripts();              
            
        }

        /// <summary>
        /// Carga en la lista los scripts que serán ejecutados en el proceso de actualizar.
        /// </summary>
        void CargarScripts()         
        {
            this.lstVersiones.Items.Clear();
            List<ElementoVersion> lstElementos = Versionado.ScriptsActualizar();
            foreach (ElementoVersion item in lstElementos)
            {
                ListViewItem elemento=this.lstVersiones.Items.Add(item.ToString());
                elemento.Tag = item;
                elemento.ToolTipText = item.Descripcion;
                if (item.Fecha.HasValue)
                    elemento.SubItems.Add(item.Fecha.Value.ToShortDateString());

            }

        
        }
        #endregion

    }
}

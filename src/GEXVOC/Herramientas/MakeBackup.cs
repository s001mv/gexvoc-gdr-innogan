using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Logic;

namespace GEXVOC.UI
{
    /// <summary>
    /// Formulario para realizar y restaurar las copias de seguridad.
    /// </summary>
    public partial class MakeBackup : Form
    {
        #region VARIABLES Y PROPIEDADES PRINCIPALES

            /// <summary>
            /// Extension de los archivos de backup.
            /// </summary>
            public const string BackupsExtension = "sbackup";
            private string strBackupPath = string.Empty;
     
            private System.Data.SqlClient.SqlConnection sqlCon = null;
            private bool BackupDone = false;
            private bool RestoreMade = false;
            /// <summary>
            /// Inicio la cadena de conexion pero en vez de iniciarla con la Base de datos gexvoc, lo hago con master.
            /// </summary>
            private string ConnectionString = Core.Data.BDController.ConectionStringGEXVOC(null, "master");

            private bool _PermitirRestaurar = true;

            /// <summary>
            /// Nos indica la posibilidad de hacer o no restauraciones, es úlil por ejemplo, cuando abrimos el formulario
            /// para hacer copias de seguridad solamente.
            /// </summary>
            public bool PermitirRestaurar
            {
                get { return _PermitirRestaurar; }
                set
                {
                    _PermitirRestaurar = value;
                    btnRestore.Enabled = value;
                }
            }


        #endregion

        #region CONSTRUCTORES
            /// <summary>
            /// Constructor
            /// </summary>
            public MakeBackup()
            {
                InitializeComponent();
            }

        #endregion           

        #region CARGAS COMUNES
            private void MakeBackup_Load(object sender, EventArgs e)
            {
                //LogicaNegocio.NHibernateFactory.CloseDBConnection();

                Core.Data.BDController.FinalizarBDOperaciones();
                Core.Data.BDController.CerrarConexion();

              


                System.Configuration.AppSettingsReader ar = new System.Configuration.AppSettingsReader();
                strBackupPath = ar.GetValue("BackupFolder", typeof(string)).ToString();
                if (strBackupPath.Contains(":") == false)
                    strBackupPath = Application.StartupPath + "\\" + strBackupPath;
                if (strBackupPath.EndsWith("\\") == false)
                    strBackupPath += "\\";

                this.lnkPath.Text = strBackupPath;
              
                this.ShowBackupFiles();
            }
            private void ShowBackupFiles()
            {
                if (System.IO.Directory.Exists(this.strBackupPath))
                {
                    this.lvFilesB.Items.Clear();
                    string[] bfiles = System.IO.Directory.GetFiles(this.strBackupPath, "*." + BackupsExtension);

                    ListViewItem lvi = null;
                    System.IO.FileInfo fi = null;

                    foreach (string bfile in bfiles)
                    {
                        fi = new System.IO.FileInfo(bfile);

                        lvi = new ListViewItem();
                        lvi.Text = System.IO.Path.GetFileNameWithoutExtension(bfile);
                        lvi.Tag = bfile;
                        lvi.ImageIndex = 0;
                        lvi.SubItems.Add(fi.CreationTime.ToShortDateString() + " " + fi.CreationTime.ToLongTimeString());
                        lvi.SubItems.Add((fi.Length / 1024).ToString("0,0 KB"));
                        lvi.SubItems.Add(bfile);

                        lvFilesB.Items.Add(lvi);
                    }
                }
                else
                    System.IO.Directory.CreateDirectory(this.strBackupPath);
            }
        #endregion      

        #region FUNCIONAMIENTO GENERAL

            private void btnClose_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                this.DeleteFiles();
            }

            private void btnBackup_Click(object sender, EventArgs e)
            {
                this.CreateBackupFile();
            }

            private void lnkPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                System.Diagnostics.Process proc = System.Diagnostics.Process.Start("explorer.exe", "\"" + this.strBackupPath + "\"");
            }

            private void lvFilesB_MouseDown(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.cmsLista.Show(this.lvFilesB, e.Location);
                }
            }

            private void cmsLista_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
            {
                this.cmsList.Visible = false;
                if (e.ClickedItem == null || e.ClickedItem.Tag == null) return;

                switch (e.ClickedItem.Tag.ToString())
                {
                    case "RESTORE":
                        this.RestoreBackup();
                        break;
                    case "DELETE":
                        this.DeleteFiles();
                        break;
                    default:
                        break;
                }
            }

            private void cmsLargeIcon_Click(object sender, EventArgs e)
            {
                this.cmsList.Visible = false;
                this.lvFilesB.View = View.LargeIcon;
            }

            private void cmsSmallIcon_Click(object sender, EventArgs e)
            {
                this.cmsList.Visible = false;
                this.lvFilesB.View = View.SmallIcon;
            }

            private void cmsTile_Click(object sender, EventArgs e)
            {
                this.cmsList.Visible = false;
                this.lvFilesB.View = View.Tile;
            }

            private void cmsList_Click(object sender, EventArgs e)
            {
                this.cmsList.Visible = false;
                this.lvFilesB.View = View.List;
            }

            private void cmsDetails_Click(object sender, EventArgs e)
            {
                this.cmsList.Visible = false;
                this.lvFilesB.View = View.Details;
            }

            private void OpenConnection()
            {
                try
                {
                    if (sqlCon == null)
                        sqlCon = new System.Data.SqlClient.SqlConnection(ConnectionString);

                    if (sqlCon.State == ConnectionState.Broken || sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                }
                catch (Exception ex)
                {
                    
                    Traza.RegistrarError("Error al abrir conexión para backup. Detalle: " + ex.Message);
                        
                    Generic.AvisoError("Error al conectar al servidor.");
                 
                }
            }

            private void CloseConnection()
            {
                try
                {
                    if (sqlCon != null && (sqlCon.State != ConnectionState.Closed && sqlCon.State != ConnectionState.Broken))
                    {
                        sqlCon.Close();
                        sqlCon.Dispose();
                        sqlCon = null;
                    }
                }
                catch (Exception ex)
                {
                    Traza.RegistrarError("Error al cerrar conexión para backup. Detalle: "+ ex.Message);
                    Generic.AvisoError("Error al cerrar la conexión al servidor.");

                }
            }

            private void MakeBackup_FormClosing(object sender, FormClosingEventArgs e)
            {
                this.CloseConnection();

                if (this.RestoreMade == true)
                {
                   
                        
                    Generic.AvisoInformation("Se ha restaurado la base de datos.\nPulse ACEPTAR para reiniciar la aplicación.");
                
                    this.RestoreMade = false;
                    System.Diagnostics.Process proc = System.Diagnostics.Process.Start(Application.ExecutablePath, string.Empty);
                    this.Owner.Close();
                }
            }

            private void CreateBackupFile()
            {
                string strBackupFilename = "GEXVOC_";
                DateTime ahora = DateTime.Now;
                strBackupFilename += ahora.ToString("yyyyMMdd_HHmmss") + "." + BackupsExtension;

                bool MakeBackup = true;

                string Aviso = "";

                if (System.IO.File.Exists(strBackupPath + strBackupFilename) == true)
                {
                        
                    Aviso = "El archivo de copia de seguridad: '" + strBackupFilename + "' ya existe.\n¿Desea sobreescribirlo?";
                 

                    if (MessageBox.Show(Aviso, "Confirmación de escritura", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                    {
                        MakeBackup = false;
                        MessageBox.Show("Operación cancelada");
                    }
                }
                if (MakeBackup == true)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        this.OpenConnection();

                        System.Data.SqlClient.SqlParameter sqlparam;
                        System.Data.SqlClient.SqlCommand sqlcmd = new System.Data.SqlClient.SqlCommand("master.dbo.BackupGEXVOC", this.sqlCon);
                        sqlcmd.CommandType = CommandType.StoredProcedure;

                        sqlparam = new System.Data.SqlClient.SqlParameter("Operation", "BACKUP");
                        sqlcmd.Parameters.Add(sqlparam);

                        sqlparam = new System.Data.SqlClient.SqlParameter("DiskFileName", strBackupPath + strBackupFilename);
                        sqlcmd.Parameters.Add(sqlparam);

                        sqlparam = new System.Data.SqlClient.SqlParameter("BackupName", "Copia de seguridad completa en fecha: " + ahora.ToShortDateString() + " " + ahora.ToShortTimeString());
                        sqlcmd.Parameters.Add(sqlparam);

                        sqlcmd.ExecuteNonQuery();

                        BackupDone = true;

                        this.ShowBackupFiles();



                        Generic.AvisoInformation("Copia de seguridad completada con éxito!");
                        
                       
                    }
                    catch (Exception ex)
                    {
                        Traza.RegistrarError("Error al realizar la copia de seguridad. Detalle: "+ ex.Message);                   
                            
                        Generic.AvisoError("Error al realizar la copia de seguridad.");
                        
                    }
                    finally
                    {
                        this.CloseConnection();
                        Cursor.Current = Cursors.Arrow;
                    }
                }
            }

            private void RestoreBackup()
            {
                if (!PermitirRestaurar)
                {                 
                    Generic.AvisoInformation("La operación de restauración no se encuentra activada.");                
                    return; 
                }
                if (this.lvFilesB.SelectedItems.Count != 1)
                {
                    Generic.AvisoInformation("Debe seleccionar una única copia de seguridad para poder inciar la restauración de la misma.");                
                    return;
                }


                bool bMakeRestore = false;
                string strBackupFilename = this.lvFilesB.SelectedItems[0].Tag.ToString();

                if (System.IO.File.Exists(strBackupFilename))
                {
                    DialogResult dgr = DialogResult.Cancel;

                    if (BackupDone == false)
                    {
        
                        dgr = MessageBox.Show("Es muy recomendable realizar una copia de seguridad antes de restaurar una copia anterior.\nNo ha realizado una copia de seguridad todavía.\n¿Desea realizarla ahora?", "Realizar copia previa", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                       
                        if (dgr == DialogResult.Cancel)
                        {
                            MessageBox.Show("Operación cancelada.");
                            return;
                        }

                        if (dgr == DialogResult.Yes)
                            this.CreateBackupFile();
                    }


                    string Aviso = "¿Está seguro de querer restaurar el archivo de copia de seguridad seleccionado?\nEsto sustituira todos los datos actuales, por los datos contenidos en la copia de seguridad.";
                 
                    if (MessageBox.Show(Aviso, "Confirmación de restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        bMakeRestore = true;
                    else
                        MessageBox.Show("Operación cancelada.");
                }
                else
                {                   
                    MessageBox.Show("El archivo de copia de seguridad seleccionado no se encuentra en el disco, quizá haya sido eliminado.\nArchivo: " + strBackupFilename, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Stop);              
                    this.ShowBackupFiles();
                }

                if (bMakeRestore == true)
                {

                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        this.OpenConnection();

                        System.Data.SqlClient.SqlParameter sqlparam;
                        System.Data.SqlClient.SqlCommand sqlcmd = new System.Data.SqlClient.SqlCommand("master.dbo.BackupGEXVOC", this.sqlCon);
                        sqlcmd.CommandType = CommandType.StoredProcedure;

                        sqlparam = new System.Data.SqlClient.SqlParameter("Operation", "RESTORE");
                        sqlcmd.Parameters.Add(sqlparam);

                        sqlparam = new System.Data.SqlClient.SqlParameter("DiskFileName", strBackupFilename);
                        sqlcmd.Parameters.Add(sqlparam);

                        sqlcmd.ExecuteNonQuery();
                        this.RestoreMade = true;

                        this.ShowBackupFiles();                  
                            
                        Generic.AvisoInformation(string.Format("Se ha restaurado con éxito la copia de seguridad:\n{0}", strBackupFilename)); 
                       
                    }
                    catch (Exception ex)
                    {
                        Traza.RegistrarError("Error al restaurar la copia de seguridad. Detalle: "+ ex.Message);
                        Generic.AvisoError("Error al restaurar la copia de seguridad.");
                        
                    }
                    finally
                    {
                        this.CloseConnection();
                        Cursor.Current = Cursors.Arrow;
                    }            
                }
            }

            private void DeleteFiles()
            {
                if (this.lvFilesB.SelectedItems.Count > 0)
                {
                    string Aviso = "¿Desea eliminar el conjunto de copias de seguridad seleccionadas?";                

                    if (MessageBox.Show(Aviso, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        foreach (ListViewItem lvi in this.lvFilesB.SelectedItems)
                        {
                            try
                            {
                                System.IO.File.Delete(lvi.Tag.ToString());
                            }
                            catch (Exception ex)
                            {       
                                MessageBox.Show("No ha sido posible eliminar el archivo: \n\t" + lvi.Tag.ToString() + "\nMotivo:\n" + ex.Message);                           
                            }
                        }

                        this.ShowBackupFiles();
                    }
                    else
                        MessageBox.Show("Acción cancelada.");
                }
                else
                    MessageBox.Show("Debe seleccionar al menos un elemento para poder eliminarlo.");
                    
            }

            private void btnRestore_Click(object sender, EventArgs e)
            {
                this.RestoreBackup();
            }
        #endregion

    }
}
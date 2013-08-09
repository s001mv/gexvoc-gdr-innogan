using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GEXVOC.UI;
using GEXVOC.Core.Logic;
using System.Security.Principal;
using System.Management;
using GEXVOC.Core.Registro;
using GEXVOC.Core.Data;



namespace GEXVOC
{
    static class Program
    {
        /// <summary>
        /// Para y deshabilita el servicio de sql server 2000 si existe en la máquina.
        /// </summary>
        /// <returns>0 si todo fué correcto, mayor que 0 si hubo error.</returns>
        private static int StopAndDisableSQLServer2000()
        {
            int retValue = 0;
            try
            {
                ManagementObject classInstance = new ManagementObject("root\\CIMV2", "Win32_Service.Name='MSSQLSERVER'", null);
                classInstance.Get();

                if (classInstance.GetPropertyValue("StartMode").ToString() != "Disabled")
                {
                    // Obtiene parametros
                    ManagementBaseObject inParams = classInstance.GetMethodParameters("ChangeStartMode");

                    // Deshabilita el servicio de SQL Server 2000
                    inParams["StartMode"] = "Disabled";
                    ManagementBaseObject outParams = classInstance.InvokeMethod("ChangeStartMode", inParams, null);

                    // Para el servicio
                    outParams = classInstance.InvokeMethod("StopService", null, null);
                }
            }
            catch (Exception)
            {
                Traza.RegistrarError("Error deshabilitando servicio de SQLServer. Quizá el servicio no exista.");
            }
            return retValue;
        }

        /// <summary>
        /// Configura el puerto y propiedades de la instancia de SQL Server .\SQLEXPRESS
        /// </summary>
        /// <returns>0 si todo fué correcto, mayor que 0 si hubo error.</returns>
        private static int SetupSQLServerInstance()
        {
            const string SQLServerPort = "1433";
            int retValue = 0;
            try
            {
                ManagementScope manScope = new ManagementScope(@"\\localhost\root\Microsoft\SqlServer\ComputerManagement");
                ManagementClass serverProtocolsMan = new ManagementClass(manScope, new ManagementPath("ServerNetworkProtocol"), null);
                ManagementClass ServerProtocolProps = new ManagementClass(manScope, new ManagementPath("ServerNetworkProtocolProperty"), null);

                serverProtocolsMan.Get();
                ServerProtocolProps.Get();

                foreach (ManagementObject prot in serverProtocolsMan.GetInstances())
                {
                    prot.Get();
                    // Habilita todos los protocolos si están deshabilitadas (para permitir conexiones remotas).
                    if (prot.GetPropertyValue("Enabled").ToString() != "True" && prot.GetPropertyValue("InstanceName").ToString() == "SQLEXPRESS")
                        switch (prot.GetPropertyValue("ProtocolName").ToString())
                        {
                            case "Tcp": // TCP-IP
                            case "Via": // VIA
                            case "Np":  // Named Pipes
                            case "Sm":  // Shared Memory
                                prot.InvokeMethod("SetEnable", null);
                                break;
                            default:
                                continue;
                        }
                }

                string pName = string.Empty, pValue = string.Empty; ;
                ManagementBaseObject inParams = null;

                // Fija el puerto de escucha de SQLServer Express.
                foreach (ManagementObject prop in ServerProtocolProps.GetInstances())
                {
                    prop.Get();
                    pName = prop.GetPropertyValue("PropertyName").ToString();
                    if (
                            prop.GetPropertyValue("InstanceName").ToString() == "SQLEXPRESS" &&
                            (prop.GetPropertyValue("ProtocolName").ToString() == "Tcp" || prop.GetPropertyValue("ProtocolName").ToString() == "Via")
                       )
                    {
                        inParams = prop.GetMethodParameters("SetStringValue");

                        switch (pName)
                        {
                            case "TcpDynamicPorts":
                                inParams["StrValue"] = string.Empty;
                                break;
                            case "TcpPort":
                                if (prop.GetPropertyValue("IPAddressName").ToString() == "IPAll")
                                    inParams["StrValue"] = SQLServerPort;
                                else
                                    inParams["StrValue"] = string.Empty;
                                break;
                            case "DefaultServerPort":
                            case "ListenInfo":
                                inParams["StrValue"] = "0:" + SQLServerPort;
                                break;
                            default:
                                continue;
                        }

                        pValue = prop.GetPropertyValue("PropertyStrVal").ToString();
                        if (pValue != inParams["StrValue"].ToString())
                            prop.InvokeMethod("SetStringValue", inParams, null);
                    }
                }

                ManagementObject classInstance = new ManagementObject("root\\CIMV2", "Win32_Service.Name='MSSQL$SQLEXPRESS'", null);
                classInstance.Get();

                if (classInstance.GetPropertyValue("StartMode").ToString() != "Auto")
                {
                    inParams = classInstance.GetMethodParameters("ChangeStartMode");
                    inParams["StartMode"] = "Automatic";

                    ManagementBaseObject outParams = classInstance.InvokeMethod("ChangeStartMode", inParams, null);
                }
            }
            catch (Exception)
            {
                retValue++;
                Traza.RegistrarError("Error configurando puerto: " + SQLServerPort + ", para la instancia .\\SQLEXPRESS.");
            }

            return retValue;
        }

        /// <summary>
        /// Crea un script sql que realizará el attach de la base de datos y creará el inicio de sesión y los usuarios.
        /// </summary>
        /// <param name="PathToFiles">Ruta donde está el archivo.</param>
        /// <param name="SQLScriptName">Nombre de archivo que contendra el script.</param>
        private static void CreateScript4CreateDB(string PathToFiles, string SQLScriptName)
        {
            Traza.RegistrarInfo("\tComprobando existencia de script antiguo...");

            if (System.IO.File.Exists(PathToFiles + SQLScriptName))
                System.IO.File.Delete(PathToFiles + SQLScriptName);

            Traza.RegistrarInfo("\tGenerando script de creación de BD.");

            System.IO.StreamWriter sw = System.IO.File.CreateText(PathToFiles + SQLScriptName);
            sw.WriteLine("USE [master]");
            sw.WriteLine("GO");
            // Habilita la autenticación mixta en servidor SQL Server.
            sw.WriteLine("EXEC xp_instance_regwrite N'HKEY_LOCAL_MACHINE', N'Software\\Microsoft\\MSSQLServer\\MSSQLServer', N'LoginMode', REG_DWORD, 2");
            sw.WriteLine("GO");
            // Si existe la BD le hace un detach primero.
            sw.WriteLine("IF EXISTS (SELECT name FROM sys.databases WHERE name = N'gexvoc')");
            sw.WriteLine("EXEC master.dbo.sp_detach_db @dbname = N'gexvoc', @keepfulltextindexfile=N'true'");
            sw.WriteLine("GO");
            // Crea la BD si no existe, for attach...
            sw.WriteLine("IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'gexvoc')");
            sw.WriteLine(string.Format("CREATE DATABASE [gexvoc] ON ( FILENAME = '{0}gexvoc.mdf' ),( FILENAME = '{0}gexvoc_log.LDF' ) FOR ATTACH", PathToFiles));
            sw.WriteLine("GO");
            // Crea Login en Instancia SQL Server
            sw.WriteLine("IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'gexvoc')");
            sw.WriteLine("CREATE LOGIN [gexvoc] WITH PASSWORD=N'gexvoc', DEFAULT_DATABASE=[gexvoc], DEFAULT_LANGUAGE=[Spanish], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF");
            sw.WriteLine("GO");
            // Concede permiso de conexión
            sw.WriteLine("GRANT CONNECT TO [gexvoc]");
            sw.WriteLine("GO");
            // Habilita el usuario
            sw.WriteLine("ALTER LOGIN [gexvoc] ENABLE");
            sw.WriteLine("GO");
            sw.WriteLine("USE [gexvoc]");
            sw.WriteLine("GO");
            // Si el Usuario existe en la BD lo engancha al inicio de sesión
            sw.WriteLine("IF EXISTS (SELECT * FROM sys.database_principals WHERE name = N'gexvoc')");
            sw.WriteLine("ALTER USER [gexvoc] WITH DEFAULT_SCHEMA=[dbo]");
            sw.WriteLine("GO");
            // Crea Usuario en BD
            sw.WriteLine("IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'gexvoc')");
            sw.WriteLine("CREATE USER [gexvoc] FOR LOGIN [gexvoc] WITH DEFAULT_SCHEMA=[dbo]");
            sw.WriteLine("GO");
            // Da permisos de DBOwner al usuario gexvoc.
            sw.WriteLine("EXEC sp_addrolemember N'db_owner', N'gexvoc'");
            sw.WriteLine("GO");
            sw.WriteLine("USE [master]");
            sw.WriteLine("GO");
            // Crea Usuario en BD
            sw.WriteLine("IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'gexvoc')");
            sw.WriteLine("CREATE USER [gexvoc] FOR LOGIN [gexvoc] WITH DEFAULT_SCHEMA=[dbo]");
            sw.WriteLine("GO");
            sw.WriteLine("EXEC master.dbo.sp_addsrvrolemember @loginame = N'gexvoc', @rolename = N'sysadmin'");
            sw.WriteLine("GO");

            // Crea procedimiento almacenado en master para hacer backups
            sw.WriteLine("SET ANSI_NULLS ON");
            sw.WriteLine("GO");
            sw.WriteLine("SET QUOTED_IDENTIFIER ON");
            sw.WriteLine("GO");
            sw.WriteLine("if exists (SELECT procs.name from master.sys.procedures procs where name='BackupGexvoc') ");
            sw.WriteLine("BEGIN");
            sw.WriteLine("drop procedure dbo.BackupGexvoc;");
            sw.WriteLine("END");
            sw.WriteLine("GO");
            sw.WriteLine("EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[BackupGexvoc]");
            sw.WriteLine("    -- Add the parameters for the stored procedure here");
            sw.WriteLine("    @Operation		varchar(255),");
            sw.WriteLine("    @DiskFileName	varchar(255),");
            sw.WriteLine("    @BackupName		varchar(255) = NULL");
            sw.WriteLine("AS");
            sw.WriteLine("BEGIN");
            sw.WriteLine("    -- SET NOCOUNT ON added to prevent extra result sets from");
            sw.WriteLine("    -- interfering with SELECT statements.");
            sw.WriteLine("    SET NOCOUNT ON;");
            sw.WriteLine("    if (upper(@Operation) = ''BACKUP'') ");
            sw.WriteLine("    begin	");
            sw.WriteLine("        BACKUP DATABASE [gexvoc] TO  DISK = @DiskFileName ");
            sw.WriteLine("        WITH NOFORMAT, NOINIT,  NAME = @BackupName, SKIP, NOREWIND, NOUNLOAD,  STATS = 10;");
            sw.WriteLine("        BACKUP LOG [gexvoc] with TRUNCATE_ONLY;");
            sw.WriteLine("        exec gexvoc.dbo.ShrinkGexvocLog");
            sw.WriteLine("    end");
            sw.WriteLine("    if (upper(@Operation) = ''RESTORE'') ");
            sw.WriteLine("    begin");
            sw.WriteLine("        -- Se carga todas las conexiones a la BD gexvoc.");
            sw.WriteLine("        DECLARE spids2Kill CURSOR FAST_FORWARD for");
            sw.WriteLine("                select ");
            sw.WriteLine("                    sproc.spid");
            sw.WriteLine("                from ");
            sw.WriteLine("                    master.dbo.sysprocesses sproc ");
            sw.WriteLine("                    inner join");
            sw.WriteLine("                        master.dbo.sysdatabases sdb");
            sw.WriteLine("                      on");
            sw.WriteLine("                        sproc.dbid = sdb.dbid");
            sw.WriteLine("                where");
            sw.WriteLine("                    upper(sdb.name) = ''GEXVOC'';");
            sw.WriteLine("        declare	@spid integer;");
            sw.WriteLine("        declare @ExecCommand varchar(255);");
            sw.WriteLine("        open spids2Kill;");
            sw.WriteLine("        fetch next from spids2Kill into @spid;");
            sw.WriteLine("        while @@FETCH_STATUS = 0");
            sw.WriteLine("        begin");
            sw.WriteLine("            set @ExecCommand = ''Kill '' + convert(varchar, @spid) + '';'';");
            sw.WriteLine("            exec (@ExecCommand);");
            sw.WriteLine("            fetch next from spids2Kill into @spid;");
            sw.WriteLine("        end");
            sw.WriteLine("        close spids2Kill;");
            sw.WriteLine("        deallocate spids2Kill;");
            sw.WriteLine("        RESTORE DATABASE [gexvoc] FROM  DISK = @DiskFileName WITH REPLACE, FILE = 1,  NOUNLOAD,  STATS = 10");
            sw.WriteLine("    end");
            sw.WriteLine("END");
            sw.WriteLine("' ");
            sw.WriteLine("GO");

            sw.Close();
            sw.Dispose();
            sw = null;
        }

        /// <summary>
        /// Crea un script para hacer el detach de la BD.
        /// </summary>
        /// <param name="PathToFiles">Ruta al script.</param>
        /// <param name="SQLScriptName">Nombre del fichero de script.</param>
        private static void CreateScript4DetachDB(string PathToFiles, string SQLScriptName)
        {
            Traza.RegistrarInfo("\tComprobando existencia de script antiguo...");
            if (System.IO.File.Exists(PathToFiles + SQLScriptName))
                System.IO.File.Delete(PathToFiles + SQLScriptName);

            Traza.RegistrarInfo("\tGenerando script de separación de BD.");

            System.IO.StreamWriter sw = System.IO.File.CreateText(PathToFiles + SQLScriptName);
            sw.WriteLine("USE [master]");
            sw.WriteLine("GO");

            // Si existe la BD le hace un detach primero.
            sw.WriteLine("IF EXISTS (SELECT name FROM sys.databases WHERE name = N'gexvoc')");
            sw.WriteLine("EXEC master.dbo.sp_detach_db @dbname = N'gexvoc', @keepfulltextindexfile=N'false'");
            sw.WriteLine("GO");

            // Crea Login en Instancia SQL Server
            sw.WriteLine("IF EXISTS (SELECT * FROM sys.server_principals WHERE name = N'gexvoc')");
            sw.WriteLine("DROP LOGIN [gexvoc]");
            sw.WriteLine("GO");
            sw.Close();
            sw.Dispose();
            sw = null;
        }

        /// <summary>
        /// Ejecuta un determinado script y reinicia los servicios de SQL Server Express si se solictia
        /// </summary>
        private static int ExecuteSQLScript(string ScriptFileName, bool RestartServices)
        {
            int returnCode = 0;
            try
            {
                //Lanza un nuevo proceso para la ejecución del script de Creación de Base de datos
                System.Diagnostics.Process proc;

                //Arranca servicio de SQL Server Express por si acaso no está inciado...
                Traza.RegistrarInfo("\tIniciando Servicio SQL Server Express...");
                Program.SQLServiceCommand(ServiceCommand.Start);
                Traza.RegistrarInfo("\tServicio SQL Server Express iniciado...");

                Traza.RegistrarInfo(string.Format("\tLanzando script de BD: {0}", ScriptFileName));

                proc = System.Diagnostics.Process.Start("sqlcmd.exe", string.Format(" -S localhost\\SQLEXPRESS -i \"{0}\" -o \"{0}.log\"", ScriptFileName));
                proc.WaitForExit();
                returnCode += proc.ExitCode;
                Traza.RegistrarInfo("\tCódigo de retorno de creacion de BD: " + proc.ExitCode.ToString());

                if (RestartServices == true)
                {
                    Traza.RegistrarInfo("\tParando Servicio SQL Server Express...");
                    returnCode += Program.SQLServiceCommand(ServiceCommand.Stop);
                    Traza.RegistrarInfo("\tCódigo de retorno de parada de mssql$sqlexpress: " + returnCode);

                    Traza.RegistrarInfo("\tIniciando Servicio SQL Server Express...");
                    returnCode += Program.SQLServiceCommand(ServiceCommand.Start);
                    Traza.RegistrarInfo("\tCódigo de retorno de inicio de mssql$sqlexpress: " + returnCode);
                }

                Traza.RegistrarInfo("Proceso de creación de Bd concluido con código de retorno: " + returnCode);
            }
            catch (Exception)
            {
                Traza.RegistrarError("Error ejecutando script.");
            }

            return (returnCode);
        }

        private enum ServiceCommand
        {
            Start = 1,
            Stop = 2,
            Pause = 3,
            Resume = 4,
        }

        private static System.ServiceProcess.ServiceController SQLServerExpressService = null;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static int SQLServiceCommand(ServiceCommand svccmd)
        {
            try
            {
                if (SQLServerExpressService == null)
                {
                    System.ServiceProcess.ServiceController[] svcs = System.ServiceProcess.ServiceController.GetServices();

                    foreach (System.ServiceProcess.ServiceController svc in svcs)
                        if (svc.ServiceName.ToUpper() == "MSSQL$SQLEXPRESS")
                            Program.SQLServerExpressService = svc;
                }

                switch (svccmd)
                {
                    case ServiceCommand.Start:
                        if (Program.SQLServerExpressService.Status != System.ServiceProcess.ServiceControllerStatus.Running)
                        {
                            Program.SQLServerExpressService.Start();
                            Program.SQLServerExpressService.WaitForStatus(System.ServiceProcess.ServiceControllerStatus.Running);
                        }
                        break;
                    case ServiceCommand.Stop:
                        Program.SQLServerExpressService.Stop();
                        Program.SQLServerExpressService.WaitForStatus(System.ServiceProcess.ServiceControllerStatus.Stopped);
                        break;
                    case ServiceCommand.Pause:
                        if (Program.SQLServerExpressService.CanPauseAndContinue == true && Program.SQLServerExpressService.Status == System.ServiceProcess.ServiceControllerStatus.Running)
                        {
                            Program.SQLServerExpressService.Pause();
                            Program.SQLServerExpressService.WaitForStatus(System.ServiceProcess.ServiceControllerStatus.Paused);
                        }
                        break;
                    case ServiceCommand.Resume:
                        if (Program.SQLServerExpressService.CanPauseAndContinue == true && Program.SQLServerExpressService.Status == System.ServiceProcess.ServiceControllerStatus.Paused)
                        {
                            Program.SQLServerExpressService.Continue();
                            Program.SQLServerExpressService.WaitForStatus(System.ServiceProcess.ServiceControllerStatus.Running);
                        }
                        break;
                    default:
                        break;
                }
                return 0;
            }
            catch (Exception)
            {
                Traza.RegistrarError("Error manejando servicio de SQL Server Express.");
                return 1;
            }
        }

        private static int GrantPermissions()
        {
            // Recupera la ruta a la carpeta de backups
            System.Configuration.AppSettingsReader ar = new System.Configuration.AppSettingsReader();
            string strBackupPath = ar.GetValue("BackupFolder", typeof(string)).ToString();
            if (strBackupPath.Contains(":") == false)
                strBackupPath = Application.StartupPath + "\\" + strBackupPath;
            while (strBackupPath.EndsWith("\\"))
                strBackupPath = strBackupPath.Substring(0, strBackupPath.Length - 1);

            //System.Security.Principal.WellKnownSidType.NetworkServiceSid
            SecurityIdentifier si = new SecurityIdentifier("S-1-5-20");
            IdentityReference NSir = si.Translate(typeof(NTAccount));

            if (NSir != null)
            {
                // Concede control total al usuario Servicio de Red sobre la carpeta de backups.
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(strBackupPath);
                System.Security.AccessControl.DirectorySecurity ds = di.GetAccessControl();
                System.Security.AccessControl.FileSystemAccessRule fsar = new System.Security.AccessControl.FileSystemAccessRule(NSir, System.Security.AccessControl.FileSystemRights.FullControl, System.Security.AccessControl.InheritanceFlags.ContainerInherit, System.Security.AccessControl.PropagationFlags.InheritOnly, System.Security.AccessControl.AccessControlType.Allow);
                ds.AddAccessRule(fsar);
                fsar = new System.Security.AccessControl.FileSystemAccessRule(NSir, System.Security.AccessControl.FileSystemRights.FullControl, System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.InheritOnly, System.Security.AccessControl.AccessControlType.Allow);
                ds.AddAccessRule(fsar);
                fsar = new System.Security.AccessControl.FileSystemAccessRule(NSir, System.Security.AccessControl.FileSystemRights.FullControl, System.Security.AccessControl.InheritanceFlags.None, System.Security.AccessControl.PropagationFlags.InheritOnly, System.Security.AccessControl.AccessControlType.Allow);
                ds.AddAccessRule(fsar);

                di.SetAccessControl(ds);

                return (0);
            }
            else
                return 1;
        }

        private static int ClearFilesOnUninstall()
        {
            foreach (string file in System.IO.Directory.GetFileSystemEntries(Application.StartupPath))
            {
                try
                {
                    Traza.RegistrarInfo("Borrando el path: " + file);
                    if (System.IO.Directory.Exists(file))
                        System.IO.Directory.Delete(file, true);
                    else
                        System.IO.File.Delete(file);
                }
                catch
                {
                }
            }

            return 0;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            string SQLScriptName = "AttachDB.sql";
            string PathToFiles = Application.StartupPath + "\\";

            try
            {
                int returnCode = 0;
                string argument = string.Empty, modificador = string.Empty;
                string[] arguments;

                if (args.Length > 0)
                {
                    foreach (string arg in args)
                    {
                        Traza.RegistrarInfo("Argumento recibido: " + arg);
                        argument += arg + " ";
                    }

                    arguments = argument.Trim().Split('/');

                    foreach (string arg in arguments)
                    {
                        if (arg != string.Empty)
                        {
                            Traza.RegistrarInfo("Argumento procesado: " + arg.Trim());

                            if (arg.IndexOf(":") > -1)
                            {
                                argument = arg.Substring(0, arg.IndexOf(":")).ToUpper();
                                modificador = arg.Substring(arg.IndexOf(":") + 1);
                            }
                            else
                                argument = arg.Trim().ToUpper();

                            switch (argument)
                            {
                                case "CREATEDB":


                                    //Solo creo la base de datos en caso de que la aplicación haya sido instalada en local.
                                    //y que no exista la base de datos.
                                    if (Registro.GetSetting("TipoInstalacion","servidor") == "servidor" && !BDController.ExisteBD())
                                    {
                                        if (modificador != string.Empty) PathToFiles = modificador;
                                        if (PathToFiles.EndsWith("\\") == false) PathToFiles += "\\";

                                        SQLScriptName = "AttachDB.sql";
                                        Traza.RegistrarInfo("Iniciando proceso de creación.");

                                        if (System.IO.File.Exists(PathToFiles + "gexvoc.mdf") == false)
                                        {
                                            Traza.RegistrarInfo("No se encuentra el archivo gexvoc.mdf. Imposible hace el attach de base de datos.");
                                            returnCode++;
                                            break;
                                        }

                                        if (System.IO.File.Exists(PathToFiles + "gexvoc_log.ldf") == false)
                                        {
                                            Traza.RegistrarInfo("No se encuentra el archivo gexvoc_log.ldf. Imposible hace el attach de base de datos.");
                                            returnCode++;
                                            break;
                                        }

                                        // Para y deshabilita el servicio de SQL Server 2000
                                        returnCode += Program.StopAndDisableSQLServer2000();

                                        // Fija el puerto de SQLServer
                                        returnCode += Program.SetupSQLServerInstance();

                                        Program.CreateScript4CreateDB(PathToFiles, SQLScriptName);
                                        returnCode += Program.ExecuteSQLScript(PathToFiles + SQLScriptName, true);

                                        // Da permisos al usuario que ejecuta la instancia de SQL Server sobre la carpeta de Backups
                                        returnCode += Program.GrantPermissions();
                                                                           
                                    }

                                    break;      
                                case "DETACHDB":
                                    if (modificador != string.Empty) PathToFiles = modificador;
                                    if (PathToFiles.EndsWith("\\") == false) PathToFiles += "\\";

                                    SQLScriptName = "DetachDB.sql";
                                    Program.CreateScript4DetachDB(PathToFiles, SQLScriptName);
                                    returnCode += Program.ExecuteSQLScript(PathToFiles + SQLScriptName, false);
                                    returnCode += Program.ClearFilesOnUninstall();
                                    break;

                                case "UNINSTALL":
                                    if (modificador == string.Empty)
                                    {
                                        System.Windows.Forms.MessageBox.Show("Para desintallar Gexvoc utilice Agregar o quitar programas en el Panel de Control");
                                        returnCode = 1;
                                    }
                                    else
                                    {
                                        System.Diagnostics.Process proc;

                                        //Lanza el msiexec para quitar gexvoc...
                                        Traza.RegistrarInfo("\tIniciando desintalador de Gexvoc...");
                                        proc = System.Diagnostics.Process.Start("msiexec.exe", "/qf /x " + modificador);
                                        returnCode = 0;
                                    }

                                    break;

                                default:
                                    Traza.RegistrarInfo("Argumento no soportado.");
                                    returnCode++;
                                    break;
                            }
                        }
                    }

                    return (returnCode);
                }
            }
            catch (Exception ex)
            {
                Traza.RegistrarError("Error al procesar parámetro de linea de comandos");
                Traza.RegistrarError(ex);
                // Si hay una excepción no esperada, se pira con código de error alto
                return (10000);
            }
            finally
            {
                if (System.IO.File.Exists(PathToFiles + SQLScriptName))
                    System.IO.File.Delete(PathToFiles + SQLScriptName);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Principal frmPrincipal = null;
            try
            {
                frmPrincipal = new Principal();
                Application.Run(frmPrincipal);
            }
            catch (Exception ex)
            {
                GEXVOC.UI.Clases.Generic.AvisoError(ex.Message);
            }          

            return (0);
        }
    
    }
}

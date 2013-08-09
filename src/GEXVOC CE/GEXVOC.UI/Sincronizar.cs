using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using System.IO;
using GEXVOC.Core.Data;
using System.Collections;
using System.Reflection;

namespace GEXVOC.UI
{
    public partial class Sincronizar : GEXVOC.UI.Principal
    {
        public Sincronizar()
        {
            InitializeComponent();
        }
        #region Descargar Datos
        private void BDescargar_Click(object sender, EventArgs e)
        {
            bool bResult;
            try
            {
                DialogResult r = Program.Preguntar("¿Desea realizar la Descarga de datos al PC? Recuerde que todos los datos de la PDA se borrarán y será actualizada con los últimos datos del PC.");
                if (r == DialogResult.Yes)
                {
                    bResult = Iniciar_Proceso_Descarga();
                    if (bResult)
                    {
                        Program.Informar("Base de datos descargada con éxito");
                    }
                    else
                    {
                        Program.Informar("Errores Descargando base de datos");
                    }
                    //Aquí se inicia la descarga de datos
                }
                else
                {
                    MessageBox.Show("no");
                    //Aqui no se hace nada
                }

            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
                Program.Alertar("La aplicación ha realizado una operación no válida.");
            }
        }
        private bool Iniciar_Proceso_Descarga()
        {
            bool resultado = true;
            string cadenadestino = Configurador.CSLocal;
            string cadenaorigen = Configurador.CSRemota;
            try
            {
                //if de si existe la BD
                if (File.Exists(Configurador.BD))
                    File.Delete(Configurador.BD); //SE BORRA

                //Crear la BD
                Crear_BD(cadenadestino); //SE CREA

                //Crear las tablas
              bool creadas =  Crear_Tablas(cadenadestino); //SE CREAN LAS TABLAS
                //Descargar datos                
              if (creadas)
              {
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Aborto"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Alta"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "AniLot"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Animal"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Baja"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "CondicionCorporal"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "CondicionJuridica"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Configuracion"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Conformacion"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Control"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Cubricion"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "DiagAnimal"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "DiagInseminacion"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Enfermedad"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Especie"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Estado"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Estancia"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "ExpEsp"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Explotacion"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Facilidad"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Familia"))
                  {
                      resultado = false;
                  }
                  /*****************************************************************************/
                  //if (!Descargar_Datos(cadenadestino, cadenaorigen, "Gasto"))
                  //{
                  //    resultado = false;
                  //}
                  /*****************************************************************************/
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Inseminacion"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "InsPar"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Lactacion"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "LoteAnimal"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Momento"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Motivo"))
                  {
                      resultado = false;
                  }
                  /********************************************************************************/
                  // if (!Descargar_Datos(cadenadestino, cadenaorigen, "Movimiento"))
                  // {
                  //     resultado = false;
                  // }
                  /********************************************************************************/
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Municipio"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Naturaleza"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Parto"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Peso"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "TipoProducto"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Producto"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Provincia"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Raza"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Receta"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Secado"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "StatusControl"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "StatusOrdeno"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Stock"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Talla"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "TipoAborto"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "TipoAlta"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "TipoBaja"))
                  {
                      resultado = false;
                  }

                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "TipoCondicion"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "TipoCubricion"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "TipoDiagnostico"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "TipoEnfermedad"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "TipoInseminacion"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "TipoParto"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "TipoPersonal"))
                  {
                      resultado = false;
                  }

                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "TipoSecado"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "TratEnfermedad"))
                  {
                      resultado = false;
                  }
                  if (!Descargar_Datos(cadenadestino, cadenaorigen, "Veterinario"))
                  {
                      resultado = false;
                  }
              }
              else
              {
                  resultado = false;
              }
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
                resultado = false;
            }
            return resultado;

        }
        private void Crear_BD(string cadenadestino)
        {
            try
            {
                SqlCeEngine engine = new SqlCeEngine(cadenadestino);
                engine.CreateDatabase();                
                engine.Dispose();                
            }
            catch (Exception ex)
            {
                Program.Alertar("Error Creando Base de datos");
                Traza.Registrar(ex);
            }
        }
        private bool Crear_Tablas(string cadenadestino)
        {
            StreamReader lector;
            string linea = "";
            SqlCeConnection conn;
            SqlCeCommand cmdInsert;
            int i;
            cmdInsert = new SqlCeCommand();
            conn = new SqlCeConnection(cadenadestino);
            cmdInsert.Connection = conn;
            conn.Open();
            lector = File.OpenText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase),"gexvocce.sql"));                
            try
            {
                

                // Lee linea a linea
                linea = lector.ReadToEnd();
                linea = linea.Replace("\n", " ");
                linea = linea.Replace("\r", " ");
                linea = linea.Replace("\t", " ");
                String[] linea2 =  linea.Split(';');
                
                for (i = 0; i < linea2.Length; i++)
                {
                    if (linea2[i] != "")
                    {
                        //MessageBox.Show(linea2[i]);
                        cmdInsert.CommandText = linea2[i];
                        cmdInsert.ExecuteNonQuery();
                    }
                }               
                lector.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
                lector.Close();
                conn.Close();
                Program.Informar("Problemas al cargar el fichero");
                return false;
            }
            return true;
        }
        private bool Descargar_Datos(string cadenadestino, string cadenaorigen, string tabla)
        {
            SqlCommand cmdOrigen;
            SqlCeCommand cmdDestino;
            SqlCeConnection connDestino;
            SqlConnection connOrigen;
            DataSet dsOrigen;
            DataSet dsDestino;
            SqlCeCommandBuilder cbDestino;
            SqlDataAdapter daOrigen;
            SqlCeDataAdapter daDestino;

            
            

            connOrigen = new SqlConnection();
            connOrigen.ConnectionString = cadenaorigen;
            connDestino = new SqlCeConnection();
            connDestino.ConnectionString = cadenadestino;

            try
            {
                QueTabla.Text = tabla;
                QueTabla.Refresh();
                connDestino.Open();
                connOrigen.Open();

                cmdOrigen = new SqlCommand();
                cmdOrigen.Connection = connOrigen;
                cmdDestino = new SqlCeCommand();
                cmdDestino.Connection = connDestino;

                if (tabla == "Producto")
                {
                    daOrigen = new SqlDataAdapter();
                    daDestino = new SqlCeDataAdapter();
                    dsOrigen = new DataSet();
                    dsDestino = new DataSet();

                    cmdOrigen.CommandText = "SELECT * FROM " + tabla + "  WHERE IdTipo = (SELECT Id From TipoProducto WHERE Descripcion = 'PRODUCCIÓN') OR IdTipo = (SELECT Id From TipoProducto WHERE Descripcion = 'SANIDAD') ";
                    daOrigen.SelectCommand = cmdOrigen;
                    dsOrigen.Clear();
                    daOrigen.Fill(dsOrigen, tabla);

                    //Hago lo mismo en el pocket (esta vacio)
                    cmdDestino.CommandText = "SELECT * FROM " + tabla;


                    daDestino.SelectCommand = cmdDestino;
                    cbDestino = new SqlCeCommandBuilder(daDestino);
                    dsDestino.Clear();
                    daDestino.Fill(dsDestino, tabla);

                    //Le hago el truco del dataset
                    dsDestino = dsOrigen;
                    //Marco las filas como añadidas
                    foreach (DataRow rowTmp in dsDestino.Tables[tabla].Rows)
                    {
                        rowTmp.SetAdded();
                    }
                    //Actualizo el dataadapter del pocket
                    daDestino.Update(dsDestino, tabla);
                    //limpio los datasets
                    dsOrigen.Clear();
                    dsDestino.Clear();
                }
                else if (tabla == "Stock")
                {
                    daOrigen = new SqlDataAdapter();
                    daDestino = new SqlCeDataAdapter();
                    dsOrigen = new DataSet();
                    dsDestino = new DataSet();



                    cmdOrigen.CommandText = "SELECT * FROM " + tabla + " WHERE IdProducto IN (SELECT Id From Producto WHERE IdTipo = (SELECT Id From TipoProducto WHERE Descripcion = 'SANIDAD') OR IdTipo = (SELECT Id From TipoProducto WHERE Descripcion = 'PRODUCCIÓN')) ";
                    daOrigen.SelectCommand = cmdOrigen;
                    dsOrigen.Clear();
                    daOrigen.Fill(dsOrigen, tabla);

                    //Hago lo mismo en el pocket (esta vacio)
                    cmdDestino.CommandText = "SELECT * FROM " + tabla;


                    daDestino.SelectCommand = cmdDestino;
                    cbDestino = new SqlCeCommandBuilder(daDestino);
                    dsDestino.Clear();
                    daDestino.Fill(dsDestino, tabla);

                    //Le hago el truco del dataset
                    dsDestino = dsOrigen;
                    //Marco las filas como añadidas
                    foreach (DataRow rowTmp in dsDestino.Tables[tabla].Rows)
                    {
                        rowTmp.SetAdded();
                    }
                    //Actualizo el dataadapter del pocket
                    daDestino.Update(dsDestino, tabla);
                    //limpio los datasets
                    dsOrigen.Clear();
                    dsDestino.Clear();
                }
                else
                {
                    //Busco los datos en el servidor
                    daOrigen = new SqlDataAdapter();
                    daDestino = new SqlCeDataAdapter();
                    dsOrigen = new DataSet();
                    dsDestino = new DataSet();
                    
                    cmdOrigen.CommandText = "SELECT * FROM " + tabla;
                    daOrigen.SelectCommand = cmdOrigen;
                    dsOrigen.Clear();
                    daOrigen.Fill(dsOrigen, tabla);

                    //Hago lo mismo en el pocket (esta vacio)
                    cmdDestino.CommandText = "SELECT * FROM " + tabla;


                    daDestino.SelectCommand = cmdDestino;
                    cbDestino = new SqlCeCommandBuilder(daDestino);
                    dsDestino.Clear();
                    daDestino.Fill(dsDestino, tabla);

                    //Le hago el truco del dataset
                    dsDestino = dsOrigen;
                    //Marco las filas como añadidas
                    foreach (DataRow rowTmp in dsDestino.Tables[tabla].Rows)
                    {
                        rowTmp.SetAdded();
                    }
                    //Actualizo el dataadapter del pocket
                    daDestino.Update(dsDestino, tabla);
                    //limpio los datasets
                    dsOrigen.Clear();
                    dsDestino.Clear();
                }
                connDestino.Close();
                connOrigen.Close();
            }
            catch (SqlCeException ex)
            {
                connDestino.Close();
                connOrigen.Close();
                Traza.Registrar(ex);
                return false;
            }
            catch (SqlException ex)
            {
                connDestino.Close();
                connOrigen.Close();
                Traza.Registrar(ex);
                return false;
            }
            catch (Exception ex)
            {
                connDestino.Close();
                connOrigen.Close();
                Traza.Registrar(ex);
                return false;
            }
            return true;
        }
#endregion
        #region subir datos
        private void Subir_Click(object sender, EventArgs e)
        {
            bool bResult;
            try
            {
                DialogResult r = Program.Preguntar("¿Desea realizar La subida de datos desde el pocket al pc?");
                if (r == DialogResult.Yes)
                {
                    bResult = Iniciar_Proceso_Subida();
                    if (bResult)
                    {
                        Program.Informar("base de datos descargada con exito");
                    }
                    else
                    {
                        Program.Informar("Errores Descargando base de datos");
                    }
                    //Aquí se inicia la descarga de datos
                }
                else
                {
                    MessageBox.Show("no");
                    //Aqui no se hace nada
                }

            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
                Program.Alertar("La aplicación ha realizado una operación no válida.");
            }
        }
        private bool Iniciar_Proceso_Subida()
        {
            bool resultado2 = true;
            string cadenadestino = Configurador.CSRemota;
            string cadenaorigen = Configurador.CSLocal;
            if (!Subir_Datos(cadenadestino, cadenaorigen, "Animal"))
            {
                resultado2 = false;
            }            
            return resultado2;
        }
        private bool Subir_Datos(string cadenadestino, string cadenaorigen, string tabla)
        {
            //Busco la ruta de la base de datos
            //bool resultado = true;
            string cadenaOrigen = cadenaorigen;
            string cadenaDestino = cadenadestino;
            SqlConnection connDestino = new SqlConnection();
            SqlTransaction sqlTransDestino;
            SqlCommand cmdDestino = new SqlCommand();

            //DataSet dsOrigen;
            //DataSet dsDestino;

            int IdOrigen;
            int IdDestino;

            int IdOrigenMacho;
            int IdDestinoMacho;
            int IdOrigenHembra;
            int IdDestinoHembra;
            int IdOrigenDiagnostico;
            int IdDestinoDiagnostico;

            Hashtable AnimalHash = new Hashtable();
            Hashtable InseminacionesHash = new Hashtable();
            Hashtable DiagAnimal = new Hashtable();
           // Hashtable DiagnosticoHash = new Hashtable();

            ////Conectando
           

            connDestino.ConnectionString = cadenaDestino;
            connDestino.Open();
            //MessageBox.Show(connDestino.State.ToString());

            sqlTransDestino = connDestino.BeginTransaction(IsolationLevel.ReadCommitted);

            try //Transaccion
            {
                DataSet dsOrigen;
                DataSet dsDestino;
                //Para el push con transaccion necesito las conexiones              

                dsOrigen = new DataSet();
                dsDestino = new DataSet();

                cmdDestino.Connection = sqlTransDestino.Connection;
                cmdDestino.Transaction = sqlTransDestino;
                #region animales alta y baja
                #region animales
                //animales
                dsOrigen = SqlCeHelper.ExecuteQuery("SELECT * FROM Animal WHERE modificable=1");
                foreach (DataRow drAnimal in dsOrigen.Tables[0].Rows)
                {
                    IdOrigen = Convert.ToInt32(drAnimal["Id"]);
                    cmdDestino.CommandText = "INSERT INTO Animal (IdRaza, IdTalla, IdConformacion, IdExplotacion, DIB, Crotal, Tatuaje, Nombre, FechaNacimiento, Sexo, IdEstado,Modificable) VALUES (" +
                                                                   Program.ConvertirObjectInteger(drAnimal["IdRaza"]) + ", " +
                                                                   Program.ConvertirObjectInteger(drAnimal["IdTalla"]) + ", " +
                                                                   Program.ConvertirObjectInteger(drAnimal["IdConformacion"]) + ", " +
                                                                   Program.ConvertirObjectInteger(drAnimal["IdExplotacion"]) + ", " +
                                                                   Program.ConvertirString(drAnimal["DIB"]) + ", " +
                                                                   Program.ConvertirString(drAnimal["Crotal"]) + ", " +
                                                                   Program.ConvertirString(drAnimal["Tatuaje"]) + ", " +
                                                                   Program.ConvertirString(drAnimal["Nombre"]) + ", " +
                                                                   Program.ConvertirString(drAnimal["FechaNacimiento"]) + ", " +
                                                                   Program.ConvertirString(drAnimal["Sexo"]) + ", " +
                                                                   Program.ConvertirObjectInteger(drAnimal["IdEstado"]) + " ," +
                                                                   '0'+" "+
                                                                    ")";
                    //MessageBox.Show(connDestino.State.ToString()) ;
                    cmdDestino.ExecuteNonQuery();
                    cmdDestino.CommandText = "Select @@Identity FROM Animal";
                    IdDestino = Convert.ToInt32(cmdDestino.ExecuteScalar());

                    AnimalHash.Add(IdOrigen, IdDestino);

                }
                #endregion
                #region alta de animales
                //Alta
                dsOrigen = SqlCeHelper.ExecuteQuery("SELECT * FROM Alta WHERE modificable=1");
                foreach (DataRow drAlta in dsOrigen.Tables[0].Rows)
                {

                    IdOrigen = Convert.ToInt32(drAlta["IdAnimal"]);
                    if (AnimalHash.ContainsKey(IdOrigen))
                        IdDestino = Convert.ToInt32(AnimalHash[IdOrigen]);
                    else
                        IdDestino = IdOrigen;                    
                    cmdDestino.CommandText = "INSERT INTO Alta (IdTipo, IdAnimal, Detalle, Fecha, Modificable) VALUES (" +
                                                                   Program.ConvertirObjectInteger(drAlta["IdTipo"]) + ", " +
                                                                   IdDestino + ", " +
                                                                   Program.ConvertirString(drAlta["Detalle"]) + ", " +
                                                                   Program.ConvertirString(drAlta["Fecha"]) + ", " +
                                                                   '0' + " " +
                                                                    ")";
                    
                    cmdDestino.ExecuteNonQuery();
                }
                #endregion
                #region baja de animales
                //Baja
                dsOrigen = SqlCeHelper.ExecuteQuery("SELECT * FROM Baja WHERE modificable=1");
                foreach (DataRow drBaja in dsOrigen.Tables[0].Rows)
                {

                    IdOrigen = Convert.ToInt32(drBaja["IdAnimal"]);
                    if (AnimalHash.ContainsKey(IdOrigen))
                        IdDestino = Convert.ToInt32(AnimalHash[IdOrigen]);
                    else
                        IdDestino = IdOrigen;
                    cmdDestino.CommandText = "INSERT INTO Baja (IdTipo, IdAnimal, Detalle, Fecha, Modificable) VALUES (" +
                                                                   Program.ConvertirObjectInteger(drBaja["IdTipo"]) + ", " +
                                                                   IdDestino + ", " +
                                                                   Program.ConvertirString(drBaja["Detalle"]) + ", " +
                                                                   Program.ConvertirString(drBaja["Fecha"]) + ", " +
                                                                   '0' + " " +
                                                                    ")";

                    cmdDestino.ExecuteNonQuery();
                }
                #endregion
                #endregion
                #region inseminaciones y diagnostico de gestacion
                //Inseminaciones             
                dsOrigen = SqlCeHelper.ExecuteQuery("SELECT * FROM Inseminacion WHERE modificable=1");
                foreach (DataRow drInseminaciones in dsOrigen.Tables[0].Rows)
                {
                    IdOrigen = Convert.ToInt32(drInseminaciones["Id"]);

                    IdOrigenMacho = Convert.ToInt32(drInseminaciones["IdMacho"]);
                    if (AnimalHash.ContainsKey(IdOrigenMacho))
                        IdDestinoMacho = Convert.ToInt32(AnimalHash[IdOrigenMacho]);
                    else
                        IdDestinoMacho = IdOrigenMacho;

                    IdOrigenHembra = Convert.ToInt32(drInseminaciones["IdHembra"]);
                    if (AnimalHash.ContainsKey(IdOrigenHembra))
                        IdDestinoHembra = Convert.ToInt32(AnimalHash[IdOrigenHembra]);
                    else
                        IdDestinoHembra = IdOrigenHembra;




                    cmdDestino.CommandText = "INSERT INTO Inseminacion (IdMacho, IdHembra, IdTipo, IdVeterinario, IdEmbrion, Numero, Dosis, Fecha,Modificable) VALUES (" +
                                                                   IdDestinoMacho + ", " +
                                                                   IdDestinoHembra + ", " +
                                                                   Program.ConvertirObjectInteger(drInseminaciones["IdTipo"]) + ", " +
                                                                   Program.ConvertirObjectInteger(drInseminaciones["IdVeterinario"]) + ", " +
                                                                   Program.ConvertirObjectInteger(drInseminaciones["IdEmbrion"]) + ", " +
                                                                   Program.ConvertirObjectInteger(drInseminaciones["Numero"]) + ", " +
                                                                   Program.ConvertirObjectInteger(drInseminaciones["Dosis"]) + ", " +
                                                                   Program.ConvertirString(drInseminaciones["Fecha"]) + ", " +
                                                                   '0' + " " +
                                                                    ")";
                    //MessageBox.Show(connDestino.State.ToString()) ;
                    cmdDestino.ExecuteNonQuery();
                    cmdDestino.CommandText = "Select @@Identity FROM Inseminacion";
                    IdDestino = Convert.ToInt32(cmdDestino.ExecuteScalar());
                    InseminacionesHash.Add(IdOrigen, IdDestino);
                }


                /*******************************************************************/
                //DiagInseminacion
                dsOrigen = SqlCeHelper.ExecuteQuery("SELECT * FROM DiagInseminacion WHERE Modificable='True'");
                foreach (DataRow drDiagInseminacion in dsOrigen.Tables[0].Rows)
                {
                    IdOrigen = Convert.ToInt32(drDiagInseminacion["IdAnimal"]);
                    if (AnimalHash.ContainsKey(IdOrigen))
                        IdDestino = Convert.ToInt32(AnimalHash[IdOrigen]);
                    else
                        IdDestino = IdOrigen;
                    cmdDestino.CommandText = "INSERT INTO DiagInseminacion (IdTipo,IdAnimal,Fecha,Resultado,DiasGestacion,Modificable) VALUES (" +
                                                                   Program.ConvertirObjectInteger(drDiagInseminacion["IdTipo"]) + ", " +
                                                                   IdDestino + ", " +
                                                                   Program.ConvertirString(drDiagInseminacion["Fecha"]) + ", " +
                                                                   Program.ConvertirString(drDiagInseminacion["Resultado"]) + ", " +
                                                                   Program.ConvertirObjectInteger(drDiagInseminacion["DiasGestacion"]) + ", " +
                                                                  '0' + " " +
                                                                  ")";

                    //MessageBox.Show(connDestino.State.ToString());
                    cmdDestino.ExecuteNonQuery();

                }
                /*******************************************************************/

                #endregion
                #region Lactacion
                //Lactacion             
                dsOrigen = SqlCeHelper.ExecuteQuery("SELECT * FROM Lactacion WHERE modificable=1");
                foreach (DataRow drLactaciones in dsOrigen.Tables[0].Rows)
                {
                    IdOrigen = Convert.ToInt32(drLactaciones["Id"]);

                    IdOrigenHembra = Convert.ToInt32(drLactaciones["IdHembra"]);
                    if (AnimalHash.ContainsKey(IdOrigenHembra))
                        IdDestinoHembra = Convert.ToInt32(AnimalHash[IdOrigenHembra]);
                    else
                        IdDestinoHembra = IdOrigenHembra;




                    cmdDestino.CommandText = "INSERT INTO Lactacion (IdHembra,Numero,FechaInicio,FechaFin,Modificable) VALUES (" +                                                                   
                                                                   IdDestinoHembra + ", " +
                                                                   Program.ConvertirObjectInteger(drLactaciones["Numero"]) + ", " +
                                                                   Program.ConvertirString(drLactaciones["FechaInicio"]) + ", " +
                                                                   Program.ConvertirString(drLactaciones["FechaFin"]) + ", " +                                                                   
                                                                   '0' + " " +
                                                                    ")";
                    //MessageBox.Show(connDestino.State.ToString()) ;
                    cmdDestino.ExecuteNonQuery();
                    cmdDestino.CommandText = "Select @@Identity FROM Lactacion";
                    IdDestino = Convert.ToInt32(cmdDestino.ExecuteScalar());
                   // InseminacionesHash.Add(IdOrigen, IdDestino);
                }
                #endregion
                #region Partos
                //Partos             
                dsOrigen = SqlCeHelper.ExecuteQuery("SELECT * FROM Parto WHERE modificable=1");
                foreach (DataRow drPartos in dsOrigen.Tables[0].Rows)
                {
                    IdOrigen = Convert.ToInt32(drPartos["Id"]);

                    IdOrigenHembra = Convert.ToInt32(drPartos["IdHembra"]);
                    if (AnimalHash.ContainsKey(IdOrigenHembra))
                        IdDestinoHembra = Convert.ToInt32(AnimalHash[IdOrigenHembra]);
                    else
                        IdDestinoHembra = IdOrigenHembra;

                    cmdDestino.CommandText = "INSERT INTO Parto (IdHembra,IdTipo,IdFacilidad,Numero,Vivos,Muertos,CausaMuerte,Fecha,Modificable) VALUES (" +
                                                                   IdDestinoHembra + ", " +
                                                                   Program.ConvertirObjectInteger(drPartos["IdTipo"]) + ", " +
                                                                   Program.ConvertirObjectInteger(drPartos["IdFacilidad"]) + ", " +
                                                                   Program.ConvertirObjectInteger(drPartos["Numero"]) + ", " +
                                                                   Program.ConvertirObjectInteger(drPartos["Vivos"]) + ", " +
                                                                   Program.ConvertirObjectInteger(drPartos["Muertos"]) + ", " +
                                                                   Program.ConvertirString(drPartos["CausaMuerte"]) + ", " +
                                                                   Program.ConvertirString(drPartos["Fecha"]) + ", " +                                                                   
                                                                   '0' + " " +
                                                                    ")";
                    //MessageBox.Show(connDestino.State.ToString()) ;
                    cmdDestino.ExecuteNonQuery();
                    cmdDestino.CommandText = "Select @@Identity FROM Parto";
                    IdDestino = Convert.ToInt32(cmdDestino.ExecuteScalar());
                    // InseminacionesHash.Add(IdOrigen, IdDestino);
                }
                #endregion
                #region Pesos
                //Pesos             
                dsOrigen = SqlCeHelper.ExecuteQuery("SELECT * FROM Peso WHERE modificable=1");
                foreach (DataRow drPesos in dsOrigen.Tables[0].Rows)
                {
                    IdOrigen = Convert.ToInt32(drPesos["Id"]);

                    IdOrigenHembra = Convert.ToInt32(drPesos["IdAnimal"]);
                    if (AnimalHash.ContainsKey(IdOrigenHembra))
                        IdDestinoHembra = Convert.ToInt32(AnimalHash[IdOrigenHembra]);
                    else
                        IdDestinoHembra = IdOrigenHembra;

                    cmdDestino.CommandText = "INSERT INTO Peso (IdMomento,IdAnimal,Peso,Fecha,Modificable) VALUES (" +
                                                                   Program.ConvertirObjectInteger(drPesos["IdMomento"]) + ", " +
                                                                   IdDestinoHembra + ", " +                                                                   
                                                                   Program.ConvertirObjectDecimal(drPesos["Peso"]) + ", " +                                                                   
                                                                   Program.ConvertirString(drPesos["Fecha"]) + ", " +
                                                                   '0' + " " +
                                                                    ")";
                    //MessageBox.Show(connDestino.State.ToString()) ;
                    cmdDestino.ExecuteNonQuery();
                    cmdDestino.CommandText = "Select @@Identity FROM Peso";
                    IdDestino = Convert.ToInt32(cmdDestino.ExecuteScalar());
                    // InseminacionesHash.Add(IdOrigen, IdDestino);
                }
                #endregion
                #region Secados
                //SEcados             
                dsOrigen = SqlCeHelper.ExecuteQuery("SELECT * FROM Secado WHERE modificable=1");
                foreach (DataRow drSecado in dsOrigen.Tables[0].Rows)
                {
                    IdOrigen = Convert.ToInt32(drSecado["Id"]);

                    IdOrigenHembra = Convert.ToInt32(drSecado["IdHembra"]);
                    if (AnimalHash.ContainsKey(IdOrigenHembra))
                        IdDestinoHembra = Convert.ToInt32(AnimalHash[IdOrigenHembra]);
                    else
                        IdDestinoHembra = IdOrigenHembra;

                    cmdDestino.CommandText = "INSERT INTO Secado (IdTipo,IdMotivo,IdHembra,Fecha,Modificable) VALUES (" +
                                                                   Program.ConvertirObjectInteger(drSecado["IdTipo"]) + ", " +
                                                                   Program.ConvertirObjectInteger(drSecado["IdMotivo"]) + ", " +
                                                                   IdDestinoHembra + ", " +
                                                                   Program.ConvertirString(drSecado["Fecha"]) + ", " +
                                                                   '0' + " " +
                                                                    ")";
                    //MessageBox.Show(connDestino.State.ToString()) ;
                    cmdDestino.ExecuteNonQuery();
                    cmdDestino.CommandText = "Select @@Identity FROM Peso";
                    IdDestino = Convert.ToInt32(cmdDestino.ExecuteScalar());
                    // InseminacionesHash.Add(IdOrigen, IdDestino);
                }
                #endregion
                #region Cubriciones
                //Cubriciones             
                dsOrigen = SqlCeHelper.ExecuteQuery("SELECT * FROM Cubricion WHERE modificable=1");
                foreach (DataRow drCubricion in dsOrigen.Tables[0].Rows)
                {
                    IdOrigen = Convert.ToInt32(drCubricion["Id"]);

                    //IdOrigenHembra = Convert.ToInt32(drCubricion["IdHembra"]);
                    //if (AnimalHash.ContainsKey(IdOrigenHembra))
                    //    IdDestinoHembra = Convert.ToInt32(AnimalHash[IdOrigenHembra]);
                    //else
                    //    IdDestinoHembra = IdOrigenHembra;

                    cmdDestino.CommandText = "INSERT INTO Cubricion (IdTipo,IdLote,FechaInicio,FechaFin,Modificable) VALUES (" +
                                                                   Program.ConvertirObjectInteger(drCubricion["IdTipo"]) + ", " +
                                                                   Program.ConvertirObjectInteger(drCubricion["IdLote"]) + ", " +
                                                                   Program.ConvertirString(drCubricion["FechaInicio"]) + ", " +
                                                                   Program.ConvertirString(drCubricion["FechaFin"]) + ", " +
                                                                   '0' + " " +
                                                                    ")";
                    //MessageBox.Show(connDestino.State.ToString()) ;
                    cmdDestino.ExecuteNonQuery();
                    cmdDestino.CommandText = "Select @@Identity FROM Cubricion";
                    IdDestino = Convert.ToInt32(cmdDestino.ExecuteScalar());
                    // InseminacionesHash.Add(IdOrigen, IdDestino);
                }
                #endregion
                #region DiagAnimal
                //DiagAnimal             
                dsOrigen = SqlCeHelper.ExecuteQuery("SELECT * FROM DiagAnimal WHERE modificable=1");
                foreach (DataRow drDiagAnimal in dsOrigen.Tables[0].Rows)
                {
                    IdOrigen = Convert.ToInt32(drDiagAnimal["Id"]);

                    IdOrigenHembra = Convert.ToInt32(drDiagAnimal["IdAnimal"]);
                    if (AnimalHash.ContainsKey(IdOrigenHembra))
                        IdDestinoHembra = Convert.ToInt32(AnimalHash[IdOrigenHembra]);
                    else
                        IdDestinoHembra = IdOrigenHembra;

                    cmdDestino.CommandText = "INSERT INTO DiagAnimal (IdAnimal,IdEnfermedad,IdVeterinario,Diagnostico,Fecha,Modificable) VALUES (" +
                          IdDestinoHembra + ", " +
                                                                   Program.ConvertirObjectInteger(drDiagAnimal["IdEnfermedad"]) + ", " +
                                                                   Program.ConvertirObjectInteger(drDiagAnimal["IdVeterinario"]) + ", " +
                                                                   Program.ConvertirString(drDiagAnimal["Diagnostico"]) + ", " +
                                                                   Program.ConvertirString(drDiagAnimal["Fecha"]) + ", " +
                                                                   '0' + " " +
                                                                    ")";
                    //MessageBox.Show(connDestino.State.ToString()) ;
                    cmdDestino.ExecuteNonQuery();
                    cmdDestino.CommandText = "Select @@Identity FROM DiagAnimal";
                    IdDestino = Convert.ToInt32(cmdDestino.ExecuteScalar());
                    DiagAnimal.Add(IdOrigen, IdDestino);

                    // InseminacionesHash.Add(IdOrigen, IdDestino);
                }
                #endregion
                #region Tratamiento
                //Tratamiento             
                dsOrigen = SqlCeHelper.ExecuteQuery("SELECT * FROM TratEnfermedad WHERE modificable=1");
                foreach (DataRow drTratEnfermedad in dsOrigen.Tables[0].Rows)
                {
                    IdOrigen = Convert.ToInt32(drTratEnfermedad["Id"]);

                    IdOrigenDiagnostico = Convert.ToInt32(drTratEnfermedad["IdDiagnostico"]);
                    if (AnimalHash.ContainsKey(IdOrigenDiagnostico))
                        IdDestinoDiagnostico = Convert.ToInt32(DiagAnimal[IdOrigenDiagnostico]);
                    else
                        IdDestinoDiagnostico = IdOrigenDiagnostico;

                    cmdDestino.CommandText = "INSERT INTO TratEnfermedad (IdDiagnostico,IdVeterinario,Detalle,Duracion,SupresionLeche,SupresionCarne,Fecha,Modificable) VALUES (" +
                        IdDestinoDiagnostico + ", " +
                        Program.ConvertirObjectInteger(drTratEnfermedad["IdVeterinario"]) + ", " +
                        Program.ConvertirString(drTratEnfermedad["Detalle"]) + ", " +
                        Program.ConvertirObjectInteger(drTratEnfermedad["Duracion"]) + ", " +
                        Program.ConvertirObjectDecimal(drTratEnfermedad["SupresionLeche"]) + ", " +
                        Program.ConvertirObjectDecimal(drTratEnfermedad["SupresionCarne"]) + ", " +
                        Program.ConvertirString(drTratEnfermedad["Fecha"]) + ", " +
                        '0' + " " +
                        ")";
                    //MessageBox.Show(connDestino.State.ToString()) ;
                    cmdDestino.ExecuteNonQuery();
                    cmdDestino.CommandText = "Select @@Identity FROM TratEnfermedad";
                    IdDestino = Convert.ToInt32(cmdDestino.ExecuteScalar());
                    // InseminacionesHash.Add(IdOrigen, IdDestino);
                }
                #endregion





                //Condicion Corporal
                dsOrigen = SqlCeHelper.ExecuteQuery("SELECT * FROM CondicionCorporal WHERE modificable=1");
                foreach (DataRow drCondicionCorporal in dsOrigen.Tables[0].Rows)
                {

                    IdOrigen = Convert.ToInt32(drCondicionCorporal["IdHembra"]);
                    if (AnimalHash.ContainsKey(IdOrigen))
                        IdDestino = Convert.ToInt32(AnimalHash[IdOrigen]);
                    else
                        IdDestino = IdOrigen;
                    cmdDestino.CommandText = "INSERT INTO CondicionCorporal (IdTipo, IdHembra, Fecha, Modificable) VALUES (" +
                                                                   Program.ConvertirObjectInteger(drCondicionCorporal["IdTipo"]) + ", " +
                                                                   IdDestino + ", " +
                                                                   Program.ConvertirString(drCondicionCorporal["Fecha"]) + ", " +
                                                                   '0' + " " +
                                                                    ")";

                    cmdDestino.ExecuteNonQuery();
                }
                
                //Cierro la transaccion
                sqlTransDestino.Commit();
                connDestino.Close();


            }
            catch (SqlException ex)
            {
                Traza.Registrar(ex);
                sqlTransDestino.Rollback();
                if (connDestino.State == ConnectionState.Open)
                    connDestino.Close();
                return false;
            }
            catch (Exception ex)
            {
                ////Fin Transacción   
                //Cierro la transaccion
                Traza.Registrar(ex);
                sqlTransDestino.Rollback();
                if (connDestino.State == ConnectionState.Open)
                    connDestino.Close();
                return false;
                //throw new Exception("Non se puido realizar a sincronización. ");
            }
            return Iniciar_Proceso_Descarga();
            //return true;

        }
        #endregion

        private void Sincronizar_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Sincronizar mForm = (Sincronizar)FormFactory.Obtener(Formulario.Sincronizar);
            mForm.Hide();
        }

    }
}





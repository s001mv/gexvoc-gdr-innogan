using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using GEXVOC.Core.Logic;
using System.Collections;
using System.Collections.Specialized;


namespace GEXVOC.UI
{
    public partial class ImportadorAnimales : GEXVOC.UI.GenericMaestro
    {
        #region CONSTUCTORES
            public ImportadorAnimales()
            {
                InitializeComponent();
            }

        #endregion
            
        #region CARGAS COMUNES
            private void CargarFichero(string rutaFichero)
            {
                Application.DoEvents();   
                if (File.Exists(rutaFichero))
                {
                    Traza.RegistrarInfo("Cargando el fichero: '" + rutaFichero + "' para la importación de animales.");
                    IniciarEspera();
                    try
                    {
                        lstListaImportar.Items.Clear();
                        lstListaImportar.Columns.Clear();
                        //PrimeraFila = null;
                        int numfila = 0;


                     
                        StreamReader streamR = new StreamReader(txtFichero.Text,Encoding.GetEncoding("iso-8859-1"));
                        while (streamR.Peek() >= 0)
                        {
                            string Linea = streamR.ReadLine();

                            numfila++;
                            if (numfila<=nudFilasDescartar.Value)                        
                                continue;
                            string[] items = Linea.Split(char.Parse(";"));
                            if (!GEXVOC.Core.Clases.Cadenas.ArrayBacio(items))
                            {                              
                                ListViewItem item = new ListViewItem(items);                        
                                item.Tag = Linea;                        
                                lstListaImportar.Items.Add(item);
                            }
                            Application.DoEvents();   
                        }
                        streamR.Close();
                        streamR.Dispose();
                        CrearColumnas();                   
                    }
                    catch (Exception ex)
                    {
                        FinalizarEspera();
                        GEXVOC.UI.Clases.Generic.AvisoError("Se ha producido un error importando el fichero.\nDetalle: " + ex.Message);
                    }
                    finally
                    { FinalizarEspera(); }



                }
            }
            void CrearColumnas()
            {

                int numColumnas = 0;
                if (lstListaImportar.Items.Count != 0)
                    numColumnas = lstListaImportar.Items[0].SubItems.Count;

                if (lstListaImportar.Columns.Count < numColumnas)
                    for (int i = lstListaImportar.Columns.Count; i < numColumnas; i++)
                    {
                        string DescripcionColumna = string.Empty;
                        try
                        {
                            DescripcionColumna = columnas[i];
                        }
                        catch (Exception) { }

                        lstListaImportar.Columns.Add(DescripcionColumna).Width = 100;
                    }

            }

            string[] columnas ={"Nombre",
                            "CI",
                            "Recrotalacion",
                            "Sexo",
                            "FechaNacimiento",             
                            "Raza",
                            "CIMadre",
                            "TipoAlta",
                            "FechaAlta",
                            "ProcedenciaAlta",
                            "NumDocumentoAlta",
                            "TipoBaja",
                            "FechaBaja",
                            "DestinoBaja",
                            "NumDocumentoBaja"};


            
                
        #endregion

        #region FUNCIONAMIENTO GENERAL

            #region Funcionamiento Arrastra y soltar Lista
            private void lstListaImportar_DragEnter(object sender, DragEventArgs e)
            {
                e.Effect = DragDropEffects.Copy;
            }

            private void lstListaImportar_DragDrop(object sender, DragEventArgs e)
            {
                object rdo = (IEnumerable<string>)e.Data.GetData("FileNameW");
                if (rdo.GetType().IsArray)
                {
                    if (((IList)rdo).Count != 0)
                        txtFichero.Text = ((IList)rdo)[0].ToString();

                }
                CargarFichero(txtFichero.Text);

            }

            #endregion

            private void btnExaminar_Click(object sender, EventArgs e)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtFichero.Text = openFileDialog1.FileName;
                    CargarFichero(txtFichero.Text);
                }
            }
            private void nudFilasDescartar_ValueChanged(object sender, EventArgs e)
            {

                if (txtFichero.Text != string.Empty)
                {
                    try
                    {
                        nudFilasDescartar.Enabled = false;
                        CargarFichero(txtFichero.Text);
                    }
                    catch (Exception)
                    { Traza.RegistrarError("Se ha producido un error cargado el fichero: " + txtFichero.Text); }
                    finally { nudFilasDescartar.Enabled = true; }

                }
            }
            private void btnEjecutarProceso_Click(object sender, EventArgs e)
            {
                if (lstListaImportar.Items.Count > 0)
                {
                    Traza.RegistrarInfo("Iniciando la importación de controles mútiples con los datos cargados.");
                    IniciarEspera();
                    pantallaEspera.NumeroPasos = lstListaImportar.Items.Count;
                    try
                    {
                        foreach (ListViewItem item in lstListaImportar.Items)
                        {
                            ImportacionAnimal imp = new ImportacionAnimal(ImportacionAnimal.TiposImportacion.BovinaXLS);
                            StringDictionary dic = new StringDictionary();
                            for (int i = 0; i < columnas.Length; i++)
                            {
                                if (i < item.SubItems.Count)//i nunca puede ser superior al nº de columnas (Puede pasar si se cargan menos columnas de las definidas)                                
                                    dic.Add(columnas[i], item.SubItems[i].Text);
                            }
                            try
                            {
                                imp.ImportarSTR(dic);
                                item.BackColor = Color.FromArgb(232, 254, 228);//Verde
                            }
                            catch (Exception ex)
                            {
                                Traza.RegistrarInfo("No se ha podido importar la línea. Causa: " + ex.Message +
                                    "\n Detalle Linea: " + item.Tag.ToString());
                                item.BackColor = Color.FromArgb(253, 202, 191);//Rojo
                                item.ToolTipText = ex.Message;
                                //throw;
                            }

                            pantallaEspera.Avanzar();
                        }
                    }
                    catch (Exception ex)
                    {
                        GEXVOC.UI.Clases.Generic.AvisoError("Se ha producido un error en la importación. Detalles: " + ex.Message);
                    }
                    finally
                    {
                        Traza.RegistrarInfo("Finalizada la importación de animales.");
                        FinalizarEspera();
                    }
                }
            }

        #endregion
      
    }
}

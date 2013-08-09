using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Collections;
using GEXVOC.Core.Logic;
using System.IO;

namespace GEXVOC.UI
{
    public partial class ImportadorAnimalesWebPigan : GEXVOC.UI.GenericMaestro
    {
        public ImportadorAnimalesWebPigan()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFichero.Text = openFileDialog1.FileName;
                CargarFichero(txtFichero.Text);
            }
        }
        ListViewItem PrimeraFila = null;

        #region CARGAS COMUNES
        public void DescripcionesPrimeraFila(bool value)
        {
            if (lstListaImportar.Items.Count != 0)
            {
                if (value && PrimeraFila == null)
                {
                    PrimeraFila = lstListaImportar.Items[0];

                    for (int i = 0; i < lstListaImportar.Columns.Count; i++)
                        lstListaImportar.Columns[i].Text = PrimeraFila.SubItems[i].Text;

                    lstListaImportar.Items[0].Remove();
                }
                if (!value && !(PrimeraFila == null))
                {

                    for (int i = 0; i < lstListaImportar.Columns.Count; i++)
                        lstListaImportar.Columns[i].Text = string.Empty;


                    List<ListViewItem> items = new List<ListViewItem>();


                    foreach (ListViewItem item in lstListaImportar.Items)
                    {
                        items.Add(item);
                    }
                    lstListaImportar.Items.Clear();

                    lstListaImportar.Items.Add(PrimeraFila);
                    lstListaImportar.Items.AddRange(items.ToArray());
                    PrimeraFila = null;
                }
            }
        }
        private void CargarFichero(string rutaFichero)
        {
            if (File.Exists(rutaFichero))
            {
                Traza.RegistrarInfo("Cargando el fichero: '" + rutaFichero + "' para la importación de controles mútiples.");
                IniciarEspera();
                try
                {
                    lstListaImportar.Items.Clear();
                    lstListaImportar.Columns.Clear();
                    PrimeraFila = null;
                    StreamReader streamR = new StreamReader(txtFichero.Text, Encoding.GetEncoding("iso-8859-1"));
                    while (streamR.Peek() >= 0)
                    {
                        string Linea = streamR.ReadLine();
                        string[] items = Linea.Split(char.Parse(";"));

                        if (!GEXVOC.Core.Clases.Cadenas.ArrayBacio(items))
                        {
                            ListViewItem item = new ListViewItem(items);
                            item.Tag = Linea;
                            lstListaImportar.Items.Add(item);

                        }

                    }
                    streamR.Close();
                    streamR.Dispose();
                    CrearColumnas();
                    DescripcionesPrimeraFila(chkDescripcionesPrimeraFila.Checked);
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
                        DescripcionColumna = DescripcionColumna.Replace("_", " ");
                    }
                    catch (Exception) { }

                    lstListaImportar.Columns.Add(DescripcionColumna).Width = 100;
                }

        }

        string[] columnas ={"Nº","CI",                            
                            "Raza",                               
                            "Sexo",
                            "TipoAlta",                                                        
                            "FechaAlta",
                            "FechaNacimiento",                           
                            "FechaParto"};

        private void chkDescripcionesPrimeraFila_CheckedChanged(object sender, EventArgs e)
        {
            DescripcionesPrimeraFila(chkDescripcionesPrimeraFila.Checked);
        }
        #endregion

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


        #region FUNCIONAMIENTO GENERAL

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
                        ImportacionAnimal imp = new ImportacionAnimal(ImportacionAnimal.TiposImportacion.BovinaWeb);
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

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
    
    public partial class ImportadorControles : GEXVOC.UI.GenericMaestro
    {
                
        #region Constructor
        public ImportadorControles()
        {
            InitializeComponent();
        }


        #endregion

        #region Importación del Fichero
        ListViewItem PrimeraFila = null;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DescripcionesPrimeraFila(chkDescripcionesPrimeraFila.Checked);

        }

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

        void CrearColumnas()
        {

            int numColumnas = 0;
            if (lstListaImportar.Items.Count != 0)
                numColumnas = lstListaImportar.Items[0].SubItems.Count;

            if (lstListaImportar.Columns.Count < numColumnas)
                for (int i = lstListaImportar.Columns.Count; i < numColumnas; i++)
                    lstListaImportar.Columns.Add(string.Empty).Width = 100;

        }
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFichero.Text = openFileDialog1.FileName;
                CargarFichero(txtFichero.Text);
            }
        }

        private void CargarFichero(string rutaFichero)
        {
            if (File.Exists(rutaFichero))
            {
                Traza.RegistrarInfo("Cargando el fichero: '" + rutaFichero+ "' para la importación de controles mútiples.");
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
                        string[] items = Linea.Split(char.Parse("|"));
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
        #endregion
       
        #region Funcionamiento Arrastra y soltar Lista
            private void listView1_DragEnter(object sender, DragEventArgs e)
            {                
                e.Effect = DragDropEffects.Copy;
            }

            private void listView1_DragDrop(object sender, DragEventArgs e)
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
        /// <summary>
        /// Array que define la estructura final de la clase que realiza la importación
        /// Esto se ha hecho así para que esta estructura pueda incluso ser cargada desde configuración
        /// y hacer reutilizables las funciones del proceso de importación.       
        /// </summary>
        string[] columnas ={"CI",
                            "NumLactacion",
                            "FechaInicioLactacion",
                            "FechaFinLactacion",
                            "NumControl",             
                            "FechaControl",
                            "EstadoControl",
                            "EstadoOrdeno",
                            "LManana",
                            "LTarde",
                            "LNoche",
                            "Laboratorio",
                            "FechaMuestra",
                            "RtoCelular",
                            "Grasa",
                            "Urea",
                            "Proteina",
                            "Lactosa",
                            "ExtractoSeco",
                            "ExtractoSecoMagro",
                            "ExtractoQuesero",
                            "LinealPto",
                            "Germenes",
                            "PtoCrioscopico",
                            "Inhibidores"};

        private void btnEjecutarProceso_Click(object sender, EventArgs e)
        {
            if (lstListaImportar.Items.Count>0)
            {
                Traza.RegistrarInfo("Iniciando la importación de controles mútiples con los datos cargados.");
                IniciarEspera();
                pantallaEspera.NumeroPasos = lstListaImportar.Items.Count;
                try
                {
                    foreach (ListViewItem item in lstListaImportar.Items)
                    {
                        
                        if (item.SubItems.Count!=25)                        
                            throw new Exception("No es posible continar con la importación porque el archivo no contiene una estructura adecuada.");
                        
                        ImportacionControl imp = new ImportacionControl();
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
                    Traza.RegistrarInfo("Finalizada la importación de controles mútiples.");
                    FinalizarEspera();
                }
           
            }
            

           
           
        
        }       
        #endregion
       
    }
}

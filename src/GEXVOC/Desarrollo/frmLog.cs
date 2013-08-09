using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;


namespace GEXVOC.UI.Desarrollo
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
          
            DirectoryInfo DirectorioLogs =new DirectoryInfo(Application.StartupPath + "\\Logs\\");
            this.listBox1.Items.Clear();
            foreach (FileInfo Archivo in DirectorioLogs.GetFiles())
            {                
                this.listBox1.Items.Add(Archivo.FullName);
            }


           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string sLine = "";
            ArrayList arrText = new ArrayList();
            this.textBox1.Text = string.Empty;

            try
            {
                if (this.listBox1.SelectedItem != null)
                {
                    StreamReader archivolog = new StreamReader(this.listBox1.SelectedItem.ToString());
                   
                    while (sLine != null)
                    {
                        sLine = archivolog.ReadLine();
                        if (sLine != null)
                            arrText.Add(sLine);
                    }
                    archivolog.Close();
                    long nLineasLeer = (long)this.numericUpDown1.Value;
                    if (nLineasLeer > arrText.Count)
                        nLineasLeer = arrText.Count;

                    for (int i = arrText.Count - 1; i >= arrText.Count - nLineasLeer; i--)
                        this.textBox1.Text = this.textBox1.Text + arrText[i] + System.Environment.NewLine; 

                    
                }
            }
            catch (Exception)
            {
                this.textBox1.Text = "Error accediendo al archivo";
        
            }
            
            
        }
    }
}

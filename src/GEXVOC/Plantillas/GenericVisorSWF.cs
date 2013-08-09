using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GEXVOC.UI
{
    public partial class GenericVisorSWF : GEXVOC.UI.GenericMaestro
    {
        #region CONSTRUCTORES
            public GenericVisorSWF()
            {
                InitializeComponent();
            }
            public GenericVisorSWF(string rutaSWF)
            {
                InitializeComponent();
                CargarSWF(rutaSWF);
            }
        #endregion
            
        #region CARGAS COMUNES
            public void CargarSWF(string rutaSWF)
            {
                System.IO.FileInfo ArchivoSWF = new System.IO.FileInfo(rutaSWF);
                if (ArchivoSWF.Exists)
                {
                    this.Text = ArchivoSWF.Name.Replace(ArchivoSWF.Extension, string.Empty);
                    axShockwaveFlash1.Zoom(1);
                    axShockwaveFlash1.Movie = ArchivoSWF.FullName;
                    axShockwaveFlash1.Width=1024;
                    axShockwaveFlash1.Height = 756;
                    axShockwaveFlash1.Play();                
                }
            }            
        #endregion
    }
}

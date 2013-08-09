using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Controles
{
    public partial class ctlTreeObjeto : TreeNode
    {
        public ctlTreeObjeto()
        {
            InitializeComponent();
           
        }
     

        public ctlTreeObjeto(string text):base(text)
        {
            InitializeComponent();
            
        }
        public ctlTreeObjeto(string text,int imageIndex)
            : base(text)
        {
            InitializeComponent();
            this.ImageIndex = imageIndex;
            this.SelectedImageIndex = imageIndex;
           
        }
     

        string _textoElementoSinDescipcion = "Sin Elementos";
        public string TextoElementoSinDescipcion
        {
            get { return _textoElementoSinDescipcion; }
            set { _textoElementoSinDescipcion = value; }
        }
    

        bool _AgregarElementoSinDescripcionAutomaticamente = false;        
        public bool AgregarElementoSinDescripcionAutomaticamente
        {
          get { return _AgregarElementoSinDescripcionAutomaticamente; }
          set
          {
              if (value)
                  Nodes.Add(TextoElementoSinDescipcion);
              
                   
              
              _AgregarElementoSinDescripcionAutomaticamente = value; 
          }
        }

        IClaseBase _ClaseActiva = null;
        public IClaseBase ClaseActiva
        {
            get { return _ClaseActiva; }
            set { _ClaseActiva = value; }
        }


        private bool _readonly;
        public bool ReadOnly
        {
            get { return _readonly; }
            set {
                if (value)
                {
                    this.ForeColor = Color.FromName("ControlDark");
                    //this.NodeFont = new Font(this.TreeView.Font, FontStyle.Italic);
                    
                }
                _readonly = value; 
            }
        }
        

       
    }
}

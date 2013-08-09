using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using System.Reflection;

namespace GEXVOC.UI
{
    public partial class EditEnsamblados : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditEnsamblados()
        {
            InitializeComponent();
        }
   
        #endregion


        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        //public Ensamblados ObjetoBase { get { return (Ensamblados)this.ClaseBase; } }
        #endregion

        private void EditEnsamblados_Load(object sender, EventArgs e)
        {
            List<Proceso> procesos = new List<Proceso>();

            foreach ( Type item in this.GetType().Assembly.GetTypes())
	        {
                foreach ( PropertyInfo propiedad in item.GetProperties())
                {
                    if (propiedad.Name.Contains("_proceso_"))
                    {
                        procesos.Add(new Proceso() { Nombre = propiedad.Name.Replace("_proceso_", string.Empty), Formulario = item.Name });                        
                    }            		 
                }
            }
            
            foreach (Proceso item in procesos)            
                AgregarElementoNodo(item);//trvMenus.Nodes.Add(item.Nombre); 
                     

        }
        void AgregarElementoNodo (Proceso elemento)
        {
            TreeNode nodoAgregar = null;
            foreach (TreeNode item in trvMenus.Nodes)            
                if (item.Text==elemento.Nombre)                
                    nodoAgregar = item;


            if (nodoAgregar == null)
            {
                nodoAgregar = new TreeNode(elemento.Nombre);
                trvMenus.Nodes.Add(nodoAgregar);
            }
            

            TreeNode nodoElemento = new TreeNode(elemento.Formulario);      

            nodoAgregar.Nodes.Add(nodoElemento);
        
        }

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

        //protected override void ClaseBaseAControles()
        //{
        //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
        //}

        //protected override void ControlesAClaseBase()
        //{

        //    Generic.ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
        //}



        ///// <summary>
        ///// Validación de los Controles, se produce antes de actualizar la ClaseBase.
        ///// </summary>
        ///// <returns>Controles válidos (Si/No)</returns>
        //protected override bool Validar()
        //{
        //    bool Rtno = true;
        //    this.ErrorProvider.Clear();
        //    if (!Generic.ControlValorado(new Control[] { txtDescripcion }, this.ErrorProvider))
        //        Rtno = false;


        //    return Rtno;

        //}

        #endregion
    }
}
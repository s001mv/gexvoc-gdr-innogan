using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Controles;
using GEXVOC.UI.Clases;
namespace GEXVOC.UI
{
   
    public partial class ExploradorProductos : GenericMaestro
    {
        #region VARIABLES Y PROPIEDADES PRINCIPALES
            enum imagenes
            {
                Nada = 0,
                TipoProducto = 1,
                FamiliaProducto = 2,
                Producto = 3

            }
        #endregion

        #region CONTRUCTORES
        public ExploradorProductos()
            {
                InitializeComponent();

                CargarTreeProductos();
                
            }
        #endregion

        #region CARGAS COMUNES
            private void CargarTreeProductos()
            {
                this.treeProductos.Nodes.Clear();
                List<TipoProducto> lstTipoProducto=TipoProducto.Buscar();
                if (lstTipoProducto!=null)
                    foreach (TipoProducto item in lstTipoProducto)                            
                        this.treeProductos.Nodes.Add(new ctlTreeObjeto(item.Descripcion, (int)imagenes.TipoProducto) { ClaseActiva = item,AgregarElementoSinDescripcionAutomaticamente=true });
                
            } 
            private static void CargarNodo(ctlTreeObjeto tree)
            {
                tree.Nodes.Clear();

                if (tree.ClaseActiva.GetType() == typeof(GEXVOC.Core.Logic.TipoProducto))
                {
                    //tree.Nodes.Clear();
                    //Cargamos primero las familias

                    TipoProducto tipo = (TipoProducto)tree.ClaseActiva;
                    if (tipo.Familia != null && (bool)tipo.Familia)
                    {
                        List<Familia> lstFamilia = tipo.lstFamilias;
                        if (lstFamilia != null && lstFamilia.Count > 0)
                        {

                            foreach (Familia item in lstFamilia)
                                tree.Nodes.Add(new ctlTreeObjeto(item.Descripcion, (int)imagenes.FamiliaProducto) { ClaseActiva = item, AgregarElementoSinDescripcionAutomaticamente = true });


                        }

                    }

                    //Cargamos ahora los productos (Tanto si hemos cargado familias como si no
                    List<Producto> lstProducto = tipo.lstProductos;
                    if (lstProducto != null && lstProducto.Count > 0)
                    {
                        foreach (Producto item in lstProducto)
                            tree.Nodes.Add(new ctlTreeObjeto(item.Descripcion, (int)imagenes.Producto) { ClaseActiva = item });

                    }

                    //Si no he cargado ningun elemento pero si he borrado el elemento por defecto, lo vuelvo a crear para que vuelva a ocurrir
                    //en ocasiones futuras este evento
                    //if (tree.Nodes.Count == 0)
                      //  tree.Nodes.Add(tree.TextoElementoSinDescipcion);



                }
                if (tree.ClaseActiva.GetType() == typeof(GEXVOC.Core.Logic.Familia))
                {
                    //tree.Nodes.Clear();
                    Familia familiaProducto = (Familia)tree.ClaseActiva;
                    List<Producto> lstProducto = familiaProducto.lstProductos;
                    if (lstProducto != null && lstProducto.Count > 0)
                    {
                        //tree.Nodes.Clear();
                        foreach (Producto item in lstProducto)
                            tree.Nodes.Add(new ctlTreeObjeto(item.Descripcion, (int)imagenes.Producto) { ClaseActiva = item });

                    }
                    


                }
                if (tree.Nodes.Count == 0)
                    tree.Nodes.Add(tree.TextoElementoSinDescipcion);

            }
        #endregion

        #region FUNCIONAMIENTO GENERAL

            private void treeProductos_BeforeExpand(object sender, TreeViewCancelEventArgs e)
            {

                ctlTreeObjeto tree = (ctlTreeObjeto)e.Node;
                CargarNodo(tree);           
                

            }     


            private void treeProductos_MouseDown(object sender, MouseEventArgs e)
            {
                if (e.Button==MouseButtons.Right)
                    this.treeProductos.SelectedNode = treeProductos.GetNodeAt(e.X,e.Y);
                    
                
            }

            private void tsmNuevo_Click(object sender, EventArgs e)
            {
                if (treeProductos.SelectedNode!=null)
                {
                    ctlTreeObjeto ctltree = (ctlTreeObjeto)treeProductos.SelectedNode;
                    if (ctltree.ClaseActiva!=null)
                    {
                        if (ctltree.ClaseActiva.GetType()==typeof(TipoProducto))
                        {
                            Producto ObjNuevo = new Producto();
                            this.LanzarFormulario(new EditProducto(Modo.Guardar, ObjNuevo) { ValorFijoTipoProducto = (TipoProducto)ctltree.ClaseActiva });

                            CargarNodo(ctltree);
                            
                        }

                        if (ctltree.ClaseActiva.GetType() == typeof(Familia))
                        {
                           //Obtengo el tipo del producto
                            ctlTreeObjeto nodoTipo = (ctlTreeObjeto)ctltree.Parent;
                            if (nodoTipo.ClaseActiva!=null)
                            {
                                Producto ObjNuevo = new Producto();
                                this.LanzarFormulario(new EditProducto(Modo.Guardar, ObjNuevo) {ValorFijoTipoProducto=(TipoProducto)nodoTipo.ClaseActiva, ValorFijoIdFamilia = ((Familia)ctltree.ClaseActiva).Id });

                                CargarNodo(ctltree);
                                
                            }
                        }

                    }
                     
                    
                    
                }
                

            }

            /// <summary>
            /// Utilizo este evento para habilitar o no los controles que representan las operaciones, nuevo, modificar y eliminar en
            /// función de la existencia de un nodo seleccionado.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void cmsTree_Opening(object sender, CancelEventArgs e)
            {
                //Si hay elementos activos en el tree node los controles estaran activos, de lo contrario no          
                cmsTree.Enabled = !(treeProductos.SelectedNode == null);            
                
            }

            private void tsmModificar_Click(object sender, EventArgs e)
            {
                ctlTreeObjeto ctltree = (ctlTreeObjeto)treeProductos.SelectedNode;
                if (ctltree.ClaseActiva != null)
                {
                    if (ctltree.ClaseActiva.GetType() == typeof(TipoProducto))
                    {
                        TipoProducto ObjetoBase = (TipoProducto)ctltree.ClaseActiva;
                        this.LanzarFormulario(new EditTipoProducto(Modo.Actualizar, ObjetoBase));

                        CargarTreeProductos();
                    }
                    if (ctltree.ClaseActiva.GetType() == typeof(Familia))
                    {
                        //Obtengo el tipo del producto
                        ctlTreeObjeto nodoTipo = (ctlTreeObjeto)ctltree.Parent;

                        if (nodoTipo.ClaseActiva != null)
                        {


                            Familia ObjetoBase = (Familia)ctltree.ClaseActiva;
                            this.LanzarFormulario(new EditFamilia(Modo.Actualizar, ObjetoBase) { ValorFijoTipoProducto = (TipoProducto)nodoTipo.ClaseActiva });


                            CargarNodo(nodoTipo);
                        }
                    }
                    if (ctltree.ClaseActiva.GetType() == typeof(Producto))
                    {
                        TipoProducto valorTipo = null;
                        int? valorIdFamilia = null;

                        //Obtengo nodo anterior
                        ctlTreeObjeto nodoAnterior = (ctlTreeObjeto)ctltree.Parent;
                        if (nodoAnterior.ClaseActiva != null && nodoAnterior.ClaseActiva.GetType() == typeof(Familia))
                        {
                            //Estoy ante el caso de modificar un producto con familia
                            valorIdFamilia = nodoAnterior.ClaseActiva.Id;

                            //tengo que obtener todavia el tipo
                            ctlTreeObjeto nodoTipo = (ctlTreeObjeto)ctltree.Parent.Parent;
                            if (nodoTipo!=null && nodoTipo.ClaseActiva!=null)
                                valorTipo=(TipoProducto)nodoTipo.ClaseActiva;                                          


                            


                        }
                        else
                        {
                            if (nodoAnterior.ClaseActiva != null && nodoAnterior.ClaseActiva.GetType() == typeof(TipoProducto))//Estoy ante el caso de modificar un prodcuto que cuelga directamente desde el tipo                        
                                valorTipo = (TipoProducto)nodoAnterior.ClaseActiva;                        
                            
                        
                        }


                         
                         this.LanzarFormulario(new EditProducto(Modo.Actualizar, (Producto)ctltree.ClaseActiva) {ValorFijoTipoProducto=valorTipo, ValorFijoIdFamilia = valorIdFamilia});
                         CargarNodo(nodoAnterior);
                       

                    }
         
                }           


            }

            private void tsmEliminar_Click(object sender, EventArgs e)
            {
                if (treeProductos.SelectedNode != null)
                {
                    ctlTreeObjeto ctltree = (ctlTreeObjeto)treeProductos.SelectedNode;
                    ctlTreeObjeto nodoAnterior = (ctlTreeObjeto)ctltree.Parent;
                    if (ctltree.ClaseActiva != null)
                    {
                        //Explotacion ObjetoBase = (Explotacion)this.dtgResultado.CurrentRow.DataBoundItem;
                        DialogResult Rdo = Generic.Aviso("Va a proceder a eliminar el elemento seleccionado de la Base de datos.\r" +
                            "¿Desea continuar y eliminarlo definitivamente?", "Borrando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (Rdo == DialogResult.Yes)
                        {
                            this.IniciarContextoOperacion();
                            try
                            {
                                ctltree.ClaseActiva.Eliminar();
                            }
                            catch (Exception ex)
                            {
                                Generic.AvisoError("Se ha producido un error eliminado el registro, "
                                    + ex.Message);

                            }
                            finally { this.FinalizarContextoOperacion(); }

                            if (nodoAnterior==null)//Estamos eliminado un tipo producto                        
                                this.CargarTreeProductos();
                            else//Estamos eliminado familias o productos
                                CargarNodo(nodoAnterior);

                        }

                    }
                }

            }

        #endregion          
    }
}

//---------------------Código Comentado----------------------------------------------//

        //private void tsmNuevo_Click(object sender, EventArgs e)
        //{
        //    treeProductos.GetChildAtPoint(MousePosition);

        //}

        //private void treeProductos_DoubleClick(object sender, EventArgs e)
        //{
        //    if (treeProductos.SelectedNode != null)
        //    {
        //        ctlTreeObjeto tree = (ctlTreeObjeto)treeProductos.SelectedNode;
        //        if (tree.ClaseActiva.GetType() == typeof(GEXVOC.Core.Logic.Familia))
        //        {
                    

                
        //        }
        //        if (tree.ClaseActiva.GetType() == typeof(GEXVOC.Core.Logic.Producto))
        //        {
        //            Producto ObjActualizar = (Producto)tree.ClaseActiva;
                   
        //            this.LanzarFormulario(new EditProducto(Modo.Actualizar, ObjActualizar) s);

        //        }

        //    }
        //}
     
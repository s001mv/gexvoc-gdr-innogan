using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;

namespace GEXVOC.UI
{
    public partial class EditPersonalizarMenus : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditPersonalizarMenus()
        {
            InitializeComponent();
        }
        //public EditPersonalizarMenus(Modo modo, EditPersonalizarMenus ClaseBase)
        //    : base(modo, ClaseBase)
        //{
        //    InitializeComponent();
        //}
        #endregion

        #region CARGAS COMUNES
            void cargarMenus(ToolStripMenuItem menu, TreeNode nodopadre)
            {

                foreach (ToolStripItem item in ((ToolStripMenuItem)menu).DropDownItems)
                 {
                     TreeNode nodohijo = CrearNodo(item);
                     nodopadre.Nodes.Add(nodohijo);                    

                        if (item.GetType() == typeof(ToolStripMenuItem))                   
                            cargarMenus((ToolStripMenuItem)item, nodohijo);                    
                  }                
            }
        #endregion

        #region FUNCIONES SOBREECRITAS
            protected override void Guardar()
            {
                if (ValidarControles())
                {             
                    BD.IniciarBDOperaciones();
                    bool transacionPropia=BD.IniciarTransaccion();
                    try
                    {
                        //Antes de guardar en este formulario se borra toda la información anterior.
                        List<Core.Logic.Menu> lstMenu = Core.Logic.Menu.BuscarPadres(Generic.ControlAIntNullable(cmbModulo),  null, string.Empty);
                        foreach (Core.Logic.Menu item in lstMenu)                     
                                item.Eliminar();
                        
                            
                        foreach (TreeNode item in trvMenus.Nodes)
                        {
                            
                            if (item.Checked)
                            {
                                //if (ReadOnlyNodo(item))//Asignamos readonlynodo=true a los elementos heredados, pero no queremos que sean guardados
                                //{
                                    Core.Logic.Menu mnu = new Core.Logic.Menu();
                                    mnu.IdModulo = Generic.ControlAIntNullable(cmbModulo);
                                    mnu.Texto = item.Name;                                                              
                                    recorrerNodo(item, mnu);
                                    mnu.Insertar();
                                //}
                                //##PENDIENTE##Recorrer los nodos aunque formen parte de un elemento heredado.
                                
                            }
                        }
                        if (transacionPropia)
                            BD.FinalizarTransaccion(true);

                        this.cmbModulo.ClaseActiva = null;

                    }
                    catch (Exception ex)
                    {
                      

                        Generic.AvisoError("Error en el proceso de guardado.");
                        Traza.RegistrarError(ex);

                        try
                        {
                            if (transacionPropia)
                                BD.FinalizarTransaccion(false);
                        }
                        catch (Exception){}
                        
                        
                    }
                    finally
                    {
                        BD.FinalizarBDOperaciones();
                    }

                }              
              
            }
            protected override bool Validar()
            {
                bool rtno = true;
                
                if (!Generic.ControlValorado(cmbModulo,this.ErrorProvider)) rtno = false;
                return rtno;
            }
        #endregion

        #region FUNCIONAMIENTO GENERAL

            private TreeNode CrearNodo(ToolStripItem menu)
            {
                
                TreeNode rtno = null;
                string textoamostrar = string.Empty;
                try
                {
                    textoamostrar = menu.Text.Replace("&", string.Empty);
                    if (menu.GetType() == typeof(ToolStripSeparator))
                        textoamostrar = "---------";
                    rtno = new TreeNode(textoamostrar);
                    rtno.Name = menu.Name;
                    rtno.Tag = false;//Tratamos la propiedad tag como informacion de ReadOnly.

                    if (lstMenusPermitidosPropios != null && lstMenusPermitidosPropios.ContainsKey(menu.Name))                
                        rtno.Checked = true;
                    if (lstMenusPermitidosHeredados != null && lstMenusPermitidosHeredados.ContainsKey(menu.Name))
                    {
                        rtno.Tag = true;                    
                        rtno.ForeColor = Color.FromName("ControlDark");
                        rtno.NodeFont = new Font(trvMenus.Font, FontStyle.Italic);
                    } 
                }
                catch (Exception){}
               

                return rtno;
            }       

            /// <summary>
            /// Recorre todos los subnodos del nodo especificado como parametro.
            /// Crea objetos del tipo menu y los asocia al menú especificado como parámetro.
            /// Es un función recursiva, una vez llamada recorrerá el arbol por completo a partir del nodo proporcionado.
            /// </summary>
            /// <param name="nodo"></param>
            /// <param name="menu"></param>
            void recorrerNodo(TreeNode nodo,Core.Logic.Menu menu)
            {
                foreach (TreeNode item in nodo.Nodes)
                {
                    if (item.Checked)
                    {
                        Core.Logic.Menu mnu = new Core.Logic.Menu();
                        mnu.IdModulo = Generic.ControlAIntNullable(cmbModulo);
                        mnu.Texto = item.Name;
                        menu.Menu2.Add(mnu);
                        recorrerNodo(item, mnu);//Llamada a la recursividad.
                    }
                }
            }




            private void btnBuscarModulos_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindModulo(Modo.Consultar, this.cmbModulo));
            }



            private void cmbModulo_ClaseActivaChanged(object sender, GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs e)
            {
                trvMenus.Nodes.Clear();
                if (e.ClaseActiva != null)
                {
                    Modulo moduloSeleccionado = (Modulo)e.ClaseActiva;
                    lstMenusPermitidosPropios = moduloSeleccionado.lstMenusPermitidosPropios;
                    lstMenusPermitidosHeredados = moduloSeleccionado.lstMenusPermitidosHeredados;

                    foreach (ToolStripItem item in ((Principal)this.MdiParent).MenuPrincipal.Items)
                    {

                        TreeNode nodopadre = CrearNodo(item);
                        trvMenus.Nodes.Add(nodopadre);

                        if (item.GetType() == typeof(ToolStripMenuItem))
                            cargarMenus((ToolStripMenuItem)item, nodopadre);

                    }

                }


            }


            /// <summary>
            /// Retorna el contendido de la etiqueta tag de un nodo, transformado en un string, si es posible.
            /// </summary>
            /// <param name="nodo"></param>
            /// <returns></returns>
            bool ReadOnlyNodo(TreeNode nodo)
            {
                //No permito que se puedan checkear ni descheckear los elementos heredados.
                bool rtno = false;
                try
                {
                    rtno = (bool)nodo.Tag;
                }
                catch (Exception) { }
                return rtno;
            }

            private void trvMenus_BeforeCheck(object sender, TreeViewCancelEventArgs e)
            {

                if (ReadOnlyNodo(e.Node) && !cambioAutomatico)
                {
                    Generic.AvisoInformation("No es posible modificar la asociación del menú porque se trata de un elemento heredado.");
                    e.Cancel = true;
                }

            }
            /// <summary>
            /// Asigna a todos los hijos del nodo enviado como parametro, a su propiedad Checked, el 
            /// valor indicado en el parámetro check.
            /// </summary>
            /// <param name="nodoPadre"></param>
            /// <param name="check"></param>
            void AsignarCheckNodosHijos(TreeNode nodoPadre, bool check)
            {
                if (nodoPadre != null)
                {
                    foreach (TreeNode item in nodoPadre.Nodes)
                        if (!ReadOnlyNodo(item)) //Los nodos que represnetan menús heredados no los toco.
                            item.Checked = check;

                }
            }


            void CambiarCheckModoAutomatico(TreeNode nodo, bool check)
            {
                try
                {
                    cambioAutomatico = true;
                    nodo.Checked = check;
                }
                catch (Exception) { }
                finally
                { cambioAutomatico = false; }


            }


            private void trvMenus_AfterCheck(object sender, TreeViewEventArgs e)
            {

                if (e.Node.Checked)
                {
                    //Si cuando checkeo un nodo, no se encuentra el anterior checkedado, lo checkeo automaticamente.
                    if (e.Node.Parent != null && !e.Node.Parent.Checked)
                        CambiarCheckModoAutomatico(e.Node.Parent, true);


                    //Comprobar si he checkeado un nodo padre y debo checkear todos sus hijos.                
                    //AsignarCheckNodosHijos(e.Node, e.Node.Checked);                   

                }
                else//He descheckeado el nodo.
                {

                    //Deschekeo todos sus nodos hijos.
                    AsignarCheckNodosHijos(e.Node, e.Node.Checked);


                    // Inicio - Comprobar si debo deschekear tambien el padre.
                    if (e.Node.Parent != null && e.Node.Parent.Checked)
                    {
                        bool ExisteHijoCheckeado = false;
                        foreach (TreeNode item in e.Node.Parent.Nodes)//recorro todos los nodos del padre a ver si existe alguno checheado                    
                        {
                            if (item.Checked)//he encontrado un nodo hijo checkeado, salgo para no ejecutar la linea de deschekear el padre      
                            {
                                ExisteHijoCheckeado = true;
                                break;
                            }
                        }

                        if (!ExisteHijoCheckeado)
                            CambiarCheckModoAutomatico(e.Node.Parent, false);//No se ha encontrado ningun elemento checheado en ese padre, significa que acabo de 
                        //descheckear el úlitmo de los elementos, con lo cual, quito el check tb al padre.                    
                    }
                    // Fin - Comprobar si debo deschekear tambien el padre.

                }







            }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        //public PersonalizarMenus ObjetoBase { get { return (PersonalizarMenus)this.ClaseBase; } }
        Dictionary<string, Core.Logic.Menu> lstMenusPermitidosPropios = null;
        Dictionary<string, Core.Logic.Menu> lstMenusPermitidosHeredados = null;


        /// <summary>
        /// Variable que utilizo para saber si soy yo el que cambia el estado de los checks por codigo, o es el usuario el que lo hace.
        /// Hago esta distinción por ejemplo para el siguiente caso:
        ///     Los menús heredados no es posible que se modifiquen por el usuario.
        ///     Pero hay un caso en el que deben ser modificados y es en el automatico, pues podemos tener un submenú dentro de un menu heredado
        ///     que queremos asignar, en este caso debemos crear tb la asociación de dicho menú con el módulo activo, a pesar de que 
        ///     ya exista dicha relacion en el modulo del que hereda.
        /// </summary>
        bool cambioAutomatico = false;
        #endregion
       
    }
}
//#region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

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

// #endregion
//protected override void CargarCombos()
//{
//    this.CargarCombo(cmbModulo, Modulo.Buscar());

//    base.CargarCombos();
//}
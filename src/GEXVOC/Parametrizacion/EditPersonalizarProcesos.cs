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
using GEXVOC.Core.Controles;
using GEXVOC.Core.Reflection;

namespace GEXVOC.UI
{
    public partial class EditPersonalizarProcesos : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditPersonalizarProcesos()
        {
            InitializeComponent();
         

            foreach (Type item in this.GetType().Assembly.GetTypes())
            {
                foreach (PropertyInfo propiedad in item.GetProperties())
                {
                    
                    if (propiedad.Name.Contains("_proceso_"))
                    {
                        ProcesoDescripcion ProcesoDesc= ProcesoConversiones.GetProceso(propiedad);
                        if (ProcesoDesc==null)                        
                            procesos.Add(new Proceso() { Nombre = propiedad.Name.Replace("_proceso_", string.Empty), Formulario = item.Name});                        
                        else
                            procesos.Add(new Proceso() { Nombre = propiedad.Name.Replace("_proceso_", string.Empty), Formulario=item.Name,Descripcion = ProcesoDesc.Descripcion,Clasificacion=ProcesoDesc.Clasificacion });

 
                    }
                }
            }

            //procesos.Sort();
            procesos.Sort(delegate(Proceso p1, Proceso p2) { return p1.Nombre.CompareTo(p2.Nombre); });
        }

        List<Proceso> procesos = new List<Proceso>();
      
        //public EditProcesos(Modo modo, Procesos ClaseBase)
        //    : base(modo, ClaseBase)
        //{
        //    InitializeComponent();
        //}
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES
        Dictionary<string, Core.Logic.Proceso> lstProcesosPermitidosPropios = null;
        Dictionary<string, Core.Logic.Proceso> lstProcesosPermitidosHeredados = null;
        #endregion

        #region FUNCIONES SOBREESCRITAS

        protected override void Guardar()
        {
            if (ValidarControles())
            {
                BD.IniciarBDOperaciones();
                bool transacionPropia = BD.IniciarTransaccion();
                try
                {
                    //Antes de guardar en este formulario se borra toda la información anterior.
                    List<Core.Logic.Proceso> lstProcesos = Core.Logic.Proceso.Buscar(Generic.ControlAIntNullable(cmbModulo),string.Empty,string.Empty,null);
                    foreach (Core.Logic.Proceso item in lstProcesos)
                        item.Eliminar();


                    foreach (TreeNode item in trvProcesos.Nodes)
                    {
                        foreach (TreeNode elemento in item.Nodes)//Solo inserto los nodos de segundo nivel.
                        {
                            if (elemento.Checked)
                            {
                                Core.Logic.Proceso proc = new Core.Logic.Proceso();
                                proc.IdModulo = Generic.ControlAIntNullable(cmbModulo);
                                proc.Formulario = elemento.Tag.ToString();
                                proc.Nombre = elemento.Parent.Tag.ToString();
                                proc.Insertar();                                                        
                            }
                        }
                    }
                    if (transacionPropia)
                        BD.FinalizarTransaccion(true);

                    cmbModulo.ClaseActiva = null;

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
                    catch (Exception) { }


                }
                finally
                {
                    BD.FinalizarBDOperaciones();
                }

            }

        }
        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarModulos_Click(object sender, EventArgs e)
            {
                  this.LanzarFormularioConsulta(new FindModulo(Modo.Consultar, this.cmbModulo));
            }

            private void cmbModulo_ClaseActivaChanged(object sender, GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs e)
            {
                trvProcesos.Nodes.Clear();
                if (e.ClaseActiva != null)
                {
                    Modulo moduloSeleccionado = (Modulo)e.ClaseActiva;
                    lstProcesosPermitidosPropios = moduloSeleccionado.lstProcesosPermitidos;
                    lstProcesosPermitidosHeredados = moduloSeleccionado.lstProcesosPermitidosHeredados;



                    foreach (Proceso item in procesos)
                        AgregarElementoNodo(item);

                    trvProcesos.ExpandAll();
                }
            }

            void AgregarElementoNodo(Proceso elemento)
            {
                ctlTreeObjeto nodoAgregar = null;
                foreach (ctlTreeObjeto item in trvProcesos.Nodes)
                    if (item.Text == elemento.Clasificacion)
                        nodoAgregar = item;


                if (nodoAgregar == null)
                {
                    nodoAgregar = new ctlTreeObjeto(elemento.Clasificacion) { ReadOnly = true, Tag=elemento.Nombre };
                    trvProcesos.Nodes.Add(nodoAgregar);
                }


                ctlTreeObjeto nodoElemento = new ctlTreeObjeto(elemento.Descripcion) { Tag = elemento.Formulario };       

                if (lstProcesosPermitidosPropios != null && lstProcesosPermitidosPropios.ContainsKey(elemento.IdentificacionProceso))
                    nodoElemento.Checked = true;

                if (lstProcesosPermitidosHeredados != null && lstProcesosPermitidosHeredados.ContainsKey(elemento.IdentificacionProceso))
                {
                    nodoElemento.Checked = false;
                    nodoElemento.ReadOnly = true;

                    //nodoElemento.ForeColor = Color.FromName("ControlDark");
                    nodoElemento.NodeFont = new Font(trvProcesos.Font, FontStyle.Italic);
                }




                nodoAgregar.Nodes.Add(nodoElemento);

            }

            private void trvProcesos_BeforeCheck(object sender, TreeViewCancelEventArgs e)
            {
                if (e.Node.GetType()==typeof(ctlTreeObjeto))
                {
                    ctlTreeObjeto nodo = (ctlTreeObjeto)e.Node;
                    if (nodo.ReadOnly)
                        e.Cancel = true;                
                }
                
                
                
                
            }
        #endregion

    }
}  

//#region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        //public Procesos ObjetoBase { get { return (Procesos)this.ClaseBase; } }
        //#endregion

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

        //#endregion
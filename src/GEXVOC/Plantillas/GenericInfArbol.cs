using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Informes;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;

namespace GEXVOC.UI
{
    public partial class GenericInfArbol : GEXVOC.UI.GenericInf
    {
        
        #region CONSTRUCTORES
            public GenericInfArbol(string InformeSeleccionar) 
            {
                InitializeComponent();
                _InformeSeleccionar = InformeSeleccionar;           
            }
            public GenericInfArbol()
            {
                InitializeComponent();

            }
        #endregion

        #region EVENTOS
        public event EventHandler<GenericInfArbolEventArgs> InformeSeleccionando;
        public event EventHandler<GenericInfArbolEventArgs> InformeSeleccionado;


        protected virtual void OnInformeSeleccionado(GenericInfArbolEventArgs e)
        {

            EventHandler<GenericInfArbolEventArgs> handler = InformeSeleccionado;

            if (handler != null)
            {
                handler(this, e);
            }
        }
        protected virtual void OnInformeSeleccionando(GenericInfArbolEventArgs e)
        {

            EventHandler<GenericInfArbolEventArgs> handler = InformeSeleccionando;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES

        string _InformeSeleccionar = string.Empty;
        enum Imagenes
        {
            Carpeta = 0,
            Informe = 1
        }
        GEXVOC.Core.Controles.ctlInforme _Informe = null;
        private GEXVOC.Core.Controles.ctlInforme Informe
        {
            get { return _Informe; }
            set
            {
                if (value != null)
                {
                    Generic.PonerControlesMayusculas(value);
                    Generic.EjecutarProcesos(value);
                    value.Location = new Point(1, 12);
                    value.FormularioInformes = this;
                    value.CargaControles();
                    value.ValoresPredeterminados();
                    this.Filtros.Controls.Add(value);
                }

                _Informe = value;
            }
        }

        #endregion

        #region FUNCIONAMIENTO GENERAL
        /// <summary>
        /// Selecciona el nodo que se le evia como parametro
        /// Ojo: Solamente se buscarán en nodos que no tengan hijos (Los últimos del árbol) que son los que consideramos informes,
        /// el resto serán solo carpetas contenedoras.
        /// </summary>
        /// <param name="nodos">Coleccion de nodos desde donde empezar a buscar (la búsqueda se hara recursiva)</param>
        /// <param name="NodoASeleccionar">Debe ser la ruta completa del tipo "Informes compras/Pendientes Servir"</param>
        public void SeleccionarNodo(TreeNodeCollection nodos, string NodoASeleccionar)
        {
            if (NodoASeleccionar != string.Empty)
            {
                foreach (TreeNode item in nodos)
                {
                    if (item.FullPath.ToUpper() == NodoASeleccionar.ToUpper())
                    {
                        trvInformes.SelectedNode = item;
                        Application.DoEvents();
                        break;
                    }
                    else
                    {
                        if (item.Nodes.Count > 0)
                            SeleccionarNodo(item.Nodes, NodoASeleccionar);
                    }

                }
            }
        }
        public void SeleccionarNodo(string NodoASeleccionar)
        {
            this.SeleccionarNodo(trvInformes.Nodes, NodoASeleccionar);
        }

        private void trvInformes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.Informe = null;
            this.Filtros.Controls.Clear();
            this.rptVisor.ReportSource = null;

            Application.DoEvents();
            string NombreCompleto = trvInformes.SelectedNode.FullPath.ToUpper();
            if (e.Node.Nodes.Count == 0)
            {

                GenericInfArbolEventArgs eventArgs = new GenericInfArbolEventArgs();
                eventArgs.NombreCompleto = NombreCompleto;
                eventArgs.NodoSeleccionado = e.Node;

                OnInformeSeleccionando(eventArgs);
                if (!eventArgs.Cancelar && eventArgs.InformeActivo != null)
                {
                    this.toolTip1.SetToolTip(lblInformeLanzar, eventArgs.InformeActivo.DescripcionInforme);
                    this.Informe = eventArgs.InformeActivo;
                }
            }
            this.lblInformeLanzar.Text = NombreCompleto;
        }

        protected override void Generar()
        {
            rptVisor.ReportSource = null;
            IniciarEspera();
            try
            {
                rptVisor.ReportSource = Informe.ConstruirInforme();
                rptVisor.Zoom(80);//Establezo el zoom maximo para que no salga el scroll horizontal en un informe con orientacion
                //de página en vertical (los mas comunes), hago un poco mas pequeño el informe.
            }
            catch (LogicException ex)
            {
                FinalizarEspera();
                Generic.AvisoInformation(ex.Message);
            }
            catch (Exception ex)
            {
                FinalizarEspera();
                Generic.AvisoError(ex.Message);
            }
            finally { FinalizarEspera(); }


        }
        protected override bool Validar()
        {
            bool rtno = true;

            if (Informe != null)
                rtno = Informe.Validar();
            else
            {
                Generic.AvisoInformation("No se encuentra cargado ningún Informe, el proceso no continuará.");
                rtno = false;
            }

            return rtno;
        }

        //private void Filtros_SizeChanged(object sender, EventArgs e)
        //{
        //    panel1.Size = new Size(Filtros.Size.Width, 473 - (Filtros.Size.Height - 112));
        //    panel1.Location = new Point(281, 170 + (Filtros.Size.Height - 112));
        //}
        #endregion

        #region CARGAS COMUNES
        public override void Cargar()
        {

            this.trvInformes.ExpandAll();
            CambiarIconosNodos(trvInformes.Nodes);
            //Selecciono por defecto el primer nodo, esto se hace porque si hay scroll vertical  aparecen los nodos desde el 
            //final por culpa de expandall, y asi me aseguro de que se lea el arbol desde el principio
            if (trvInformes.Nodes.Count > 0) trvInformes.SelectedNode = trvInformes.Nodes[0];

            //Si se nos ha especificado un informe para ser seleccionado, lo seleccionamos.
            if (_InformeSeleccionar != string.Empty)
                SeleccionarNodo(_InformeSeleccionar);
            Application.DoEvents();


            base.Cargar();
        }

        /// <summary>
        /// Funcion que establece el icono que deben tener los nodos
        /// existen 2 posibles:
        ///     - Si es un nodo contenedor: Imagen de Carpeta
        ///     - Si es un nodo elemento:   Imagen de Informe
        /// </summary>
        /// <param name="nodos"></param>
        void CambiarIconosNodos(TreeNodeCollection nodos)
        {
            foreach (TreeNode item in nodos)
            {
                if (item.Nodes.Count > 0)
                {
                    item.ImageIndex = (int)Imagenes.Carpeta;
                    item.SelectedImageIndex = (int)Imagenes.Carpeta;
                    CambiarIconosNodos(item.Nodes);

                }
                else
                {
                    item.ImageIndex = (int)Imagenes.Informe;
                    item.SelectedImageIndex = (int)Imagenes.Informe;
                }
            }
        }
        #endregion

        
       
    
    }



}

///Francisco J. Gonzalez 21-02-2008

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using System.Reflection;

namespace GEXVOC.Core.Controles
{
    /// <summary>
    /// Simplemente es un combo, solo que con aspecto de textbox y de solo lectura
    /// Se utilizará como el tipico control de busqueda que abre un formulario Find 
    /// El formulario Find lo recibe como parametro en una de sus sobrecargas y le carga los datos en funcion
    /// del modo y seleccion.
    /// </summary>
    public partial class ctlBuscarObjeto : ComboBox
    {

        #region CONSTRUCTOR
            /// <summary>
            /// Constuctor sin parámetros, establece las propiedades predenterminadas al control.
            /// </summary>
            public ctlBuscarObjeto()
            {
                InitializeComponent();
                this.BackColor = Color.FromName("Control");//Le doy un color gris de fondo.
                this.DropDownStyle = ComboBoxStyle.Simple;
                this.Size = new Size(this.Size.Width, 21);//Elimino la posibilidad de que el control sea más alto que una linea
            }
        #endregion        

        #region SOBREESCRITURAS

            /// <summary>
            /// Bloqueo la propiedad DropDownStyle para que no se pueda cambiar, el estilo en este
            /// control será siempre simple debido a su naturaleza.
            /// </summary>
            /// <param name="e"></param>
            protected override void OnDropDownStyleChanged(EventArgs e)
            {
                if (this.DropDownStyle!=ComboBoxStyle.Simple)
                    this.DropDownStyle = ComboBoxStyle.Simple;

                base.OnSizeChanged(e);
            }

            /// <summary>
            /// Para conservar el estilo del control, bloqueo la propiedad Size.Height en 21 ptos
            /// </summary>
            /// <param name="e"></param>
            protected override void OnSizeChanged(EventArgs e)
            {
                if (this.Size.Height != 21)
                    this.Size = new Size(this.Size.Width, 21);
                base.OnSizeChanged(e);
            }

            /// <summary>
            /// Elimino cualquir posibilidad de pulsaciones de teclas , ya que este control por su 
            /// naturaleza es de solo lectura, solo se podrá cambiar su valor a través de formularios Find.
            /// </summary>
            /// <param name="e"></param>
            protected override void OnKeyPress(KeyPressEventArgs e)
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }

            /// <summary>
            /// Compruebo las teclas presionadas pues es posible que activen funcionamientos internos del control
            /// por ejemplo:  
            /// - Probocar lanzamiento del formulario buscar a través del btnBuscar asociado.
            /// - Eliminar los datos cargados
            /// - etc...
            /// </summary>
            /// <param name="e"></param>
            protected override void OnKeyDown(KeyEventArgs e)
            {
                if (e.KeyData == Keys.Back && PermitirEliminar)//Capturo la tecla backspace y limpio el control si es pulsada
                {
                    this.SelectedItem = null;
                    ClaseActiva = null;
                }
                if (e.KeyData == _TeclaBusqueda && this._btnBusqueda != null && !this.ReadOnly)
                    this._btnBusqueda.PerformClick();//Proboco el click del boton si las condiciones lo permiten y la tecla abreviada correspondiente es pulsada.


                if (e.Control && e.KeyCode == Keys.A && !this.ReadOnly)
                {
                    OnCrearNuevo(System.EventArgs.Empty);                   
                }

                e.Handled = true;
                
                base.OnKeyDown(e);
            }

        #endregion

        #region PROPIEDADES PERSONALIZADAS

            Boolean _PermitirEliminar = true;
            /// <summary>
            /// Esta propiedad nos indica si vamos a activar el funcionamiento de la tecla BackSpace o no.
            /// Por defecto se permite eliminar.
            /// </summary>
            public Boolean PermitirEliminar
            {
                get { return _PermitirEliminar; }
                set { _PermitirEliminar = value; }
            }

            Boolean _PermitirLimpiar= true;
            /// <summary>
            /// Esta propiedad nos indica si vamos a activar la posibilidad de que se vacie el boton pulsando la tecla limpiar.
            /// Por defecto se permite eliminar.
            /// </summary>
            public Boolean PermitirLimpiar
            {
                get { return _PermitirLimpiar; }
                set { _PermitirLimpiar = value; }
            }

            IClaseBase _ClaseActiva = null;
            /// <summary>
            /// Establece al ctlBuscarObjeto una clase base como elemento activo
            /// </summary>
            public IClaseBase ClaseActiva
            {
                get {
                ////{   //Si no existe una clase activa, puede ser que si exista un datasource con elementos
                ////    IClaseBase rtno = null;
                ////    if (_ClaseActiva == null && this.DataSource != null && ((List<IClaseBase>)this.DataSource).Count == 1)
                ////        rtno = ((List<IClaseBase>)this.DataSource).First();
                ////    else
                ////        rtno = _ClaseActiva;
                
                    return _ClaseActiva;
                }
                set
                {

                    string DisplayMember = this.DisplayMember;//Guardo el display member pq lo pierde                
                    this.DataSource = null;
                    this.Items.Clear();
                    if (value != null)
                    {
                        this.Items.Add(value);
                        this.SelectedItem = value;

                    }
                    else
                    {
                        this.SelectedItem = null;
                        this.Text = string.Empty;
                    }
                    this.DisplayMember = DisplayMember;//Vuelvo a asignar el DisplayMember


                    

                    _ClaseActiva = value;

                    //lanzo el evento de cambiado
                    ctlBuscarObjetoEventArgs eventArgs = new ctlBuscarObjetoEventArgs();
                    eventArgs.ClaseActiva = value;

                    OnClaseActivaChanged(eventArgs);
                }
            }

            /// <summary>
            /// Retorna el identificador de la clase base activa, retorna '0' si no existe ninguna
            /// </summary>
            public int IdClaseActiva
            {
                set
                {
                    try
                    {
                        if (TipoDatos != null)
                        {
                            try
                            {
                                object claseBase = this.GetType().Assembly.CreateInstance(TipoDatos.ToString());//Creo la clase.                           
                                MethodInfo mtdoBuscar = claseBase.GetType().GetMethod("Buscar", new Type[] { typeof(int) });//Busco el método Buscar
                                if (mtdoBuscar != null)//Método buscar con parámetro int existe, lo invoco.
                                    ClaseActiva = (IClaseBase)mtdoBuscar.Invoke(claseBase, new object[] { value });
                                else//Método buscar con parámetro int NO existe, Lanzo excepción.
                                    throw new Exception("No se encuentra el método buscar(int) en la clase especificada." + //: " + (claseBase).ToString() +
                                        "\rEste método es obligatorio para que el control ctlBuscarObjeto pueda asignar valores a su propiedad IdClaseActiva");
                            }
                            catch (Exception)
                            {
                                throw new Exception("Se ha producido un error en la asignacion de la propiedad IdClaseActiva de control ctlBuscarObjeto");
                            }
                            
                            //break;
                            //foreach (MethodInfo item in claseBase.GetType().GetMethods())
                            //{
                            //    if (item.Name == "Buscar" && item.GetParameters().Count() == 1 && item.GetParameters()[0].Name.ToUpper() == "ID")
                            //    {
                            //        ClaseActiva = (IClaseBase)item.Invoke(claseBase, new object[] { value });
                            //        break;
                            //    }
                            //}
                        }
                    }
                    catch (Exception)
                    {
                        
                        throw;
                    }
                    
                
                }
                get 
                { 
                    int rtno=0;
                    if (this._ClaseActiva != null)
                        rtno = this._ClaseActiva.Id;
                        return  rtno;
                }
                    
            }

            /// <summary>
            /// Retorna el identificador de la clase base activa, retorna 'null' si no existe ninguna
            /// </summary>
            public int? IdClaseActivaNullable
            {
                get
                {
                    int? rtno =null;
                    if (this._ClaseActiva != null)
                        rtno = this._ClaseActiva.Id;
                    return rtno;
                }

            }

            Button _btnBusqueda=null;        
            /// <summary>
            /// Representa el Botón Buscar que lanza los formularios en modo consulta que nos proporcionan
            /// los datos.
            /// Debe estar valorado en practicamente la totalidad de casos, debe ser especificado en el 
            /// diseño del formulario.
            /// </summary>
            public Button btnBusqueda
            {
                get { return _btnBusqueda; }
                set { _btnBusqueda = value; }
            }

            bool _ReadOnly=false;
            /// <summary>
            /// Nos indica si el control se encuentra en modo Solo lectura, o si por el contrario
            /// permitirá que el usuario actualice su valor.
            /// Esta propiedad tendrá una repercusión directa sobre las propiedades: 
            /// - TabStop
            /// - PermitirEliminar
            /// - btnBusqueda.Enabled
            /// </summary>
            public bool ReadOnly
            {
                get { return _ReadOnly; }
                set { 
                    
                    this.TabStop = !value;
                    this.PermitirEliminar = !value;
                    if (this.btnBusqueda != null)
                        btnBusqueda.Enabled = !value;

                    _ReadOnly = value; 
                }
            }

            Keys _TeclaBusqueda = (Keys)(Keys.Control | Keys.B);
            /// <summary>
            /// Tecla abreviada que probocará que se lance el formulario de búsqueda
            /// Nota: Es necesario que la propiedad btnBusqueda se encuentre valorada para que funcione.
            /// </summary>
            public Keys TeclaBusqueda
            {
                get { return _TeclaBusqueda; }
                set { _TeclaBusqueda = value; }
            }

            protected override void OnVisibleChanged(EventArgs e)
            {
                if (this.btnBusqueda != null)
                    this.btnBusqueda.Visible = this.Visible;
                base.OnVisibleChanged(e);
            }

            bool _ControlVisible = true;
            /// <summary>
            /// Nos indica si el control está visible o no.
            /// </summary>
            public bool ControlVisible
            {
                get { return _ControlVisible; }
                set
                {
                    _ControlVisible = value;
                    this.Visible = _ControlVisible;
                }
            }

            System.Type _TipoDatos=null;
            /// <summary>
            /// Proporciona al control información sobre el tipo de datos al que pertenecerá
            /// su clase principal.
            /// Se utiliza en propiedades como IdClaseActiva.
            /// En control se vale de este tipo para crear objetos de su tipo principal y acceder a sus propiedades y métodos.
            /// </summary>
            public System.Type TipoDatos
            {
                get { return _TipoDatos; }
                set { _TipoDatos = value; }
            }

        #endregion

        #region EVENTOS PERSONALIZADOS   
            /// <summary>
            /// Evento que se produce cuando se cambia la clase activa en el control.
            /// El evento publica la clase activa.
            /// Se produce también cuando se libera la clase activa.
            /// </summary>
            public event EventHandler<ctlBuscarObjetoEventArgs> ClaseActivaChanged;
            /// <summary>
            /// Lanzador del evento.
            /// </summary>
            /// <param name="e"></param>
            protected virtual void OnClaseActivaChanged(ctlBuscarObjetoEventArgs e)
            {
                EventHandler<ctlBuscarObjetoEventArgs> handler = ClaseActivaChanged;
                if (handler != null)
                {
                    handler(this, e);
                }
            }

            public event System.EventHandler CrearNuevo;

            /// <summary>
            /// Lanzador del evento.
            /// </summary>
            /// <param name="e"></param>
            protected virtual void OnCrearNuevo(System.EventArgs e)
            {
                //Asigno la descripcicion de texto a crear siempre se se cumplan 2 condiciones, que el control
                //contenga texto, y que dicho texto no se corresponda con un elemento existente.
                //if (idClaseActiva == null && e != null && this.Text != string.Empty)
                //    e.TextoCrear = this.Text;

                System.EventHandler handler = CrearNuevo;
                if (handler != null)
                {
                    handler(this, e);
                }
            }

        

        #endregion


    }

    
}

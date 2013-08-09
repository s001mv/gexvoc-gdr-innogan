using System;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using GEXVOC.Core.Controles;
using GEXVOC.Core.Logic;
using System.Data;
using System.Collections.Generic;
using System.Data.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Linq;


namespace GEXVOC.UI.Clases
{
    /// <summary>
    /// Clase almacén de funciones globales de interfaz de usuario.
    /// </summary>
    public static class Generic
    {
        #region Campo activo

        /// <summary>
        /// Establece resaltado para el campo activo.
        /// </summary>
        /// <param name="obj">Formulario a modificar.</param>
        public static void ResaltarCampoActivo(Control obj)
        {
            foreach (Control c in obj.Controls)
                switch (c.GetType().ToString())
                {
                    case "System.Windows.Forms.TextBox":
                        c.Enter += new EventHandler(Activar);
                        c.Leave += new EventHandler(Desactivar);
                        break;
                    case "System.Windows.Forms.ComboBox":
                        c.Enter += new EventHandler(Activar);
                        c.Leave += new EventHandler(Desactivar);
                        break;
                    case "System.Windows.Forms.GroupBox":
                        ResaltarCampoActivo(c);
                        break;
                    case "System.Windows.Forms.Panel":
                        ResaltarCampoActivo(c);
                        break;
                    case "System.Windows.Forms.TabControl":
                        ResaltarCampoActivo(c);
                        break;
                    case "System.Windows.Forms.TabPage":
                        ResaltarCampoActivo(c);
                        break;
                }
        }

        /// <summary>
        /// Controla el evento de activación del control.
        /// </summary>
        /// <param name="sender">Control que produce el evento.</param>
        /// <param name="e">Información sobre el evento.</param>
        private static void Activar(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = System.Drawing.Color.Azure;
        }

        /// <summary>
        /// Controla el evento de desactivación del control.
        /// </summary>
        /// <param name="sender">Control que produce el evento.</param>
        /// <param name="e">Información sobre el evento.</param>
        private static void Desactivar(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = System.Drawing.SystemColors.Window;
        }

        #endregion
        

      


        /// <summary>
        /// Borra el contenido de los controles del formulario.
        /// </summary>
        /// <param name="obj">Formulario a limpiar.</param>
        public static void LimpiarControles(Control obj)
        {
            foreach (Control c in obj.Controls)
            {
                switch (c.GetType().ToString())
                {
                    case "System.Windows.Forms.TextBox":
                        c.Text = "";
                        if (c.Tag != null)
                            c.Tag = null;

                        break;
                    case "System.Windows.Forms.MaskedTextBox":
                        c.Text = string.Empty;                        
                        break;
                    case "System.Windows.Forms.ListView":
                        ((ListView)c).Items.Clear();
                        break;
                    case "System.Windows.Forms.CheckBox":
                        ((CheckBox)c).Checked = false;
                        break;
                    case "System.Windows.Forms.ComboBox":
                        ((ComboBox)c).SelectedIndex = -1;
                        ((ComboBox)c).Text = string.Empty;
                        break;
                    case "GEXVOC.Core.Controles.ctlBuscarObjeto":
                        if (((ctlBuscarObjeto)c).PermitirEliminar)
                        {
                            ((ctlBuscarObjeto)c).SelectedIndex = -1;
                            ((ctlBuscarObjeto)c).ClaseActiva = null;                            
                        }
                        break;
                    case "GEXVOC.Core.Controles.ctlCombo":
                        if (((ctlCombo)c).Enabled)
                        {
                            ((ctlCombo)c).SelectedIndex = -1;
                            ((ctlCombo)c).Text = string.Empty;                           
                        }    

                        break;
                    case "GEXVOC.Core.Controles.ctlInforme":
                        LimpiarControles(c);
                        break;
                    case "GEXVOC.Core.Controles.ctlFecha":
                        ((ctlFecha)c).Value = null;
                        break;
                    case "System.Windows.Forms.DataGridView":
                        ((DataGridView)c).DataSource = null;
                        ((DataGridView)c).Rows.Clear();                    

                        break;
                    case "System.Windows.Forms.GroupBox":
                        LimpiarControles(c);
                        break;
                    case "System.Windows.Forms.TabControl":
                        foreach (TabPage item in ((TabControl)c).TabPages)	                    
                            LimpiarControles(item);
                        break;
                    case "System.Windows.Forms.TableLayoutPanel":
                        LimpiarControles(c);
                        break;
                    case "System.Windows.Forms.Panel":
                        LimpiarControles(c);
                        break;
                    case "CrystalDecisions.Windows.Forms.CrystalReportViewer":
                        ((CrystalDecisions.Windows.Forms.CrystalReportViewer)c).ReportSource=null;
                        break;
                        
                    case "System.Windows.Forms.SplitContainer":
                        LimpiarControles(((SplitContainer)c).Panel1);
                        LimpiarControles(((SplitContainer)c).Panel2);                        
                        break;
                        
                    case "System.Windows.Forms.SplitterPanel":
                        LimpiarControles(c);
                        break;


                     default:
                        try
                        {
                            if (c.GetType().BaseType == typeof(ctlInforme))
	                        {
                               // ((ctlInforme)c).ErrorProvider.Clear();
                                LimpiarControles(c);
	                        }
                        }
                        catch (Exception)
                        {}
                        
                        break;


                     
                }
              
            }
        }

        /// <summary>
        /// Funcion recursiva que recorre todos los controles del formulario en busca de Objetos del tipo DataGridView,
        /// una vez encontrados, les cabia la propiedad AutoGenerateColumns a false para utilizar nuestros estilos
        /// personalizados en el diseño y que no se generen automaticamente las columnas
        /// que faltal.
        /// Esta funcion es llamada desde GenericEdit.InicializarGenericEdit();
        /// </summary>
        /// <param name="obj"></param>
        public static void EliminarAutogenerateColumns(Control obj)
        {
            foreach (Control c in obj.Controls)
            {
                switch (c.GetType().ToString())
                {
                 
                    case "System.Windows.Forms.DataGridView":
                        ((DataGridView)c).AutoGenerateColumns = false;
                        break;
                    case "System.Windows.Forms.GroupBox":
                        EliminarAutogenerateColumns(c);
                        break;
                    case "System.Windows.Forms.Panel":
                        EliminarAutogenerateColumns(c);
                        break;
                    case "System.Windows.Forms.TableLayoutPanel":
                        EliminarAutogenerateColumns(c);
                        break;

                    case "System.Windows.Forms.TabControl":
                        foreach (TabPage tabpage in ((TabControl)c).TabPages)
                        {
                            EliminarAutogenerateColumns(tabpage);
                        }
                        
                        break;
                

                }
            }
        }

        /// <summary>
        /// Establece las propiedades pertinenetes en los controles que indican al control que represente todos sus datos en mayúsculas.
        /// </summary>
        /// <param name="obj"></param>
        public static void PonerControlesMayusculas(Control obj)
        {
            foreach (Control c in obj.Controls)
            {
                switch (c.GetType().ToString())
                {
                    case "System.Windows.Forms.TextBox":                            
                        ///El caso de los textbox es algo especial
                        ///en ocasiones no quiero poner todo en mayusculas, con lo que establezco la propiedad CharacterCasing a Lower, para indicar que dicho control va a trabajar de forma normal.
                        /// en cualquier otro caso, siempre mayúsculas
                        if (((TextBox)c).CharacterCasing == CharacterCasing.Lower)
                            ((TextBox)c).CharacterCasing = CharacterCasing.Normal;
                        else
                            ((TextBox)c).CharacterCasing = CharacterCasing.Upper;
                        break;
                    case "GEXVOC.Core.Controles.ctlCombo":
                        ((ctlCombo)c).CharacterCasing = CharacterCasing.Upper;
                        break;
                    case "System.Windows.Forms.ComboBox":
                        ((ComboBox)c).KeyPress += Combo_KeyPress;//hacemos que los combos normales le pasen el evento KeyPress a nuestra funcion Combo_KeyPress
                        break;
                    case "System.Windows.Forms.GroupBox":
                        PonerControlesMayusculas(c);
                        break;
                    case "System.Windows.Forms.Panel":
                        PonerControlesMayusculas(c);
                        break;
                    case "System.Windows.Forms.TableLayoutPanel":
                        PonerControlesMayusculas(c);
                        break;

                    case "System.Windows.Forms.TabControl":
                        foreach (TabPage tabpage in ((TabControl)c).TabPages)                        
                            PonerControlesMayusculas(tabpage);
                        break;
                    case "System.Windows.Forms.MaskedTextBox":
                        ((MaskedTextBox)c).KeyPress += Combo_KeyPress;
                        break;
                    case "GEXVOC.Core.Controles.Asistente.Wizard":
                        foreach (Core.Controles.Asistente.WizardPage item in ((Core.Controles.Asistente.Wizard)c).Pages)                        
                            PonerControlesMayusculas(item);                        
                        break;
                }
            }
        }

        /// <summary>
       /// Actuará como una funcion de delegado
       /// en tiempo de ejecución el evento keypress de todos los combos será asignado a este "delegado"
       /// que se encarga de que toda pulsacion se convierta a mayusculas.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private static void Combo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);//Transformo la tecla presionada en su compatible en mayusculas
        }

        

        /// <summary>
        /// Concatena una cantidad ilimitada de cadenas.
        /// </summary>
        /// <param name="args">Cadenas a concatenar.</param>
        /// <returns>Cadena resultado de la concatenación.</returns>
        public static string Concatenar(params string[] args)
        {
            StringBuilder sb = new StringBuilder();

            if (args.Length > 0)
                foreach (String arg in args)
                    sb.Append(arg);
            else
                sb.Append("");

            return sb.ToString();
        }

        /// <summary>
        /// Obtiene la letra de NIF correspondiente a un DNI.
        /// </summary>
        /// <param name="dni">DNI del que obtener la letra.</param>
        /// <returns>Letra de NIF.</returns>
        public static char CalcularLetraNIF(string dni)
        {
            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";

            int pos = Convert.ToInt32(dni) % 23;

            return Convert.ToChar(letras.Substring(pos, 1));
        }

        /// <summary>
        /// Método para dividir una cadena a partir de otra cadena.
        /// </summary>
        /// <param name="cadena">Cadena a partir.</param>
        /// <param name="sep">Cadena a utilizar como separador.</param>
        /// <returns></returns>
        public static string[] DividirCadena(string cadena, string sep)
        {
            ArrayList cad = new ArrayList();
            int pos = cadena.IndexOf(sep);

            while (pos != -1)
            {
                cad.Add(cadena.Substring(0, pos));
                cadena = cadena.Remove(0, pos + sep.Length);

                if (cadena.IndexOf(sep) == -1)
                {
                    if (cadena == "")
                        cad.Add("");
                    else
                        cad.Add(cadena.Substring(0, cadena.Length));
                    break;
                }

                pos = cadena.IndexOf(sep);
            }

            string[] result = new string[cad.Count];
            cad.CopyTo(result);

            return result;
        }

        /// <summary>
        /// Método para la validación de campos introducidos por el usuario.
        /// </summary>
        /// <param name="campo">Campo a validar.</param>
        /// <returns>Resultado de la validación.</returns>
        public static string ValidarSQL(string campo)
        {
            if (campo.IndexOf("'") != -1)
                campo = campo.Replace("'", "''");
            if (campo.IndexOf("[") != -1)
                campo = campo.Replace("[", "[[]");
            if (campo.IndexOf("%") != -1)
                campo = campo.Replace("%", "[%]");
            if (campo.IndexOf("_") != -1)
                campo = campo.Replace("_", "[_]");

            return campo;
        }

        /// <summary>
        /// Añade los separadores "/" a una fecha introducida por el usuario.
        /// </summary>
        /// <param name="fecha">Fecha introducida por el usuario.</param>
        /// <returns>Fecha formateada.</returns>
        public static string FormatearFecha(string fecha)
        {
            if (fecha != "")
                if(fecha.Length == 8 && fecha.IndexOf("/") == -1)
                    try
                    {
                        if(Validacion.EsFecha(fecha.Substring(0, 2) + "/" + fecha.Substring(2, 2) + "/" + fecha.Substring(4, 4)))
                            fecha = fecha.Substring(0, 2) + "/" + fecha.Substring(2, 2) + "/" + fecha.Substring(4, 4);
                    }
                    catch
                    {
                    }

            return fecha;
        }

        /// <summary>
        /// Crea una ventana de aviso.
        /// </summary>
        /// <param name="texto">Texto a mostrar.</param>
        /// <param name="titulo">Titulo de la ventana.</param>
        /// <param name="botones">Botones a mostrar.</param>
        /// <param name="icono">Icono a mostrar.</param>
        public static DialogResult Aviso(string texto, string titulo, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            Traza.RegistrarInfo(texto);
            return MessageBox.Show(texto, titulo, botones, icono);
        }
        public static DialogResult AvisoInformation(string texto)
        {
            Traza.RegistrarInfo(texto);
            return MessageBox.Show(texto,Application.ProductName,  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult AvisoError(string texto)
        {
            Traza.RegistrarError(texto);
            return MessageBox.Show(texto, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult AvisoAdvertencia(string texto)
        {
            Traza.RegistrarInfo(texto);
            return MessageBox.Show(texto, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Realiza una pregunta al usuario, registrandola en la traza.
        /// Permite asignar los botones de las posibles respuestas
        /// </summary>
        /// <param name="textoPregunta"></param>
        /// <param name="respuestas"></param>
        /// <returns></returns>
        public static DialogResult Pregunta(string textoPregunta, MessageBoxButtons respuestas)         
        {

            Traza.RegistrarInfo("Pregunta: " + textoPregunta);
            DialogResult rdo = MessageBox.Show(textoPregunta, "Atención", respuestas, MessageBoxIcon.Question);
            Traza.RegistrarInfo("Respuesta: " + rdo.ToString());

            return rdo;        
        }
        public static DialogResult Pregunta(string textoPregunta)
        {
            return Pregunta(textoPregunta, MessageBoxButtons.YesNo); ;
        }


        #region CONTROL A TYPE
            public static DateTime? ControlADatetimeNullable(Control control)
            { 
                DateTime? Rtno=null;
                if (control is TextBox || control is MaskedTextBox)
                {
                    try
                    {
                        Rtno = Convert.ToDateTime(control.Text);
                    }
                    catch (Exception)
                    { }
                }
                if (control is ctlFecha)
                {    
                    Rtno = ((ctlFecha)control).Value;                   
                }
               
            
                return Rtno;
            }
            public static DateTime ControlADatetime(Control control)
            {
                DateTime Rtno=DateTime.Now.Date;

                DateTime? rdo = ControlADatetimeNullable(control);

                if (rdo != null)
                    Rtno = (DateTime)rdo;
                else
                    throw new Exception("El control no contiene una fecha válida");

                return Rtno;
            }
            public static DateTime ControlADatetime(Control control,DateTime valorDefecto)
            {
                DateTime Rtno = valorDefecto;

                DateTime? rdo = ControlADatetimeNullable(control);

                if (rdo != null)
                    Rtno = (DateTime)rdo;
              
                return Rtno;
            }

            public static Decimal? ControlADecimalNullable(Control control)
            {
                Decimal? Rtno = null;

                if (control is TextBox || control is MaskedTextBox)
                {

                    try
                    {
                        Rtno = Convert.ToDecimal(control.Text.Replace(".", ","));
                    }
                    catch (Exception) { }
                }



                return Rtno;
            }
            public static Decimal ControlADecimal(Control control)
            {
                Decimal Rtno = 0;
                Decimal? rdo = ControlADecimalNullable(control);
                if (rdo != null)
                    Rtno = (decimal)rdo;
              
                return Rtno;
            }
            public static Decimal ControlADecimal(Control control,Decimal valorDefecto)
            {
                Decimal Rtno = valorDefecto;
                Decimal? rdo = ControlADecimalNullable(control);
                if (rdo != null)
                    Rtno = (decimal)rdo;

                return Rtno;
            }

            public static int? ControlAIntNullable(Control control)
            {
                int? rtno = null;


                if (control is TextBox)
                {
                    if (Validacion.EsEntero(control.Text))
                        rtno = Convert.ToInt32(control.Text);
                }
                if (control is ComboBox)
                {
                    if (((ComboBox)control).SelectedValue != null)
                    {
                        try
                        {
                            rtno = (int?)((ComboBox)control).SelectedValue;
                        }
                        catch (Exception){}
                    }
                    
                }
                if (control is ctlBuscarObjeto)
                {
                    rtno = ((ctlBuscarObjeto)control).IdClaseActivaNullable;
                }


                return rtno;
            }
            public static int ControlAInt(Control control)
            {//Simplemente llama a ControlAIntNullable y en el caso de devolver nulo, devolvemos 0
                int Rtno = 0;

                int? rdo = ControlAIntNullable(control);
                if (rdo != null)
                    Rtno = (int)rdo;


                return Rtno;
            }
            public static int ControlAInt(Control control, int valorDefecto)
            {//Simplemente llama a ControlAIntNullable y en el caso de devolver nulo, devolvemos el Valor por defecto
                int Rtno = valorDefecto;

                int? rdo = ControlAIntNullable(control);
                if (rdo != null)
                    Rtno = (int)rdo;


                return Rtno;
            }


            public static string ControlAString(Control control)
            {
                string rtno = string.Empty;

                if (control is TextBox || control is MaskedTextBox)
                {
                    rtno = control.Text;
                }
                if (control is ComboBox)
                {
                    rtno = ((ComboBox)control).Text;
                }
            

                return rtno;
            }
            public static string ControlAString(Control control,string valorDefecto)
            {
                string rtno = valorDefecto;
                string rdo = ControlAString(control);
                if (rdo != string.Empty)
                    rtno = rdo;


                return rtno;
            }

            public static char? ControlACharNullable(Control control)
            {
                char? rtno = null;

                if (control is TextBox || control is MaskedTextBox)
                {
                    if (control.Text!=string.Empty)
                        rtno = Convert.ToChar(control.Text);
                    
                }
                if (control is ComboBox)
                {
                    if (((ComboBox)control).SelectedValue != null)
                        rtno = Convert.ToChar(((ComboBox)control).SelectedValue);
                }


                return rtno;
            }
            public static char ControlAChar(Control control, char valorDefecto)
            {
                char rtno = valorDefecto;
                char? rdo = ControlACharNullable(control);
                if (rdo != null)
                    rtno = (char)rdo;


                return rtno;
            }
            public static char ControlAChar(Control control)
            {
                char rtno = Convert.ToChar(" ");
                char? rdo = ControlACharNullable(control);
                if (rdo != null)
                    rtno = (char)rdo;


                return rtno;
            }



            public static Boolean? ControlABooleanNullable(Control control)
            {
                Boolean? Rtno = null;

                if (control is CheckBox)
                {
                    try
                    {
                        Rtno = ((CheckBox)control).Checked;
                    }
                    catch (Exception) { }
                }
                if (control is ComboBox)
                {
                    try
                    {
                        if (((ComboBox)control).SelectedValue!=null)
                            Rtno = (bool)((ComboBox)control).SelectedValue;    
                                                
                    }
                    catch (Exception) { }
                }



                return Rtno;
            }
            public static Boolean ControlABoolean(Control control)
            {
                Boolean Rtno = false;
                Boolean? rdo = ControlABooleanNullable(control);
                if (rdo != null)
                    Rtno = (bool)rdo;

                return Rtno;
            }

        #endregion

        #region TYPE A CONTROL
            public static void StringAControl(Control control,string valor)
        {
            if (control is TextBox || control is MaskedTextBox)
            {
                control.Text = valor;
            }
            if (control is ComboBox)
            {
                ((ComboBox)control).Text=valor;
            }
        }
            public static void IntNullableAControl(Control control,int? valor)
            {
                if (control is TextBox || control is MaskedTextBox)
                {
                    if (valor != null)
                        control.Text = valor.ToString();
                    else
                        control.Text = string.Empty;
                }
                if (control is ComboBox)
                {
                    if (valor != null)
                        ((ComboBox)control).SelectedValue = valor;
                    else
                        ((ComboBox)control).SelectedIndex = -1;

                }
                if (control is ctlBuscarObjeto)
                {
                    if (valor != null)
                        ((ctlBuscarObjeto)control).IdClaseActiva = (int)valor;
                    else
                        ((ctlBuscarObjeto)control).ClaseActiva = null;

                }

             }
            public static void IntAControl(Control control, int valor)
            {
                IntNullableAControl(control,valor);
            }                
            public static void DatetimeAControl(Control control, DateTime valor)
            {
                DatetimeNullableAControl(control, valor);           

            }
            public static void DatetimeNullableAControl(Control control, DateTime? valor)
            {
                if (control is TextBox || control is MaskedTextBox)
                {
                    if (valor == null)
                        control.Text = string.Empty;
                    else
                        control.Text = ((DateTime)valor).ToShortDateString();//No hay problema en pasarla a DateTime porque ya nos aseguramos de que no es nulo
                }
                if (control is ctlFecha)                
                    ((ctlFecha)control).Value = valor;                    
                

            }
            public static void CharNullableAControl(Control control, char? valor)
            {
                if (control is TextBox || control is MaskedTextBox)
                {
                    if (valor != null)
                        control.Text = valor.ToString();
                    else
                        control.Text = string.Empty;

                }
                if (control is ComboBox)
                {
                    if (valor != null)
                        ((ComboBox)control).SelectedValue = valor;

                    else
                    {
                        ((ComboBox)control).Text = string.Empty;                    
                        ((ComboBox)control).SelectedIndex = -1;
                    }

                }
            }
            public static void CharAControl(Control control, char valor)
            {
                CharNullableAControl(control, valor);
            }

            public static void DecimalNullableAControl(Control control, decimal? valor)
            {
                if (control is TextBox || control is MaskedTextBox)
                {
                    if (valor != null)
                        control.Text = valor.ToString();
                    else
                        control.Text = string.Empty;
                }
              
            }
            public static void DecimalAControl(Control control, decimal? valor)
            {
                DecimalNullableAControl(control, valor);
            }


            public static void BooleanNullableAControl(Control control, Boolean? valor)
            {
                if (control is CheckBox)
                {
                    if (valor != null)
                        ((CheckBox)control).Checked = (Boolean)valor;
                    //else
                    //    ((CheckBox)control).Checked = false;
                }

            }
            public static void BooleanAControl(Control control, Boolean valor)
            {
                BooleanNullableAControl(control, valor);

            }
        #endregion

        
        public static void ClaseBaseAcontrol(object objeto,string nombrePropiedad, Control control)
        {
            if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(string))
                StringAControl(control,(string) objeto.GetType().GetProperty(nombrePropiedad).GetValue(objeto, null));

            if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(DateTime?))
                DatetimeNullableAControl(control, (DateTime?)objeto.GetType().GetProperty(nombrePropiedad).GetValue(objeto, null));
            if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(DateTime))
                DatetimeAControl(control, (DateTime)objeto.GetType().GetProperty(nombrePropiedad).GetValue(objeto, null));           

            if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(int?))                
                IntNullableAControl(control, (int?)objeto.GetType().GetProperty(nombrePropiedad).GetValue(objeto, null));                   
            if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(int))
                IntAControl(control, (int)objeto.GetType().GetProperty(nombrePropiedad).GetValue(objeto, null));          

            if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(char?))
                CharNullableAControl(control, (char?)objeto.GetType().GetProperty(nombrePropiedad).GetValue(objeto, null));
            if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(char))
                CharAControl(control, (char)objeto.GetType().GetProperty(nombrePropiedad).GetValue(objeto, null));

            if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(Decimal?))
                DecimalNullableAControl(control, (decimal?)objeto.GetType().GetProperty(nombrePropiedad).GetValue(objeto, null));
            if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(Decimal))
                DecimalAControl(control, (decimal)objeto.GetType().GetProperty(nombrePropiedad).GetValue(objeto, null));

            if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(Boolean?))
                BooleanNullableAControl(control, (Boolean?)objeto.GetType().GetProperty(nombrePropiedad).GetValue(objeto, null));
            if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(Boolean))
                BooleanAControl(control, (Boolean)objeto.GetType().GetProperty(nombrePropiedad).GetValue(objeto, null));

        
        }
        public static void ControlAClaseBase(object objeto, string nombrePropiedad, Control control)
        {
            if (objeto == null || nombrePropiedad == string.Empty || control == null)
                throw new Exception("No se han completado los requisitos míminos para llamar a este procedimiento");


            try
            {
                if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(string))
                    objeto.GetType().GetProperty(nombrePropiedad).SetValue(objeto, ControlAString(control), null);

                if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(DateTime?))
                    objeto.GetType().GetProperty(nombrePropiedad).SetValue(objeto, ControlADatetimeNullable(control), null);
                if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(DateTime))
                    objeto.GetType().GetProperty(nombrePropiedad).SetValue(objeto, ControlADatetime(control), null);

                if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(int?))
                    objeto.GetType().GetProperty(nombrePropiedad).SetValue(objeto, ControlAIntNullable(control), null);
                if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(int))
                    objeto.GetType().GetProperty(nombrePropiedad).SetValue(objeto, ControlAInt(control), null);              

                if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(char?))
                    objeto.GetType().GetProperty(nombrePropiedad).SetValue(objeto, ControlACharNullable(control), null);
                if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(char))
                    objeto.GetType().GetProperty(nombrePropiedad).SetValue(objeto, ControlAChar(control), null);

                if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(decimal?))
                    objeto.GetType().GetProperty(nombrePropiedad).SetValue(objeto, ControlADecimalNullable(control), null);
                if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(decimal))
                    objeto.GetType().GetProperty(nombrePropiedad).SetValue(objeto, ControlADecimal(control), null);                  

                if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(Boolean?))
                    objeto.GetType().GetProperty(nombrePropiedad).SetValue(objeto, ControlABooleanNullable(control), null);
                if (objeto.GetType().GetProperty(nombrePropiedad).PropertyType == typeof(Boolean))
                    objeto.GetType().GetProperty(nombrePropiedad).SetValue(objeto, ControlABoolean(control), null);



            }
            catch (Exception ex)
            {
                if (ex.InnerException!=null && ex.InnerException.GetType() == typeof(LogicException))
                    throw ex.InnerException;
                else
                    throw new Exception("Se ha producido un error en la asignación de la propiedad " + nombrePropiedad);
            }
              

        }


        /// <summary>
        /// Permite realizar el proceso de establecer en una propiedad de la clase el contenido del control
        /// pero antes de hacer esto se asegura de que el contenido del control es compatible, en caso contrario le establece
        /// un error al control.
        /// Hay una funcionalidad añadida, si se especifica un proveedor de errores contenido en un formulario GenericMaestro
        /// a medida que se añadan errores, los controles aparecerán en una lista interna llamada lstControlesConErrores
        /// Que habitualmente cancela la ejecucion de algunas opreaciones en dicho formulario.        
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="nombrePropiedad"></param>
        /// <param name="control"></param>
        /// <param name="Requerido"></param>
        /// <param name="ProveedorErrores"></param>
        public static void ControlAClaseBaseConValidacion(object objeto, string nombrePropiedad, Control control,Boolean Requerido,ErrorProvider ProveedorErrores)
        {
            if (Generic.ControlDatosCorrectos(control, ProveedorErrores, objeto.GetType().GetProperty(nombrePropiedad).PropertyType, Requerido) &&
                Generic.ControlLongitudCorrecta(control,ProveedorErrores,string.Empty,objeto,nombrePropiedad))
            {              
                    try
                    {
                        ControlAClaseBase(objeto, nombrePropiedad, control);
                    }
                    catch (LogicException ex)
                    {
                        Generic.PonerError(ProveedorErrores, control, ex.Message);

                    }
               
            }
            
        }
        public static void ControlAClaseBaseConValidacion(BindingMaestro elementoBind, ErrorProvider ProveedorErrores,IClaseBase ClaseActiva)
        {
            if (Generic.ControlDatosCorrectos(elementoBind.ControlAsociado, ProveedorErrores, elementoBind.TipoDatos, elementoBind.Requerido) &&
                Generic.ControlLongitudCorrecta(elementoBind.ControlAsociado, ProveedorErrores, string.Empty, ClaseActiva, elementoBind.NombrePropiedad))
            {
                bool DatosValidos = true;
                switch (elementoBind.ValidacionEspecial)
                {
                    case ValidacionesEspeciales.EsDNI:
                        DatosValidos = Validacion.EsRegExp(elementoBind.ControlAsociado, elementoBind.Requerido, ProveedorErrores, @"^(X(-|\.)?0?\d{7}(-|\.)?[A-Z]|[A-Z](-|\.)?\d{7}(-|\.)?[0-9A-Z]|\d{8}(-|\.)?[A-Z])$", "DNI-NIF-CIF");
                        
                        break;
                    case ValidacionesEspeciales.EsCodigoPostal:
                        DatosValidos = Validacion.EsRegExp(elementoBind.ControlAsociado, elementoBind.Requerido, ProveedorErrores, @"^([1-9]{2}|[0-9][1-9]|[1-9][0-9])[0-9]{3}$", "Código Postal");
                        break;
                    case ValidacionesEspeciales.EsTarjetaCredito:
                        DatosValidos = Validacion.EsRegExp(elementoBind.ControlAsociado, elementoBind.Requerido, ProveedorErrores, @"^((67\d{2})|(4\d{3})|(5[1-5]\d{2})|(6011))(-?\s?\d{4}){3}|(3[4,7])\ d{2}-?\s?\d{6}-?\s?\d{5}$", "Tarjeta de Crédito");
                        break;
                    case ValidacionesEspeciales.EsTelefono:
                        DatosValidos = Validacion.EsRegExp(elementoBind.ControlAsociado, elementoBind.Requerido, ProveedorErrores, @"^[0-9]{2,3}-? ?[0-9]{6,7}$", "Teléfono");
                        break;
                    case ValidacionesEspeciales.EsEntero:
                        throw new NotImplementedException();                       
                    case ValidacionesEspeciales.EsEnteroPositivo:
                        throw new NotImplementedException();                        
                    case ValidacionesEspeciales.EsNumero:
                        throw new NotImplementedException();                        
                    case ValidacionesEspeciales.EsCodigo:
                        DatosValidos = Validacion.EsRegExp(elementoBind.ControlAsociado, elementoBind.Requerido, ProveedorErrores, "[^0-9]", "Código", elementoBind.LongitudRegExp);
                        break;
                    case ValidacionesEspeciales.EsAlfabetico:
                        DatosValidos = Validacion.EsRegExp(elementoBind.ControlAsociado, elementoBind.Requerido, ProveedorErrores, "[^a-zA-Z]", "Alfabético");
                        break;
                    case ValidacionesEspeciales.EsAlfaNumerico:
                        DatosValidos = Validacion.EsRegExp(elementoBind.ControlAsociado, elementoBind.Requerido, ProveedorErrores, "[^a-zA-Z0-9]", "Alfanumérico");
                        break;
                    case ValidacionesEspeciales.EsEmail:
                        DatosValidos = Validacion.EsRegExp(elementoBind.ControlAsociado, elementoBind.Requerido, ProveedorErrores, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", "Email");
                        break;
                    //default:
                    //    DatosValidos=true;
                }
                if (DatosValidos)
                {
                    try
                    {
                        ControlAClaseBase(ClaseActiva, elementoBind.NombrePropiedad, elementoBind.ControlAsociado);
                    }
                    catch (LogicException ex)
                    {
                        Generic.PonerError(ProveedorErrores, elementoBind.ControlAsociado, ex.Message);

                    }
                }
                


            }
            //if (!Generic.ControlDatosCorrectos(item.ControlAsociado,this.ErrorProvider,item.TipoDatos,item.Requerido))
        }

        /// <summary>
        /// Esta sobrecarga considera todos los elementos como no requeridos (permitirán nulos)
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="nombrePropiedad"></param>
        /// <param name="control"></param>
        /// <param name="ProveedorErrores"></param>
        public static void ControlAClaseBaseConValidacion(object objeto, string nombrePropiedad, Control control, ErrorProvider ProveedorErrores)
        {
            ControlAClaseBaseConValidacion(objeto, nombrePropiedad, control, false, ProveedorErrores);
        }
        
        


        /// <summary>
        /// Funcion que nos indica si un control se encuentra valorado o no.
        /// Se utiliza para los campos requeridos.
        /// La funcion Recibe un Error provider para establecer un punto de error en el control.
        /// </summary>
        /// <param name="txtControl">Control </param>
        /// <param name="ProveedorErrores"></param>
        /// <param name="Mensaje"></param>
        /// <returns></returns>
        public static bool ControlValorado(Control control, ErrorProvider proveedorErrores,string mensaje){
         bool Rtno = true;

         Rtno = ControlValorado(control);
         if (!Rtno) {
             Generic.PonerError(proveedorErrores,control, mensaje);
               
         
         }

         

         return Rtno;

        }
        public static bool ControlValorado(Control control, ErrorProvider proveedorErrores){
            return ControlValorado(control, proveedorErrores, "Valor Obligatorio");
        }
        public static bool ControlValorado(Control control)
        {
            bool Rtno = true;
            switch (control.GetType().FullName)
            {
                case "System.Windows.Forms.TextBox": 
                    if (control.Text == string.Empty)
                        Rtno = false;

                    break;
                case "System.Windows.Forms.MaskedTextBox":
                    MaskedTextBox controlmask = (MaskedTextBox)control;

                    MaskFormat mfMaskFormat = controlmask.TextMaskFormat;//Guardo el valor de la propiedad                    
                    controlmask.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;//Le quito los literales a .Text 
                    if (controlmask.Text == string.Empty)                    
                        Rtno = false;                    
                    controlmask.TextMaskFormat = mfMaskFormat;//Asigno de nuevo la propiedad a su valor original

                    break;
                case "System.Windows.Forms.ComboBox":
                    if (((ComboBox)control).SelectedValue == null)
                        Rtno = false;

                    break;
                case "GEXVOC.Core.Controles.ctlBuscarObjeto":
                    if (((ctlBuscarObjeto)control).ClaseActiva == null && ((ctlBuscarObjeto)control).DataSource==null)
                        Rtno = false;
                    break;
                case "GEXVOC.Core.Controles.ctlCombo":
                    if (((GEXVOC.Core.Controles.ctlCombo)control).SelectedValue == null)
                        Rtno = false;
                    break;
                case "GEXVOC.Core.Controles.ctlFecha":
                    Rtno = ((GEXVOC.Core.Controles.ctlFecha)control).ControlValorado;
                    break;
                


            
            }
            

            //if (control is TextBox)
            //{
            //    if (control.Text == string.Empty)
            //        Rtno = false;
            //}
            //if (control is ComboBox)
            //{
            //    if (((ComboBox)control).SelectedValue ==null)
            //        Rtno = false;
            //}
            //if (control is ctlBuscarObjeto)
            //{
            //    if (((ctlBuscarObjeto)control).ClaseActiva == null)
            //        Rtno = false;
            //}

            return Rtno;
        }      
        public static bool ControlValorado(Control[] controles, ErrorProvider proveedorErrores)
        {
            return ControlValorado(controles, proveedorErrores, "Valor Obligatorio");
        }
        public static bool ControlValorado(Control[] controles, ErrorProvider proveedorErrores,string mensaje)
        {
            Boolean Rtno = true;
            foreach (Control control in controles)
            {
                if (!ControlValorado(control, proveedorErrores, mensaje))
                    Rtno = false;


            }

            return Rtno;
        }

        public static bool DatosRequeridosGrid(DataGridViewCell celda, string mensaje)
        {
            Boolean Rtno = true;
            if (((DataGridViewCell)celda).Value == null)
            {
                celda.ErrorText = mensaje;
                Rtno = false;
            }
            return Rtno;
        
        }
        public static bool DatosCorrectoGrid(DataGridViewCell celda, string mensaje,System.Type tipoDatos)
        {
            Boolean  Rtno = true;

            if (tipoDatos == typeof(DateTime) || tipoDatos == typeof(DateTime?))
            {
                DateTime? fecha = null;
                try
                {
                    fecha = Convert.ToDateTime(celda.Value);
                    if (fecha<DateTime.Parse("01/01/1753") || fecha>DateTime.Parse("31/12/9999"))                    
                        throw new Exception("El rango de la fecha no es correcto, debe estar comprendido entre 01/01/1753 y el 31/12/9999");
                        
                    
                    
                }
                catch (Exception)
                {
                    if (mensaje == string.Empty)
                        mensaje = "Error en la validación de los datos, se requiere un dato de tipo Fecha.";
                    celda.ErrorText = mensaje;
                    Rtno = false;
                }
            
            }
            return Rtno;
 
        }

        public static bool ControlDatosCorrectos(Control control, ErrorProvider proveedorErrores,  System.Type tipoDatos, Boolean Requerido)
        {
            return ControlDatosCorrectos(control, proveedorErrores, string.Empty, tipoDatos, Requerido);
        }        
        public static bool ControlDatosCorrectos(Control control,ErrorProvider proveedorErrores,string mensaje, System.Type tipoDatos,Boolean Requerido) {
            bool Rtno = true;
            
            if (Requerido && !ControlValorado(control))
            {
                if (mensaje==string.Empty)
                    mensaje = "El valor es requerido";
                Rtno=false;
            }
            else if (!Requerido && !ControlValorado(control))
            {               
                Rtno = true;
            }
            else
            {
                if (tipoDatos ==typeof(DateTime) || tipoDatos==typeof(DateTime?))
                {
                    if (control is TextBox )
                    {
                        DateTime? fecha = null;
                        try
                        {
                            fecha = Convert.ToDateTime(control.Text);
                            control.Text = ((DateTime)fecha).ToShortDateString();
                        }
                        catch (Exception)
                        {
                            if (mensaje == string.Empty)
                                mensaje = "Error en la validación de los datos, se requiere un dato de tipo Fecha.";
                            Rtno = false;
                        }
                    }
                    if ( control is MaskedTextBox)
                    {
                        
                      
                            DateTime? fecha = null;
                            try
                            {
                                if (!((MaskedTextBox)control).MaskCompleted)                                  
                                     throw new Exception();
                                  
                                fecha = Convert.ToDateTime(control.Text);
                                //control.Text = ((DateTime)fecha).ToShortDateString();
                            }
                            catch (Exception)
                            {
                                if (mensaje == string.Empty)
                                    mensaje = "Error en la validación de los datos, se requiere un dato de tipo Fecha.";
                                Rtno = false;
                            } 
                    }
                    if (control is ctlFecha)
                    {
                        if (!((ctlFecha)control).DatosCorrectos)
                        {
                            if (mensaje == string.Empty)
                                mensaje = "Error en la validación de los datos, se requiere un dato de tipo Fecha.";
                            Rtno = false;
                        }
                    }
                    
                }
                if (tipoDatos == typeof(decimal) || tipoDatos == typeof(decimal?))
                {

                    if (control is TextBox || control is MaskedTextBox)
                    {
                        Decimal? valor = null;

                        try
                        {
                            valor = Convert.ToDecimal(control.Text.Replace(".", ","));
                            //control.Text = ((DateTime)fecha).ToShortDateString();
                        }
                        catch (Exception)
                        {
                            if (mensaje == string.Empty)
                                mensaje = "Error en la validación de los datos, se requiere un dato de tipo Decimal.";
                            Rtno = false;
                        }

                    }
                }
                if (tipoDatos == typeof(Int16) || tipoDatos == typeof(Int16?))
                {
                    if (control is TextBox || control is MaskedTextBox)
                    {
                        Int16? valor = null;

                        try
                        {
                            valor = Convert.ToInt16(control.Text);
                        }
                        catch (Exception)
                        {
                            if (mensaje == string.Empty)
                                mensaje = "Error en la validación de los datos, se requiere un dato de tipo Numérico.";
                            Rtno = false;
                        }

                    }

                }
                if (tipoDatos == typeof(Int32) || tipoDatos == typeof(Int32?))
                {
                    if (control is TextBox || control is MaskedTextBox)
                    {
                        Int32? valor = null;

                        try
                        {
                            valor = Convert.ToInt32(control.Text);
                        }
                        catch (Exception)
                        {
                            if (mensaje == string.Empty)
                                mensaje = "Error en la validación de los datos, se requiere un dato de tipo Numérico.";
                            Rtno = false;
                        }

                    }

                }
                if (tipoDatos == typeof(Int64) || tipoDatos == typeof(Int64?))
                {
                    if (control is TextBox || control is MaskedTextBox)
                    {
                        Int64? valor = null;

                        try
                        {
                            valor = Convert.ToInt64(control.Text);
                        }
                        catch (Exception)
                        {
                            if (mensaje == string.Empty)
                                mensaje = "Error en la validación de los datos, se requiere un dato de tipo Numérico.";
                            Rtno = false;
                        }

                    }
                }

                //////switch (tipoDatos.ToString())
                //////{

                //////    case "System.DateTime":
                        
                //////        if (control is TextBox)
                //////        {
                //////            DateTime? fecha = null;
                //////            try
                //////            {
                //////                fecha = Convert.ToDateTime(control.Text);
                //////                //control.Text = ((DateTime)fecha).ToShortDateString();
                //////            }
                //////            catch (Exception)
                //////            {
                //////                if (mensaje == string.Empty)
                //////                    mensaje = "Error en la validación de los datos, se requiere un dato de tipo Fecha."; 
                //////                Rtno = false;
                //////            }
                //////        }
                //////        break;

                //////    case "System.Decimal":

                //////        if (control is TextBox)
                //////        {
                //////            Decimal? valor = null;
                            
                //////            try
                //////            {
                //////                valor = Convert.ToDecimal(control.Text.Replace(".",","));
                //////                //control.Text = ((DateTime)fecha).ToShortDateString();
                //////            }
                //////            catch (Exception)
                //////            {
                //////                if (mensaje == string.Empty)
                //////                    mensaje = "Error en la validación de los datos, se requiere un dato de tipo Decimal.";
                //////                Rtno = false;
                //////            }

                //////        }
                //////        break;
                //////    case "System.Int32":
                //////        if (control is TextBox)
                //////        {
                //////            Int32? valor = null;

                //////            try
                //////            {
                //////                valor = Convert.ToInt32(control.Text);                                
                //////            }
                //////            catch (Exception)
                //////            {
                //////                if (mensaje == string.Empty)
                //////                    mensaje = "Error en la validación de los datos, se requiere un dato de tipo Numérico.";
                //////                Rtno = false;
                //////            }

                //////        }

                //////        break;
                //////        case "System.Int16":
                //////        if (control is TextBox)
                //////        {
                //////            Int16? valor = null;

                //////            try
                //////            {
                //////                valor = Convert.ToInt16(control.Text);                                
                //////            }
                //////            catch (Exception)
                //////            {
                //////                if (mensaje == string.Empty)
                //////                    mensaje = "Error en la validación de los datos, se requiere un dato de tipo Numérico.";
                //////                Rtno = false;
                //////            }

                //////        }

                //////        break;
                //////             case "System.Int64":
                //////        if (control is TextBox)
                //////        {
                //////            Int64? valor = null;

                //////            try
                //////            {
                //////                valor = Convert.ToInt64(control.Text);                                
                //////            }
                //////            catch (Exception)
                //////            {
                //////                if (mensaje == string.Empty)
                //////                    mensaje = "Error en la validación de los datos, se requiere un dato de tipo Numérico.";
                //////                Rtno = false;
                //////            }

                //////        }

                //////        break;


                //////}

            }
           



            if (!Rtno)            
                PonerError(proveedorErrores, control, mensaje);
            
           
            
            
            return Rtno;
        }

        public static bool ControlLongitudCorrecta(Control control, ErrorProvider proveedorErrores, string mensaje, object objeto, string nombrePropiedad)
        {
            bool Rtno = true;
            //control, ProveedorErrores, objeto.GetType().GetProperty(nombrePropiedad).PropertyType
            Type TipoDatos=objeto.GetType().GetProperty(nombrePropiedad).PropertyType;


            System.Data.Linq.Mapping.ColumnAttribute AtributosLINQ = null;
            try//Obtengo los atributos linq para esta propiedad fundamentalmente para obtener el campo DbType
            {
                AtributosLINQ = ((System.Data.Linq.Mapping.ColumnAttribute)objeto.GetType().GetProperty(nombrePropiedad).GetCustomAttributes(false)[0]);
            }
            catch (Exception ex)
            { Traza.RegistrarError(ex); }

            
            if (AtributosLINQ!=null)
            {
                if (TipoDatos == typeof(decimal) || TipoDatos == typeof(decimal?))
                {
                    //int? maxlenth = 1;
                    int? total_cifras = null;
                    int? parte_decimal = null;
                    int parte_entera = 0;
                    string expreg = @"\((?<total_cifras>\d*)\,(?<parte_decimal>\d*)\)";

                    Regex r = new Regex(expreg);
                    try
                    {
                        Match resultado = r.Match(AtributosLINQ.DbType);
                        if (resultado != null && resultado.Success)
                        {
                            total_cifras = int.Parse(resultado.Groups["total_cifras"].Value);
                            parte_decimal = int.Parse(resultado.Groups["parte_decimal"].Value);
                            parte_entera = (total_cifras ?? 0) - (parte_decimal ?? 0);
                        }
                    }
                    catch (Exception) { }

                    if (control is TextBox || control is MaskedTextBox)
                    {
                        if (!string.IsNullOrEmpty(control.Text))
                        {                              
                            Decimal? valor = null;
                            try
                            {
                                valor = Convert.ToDecimal(control.Text.Replace(".", ","));

                                ///Si el tamaño de la parte entera es superior al tamaño soportado por la bd 
                                ///Lanzamos una excepción
                                if (Math.Truncate(valor.Value).ToString().Length > parte_entera)
                                    throw new Exception();

                            }
                            catch (Exception)
                            {
                                if (string.IsNullOrEmpty(mensaje))
                                    mensaje = "Error en la longitud de los datos, la parte entera del decimal requerido no puede tener más de (" + parte_entera + ") cifras.";
                                Rtno = false;
                            }
                        }
                      
                    }
                }
            }
            if (!Rtno)                
                PonerError(proveedorErrores, control, mensaje);
            
            return Rtno;
        }
        


        //internal static DateTime ControlADatetime(ref TextBox txtFecha)
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// Establece el error en un control a través de un proveedor de errores que toma por parámetro.
        /// Comprueba si el control que contiene el error pertenece a un formulario del tipo GenericMaestro o GenericEdit, 
        /// de ser así agrega el control a la lista lstControlesConErrores característica de este tipo de formularios.
        /// </summary>
        /// <param name="proveedorErrores"></param>
        /// <param name="control"></param>
        /// <param name="mensajeError"></param>
        public static void PonerError(ErrorProvider proveedorErrores, Control control, string mensajeError)
        {
            proveedorErrores.SetError(control, mensajeError);
            if (proveedorErrores.ContainerControl.GetType().BaseType.BaseType == typeof(GenericMaestro) || proveedorErrores.ContainerControl.GetType().BaseType.BaseType==typeof(GenericEdit))
                ((GenericMaestro)proveedorErrores.ContainerControl).lstControlesConErrores.Add(control);
        }
        
        public struct Valores_ChrStr
        {
            char _codigo;
            string _descripcion;


            public Valores_ChrStr(char codigo, string descripcion)
            {
                _codigo = codigo;
                _descripcion = descripcion;
            }

            public char Codigo
            {
                get { return _codigo; }
                set { _codigo = value; }
            }
           

            public string Descripcion
            {
                get { return _descripcion; }
                set { _descripcion = value; }
            }

            
        
        }
        public struct Valores_BolStr
        {
            bool _codigo;
            string _descripcion;


            public Valores_BolStr(bool codigo, string descripcion)
            {
                _codigo = codigo;
                _descripcion = descripcion;
            }

            public bool Codigo
            {
                get { return _codigo; }
                set { _codigo = value; }
            }


            public string Descripcion
            {
                get { return _descripcion; }
                set { _descripcion = value; }
            }



        }
                    

        #region CARGA DE COMBOS COMUNES

            public static void CargarComboSexos(System.Windows.Forms.ComboBox cmbSexo)
            {
                //Dictionary<char, string> lstSexo = new Dictionary<char, string>();
                //lstSexo.Add(char.Parse("H"), "HEMBRA");
                //lstSexo.Add(char.Parse("M"), "MACHO");
                List<Valores_ChrStr> lstSexo = new List<Valores_ChrStr>();
                lstSexo.Add(new Valores_ChrStr(Convert.ToChar("H"), "HEMBRA"));
                lstSexo.Add(new Valores_ChrStr(Convert.ToChar("M"), "MACHO"));

                //cmbSexo.DisplayMember = "Value";
                //cmbSexo.ValueMember = "Key";
                cmbSexo.DataSource = lstSexo;
                cmbSexo.DisplayMember = "Descripcion";
                cmbSexo.ValueMember = "Codigo";
                cmbSexo.SelectedIndex = -1;


            }
            public static void CargarComboSiNo(System.Windows.Forms.ComboBox cmbSiNo)
            {
                List<Valores_BolStr> lstSiNo = new List<Valores_BolStr>();
                lstSiNo.Add(new Valores_BolStr(true, "SÍ"));
                lstSiNo.Add(new Valores_BolStr(false, "NO"));

                cmbSiNo.DataSource = lstSiNo;
                cmbSiNo.DisplayMember = "Descripcion";
                cmbSiNo.ValueMember = "Codigo";
                cmbSiNo.SelectedIndex = -1;


            }

        #endregion

        /// <summary>
        /// Ejecuta los procesos adecuados de cada formulario.
        /// Los procesos son propiedades que cambian la apariencia y funcionamiento del formulario
        /// son utilizados normalmente para establecer el contenido del formulario, en funcion del la 
        /// informacion de los módulos cargados.
        /// </summary>
        public static void EjecutarProcesos(Control formulario)
        {
            try
            {
               
                    List<PropertyInfo> lstpropiedades_Proceso = new List<PropertyInfo>();//Creamos una lista generica de informacion de propiedades
                    foreach (PropertyInfo item in formulario.GetType().GetProperties())
                    {//Cargamos la lista de informacion de propiedades con las propiedades del tipo proceso (Se identifican por el prefijo "_proceso_"
                        if (item.Name.Contains("_proceso_"))
                            lstpropiedades_Proceso.Add(item);
                    }

                    foreach (PropertyInfo item in lstpropiedades_Proceso)//Recorremos las propiedades del tipo proceso del formulario.
                    {
                        try
                        {   ///Asignamos TRUE a la propiedad en los siguientes casos.
                            ///- Si no tenemos configurados procesos.
                            ///- Si tenemos activado el proceso en cuentión.
                            if (Configuracion.Explotacion.lstProcesosPermitidos == null || Configuracion.Explotacion.lstProcesosPermitidos.Count == 0 || Configuracion.Explotacion.lstProcesosPermitidos.ContainsKey(formulario.Name + "." + item.Name.Replace("_proceso_", string.Empty)))
                                item.SetValue(formulario, true, null);
                            else//Asignamos FALSE cuando existen procesos configurados y el proceso a tratar no se encuentra activado.
                                item.SetValue(formulario, false, null);
                        }
                        catch (Exception ex){Traza.RegistrarError(ex);}
                    }
              

            }
            catch (Exception) { }


        }

        /// <summary>
        /// Cambia la localización del formulario secundario para centrarlo dentro del primario.
        /// </summary>
        /// <param name="principal"></param>
        /// <param name="secundario"></param>
        public static void CentrarFormulario(Form principal, Form secundario) 
        {
            if (principal!=null && secundario !=null)
            {
                if (secundario.Width<principal.Width && secundario.Height<principal.Height)
                {
                    secundario.StartPosition = FormStartPosition.Manual;
                    secundario.Left = principal.Left + ((principal.Width - secundario.Width) / 2);
                    secundario.Top = principal.Top + ((principal.Height - secundario.Height) / 2);
                }                
            }
        
        }

        
        public static void EstablecerParametro(CrystalDecisions.CrystalReports.Engine.ReportDocument rpte, CrystalDecisions.Shared.IParameterField parametro,object valor) 
        {
            if (rpte==null)            
                throw new ArgumentException("Debe especificar un ReportDocument Válido.","rpte");
            if (parametro==null)
                throw new ArgumentException("Debe especificar un IParameterField Válido.", "parametro");	

            if (parametro.ReportName!=string.Empty)            
                rpte.SetParameterValue(parametro.ParameterFieldName, valor, parametro.ReportName);
            else
                rpte.SetParameterValue(parametro.ParameterFieldName, valor);
        }

        public static void OcultarControl(Control control)
        {
            ManipularControl(control, false);
        }
        public static void MostrarControl(Control control)
        {
            ManipularControl(control, true);
        }
        public static void ManipularControl(Control control,bool estado)
        {
            control.Visible = estado;
            control.Enabled = estado;
        }

        /// <summary>
        /// Desactiva un control de topo CheckBox
        /// Se utiliza sobre todo en el crlInforme para desactivar opciones según modulos instalados.
        /// </summary>
        /// <param name="control"></param>
        public static void DesactivarControl(CheckBox control)
        {
            if (control != null)
            {
                control.Enabled = false;
                control.Checked = false;
            }
        }
    }
}

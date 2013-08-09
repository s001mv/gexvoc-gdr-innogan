using System;
using System.Net;
using System.Threading;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GEXVOC.UI.Clases
{
    /// <summary>
    /// Realiza la validación de datos.
    /// </summary>
    public static class Validacion
    {
        /// <summary>
        /// Método de validación de datos obligatorios sin validación específica.
        /// </summary>
        /// <param name="cadena">Cadena a comprobar.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsVacio(string cadena)
        {
            return cadena == String.Empty;
        }

        /// <summary>
        /// Método de validación de campos obligatorios sin validación específica.
        /// </summary>
        /// <param name="campo">Campo/s a comprobar.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsVacio(params TextBox[] campos)
        {
            bool result = false;

            foreach (TextBox campo in campos)
            {
                if (campo.Text == String.Empty)
                {
                    result = true;

                    
                    Generic.Aviso("Faltan datos requeridos por cubrir.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    if (campo.Enabled && campo.Visible)
                        campo.Focus();

                    break;
                }
                else
                    result = false;
            }

            return result;
        }

        /// <summary>
        /// Método de validación de campos obligatorios sin validación específica.
        /// </summary>
        /// <param name="campo">Campo/s a comprobar.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsVacio(params ComboBox[] campos)
        {
            bool result = false;

            foreach (ComboBox campo in campos)
            {
                if (campo.SelectedValue == null || (int)campo.SelectedValue == 0)
                {
                    result = true;

                    
                    Generic.Aviso("Faltan datos requeridos por cubrir.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    if (campo.Enabled && campo.Visible)
                        campo.Focus();

                    break;
                }
                else
                    result = false;
            }

            return result;
        }

        /// <summary>
        /// Método de validación de direcciones de correo electrónico.
        /// </summary>
        /// <param name="correo">Dirección a comprobar.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsEmail(string correo)
        {
            string mail = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            return Regex.IsMatch(correo, mail);
        }

        /// <summary>
        /// Método de validación de campos de direcciones de correo electrónico.
        /// </summary>
        /// <param name="campo">Campo/s a comprobar.</param>
        /// <param name="requerido">Especifica si el dato es obligatorio.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsEmail(TextBox campo, bool requerido)
        {
            string mail = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            bool result = true;

            if (requerido)
            {
                if (EsVacio(campo.Text))
                {
                    result = false;

                    
                    Generic.Aviso("Debe introducir el E-Mail.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    if (campo.Enabled && campo.Visible)
                        campo.Focus();
                }
                else if (!Regex.IsMatch(campo.Text, mail))
                {
                    result = false;

                    
                    Generic.Aviso("Formato de E-Mail incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    if (campo.Enabled && campo.Visible)
                    {
                        campo.Focus();
                        campo.SelectAll();
                    }
                }
            }
            else if (!EsVacio(campo.Text) && !Regex.IsMatch(campo.Text, mail))
            {
                result = false;

                
                Generic.Aviso("Formato de E-Mail incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                if (campo.Enabled && campo.Visible)
                {
                    campo.Focus();
                    campo.SelectAll();
                }
            }

            return result;
        }
        public static bool EsEmail(TextBox campo, bool requerido,ErrorProvider proveedorErrores)
        {
            string mail = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            bool result = true;

            if (requerido)
            {
                if (EsVacio(campo.Text))
                {
                    result = false;
                    Generic.PonerError(proveedorErrores, campo, "Debe introducir el E-Mail.");
                    
                  
                }
                else if (!Regex.IsMatch(campo.Text, mail))
                {
                    result = false;

                    Generic.PonerError(proveedorErrores, campo, "Formato de E-Mail incorrecto.");                   
                  
                }
            }
            else if (!EsVacio(campo.Text) && !Regex.IsMatch(campo.Text, mail))
            {
                result = false;
                Generic.PonerError(proveedorErrores, campo, "Formato de E-Mail incorrecto.");  
             
              
            }

            return result;
        }

        /// <summary>
        /// Método de validación de número de tarjetas de crédito.
        /// </summary>
        /// <param name="tarjetaCredito">Número de tarjeta a comprobar.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsTarjetaCredito(string tarjetaCredito)
        {
            string creditcard = @"^((67\d{2})|(4\d{3})|(5[1-5]\d{2})|(6011))(-?\s?\d{4}){3}|(3[4,7])\ d{2}-?\s?\d{6}-?\s?\d{5}$";

            return Regex.IsMatch(tarjetaCredito, creditcard);
        }

        /// <summary>
        /// Método de validación de campos de números de tarjetas de crédito.
        /// </summary>
        /// <param name="campo">Campo a comprobar.</param>
        /// <param name="requerido">Especifica si el dato es obligatorio.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsTarjetaCredito(TextBox campo, bool requerido)
        {
            string creditcard = @"^((67\d{2})|(4\d{3})|(5[1-5]\d{2})|(6011))(-?\s?\d{4}){3}|(3[4,7])\ d{2}-?\s?\d{6}-?\s?\d{5}$";
            bool result = true;

            if (requerido)
            {
                if (EsVacio(campo.Text))
                {
                    result = false;


                  
                    Generic.Aviso("Debe introducir la tarjeta de crédito.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  
                    if (campo.Enabled && campo.Visible)
                        campo.Focus();
                }
                else if (!Regex.IsMatch(campo.Text, creditcard))
                {
                    result = false;


                    
                    Generic.Aviso("Formato de tarjeta de crédito incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    if (campo.Enabled && campo.Visible)
                    {
                        campo.Focus();
                        campo.SelectAll();
                    }
                }
            }
            else if (!EsVacio(campo.Text) && !Regex.IsMatch(campo.Text, creditcard))
            {
                result = false;


                
                Generic.Aviso("Formato de tarjeta de crédito incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                if (campo.Enabled && campo.Visible)
                {
                    campo.Focus();
                    campo.SelectAll();
                }
            }

            return result;
        }

        /// <summary>
        /// Método de validación de teléfonos.
        /// </summary>
        /// <param name="telefono">Teléfono a comprobar.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsTelefono(string telefono)
        {
            string telephone = @"^[0-9]{2,3}-? ?[0-9]{6,7}$";

            return Regex.IsMatch(telefono, telephone);
        }

        /// <summary>
        /// Método de validación de campos de teléfonos.
        /// </summary>
        /// <param name="campo">Campo a comprobar.</param>
        /// <param name="requerido">Especifica si el dato es obligatorio.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsTelefono(TextBox campo, bool requerido)
        {
            string telephone = @"^[0-9]{2,3}-? ?[0-9]{6,7}$";
            bool result = true;

            if (requerido)
            {
                if (EsVacio(campo.Text))
                {
                    result = false;


                    
                    Generic.Aviso("Debe introducir el teléfono.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    if (campo.Enabled && campo.Visible)
                        campo.Focus();
                }
                else if (!Regex.IsMatch(campo.Text, telephone))
                {
                    result = false;


                    
                    Generic.Aviso("Formato de teléfono incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    if (campo.Enabled && campo.Visible)
                    {
                        campo.Focus();
                        campo.SelectAll();
                    }
                }
            }
            else if (!EsVacio(campo.Text) && !Regex.IsMatch(campo.Text, telephone))
            {
                result = false;


                
                Generic.Aviso("Formato de teléfono incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                if (campo.Enabled && campo.Visible)
                {
                    campo.Focus();
                    campo.SelectAll();
                }
            }

            return result;
        }
        public static bool EsTelefono(Control control, bool requerido,ErrorProvider proveedorErrores)
        {
            bool result = true;
            string telephone = @"^[0-9]{2,3}-? ?[0-9]{6,7}$";

            if (control is TextBox)
            {
                if (requerido)
                {
                    if (EsVacio(control.Text))
                    {
                        result = false;
                        Generic.PonerError(proveedorErrores, control, "Debe introducir el teléfono.");

                    }
                    else if (!Regex.IsMatch(control.Text, telephone))
                    {
                        result = false;
                        Generic.PonerError(proveedorErrores, control, "Formato de teléfono incorrecto.");
                    }
                }
                else if (!EsVacio(control.Text) && !Regex.IsMatch(control.Text, telephone))
                {
                    result = false;
                    Generic.PonerError(proveedorErrores, control, "Formato de teléfono incorrecto.");
                }
            }
            // else if(control is ****)//AQUI VIENEN LAS COMPARACIONES ESPECIFICAS PARA CADA UNO DE LOS CONTROLES
            else//el control no se corresponde con ninguno de los 
            {
                result = false;
                Generic.PonerError(proveedorErrores, control, "No se han especificado acciones para este control.");
            }
            return result;
        }

        /// <summary>
        /// Método de validación de códigos postales.
        /// </summary>
        /// <param name="codigoPostal">Código postal a comprobar.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsCodigoPostal(string codigoPostal)
        {
            string zipcode = @"^([1-9]{2}|[0-9][1-9]|[1-9][0-9])[0-9]{3}$";

            return Regex.IsMatch(codigoPostal, zipcode);
        }

        /// <summary>
        /// Método de validación de campos de códigos postales.
        /// </summary>
        /// <param name="campo">Campo a comprobar.</param>
        /// <param name="requerido">Especifica si el dato es obligatorio.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsCodigoPostal(TextBox campo, bool requerido)
        {
            string zipcode = @"^([1-9]{2}|[0-9][1-9]|[1-9][0-9])[0-9]{3}$";
            bool result = true;

            if (requerido)
            {
                if (EsVacio(campo.Text))
                {
                    result = false;

                    
                    Generic.Aviso("Debe introducir el código postal.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    if (campo.Enabled && campo.Visible)
                        campo.Focus();
                }
                else if (!Regex.IsMatch(campo.Text, zipcode))
                {
                    result = false;

                    
                    Generic.Aviso("Formato de código postal incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    if (campo.Enabled && campo.Visible)
                    {
                        campo.Focus();
                        campo.SelectAll();
                    }
                }
            }
            else if (!EsVacio(campo.Text) && !Regex.IsMatch(campo.Text, zipcode))
            {
                result = false;

                
                Generic.Aviso("Formato de código postal incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                if (campo.Enabled && campo.Visible)
                {
                    campo.Focus();
                    campo.SelectAll();
                }
            }

            return result;
        }
        public static bool EsCodigoPostal(TextBox campo, bool requerido,ErrorProvider proveedorErrores)
        {
            string zipcode = @"^([1-9]{2}|[0-9][1-9]|[1-9][0-9])[0-9]{3}$";
            bool result = true;

            if (requerido)
            {
                if (EsVacio(campo.Text))
                {
                    result = false;
                    Generic.PonerError(proveedorErrores, campo, "Debe introducir el código postal."); 
                    
                 
                }
                else if (!Regex.IsMatch(campo.Text, zipcode))
                {
                    result = false;
                    Generic.PonerError(proveedorErrores, campo, "Formato de código postal incorrecto.");                     
                  
                }
            }
            else if (!EsVacio(campo.Text) && !Regex.IsMatch(campo.Text, zipcode))
            {
                result = false;

                Generic.PonerError(proveedorErrores, campo, "Formato de código postal incorrecto.");  
              
            }

            return result;
        }

        /// <summary>
        /// Método de validación de fechas.
        /// </summary>
        /// <param name="fecha">Fecha a comprobar.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsFecha(Object fecha)
        {
            string date = @"^\d{1,2}\/\d{1,2}\/\d{2,4}$";
            bool result = true;

            if (fecha != null)
                try
                {
                    if (!Regex.IsMatch(fecha.ToString(), date))
                        result = false;
                    else
                    {
                        DateTime dt = DateTime.Parse(fecha.ToString());
                    }
                }
                catch
                {
                    result = false;
                }
            else
                result = false;

            return result;
        }

        /// <summary>
        /// Método de validación de fechas y formateo de campo si fuera necesario.
        /// </summary>
        /// <param name="campo">Campo a comprobar.</param>
        /// <returns>Validez del campo.</returns>
        public static bool EsFecha(ref TextBox campo)
        {
            string date = @"^\d{1,2}\/\d{1,2}\/\d{2,4}$";
            bool result = true;

            if (campo.Text.IndexOf('/') == -1)
                campo.Text = Generic.FormatearFecha(campo.Text);

            try
            {
                if (!Regex.IsMatch(campo.Text, date))
                    result = false;
                else
                {
                    DateTime dt = DateTime.Parse(campo.Text);
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Método de validación de campos de fechas.
        /// </summary>
        /// <param name="campo">Campo a comprobar.</param>
        /// <param name="requerido">Especifica si el dato es obligatorio.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsFecha(TextBox campo, bool requerido)
        {
            string date = @"^\d{1,2}\/\d{1,2}\/\d{2,4}$";
            bool result = true;

            if (campo.Text.IndexOf('/') == -1)
                campo.Text = Generic.FormatearFecha(campo.Text);

            if (requerido)
            {
                if (EsVacio(campo.Text))
                {
                    result = false;

                    
                    Generic.Aviso("Debe introducir la fecha.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    if (campo.Enabled && campo.Visible)
                        campo.Focus();
                }
                else if (!Regex.IsMatch(campo.Text, date))
                {
                    result = false;

                    
                    Generic.Aviso("Formato de fecha incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    if (campo.Enabled && campo.Visible)
                    {
                        campo.Focus();
                        campo.SelectAll();
                    }
                }
                else
                {
                    try
                    {
                        DateTime dt = DateTime.Parse(campo.Text);
                    }
                    catch
                    {
                        result = false;

                        
                        Generic.Aviso("Formato de fecha incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                        if (campo.Enabled && campo.Visible)
                        {
                            campo.Focus();
                            campo.SelectAll();
                        }
                    }
                }
            }
            else if (!EsVacio(campo.Text) && !Regex.IsMatch(campo.Text, date))
            {
                result = false;

                
                Generic.Aviso("Formato de fecha incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              
                if (campo.Enabled && campo.Visible)
                {
                    campo.Focus();
                    campo.SelectAll();
                }
            }
            else if(Regex.IsMatch(campo.Text, date))
            {
                try
                {
                    DateTime dt = DateTime.Parse(campo.Text);
                }
                catch
                {
                    result = false;

                    
                    Generic.Aviso("Formato de fecha incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    if (campo.Enabled && campo.Visible)
                    {
                        campo.Focus();
                        campo.SelectAll();
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Método de validación de números enteros positivos.
        /// </summary>
        /// <param name="numero">Número a validar.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsEnteroPositivo(string numero)
        {
            string number = "[^0-9]";

            return !Regex.IsMatch(numero, number);
        }
        public static bool EsEnteroPositivo(Object numero)
        {
            string number = "[^0-9]";
            bool result = true;
            if (numero != null)
            {
                result= !Regex.IsMatch(numero.ToString(), number);
            }
            return result;
        
        }
        /// <summary>
        /// Método de validación de campos de enteros positivos.
        /// </summary>
        /// <param name="campo">Campo a comprobar.</param>
        /// <param name="requerido">Especifica si el dato es obligatorio.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsEnteroPositivo(TextBox campo, bool requerido)
        {
            string number = "[^0-9]";
            bool result = true;

            if (requerido)
            {
                if (EsVacio(campo.Text))
                {
                    result = false;

                   
                    Generic.Aviso("Debe introducir el dato.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   
                    if (campo.Enabled && campo.Visible)
                        campo.Focus();
                }
                else if (Regex.IsMatch(campo.Text, number))
                {
                    result = false;

                    
                    Generic.Aviso("Dato incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    if (campo.Enabled && campo.Visible)
                    {
                        campo.Focus();
                        campo.SelectAll();
                    }
                }
            }
            else if (!EsVacio(campo.Text) && Regex.IsMatch(campo.Text, number))
            {
                result = false;

                
                Generic.Aviso("Dato incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                if (campo.Enabled && campo.Visible)
                {
                    campo.Focus();
                    campo.SelectAll();
                }
            }

            return result;
        }

        /// <summary>
        /// Método de validación de números enteros positivos y negativos.
        /// </summary>
        /// <param name="numero">Número a validar.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsEntero(string numero)
        {
            Regex objNotIntPattern = new Regex("[^0-9-]");
            Regex objIntPattern = new Regex("^-[0-9]+$|^[0-9]+$");

            return !objNotIntPattern.IsMatch(numero) && objIntPattern.IsMatch(numero);
        }

        /// <summary>
        /// Método de validación de campos de enteros.
        /// </summary>
        /// <param name="campo">Campo a comprobar.</param>
        /// <param name="requerido">Especifica si el dato es obligatorio.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsEntero(TextBox campo, bool requerido)
        {
            Regex objNotIntPattern = new Regex("[^0-9-]");
            Regex objIntPattern = new Regex("^-[0-9]+$|^[0-9]+$");

            bool result = true;

            if (requerido)
            {
                if (EsVacio(campo.Text))
                {
                    result = false;

                    
                    Generic.Aviso("Debe introducir el dato.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    if (campo.Enabled && campo.Visible)
                        campo.Focus();
                }
                else if (objNotIntPattern.IsMatch(campo.Text) || !objIntPattern.IsMatch(campo.Text))
                {
                    result = false;

                    
                    Generic.Aviso("Dato incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    if (campo.Enabled && campo.Visible)
                    {
                        campo.Focus();
                        campo.SelectAll();
                    }
                }
            }
            else if (!EsVacio(campo.Text) && (objNotIntPattern.IsMatch(campo.Text) || !objIntPattern.IsMatch(campo.Text)))
            {
                result = false;

                
                Generic.Aviso("Dato incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                if (campo.Enabled && campo.Visible)
                {
                    campo.Focus();
                    campo.SelectAll();
                }
            }

            return result;
        }

        /// <summary>
        /// Método de validación para establecer si una cadena es un número válido.
        /// </summary>
        /// <param name="numero">Número a validar.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsNumero(string numero)
        {
            Regex objNotNumberPattern = new Regex("[^0-9,-]");
            Regex objTwoDotPattern = new Regex("[0-9]*[,][0-9]*[,][0-9]*");
            Regex objTwoMinusPattern = new Regex("[0-9]*[-][0-9]*[-][0-9]*");
            String strValidRealPattern = "^([-]|[,]|[-,]|[0-9])[0-9]*[,]*[0-9]+$";
            String strValidIntegerPattern = "^([-]|[0-9])[0-9]*$";
            Regex objNumberPattern = new Regex("(" + strValidRealPattern + ")|(" + strValidIntegerPattern + ")");

            if (numero.IndexOf('.') != -1 && '.' != Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0])
                numero = numero.Replace('.', Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0]);
            else if (numero.IndexOf(',') != -1 && ',' != Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0])
                numero = numero.Replace(',', Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0]);

            return !objNotNumberPattern.IsMatch(numero) &&
                !objTwoDotPattern.IsMatch(numero) &&
                !objTwoMinusPattern.IsMatch(numero) &&
                objNumberPattern.IsMatch(numero);
        }

        /// <summary>
        /// Método de validación para establecer si un campo es un número válido.
        /// </summary>
        /// <param name="campo">Campo a validar.</param>
        /// <returns>Validez del campo.</returns>
        public static bool EsNumero(ref TextBox campo)
        {
            Regex objNotNumberPattern = new Regex("[^0-9,-]");
            Regex objTwoDotPattern = new Regex("[0-9]*[,][0-9]*[,][0-9]*");
            Regex objTwoMinusPattern = new Regex("[0-9]*[-][0-9]*[-][0-9]*");
            String strValidRealPattern = "^([-]|[,]|[-,]|[0-9])[0-9]*[,]*[0-9]+$";
            String strValidIntegerPattern = "^([-]|[0-9])[0-9]*$";
            Regex objNumberPattern = new Regex("(" + strValidRealPattern + ")|(" + strValidIntegerPattern + ")");

            if (campo.Text.IndexOf('.') != -1 && '.' != Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0])
                campo.Text = campo.Text.Replace('.', Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0]);
            else if (campo.Text.IndexOf(',') != -1 && ',' != Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0])
                campo.Text = campo.Text.Replace(',', Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0]);

            return !objNotNumberPattern.IsMatch(campo.Text) &&
                !objTwoDotPattern.IsMatch(campo.Text) &&
                !objTwoMinusPattern.IsMatch(campo.Text) &&
                objNumberPattern.IsMatch(campo.Text);
        }

        /// <summary>
        /// Método de validación de campos numéricos.
        /// </summary>
        /// <param name="campo">Campo a comprobar.</param>
        /// <param name="requerido">Especifica si el dato es obligatorio.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsNumero(TextBox campo, bool requerido)
        {
            Regex objNotNumberPattern = new Regex("[^0-9,-]");
            Regex objTwoDotPattern = new Regex("[0-9]*[,][0-9]*[,][0-9]*");
            Regex objTwoMinusPattern = new Regex("[0-9]*[-][0-9]*[-][0-9]*");
            String strValidRealPattern = "^([-]|[,]|[-,]|[0-9])[0-9]*[,]*[0-9]+$";
            String strValidIntegerPattern = "^([-]|[0-9])[0-9]*$";
            Regex objNumberPattern = new Regex("(" + strValidRealPattern + ")|(" + strValidIntegerPattern + ")");

            bool result = true;

            if (campo.Text.IndexOf('.') != -1 && '.' != Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0])
                campo.Text = campo.Text.Replace('.', Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0]);
            else if (campo.Text.IndexOf(',') != -1 && ',' != Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0])
                campo.Text = campo.Text.Replace(',', Thread.CurrentThread.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0]);

            if (requerido)
            {
                if (EsVacio(campo.Text))
                {
                    result = false;

                   
                    Generic.Aviso("Debe introducir el dato.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   
                    if (campo.Enabled && campo.Visible)
                        campo.Focus();
                }
                else if (objNotNumberPattern.IsMatch(campo.Text) || objTwoDotPattern.IsMatch(campo.Text) ||
                    objTwoMinusPattern.IsMatch(campo.Text) || !objNumberPattern.IsMatch(campo.Text))
                {
                    result = false;

                    
                    Generic.Aviso("Dato incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    if (campo.Enabled && campo.Visible)
                    {
                        campo.Focus();
                        campo.SelectAll();
                    }
                }
            }
            else if (!EsVacio(campo.Text) && (objNotNumberPattern.IsMatch(campo.Text) || objTwoDotPattern.IsMatch(campo.Text) ||
                objTwoMinusPattern.IsMatch(campo.Text) || !objNumberPattern.IsMatch(campo.Text)))
            {
                result = false;

                
                Generic.Aviso("Dato incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                if (campo.Enabled && campo.Visible)
                {
                    campo.Focus();
                    campo.SelectAll();
                }
            }

            return result;
        }

        /// <summary>
        /// Método de validación de números.
        /// </summary>
        /// <param name="numero">Número a comprobar.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsNumero(Object numero)
        {
            Regex objNotNumberPattern = new Regex("[^0-9,-]");
            Regex objTwoDotPattern = new Regex("[0-9]*[,][0-9]*[,][0-9]*");
            Regex objTwoMinusPattern = new Regex("[0-9]*[-][0-9]*[-][0-9]*");
            String strValidRealPattern = "^([-]|[,]|[-,]|[0-9])[0-9]*[,]*[0-9]+$";
            String strValidIntegerPattern = "^([-]|[0-9])[0-9]*$";
            Regex objNumberPattern = new Regex("(" + strValidRealPattern + ")|(" + strValidIntegerPattern + ")");

            bool result = true;

            if (numero != null)
            {
                result = !objNotNumberPattern.IsMatch(numero.ToString()) &&
                    !objTwoDotPattern.IsMatch(numero.ToString()) &&
                    !objTwoMinusPattern.IsMatch(numero.ToString()) &&
                    objNumberPattern.IsMatch(numero.ToString());
            }
            else
                result = false;

            return result;
        }

        /// <summary>
        /// Método de validación para campo alfabético.
        /// </summary>
        /// <param name="texto">Texto a validar.</param>
        /// <returns>Validex del dato.</returns>
        public static bool EsCodigo(string texto, int longitud)
        {
            string number = "[^0-9]";

            return texto.Length == longitud && !Regex.IsMatch(texto, number);
        }

        /// <summary>
        /// Método de validación de campos de códigos.
        /// </summary>
        /// <param name="campo">Campo a comprobar.</param>
        /// <param name="longitud">Especifica la longitud de código.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsCodigo(TextBox campo, int longitud)
        {
            return EsCodigo(campo, longitud, false);
        }
        public static bool EsCodigo(TextBox campo, int longitud,ErrorProvider proveedorErrores)
        {
            return EsCodigo(campo, longitud, false, proveedorErrores);
        }

        /// <summary>
        /// Método de validación de campos de códigos.
        /// </summary>
        /// <param name="campo">Campo a comprobar.</param>
        /// <param name="longitud">Especifica la longitud de código.</param>
        /// <returns>Validez del dato.</returns>
        public static bool EsCodigo(TextBox campo, int longitud, bool requerido)
        {
            string number = "[^0-9]";
            bool result = true;

            if (EsVacio(campo.Text))
            {
                if (requerido)
                {
                    result = false;

                    
                    Generic.Aviso("Debe introducir el dato.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    if (campo.Enabled && campo.Visible)
                        campo.Focus();
                }
            }
            else if (campo.Text.Length != longitud || Regex.IsMatch(campo.Text, number))
            {
                result = false;

                
                Generic.Aviso("Dato incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                if (campo.Enabled && campo.Visible)
                {
                    campo.Focus();
                    campo.SelectAll();
                }
            }

            return result;
        }
        public static bool EsCodigo(TextBox campo, int longitud, bool requerido,ErrorProvider proveedorErrores)
        {
            string number = "[^0-9]";
            bool result = true;

            if (EsVacio(campo.Text))
            {
                if (requerido)
                {
                    result = false;


                    Generic.PonerError(proveedorErrores,campo,"Debe introducir el dato.");

                    if (campo.Enabled && campo.Visible)
                        campo.Focus();
                }
            }
            else if (campo.Text.Length != longitud || Regex.IsMatch(campo.Text, number))
            {
                result = false;

                Generic.PonerError(proveedorErrores, campo, "Dato incorrecto el dato debe ser un código de " + longitud.ToString() + " elementos.");
               
                if (campo.Enabled && campo.Visible)
                {
                    campo.Focus();
                    campo.SelectAll();
                }
            }

            return result;
        }

        /// <summary>
        /// Método de validación para campo alfabético.
        /// </summary>
        /// <param name="texto">Texto a validar.</param>
        /// <returns>Validex del dato.</returns>
        public static bool EsAlfabetico(string texto)
        {
            string alphabetical = "[^a-zA-Z]";

            return !Regex.IsMatch(texto, alphabetical);
        }

        /// <summary>
        /// Método de validación para campo alfanumérico.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static bool EsAlfaNumerico(string texto)
        {
            string alphanumeric = "[^a-zA-Z0-9]";

            return !Regex.IsMatch(texto, alphanumeric);
        }

        /// <summary>
        /// Método de validación para campo alfanumérico.
        /// </summary>
        /// <param name="campo"></param>
        /// <param name="longitud"></param>
        /// <returns></returns>
        public static bool EsAlfaNumerico(TextBox campo, int longitud)
        {
            bool result = true;
            string alphanumeric = "[^a-zA-Z0-9]";

            if ((Regex.IsMatch(campo.Text, alphanumeric) || campo.Text.Length != longitud) && campo.Text != "")
            {
                result = false;

                
                Generic.Aviso("Dato incorrecto.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              
                if (campo.Enabled && campo.Visible)
                {
                    campo.Focus();
                    campo.SelectAll();
                }
            }

            return result;
        }


        public static bool EsRegExp(Control control, bool requerido, ErrorProvider proveedorErrores,string regExp,string descripcion,int longitud)
        {
            bool result = true;          

            if (control is TextBox)
            {
                if (requerido)
                {
                    if (EsVacio(control.Text))
                    {
                        result = false;
                        Generic.PonerError(proveedorErrores, control, "Debe introducir el/la " + descripcion + ".");

                    }
                    else if (!Regex.IsMatch(control.Text, regExp))
                    {
                        result = false;
                        Generic.PonerError(proveedorErrores, control, "Formato de " + descripcion + " incorrecto.");
                    }
                    if (result && longitud != -1 && control.Text.Length != longitud)
                    {
                        result = false;
                        Generic.PonerError(proveedorErrores, control, "Formato de " + descripcion + " incorrecto, la longitud debe ser: " + longitud.ToString());                        
                    }
                }
                else if (!EsVacio(control.Text) && !Regex.IsMatch(control.Text, regExp))
                {
                    result = false;
                    Generic.PonerError(proveedorErrores, control, "Formato de " + descripcion + " incorrecto.");
                }
            }
            // else if(control is ****)//AQUI VIENEN LAS COMPARACIONES ESPECIFICAS PARA CADA UNO DE LOS CONTROLES
            else//el control no se corresponde con ninguno de los 
            {
                result = false;
                Generic.PonerError(proveedorErrores, control, "No se han especificado acciones especificas para este control.");
            }
            return result;
        }
        public static bool EsRegExp(Control control, bool requerido, ErrorProvider proveedorErrores, string regExp, string descripcion)
        {
            return EsRegExp(control, requerido, proveedorErrores, regExp, descripcion,-1);
        }


    }
}

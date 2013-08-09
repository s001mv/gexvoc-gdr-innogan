using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;



namespace GEXVOC.UI
{
    public enum ValidacionesEspeciales
    {   SinValidacionEspecial,
        EsDNI,
        EsCodigoPostal,
        EsTarjetaCredito,
        EsTelefono,
        EsEntero,
        EsEnteroPositivo,
        EsNumero,
        EsCodigo,//Puede tener longitud, si es el caso asignar el correspondiente valor a la propiedad LongitudRegExp
        EsAlfabetico,
        EsAlfaNumerico,
        EsEmail,
        Personalizada//Se debe especificar un valor para regExp en la clase BindingMaestro
      

    }
 
    public class BindingMaestro
    {
        string _NombrePropiedad;
        public string NombrePropiedad
        {
            get { return _NombrePropiedad; }
            set { _NombrePropiedad = value; }
        }
        string _NombreVisible;

        public string NombreVisible
        {
            get { return _NombreVisible; }
            set { _NombreVisible = value; }
        }
        public string ValorDefecto { get; set; }


        IClaseBase _Objeto;
        public IClaseBase Objeto
        {
            get { return _Objeto; }
            set { _Objeto = value; }
        }

        Control _ControlAsociado;
        public Control ControlAsociado
        {
            get { return _ControlAsociado; }
            set { _ControlAsociado = value; }
        }
        Label _lblAsociado;
        public Label LblAsociado
        {
            get { return _lblAsociado; }
            set { _lblAsociado = value; }
        }

     
        private bool _Requerido=false;

        public bool Requerido
        {
            get { return _Requerido; }
            set {

                //Poner lbl en negrita o normal segun sea necesario
                if (LblAsociado!=null)
                {
                    if (value)
                        _lblAsociado.Font = new Font(_lblAsociado.Font, FontStyle.Bold);
                    else
                        _lblAsociado.Font = new Font(_lblAsociado.Font, FontStyle.Regular);
                }
                _Requerido = value; 
            }
        }

        private System.Type _TipoDatos;

        public System.Type TipoDatos
        {
            get { return _TipoDatos; }
            set { _TipoDatos = value; }
        }
   

        System.Data.Linq.Mapping.ColumnAttribute _AtributosLINQ = null;

        public System.Data.Linq.Mapping.ColumnAttribute AtributosLINQ
        {
            get { return _AtributosLINQ; }
            set { _AtributosLINQ = value; }
        }

        



        int _longitudRegExp = -1;
        /// <summary>
        /// Se utiliza cuando las validaciones especiales requieren la validación de longitud.
        /// </summary>
        public int LongitudRegExp
        {
            get { return _longitudRegExp; }
            set { _longitudRegExp = value; }
        }
       

        public int? max_length
        {
            get 
            {
                int? rtno = null;

                //Asigno tamaños por defecto si existen, por ejemplo datetime=10
                if (TipoDatos == typeof(DateTime) || TipoDatos == typeof(DateTime?))
                    rtno = 10;
          
                if (AtributosLINQ!=null && rtno==null)
                {
                    
                        string expreg = @"\([0-9]{1,12}";
                        string rdo = string.Empty;
                        Regex r = new Regex(expreg);
                        try
                        {
                            rdo = r.Match(AtributosLINQ.DbType).Value;
                        }
                        catch (Exception) { }

                        rdo = rdo.Replace("(", string.Empty);
                        try
                        {
                            rtno = int.Parse(rdo);
                        }
                        catch (Exception) { }
                }
                return rtno;
            
            }
        
        }

       
        ValidacionesEspeciales _ValidacionEspecial;
        public ValidacionesEspeciales ValidacionEspecial
        {
            get { return _ValidacionEspecial; }
            set { _ValidacionEspecial = value; }
        }

        string _regExp;
        
        /// <summary>
        /// Si se encuentra valorado, despues de la validación de tipos se aplica una segunda validación mediante expresión regular.        ///
        /// Aqui se especificará la expresión regular adecuada.
        /// </summary>
        public string RegExp
        {
            get { return _regExp; }
            set { _regExp = value; }
        }

        string _descRegExp;
        /// <summary>
        /// Descripción que se pondrá en el control si los datos no cumplen la expresión.
        /// </summary>
        public string DescRegExp
        {
            get { return _descRegExp; }
            set { _descRegExp = value; }
        }
      

    

        

        public BindingMaestro(IClaseBase objeto, string nombrePropiedad, string nombreVisible)
        {
            _Objeto = objeto;
            _NombrePropiedad = nombrePropiedad;
            _NombreVisible = nombreVisible;
         
            if (objeto != null)
            {
                try
                {
                    _TipoDatos = objeto.GetType().GetProperty(nombrePropiedad).PropertyType;
                }
                catch (Exception)
                {
                    throw new LogicException("La clase base especificada no contiene la propiedad: " + nombrePropiedad);
                }

                try//Obtengo los atributos linq para esta propiedad, DbType (Importantisimo) etc....
                {
                    _AtributosLINQ = ((System.Data.Linq.Mapping.ColumnAttribute)objeto.GetType().GetProperty(nombrePropiedad).GetCustomAttributes(false)[0]);                            

                }
                catch (Exception ex)
                { Traza.RegistrarError(ex); }
            }
            else
                _TipoDatos = typeof(Nullable);

            int anchoControl = 0;
            if (max_length!=null)         
                 anchoControl = ((int)max_length * 11) + 8;
         
                    
            if (anchoControl > 300 || anchoControl==0) anchoControl = 300;

            //Crear control Asociado
            _ControlAsociado = new TextBox() { Name = "txt" + nombrePropiedad, Width = anchoControl, Anchor = AnchorStyles.Left, MaxLength = max_length ?? 32767 };

            //Crear Label Asociado
            _lblAsociado = new Label() { Name = "lbl" + nombrePropiedad, Text = nombreVisible, AutoSize = true, Anchor = AnchorStyles.Left };

            if ((AtributosLINQ != null && !AtributosLINQ.CanBeNull) || (AtributosLINQ != null && AtributosLINQ.DbType.Contains("NOT NULL"))) Requerido = true;         


            
            _ValidacionEspecial = ValidacionesEspeciales.SinValidacionEspecial;

        }
       


        public BindingMaestro(IClaseBase objeto, string nombrePropiedad, Boolean requerido,Control control,Label lbl)
        {
            _Objeto = objeto;
            _NombrePropiedad = nombrePropiedad;
            if (lbl != null)
                _NombreVisible = lbl.Text;
            else
                _NombreVisible = nombrePropiedad;

            
            //_Ancho = control.Width;
          

            //Crear control Asociado
            _ControlAsociado = control;

            //Crear Label Asociado
            _lblAsociado = lbl;

            //Establecer la propiedad que indica si el valor es o no obigatorio.
            Requerido = requerido;

        

            if (objeto != null)
            {
                try
                {
                    _TipoDatos = objeto.GetType().GetProperty(nombrePropiedad).PropertyType;}
                catch (Exception)
                {
                    throw new LogicException("La clase base especificada no contiene la propiedad: " + nombrePropiedad);
                }

                try//Obtengo los atributos linq para esta propiedad, DbType (Importantisimo) etc....
                {
                    _AtributosLINQ = ((System.Data.Linq.Mapping.ColumnAttribute)objeto.GetType().GetProperty(nombrePropiedad).GetCustomAttributes(false)[0]);
                }
                catch (Exception ex)
                { Traza.RegistrarError(ex); }

                try
                {                        
                    //Si el tipo de datos del control es decimal, establecemos la alineacion del control a la derecha                        
                    if (_TipoDatos == typeof(decimal) || _TipoDatos == typeof(decimal?) || _TipoDatos == typeof(int) || _TipoDatos == typeof(int?))
                    {
                        if (control.GetType() == typeof(TextBox))
                            ((TextBox)control).TextAlign = HorizontalAlignment.Right;
                    }
                    else
                        if (max_length != null && control.GetType() == typeof(TextBox))
                            ((TextBox)control).MaxLength = (int)max_length;

                                               

                    
                }
                catch (Exception ex)
                {
                    Traza.RegistrarError(ex);
                }

                
            }
            else
                _TipoDatos = typeof(Nullable);

            if ((AtributosLINQ != null && !AtributosLINQ.CanBeNull) || (AtributosLINQ != null && AtributosLINQ.DbType.Contains("NOT NULL"))) Requerido = true;         


           



            _ValidacionEspecial = ValidacionesEspeciales.SinValidacionEspecial;

            
        }
  

        //public BindingMaestro(IClaseBase objeto,  Boolean requerido, Control control, Label lbl)
        //{
        //    objeto.GetType().GetProperty("asdasd")

        //    _Objeto = objeto;
        //    _NombrePropiedad = nombrePropiedad;
        //    _NombreVisible = lbl.Text;
        //    _Ancho = control.Width;
        //    _Requerido = requerido;

        //    //Crear control Asociado
        //    _ControlAsociado = control;

        //    //Crear Label Asociado
        //    _lblAsociado = lbl;


        //    //Poner lbl en negrita si es necesario
        //    if (requerido)
        //        _lblAsociado.Font = new Font(_lblAsociado.Font, FontStyle.Bold);



        //    if (objeto != null)
        //    {
        //        try
        //        {
        //            _TipoDatos = objeto.GetType().GetProperty(nombrePropiedad).PropertyType;
        //        }
        //        catch (Exception)
        //        {

        //            throw new LogicException("La clase base especificada no contiene la propiedad: " + nombrePropiedad);
        //        }
        //    }
        //    else
        //        _TipoDatos = typeof(Nullable);


        //}
     
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GEXVOC.Core.Controles
{
    public partial class ctlFecha : UserControl
    {

        #region CONSTRUCTORES
        public ctlFecha()
        {
            InitializeComponent();
            dtp.MaxDate = FechaMaxima;
            dtp.MinDate = fechaMinima;
        }       
        #endregion

        #region FUNCIONAMIENTO GENERAL
        private void dtp_DropDown(object sender, EventArgs e)
        {           
            this.txtFecha.Focus();
        }
        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            if (txtFecha.MaskCompleted)
            {
                DateTime fechaConvertir;
                if (DateTime.TryParse(txtFecha.Text, out fechaConvertir))
                {
                    if (fechaConvertir>=this.fechaMinima && fechaConvertir<=this.fechaMaxima)
                    {                          
                        this.txtFecha.Text = fechaConvertir.ToShortDateString();                    
                        this.dtp.Value = fechaConvertir;  
                    }                                   
                }                
            }            
        }
        private void dtp_CloseUp(object sender, EventArgs e)
        {
            this.txtFecha.Text = dtp.Value.ToShortDateString();
            this.txtFecha.Focus();
        }
        #endregion

        #region PROPIEDADES PERSONALIZADAS
        DateTime fechaMinima = DateTime.Parse("01/01/1753");
        public DateTime FechaMinima
        {
            get { return fechaMinima; }
            set { fechaMinima = value; }
        }
        DateTime fechaMaxima = DateTime.Parse("31/12/9998");
        public DateTime FechaMaxima
        {
            get { return fechaMaxima; }
            set { fechaMaxima = value; }
        }
        private bool _ReadOnly = false;
        public bool ReadOnly
        {
            get { return _ReadOnly; }
            set {
                
                txtFecha.ReadOnly = value;
                dtp.Enabled = !value; 

                this._ReadOnly = value;
            }
        }

        public bool ControlValorado
        {
            get
            {
                bool rtno = false;

                string TextoSinMascara = string.Empty;

                MaskFormat mfMaskFormat = txtFecha.TextMaskFormat;//Guardo el valor de la propiedad                    
                txtFecha.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;//Le quito los literales a .Text 
                TextoSinMascara = txtFecha.Text;
                txtFecha.TextMaskFormat = mfMaskFormat;//Asigno de nuevo la propiedad a su valor original

                if (TextoSinMascara != string.Empty)
                    rtno = true;

                return rtno;
            }
        }
        
        public bool DatosCorrectos
        {
            get 
            {
                bool rtno = true;
                if (ControlValorado && this.Value == null)//Tiene datos y no son una fecha válida
                    rtno = false;
                return rtno;            
            }          
        }

        public DateTime? Value
        {
            get { 
                DateTime Valor;
                if (DateTime.TryParse(txtFecha.Text, out Valor))
                    return Valor;
                else
                    return null;                            
            }

            set {                
                if (value.HasValue)
                {
                    if (value.Value >= fechaMinima && value <= fechaMaxima)
                        txtFecha.Text = value.Value.ToShortDateString();
                    else
                        txtFecha.Text = string.Empty;
                }
                else
                    txtFecha.Text = string.Empty;


                //lanzo el evento de valor cambiado
                ctlFechaEventArgs eventArgs = new ctlFechaEventArgs();
                eventArgs.Value = this.Value;
                OnValueChanged(eventArgs);
            }
        
        }

        public override string Text
        {
            get
            {
               return txtFecha.Text;
            }
            set
            {
                txtFecha.Text = value;
            }
        }

        #endregion        

        #region EVENTOS PERSONALIZADOS
        /// <summary>
        /// Evento que se produce cuando se cambia el valor en el control.
        /// El evento publica el nuevo valor.
        /// Se produce también cuando se asigna un valor bacío.
        /// </summary>
        public event EventHandler<ctlFechaEventArgs> ValueChanged;
        /// <summary>
        /// Lanzador del evento.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnValueChanged(ctlFechaEventArgs e)
        {
            EventHandler<ctlFechaEventArgs> handler = ValueChanged;
            if (handler != null)            
                handler(this, e);
            
        }
        #endregion       

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            this.Value = dtp.Value;
        }
      
    }

    #region CLASE PARA EVENTOS
    public class ctlFechaEventArgs : EventArgs
    {
        DateTime? _Value;
        public DateTime? Value
        {
            get { return _Value; }
            set { _Value = value; }
        }    
    }

    #endregion

    
    

}

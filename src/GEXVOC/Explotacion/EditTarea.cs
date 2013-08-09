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
    public partial class EditTarea : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditTarea()
        {
            InitializeComponent();
        }
        public EditTarea(Modo modo, Tarea ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Tarea ObjetoBase { get { return (Tarea)this.ClaseBase; } }

        int? _ValorFijoIdExplotacion = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe de aparecer con el valor de la explotación fijo.
        /// </summary>
        public int? ValorFijoIdExplotacion
        {
            get { return _ValorFijoIdExplotacion; }
            set
            {
                if (value != null)
                {
                    this.cmbExplotacion.ClaseActiva = Explotacion.Buscar((int)value);
                    this.cmbExplotacion.ReadOnly = true;
                }
                else
                    this.cmbExplotacion.ReadOnly = false;
                _ValorFijoIdExplotacion = value;
            }
        }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

            protected override void ClaseBaseAControles()
            {
                if (this.ObjetoBase.IdExplotacion>0)            
                    this.ValorFijoIdExplotacion = this.ObjetoBase.IdExplotacion;
                
                Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);

                DateTime fecha = this.ObjetoBase.Fecha;
                txtFecha.Value = fecha;
                txtHora.Text = fecha.ToString("HH:mm");

            }

            protected override void ControlesAClaseBase()
            {
               

                DateTime fecha;
                if (Generic.ControlValorado(txtHora))
                    fecha = Convert.ToDateTime(txtFecha.Text + " " + txtHora.Text);
                else
                    fecha = Generic.ControlADatetime(txtFecha);

                this.ObjetoBase.Fecha = fecha;



                ControlAClaseBase(this.ObjetoBase, "IdExplotacion", cmbExplotacion);
                ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
                
                
            }



            /// <summary>
            /// Validación de los Controles, se produce antes de actualizar la ClaseBase.
            /// </summary>
            /// <returns>Controles válidos (Si/No)</returns>
            protected override bool Validar()
            {
                bool Rtno = true;
                this.ErrorProvider.Clear();
                if (!Generic.ControlValorado(new Control[] { txtDescripcion }, this.ErrorProvider)) Rtno = false;
                if (!Generic.ControlDatosCorrectos(txtFecha, this.ErrorProvider, typeof(DateTime), true)) Rtno = false;
                if (!Generic.ControlDatosCorrectos(txtHora, this.ErrorProvider, typeof(DateTime), false)) Rtno = false;          

                return Rtno;

            }

        #endregion
      
        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarExplotacion_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindExplotaciones(Modo.Consultar, this.cmbExplotacion));
            }


        #endregion

        #region CARGAS COMUNES

            protected override void CargarValoresDefecto()
            {

                if (this._ValorFijoIdExplotacion == null)
                    this.ValorFijoIdExplotacion = Configuracion.Explotacion.Id;

                base.CargarValoresDefecto();
            }

        #endregion

    }
}
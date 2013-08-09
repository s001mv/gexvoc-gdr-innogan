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
    public partial class EditComposicion : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditComposicion()
        {
            InitializeComponent();
        }
        public EditComposicion(Modo modo, Composicion ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Composicion ObjetoBase { get { return (Composicion)this.ClaseBase; } }

        int? _ValorFijoIdRacion = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe aparecer con el combo de la explotacion fijo y con la explotacion que corresponde 
        /// con el Id especificado aqui.
        /// </summary>
        public int? ValorFijoIdRacion
        {
            get { return _ValorFijoIdRacion; }
            set
            {
                if (value != null)
                {
                    this.cmbRacion.ClaseActiva = Racion.Buscar((int)value);
                    this.cmbRacion.ReadOnly = true;                    
                }
                else
                    this.cmbRacion.ReadOnly = false; 

                _ValorFijoIdRacion = value;
            }
        }
        int? _ValorFijoIdAlimento = null;
        public int? ValorFijoIdAlimento
        {
            get { return _ValorFijoIdAlimento; }
            set
            {
                if (value != null)
                {
                    this.cmbAlimento.ClaseActiva = Producto.Buscar((int)value);
                    this.cmbAlimento.ReadOnly = true;
                }
                else
                    this.cmbAlimento.ReadOnly = false;

                _ValorFijoIdAlimento = value;
            }
        }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

        protected override void ClaseBaseAControles()
        {
            //this.cmbAlimento.ClaseActiva = Alimento.Buscar(this.ObjetoBase.Alimento.Id);
            //Generic.ClaseBaseAcontrol(this.ObjetoBase, "IdRacion", cmbRacion);
            ////Generic.ClaseBaseAcontrol(this.ObjetoBase, "IdAlimento", cmbAlimento);
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "Porcentaje", txtPorcentaje);
        }

        protected override void ControlesAClaseBase()
        {

            this.ControlAClaseBase(this.ObjetoBase, "IdRacion", cmbRacion);
            this.ControlAClaseBase(this.ObjetoBase, "IdAlimento", cmbAlimento);
            this.ControlAClaseBase(this.ObjetoBase, "Porcentaje", txtPorcentaje);
        }



        /// <summary>
        /// Validación de los Controles, se produce antes de actualizar la ClaseBase.
        /// </summary>
        /// <returns>Controles válidos (Si/No)</returns>
        protected override bool Validar()
        {
            bool Rtno = true;
            this.ErrorProvider.Clear();
            if (!Generic.ControlValorado(new Control[] { txtPorcentaje,cmbAlimento,cmbRacion }, this.ErrorProvider))
                Rtno = false;
            if(!Generic.ControlDatosCorrectos(txtPorcentaje,this.ErrorProvider,"El dato debe ser un porcentaje",this.ObjetoBase.Porcentaje.GetType(),true))
                Rtno = false;


            return Rtno;

        }

        #endregion

        #region FUNCIONAMIENTO GENERAL

            private void btnBuscarRacion_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindRacion(Modo.Consultar, this.cmbRacion));
            }

            private void btnBuscarAlimento_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindProducto(Modo.Consultar, this.cmbAlimento) { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.ALIMENTACION) });

            }

        #endregion

        #region COMBOS


            private void cmbAlimento_CrearNuevo(object sender, EventArgs e)
            {
                Producto ObjetoBase = new Producto();
                EditProducto editProducto = new EditProducto(Modo.Guardar, ObjetoBase);
                editProducto.ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.ALIMENTACION);                


                CrearNuevoElementoCombo(editProducto, sender);
            }


        #endregion



    }
}
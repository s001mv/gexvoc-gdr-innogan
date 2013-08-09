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
    public partial class EditTratHigiene : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditTratHigiene()
        {
            InitializeComponent();
        }
        public EditTratHigiene(Modo modo, TratHigiene ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public TratHigiene ObjetoBase { get { return (TratHigiene)this.ClaseBase; } }

        int? _ValorFijoIdExplotacion = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe aparecer con el combo de la explotacion fijo y con la explotacion que corresponde 
        /// con el Id especificado aqui.
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

            protected override void DefinirListaBinding()
            {
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdExplotacion", true, this.cmbExplotacion, lblExplotacion));
                //this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdProducto", true, this.cmbProducto, lblProducto));
                //this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdPrograma", true, this.cmbPrograma, lblprograma));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Detalle", false, this.txtDetalle, lblDetalle));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, this.txtFecha, lblFecha));

                
                base.DefinirListaBinding();
            }
            private void EditTratHigiene_PropiedadAControl(object sender, PropiedadBindEventArgs e)
            {
                e.Cancelar = true;

                if (e.Control == cmbExplotacion)
                    this.cmbExplotacion.ClaseActiva = Explotacion.Buscar(this.ObjetoBase.IdExplotacion);
                //else if (e.Control == cmbProducto)
                //    this.cmbProducto.ClaseActiva = Producto.Buscar(this.ObjetoBase.IdProducto);
                else
                    e.Cancelar = false;
                
            }

        #endregion

        #region CARGAS COMUNES
            protected override void CargarValoresDefecto()
            {
                if (this._ValorFijoIdExplotacion == null)
                    this.ValorFijoIdExplotacion = Configuracion.Explotacion.Id;
                    
                base.CargarValoresDefecto();
            }

            protected override void CargarCombos()
            {
                this.CargarCombo(cmbPrograma, Programa.Buscar());            
        
                base.CargarCombos();
            }

        #endregion

        #region FUNCIONAMIENTO GENERAL

            private void btnBuscarProducto_Click(object sender, EventArgs e)
            {
                FindProducto frmProducto = new FindProducto(Modo.Consultar,cmbProducto) { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.PRODUCTO_PARA_PLANES_DE_HIGIENE) };

                LanzarFormularioConsulta(frmProducto);       
            }

            private void btnBuscarExplotacion_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindExplotaciones(Modo.Consultar, this.cmbExplotacion));
            }

        #endregion





    }
}
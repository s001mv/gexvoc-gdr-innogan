using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Clases;

namespace GEXVOC.UI
{
    public partial class EditProducto : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditProducto()
        {
            InitializeComponent();
        }
        public EditProducto(Modo modo, Producto ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Producto ObjetoBase { get { return (Producto)this.ClaseBase; } }


    
        TipoProducto _ValorFijoTipoProducto=null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe aparecer con el combo de la hembra fijo y con el animal que corresponde 
        /// con el Id especificado aqui.
        /// </summary>
        public TipoProducto ValorFijoTipoProducto
        {
            get { return _ValorFijoTipoProducto; }
            set
            {
                if (value != null)
                {
                    _ValorFijoTipoProducto = value;
                    this.cmbTipoProducto.ClaseActiva = value;
                    this.cmbTipoProducto.ReadOnly = true;
                    this.Text = "Producto del tipo: " + Cadenas.ToUpperPrimerCaracter(_ValorFijoTipoProducto.Descripcion);



                    if (value.Familia != null && value.Familia == true)
                    {
                        this.cmbFamilia.Enabled = true;
                        this.cmbFamilia.Visible = true;
                        lblFamilia.Enabled = true;
                        lblFamilia.Visible = true;
                    }
                    else
                    {
                        this.cmbFamilia.Enabled = false;
                        this.cmbFamilia.Visible = false;
                        lblFamilia.Enabled = false;
                        lblFamilia.Visible = false;

                    }
                }
                else
                    this.cmbTipoProducto.ReadOnly = false;

                _ValorFijoTipoProducto = value;
            }
        }


        int? _ValorFijoIdFamilia = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe aparecer con el combo de la Provincia fijo y con la seleccion que corresponde 
        /// con el Id especificado aqui.
        /// </summary>
        public int? ValorFijoIdFamilia
        {
            get { return _ValorFijoIdFamilia; }
            set
            {
                if (value != null)
                {
                    this.CargarCombo(cmbFamilia, "Descripcion", Familia.Buscar());
                    this.cmbFamilia.SelectedValue = value;
                    this.cmbFamilia.Enabled = false;
                }
                else
                    this.cmbFamilia.Enabled = true;

                _ValorFijoIdFamilia = value;
            }
        }

        public string Descripcion { get { return txtDescripcion.Text; } set { txtDescripcion.Text = value; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Descripcion", true, this.txtDescripcion, lblDescripcion));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdFamilia", false, this.cmbFamilia, lblFamilia));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTipo", true, this.cmbTipoProducto, lblTipo));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "SupresionLeche", false, this.txtSupresionLeche, lblSupresionLeche));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "SupresionCarne", false, this.txtSupresionCarne, lblSupresionCarne));
                
                base.DefinirListaBinding();
            }         

           

        #endregion

        #region CARGAS COMUNES
            protected override void CargarCombos()
            {
                cmbFamilia.CargarCombo();           
            }
        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void cmbTipoProducto_ClaseActivaChanged(object sender, GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs e)
            {

                if (e.ClaseActiva!=null && e.ClaseActiva.Id == Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.SANIDAD).Id)
                {
                    pnlMedicamento.Enabled = true;
                    pnlMedicamento.Visible=true;                
                }
                else
                {
                    pnlMedicamento.Enabled = false;
                    pnlMedicamento.Visible = false;
                
                }
            }

            private void txtSupresionLeche_TextChanged(object sender, EventArgs e)
            {

            }

        #endregion

 
        #region COMBOS
           private void cmbFamilia_CargarContenido(object sender, EventArgs e)
            {
                if (this.ValorFijoIdFamilia == null)
                    this.CargarCombo(this.cmbFamilia, "Descripcion", Familia.Buscar(Generic.ControlAIntNullable(cmbTipoProducto), string.Empty, null));            
           
            }

            private void cmbFamilia_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                
                Familia ObjetoBase = new Familia();
                EditFamilia editFamilia = new EditFamilia(Modo.Guardar, ObjetoBase);
                editFamilia.ValorFijoTipoProducto = (TipoProducto)cmbTipoProducto.ClaseActiva;
                editFamilia.Descripcion = e.TextoCrear;

                CrearNuevoElementoCombo(editFamilia, sender);
                
            }

        #endregion


    }
}

 //---------------------Código Comentado----------------------------------------------//
            //protected override void ClaseBaseAControles()
            //{
            //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
            //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "IdFamilia", cmbFamilia);
            //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "IdTipo", cmbTipoProducto);
            //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "SupresionLeche", txtSupresionLeche);
            //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "SupresionCarne", txtSupresionCarne);
            //}

            //protected override void ControlesAClaseBase()
            //{

            //    Generic.ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
            //    Generic.ControlAClaseBase(this.ObjetoBase, "IdFamilia", cmbFamilia);
            //    Generic.ControlAClaseBase(this.ObjetoBase, "IdTipo", cmbTipoProducto);
            //    Generic.ControlAClaseBase(this.ObjetoBase, "SupresionLeche", txtSupresionLeche);
            //    Generic.ControlAClaseBase(this.ObjetoBase, "SupresionCarne", txtSupresionCarne);
            //}



            ///// <summary>
            ///// Validación de los Controles, se produce antes de actualizar la ClaseBase.
            ///// </summary>
            ///// <returns>Controles válidos (Si/No)</returns>
            //protected override bool Validar()
            //{
            //    bool Rtno = true;
            //    this.ErrorProvider.Clear();
            //    if (!Generic.ControlValorado(cmbTipoProducto, this.ErrorProvider)) 
            //    {
            //        Generic.AvisoInformation("El tipo no se ha especificado, no se puede continuar");
            //        Rtno = false;                
                
            //    }
                    

            //    if (!Generic.ControlValorado(txtDescripcion , this.ErrorProvider))
            //        Rtno = false;


            //    return Rtno;

            //}
        //private void cmbTipoProducto_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    if (cmbTipoProducto.Text == "MEDICAMENTO")
        //    {
        //        lblSupresionCarne.Visible = true;
        //        lblSupresionLeche.Visible = true;
        //        lblDiasCarne.Visible = true;
        //        lblDiasLeche.Visible = true;
        //        txtSupresionCarne.Visible = true;
        //        txtSupresionLeche.Visible = true;
        //    }
        //    else
        //    {
        //        lblSupresionCarne.Visible = false;
        //        lblSupresionLeche.Visible = false;
        //        lblDiasCarne.Visible = false;
        //        lblDiasLeche.Visible = false;
        //        txtSupresionCarne.Visible = false;
        //        txtSupresionLeche.Visible = false;
        //    }
        //}
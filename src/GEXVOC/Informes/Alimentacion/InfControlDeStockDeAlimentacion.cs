using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Informes;
using GEXVOC.UI;
using GEXVOC.UI.Clases;

namespace GEXVOC.Informes
{
    public partial class InfControlDeStockDeAlimentacion : GEXVOC.Core.Controles.ctlInforme
    {
        public InfControlDeStockDeAlimentacion()
        {
            InitializeComponent();
        }
        public GenericMaestro FormularioMaestro
        {
            get { return ((GenericMaestro)this.FormularioInformes); }
        }
        
        public override CrystalDecisions.CrystalReports.Engine.ReportDocument Generar()
        {
            //INICIO - Declaro y establezo los valores a las variables que forman el filtro
            DateTime? FechaInicio = Generic.ControlADatetimeNullable(txtFechaInicio);
            DateTime? FechaFin = Generic.ControlADatetimeNullable(txtFechaFin);
            //FIN - Declaro y establezo los valores a las variables que forman el filtro

            
            //Creo el objeto del tipo adecuado (hereda de ReportDocument)
            ControlDeStockDeAlimentacion rpte = new ControlDeStockDeAlimentacion();

            //Inicializo el dataset adecuado para el informe con los datos pertinentes.
            ControlDeStockDeAlimentacionDS datos = DatosInformes.ControlDeStockDeAlimentacion(Generic.ControlAIntNullable(cmbTipoProducto),
                                                                                              Generic.ControlAIntNullable(cmbFamilia),
                                                                                              Generic.ControlAIntNullable(cmbProducto),
                                                                                              Generic.ControlAIntNullable(cmbMacho),null,
                                                                                              FechaInicio,FechaFin);

            //Establezco el origen de datos del informe
            rpte.SetDataSource(datos);

            //Establezco los valores a los parámetros del informe.
            Generic.EstablecerParametro(rpte, rpte.Parameter_CEA, Configuracion.Explotacion.CEA);
            Generic.EstablecerParametro(rpte, rpte.Parameter_Explotacion, Configuracion.Explotacion.Nombre);
            Generic.EstablecerParametro(rpte, rpte.Parameter_Filtro,
                (FechaInicio.HasValue?"Fecha >= " + FechaInicio.Value.ToShortDateString() + "; ":string.Empty) + 
                (FechaFin.HasValue?"Fecha <= " + FechaFin.Value.ToShortDateString() + "; ":string.Empty) +
                (Generic.ControlAIntNullable(cmbTipoProducto).HasValue ? "TIPO PRODUCTO = " + cmbTipoProducto.Text + "; ":string.Empty) +
                (Generic.ControlAIntNullable(cmbFamilia).HasValue ? "FAMILIA = " + cmbFamilia.Text + "; ":string.Empty) +
                (Generic.ControlAIntNullable(cmbProducto).HasValue ? "PRODUCTO = " + cmbProducto.Text + "; " : string.Empty));
            

            //Retorno el ReportDocument debidamente formado.
            return rpte;
        }


        #region Carga de Familias y Productos - Funcionamiento dependiente del valor seleccionado en Tipos de Productos
        /// <summary>
        /// switch q nos indica si cargar o no productos (se utiliza para no llamar mas de una vez a cargar productos si no es necesario)
        /// </summary>
        bool CargaBloqueada = false;
        void CargarProductos()
        {
            if (!CargaBloqueada)
            {
                List<Producto> lstProductos = null;
                if (cmbTipoProducto.SelectedValue != null)
                {
                    if (cmbFamilia.SelectedValue != null)//Cargo los productos asociados a la familia.
                    {
                        Familia familia = Familia.Buscar(Generic.ControlAInt(cmbFamilia));
                        lstProductos = familia.lstProductos;
                    }
                    else//Cargo los productos asociados a tipo de producto
                    {
                        TipoProducto tipoSeleccionado = TipoProducto.Buscar(Generic.ControlAInt(cmbTipoProducto));
                        lstProductos = tipoSeleccionado.lstProductos;
                    }
                }
                else
                {
                    this.cmbFamilia.Text = string.Empty;
                    this.cmbFamilia.DataSource = null;
                }
                this.cmbProducto.Text = string.Empty;
                this.cmbProducto.DataSource = null;
                FormularioMaestro.CargarCombo(this.cmbProducto, lstProductos, true);
            }
        }
        private void cmbTipoProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CargarProductos();
                CargaBloqueada = true;

                if (cmbTipoProducto.SelectedValue != null)
                {
                    TipoProducto tipoSeleccionado = TipoProducto.Buscar(Generic.ControlAInt(cmbTipoProducto));
                  

                    if (tipoSeleccionado != null)
                    {
                       
                        if (tipoSeleccionado.Familia ?? false)
                        {//Si el tipo tiene familias
                            FormularioMaestro.CargarCombo(this.cmbFamilia, tipoSeleccionado.lstFamilias);
                            cmbFamilia.Enabled = true;
                        }
                        else
                            cmbFamilia.Enabled = false;

                      
                    }
                }
                else
                {
                    this.cmbFamilia.DataSource = null;
                    this.cmbProducto.DataSource = null;
                }
            }
            finally
            {
                CargaBloqueada = false;

            }
        }
        private void cmbFamilia_SelectedValueChanged(object sender, EventArgs e)
        {

            CargarProductos();
            if (cmbFamilia.SelectedValue != null)
            {

                Familia familia = Familia.Buscar(Generic.ControlAInt(cmbFamilia));
                //CargarCombo(this.cmbProducto, familia.lstProductos, true);
                if (familia.Id == Configuracion.FamiliaSistema(Configuracion.FamiliasSistema.PAJUELA_SEMEN).Id)
                {
                    pnlMacho.Visible = true;
                    pnlMacho.Enabled = true;
                    Generic.IntAControl(cmbProducto, Configuracion.ProductoSistema(Configuracion.ProductosSistema.PAJUELA_PROPIA).Id);
                    pnlProducto.Visible = false;
                    pnlProducto.Enabled = false;
                  

                }
                else
                {
                    pnlProducto.Visible = true;
                    pnlProducto.Enabled = true;

                    pnlMacho.Visible = false;
                    pnlMacho.Enabled = false;

                }


            }


        }
        private void cmbFamilia_TextUpdate(object sender, EventArgs e)
        {
            if (cmbFamilia.Text == string.Empty)
            {
                cmbFamilia.SelectedIndex = -1;
                //Validate(true);            
                //CargarProductos();
            }

        }
        private void cmbTipoProducto_TextUpdate(object sender, EventArgs e)
        {
            if (cmbTipoProducto.Text == string.Empty)
            {
                cmbTipoProducto.SelectedIndex = -1;

            }

        }
        #endregion

        public override void CargaControles()
        {
            base.CargaControles();

            //Carga el combo de Tipo Producto
            FormularioMaestro.CargarCombo(cmbTipoProducto, TipoProducto.Buscar());
        }

        private void btnBuscarMacho_Click(object sender, EventArgs e)
        {
            FormularioMaestro.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbMacho) { ValorSexoFijo = Convert.ToChar("M") });
        }
        public override void ValoresPredeterminados()
        {
            //base.ValoresPredeterminados();
            Generic.IntAControl(cmbTipoProducto, Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.ALIMENTACION).Id);
            cmbTipoProducto.Enabled = false;
          

        }
     

       

      

       
       

      
    }
}
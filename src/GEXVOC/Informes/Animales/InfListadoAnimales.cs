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
    public partial class InfListadoAnimales : GEXVOC.Core.Controles.ctlInforme
    {
        public InfListadoAnimales()
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
            ////****Escribir aqui las variables necesarias para la llamada a: DatosInformes.ListadoAnimales();
            //FIN - Declaro y establezo los valores a las variables que forman el filtro


            //Creo el objeto del tipo adecuado (hereda de ReportDocument)
            ListadoAnimales rpte = new ListadoAnimales();

            //Inicializo el dataset adecuado para el informe con los datos pertinentes.
            ListadoAnimalesDS datos = DatosInformes.ListadoAnimales(null,Generic.ControlAIntNullable(cmbRaza),Generic.ControlAIntNullable(cmEstado),null,null,
                                               Configuracion.Explotacion.Id, txtDIB.Text,this.txtCrotal.Text,txtTatuaje.Text,
                                               this.txtNombre.Text, Generic.ControlADatetimeNullable(this.txtFecNacimiento),Generic.ControlACharNullable(cmbSexo),null,
                                               null,rbtMostrarBajas.Checked,Generic.ControlAIntNullable(cmbEspecie),
                                               Generic.ControlAIntNullable(cmbAltaTipo),Generic.ControlADatetimeNullable(txtAltaFecha),txtAltaDetalle.Text,
                                               Generic.ControlAIntNullable(cmbBajaTipo),Generic.ControlADatetimeNullable(txtBajaFecha),txtBajaDetalle.Text,chkIncluirExternos.Checked);

            //Establezco el origen de datos del informe
            rpte.SetDataSource(datos);

            //Obtengo los valores de los parámetros
            string filtro = (Generic.ControlAIntNullable(cmbRaza).HasValue ? "Raza = " + cmbRaza.Text + "; " : string.Empty) +
                (Generic.ControlAIntNullable(cmEstado).HasValue ? "Estado = " + cmEstado.Text + "; " : string.Empty) +
                (txtDIB.Text != string.Empty ? "CI contiene (" + txtDIB.Text + "); " : string.Empty) +
                (txtCrotal.Text != string.Empty ? "Crotal contiene (" + txtCrotal.Text + "); " : string.Empty) +
                (txtTatuaje.Text != string.Empty ? "Tatuaje contiene (" + txtTatuaje.Text + "); " : string.Empty) +
                (txtNombre.Text != string.Empty ? "Nombre contiene (" + txtNombre.Text + "); " : string.Empty) +
                (Generic.ControlAIntNullable(txtFecNacimiento).HasValue ? "Estado = " + txtFecNacimiento.Value.Value.ToShortDateString() + "; " : string.Empty) +
                (Generic.ControlACharNullable(cmbSexo).HasValue ? "Sexo = " + Generic.ControlACharNullable(cmbSexo).Value.ToString() + "; " : string.Empty) +
                (Generic.ControlAIntNullable(cmbEspecie).HasValue ? "Especie = " + cmbEspecie.Text + "; " : string.Empty) +
                (Generic.ControlAIntNullable(cmbAltaTipo).HasValue ? "Tipo Alta = " + cmbAltaTipo.Text + "; " : string.Empty) +
                (Generic.ControlAIntNullable(txtAltaFecha).HasValue ? "Fecha Alta = " + txtAltaFecha.Value.Value.ToShortDateString() + "; " : string.Empty) +
                (txtAltaDetalle.Text != string.Empty ? "Detalle Alta contiene (" + txtAltaDetalle.Text + "); " : string.Empty) +
                (Generic.ControlAIntNullable(cmbBajaTipo).HasValue ? "Tipo Baja = " + cmbBajaTipo.Text + "; " : string.Empty) +
                (Generic.ControlAIntNullable(txtBajaFecha).HasValue ? "Fecha Baja = " + txtBajaFecha.Value.Value.ToShortDateString() + "; " : string.Empty) +
                (txtBajaDetalle.Text != string.Empty ? "Detalle Baja contiene (" + txtBajaDetalle.Text + "); " : string.Empty) +
                (rbtMostrarBajas.Checked ? "Mostrar solo Bajas" : "Mostrar solo Altas") +
                (chkIncluirExternos.Checked ? "; Externos incluídos" : "; Externos excluídos");
            

            //Establezco los valores a los parámetros del informe.
            Generic.EstablecerParametro(rpte, rpte.Parameter_CEA, Configuracion.Explotacion.CEA);
            Generic.EstablecerParametro(rpte, rpte.Parameter_Explotacion, Configuracion.Explotacion.Nombre);            
            Generic.EstablecerParametro(rpte, rpte.Parameter_Filtro,filtro);
            

            //Retorno el ReportDocument debidamente formado.
            return rpte;
        }

        private void ActualizarPaneles()
        {

            if (this.rbtMostrarAltas.Checked && !pnlAlta.Visible)
            {
                pnlAlta.Visible = true;
                pnlAlta.Enabled = true;
                pnlBaja.Visible = false;
                pnlBaja.Enabled = false;
                txtAltaFecha.Focus();
            }
            if (this.rbtMostrarBajas.Checked && !pnlBaja.Visible)
            {
                pnlAlta.Visible = false;
                pnlAlta.Enabled = false;
                pnlBaja.Visible = true;
                pnlBaja.Enabled = true;
                txtBajaFecha.Focus();
            }
        }

        private void rbt_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarPaneles();
        }

       public override void  CargaControles()        
       {
            FormularioMaestro.CargarCombo(cmbEspecie, Configuracion.Explotacion.lstEspecies, true);
            FormularioMaestro.CargarCombo(cmEstado, Estado.Buscar());

            FormularioMaestro.CargarCombo(cmbAltaTipo, TipoAlta.Buscar());
            FormularioMaestro.CargarCombo(cmbBajaTipo, TipoBaja.Buscar());

            Generic.CargarComboSexos(cmbSexo);
        }

       private void cmbEspecie_SelectedIndexChanged(object sender, EventArgs e)
       {
           if (cmbEspecie.SelectedValue != null)           
               FormularioMaestro.CargarCombo(this.cmbRaza, "Descripcion", Raza.Buscar(string.Empty, Generic.ControlAIntNullable(cmbEspecie)));           
           else
               this.cmbRaza.DataSource = null;
       }
    }
}
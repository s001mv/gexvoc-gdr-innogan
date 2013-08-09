using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GEXVOC.UI.Clases;
using GEXVOC.UI;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Informes;

namespace GEXVOC.Informes
{
    public partial class InfCapacidadMaternal : GEXVOC.Core.Controles.ctlInforme
    {
        public InfCapacidadMaternal()
        {
            InitializeComponent();
        }

        public GenericMaestro FormularioMaestro
        { 
            get { return ((GenericMaestro)this.FormularioInformes); } 
        }

        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            SelectorAnimales frmSelectorAnimales = new SelectorAnimales(Modo.Consultar, (List<Animal>)this.cmbAnimal.DataSource, Convert.ToChar("H"));

            if (FormularioMaestro != null)
                FormularioMaestro.LanzarFormulario(frmSelectorAnimales);

            if (frmSelectorAnimales.LstAnimalesSeleccionadosRtno != null)
            {
                this.cmbAnimal.DataSource = frmSelectorAnimales.LstAnimalesSeleccionadosRtno;
                this.cmbAnimal.Text = "(" + frmSelectorAnimales.LstAnimalesSeleccionadosRtno.Count + ") Elementos en selección";
            }
        }

        public override bool Validar()
        {
            Boolean rtno = true;

            if (FormularioMaestro != null)
            {
                if (!Generic.ControlValorado(this.cmbAnimal, FormularioMaestro.ErrorProvider)) rtno = false;
            }

            return rtno;
        }

        public override CrystalDecisions.CrystalReports.Engine.ReportDocument Generar()
        {
            //INICIO - Declaro y establezo los valores a las variables que forman el filtro
            ////****Escribir aqui las variables necesarias para la llamada a: DatosInformes.CapacidadMaternal();
            //FIN - Declaro y establezo los valores a las variables que forman el filtro


            //Creo el objeto del tipo adecuado (hereda de ReportDocument)
            CapacidadMaternal rpte = new CapacidadMaternal();

            //Inicializo el dataset adecuado para el informe con los datos pertinentes.
            CapacidadMaternalDS datos = DatosInformes.CapacidadMaternal((List<Animal>)this.cmbAnimal.DataSource);

            //Establezco el origen de datos del informe
            rpte.SetDataSource(datos);

            //Establezco los valores a los parámetros del informe si es necesario.
            Generic.EstablecerParametro(rpte, rpte.Parameter_MostrarComoSubInforme, false);

            //Retorno el ReportDocument debidamente formado.
            return rpte;
        }
    }
}

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
using GEXVOC.Core.Data;

namespace GEXVOC.Informes
{
    public partial class InfTasaAbortos : GEXVOC.Core.Controles.ctlInforme
    {
        public InfTasaAbortos()
        {
            InitializeComponent();
        }

        public GenericMaestro FormularioMaestro
        {
            get { return ((GenericMaestro)this.FormularioInformes); }
        }

        public override void CargaControles()
        {
            if (FormularioMaestro != null)
                FormularioMaestro.CargarCombo(this.cmbEspecie, Especie.Buscar());

            base.CargaControles();
        }

        /// <summary>
        /// Se produce al pulsar el botón de generar, dependiendo del valor devuelto, se continuará con la carga
        /// del informe, o ésta se cancelará
        /// Representamos aqui tanto los valores requeridos sin los que no tendría sentido el informe, como la 
        /// validación de los tipos de datos de los controles.
        /// </summary>
        /// <returns></returns>
        public override bool Validar()
        {
            Boolean rtno = true;

            if (FormularioMaestro != null)
            {
                if (!Generic.ControlValorado(this.cmbEspecie, FormularioMaestro.ErrorProvider))
                    rtno = false;
                if (!Generic.ControlDatosCorrectos(this.txtFInicio, FormularioMaestro.ErrorProvider, typeof(System.DateTime), true))
                    rtno = false;
                if (!Generic.ControlDatosCorrectos(this.txtFFin, FormularioMaestro.ErrorProvider, typeof(System.DateTime), true))
                    rtno = false;
            }

            return rtno;
        }

        public override CrystalDecisions.CrystalReports.Engine.ReportDocument Generar()
        {
            DateTime Inicio = Convert.ToDateTime(txtFInicio.Text);
            DateTime Fin = Convert.ToDateTime(txtFFin.Text);

            TasaAbortos Informe = new TasaAbortos();
            TasaAbortosDS Datos = new TasaAbortosDS();

            TasaAbortosDS.TasaRow TasaRow = Datos.Tasa.NewTasaRow();

            TasaRow.Tipo = "Partos";
            TasaRow.Numero = DatosInformes.PartosXIntervalo(Configuracion.Explotacion.Id, Generic.ControlAInt(cmbEspecie), Inicio, Fin).Count;

            Datos.Tasa.AddTasaRow(TasaRow);

            TasaRow = Datos.Tasa.NewTasaRow();

            TasaRow.Tipo = "Abortos";
            TasaRow.Numero = DatosInformes.AbortosXIntervalo(Configuracion.Explotacion.Id, Generic.ControlAInt(cmbEspecie), Inicio, Fin).Count;

            Datos.Tasa.AddTasaRow(TasaRow);
            
            Informe.SetDataSource(Datos);

            Informe.SetParameterValue("CEA", Configuracion.Explotacion.CEA);
            Informe.SetParameterValue("Explotacion", Configuracion.Explotacion.Nombre);
            Informe.SetParameterValue("Periodo", "Período: " + txtFInicio.Text + " al " + txtFFin.Text);

            return Informe;
        }
    }
}

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
    public partial class InfTasaPartos : GEXVOC.Core.Controles.ctlInforme
    {
        public InfTasaPartos()
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
                if (!Generic.ControlDatosCorrectos(this.txtEInicio, FormularioMaestro.ErrorProvider, typeof(System.Int32), false))
                    rtno = false;
                if (!Generic.ControlDatosCorrectos(this.txtEFin, FormularioMaestro.ErrorProvider, typeof(System.Int32), false))
                    rtno = false;

                if (Generic.ControlAIntNullable(this.txtEInicio) != null && Generic.ControlAIntNullable(this.txtEFin) != null
                    && Generic.ControlAIntNullable(this.txtEInicio).Value > Generic.ControlAIntNullable(this.txtEFin).Value)
                {
                    Generic.PonerError(FormularioMaestro.ErrorProvider, txtEFin, "La edad de fin del intervalo de búsqueda debe ser mayor o igual que la de inicio.");
                    
                    rtno = false;
                }
            }

            return rtno;
        }

        public override CrystalDecisions.CrystalReports.Engine.ReportDocument Generar()
        {
            DateTime Inicio = Convert.ToDateTime(txtFInicio.Text);
            DateTime Fin = Convert.ToDateTime(txtFFin.Text);

            TasaPartos Informe = new TasaPartos();
            TasaPartosDS Datos = new TasaPartosDS();

            TasaPartosDS.TasaRow TasaRow = Datos.Tasa.NewTasaRow();

            TasaRow.Tipo = "Animales";

            List<Animal> Animales = DatosInformes.HembrasXEdadIntervalo(Configuracion.Explotacion.Id, Generic.ControlAInt(cmbEspecie),
                Generic.ControlAIntNullable(txtEInicio), Generic.ControlAIntNullable(txtEFin), Inicio, Fin);

            TasaRow.Numero = Animales.Count;

            Datos.Tasa.AddTasaRow(TasaRow);

            TasaRow = Datos.Tasa.NewTasaRow();

            TasaRow.Tipo = "Partos";
            TasaRow.Numero = 0;

            foreach (Animal A in Animales)
                TasaRow.Numero += Parto.Buscar(A.Id, null, null, null, null, Inicio, Fin, null).Count;

            Datos.Tasa.AddTasaRow(TasaRow);

            Informe.SetDataSource(Datos);

            Informe.SetParameterValue("CEA", Configuracion.Explotacion.CEA);
            Informe.SetParameterValue("Explotacion", Configuracion.Explotacion.Nombre);
            Informe.SetParameterValue("Periodo", "Período: " + txtFInicio.Text + " al " + txtFFin.Text);

            return Informe;
        }
    }
}

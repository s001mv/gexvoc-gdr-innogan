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
    public partial class InfDistribucionPartos : GEXVOC.Core.Controles.ctlInforme
    {
        public InfDistribucionPartos()
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

            DistribucionPartos Informe = new DistribucionPartos();
            DistribucionPartosDS Datos = new DistribucionPartosDS();

            List<Parto> Partos = DatosInformes.UltimosPartosXIntervalo(Configuracion.Explotacion.Id, Generic.ControlAInt(cmbEspecie), Inicio, Fin);

            if (Partos.Count > 0)
            {
                DistribucionPartosDS.DistribucionRow DistribucionRow = Datos.Distribucion.NewDistribucionRow();
                DistribucionRow.Primero = 0;
                DistribucionRow.Segundo = 0;
                DistribucionRow.Tercero = 0;
                DistribucionRow.Mas = 0;
                DistribucionRow.Primavera = 0;
                DistribucionRow.Verano = 0;
                DistribucionRow.Otoño = 0;
                DistribucionRow.Invierno = 0;

                int Primavera = Convert.ToDateTime("21/03").DayOfYear;
                int Verano = Convert.ToDateTime("21/06").DayOfYear;
                int Otoño = Convert.ToDateTime("23/09").DayOfYear;
                int Invierno = Convert.ToDateTime("21/12").DayOfYear;

                foreach (Parto P in Partos)
                {
                    switch (P.Numero)
                    {
                        case 1:
                            DistribucionRow.Primero += 1;
                            break;
                        case 2:
                            DistribucionRow.Segundo += 1;
                            break;
                        case 3:
                            DistribucionRow.Tercero += 1;
                            break;
                        default:
                            DistribucionRow.Mas += 1;
                            break;
                    }

                    if (P.Fecha.DayOfYear >= Primavera && P.Fecha.DayOfYear < Verano)
                        DistribucionRow.Primavera += 1;
                    else if (P.Fecha.DayOfYear >= Verano && P.Fecha.DayOfYear < Otoño)
                        DistribucionRow.Verano += 1;
                    else if (P.Fecha.DayOfYear >= Otoño && P.Fecha.DayOfYear < Invierno)
                        DistribucionRow.Otoño += 1;
                    else
                        DistribucionRow.Invierno += 1;
                }

                Datos.Distribucion.AddDistribucionRow(DistribucionRow);
            }

            Partos = null;

            Informe.SetDataSource(Datos);

            Informe.SetParameterValue("CEA", Configuracion.Explotacion.CEA);
            Informe.SetParameterValue("Explotacion", Configuracion.Explotacion.Nombre);
            Informe.SetParameterValue("Periodo", "Período: " + txtFInicio.Text + " al " + txtFFin.Text);

            return Informe;
        }
    }
}

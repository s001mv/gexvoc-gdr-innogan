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
    public partial class InfEstadisticasFertilidad : GEXVOC.Core.Controles.ctlInforme
    {
        public InfEstadisticasFertilidad()
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

            EstadisticasFertilidad Informe = new EstadisticasFertilidad();
            EstadisticasFertilidadDS Datos = new EstadisticasFertilidadDS();

            EstadisticasFertilidadDS.EstadisticaRow EstadisticaRow = Datos.Estadistica.NewEstadisticaRow();

            List<Inseminacion> Inseminaciones = DatosInformes.UltimasInseminacionesXIntervalo(Configuracion.Explotacion.Id, Generic.ControlAInt(cmbEspecie), Inicio, Fin);
            EstadisticaRow.Inseminados = Inseminaciones.Count;
            EstadisticaRow.Gestantes = 0;

            EstadisticaRow.Primera = 0;
            EstadisticaRow.Segunda = 0;
            EstadisticaRow.Tercera = 0;
            EstadisticaRow.Mas = 0;

            EstadisticaRow.Fecundadas1 = 0;
            EstadisticaRow.Fecundadas2 = 0;
            EstadisticaRow.Fecundadas3 = 0;
            EstadisticaRow.FecundadasMas = 0;

            EstadisticaRow.Preñez = 0;

            DiagInseminacion Fecundidad = null;
            foreach (Inseminacion I in Inseminaciones)
            {
                Fecundidad = I.DiagPositivo;

                switch (I.Numero)
                {
                    case 1:
                        EstadisticaRow.Primera += 1;

                        if (Fecundidad != null)
                            EstadisticaRow.Fecundadas1 += 1;

                        break;
                    case 2:
                        EstadisticaRow.Segunda += 1;

                        if (Fecundidad != null)
                            EstadisticaRow.Fecundadas2 += 1;

                        break;
                    case 3:
                        EstadisticaRow.Tercera += 1;

                        if (Fecundidad != null)
                            EstadisticaRow.Fecundadas3 += 1;

                        break;
                    default:
                        EstadisticaRow.Mas += 1;

                        if (Fecundidad != null)
                            EstadisticaRow.FecundadasMas += 1;

                        break;
                }

                if (Fecundidad != null)
                {
                    EstadisticaRow.Gestantes += 1;

                    if (Fecundidad.DiasGestacion != null && Fecundidad.DiasGestacion <= 21)
                        EstadisticaRow.Preñez += 1;
                }
            }

            if (EstadisticaRow.Primera != 0)
                EstadisticaRow.Fecundidad1 = (EstadisticaRow.Fecundadas1 * 100) / EstadisticaRow.Primera;

            if (EstadisticaRow.Segunda != 0)
                EstadisticaRow.Fecundidad2 = (EstadisticaRow.Fecundadas2 * 100) / EstadisticaRow.Segunda;

            if (EstadisticaRow.Tercera != 0)
                EstadisticaRow.Fecundidad3 = (EstadisticaRow.Fecundadas3 * 100) / EstadisticaRow.Tercera;

            if (EstadisticaRow.Mas != 0)
                EstadisticaRow.FecundidadMas = (EstadisticaRow.FecundadasMas * 100) / EstadisticaRow.Mas;

            if (EstadisticaRow.Gestantes != 0)
                EstadisticaRow.Preñez = (EstadisticaRow.Preñez * 100) / EstadisticaRow.Gestantes;

            Fecundidad = null;

            Inseminaciones = null;

            Datos.Estadistica.AddEstadisticaRow(EstadisticaRow);

            Informe.SetDataSource(Datos);

            Informe.SetParameterValue("CEA", Configuracion.Explotacion.CEA);
            Informe.SetParameterValue("Explotacion", Configuracion.Explotacion.Nombre);
            Informe.SetParameterValue("Periodo", "Período: " + txtFInicio.Text + " al " + txtFFin.Text);

            return Informe;
        }
    }
}

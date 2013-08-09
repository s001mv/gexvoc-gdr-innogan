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
    public partial class InfRecuento : GEXVOC.Core.Controles.ctlInforme
    {
        public bool Grafico { get; set; }

        public InfRecuento()
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
                if (!Generic.ControlValorado(this.cmbAnimal, FormularioMaestro.ErrorProvider))
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
            DateTime FechaInicio = Convert.ToDateTime(txtFInicio.Text);
            DateTime FechaFin = Convert.ToDateTime(txtFFin.Text);

            Recuento Informe = new Recuento();
            RecuentoDS Datos = new RecuentoDS();

            RecuentoDS.AnimalRow AnimalRow = null;
            foreach (Animal Hembra in DatosInformes.HembrasMuestraXIntervalo((List<Animal>)this.cmbAnimal.DataSource, FechaInicio, FechaFin))
            {
                AnimalRow = Datos.Animal.NewAnimalRow();

                AnimalRow.Id = Hembra.Id;
                AnimalRow.Raza = Hembra.DescRaza;
                AnimalRow.DIB = Hembra.DIB;
                AnimalRow.Crotal = Hembra.Crotal;
                AnimalRow.Tatuaje = Hembra.Tatuaje;
                AnimalRow.Genotipo = Hembra.Genotipo;
                AnimalRow.Nombre = "Animal: " + Hembra.Nombre;
                AnimalRow.Nacimiento = Hembra.FechaNacimiento;

                Datos.Animal.AddAnimalRow(AnimalRow);

                foreach (Lactacion L in Hembra.lstLactaciones.OrderBy(L => L.Numero))
                {
                    RecuentoDS.MuestraRow MuestraRow = null;
                    foreach (ControlLeche C in L.lstControlesLeche.OrderBy(C => C.Numero))
                        if (C.lstMuestrasControl.Count == 1)
                            if (C.lstMuestrasControl[0].Fecha >= FechaInicio && C.lstMuestrasControl[0].Fecha <= FechaFin)
                            {
                                MuestraRow = Datos.Muestra.NewMuestraRow();

                                MuestraRow.IdHembra = Hembra.Id;
                                MuestraRow.Fecha = C.lstMuestrasControl[0].Fecha;
                                MuestraRow.Lactacion = L.Numero;
                                MuestraRow.Dias = C.lstMuestrasControl[0].Fecha.Subtract(L.FechaInicio).Days;
                                MuestraRow.RC = C.lstMuestrasControl[0].RctoCelular ?? 0;
                                MuestraRow.Urea = C.lstMuestrasControl[0].Urea ?? 0;

                                Datos.Muestra.AddMuestraRow(MuestraRow);
                            }
                }
            }

            Informe.SetDataSource(Datos);

            Informe.SetParameterValue("CEA", Configuracion.Explotacion.CEA);
            Informe.SetParameterValue("Explotacion", Configuracion.Explotacion.Nombre);
            Informe.SetParameterValue("Periodo", "Período: " + txtFInicio.Text + " al " + txtFFin.Text);
            Informe.SetParameterValue("Grafico", Grafico);

            return Informe;
        }
    }
}

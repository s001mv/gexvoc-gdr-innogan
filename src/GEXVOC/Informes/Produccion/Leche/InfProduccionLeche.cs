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
    public partial class InfProduccionLeche : GEXVOC.Core.Controles.ctlInforme
    {
        public InfProduccionLeche()
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
            Especie especie = Especie.Buscar((int)Generic.ControlAIntNullable(cmbEspecie));
            DateTime FechaInicio = Convert.ToDateTime(txtFInicio.Text);
            DateTime FechaFin = Convert.ToDateTime(txtFFin.Text);

            ProduccionLeche Informe = new ProduccionLeche();
            ProduccionLecheDS Datos = new ProduccionLecheDS();

            ProduccionLecheDS.AnimalRow AnimalRow = null;
            foreach (Animal Hembra in DatosInformes.HembrasLactacionXIntervalo(especie.Id, FechaInicio, FechaFin))
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

                ProduccionLecheDS.LactacionRow LactacionRow = null;
                foreach (Lactacion L in Hembra.lstLactaciones)
                    if ((L.FechaInicio <= FechaInicio && (L.FechaFin == null || L.FechaFin.Value >= FechaInicio))
                        || (L.FechaInicio <= FechaFin && (L.FechaFin == null || L.FechaFin.Value >= FechaFin))
                        || (L.FechaInicio >= FechaInicio && L.FechaInicio <= FechaFin))
                    {
                        LactacionRow = Datos.Lactacion.NewLactacionRow();

                        LactacionRow.Id = L.Id;
                        LactacionRow.IdHembra = Hembra.Id;
                        LactacionRow.Numero = L.Numero;
                        LactacionRow.Dias = (L.FechaFin ?? FechaFin).Subtract(L.FechaInicio).Days;

                        Datos.Lactacion.AddLactacionRow(LactacionRow);

                        ProduccionLecheDS.ControlRow ControlRow = null;
                        foreach (ControlLeche C in L.lstControlesLeche)
                            if (C.Fecha >= FechaInicio && C.Fecha <= FechaFin)
                            {
                                ControlRow = Datos.Control.NewControlRow();

                                ControlRow.IdLactacion = L.Id;
                                ControlRow.Fecha = C.Fecha;
                                ControlRow.Mañana = C.LecheManana ?? 0;
                                ControlRow.Tarde = C.LecheTarde ?? 0;
                                ControlRow.Noche = C.LecheNoche ?? 0;
                                ControlRow.Total = ControlRow.Mañana + ControlRow.Tarde + ControlRow.Noche;

                                LactacionRow.Mañana += ControlRow.Mañana;
                                LactacionRow.Tarde += ControlRow.Tarde;
                                LactacionRow.Noche += ControlRow.Noche;
                                LactacionRow.Total += ControlRow.Total;

                                if (C.lstMuestrasControl.Count == 1)
                                {
                                    if (C.lstMuestrasControl[0].Proteina.HasValue)
                                    {
                                        ControlRow.Proteina = C.lstMuestrasControl[0].Proteina.Value;
                                        LactacionRow.Proteina += ControlRow.Proteina;
                                    }

                                    if (C.lstMuestrasControl[0].Grasa.HasValue)
                                    {
                                        ControlRow.Grasa = C.lstMuestrasControl[0].Grasa.Value;
                                        LactacionRow.Grasa += ControlRow.Grasa;
                                    }
                                }

                                Datos.Control.AddControlRow(ControlRow);
                            }
                    }
            }

            Informe.SetDataSource(Datos);

            Informe.SetParameterValue("CEA", Configuracion.Explotacion.CEA);
            Informe.SetParameterValue("Explotacion", Configuracion.Explotacion.Nombre);
            Informe.SetParameterValue("Periodo", "Período: " + txtFInicio.Text + " al " + txtFFin.Text);

            return Informe;
        }
    }
}

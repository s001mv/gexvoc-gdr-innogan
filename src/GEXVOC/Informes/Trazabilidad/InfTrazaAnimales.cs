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
    public partial class InfTrazaAnimales : GEXVOC.Core.Controles.ctlInforme
    {
        public InfTrazaAnimales()
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
            TrazaAnimales Informe = new TrazaAnimales();
            TrazaAnimalesDS Datos = new TrazaAnimalesDS();

            TrazaAnimalesDS.AnimalRow AnimalRow = null;
            TrazaAnimalesDS.AltaRow AltaRow = null;
            TrazaAnimalesDS.BajaRow BajaRow = null;
            foreach (Animal Animal in (List<Animal>)this.cmbAnimal.DataSource)
            {
                AnimalRow = Datos.Animal.NewAnimalRow();

                AnimalRow.Id = Animal.Id;
                AnimalRow.Raza = Animal.DescRaza;
                AnimalRow.DIB = Animal.DIB;
                AnimalRow.Crotal = Animal.Crotal;
                AnimalRow.Tatuaje = Animal.Tatuaje;
                AnimalRow.Genotipo = Animal.Genotipo;
                AnimalRow.Nombre = Animal.Nombre;
                AnimalRow.Nacimiento = Animal.FechaNacimiento;

                Datos.Animal.AddAnimalRow(AnimalRow);

                AnimalRow = null;

                Alta A = Animal.AltaAnimal();

                if (A != null)
                {
                    AltaRow = Datos.Alta.NewAltaRow();

                    AltaRow.IdAnimal = Animal.Id;
                    AltaRow.Tipo = A.DescTipo;
                    AltaRow.Detalle = A.Detalle;
                    AltaRow.Fecha = A.Fecha;

                    Datos.Alta.AddAltaRow(AltaRow);

                    A = null;
                    AltaRow = null;
                }

                Baja B = Animal.BajaAnimal();

                if (B != null)
                {
                    BajaRow = Datos.Baja.NewBajaRow();

                    BajaRow.IdAnimal = Animal.Id;
                    BajaRow.Tipo = B.DescTipo;
                    BajaRow.Detalle = B.Detalle;
                    BajaRow.Fecha = B.Fecha;

                    Datos.Baja.AddBajaRow(BajaRow);

                    B = null;
                    BajaRow = null;
                }

                LoteAnimal Lote = null;
                TrazaAnimalesDS.LoteRow LoteRow = null;
                TrazaAnimalesDS.AniLotRow AniLotRow = null;
                foreach (AniLot AL in Animal.lstAniLot)
                {
                    Lote = LoteAnimal.Buscar(AL.IdLote);

                    if (Lote != null)
                    {
                        if (!Datos.Lote.Rows.Contains(Lote.Id))
                        {
                            LoteRow = Datos.Lote.NewLoteRow();

                            LoteRow.Id = Lote.Id;
                            LoteRow.Tipo = "(" + Lote.DescTipo + ")";
                            LoteRow.Descripcion = Lote.Descripcion;

                            Datos.Lote.AddLoteRow(LoteRow);

                            LoteRow = null;
                        }

                        Lote = null;

                        AniLotRow = Datos.AniLot.NewAniLotRow();

                        AniLotRow.IdLote = AL.IdLote;
                        AniLotRow.IdAnimal = AL.IdAnimal;
                        AniLotRow.Inicio = AL.FechaInicio;

                        if (AL.FechaFin.HasValue)
                            AniLotRow.Fin = AL.FechaFin.Value;

                        Datos.AniLot.AddAniLotRow(AniLotRow);

                        AniLotRow = null;

                        TrazaAnimalesDS.PastoreoRow PastoreoRow = null;
                        foreach (Pastoreo P in Pastoreo.BuscarXIntervalo(null, AL.IdLote, AL.FechaInicio, AL.FechaFin))
                        {
                            PastoreoRow = Datos.Pastoreo.NewPastoreoRow();

                            PastoreoRow.IdLote = AL.IdLote;
                            PastoreoRow.IdAnimal = AL.IdAnimal;
                            PastoreoRow.Parcela = P.DescParcela;

                            PastoreoRow.Inicio = AL.FechaInicio;

                            if (P.FechaInicio > AL.FechaInicio)
                                PastoreoRow.Inicio = P.FechaInicio;

                            if (AL.FechaFin.HasValue)
                                PastoreoRow.Fin = AL.FechaFin.Value;

                            if ((P.FechaFin.HasValue && !AL.FechaFin.HasValue)
                                || (P.FechaFin.HasValue && AL.FechaFin.HasValue && P.FechaFin.Value < AL.FechaFin.Value))
                                PastoreoRow.Fin = P.FechaFin.Value;

                            Datos.Pastoreo.AddPastoreoRow(PastoreoRow);
                        }

                        PastoreoRow = null;
                    }
                }
            }

            Informe.SetDataSource(Datos);
            Informe.SetParameterValue("CEA", Configuracion.Explotacion.CEA);
            Informe.SetParameterValue("Explotacion", Configuracion.Explotacion.Nombre);

            return Informe;
        }
    }
}

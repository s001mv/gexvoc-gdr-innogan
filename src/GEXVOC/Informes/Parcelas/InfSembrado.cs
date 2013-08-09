using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Informes;
using GEXVOC.Core.Logic;
using GEXVOC.UI;

namespace GEXVOC.Informes
{
    public partial class InfSembrado : GEXVOC.Core.Controles.ctlInforme
    {
        public InfSembrado()
        {
            InitializeComponent();      
        }

        public GenericMaestro FormularioMaestro
        {
            get { return ((GenericMaestro)this.FormularioInformes); }
        }

        /// <summary>
        /// Carga los controles con sus contenidos iniciales, combos etc...
        /// </summary>
        public override void  CargaControles()
        {
            if (FormularioMaestro != null)
                FormularioMaestro.CargarCombo(this.cmbParcela, "Nombre", Parcela.Buscar());
          
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
            UI.GenericMaestro frmMaestro = ((GEXVOC.UI.GenericMaestro)FormularioInformes);

            if (frmMaestro!=null)
            {
                if (!Generic.ControlDatosCorrectos(this.txtFInicio, frmMaestro.ErrorProvider, typeof(System.DateTime), false))
                    rtno = false;
                if (!Generic.ControlDatosCorrectos(this.txtFFin, frmMaestro.ErrorProvider, typeof(System.DateTime), false))
                    rtno = false;
            }             

            return rtno;
        }

        /// <summary>
        /// Es el método que genera un objeto del tipo ReportDocument
        /// Generera un ReportDocument concreto valiéndonos para ello de la información del resto de los controles
        /// Aqui se cargan tambien los datos en el informe tal que el elemento devuelto por este procedimiento
        /// es ya un informe ya completo y preparado para ser mostrado al usuario.
        /// </summary>
        /// <returns></returns>
        public override CrystalDecisions.CrystalReports.Engine.ReportDocument Generar()
        {
            Sembrados Informe = new Sembrados();
            SembradosDS Datos = new SembradosDS();

            string Titular = string.Empty;
            string DNI = string.Empty;

            foreach (Parcela P in Parcela.Buscar(Generic.ControlAIntNullable(cmbParcela), null, string.Empty, string.Empty, null))
            {
                if (Titular.IndexOf(P.DescTitular) == -1)
                {
                    if (Titular.Length > 0)
                        Titular += "/";

                    Titular += P.DescTitular;
                }

                if (DNI.IndexOf(P.DescDNITitular) == -1)
                {
                    if (DNI.Length > 0)
                        DNI += "/";

                    DNI += P.DescDNITitular;
                }

                SembradosDS.ParcelaRow ParcelaRow = Datos.Parcela.NewParcelaRow();

                ParcelaRow.Id = P.Id;
                ParcelaRow.Nombre = P.Nombre;
                ParcelaRow.Poligono = P.Poligono;
                ParcelaRow.Extension = P.Extension;

                Datos.Parcela.AddParcelaRow(ParcelaRow);

                SembradosDS.SiembraRow SiembraRow = null;
                foreach (Siembra S in Siembra.Buscar(null, P.Id, null, Generic.ControlADatetimeNullable(txtFInicio), Generic.ControlADatetimeNullable(txtFFin)))
                {
                    SiembraRow = Datos.Siembra.NewSiembraRow();

                    SiembraRow.IdParcela = P.Id;
                    SiembraRow.Semilla = S.DescSemilla;
                    SiembraRow.Cantidad = S.Cantidad;
                    SiembraRow.Fecha = S.Fecha;

                    Datos.Siembra.AddSiembraRow(SiembraRow);
                }
            }

            Informe.SetDataSource(Datos);

            Informe.SetParameterValue("Titular", Titular);
            Informe.SetParameterValue("DNI", DNI);
            Informe.SetParameterValue("Periodo", "Período: " + txtFInicio.Text + " al " + txtFFin.Text);

            return Informe;
        }
    }
}

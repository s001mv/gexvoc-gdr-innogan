using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Informes;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;

namespace GEXVOC.UI
{
    public partial class infArbolInformes : GenericInf
    {
        public infArbolInformes()
        {
            InitializeComponent();
            this.trvInformes.ExpandAll();
        }

        private void trvInformes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.lblInformeLanzar.Text= trvInformes.SelectedNode.FullPath.ToUpper();
            switch (trvInformes.SelectedNode.FullPath)
            {
                case "Gestión de fincas\\Abonados":
                    //this.Filtros.Controls.Add(new Informes.InfAbonado());
                    this.Informe = new Informes.InfAbonado();
                    this.Informe.FormularioInformes = this;

                    break;
                case "Alimentación\\Consumo y Producción":
                    this.Informe = new Informes.InfConsumos();
                    this.Informe.FormularioInformes = this;

                    break;

                default:
                    this.Informe = null;
                    this.Filtros.Controls.Clear();
                    break;
            }
        }

        //protected override void CargarCombos()
        //{
        //    this.CargarCombo(this.cmbParcela, "Nombre", Parcela.Buscar());
        //    base.CargarCombos();
        //}

        //protected override bool Validar()
        //{
        //    Boolean rtno = true;

        //    if (!Generic.ControlDatosCorrectos(this.txtFInicio, this.ErrorProvider, "El valor introducido no es del tipo fecha", typeof(System.DateTime), false))
        //        rtno = false;
        //    if (!Generic.ControlDatosCorrectos(this.txtFFin, this.ErrorProvider, "El valor introducido no es del tipo fecha", typeof(System.DateTime), false))
        //        rtno = false;


        //    return rtno;
        //}
        GEXVOC.Core.Controles.ctlInforme _Informe = null;
        public GEXVOC.Core.Controles.ctlInforme Informe
        {
            get { return _Informe; }
            set {
                if (value!=null)
                {
                    value.Location = new Point(1, 12);
                    this.Filtros.Controls.Add(value);                    
                }
                
                _Informe = value; 
            }
        }


        protected override void Generar()
        {         
                rptVisor.ReportSource = Informe.Generar();
                rptVisor.Zoom(80);//Establezo el zoom maximo para que no salga el scroll horizontal en un informe con orientacion
                //de página en vertical (los mas comunes), hago un poco mas pequeño el informe.
                       
         }
        protected override bool Validar()
        {
            bool rtno = true;

            if (Informe != null)
                rtno = Informe.Validar();
            else
            {
                Generic.AvisoInformation("No se encuentra cargado ningún elemento del tipo ctlInforme, el proceso no continuará");
                rtno = false;
            }
            
            return rtno;
        }

        private void infArbolInformes_Load(object sender, EventArgs e)
        {

        }
    }
}

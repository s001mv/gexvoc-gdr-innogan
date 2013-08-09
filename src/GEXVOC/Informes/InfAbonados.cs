using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Informes;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;



namespace GEXVOC.UI
{
    public partial class InfAbonados : GEXVOC.UI.GenericInf
    {
        public InfAbonados()
        {
            InitializeComponent();
        }
        protected override void Generar()
        {
            Abonados rpt = new Abonados();


            //rpt.FileName = Configuracion.Parametros["RutaInformes"] + "Abonados.rpt";
            //a

            //rpt.SetDataSource(Informe);
            AbonadosDS datos= new AbonadosDS();


            datos.Cabecera.AddCabeceraRow("Gomt Lozano, Entir/Perez Mirt, Suld/Gomt Lozano, Entir/Perez Mirt, Suld/Anton Gomez", "0000000L", Convert.ToDateTime("01/01/08"), Convert.ToDateTime("31/12/08"));
            //datos.Cabecera.AddCabeceraRow("Perez Mirt, Sl", "11111111H", Convert.ToDateTime("01/01/08"), Convert.ToDateTime("31/12/08"));

            

            foreach (Parcela item in Parcela.Buscar(Generic.ControlAIntNullable(cmbParcela),null,string.Empty,string.Empty,null))
            {
                AbonadosDS.FincasRow fila = datos.Fincas.NewFincasRow();
                fila.IdFinca = item.Id;
                fila.Finca = item.Nombre;
                fila.Poligono = item.Poligono;
                fila.Parcela = string.Empty;
                fila.Tamaño = item.Extension;



                datos.Fincas.AddFincasRow(fila);


                foreach (Abonado item2 in Abonado.Buscar(null, item.Id, null, Generic.ControlADatetimeNullable(txtFInicio), Generic.ControlADatetimeNullable(txtFFin)))
                {
                    datos.Abonados.AddAbonadosRow(fila, item2.DescAbono, item2.Cantidad, item2.Fecha);
                }
                               
            }



            rpt.SetDataSource(datos);

            
            rptVisor.ReportSource = rpt;


           base.Generar();
        }

        protected override void CargarCombos()
        {
            this.CargarCombo(this.cmbParcela,"Nombre",Parcela.Buscar());
            base.CargarCombos();
        }

        protected override bool Validar()
        {
            Boolean rtno=true;

            if (!Generic.ControlDatosCorrectos(this.txtFInicio, this.ErrorProvider, "El valor introducido no es del tipo fecha", typeof(System.DateTime), false))
                rtno = false;
            if (!Generic.ControlDatosCorrectos(this.txtFFin, this.ErrorProvider, "El valor introducido no es del tipo fecha", typeof(System.DateTime), false))
                rtno = false;


            return rtno;
        }

    }
   
}

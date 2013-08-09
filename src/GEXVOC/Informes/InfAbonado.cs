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
    public partial class InfAbonado : GEXVOC.Core.Controles.ctlInforme
    {
        public InfAbonado()
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
            if (FormularioMaestro!=null)
            {
                FormularioMaestro.CargarCombo(this.cmbParcela, "Nombre", Parcela.Buscar());                
            }
             
         
          
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

            Abonados rpt = new Abonados();
                                    
            AbonadosDS datos = new AbonadosDS();

            string NombreTitular = string.Empty;
            string DNI  =string.Empty;
           
            
            foreach (Parcela item in Parcela.Buscar(Generic.ControlAIntNullable(cmbParcela), null, string.Empty, string.Empty, null))
            {
                if (NombreTitular.IndexOf(item.DescTitular)==-1)                
                    NombreTitular += item.DescTitular + "/";
                
                if (DNI.IndexOf(item.DescDNITitular) == -1)                
                    DNI += item.DescDNITitular + "/";
                
                AbonadosDS.FincasRow fila = datos.Fincas.NewFincasRow();
                fila.IdFinca = item.Id;
                fila.Finca = item.Nombre;
                fila.Poligono = item.Poligono;
                fila.Parcela = string.Empty;
                fila.Tamaño = item.Extension;


                //Añadimos los datos a la tabla AbonadosDS.Fincas
                datos.Fincas.AddFincasRow(fila);

                
                foreach (Abonado item2 in Abonado.Buscar(null, item.Id, null, Generic.ControlADatetimeNullable(txtFInicio), Generic.ControlADatetimeNullable(txtFFin)))
                {
                    //Añadimos los datos a la tabla AbonadosDS.Abonados
                    datos.Abonados.AddAbonadosRow(fila, item2.DescAbono, item2.Cantidad, item2.Fecha);
                }
            }

            //Añadimos los datos a la tabla AbonadosDS.Cabecera
            datos.Cabecera.AddCabeceraRow(NombreTitular.TrimEnd(new char[]{Convert.ToChar("/")}), DNI.TrimEnd(Convert.ToChar("/")), Convert.ToDateTime("1/1/1"), Convert.ToDateTime("1/1/1"));
            

            rpt.SetDataSource(datos);       

            return rpt;
        }

     
    
    }

    
    
   

}

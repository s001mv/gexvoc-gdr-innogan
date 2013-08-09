using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using GEXVOC.UI;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Informes;

namespace GEXVOC.Informes
{
    public partial class InfTrazaProductos : GEXVOC.Core.Controles.ctlInforme
    {
        public InfTrazaProductos()
        {
            InitializeComponent();          
        }

        public GenericMaestro FormularioMaestro
        {
            get { return ((GenericMaestro)this.FormularioInformes); }
        }
 
        public override bool Validar()
        {
            bool rtno = true;

            if (FormularioMaestro != null)
            {
                if (!Generic.ControlDatosCorrectos(this.txtFInicio, FormularioMaestro.ErrorProvider, typeof(System.DateTime), true))
                    rtno = false;

                if (!Generic.ControlDatosCorrectos(this.txtFFin, FormularioMaestro.ErrorProvider, typeof(System.DateTime), true))
                    rtno = false;

                if (!Generic.ControlValorado(cmbProducto, FormularioMaestro.ErrorProvider))
                    rtno = false;
            }            

            return rtno;
        }

        public override void CargaControles()
        {
            if (FormularioMaestro != null)
                FormularioMaestro.CargarCombo(cmbTipoProducto, "Descripcion", "Id", TipoProducto.Buscar());

            base.CargaControles();
        }

        private void cmbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            if (FormularioMaestro != null)
            {
                if (this.cmbTipoProducto.SelectedValue != null)
                    FormularioMaestro.CargarCombo(cmbProducto, Core.Logic.Producto.Buscar((int)this.cmbTipoProducto.SelectedValue, null, string.Empty, null, null, null), true);
                else
                    FormularioMaestro.CargarCombo(cmbProducto, null);
            }
        }

        public override CrystalDecisions.CrystalReports.Engine.ReportDocument Generar()
        {
            TrazaProductos Informe = new TrazaProductos();
            TrazaProductosDS Datos = new TrazaProductosDS();

            DateTime Inicio = Convert.ToDateTime(txtFInicio.Text);
            DateTime Fin = Convert.ToDateTime(txtFFin.Text).AddDays(1).AddSeconds(-1);

            Producto P = (Producto)cmbProducto.SelectedItem;

            TrazaProductosDS.ProductoRow ProductoRow = Datos.Producto.NewProductoRow();
            ProductoRow.Id = P.Id;
            ProductoRow.Familia = P.DescFamilia;
            ProductoRow.Descripcion = P.Descripcion;

            Stock S = Stock.BuscarProducto(P.Id);

            if (S != null)
                ProductoRow.Stock = S.Cantidad;
            else
                ProductoRow.Stock = Decimal.Zero;

            S = null;

            ProductoRow.Compra = 0;

            foreach (Compra C in Compra.Buscar(null, null, P.Id, null, null, string.Empty, null, null, null, null, null))
                if (C.Fecha >= Inicio && C.Fecha <= Fin)
                    if (C.Cantidad != null)
                        ProductoRow.Compra += C.Cantidad.Value;

            ProductoRow.Venta = 0;

            foreach (Venta V in Venta.Buscar(null, null, P.Id, null, string.Empty, null, null, null, null, null))
                if (V.Fecha >= Inicio && V.Fecha <= Fin)
                    if (V.Cantidad != null)
                        ProductoRow.Venta += V.Cantidad.Value;

            Datos.Producto.AddProductoRow(ProductoRow);

            ProductoRow = null;

            TrazaProductosDS.ProcesoRow ProcesoRow = null;
            foreach (Plantilla Proceso in Plantilla.Buscar(P.Id, Inicio, Fin))
            {
                ProcesoRow = Datos.Proceso.NewProcesoRow();

                ProcesoRow.Id = Proceso.Id;
                ProcesoRow.IdProducto = P.Id;
                ProcesoRow.Descripcion = Proceso.Descripcion;

                Datos.Proceso.AddProcesoRow(ProcesoRow);

                TrazaProductosDS.EjecucionRow EjecucionRow = null;
                foreach (Ejecucion E in Proceso.lstEjecuciones)
                    if (E.Fecha >= Inicio && E.Fecha <= Fin && Plantilla.TieneProductoImplicado(Proceso.Id, P.Id, E.Fecha))
                    {
                        EjecucionRow = Datos.Ejecucion.NewEjecucionRow();

                        EjecucionRow.Id = E.Id;
                        EjecucionRow.IdProceso = E.IdPlantilla;
                        EjecucionRow.Fecha = E.Fecha;

                        Datos.Ejecucion.AddEjecucionRow(EjecucionRow);

                        EjecucionRow = null;

                        TrazaProductosDS.EntradaRow EntradaRow = null;
                        foreach (Transformacion T in Transformacion.Buscar(Proceso.Id, null, E.Fecha, 'E'))
                        {
                            EntradaRow = Datos.Entrada.NewEntradaRow();

                            EntradaRow.IdEjecucion = E.Id;
                            EntradaRow.Producto = T.Producto.Descripcion;
                            EntradaRow.Cantidad = T.Cantidad;

                            Datos.Entrada.AddEntradaRow(EntradaRow);
                        }

                        EntradaRow = null;

                        TrazaProductosDS.SalidaRow SalidaRow = null;
                        foreach (Transformacion T in Transformacion.Buscar(Proceso.Id, null, E.Fecha, 'S'))
                        {
                            SalidaRow = Datos.Salida.NewSalidaRow();

                            SalidaRow.IdEjecucion = E.Id;
                            SalidaRow.Producto = T.DescProducto;
                            SalidaRow.Cantidad = T.Cantidad;

                            Datos.Salida.AddSalidaRow(SalidaRow);
                        }

                        SalidaRow = null;

                        TrazaProductosDS.EmpleadoRow EmpleadoRow = null;
                        foreach (PlaVet PV in PlaVet.Buscar(Proceso.Id, E.Fecha))
                        {
                            EmpleadoRow = Datos.Empleado.NewEmpleadoRow();

                            EmpleadoRow.IdEjecucion = E.Id;
                            EmpleadoRow.Nombre = PV.DescEmpleado;
                            
                            Datos.Empleado.AddEmpleadoRow(EmpleadoRow);
                        }

                        EmpleadoRow = null;

                        TrazaProductosDS.ZonaRow ZonaRow = null;
                        foreach (PlaZon PZ in PlaZon.Buscar(Proceso.Id, E.Fecha))
                        {
                            ZonaRow = Datos.Zona.NewZonaRow();

                            ZonaRow.IdEjecucion = E.Id;
                            ZonaRow.Descripcion = PZ.DescZona;

                            Datos.Zona.AddZonaRow(ZonaRow);
                        }

                        ZonaRow = null;

                        TrazaProductosDS.MaquinaRow MaquinaRow = null;
                        foreach (PlaMaq PM in PlaMaq.Buscar(Proceso.Id, E.Fecha))
                        {
                            MaquinaRow = Datos.Maquina.NewMaquinaRow();

                            MaquinaRow.IdEjecucion = E.Id;
                            MaquinaRow.Descripcion = PM.DescMaquina;

                            Datos.Maquina.AddMaquinaRow(MaquinaRow);
                        }

                        MaquinaRow = null;
                    }
            }

            ProcesoRow = null;
            P = null;

            Informe.SetDataSource(Datos);
            Informe.SetParameterValue("Periodo", "Período: " + txtFInicio.Text + " al " + txtFFin.Text);
            Informe.SetParameterValue("CEA", Configuracion.Explotacion.CEA);
            Informe.SetParameterValue("Explotacion", Configuracion.Explotacion.Nombre);

            return Informe;
        }
    }
}

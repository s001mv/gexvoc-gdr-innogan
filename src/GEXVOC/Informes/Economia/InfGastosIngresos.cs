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
    public partial class InfGastosIngresos : GEXVOC.Core.Controles.ctlInforme
    {
        public InfGastosIngresos()
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

        public override bool Validar()
        {
            bool rtno = true;

            if (FormularioMaestro != null)
            {
                if (!Generic.ControlDatosCorrectos(this.txtFInicio, FormularioMaestro.ErrorProvider, typeof(System.DateTime), this.txtFFin.ControlValorado))
                    rtno = false;

                if (!Generic.ControlDatosCorrectos(this.txtFFin, FormularioMaestro.ErrorProvider, typeof(System.DateTime), this.txtFInicio.ControlValorado))
                    rtno = false;
            }

            return rtno;
        }

        public override CrystalDecisions.CrystalReports.Engine.ReportDocument Generar()
        {
            GastosIngresos Informe = new GastosIngresos();
            GastosIngresosDS Datos = new GastosIngresosDS();

            DateTime? Inicio = this.txtFInicio.Value;
            DateTime? Fin = this.txtFFin.Value;
            int? IdTipo = null;
            int? IdProducto = null;

            if (cmbProducto.SelectedItem != null)
                IdProducto = ((Producto)cmbProducto.SelectedItem).Id;
            else if (cmbTipoProducto.SelectedItem != null)
                IdTipo = ((TipoProducto)cmbTipoProducto.SelectedItem).Id;

            GastosIngresosDS.ExplotacionRow ExplotacionRow = Datos.Explotacion.NewExplotacionRow();

            ExplotacionRow.Id = Configuracion.Explotacion.Id;
            ExplotacionRow.CEA = Configuracion.Explotacion.CEA;
            ExplotacionRow.Nombre = Configuracion.Explotacion.Nombre;
            ExplotacionRow.Ventas = decimal.Zero;
            ExplotacionRow.Compras = decimal.Zero;
            ExplotacionRow.Gastos = decimal.Zero;

            Datos.Explotacion.AddExplotacionRow(ExplotacionRow);

            GastosIngresosDS.VentaRow VentaRow = null;
            foreach (Venta V in Venta.Buscar(Configuracion.Explotacion.Id, IdTipo, IdProducto,
                null, string.Empty, null, Inicio, Fin, null, true))
            {
                VentaRow = Datos.Venta.NewVentaRow();

                VentaRow.IdExplotacion = Configuracion.Explotacion.Id;

                if (V.IdClasificacion.HasValue)
                    VentaRow.Clasificacion = TipoVenta.Buscar(V.IdClasificacion.Value).Descripcion;

                if (V.IdProducto.HasValue)
                    VentaRow.Producto = Producto.Buscar(V.IdProducto.Value).Descripcion;

                if (V.IdCliente.HasValue)
                    VentaRow.Cliente = Cliente.Buscar(V.IdCliente.Value).Nombre;

                //if (V.Cantidad.HasValue)
                //{
                //    VentaRow.Cantidad = V.Cantidad.Value;
                //    VentaRow.Total = V.Cantidad.Value * V.Importe;
                //}
                //else
                //    VentaRow.Total = V.Importe;

                VentaRow.Cantidad = V.Cantidad.Value;
                VentaRow.Total = V.Importe;

                VentaRow.Concepto = V.Concepto;
                VentaRow.Fecha = V.Fecha;
                VentaRow.Importe = V.Importe;

                Datos.Venta.AddVentaRow(VentaRow);

                ExplotacionRow.Ventas += VentaRow.Total;
            }

            GastosIngresosDS.CompraRow CompraRow = null;
            foreach (Compra C in Compra.Buscar(Configuracion.Explotacion.Id, IdTipo, IdProducto,
                null, null, string.Empty, null, Inicio, Fin, null, true))
            {
                CompraRow = Datos.Compra.NewCompraRow();

                CompraRow.IdExplotacion = Configuracion.Explotacion.Id;

                if (C.IdClasificacion.HasValue)
                    CompraRow.Clasificacion = TipoCompra.Buscar(C.IdClasificacion.Value).Descripcion;

                if (C.IdProducto.HasValue)
                    CompraRow.Producto = Producto.Buscar(C.IdProducto.Value).Descripcion;

                if (C.IdMacho.HasValue)
                    CompraRow.Producto += ": " + Animal.Buscar(C.IdMacho.Value).Nombre;

                if (C.IdProveedor.HasValue)
                    CompraRow.Proveedor = Proveedor.Buscar(C.IdProveedor.Value).Nombre;

                //if (C.Cantidad.HasValue)
                //{
                //    CompraRow.Cantidad = C.Cantidad.Value;
                //    CompraRow.Total = C.Cantidad.Value * C.Importe;
                //}
                //else
                //    CompraRow.Total = C.Importe;
                
                CompraRow.Cantidad = C.Cantidad.Value;
                CompraRow.Importe = C.Importe;

                CompraRow.Concepto = C.Concepto;
                CompraRow.Fecha = C.Fecha;
                CompraRow.Total = C.Importe;
       

                Datos.Compra.AddCompraRow(CompraRow);

                ExplotacionRow.Compras += CompraRow.Total;
            }

            if (!IdTipo.HasValue && !IdProducto.HasValue)
            {
                GastosIngresosDS.GastoRow GastoRow = null;
                foreach (Gasto G in Gasto.Buscar(null, Configuracion.Explotacion.Id, null, null, null, null, null,
                    null, null, null, string.Empty, Inicio, Fin, null, null, null))
                {
                    GastoRow = Datos.Gasto.NewGastoRow();

                    GastoRow.IdExplotacion = Configuracion.Explotacion.Id;
                    GastoRow.Detalle = string.Empty;

                    if (G.IdAnimal.HasValue)
                        GastoRow.Detalle = Animal.Buscar(G.IdAnimal.Value).Nombre;
                    else if (G.IdParcela.HasValue)
                        GastoRow.Detalle = Parcela.Buscar(G.IdParcela.Value).Nombre;

                    GastoRow.Naturaleza = Naturaleza.Buscar(G.IdNaturaleza).Descripcion;

                    if (!string.IsNullOrEmpty(G.Detalle))
                        GastoRow.Detalle += ": " + G.Detalle;

                    GastoRow.Fecha = G.Fecha;
                    GastoRow.Importe = G.Importe;
                    GastoRow.Total = G.Total;

                    Datos.Gasto.AddGastoRow(GastoRow);

                    ExplotacionRow.Gastos += GastoRow.Total;
                }
            }

            ExplotacionRow.Balance = ExplotacionRow.Ventas - (ExplotacionRow.Compras + ExplotacionRow.Gastos);

            Informe.SetDataSource(Datos);

            if (this.txtFInicio.ControlValorado && this.txtFFin.ControlValorado)
                Informe.SetParameterValue("Periodo", "Período: " + txtFInicio.Text + " al " + txtFFin.Text);
            else
                Informe.SetParameterValue("Periodo", string.Empty);

            return Informe;
        }
    }
}

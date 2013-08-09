using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;

namespace GEXVOC.UI
{
    public partial class EditRegularizacionStock : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditRegularizacionStock()
        {
            InitializeComponent();
        }
       
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        //public RegularizacionStock ObjetoBase { get { return (RegularizacionStock)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
        
        protected override void Guardar()
        {
            if (Validar())
            {
                BD.IniciarBDOperaciones();
                try
                {
                    foreach (ListViewItem item in lstStock.CheckedItems)
                    {
                        Stock stockRegularizar = (Stock)item.Tag;
                        if (stockRegularizar.Cantidad < 0)
                            Movimiento.CrearMovimiento(TiposMovimientos.REGULARIZACION, stockRegularizar.IdProducto, stockRegularizar.IdMacho, stockRegularizar.Cantidad * -1, null, null,DateTime.Today);

                    }
                    BD.FinalizarBDOperaciones();
                    this.CargarStock();
                    Generic.AvisoInformation("El proceso de regularización ha concluído con éxito");

                }
                catch (LogicException ex)
                {
                    Generic.AvisoInformation("Se ha producido un error en la regularización del stock, Detalles: " + ex.Message);
                }
                catch (Exception)
                {
                    Generic.AvisoError("Se ha producido un error en la regularización del stock");
                }
                finally
                { BD.FinalizarBDOperaciones(); }

                
            }

           
        }

        ////protected override void ClaseBaseAControles()
        ////{
        ////    Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
        ////}

        ////protected override void ControlesAClaseBase()
        ////{

        ////    Generic.ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
        ////}



        /////// <summary>
        /////// Validación de los Controles, se produce antes de actualizar la ClaseBase.
        /////// </summary>
        /////// <returns>Controles válidos (Si/No)</returns>
        protected override bool Validar()
        {
            bool Rtno = true;
            this.ErrorProvider.Clear();
            if (lstStock.CheckedItems == null || lstStock.CheckedItems.Count == 0)
            {
                Rtno = false;
                Generic.PonerError(this.ErrorProvider, lstStock, "Es necesario que exista algún elemento marcado para realizar la regularización.");
            }



            return Rtno;

        }

        #endregion

        #region CARGAS COMUNES
            public override void Cargar()
            {
                base.Cargar();
                this.CargarStock();
                btnGuardar.Text = "Regularizar";
            }
            private void CargarStock()
            {
                this.ErrorProvider.Clear();
                lstStock.Items.Clear();
                foreach (Stock stock in Stock.Buscar())
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = stock;
                    item.Text = stock.DescTipoProducto;
                    item.SubItems.Add(stock.DescProducto);
                    item.SubItems.Add(stock.Precio.ToString());
                    item.SubItems.Add(stock.Cantidad.ToString());
                    if (stock.Cantidad < 0)
                    {
                        item.Checked = true;
                        item.ForeColor = Color.Red;
                    }
                    lstStock.Items.Add(item);
                    
                }
            }
            private void btnRecargar_Click(object sender, EventArgs e)
            {
                this.CargarStock();
            }
        #endregion
    }
}
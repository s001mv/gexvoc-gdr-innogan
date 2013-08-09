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
    public partial class EditCuentas : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
            public EditCuentas()
            {
                InitializeComponent();
            }
            public EditCuentas(Modo modo, Cuenta ClaseBase)
                : base(modo, ClaseBase)
            {
                InitializeComponent();            
               
            }      

        #endregion         

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            public Cuenta ObjetoBase { get { return (Cuenta)this.ClaseBase; } }
            int? _ValorFijoIdTitular = null;
            /// <summary>
            /// Propiedad que nos indica si el formulario debe aparecer con el combo del titular fijo y con el titular que corresponde 
            /// con el Id especificado aqui.
            /// </summary>
            public int? ValorFijoIdTitular
            {
                get { return _ValorFijoIdTitular; }
                set
                {
                    if (value != null)
                    {
                        this.cmbTitular.ClaseActiva = Titular.Buscar((int)value);
                        this.cmbTitular.ReadOnly = true;
                    }
                    else
                        this.cmbTitular.ReadOnly = false;

                    _ValorFijoIdTitular = value;
                }
            }
        
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {

                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTitular", true, cmbTitular, lblTitular));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Numero", true, txtCuenta, lblCuenta));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Banco", false, txtBanco, lblBanco));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Sucursal", false, txtSucursal, lblSucursal));
                base.DefinirListaBinding();
            }
            private void EditCuentas_PropiedadAControl(object sender, PropiedadBindEventArgs e)
            {
                if (e.Control == this.cmbTitular)
                {
                     this.cmbTitular.ClaseActiva = Titular.Buscar(this.ObjetoBase.IdTitular);
                     e.Cancelar = true;
                }

            }
        #endregion

        #region FUNCIONAMIENTO GENERAL

            private void btnBuscarTitular_Click(object sender, EventArgs e)
            {               
                this.LanzarFormularioConsulta(new FindTitulares(Modo.Consultar, this.cmbTitular));
            }

        #endregion
         
    }
}


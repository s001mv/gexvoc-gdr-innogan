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
    public partial class EditEngrasamientoCanal : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditEngrasamientoCanal()
        {
            InitializeComponent();
        }
        public EditEngrasamientoCanal(Modo modo, EngrasamientoCanal ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            public EngrasamientoCanal ObjetoBase { get { return (EngrasamientoCanal)this.ClaseBase; } }
        #endregion            

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

            protected override void DefinirListaBinding()
        {
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdAnimal", true, this.cmbAnimal, lblAnimal));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTipo", true, this.cmbTipo, lblTipo));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, this.txtFecha, lblFecha));

            base.DefinirListaBinding();
        }

            private void EditEngrasamientoCanal_PropiedadAControl(object sender, PropiedadBindEventArgs e)
            {
                if (e.Control == cmbAnimal)
                    cmbAnimal.ClaseActiva = Animal.Buscar(this.ObjetoBase.IdAnimal);
                    
                
            }


       

        #endregion

        #region CARGAS COMUNES

            protected override void CargarCombos()
            {
                cmbTipo.CargarCombo();
            }
            protected override void CargarValoresDefecto()
            {
                Generic.DatetimeAControl(txtFecha, DateTime.Today);
                base.CargarValoresDefecto();
            }
        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarAnimal_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbAnimal));
            }


        #endregion

        #region COMBOS

            private void cmbTipo_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbTipo, TipoEngrasamiento.Buscar());      
            }
            private void cmbTipo_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                
                TipoEngrasamiento ObjetoBase = new TipoEngrasamiento();
                EditTipoEngrasamiento editTipoEngrasamiento = new EditTipoEngrasamiento(Modo.Guardar, ObjetoBase);
                editTipoEngrasamiento.Descripcion = e.TextoCrear;

                CrearNuevoElementoCombo(editTipoEngrasamiento, sender);
                
            }

  
        #endregion


    }
}
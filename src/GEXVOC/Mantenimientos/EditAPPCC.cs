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
    public partial class EditAPPCC : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditAPPCC()
        {
            InitializeComponent();
        }
        public EditAPPCC(Modo modo, APPCC ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public APPCC ObjetoBase { get { return (APPCC)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)


        protected override void DefinirListaBinding()
        {
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdPlantilla", true, this.cmbProceso, lblProceso));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fase", false, this.txtFase, lblFase));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Peligro", true, this.txtPeligro, lblPeligro));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Prevencion", true, this.txtPrevencion, lblPrevencion));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "LimiteCritico", true, this.txtLimiteCritico, lblLimiteCritico));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Vigilancia", true, this.txtVigilancia, lblVigilancia));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Frecuencia", true, this.txtFrecuencia, lblFrecuencia));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Correccion", true, this.txtCorrecion, lblCorreccion));

            base.DefinirListaBinding();
        }

        //protected override void ClaseBaseAControles()
        //{
        //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
        //}

        //protected override void ControlesAClaseBase()
        //{

        //    Generic.ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
        //}



        ///// <summary>
        ///// Validación de los Controles, se produce antes de actualizar la ClaseBase.
        ///// </summary>
        ///// <returns>Controles válidos (Si/No)</returns>
        //protected override bool Validar()
        //{
        //    bool Rtno = true;
        //    this.ErrorProvider.Clear();
        //    if (!Generic.ControlValorado(new Control[] { txtDescripcion }, this.ErrorProvider))
        //        Rtno = false;


        //    return Rtno;

        //}

        #endregion

        #region CARGAS COMUNES

        /// <summary>
        /// Carga el combo del formulario.
        /// </summary>
        protected override void CargarCombos()
        {
            cmbProceso.CargarCombo();
        }

        #endregion

        #region COMBOS
            private void cmbProceso_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                
                Plantilla ObjetoBase = new Plantilla();
                EditPlantilla editPlantilla = new EditPlantilla(Modo.Guardar, ObjetoBase);
                editPlantilla.Descripcion = e.TextoCrear;

                CrearNuevoElementoCombo(editPlantilla, sender);
                
            }

            private void cmbProceso_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbProceso, Plantilla.Buscar());
            }

        #endregion


    }
}
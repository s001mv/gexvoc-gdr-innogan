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
    public partial class EditMarcador : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditMarcador()
        {
            InitializeComponent();
        }
        public EditMarcador(Modo modo, Marcador ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Marcador ObjetoBase { get { return (Marcador)this.ClaseBase; } }
        public string Marcador { get { return txtMarcador.Text; } set { txtMarcador.Text = value; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

        protected override void DefinirListaBinding()
        {
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTipo", true, cmbTipoAnalisis, lblTipoAnalisis));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdEspecie", true, cmbEspecie, lblEspecie));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Marcador1", true, txtMarcador, lblMarcador));
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

        protected override void CargarCombos()
        {
            cmbTipoAnalisis.CargarCombo();
            this.CargarCombo(cmbEspecie, "Descripcion", Especie.Buscar());
        }


        #endregion

        #region COMBOS  
            private void cmbTipoAnalisis_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbTipoAnalisis, TipoAnalisis.Buscar());
            }

            private void cmbTipoAnalisis_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                
                TipoAnalisis ObjetoBase = new TipoAnalisis();
              
                GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar,ObjetoBase);
                frmLanzar.Titulo = "Tipos Análisis Genéticos";
                frmLanzar.NumColumnas = 2;
                frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción") { ValorDefecto=e.TextoCrear});

                CrearNuevoElementoCombo(frmLanzar, sender);
              

            }
        #endregion


    }
}
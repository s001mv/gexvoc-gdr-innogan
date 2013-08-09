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
    public partial class EditCombinacion : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditCombinacion()
        {
            InitializeComponent();
        }
        public EditCombinacion(Modo modo, Combinacion ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Combinacion ObjetoBase { get { return (Combinacion)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

        protected override void DefinirListaBinding()
        {
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdMarcador1", true, cmbMarcador1, lblMarcador1));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdMarcador2", true, cmbMarcador2, lblMarcador2));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Grupo", false, txtGrupo, lblGrupo));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Riesgo", false, txtRiesgo, lblRiesgo));
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
        /// Carga los combos del formulario.
        /// </summary>
        protected override void CargarCombos()
        {


            cmbMarcador1.CargarCombo();
            cmbMarcador2.CargarCombo();
            
        }

        

        #endregion

        #region COMBOS
            private void cmbMarcador1_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbMarcador1, "Marcador1", "Id", Marcador.Buscar());
            }

            private void cmbMarcador1_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                
                Marcador ObjetoBase = new Marcador();
                EditMarcador editMarcador = new EditMarcador(Modo.Guardar, ObjetoBase);
                editMarcador.Marcador = e.TextoCrear;

                CrearNuevoElementoCombo(editMarcador, sender);
               
            }

            private void cmbMarcador2_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbMarcador2, "Marcador1", "Id", Marcador.Buscar());
            }

            private void cmbMarcador2_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                Marcador ObjetoBase = new Marcador();
                EditMarcador editMarcador = new EditMarcador(Modo.Guardar, ObjetoBase);
                editMarcador.Marcador = e.TextoCrear;

                CrearNuevoElementoCombo(editMarcador, sender);
            }
        #endregion
    }
}

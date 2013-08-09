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
    public partial class EditTipoSemilla : GEXVOC.UI.GenericEdit
    {
        public EditTipoSemilla()
        {
            InitializeComponent();
        }
        public EditTipoSemilla(Modo modo, Producto ClaseBase)
            : base(modo, ClaseBase)
            {
                InitializeComponent();
              
            }

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Producto ObjetoBase { get { return (Semilla)this.ClaseBase; } }



        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

        protected override void ClaseBaseAControles()
        {
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "IdFamilia", cmbFamilia);
        }

        protected override void ControlesAClaseBase()
        {

            Generic.ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
            Generic.ControlAClaseBase(this.ObjetoBase, "IdFamilia", cmbFamilia);
        }



        /// <summary>
        /// Validación de los Controles, se produce antes de actualizar la ClaseBase.
        /// </summary>
        /// <returns>Controles válidos (Si/No)</returns>
        protected override bool Validar()
        {
            bool Rtno = true;
            this.ErrorProvider.Clear();
            if (!Generic.ControlValorado(new Control[] { txtDescripcion, cmbFamilia }, this.ErrorProvider))
                Rtno = false;


            return Rtno;

        }

        #endregion

        #region CARGAS COMUNES
            /// <summary>
            /// Carga los combos del formulario
            /// </summary>
            protected override void CargarCombos()
            {

                this.cmbFamilia.DataSource = FamiliaSemilla.Buscar();
                this.cmbFamilia.DisplayMember = "Descripcion";
                this.cmbFamilia.ValueMember = "Id";
                this.cmbFamilia.SelectedIndex = -1;

            }
        #endregion 

        

    }
}

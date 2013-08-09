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
    public partial class EditFamiliaSemilla : GEXVOC.UI.GenericEdit
    {
        public EditFamiliaSemilla()
        {
            InitializeComponent();
        }
        public EditFamiliaSemilla(Modo modo, Familia ClaseBase)
            : base(modo, ClaseBase)
            {
                InitializeComponent();
              
            }


        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            public Familia ObjetoBase { get { return (FamiliaSemilla)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

            protected override void ClaseBaseAControles()
            {
                Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
            }

            protected override void ControlesAClaseBase()
            {
               
                Generic.ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
            }



        /// <summary>
        /// Validación de los Controles, se produce antes de actualizar la ClaseBase.
        /// </summary>
        /// <returns>Controles válidos (Si/No)</returns>
        protected override bool Validar()
        {
            bool Rtno = true;
            this.ErrorProvider.Clear();
            if (!Generic.ControlValorado(new Control[] { txtDescripcion }, this.ErrorProvider))
                Rtno = false;


            return Rtno;

        }

        #endregion
    }
}

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
    public partial class EditRendimientoCanal : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditRendimientoCanal()
        {
            InitializeComponent();
        }
        public EditRendimientoCanal(Modo modo, RendimientoCanal ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            public RendimientoCanal ObjetoBase { get { return (RendimientoCanal)this.ClaseBase; } }

        
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                this.lstBinding.Add(new BindingMaestro(this.ClaseBase, "IdAnimal", true, cmbAnimal, lblAnimal));
                this.lstBinding.Add(new BindingMaestro(this.ClaseBase, "Rendimiento", true, txtRendimiento, lblRendimiento));
                this.lstBinding.Add(new BindingMaestro(this.ClaseBase, "Fecha", true, txtFecha, lblFecha));

            }
            private void EditRendimientoCanal_PropiedadAControl(object sender, PropiedadBindEventArgs e)
            {
                if (e.Control == cmbAnimal)
                {
                    cmbAnimal.ClaseActiva = Animal.Buscar(this.ObjetoBase.IdAnimal);
                    e.Cancelar = true;
                }
            }
       
        #endregion

        #region CARGAS COMUNES
            /// <summary>
            /// Carga como valor por defecto la fecha del sistema.
            /// </summary>
            protected override void CargarValoresDefecto()
            {
                Generic.DatetimeAControl(txtFecha, DateTime.Now.Date);
            }
        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarAnimal_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, cmbAnimal));
            }
        #endregion
        
        



        
    }
}
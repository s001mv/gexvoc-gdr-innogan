using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;

namespace GEXVOC.UI
{
    public partial class EditRacion : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
            public EditRacion()
            {
                InitializeComponent();
            }
            public EditRacion(Modo modo, Racion ClaseBase)
                : base(modo, ClaseBase)
            {
                InitializeComponent();            
               
            }      
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            public Racion ObjetoBase { get { return (Racion)this.ClaseBase; } }

            public string Descripcion { get { return txtDescripcion.Text; } set { txtDescripcion.Text = value; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Descripcion", true, txtDescripcion, lblDescripcion));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Peso", true, txtPeso, lblPeso));

                base.DefinirListaBinding();
            }

        #endregion

        #region CARGAS COMUNES
            protected override void CargarGrids()
        {
          
            this.dtgComposicion.DataSource = this.ObjetoBase.lstComposicion;

        }
        #endregion

        #region GRID - COMPOSICION
            private void NuevaComposicion()
            {
                if (ModoActual == Modo.Actualizar)
                {
                    Composicion ObjCrear = new Composicion();
                    this.LanzarFormulario(new EditComposicion(Modo.Guardar, ObjCrear) { ValorFijoIdRacion = this.ObjetoBase.Id }, dtgComposicion);

                }
            }
            private void ModificarComposicion()
            {

                if (this.dtgComposicion.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
                {
                    //El el formulario en modo edicion no se pueden modificar las propiedades idRacion ni idAlimento por eso son bloqueadas
                    Composicion ObjActualizar = (Composicion)this.dtgComposicion.CurrentRow.DataBoundItem;
                    this.LanzarFormulario(new EditComposicion(Modo.Actualizar, ObjActualizar) { ValorFijoIdRacion = ObjActualizar.IdRacion, ValorFijoIdAlimento = ObjActualizar.IdAlimento }, this.dtgComposicion);

                }
            }

            private void tsbNuevaComposicion_Click(object sender, EventArgs e)
            {
                NuevaComposicion();
            }

            private void tsbModificarComposicion_Click(object sender, EventArgs e)
            {
                ModificarComposicion();
            }

            private void tsbEliminarComposicion_Click(object sender, EventArgs e)
            {
                this.EliminarObjGrid(this.dtgComposicion, "Va a eliminar la composición.\r¿Esta usted seguro de que desea continuar?");
            }

            private void dtgComposicion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                ModificarComposicion();
            }
     
        #endregion       
    }
}

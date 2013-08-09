using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Controles;
using GEXVOC.Core.Logic;

namespace GEXVOC.UI
{
    public partial class FindTitulares : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES

            public FindTitulares()
            {
                InitializeComponent();
            }

            public FindTitulares(Modo modo, ctlBuscarObjeto controlBusqueda)
                : base(modo,  controlBusqueda)
            {
                InitializeComponent();
              
            }

            public bool MostrarTodosTitulares 
            { 
                set {
                    chkTodasExplotaciones.Checked = true;
                    chkTodasExplotaciones.Enabled = false;
                } 
            }
        
        #endregion

        #region FUNCIONES SOBREESCRITAS

            /// <summary>
            /// Crea el Estilo Personalizado para el Grid
            /// </summary>
            protected override void GenerarEstiloGrid()
            {
                dtgResultado.Columns.Add("Nombre", "Nombre");
                dtgResultado.Columns[0].DataPropertyName = "Nombre";
                dtgResultado.Columns.Add("Apellidos", "Apellidos");
                dtgResultado.Columns[1].DataPropertyName = "Apellidos";
                dtgResultado.Columns.Add("DNI", "DNI");
                dtgResultado.Columns[2].DataPropertyName = "DNI";
                dtgResultado.Columns.Add("Direccion", "Dirección");
                dtgResultado.Columns[3].DataPropertyName = "Direccion";
                dtgResultado.Columns.Add("CP", "CP");
                dtgResultado.Columns[4].DataPropertyName = "CP";
                dtgResultado.Columns.Add("FechaAlta", "F. Alta");
                dtgResultado.Columns[5].DataPropertyName = "FechaAlta";
                dtgResultado.Columns.Add("Telefono", "Teléfono");
                dtgResultado.Columns[6].DataPropertyName = "Telefono";
                
            }

            /// <summary>
            /// Realiza la búsqueda según el criterio formado por controles del formulario. 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            protected override void Buscar()
            {
                //Nota: La llamada a buscar envia los datos de los combos como clases tipadas
                //Esto nos permite omitir cualquier tipo de validación, ya que si en el combo no existe selecciado
                //un elemento válido, envía nulo.

                if (chkTodasExplotaciones.Checked)
                    AsignarOrigenDatos<Titular>(Titular.Buscar(this.txtNombre.Text, txtApellidos.Text, txtDireccion.Text, txtCP.Text, txtDNI.Text, txtTelefono.Text, null, null, null));
                else
                    AsignarOrigenDatos<Titular>(Explotacion.BuscarTitulares(Configuracion.Explotacion.Id, txtNombre.Text, txtApellidos.Text, txtDireccion.Text, txtCP.Text, txtDNI.Text, txtTelefono.Text, null, null, null));
              
                ////dtgResultado.DataSource =  Titular.Buscar(this.txtNombre.Text, txtApellidos.Text, txtDireccion.Text, txtCP.Text,
                ////    txtDNI.Text,txtTelefono.Text,null,null,null                  );
            }

            /// <summary>
            /// Lanza el formulario de Edición de Explotaciones en Modo => Guardar
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            protected override void Insertar()
            {
                Titular objActualizar = new  Titular();
                this.LanzarFormulario(new EditTitulares(Modo.Guardar, objActualizar), this.dtgResultado);

            }

            /// <summary>
            /// Lanza el formulario de Explotaciones en Modo => Actualizar
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            protected override void Modificar()
            {
                this.Modificar(null);

            }
            protected  void Modificar(int? numTabSeleccionar)
            {

                if (dtgResultado.SelectedRows.Count == 1)
                {
                    Titular objActualizar = (Titular)this.dtgResultado.CurrentRow.DataBoundItem;

                    EditTitulares editTitulares;
                    if (numTabSeleccionar==null)
                        editTitulares = new EditTitulares(Modo.Actualizar, objActualizar);
                    else
                        editTitulares = new EditTitulares(Modo.Actualizar, objActualizar, (int)numTabSeleccionar);


                    this.LanzarFormulario(editTitulares, this.dtgResultado);
                }


            }


            #endregion

        #region BARRA HORIZONTAL ACCESOS
                private void btnCuentas_Click(object sender, EventArgs e)
                {
                    Modificar(0);
                }

                private void btnExplotaciones_Click(object sender, EventArgs e)
                {
                    Modificar(1);
                }
     
            #endregion 
            
    }
}

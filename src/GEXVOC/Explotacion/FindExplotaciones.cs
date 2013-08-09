using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Controles;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Reflection;



namespace GEXVOC.UI
{
    public partial class FindExplotaciones : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
            public FindExplotaciones()
            {
                InitializeComponent();
              
            }
            public FindExplotaciones(Modo modo, ctlBuscarObjeto controlBusqueda)
                : base(modo, controlBusqueda)
            {
                InitializeComponent();
             
            }
            
        #endregion

        #region FUNCIONES SOBREESCRITAS

            /// <summary>
            /// Crea el Estilo Personalizado para el Grid
            /// </summary>
            protected override void GenerarEstiloGrid()
            {
                dtgResultado.Columns.Add("CEA", "CEA");
                dtgResultado.Columns[0].DataPropertyName = "CEA";
                dtgResultado.Columns.Add("Nombre", "Nombre");
                dtgResultado.Columns[1].DataPropertyName = "Nombre";
                dtgResultado.Columns.Add("Direccion", "Dirección");
                dtgResultado.Columns[2].DataPropertyName = "Direccion";
                dtgResultado.Columns.Add("FechaAlta", "F. Alta");
                dtgResultado.Columns[3].DataPropertyName = "FechaAlta";
                dtgResultado.Columns.Add("FechaBaja", "F. Baja");
                dtgResultado.Columns[4].DataPropertyName = "FechaBaja";
                dtgResultado.Columns.Add("DescProvincia", "Provincia");
                dtgResultado.Columns[5].DataPropertyName = "DescProvincia";
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

                AsignarOrigenDatos<Explotacion>(Explotacion.Buscar(txtCEA.Text, txtNombre.Text, txtDireccion.Text, 
                    Generic.ControlAIntNullable(cmbProvincia),Generic.ControlAIntNullable(cmbMunicipio),
                    Generic.ControlAIntNullable(cmbCJuridica)));

                ////dtgResultado.DataSource = Explotacion.Buscar(txtCEA.Text, txtNombre.Text, txtDireccion.Text, (Provincia)cmbProvincia.SelectedItem,
                ////   (Municipio) cmbMunicipio.SelectedItem, (CondicionJuridica)cmbCJuridica.SelectedItem);
            }

            /// <summary>
            /// Lanza el formulario de Edición de Explotaciones en Modo => Guardar
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            protected override void Insertar()
            {
                
                Explotacion ObjetoBase = null;
                try
                {
                    ObjetoBase = new Explotacion();

                    EditExplotaciones frmEditExplotaciones = new EditExplotaciones(Modo.Guardar, ObjetoBase);

                    this.LanzarFormulario(frmEditExplotaciones,this.dtgResultado);

               
                }
                catch (Exception) { throw; }
              
            }

            /// <summary>
            /// Lanza el formulario de Explotaciones en Modo => Actualizar
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            protected override void Modificar()
            {
                this.Modificar(string.Empty);
            }

            protected void Modificar(string TabSeleccionar) 
            {
                if (dtgResultado.SelectedRows.Count == 1)
                {
                   
                    Explotacion ObjModificar = null;
                    
                    try
                    {

                        ObjModificar = (Explotacion)this.dtgResultado.CurrentRow.DataBoundItem;
                      
                        EditExplotaciones frmEditExplotaciones;

                        if (TabSeleccionar == string.Empty)
                            frmEditExplotaciones = new EditExplotaciones(Modo.Actualizar, ObjModificar);
                        else
                            frmEditExplotaciones = new EditExplotaciones(Modo.Actualizar, ObjModificar, TabSeleccionar);

                        this.LanzarFormulario(frmEditExplotaciones,this.dtgResultado);

                    
                    }
                    catch (Exception){throw;}
                  
                }
            }
            


        #endregion

        #region CARGAS COMUNES

            /// <summary>
            /// Carga los Combos del Formulario
            /// </summary>
            protected override void CargarCombos()
            {
                this.CargarCombo(cmbCJuridica, CondicionJuridica.Buscar());
                this.CargarCombo(cmbProvincia, Provincia.Buscar());
            }

            private void cmbProvincia_SelectedValueChanged(object sender, EventArgs e)
            {
                CargarMunicipios();
            }

            /// <summary>
            /// Realiza la carga del combo de municipios en funcion de la provincia seleccionada.
            /// </summary>
            private void CargarMunicipios()
            {
                if (this.cmbProvincia.SelectedValue != null)
                {
                    this.CargarCombo(cmbMunicipio,Municipio.Buscar(string.Empty,string.Empty,Generic.ControlAIntNullable(cmbProvincia)));                    
                }
                else
                    this.cmbMunicipio.DataSource = null;

                this.cmbMunicipio.Text = string.Empty;
                

            }



        #endregion

        #region BARRA HORIZONTAL ACCESOS

            private void botones_Click(object sender, EventArgs e)
            {               
               Modificar(sender.ToString());
            }

          
        #endregion

        #region PROPIEDADES PARA PROCESOS
            [ProcesoDescripcion("Búsqueda de Explotaciones - Muestra el botón: Contactos (en la barra superior)" , "Agenda")]
            public bool _proceso_Agenda
            {
                set
                {
                    if (!value) SubBarraHerramientas.Items.Remove(btnContactos);
                }
            }


        #endregion

    }
}

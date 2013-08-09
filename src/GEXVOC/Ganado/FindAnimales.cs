using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Controles;
using GEXVOC.Core.Reflection;

namespace GEXVOC.UI
{
    public partial class FindAnimales : GEXVOC.UI.GenericFind
    {

        #region VARIABLES Y PROPIEDADES PRINCIPALES
            char? _ValorSexoFijo=null;
            /// <summary>
            /// Nos indicará si el combo sexo tendra un valor por defecto o no.
            /// Si esta propiedad se encuentra valorada, el formulario findAnimales
            /// se mostrará con el combo del sexo deshabilitado y con el valor seleccionado
            /// que aqui se indique.
            /// Nota: Debe tener un valor incluido entre los elementos de lstSexo que se genera en Generic.CargarComboSexos()
            /// </summary>
            public char? ValorSexoFijo
            {
                get { return _ValorSexoFijo; }
                set
                {
                   _ValorSexoFijo = value; 
                }
            }


          
            //#MOD_A3          
            int? _ValorEstadoFijo = null;
            /// <summary>
            /// Nos indicará si el combo estado tendra un valor por defecto o no.
            /// Si esta propiedad se encuentra valorada, el formulario findAnimales
            /// se mostrará con el combo estado deshabilitado y con el valor seleccionado
            /// que aqui se indique.
            /// Nota: Debe tener un valor incluido entre la lista de estados.
            /// </summary>
            public int? ValorEstadoFijo
            {
                get { return _ValorEstadoFijo; }
                set
                {
                    _ValorEstadoFijo = value;
                }
            }


        #endregion

        #region CONSTRUCTORES
            public FindAnimales()
            {
                InitializeComponent();
               
            }
            public FindAnimales(Modo modo, ctlBuscarObjeto controlBusqueda):base (modo, controlBusqueda)
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
                dtgResultado.Columns.Clear();
                dtgResultado.Columns.Add("Nombre", "Nombre / CI");
                dtgResultado.Columns[0].DataPropertyName = "Nombre";
                dtgResultado.Columns.Add("DIB", "DIB / CIB");
                dtgResultado.Columns[1].DataPropertyName = "DIB";
                dtgResultado.Columns.Add("Crotal", "Crotal");
                dtgResultado.Columns[2].DataPropertyName = "Crotal";
                dtgResultado.Columns.Add("Tatuaje", "Tatuaje");
                dtgResultado.Columns[3].DataPropertyName = "Tatuaje"; 
                dtgResultado.Columns.Add("Sexo", "Sexo");
                dtgResultado.Columns[4].DataPropertyName = "Sexo";
                dtgResultado.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dtgResultado.Columns[4].Width = 35;
                dtgResultado.Columns.Add("FechaNacimiento", "F. Nac");
                dtgResultado.Columns[5].DataPropertyName = "FechaNacimiento";                     
                dtgResultado.Columns.Add("DescEspecie", "Especie");
                dtgResultado.Columns[6].DataPropertyName = "DescEspecie";
                dtgResultado.Columns.Add("DescRaza", "Raza");
                dtgResultado.Columns[7].DataPropertyName = "DescRaza";
                dtgResultado.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                //if (rbtMostrarBajas.Checked)
                //{
                //    dtgResultado.Columns.Add("DescFechaBaja", "F. Baja");
                //    dtgResultado.Columns[8].DataPropertyName = "DescFechaBaja";
                //}

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

             
                    char? sexo=null;
                    if (this.cmbSexo.SelectedValue!=null)
                        sexo = Convert.ToChar(this.cmbSexo.SelectedValue);


                    AsignarOrigenDatos<Animal>(Animal.BuscarAmpliado(null,Generic.ControlAIntNullable(cmbRaza),Generic.ControlAIntNullable(cmEstado),null,null,
                                               Configuracion.Explotacion.Id, txtDIB.Text,this.txtCrotal.Text,txtTatuaje.Text,
                                               this.txtNombre.Text, Generic.ControlADatetimeNullable(this.txtFecNacimiento),sexo,null,
                                               null,rbtMostrarBajas.Checked,Generic.ControlAIntNullable(cmbEspecie),
                                               Generic.ControlAIntNullable(cmbAltaTipo),Generic.ControlADatetimeNullable(txtAltaFecha),txtAltaDetalle.Text,
                                               Generic.ControlAIntNullable(cmbBajaTipo),Generic.ControlADatetimeNullable(txtBajaFecha),txtBajaDetalle.Text,null));
                    //this.dtgResultado.DataSource = Animal.Buscar(null,Generic.ControlAIntNullable(cmbRaza),null,null,null,Configuracion.Explotacion.Id, txtDIB.Text,this.txtCrotal.Text,txtTatuaje.Text,this.txtNombre.Text, Generic.ControlADatetimeNullable(this.txtFecNacimiento),sexo,null,null,string.Empty,chkMostrarBajas.Checked,Generic.ControlAIntNullable(cmbEspecie));
               

            }

            /// <summary>
            /// Lanza el formulario de Edición de Animales en Modo => Guardar
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            protected override void Insertar()
            {
                Animal ObjetoBase = new Animal();

                EditAnimales frmEditAnimales = new EditAnimales(Modo.Guardar, ObjetoBase);

                this.LanzarFormulario(frmEditAnimales, this.dtgResultado);

            }

            /// <summary>
            /// Lanza el formulario de Animales en Modo => Actualizar
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            protected override void Modificar(){
                this.Modificar(string.Empty);
            }

        protected void Modificar(string TabSeleccionar)
        {

            if (dtgResultado.SelectedRows.Count == 1)
            {
               
                Animal ObjetoBase = (Animal)this.dtgResultado.CurrentRow.DataBoundItem;
                EditAnimales frmEditAnimales;
                if (TabSeleccionar==string.Empty)
                    frmEditAnimales = new EditAnimales(Modo.Actualizar, ObjetoBase);
                else
                    frmEditAnimales = new EditAnimales(Modo.Actualizar, ObjetoBase,TabSeleccionar);

                this.LanzarFormulario(frmEditAnimales,this.dtgResultado);
                Console.WriteLine(DateTime.Now.ToString("fffffff"));
            }


        }

        



        #endregion

        #region CARGAS COMUNES
            /// <summary>
            /// Carga los Valores por defecto del Formulario de Explotaciones
            /// </summary>
            protected override void CargarValoresDefecto()
            {
                //this.txtExplotacion.Text = Configuracion.Explotacion.Nombre;

                if (ValorSexoFijo != null)
                {
                    this.cmbSexo.Enabled = false;
                    this.cmbSexo.SelectedValue = this.ValorSexoFijo;
                }
                if (ValorEstadoFijo != null)
                {
                    this.cmEstado.Enabled = false;
                    this.cmEstado.SelectedValue = this.ValorEstadoFijo;
                }

            }

            /// <summary>
            /// Carga los Combos del Formulario
            /// </summary>
            protected override void CargarCombos()
            {
                
               
                this.CargarCombo(cmbEspecie, Configuracion.Explotacion.lstEspecies,true);
                this.CargarCombo(cmEstado, Estado.Buscar());

                this.CargarCombo(cmbAltaTipo, TipoAlta.Buscar());
                this.CargarCombo(cmbBajaTipo, TipoBaja.Buscar());

                Generic.CargarComboSexos(cmbSexo);
            
                
            }

            public override void Cargar()
            {
                if (Configuracion.Explotacion == null)            
                    throw new LogicException("No es posible mostrar el formulario porque no se encuentra una explotación activa");

                
                base.Cargar();
            }

      
        #endregion

        #region BARRA HORIZONTAL ACCESOS
            private void btnesHorizontales_Click(object sender, EventArgs e){
                Modificar(sender.ToString());
            }

            //private void btnPartos_Click(object sender, EventArgs e){
            //    Modificar(1);
            //}

            //private void btnControles_Click(object sender, EventArgs e){
            //    Modificar(2);
            //}
            //private void btnSecados_Click(object sender, EventArgs e)
            //{
            //    Modificar(3);

            //}
            //private void btnMorfologia_Click(object sender, EventArgs e)
            //{
            //    Modificar(4);
            //}

            //private void btnPesos_Click(object sender, EventArgs e)
            //{
            //    Modificar(5);
            //}

        #endregion 

        #region FUNCIONAMIENTO GENERAL
            private void cmbEspecie_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (cmbEspecie.SelectedValue != null)
                {
                    if ((int)cmbEspecie.SelectedValue == Configuracion.EspecieSistema(Configuracion.EspeciesSistema.BOVINA).Id)                    
                        lblDIB.Text = "CIB";                
                    else                    
                        lblDIB.Text = "DIB";                      
                    

                    this.CargarCombo(this.cmbRaza, "Descripcion", Raza.Buscar(string.Empty, Generic.ControlAIntNullable(cmbEspecie)));

                }
                else
                    this.cmbRaza.DataSource = null;
            }

            private void rbtMostrarAltas_CheckedChanged(object sender, EventArgs e)
            {
                ActualizarPaneles();
            }

            private void ActualizarPaneles()
            {

                if (this.rbtMostrarAltas.Checked && !pnlAlta.Visible)
                {
                    pnlAlta.Visible = true;
                    pnlAlta.Enabled = true;
                    pnlBaja.Visible = false;
                    pnlBaja.Enabled = false;
                    txtAltaFecha.Focus();
                }
                if (this.rbtMostrarBajas.Checked && !pnlBaja.Visible)
                {
                    pnlAlta.Visible = false;
                    pnlAlta.Enabled = false;
                    pnlBaja.Visible = true;
                    pnlBaja.Enabled = true;
                    txtBajaFecha.Focus();
                }
            }

            private void rbtMostrarBajas_CheckedChanged(object sender, EventArgs e)
            {
                ActualizarPaneles();
            }

        #endregion

        #region PROPIEDADES PARA PROCESOS
            [ProcesoDescripcion("Búsqueda de Animales - Muestra los botones: Celos, Inseminaciones, Partos y Pesos (en la barra superior)", "Reproducción")]
            public bool _proceso_Reproduccion
            {
                set
                {
                    if (!value)
                    {
                        SubBarraHerramientas.Items.Remove(btnCelos);
                        SubBarraHerramientas.Items.Remove(btnInseminaciones);
                        SubBarraHerramientas.Items.Remove(btnPartos);
                        SubBarraHerramientas.Items.Remove(btnPesos);   
                    }
                }
            }
            [ProcesoDescripcion("Búsqueda de Animales - Muestra los botones: Controles, Latación y Secados (en la barra superior)", "Producción de Leche")]
            public bool _proceso_ProducionLeche
            {
                set
                {
                    if (!value)
                    {
                        SubBarraHerramientas.Items.Remove(btnControles);
                        SubBarraHerramientas.Items.Remove(btnLactacion);
                        SubBarraHerramientas.Items.Remove(btnSecados);
                    }

                }
            }
            [ProcesoDescripcion("Búsqueda de Animales - Muestra el botón: Libro Genealógico (en la barra superior)", "Genealogía")]
            public bool _proceso_Genealogia
            {
                set
                {
                    if (!value) SubBarraHerramientas.Items.Remove(btnLGenealogico);

                }
            }
          

            #endregion
    }
}
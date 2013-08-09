using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Controles;
using System.Linq;

namespace GEXVOC.UI
{
    /// <summary>
    /// Formulario de selección de conjuntos de animales
    /// Permite fintrados fijos y variables.
    /// Permite busquedas básicas, por lotes, etc...
    /// </summary>
    public partial class SelectorAnimales : GEXVOC.UI.GenericFind
    {

        #region VARIABLES Y PROPIEDADES PRINCIPALES
            char? _ValorSexoFijo = null;
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

            bool? _ValorFijoParidera = null;

            public bool? ValorFijoParidera
            {
                get { return _ValorFijoParidera; }
                set
                {
                    _ValorFijoParidera = value;
                }
            }


            List<Animal> lstAnimalesSeleccionados = new List<Animal>();

            List<Animal> _lstAnimalesSeleccionadosRtno = null;

            public List<Animal> LstAnimalesSeleccionadosRtno
            {
                get { return _lstAnimalesSeleccionadosRtno; }
            }
        #endregion

        #region CONSTRUCTORES
            public SelectorAnimales()
            {
                InitializeComponent();
                if (!Cargado) Cargar();
            }
            public SelectorAnimales(Modo modo, ctlBuscarObjeto controlBusqueda)
                : base(modo, controlBusqueda)
            {
                InitializeComponent();
                if (!Cargado) Cargar();
            }
            public SelectorAnimales(Modo modo, List<Animal> lstAnimalesIniciales)
            {

                InitializeComponent();
                base.ModoActual = modo;

                if (!Cargado) Cargar();

                if (lstAnimalesIniciales != null)
                {
                    foreach (Animal item in lstAnimalesIniciales)
                        lstAnimalesSeleccionados.Add(item);

                    this.ActualizarGridSeleccionados();
                }

            }
            public SelectorAnimales(Modo modo, List<Animal> lstAnimalesIniciales, char valorSexoFijo)
            {

                InitializeComponent();
                base.ModoActual = modo;
                ValorSexoFijo = valorSexoFijo;
                if (!Cargado) Cargar();

                if (lstAnimalesIniciales != null)
                {
                    foreach (Animal item in lstAnimalesIniciales)
                        lstAnimalesSeleccionados.Add(item);

                    this.ActualizarGridSeleccionados();
                }

            }
        

        #endregion

        #region CARGAS COMUNES
            public override void Cargar()
            {
                base.Cargar();
                btnNuevo.Visible = false;
                btnModificar.Visible = false;
                btnEliminar.Visible = false;

                this.dtgResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgResultado_CellContentClick);

                this.dtgAnimalesSeleccionados.AutoGenerateColumns = false;
                this.dtgResultado.RowHeadersWidth = 20;

            }
          
            private void SelectorAnimales_Load(object sender, EventArgs e)
            {
             
                Buscar();
            }

            protected override void GenerarEstiloGrid()
            {
                dtgResultado.Columns.Add(new DataGridViewCheckBoxColumn() { ReadOnly = false, DataPropertyName = "EnSeleccion" });

                //dtgResultado.Columns.Add("Crotal", "Crotal");
                //dtgResultado.Columns[0].DataPropertyName = "Crotal";
                dtgResultado.Columns.Add("Nombre", "Nombre / CI");
                dtgResultado.Columns[1].DataPropertyName = "Nombre";
                dtgResultado.Columns[1].ReadOnly = true;

                dtgResultado.Columns.Add("DescRaza", "Raza");
                dtgResultado.Columns[2].DataPropertyName = "DescRaza";
                dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgResultado.Columns.Add("FechaNacimiento", "F. Nac");
                dtgResultado.Columns[3].DataPropertyName = "FechaNacimiento";

                dtgResultado.Columns.Add("Sexo", "Sexo");
                dtgResultado.Columns[4].DataPropertyName = "Sexo";
                dtgResultado.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dtgResultado.Columns[4].Width = 35;


                dtgResultado.Columns.Add("DescEspecie", "Especie");
                dtgResultado.Columns[5].DataPropertyName = "DescEspecie";
                dtgResultado.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                base.GenerarEstiloGrid();
            } 

            protected override void CargarCombos()
            {
                Generic.CargarComboSexos(this.cmbSexo);
                this.CargarCombo(this.cmbEspecie, Configuracion.Explotacion.lstEspecies,true);
                //this.CargarCombo(cmbLoteAnimal, Configuracion.Explotacion.lstLotesAnimales);
                base.CargarCombos();
            }
            protected override void CargarValoresDefecto()
            {
                if (ValorSexoFijo != null)
                {
                    this.cmbSexo.Enabled = false;
                    this.cmbSexo.SelectedValue = this.ValorSexoFijo;
                }

                base.CargarValoresDefecto();
            }
            

        #endregion

        #region FUNCIONAMIENTO GENERAL

            protected override void Buscar()
            {
                          


                char? sexo = null;
                if (this.cmbSexo.SelectedValue != null)
                    sexo = Convert.ToChar(this.cmbSexo.SelectedValue);

                //List<Animal> lstAnimalesSeleccionados = ((List<Animal>)dtgAnimalesSeleccionados.DataSource);

                //List<Animal> lstAnimalesBusqueda = new List<Animal>();
                List<Animal> lstAnimalesBusqueda = Animal.Buscar(null,   Generic.ControlAIntNullable(cmbRaza), null, null, null, Configuracion.Explotacion.Id, txtDIB.Text, this.txtCrotal.Text, txtTatuaje.Text, this.txtNombre.Text, null, sexo, null, null,chkMostrarBajas.Checked,Generic.ControlAIntNullable(cmbEspecie));
                AgregarListaAnimales(lstAnimalesBusqueda);  

              
                    
              
              

                   
                base.Buscar();
            }
            protected override void Limpiar()
            {
                base.Limpiar();
                ActualizarGridSeleccionados();

            }

            #region Selección de Animales

                private void AgregarListaAnimales(List<Animal> lstAnimalesBusqueda)
                {
                    if (lstAnimalesBusqueda != null && lstAnimalesSeleccionados != null)
                    {
                        foreach (Animal item in lstAnimalesBusqueda)
                            item.EnSeleccion = false;

                        foreach (Animal item in lstAnimalesSeleccionados)
                        {
                            Animal animal = lstAnimalesBusqueda.Find(E => E.Id == item.Id);
                            if (animal != null)
                                animal.EnSeleccion = true;
                        }
                    }
                    ActualizarGridBusqueda(lstAnimalesBusqueda);

                }
                private void ActualizarGridBusqueda(List<Animal> lstAnimalesBusqueda)
                {
                    //AsignarOrigenDatos<Animal>(lstAnimalesBusqueda);
                    this.dtgResultado.DataSource = null;
                    this.dtgResultado.DataSource = lstAnimalesBusqueda;
                }


                private void dtgResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {
                    try
                    {
                        if (e.ColumnIndex == 0)
                        {
                            Animal animalMod = (Animal)dtgResultado.CurrentRow.DataBoundItem;
                            animalMod.EnSeleccion = !animalMod.EnSeleccion;

                            if (animalMod.EnSeleccion)
                            {//Tengo que añadir el animal a la seleccion pq se ha marcado
                                AgregarElemento(animalMod);
                            }
                            else
                            {
                                EliminarElemento(animalMod);
                            }



                            ActualizarGridSeleccionados();
                        }

                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }

                private void EliminarElemento(Animal animalMod)
                {
                    //Tengo que borrar el animal de la seleccion pq se ha desmarcado
                    Animal animal = null;
                    animal = lstAnimalesSeleccionados.Find(E => E.Id == animalMod.Id);
                    if (animal != null)
                        lstAnimalesSeleccionados.Remove(animal);
                }
                private void AgregarElemento(Animal animalMod)
                {
                    Animal animal = null;
                    animal = lstAnimalesSeleccionados.Find(E => E.Id == animalMod.Id);
                    if (animal == null)
                        lstAnimalesSeleccionados.Add(animalMod);
                }

                private void ActualizarGridSeleccionados()
                {
                    this.dtgAnimalesSeleccionados.DataSource = null;
                    this.dtgAnimalesSeleccionados.DataSource = lstAnimalesSeleccionados;
                }


                private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    try
                    {
                        if (dtgAnimalesSeleccionados.CurrentRow != null)
                        {
                            lstAnimalesSeleccionados.Remove((Animal)dtgAnimalesSeleccionados.CurrentRow.DataBoundItem);
                            this.ActualizarGridSeleccionados();
                            AgregarListaAnimales((List<Animal>)dtgResultado.DataSource);

                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }

            #endregion

            #region Botones Selección

                private void btnSeleccionarTodo_Click(object sender, EventArgs e)
                {
                    if (this.dtgResultado.DataSource != null)
                    {
                        List<Animal> lstAnimales = (List<Animal>)this.dtgResultado.DataSource;
                        foreach (Animal item in lstAnimales)
                        {
                            item.EnSeleccion = true;
                            AgregarElemento(item);
                        }

                        this.ActualizarGridSeleccionados();
                        this.ActualizarGridBusqueda(lstAnimales);
                    }
                }

                private void btnQuitarSeleccion_Click(object sender, EventArgs e)
                {
                    if (this.dtgResultado.DataSource != null)
                    {
                        List<Animal> lstAnimales = (List<Animal>)this.dtgResultado.DataSource;
                        foreach (Animal item in lstAnimales)
                        {
                            item.EnSeleccion = false;
                            EliminarElemento(item);
                        }

                        this.ActualizarGridSeleccionados();
                        this.ActualizarGridBusqueda(lstAnimales);
                    }
                }

                private void btnInvertirSeleccion_Click(object sender, EventArgs e)
                {
                    if (this.dtgResultado.DataSource != null)
                    {
                        List<Animal> lstAnimales = (List<Animal>)this.dtgResultado.DataSource;
                        foreach (Animal item in lstAnimales)
                        {
                            if (item.EnSeleccion)
                            {
                                item.EnSeleccion = false;
                                EliminarElemento(item);

                            }
                            else
                            {
                                item.EnSeleccion = true;
                                AgregarElemento(item);
                            }

                        }

                        this.ActualizarGridSeleccionados();
                        this.ActualizarGridBusqueda(lstAnimales);
                    }

                }

                private void btnConfirmar_Click(object sender, EventArgs e)
                {
                    _lstAnimalesSeleccionadosRtno = this.lstAnimalesSeleccionados;
                    this.Close();
                }

            #endregion

            #region Elementos del Filtro

                private void btnBuscarCubricion_Click(object sender, EventArgs e)
                {
                    this.LanzarFormularioConsulta(new FindCubricion(Modo.Consultar, this.cmbCubricion));
                }
                private void btnbuscarLote_Click(object sender, EventArgs e)
                {
                    this.LanzarFormularioConsulta(new FindLoteAnimal(Modo.Consultar, this.cmbLote) { ValorFijoParidera = ValorFijoParidera });
                }
               

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
                private void cmbLote_ClaseActivaChanged(object sender, ctlBuscarObjetoEventArgs e)
                {
                    if (e.ClaseActiva != null)
                        AgregarListaAnimales(((LoteAnimal)e.ClaseActiva).lstAnimales);
                    else
                        Buscar();


                }
                private void cmbCubricion_ClaseActivaChanged(object sender, ctlBuscarObjetoEventArgs e)
                {
                    Cubricion cubricion = (Cubricion)cmbCubricion.ClaseActiva;
                    if (cubricion != null)
                        cmbLote.ClaseActiva = LoteAnimal.Buscar(cubricion.IdLote);
                    else
                        cmbLote.ClaseActiva = null;


                }

            #endregion


        #endregion


    }
}

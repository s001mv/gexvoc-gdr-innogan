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
    public partial class EditExplotaciones : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTOR E INICIALIZACIONES REQUERIDAS

            /// <summary>
            /// Constructor por defecto
            /// </summary>
            public EditExplotaciones()
            {
                InitializeComponent();
            }

            /// <summary>
            /// Sobrecarga del Constructor que nos permite inicializar un formulario GenericEdit con los datos propios del formulario.
            /// Para ello necesitamos el modo en el que se lanza y la clase base sobre la que actúa.
            /// Este tipo de sobrecargas son siempre obligatorias al heredar de GenericEdit.
            /// El Codigo es Siempre el mismo, salvo por el tipo de la ClaseBase, que es propio del formulario heredado.
            /// </summary>
            /// <param name="modo">Modo de Apertura del Formulario Edit</param>
            /// <param name="ClaseBase">Clase Base sobre la que actúa el formulario Edit.</param>
            public EditExplotaciones(Modo modo, GEXVOC.Core.Logic.Explotacion ClaseBase)
                : base(modo, ClaseBase)
            {
                InitializeComponent();              
            }
            public EditExplotaciones(Modo modo, GEXVOC.Core.Logic.Explotacion ClaseBase, int numTabSeleccionar)
                : base(modo, ClaseBase, numTabSeleccionar)
            {
                InitializeComponent();
            }

            public EditExplotaciones(Modo modo, GEXVOC.Core.Logic.Explotacion ClaseBase, string TabSeleccionar)
                : base(modo, ClaseBase, TabSeleccionar)
            {
                InitializeComponent();
            }

        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO

            /// <summary>
            /// Es una propiedad Tipada que nos devuelve la Clase Base sobre la que actúa el Formulario Edit 
            /// El tipo es popio del formulario, pero implementa siempre la interface  IClaseBase)
            /// </summary>
            public GEXVOC.Core.Logic.Explotacion ObjetoBase
            {
                get { return (Explotacion)ClaseBase; }
                set { ClaseBase = value; }
            }
           
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

            /// <summary>
            /// Pasa los Valores de la Clase Base a los Controles del Formulario
            /// </summary>
            protected override void ClaseBaseAControles()
            {
                ClaseBaseAcontrol(this.ObjetoBase, "CEA", txtCea);
                ClaseBaseAcontrol(this.ObjetoBase, "Nombre", txtNombre);
                ClaseBaseAcontrol(this.ObjetoBase, "FechaAlta", txtFecAlta);
                ClaseBaseAcontrol(this.ObjetoBase, "FechaBaja", txtFecBaja);
                ClaseBaseAcontrol(this.ObjetoBase, "IdCJuridica", cmbCJuridica);
                ClaseBaseAcontrol(this.ObjetoBase, "IdProvincia", cmbProvincia);
                ClaseBaseAcontrol(this.ObjetoBase, "IdMunicipio", cmbMunicipio);
                ClaseBaseAcontrol(this.ObjetoBase, "Direccion", txtDireccion);
                ClaseBaseAcontrol(this.ObjetoBase, "Siglas", txtSigla);
                ClaseBaseAcontrol(this.ObjetoBase, "CodigoCLechero", txtCLechero);
            }

            /// <summary>
            /// Pasa los valores de los controles a la Clase Base
            /// </summary>
            protected override void ControlesAClaseBase()
            {
                ControlAClaseBase(this.ObjetoBase, "CEA", txtCea);
                ControlAClaseBase(this.ObjetoBase, "Nombre", txtNombre);
                ControlAClaseBase(this.ObjetoBase, "FechaAlta", txtFecAlta);
                ControlAClaseBase(this.ObjetoBase, "FechaBaja", txtFecBaja);
                ControlAClaseBase(this.ObjetoBase, "IdCJuridica", cmbCJuridica);
                ControlAClaseBase(this.ObjetoBase, "IdMunicipio", cmbMunicipio);
                ControlAClaseBase(this.ObjetoBase, "Direccion", txtDireccion);
                ControlAClaseBase(this.ObjetoBase, "Siglas", txtSigla);
                ControlAClaseBase(this.ObjetoBase, "CodigoCLechero", txtCLechero);
            }

            /// <summary>
            /// Validación de los Controles, se produce antes de actualizar la ClaseBase (ControlesAClaseBase)
            /// Si la validación retorna False no se continua con la actualización
            /// </summary>
            /// <returns>Controles Válidos (Sí/No)</returns>
            protected override bool Validar()
            {
                bool Rtno = true;
                this.ErrorProvider.Clear();
                
                //NOTA: Ponemos los campos a validar justo al revés, para que cuando se les establezca el foco (Si no se encuentran valorados), se haga
                //en orden
                if (!Generic.ControlValorado(new Control[] { txtFecAlta,cmbMunicipio, cmbProvincia, txtNombre, cmbCJuridica, txtCea },  this.ErrorProvider))
                    Rtno=false ;

                //Validaciones de tipos de datos (Siempre despues de validar los requeridos, pues son 
                //los que posicionan el foco en el control cuando no tiene valor (La validacion de tipos no lo hace)
                if (!Generic.ControlDatosCorrectos(this.txtFecAlta,  this.ErrorProvider,  typeof(System.DateTime), true)) Rtno = false;
                if (!Generic.ControlDatosCorrectos(this.txtFecBaja,  this.ErrorProvider,  typeof(System.DateTime), false)) Rtno = false;

                return Rtno;
            }

        #endregion

        #region CARGAS COMUNES

            /// <summary>
            /// Carga los combos del formulario
            /// </summary>
            protected override void CargarCombos()
            {                
                cmbCJuridica.CargarCombo();
                cmbProvincia.CargarCombo();            
            }

            /// <summary>
            /// Carga los Valores por defecto del Formulario de Explotaciones
            /// </summary>
            protected override void CargarValoresDefecto() {
                Generic.DatetimeAControl(this.txtFecAlta, DateTime.Now.Date);            
            }        

            /// <summary>
            /// Carga los grids de detalle
            /// </summary>
            protected override void CargarGrids()
            {
                this.dtgTitulares.DataSource = this.ObjetoBase.lstTitulares;
                this.dtgAnimales.DataSource = this.ObjetoBase.lstAnimales;
                this.dtgEspecies.DataSource = this.ObjetoBase.lstExpEsp;
                this.dtgContacto.DataSource = this.ObjetoBase.lstContactos;
                this.dtgLotesAnimales.DataSource = this.ObjetoBase.lstLotesAnimales;
                this.dtgModulos.DataSource = this.ObjetoBase.lstExpMod;
                this.dtgTratHigiene.DataSource = this.ObjetoBase.lstTratHigiene;
                this.dtgClientes.DataSource = this.ObjetoBase.lstClientes;
                this.dtgProveedores.DataSource = this.ObjetoBase.lstProveedores;
            }

        #endregion

        #region GRIDS

            #region TITULARES

                #region OPERACIONES
                    void ModificarTitular()
                    {
                        if (this.dtgTitulares.SelectedRows.Count == 1 && ModoActual==Modo.Actualizar)
                        {
                            //preparo el formulario que voy a lanzar
                            Titular ObjActualizar = (Titular)this.dtgTitulares.CurrentRow.DataBoundItem;                          
                            this.LanzarFormulario(new EditTitulares(Modo.Actualizar, ObjActualizar),dtgTitulares);
                        }
                    }
                    void AgregarTitular()
                    {

                        if (this.ModoActual == Modo.Actualizar)
                        {
                            Titular ObjActualizar = new Titular();
                            EditTitulares frmEditTitulares = new EditTitulares(Modo.Guardar, ObjActualizar);
                            if (this.LanzarFormulario(frmEditTitulares) == DialogResult.OK)
                                AgregarRelacionTitularExplotacion(frmEditTitulares.ObjetoBase);                                                        
                            
                        }
                        
                    }
                    void EliminarTitular()
                    {
                        this.EliminarObjGrid(this.dtgTitulares, "Va a eliminar el Titular de la Aplicación.\rSi el Titular ha sido asignado a otra explotación, se borrará dicha asignación.\r(A causa de este proceso es posible que quede alguna explotación sin Titular).\r¿Esta usted seguro de que desea continuar?");                     

                    }
                    private void AgregarRelacionTitularExplotacion(Titular titular)
                    {

                        if (titular != null && titular.Id !=0)
                        {  //crear registro en ExpTit

                            ExpTit exptit = new ExpTit();
                            this.IniciarContextoOperacion();
                            try
                            {
                                exptit.IdExplotacion = this.ObjetoBase.Id;
                                exptit.IdTitular = titular.Id;                             
                                exptit.FechaInicio = DateTime.Now;

                                exptit.Insertar();
                                CargarGrids();
                                SeleccionarObjGrid(exptit.Titular, this.dtgTitulares);//Nota: Puedo utilizar la propiedad Titular pq todavia tengo el contexto Operacion activo.
                              

                            }
                            catch (LogicException ex)
                            {
                                Generic.AvisoAdvertencia("No se ha podido guardar la relación.\rMensaje: " + ex.Message);
                                this.ObjetoBase.ExpTit.Remove(exptit);


                            }
                            catch (Exception ex)
                            {
                                Generic.AvisoError("No se ha podido guardar la relación ExpTit en el formulario EditExplotaciones.\rMensaje: " + ex.Message);
                                this.ObjetoBase.ExpTit.Remove(exptit);


                            }
                            finally { 
                                exptit = null;
                                this.FinalizarContextoOperacion();
                            }
                      

                        }
                    }
                    private void EliminarRelacionTitularExplotacion()
                    {
                        if (this.dtgTitulares.SelectedRows.Count == 1 && ModoActual==Modo.Actualizar)
                        {
                            this.IniciarContextoOperacion();

                            try
                            {
                                Titular ObjetoBaseTitular = (Titular)this.dtgTitulares.CurrentRow.DataBoundItem;
                                ExpTit exptit = ExpTit.Buscar(this.ObjetoBase.Id, ObjetoBaseTitular.Id);
                                if (exptit != null)
                                {
                                    if (DialogResult.Yes == Generic.Aviso("Va a eliminar la relación de Titular con la explotación.\r¿Esta usted seguro de que desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                    {

                                        exptit.Eliminar();
                                        CargarGrids();
                                    }
                                }


                            }
                            catch (LogicException ex)
                            {
                                Generic.AvisoAdvertencia("No se ha podido eliminar la relación.\rMensaje: " + ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Generic.AvisoError("No se ha podido eliminar la relación ExpTit en el formulario EditExplotaciones.\rMensaje: " + ex.Message);
                            }
                            finally { this.FinalizarContextoOperacion(); ; }


                        }
                    }

                #endregion

                #region BARRA BOTONES GRID
                    //NUEVO
                    private void tsmTitularNuevo_Click(object sender, EventArgs e)
                    {
                        AgregarTitular();
                    }
                    private void tsbNuevoTitular_ButtonClick(object sender, EventArgs e)
                    {
                        AgregarTitular();
                    }
                    private void tsmTitularExistente_Click(object sender, EventArgs e)
                    {
                        if (this.ModoActual == Modo.Actualizar)
                        { 
                            ctlBuscarObjeto rdoBusqueda = new ctlBuscarObjeto();
                            FindTitulares frmFindTitulares = new FindTitulares(Modo.Consultar, rdoBusqueda);
                            this.LanzarFormulario(frmFindTitulares);                         

                            AgregarRelacionTitularExplotacion((Titular)rdoBusqueda.SelectedItem);
                        }
                        
                    }

                    //MODIFICAR
                    private void tsbModificarTitular_Click(object sender, EventArgs e)
                    {
                        this.ModificarTitular();
                    }

                    //ELIMINAR
                    private void tsmEliminarRelacion_Click(object sender, EventArgs e)
                    {
                        EliminarRelacionTitularExplotacion();
                    }
                    private void tsbEliminarTitular_ButtonClick(object sender, EventArgs e)
                    {
                        this.EliminarRelacionTitularExplotacion();
                    }
                    private void tsmEliminarTitular_Click(object sender, EventArgs e)
                    {
                        this.EliminarTitular();
                    }


                #endregion

                #region EVENTOS
                    private void dtgTitulares_CellDoubleClick(object sender, DataGridViewCellEventArgs e){
                        ModificarTitular();
                    }                
                #endregion
                       

            #endregion

            #region ANIMALES
             
                private void tsbNuevoAnimal_Click(object sender, EventArgs e)
                {
                    if (ModoActual == Modo.Actualizar)
                    { 
                        Animal ObjCrear = new Animal();                       
                        this.LanzarFormulario(new EditAnimales(Modo.Guardar, ObjCrear),dtgAnimales);
                          
                    }
                    
                
                }

                private void tsbModificarAnimal_Click(object sender, EventArgs e)
                {
                    ModificarAnimal();
                }

                private void ModificarAnimal()
                {
                    Animal ObjActualizar=null;
                    if (this.dtgAnimales.SelectedRows.Count == 1 && this.ModoActual== Modo.Actualizar)
                    {

                       
                        ObjActualizar = (Animal)this.dtgAnimales.CurrentRow.DataBoundItem;                     
                        this.LanzarFormulario(new EditAnimales(Modo.Actualizar, ObjActualizar),this.dtgAnimales);
                                            

                        
                    }
                }

                private void tsbEliminarAnimal_Click(object sender, EventArgs e)
                {
                  
                    this.EliminarObjGrid(this.dtgAnimales, "Va a eliminar el Animal de la Aplicación.\r¿Esta usted seguro de que desea continuar?");

                   
                  
                }

                private void dtgAnimales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                    ModificarAnimal();
                }


            #endregion

            #region ESPECIES
            //No es posible modificar porque la tabla esta compuesta solo por claves
            //para modificar hay que borrar e insertar.

                private void tsbNuevaEspecie_Click(object sender, EventArgs e)
                {
                    if (this.ModoActual == Modo.Actualizar)
                    {
                        ExpEsp ObjNuevo = null;
                        ObjNuevo= new ExpEsp();
                        
                        EditExpEsp frmEditExpEsp = new EditExpEsp(Modo.Guardar, ObjNuevo) { ValorIdExplotacionFijo = this.ObjetoBase.Id };

                        this.LanzarFormulario(frmEditExpEsp,this.dtgEspecies);
                        

                      
                     
                    }
                }

                private void tsbEliminarEspecie_Click(object sender, EventArgs e)
                {
                                      
                    this.EliminarObjGrid(this.dtgEspecies, "Va a eliminar la asignación de la especie a la explotación en edición.\r¿Esta usted seguro de que desea continuar?");

                }

               
            
            #endregion

            #region CONTACTOS
                private void tsbNuevoContacto_Click(object sender, EventArgs e)
                {
                    if (ModoActual == Modo.Actualizar)
                    {
                        Contacto ObjCrear = new Contacto();
                        this.LanzarFormulario(new EditContacto(Modo.Guardar, ObjCrear) { ValorFijoIdExplotacion = this.ObjetoBase.Id }, dtgContacto);

                    }
                }

                private void tsbModificarContacto_Click(object sender, EventArgs e)
                {
                    ModificarContacto();

                }

                private void ModificarContacto()
                {
                    Contacto ObjActualizar = null;
                    if (this.dtgContacto.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
                    {
                        ObjActualizar = (Contacto)this.dtgContacto.CurrentRow.DataBoundItem;
                        this.LanzarFormulario(new EditContacto(Modo.Actualizar, ObjActualizar) { ValorFijoIdExplotacion = this.ObjetoBase.Id }, this.dtgContacto);

                    }
                }

                private void tsbEliminarContacto_Click(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgContacto, "Va a eliminar el Contacto de la Aplicación.\r¿Esta usted seguro de que desea continuar?");

                }

                private void dtgContacto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                    ModificarContacto();
                }
        

            

            #endregion

            #region LOTES ANIMALES
                private void tsbNuevoLoteAnimal_Click(object sender, EventArgs e)
                {
                    if (ModoActual == Modo.Actualizar)
                    {
                        LoteAnimal ObjCrear = new LoteAnimal();
                        this.LanzarFormulario(new EditLoteAnimal(Modo.Guardar, ObjCrear) { ValorFijoIdExplotacion = this.ObjetoBase.Id }, dtgLotesAnimales);
                    }
                }

                private void tsbModificarLoteAnimal_Click(object sender, EventArgs e)
                {
                    ModificarLoteAnimal();
                }

                private void ModificarLoteAnimal()
                {
                    LoteAnimal ObjActualizar = null;
                    if (this.dtgLotesAnimales.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
                    {
                        ObjActualizar = (LoteAnimal)this.dtgLotesAnimales.CurrentRow.DataBoundItem;
                        this.LanzarFormulario(new EditLoteAnimal(Modo.Actualizar, ObjActualizar) { ValorFijoIdExplotacion = this.ObjetoBase.Id }, this.dtgLotesAnimales);

                    }
                }

                private void tsbEliminarLoteAnimal_Click(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgLotesAnimales, "Va a eliminar el Lote de la Aplicación.\r¿Esta usted seguro de que desea continuar?");
                }

                private void dtgLotesAnimales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                    ModificarLoteAnimal();
                }
            #endregion

            #region MODULOS
                //No es posible modificar porque la tabla esta compuesta solo por claves
                //para modificar hay que borrar e insertar.

            
                private void tsbNuevoModulo_Click(object sender, EventArgs e)
                {
                    if (this.ModoActual == Modo.Actualizar)
                    {
                        ExpMod ObjNuevo =  new ExpMod();

                        EditExpMod frmEditExpMod = new EditExpMod(Modo.Guardar, ObjNuevo) { ValorIdExplotacionFijo = this.ObjetoBase.Id };

                        this.LanzarFormulario(frmEditExpMod, this.dtgModulos);
                        

                    }

                }

                private void tsbEliminarModulo_Click(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgModulos, "Va a eliminar la asignación del Módulo a la explotación en edición.\r¿Esta usted seguro de que desea continuar?");
                }

           

                #endregion

            #region TRATAMIENTOS DE HIGIENE
                private void tsbNuevoTratHigiene_Click(object sender, EventArgs e)
                {
                     if (ModoActual == Modo.Actualizar)
                     {
                         TratHigiene ObjCrear = new TratHigiene();
                         this.LanzarFormulario(new EditTratHigiene(Modo.Guardar, ObjCrear), dtgTratHigiene);
                     }
                }
                private void ModificarTratHigiene()
                {
                    TratHigiene ObjActualizar = null;
                    if (this.dtgTratHigiene.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
                    {
                        ObjActualizar = (TratHigiene)this.dtgTratHigiene.CurrentRow.DataBoundItem;
                        this.LanzarFormulario(new EditTratHigiene(Modo.Actualizar, ObjActualizar), this.dtgTratHigiene);
                    }
                }

                private void tsbModificarTratHigiene_Click(object sender, EventArgs e)
                {
                    ModificarTratHigiene();
                }

                private void tsbEliminarTratHigiene_Click(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgTratHigiene, "Va a eliminar el Tratamiento de Higiene de la Explotación.\r¿Esta usted seguro de que desea continuar?");
                }

                private void dtgTratHigiene_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                    ModificarTratHigiene();
                }

                ////private void tsbNuevoLoteAnimal_Click(object sender, EventArgs e)
                ////{
                ////    if (ModoActual == Modo.Actualizar)
                ////    {
                ////        LoteAnimal ObjCrear = new LoteAnimal();
                ////        this.LanzarFormulario(new EditLoteAnimal(Modo.Guardar, ObjCrear) { ValorFijoIdExplotacion = this.ObjetoBase.Id }, dtgLotesAnimales);
                ////    }
                ////}

                ////private void tsbModificarLoteAnimal_Click(object sender, EventArgs e)
                ////{
                ////    ModificarLoteAnimal();
                ////}

                ////private void ModificarLoteAnimal()
                ////{
                ////    LoteAnimal ObjActualizar = null;
                ////    if (this.dtgLotesAnimales.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
                ////    {
                ////        ObjActualizar = (LoteAnimal)this.dtgLotesAnimales.CurrentRow.DataBoundItem;
                ////        this.LanzarFormulario(new EditLoteAnimal(Modo.Actualizar, ObjActualizar) { ValorFijoIdExplotacion = this.ObjetoBase.Id }, this.dtgLotesAnimales);

                ////    }
                ////}

                ////private void tsbEliminarLoteAnimal_Click(object sender, EventArgs e)
                ////{
                ////    this.EliminarObjGrid(this.dtgLotesAnimales, "Va a eliminar el Lote de la Aplicación.\r¿Esta usted seguro de que desea continuar?");
                ////}

                ////private void dtgLotesAnimales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                ////{
                ////    ModificarLoteAnimal();
                ////}
                #endregion

            #region CLIENTES

                #region OPERACIONES

                    void ModificarCliente()
                    {
                        if (this.dtgClientes.SelectedRows.Count == 1 && ModoActual == Modo.Actualizar)
                        {
                            //preparo el formulario que voy a lanzar
                            Cliente ObjActualizar = (Cliente)this.dtgClientes.CurrentRow.DataBoundItem;
                            this.LanzarFormulario(new EditCliente(Modo.Actualizar, ObjActualizar), dtgClientes);
                        }
                    }

                    void AgregarCliente()
                    {
                        if (this.ModoActual == Modo.Actualizar)
                        {
                            Cliente ObjActualizar = new Cliente();

                            EditCliente frmEditClientes = new EditCliente(Modo.Guardar, ObjActualizar) { ExplotacionAsignada = true };

                            if (this.LanzarFormulario(frmEditClientes) == DialogResult.OK)
                                AgregarRelacionClienteExplotacion(frmEditClientes.ObjetoBase);
                        }
                    }

                    void EliminarCliente()
                    {
                        this.EliminarObjGrid(this.dtgClientes, "Va a eliminar el Cliente de la Aplicación.\rSi el Cliente ha sido asignado a otra explotación, se borrará dicha asignación.\r¿Esta usted seguro de que desea continuar?");
                    }

                    private void AgregarRelacionClienteExplotacion(Cliente cliente)
                    {
                        if (cliente != null && cliente.Id != 0)
                        {
                            ExpCli expcli = new ExpCli();
                            this.IniciarContextoOperacion();

                            try
                            {
                                expcli.IdExplotacion = this.ObjetoBase.Id;
                                expcli.IdCliente = cliente.Id;
                                expcli.FechaInicio = DateTime.Now;

                                expcli.Insertar();

                                CargarGrids();

                                SeleccionarObjGrid(expcli.Cliente, this.dtgClientes);
                            }
                            catch (LogicException ex)
                            {
                                Generic.AvisoAdvertencia("No se ha podido guardar la relación.\rMensaje: " + ex.Message);
                                this.ObjetoBase.ExpCli.Remove(expcli);
                            }
                            catch (Exception ex)
                            {
                                Generic.AvisoError("No se ha podido guardar la relación ExpCli en el formulario EditExplotaciones.\rMensaje: " + ex.Message);
                                this.ObjetoBase.ExpCli.Remove(expcli);
                            }
                            finally
                            {
                                expcli = null;
                                this.FinalizarContextoOperacion();
                            }
                        }
                    }

                    private void EliminarRelacionClienteExplotacion()
                    {
                        if (this.dtgClientes.SelectedRows.Count == 1 && ModoActual == Modo.Actualizar)
                        {
                            this.IniciarContextoOperacion();

                            try
                            {
                                Cliente ObjetoBaseCliente = (Cliente)this.dtgClientes.CurrentRow.DataBoundItem;

                                ExpCli expcli = ExpCli.Buscar(this.ObjetoBase.Id, ObjetoBaseCliente.Id);

                                if (expcli != null)
                                    if (DialogResult.Yes == Generic.Aviso("Va a eliminar la relación de Cliente con la explotación.\r¿Esta usted seguro de que desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                    {
                                        expcli.Eliminar();
                                        CargarGrids();
                                    }
                            }
                            catch (LogicException ex)
                            {
                                Generic.AvisoAdvertencia("No se ha podido eliminar la relación.\rMensaje: " + ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Generic.AvisoError("No se ha podido eliminar la relación ExpTit en el formulario EditExplotaciones.\rMensaje: " + ex.Message);
                            }
                            finally { this.FinalizarContextoOperacion(); ; }
                        }
                    }

                #endregion

                #region BARRA BOTONES GRID

                    private void tsmClienteNuevo_Click(object sender, EventArgs e)
                    {
                        AgregarCliente();
                    }

                    private void tsbNuevoCliente_ButtonClick(object sender, EventArgs e)
                    {
                        AgregarCliente();
                    }

                    private void tsmClienteExistente_Click(object sender, EventArgs e)
                    {
                        if (this.ModoActual == Modo.Actualizar)
                        {
                            ctlBuscarObjeto rdoBusqueda = new ctlBuscarObjeto();
                            FindCliente frmFindCliente = new FindCliente(Modo.Consultar, rdoBusqueda);

                            this.LanzarFormulario(frmFindCliente);

                            AgregarRelacionClienteExplotacion((Cliente)rdoBusqueda.SelectedItem);
                        }
                    }

                    private void tsbModificarCliente_Click(object sender, EventArgs e)
                    {
                        ModificarCliente();
                    }

                    private void tsmEliminarExpCli_Click(object sender, EventArgs e)
                    {
                        EliminarRelacionClienteExplotacion();
                    }

                    private void tsbEliminarCliente_ButtonClick(object sender, EventArgs e)
                    {
                        this.EliminarRelacionClienteExplotacion();
                    }

                    private void tsmEliminarCliente_Click(object sender, EventArgs e)
                    {
                        EliminarCliente();
                    }

                #endregion

                #region EVENTOS

                    private void dtgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                    {
                        ModificarCliente();
                    }

                #endregion

            #endregion

            #region PROVEEDORES

                #region OPERACIONES

                    void ModificarProveedor()
                    {
                        if (this.dtgProveedores.SelectedRows.Count == 1 && ModoActual == Modo.Actualizar)
                        {
                            //preparo el formulario que voy a lanzar
                            Proveedor ObjActualizar = (Proveedor)this.dtgProveedores.CurrentRow.DataBoundItem;
                            this.LanzarFormulario(new EditProveedor(Modo.Actualizar, ObjActualizar), dtgProveedores);
                        }
                    }

                    void AgregarProveedor()
                    {
                        if (this.ModoActual == Modo.Actualizar)
                        {
                            Proveedor ObjActualizar = new Proveedor();

                            EditProveedor frmEditProveedores = new EditProveedor(Modo.Guardar, ObjActualizar) { ExplotacionAsignada = true };

                            if (this.LanzarFormulario(frmEditProveedores) == DialogResult.OK)
                                AgregarRelacionProveedorExplotacion(frmEditProveedores.ObjetoBase);
                        }
                    }

                    void EliminarProveedor()
                    {
                        this.EliminarObjGrid(this.dtgProveedores, "Va a eliminar el Proveedor de la Aplicación.\rSi el Proveedor ha sido asignado a otra explotación, se borrará dicha asignación.\r¿Esta usted seguro de que desea continuar?");
                    }

                    private void AgregarRelacionProveedorExplotacion(Proveedor proveedor)
                    {
                        if (proveedor != null && proveedor.Id != 0)
                        {
                            ExpPro exppro = new ExpPro();
                            this.IniciarContextoOperacion();

                            try
                            {
                                exppro.IdExplotacion = this.ObjetoBase.Id;
                                exppro.IdProveedor = proveedor.Id;
                                exppro.FechaInicio = DateTime.Now;

                                exppro.Insertar();

                                CargarGrids();

                                SeleccionarObjGrid(exppro.Proveedor, this.dtgProveedores);
                            }
                            catch (LogicException ex)
                            {
                                Generic.AvisoAdvertencia("No se ha podido guardar la relación.\rMensaje: " + ex.Message);
                                this.ObjetoBase.ExpPro.Remove(exppro);
                            }
                            catch (Exception ex)
                            {
                                Generic.AvisoError("No se ha podido guardar la relación ExpPro en el formulario EditExplotaciones.\rMensaje: " + ex.Message);
                                this.ObjetoBase.ExpPro.Remove(exppro);
                            }
                            finally
                            {
                                exppro = null;
                                this.FinalizarContextoOperacion();
                            }
                        }
                    }

                    private void EliminarRelacionProveedorExplotacion()
                    {
                        if (this.dtgProveedores.SelectedRows.Count == 1 && ModoActual == Modo.Actualizar)
                        {
                            this.IniciarContextoOperacion();

                            try
                            {
                                Proveedor ObjetoBaseProveedor = (Proveedor)this.dtgProveedores.CurrentRow.DataBoundItem;

                                ExpPro exppro = ExpPro.Buscar(this.ObjetoBase.Id, ObjetoBaseProveedor.Id);

                                if (exppro != null)
                                    if (DialogResult.Yes == Generic.Aviso("Va a eliminar la relación de Proveedor con la explotación.\r¿Esta usted seguro de que desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                    {
                                        exppro.Eliminar();
                                        CargarGrids();
                                    }
                            }
                            catch (LogicException ex)
                            {
                                Generic.AvisoAdvertencia("No se ha podido eliminar la relación.\rMensaje: " + ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Generic.AvisoError("No se ha podido eliminar la relación ExpPro en el formulario EditExplotaciones.\rMensaje: " + ex.Message);
                            }
                            finally { this.FinalizarContextoOperacion(); ; }
                        }
                    }

                #endregion

                #region BARRA BOTONES GRID

                    private void tsmProveedorNuevo_Click(object sender, EventArgs e)
                    {
                        AgregarProveedor();
                    }

                    private void tsbNuevoProveedor_ButtonClick(object sender, EventArgs e)
                    {
                        AgregarProveedor();
                    }

                    private void tsmProveedorExistente_Click(object sender, EventArgs e)
                    {
                        if (this.ModoActual == Modo.Actualizar)
                        {
                            ctlBuscarObjeto rdoBusqueda = new ctlBuscarObjeto();
                            FindProveedor frmFindProveedor = new FindProveedor(Modo.Consultar, rdoBusqueda);

                            this.LanzarFormulario(frmFindProveedor);

                            AgregarRelacionProveedorExplotacion((Proveedor)rdoBusqueda.SelectedItem);
                        }
                    }

                    private void tsbModificarProveedor_Click(object sender, EventArgs e)
                    {
                        ModificarProveedor();
                    }

                    private void tsmEliminarExpPro_Click(object sender, EventArgs e)
                    {
                        EliminarRelacionProveedorExplotacion();
                    }

                    private void tsbEliminarProveedor_ButtonClick(object sender, EventArgs e)
                    {
                        EliminarRelacionProveedorExplotacion();
                    }

                    private void tsmEliminarProveedor_Click(object sender, EventArgs e)
                    {
                        EliminarProveedor();
                    }

                #endregion

                #region EVENTOS

                    private void dtgProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                    {
                        ModificarProveedor();
                    }

                #endregion

            #endregion

        #endregion

        #region PROPIEDADES PARA PROCESOS
                    
            [ProcesoDescripcion("Edición de Explotaciones - Muestra la pestaña: Contactos", "Agenda")]
            public bool _proceso_Agenda
            {
                set
                {
                    if (!value)tspExplotacion.TabPages.Remove(tbpContactos);
                }
            }
            [ProcesoDescripcion("Edición de Explotaciones - Muestra la pestaña: Tratamientos de Higiene", "Sanidad")]
            public bool _proceso_Sanidad
            {
                set
                {
                    if (!value) tspExplotacion.TabPages.Remove(tbpTratHigiene);
                }
            }
            [ProcesoDescripcion("Edición de Explotaciones - Muestra las pestañas: Clientes y Proveedores", "Economia")]
            public bool _proceso_Economia
            {
                set
                {
                    if (!value)
                    {
                        tspExplotacion.TabPages.Remove(tbpClientes);
                        tspExplotacion.TabPages.Remove(tbpProveedores);
                    }
                }
            }
          

        #endregion

        #region COMBOS
            
            private void cmbProvincia_CrearNuevo(object sender, ctlComboCrearNuevoEventArgs e)
            {
                
                Provincia ObjetoBase = new Provincia();
                EditProvincia editProvincia = new EditProvincia(Modo.Guardar, ObjetoBase);                    
                editProvincia.Descripcion = e.TextoCrear;
                editProvincia.AccionDespuesInsertar = AccionesDespuesInsertar.Cerrar;

                CrearNuevoElementoCombo(editProvincia,sender);
            }
            private void cmbProvincia_CargarContenido(object sender, System.EventArgs e)
            {
                this.CargarCombo(cmbProvincia, Provincia.Buscar());
            }
            private void cmbProvincia_SelectedValueChanged(object sender, EventArgs e)
            {
                cmbMunicipio.CargarCombo();
            }

            private void cmbCJuridica_CrearNuevo(object sender, ctlComboCrearNuevoEventArgs e)
            {
                CondicionJuridica ObjetoBase = new CondicionJuridica();
                GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ObjetoBase);
                frmLanzar.Titulo = "Condición Jurídica";
                frmLanzar.NumColumnas = 2;
                frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción") { ValorDefecto = e.TextoCrear });

                CrearNuevoElementoCombo(frmLanzar, sender);
            }
            private void cmbCJuridica_CargarContenido(object sender, System.EventArgs e)
            {
                this.CargarCombo(cmbCJuridica, CondicionJuridica.Buscar());
            }

            private void cmbMunicipio_CargarContenido(object sender, System.EventArgs e)
            {
                if (this.cmbProvincia.SelectedValue != null)
                    this.CargarCombo(cmbMunicipio, Municipio.Buscar(string.Empty, string.Empty, (int)this.cmbProvincia.SelectedValue));
                else
                    this.cmbMunicipio.DataSource = null;

                this.cmbMunicipio.Text = string.Empty;
                this.cmbMunicipio.SelectedIndex = -1;

            }
            private void cmbMunicipio_CrearNuevo(object sender, ctlComboCrearNuevoEventArgs e)
            {
                int? idProvincia = Generic.ControlAIntNullable(cmbProvincia);
                if (idProvincia.HasValue)
                {
                    Municipio ObjetoBase = new Municipio();                  
                    EditMunicipios editMunicipio = new EditMunicipios(Modo.Guardar, ObjetoBase);
                    editMunicipio.ValorFijoIdProvincia = idProvincia;
                    editMunicipio.Descripcion = e.TextoCrear;

                    CrearNuevoElementoCombo(editMunicipio, sender);
                }
                else
                    Generic.PonerError(this.ErrorProvider, cmbMunicipio, "Para poder crear un municio es necesario tener seleccionada la provincia.");

            }
         

        #endregion        
           
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Reflection;

namespace GEXVOC.UI
{
    public partial class EditLoteAnimal : GEXVOC.UI.GenericEdit
    {
      
        #region CONTRUCTORES
        public EditLoteAnimal()
        {
            InitializeComponent();
        }
        public EditLoteAnimal(Modo modo, LoteAnimal ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }

        public EditLoteAnimal(Modo modo, LoteAnimal ClaseBase, int numTabSeleccionar)
                : base(modo, ClaseBase, numTabSeleccionar)
            {
                InitializeComponent();
           
            }
        public EditLoteAnimal(Modo modo, LoteAnimal ClaseBase, string TabSeleccionar)
            : base(modo, ClaseBase, TabSeleccionar)
        {
            InitializeComponent();

        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            public LoteAnimal ObjetoBase { get { return (LoteAnimal)this.ClaseBase; } }
            int? _ValorFijoIdExplotacion = null;
            /// <summary>
            /// Propiedad que nos indica si el formulario debe aparecer con el combo de la explotacion fijo y con la explotacion que corresponde 
            /// con el Id especificado aqui.
            /// </summary>
            public int? ValorFijoIdExplotacion
            {
                get { return _ValorFijoIdExplotacion; }
                set
                {
                    if (value != null)
                    {
                        this.cmbExplotacion.ClaseActiva = Explotacion.Buscar((int)value);
                        this.cmbExplotacion.ReadOnly = true;

                    }
                    else
                        this.cmbExplotacion.ReadOnly = false;

                    _ValorFijoIdExplotacion = value;
                }
            }
        #endregion       

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                cmbExplotacion.TipoDatos = typeof(Explotacion);
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdExplotacion", true, this.cmbExplotacion, lblExplotacion));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTipo", true, this.cmbTipoLote, lblTipoLote));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Descripcion", true, this.txtDescripcion, lblDescripcion));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaAlta", true, this.txtFechaAlta, lblFecAlta));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaBaja", false, this.txtFechaBaja, lblFecBaja));

                base.DefinirListaBinding();
            }

            private void EditLoteAnimal_PropiedadAControl(object sender, PropiedadBindEventArgs e)
            {           
                if (e.Control==cmbTipoLote)
                {
                    cmbTipoLote.Enabled = false;
                }
            }


        #endregion

        #region CARGAS COMUNES
            public override void Cargar()
            {
                if (Configuracion.Explotacion==null)
                  throw new LogicException("No es posible mostrar el formulario porque no se encuentra una explotación activa");

                base.Cargar();
            }
                
            protected override void CargarGrids()
            {
                this.dtgContenido.DataSource = this.ObjetoBase.lstAniLot;
                this.dtgCubriciones.DataSource = this.ObjetoBase.lstCubriciones;
                this.dtgLotes.DataSource = this.ObjetoBase.lstLotesParidera;
                base.CargarGrids();
            }
                   
            protected override void CargarValoresDefecto()
            {
                //Establezo el valor de la explotacion de configuracion por defecto, si no se llama al formulario con explotacion fija
                if ((this.ObjetoBase ==null || this.ObjetoBase.IdExplotacion==0) && ValorFijoIdExplotacion==null)            
                    ValorFijoIdExplotacion = Configuracion.Explotacion.Id;
                
            

                //base.CargarValoresDefecto();
            }

            protected override void CargarCombos()
            {
                this.cmbTipoLote.CargarCombo();
            }
        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarExplotacion_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindExplotaciones(Modo.Consultar, this.cmbExplotacion));
            }

            private void chkParidera_CheckedChanged(object sender, EventArgs e)
            {
                ActualizarTabPages();
            }

            /// <summary>
            /// Dependiendo del valor que tenga el chk paridera se muestran unas pestañas u otras:
            ///  - Si el Lote NO es una Paridera: se muestran las pestañas Animales y cubriciones.
            ///  - Si el Lote es una Paridera: Se muestra la pestaña Lotes.
            /// </summary>
            private void ActualizarTabPages()
            {

                tbcContenido.TabPages.Clear();
                if (chkParidera.Checked)
                    tbcContenido.TabPages.Add(tbpLotes);
                else
                {
                    tbcContenido.TabPages.Add(tbpContenido);
                    tbcContenido.TabPages.Add(tbpCubriciones);
                }

            }

            private void EditLoteAnimal_Load(object sender, EventArgs e)
            {
                ActualizarTabPages();
            }

            private void EditLoteAnimal_ModoCambiado(object sender, ModoEventArgs e)
            {
                if (e.modo == Modo.Actualizar)
                    chkParidera.Enabled = false;
            }

        #endregion
                          
        #region GRID - ANIMALES
            private void tsbNuevoContenido_Click(object sender, EventArgs e)
            {
                if (this.ModoActual == Modo.Actualizar)
                {
                    AniLot ObjLanzar = new AniLot();

                    EditAniLotLotes frmLanzar = new EditAniLotLotes(Modo.GuardarMultiple, ObjLanzar) { ValorFijoIdLote = this.ObjetoBase.Id,ValorInicialFecha=this.ObjetoBase.FechaAlta };
                    this.LanzarFormulario(frmLanzar, this.dtgContenido);

                }
            }

            private void tsbModificarContenido_Click(object sender, EventArgs e)
            {
                ModificarContenido();
            }

            private void ModificarContenido()
            {
                if (this.ModoActual == Modo.Actualizar && this.dtgContenido.SelectedRows.Count == 1)
                {
                    AniLot ObjLanzar = (AniLot)this.dtgContenido.CurrentRow.DataBoundItem;
                    EditAniLotLotes frmLanzar = new EditAniLotLotes(Modo.Actualizar, ObjLanzar) { ValorFijoIdLote = ObjLanzar.Id, ValorFijoIdAnimal = ObjLanzar.IdAnimal };
                    this.LanzarFormulario(frmLanzar, this.dtgContenido);

                }
            }

            private void tsbEliminarContenido_Click(object sender, EventArgs e)
            {
                this.EliminarObjGrid(this.dtgContenido, "Va a eliminar el Animal del lote.\r¿Esta usted seguro de que desea continuar?");
            }

            private void dtgContenido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                ModificarContenido();
            }

     
        #endregion

        #region GRID - CUBRICIONES
            private void tsbNuevaCubricion_Click(object sender, EventArgs e)
            {
                if (this.ModoActual == Modo.Actualizar)
                {
                    Cubricion ObjLanzar = new Cubricion();

                    EditCubricion frmLanzar = new EditCubricion(Modo.Guardar, ObjLanzar) {  ValorFijoIdLote= this.ObjetoBase.Id };
                    this.LanzarFormulario(frmLanzar, this.dtgContenido);

                }
            }
            private void ModificarCubricion()
            {
                if (this.ModoActual == Modo.Actualizar && this.dtgCubriciones.SelectedRows.Count == 1)
                {
                    Cubricion ObjLanzar = (Cubricion)this.dtgCubriciones.CurrentRow.DataBoundItem;
                    EditCubricion frmLanzar = new EditCubricion(Modo.Actualizar, ObjLanzar) { ValorFijoIdLote = ObjLanzar.IdLote };
                    this.LanzarFormulario(frmLanzar, this.dtgCubriciones);

                }
            }

            private void tsbModificarCubricion_Click(object sender, EventArgs e)
            {
                ModificarCubricion();
            }

            private void tsbEliminarCubricion_Click(object sender, EventArgs e)
            {
                this.EliminarObjGrid(this.dtgCubriciones, "Va a eliminar las cubriciónes del lote.\r¿Esta usted seguro de que desea continuar?");

            }

            private void dtgCubriciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                ModificarCubricion();
            }
        #endregion

        #region GRID - LOTES

            private void tsbNuevoLote_Click(object sender, EventArgs e)
            {
                if (this.ModoActual == Modo.Actualizar)
                {

                    GEXVOC.Core.Controles.ctlBuscarObjeto buscar = new GEXVOC.Core.Controles.ctlBuscarObjeto();
                    FindLoteAnimal frmLanzar = new FindLoteAnimal(Modo.Consultar, buscar) { ValorFijoParidera=false};
                    
                    LanzarFormularioConsulta(frmLanzar);
                    if (buscar.ClaseActiva != null)
                    {
                        BD.IniciarBDOperaciones();
                        try
                        {
                            LoteAnimal lote = (LoteAnimal)buscar.ClaseActiva;
                            lote = (LoteAnimal)lote.CargarContextoOperacion(TipoContexto.Modificacion);
                            lote.IdParidera = this.ObjetoBase.Id;
                            lote.Actualizar();
                        }
                        catch (LogicException ex)
                        {
                            Generic.AvisoAdvertencia(ex.Message);
                        }
                        catch (Exception)
                        {
                            Generic.AvisoError("No se ha podido realizar la asociación.");
                            //throw;
                        }
                        finally { BD.FinalizarBDOperaciones(); }

                        this.CargarGrids();
                    }
                }

            }

          

            private void tsbEliminarLote_Click(object sender, EventArgs e)
            {
                if (this.ModoActual == Modo.Actualizar)
                {
                    if (dtgLotes.SelectedRows!=null && dtgLotes.SelectedRows.Count>0)
                    {
                        BD.IniciarBDOperaciones();
                        try
                        {
                            foreach (DataGridViewRow item in dtgLotes.SelectedRows)
                            {
                               // AniLot anilot=(AniLot)item.DataBoundItem;
                                LoteAnimal lote = (LoteAnimal)item.DataBoundItem;// LoteAnimal.Buscar(anilot.IdLote);
                                lote = (LoteAnimal)lote.CargarContextoOperacion(TipoContexto.Modificacion);
                                lote.IdParidera = null;
                                lote.Actualizar();                                                            
                            }
                        }
                        catch (LogicException ex)
                        {
                            Generic.AvisoAdvertencia(ex.Message);
                        }
                        catch (Exception)
                        {
                            Generic.AvisoError("No se ha podido eliminar la asociación.");
                            
                        }
                        finally 
                        { 
                            BD.FinalizarBDOperaciones();                        
                            this.CargarGrids();
                        }
                        
                    }

                  
                }
            }
        #endregion

        #region PROPIEDADES PARA PROCESOS

            [ProcesoDescripcion("Edición de Lotes - Muestra la pestaña: Cubriciones", "Reproducción")]
            public bool _proceso_Reproduccion
            {
                set
                {
                    if (!value) tbcContenido.TabPages.Remove(tbpCubriciones);

                }
            }

       #endregion

        #region COMBOS
            private void cmbTipoLote_SelectedValueChanged(object sender, EventArgs e)
            {
                if (cmbTipoLote.SelectedValue != null && (int)cmbTipoLote.SelectedValue == Configuracion.TipoLoteSistema(Configuracion.TiposLoteSistema.LOTE_DE_PARIDERA).Id)
                    chkParidera.Checked = true;
                else
                    chkParidera.Checked = false;
            }

            private void cmbTipoLote_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(this.cmbTipoLote, TipoLote.Buscar());    
            }

            private void cmbTipoLote_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {                
                TipoLote ObjetoBase = new TipoLote();
                GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ObjetoBase);
                frmLanzar.Titulo = "Tipo Lote";
                frmLanzar.NumColumnas = 2;
                frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción") { ValorDefecto = e.TextoCrear });

                CrearNuevoElementoCombo(frmLanzar, sender);

            }
        #endregion
    }
} 
//---------------------Código Comentado----------------------------------------------//
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    List<Animal>lstAnimalesIniciales=this.ObjetoBase.lstAnimales;
        //    SelectorAnimales frmSelectorAnimales = new SelectorAnimales(Modo.Consultar, lstAnimalesIniciales);
        //    this.LanzarFormulario(frmSelectorAnimales);

        //    List<Animal> lstAnimalesAgregar = frmSelectorAnimales.LstAnimalesSeleccionadosRtno;
        //    if (lstAnimalesAgregar!=null)
        //    {

        //        //Primero elimino los animales iniciales de los que se encuentran en la selección
        //        foreach (Animal item in lstAnimalesIniciales)
        //        {
        //            Animal animal = lstAnimalesAgregar.Find(E => E.Id == item.Id);
        //            if (animal!=null)                    
        //                lstAnimalesAgregar.Remove(animal);                        

        //        }

        //        string mensajeError = string.Empty;
        //        foreach (Animal item in lstAnimalesAgregar)
        //        {
        //            try
        //            {
        //                IniciarContextoOperacion();
        //                AniLot anilot = new AniLot();
        //                anilot.IdAnimal = item.Id;
        //                anilot.IdLote = this.ObjetoBase.Id;
        //                anilot.FechaInicio = DateTime.Today;
        //                anilot.Insertar();
        //            }
        //            catch (Exception ex)
        //            {
        //                mensajeError += ex.Message + "\r";
        //            }
        //            finally { FinalizarContextoOperacion(); }                    

        //        }
        //        if (mensajeError != string.Empty)
        //            Generic.AvisoError("Se han producido los siguientes errores:\r" + mensajeError);

        //        this.CargarGrids();                
        //    }

        //}
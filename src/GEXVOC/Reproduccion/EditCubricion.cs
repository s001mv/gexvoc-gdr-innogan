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
    public partial class EditCubricion : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditCubricion()
        {
            InitializeComponent();
        }
        public EditCubricion(Modo modo, Cubricion ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            public Cubricion ObjetoBase { get { return (Cubricion)this.ClaseBase; } }

            int? _ValorFijoIdLote = null;
            /// <summary>
            /// Propiedad que nos indica si el formulario debe aparecer con el combo del lote fijo y con el que corresponde 
            /// con el Id especificado aqui.
            /// </summary>
            public int? ValorFijoIdLote
            {
                get { return _ValorFijoIdLote; }
                set
                {
                    if (value != null)
                    {
                        this.cmbLote.ClaseActiva = LoteAnimal.Buscar((int)value);
                        this.cmbLote.ReadOnly = true;
                    }
                    else
                        this.cmbLote.ReadOnly = false;

                    _ValorFijoIdLote = value;
                }
            }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {              
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdLote", true, this.cmbLote, lblLote));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTipo", true, this.cmbTipo, lblTipo));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaInicio", true, this.txtFechaIni, lblFechaIni));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaFin", false, this.txtFechaFin, lblFechaFin));
                base.DefinirListaBinding();
            }
            private void EditCubricion_PropiedadAControl(object sender, PropiedadBindEventArgs e)
            {
                if (e.Control == this.cmbLote)
                {
                    cmbLote.ClaseActiva = LoteAnimal.Buscar(this.ObjetoBase.IdLote);
                    cmbLote.ReadOnly = true;
                    e.Cancelar = true;
                }
            }
        #endregion

        #region CARGAS COMUNES

            protected override void CargarCombos()
            {
                cmbTipo.CargarCombo();
            }
           protected override void CargarGrids()
            {
                this.dtgContenido.DataSource = this.ObjetoBase.lstEstancias;
                base.CargarGrids();
            }

        #endregion

        #region GRID ESTANCIAS
           private void ModificarEstancia()
           {

               if (this.dtgContenido.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
               {
                   Estancia ObjActualizar = (Estancia)this.dtgContenido.CurrentRow.DataBoundItem;
                   this.LanzarFormulario(new EditEstancia(Modo.Actualizar, ObjActualizar) { ValorFijoIdCubricion = ObjActualizar.IdCubricion, ValorFijoIdMacho = ObjActualizar.IdMacho, ValorFijoFechaInicio = ObjActualizar.FechaInicio }, this.dtgContenido);
                   //                   this.LanzarFormulario(new EditEstancia(Modo.Actualizar, ObjActualizar) { ValorFijoIdCubricion = ObjActualizar.IdCubricion }, this.dtgContenido);

               }
           }
          
           private void tsbNuevoContenido_Click(object sender, EventArgs e)
           {
               if (ModoActual == Modo.Actualizar)
               {
                   Estancia ObjCrear = new Estancia();
                   this.LanzarFormulario(new EditEstancia(Modo.Guardar, ObjCrear) { ValorFijoIdCubricion = this.ObjetoBase.Id }, dtgContenido);
               }
           }
           private void tsbModificarContenido_Click(object sender, EventArgs e)
           {
               ModificarEstancia();
           }
           private void tsbEliminarContenido_Click(object sender, EventArgs e)
           {
               this.EliminarObjGrid(this.dtgContenido, "Va a eliminar las estancias.\r¿Esta usted seguro de que desea continuar?");
           }
           private void dtgContenido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
           {
               ModificarEstancia();
           }            
        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnbuscarLote_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindLoteAnimal(Modo.Consultar, this.cmbLote) { ValorFijoParidera=false});
            }
        #endregion        

        #region COMBOS
            private void cmbTipo_CargarContenido(object sender, System.EventArgs e)
            {
                this.CargarCombo(cmbTipo, TipoCubricion.Buscar());
            }
            private void cmbTipo_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                      
                TipoCubricion ObjetoBase = new TipoCubricion();
                GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ObjetoBase);
                frmLanzar.Titulo = "Tipo cubrición";
                frmLanzar.NumColumnas = 2;
                frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción") { ValorDefecto=e.TextoCrear});                                

                CrearNuevoElementoCombo(frmLanzar, sender);
                
            }

            private void cmbLote_CrearNuevo(object sender, EventArgs e)
            {
                
                LoteAnimal ObjetoBase = new LoteAnimal();
                EditLoteAnimal editLoteAnimal = new EditLoteAnimal(Modo.Guardar, ObjetoBase);
                

                CrearNuevoElementoCombo(editLoteAnimal, sender);

                //Poner en el formulario LoteAnimal si es necesario
                //public string Descripcion { get { return txtDescripcion.Text; } set { txtDescripcion.Text = value; } }

            }
        #endregion


            

    }
}
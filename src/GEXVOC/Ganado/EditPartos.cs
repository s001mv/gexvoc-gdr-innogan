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
    public partial class EditPartos : GEXVOC.UI.GenericEdit
    {
         #region CONSTRUCTOR E INICIALIZACIONES REQUERIDAS

            /// <summary>
            /// Constructor por defecto
            /// </summary>
            public EditPartos()
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
            public EditPartos(Modo modo, Parto ClaseBase):base(modo, ClaseBase)
            {
                InitializeComponent();
              
               
            }

        #endregion

         #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            /// <summary>
            /// Es una propiedad Tipada que nos devuelve la Clase Base sobre la que actúa el Formulario Edit 
            /// El tipo es popio del formulario, pero implementa siempre la interface  IClaseBase)
            /// </summary>
            public Parto ObjetoBase
            {
                get { return (Parto)ClaseBase; }
                set { ClaseBase = value; }
            }

            int? _ValorFijoIdHembra=null;
            /// <summary>
            /// Propiedad que nos indica si el formulario debe aparecer con el combo de la hembra fijo y con el animal que corresponde 
            /// con el Id especificado aqui.
            /// </summary>
            public int? ValorFijoIdHembra
            {
                get { return _ValorFijoIdHembra; }
                set
                {
                    if (value != null)
                    {
                        
                        this.cmbHembra.ClaseActiva = Animal.Buscar((int)value);
                       
                        this.cmbHembra.ReadOnly = true;                        
                    }
                    else
                        this.cmbHembra.ReadOnly = false;

                    _ValorFijoIdHembra = value; }
            }


          #endregion

         #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdHembra", true, this.cmbHembra, lblHembra));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTipo", true, this.cmbTipo, lblTipo));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdFacilidad", true, this.cmbfacilidad, lblFacilidad));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, this.txtFecha, lblFecha));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Vivos", false, this.txtVivos, lblVivos));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Muertos", false, this.txtMuertos, lblMuertos));
                
                base.DefinirListaBinding();
            }
            private void EditPartos_PropiedadAControl(object sender, PropiedadBindEventArgs e)
            {
                if (e.Control == cmbHembra)
                    this.cmbHembra.ClaseActiva = Animal.Buscar(this.ObjetoBase.IdHembra);

            }           
         #endregion

         #region CARGAS COMUNES

            /// <summary>
            /// Carga los combos del formulario
            /// </summary>
            protected override void CargarCombos()
            {

                this.cmbTipo.DataSource = TipoParto.Buscar(string.Empty, null);
                this.cmbTipo.DisplayMember = "Descripcion";
                this.cmbTipo.ValueMember = "Id";
                this.cmbTipo.SelectedIndex = -1;


                this.cmbfacilidad.DataSource = Facilidad.Buscar(string.Empty, null);
                this.cmbfacilidad.DisplayMember = "Descripcion";
                this.cmbfacilidad.ValueMember = "Id";
                this.cmbfacilidad.SelectedIndex = -1;



            }

            /// <summary>
            /// Carga los Valores por defecto del Formulario de Explotaciones
            /// </summary>
            protected override void CargarValoresDefecto()
            {
                Generic.DatetimeAControl(this.txtFecha, DateTime.Now.Date);
                //this.dtgInseminaciones.DataSource = Inseminacion.BuscarInseminacionesLibres(this.ValorFijoIdHembra);

            }

            /// <summary>
            /// Carga los grids de detalle
            /// </summary>
            protected override void CargarGrids() { 
                //PENDIENTE: AQUI CARGAR TODAS LAS INSEMINACIONES NO ASOCIADAS A NINGUN PARTO
                
                this.dtgInseminaciones.DataSource = this.ObjetoBase.lstInseminaciones;}

         #endregion
        
         #region FUNCIONALIDAD GENERAL

            private void btnBuscarVaca_Click(object sender, EventArgs e)
            {
               this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbHembra) { ValorSexoFijo = Convert.ToChar("H") });
            }
            
            private void cmbHembra_ClaseActivaChanged(object sender, GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs e)
            {
                 if (ModoActual == Modo.Guardar && cmbHembra.IdClaseActivaNullable != null)
                 {
                     Animal animal=Animal.Buscar(cmbHembra.IdClaseActiva);
                     this.dtgInseminaciones.AutoGenerateColumns = false;//Se pone esta linea pq cuando lanzamos el formulario desde el formularios
                     //de animales, la clase activa cambia antes de que se haga la llamada a eliminarAutogenerateColumns en la plantilla, y sin
                     //esta llamada el grid intenta mostrar todos los elementos de la clase, cosa que no es posible pq no se encuentra con  un contexto activo.
                     this.dtgInseminaciones.DataSource = Inseminacion.BuscarInseminacionesLibres(cmbHembra.IdClaseActiva,animal.UltimaFechaParto_Aborto(cmbHembra.IdClaseActiva));             
                 }
                 else
                     this.dtgInseminaciones.DataSource = null;

            }

            private void btnCrearAnimal_Click(object sender, EventArgs e)
            {
                 if (ModoActual == Modo.Actualizar)
                 {
                     EditAnimales frmLanzar = new EditAnimales(this.ObjetoBase.Id);

                     this.LanzarFormulario(frmLanzar);


                 }
            }

        #endregion        

    }
}
 //---------------------Código Comentado----------------------------------------------//
          
        // #region FUNCIONALIDAD - GRIDS DETALLE


        //    void InsertarInseminacion()
        //    {
        //        if (ModoActual == Modo.Actualizar)
        //        {
        //            Inseminacion ObjetoBase = new Inseminacion();
        //            ObjetoBase.IdHembra = this.ObjetoBase.IdHembra;
        //            EditInseminacion frmEditInseminaciones = new EditInseminacion(Modo.Guardar, ObjetoBase);

        //            this.LanzarFormulario(frmEditInseminaciones, dtgInseminaciones);
        //        }
        //    }
        //    void ModificarInseminacion()
        //    {

        //        if (ModoActual == Modo.Actualizar && this.dtgInseminaciones.SelectedRows.Count == 1)
        //        {
        //            Inseminacion ObjetoBase = (Inseminacion)this.dtgInseminaciones.CurrentRow.DataBoundItem;

        //            EditInseminacion frmEditInseminaciones = new EditInseminacion(Modo.Actualizar, ObjetoBase);

        //            this.LanzarFormulario(frmEditInseminaciones, dtgInseminaciones);
        //        }
        //    }


        //    private void tsbNuevaInseminacion_Click(object sender, EventArgs e)
        //    {
        //        InsertarInseminacion();

        //    }
        //    private void tsbModificarInseminacion_Click(object sender, EventArgs e)
        //    {
        //        ModificarInseminacion();
        //    }
        //    private void dtgInseminaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //    {
        //        ModificarInseminacion();
        //    }
        //    private void tsbEliminarInseminacion_Click(object sender, EventArgs e)
        //    {
        //        this.EliminarObjGrid(this.dtgInseminaciones, "Va a eliminar la Inseminación.\r¿Esta usted seguro de que desea continuar?");
        //    }





        //#endregion
        
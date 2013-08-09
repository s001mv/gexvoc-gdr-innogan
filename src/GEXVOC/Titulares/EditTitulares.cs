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
using GEXVOC.Core;

namespace GEXVOC.UI
{
    public partial class EditTitulares : GEXVOC.UI.GenericEdit
    {
     
        #region CONSTRUCTOR E INICIALIZACIONES REQUERIDAS
            /// <summary>
            /// Constructor por Defecto
            /// </summary>
            public EditTitulares()
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
            public EditTitulares(Modo modo, Titular ClaseBase):base(modo, ClaseBase)
            {
                InitializeComponent();
             
            }
            public EditTitulares(Modo modo, Titular ClaseBase,int numTabSeleccionar)
                : base(modo, ClaseBase, numTabSeleccionar)
            {
                InitializeComponent();
              
            }


        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            /// <summary>
            /// Es una propiedad Tipada que nos devuelve la Clase Base sobre la que actúa el Formulario Edit 
            /// El tipo es popio del formulario, pero implementa siempre la interface  IClaseBase)
            /// </summary>
            public Titular ObjetoBase { get { return (Titular)this.ClaseBase; } }
            public bool MostrarTabEsplotaciones
            {
            
                set 
                {
                    if (!value)
                    {
                        tbcContenido.TabPages.Remove(tbpExplotaciones);
                    }
            
                }
            }
            public string Nombre { get { return txtNombre.Text; } set { txtNombre.Text = value; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Nombre", true, txtNombre, lblNombre));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Apellidos", false, txtApellidos, lblApellidos));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "DNI", true, txtDNI, lblDNI));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Telefono", false, txtTelefono, lblTlfno) { ValidacionEspecial= ValidacionesEspeciales.EsTelefono});
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Movil", false, this.txtMovil, lblMovil) { ValidacionEspecial = ValidacionesEspeciales.EsTelefono });
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Direccion", false, txtDireccion, lblDireccion));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "CP", false, txtCP, lblCodPostal) { ValidacionEspecial= ValidacionesEspeciales .EsCodigoPostal});
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fax", false, txtFax, lblFax) { ValidacionEspecial=ValidacionesEspeciales.EsTelefono});
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Email", false, txtemail, lblEmail) { ValidacionEspecial=ValidacionesEspeciales.EsEmail});
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaAlta", true, txtFecAlta, lblFecAlta));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaBaja", false, txtFecBaja, lblFecBaja));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaNacimiento", false, txtFecNacimiento, lblFecNacimiento));
                
                base.DefinirListaBinding();
            }
       
        #endregion

        #region CARGAS COMUNES
            /// <summary>
            /// Carga los Valores por defecto del Formulario de Explotaciones
            /// </summary>
            protected override void CargarValoresDefecto()
            {
                Generic.DatetimeAControl(this.txtFecAlta, DateTime.Now.Date);
            }
            protected override void CargarGrids() {
                this.dtgCuentas.DataSource = this.ObjetoBase.lstCuentas;
                this.dtgExplotaciones.DataSource = this.ObjetoBase.lstExplotaciones;
            }
        #endregion            

        #region GRIDS

            #region EXPLOTACIONES


                private void tsbNuevaExplotacion_ButtonClick(object sender, EventArgs e)
                {
                    this.AgregarExplotacion();
                }

                private void tsmExplotacionNueva_Click(object sender, EventArgs e)
                {
                    this.AgregarExplotacion();
                }

                private void tsmExplotacionExistente_Click(object sender, EventArgs e)
                {
                    if (this.ModoActual == Modo.Actualizar)
                    {
                        ctlBuscarObjeto rdoBusqueda = new ctlBuscarObjeto();
                        FindExplotaciones frmFindExplotaciones = new FindExplotaciones(Modo.Consultar, rdoBusqueda);
                        this.LanzarFormulario(frmFindExplotaciones);

                        AgregarRelacionTitularExplotacion((Explotacion)rdoBusqueda.SelectedItem);
                    }
                }

                private void tsbModificarExplotacion_Click(object sender, EventArgs e)
                {

                    ModificarExplotacion();

                }

                private void ModificarExplotacion()
                {
                    if (dtgExplotaciones.SelectedRows.Count == 1 && ModoActual == Modo.Actualizar)
                        this.LanzarFormulario(new EditExplotaciones(Modo.Actualizar, (Explotacion)this.dtgExplotaciones.CurrentRow.DataBoundItem), this.dtgExplotaciones);
                }

                private void dtgExplotaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                    this.ModificarExplotacion();
                }

                private void tsbEliminarExplotacion_ButtonClick(object sender, EventArgs e)
                {
                    this.EliminarRelacionTitularExplotacion();

                }

                private void tsmEliminarRelacion_Click(object sender, EventArgs e)
                {
                    this.EliminarRelacionTitularExplotacion();
                }

                private void tsmEliminarExplotacion_Click(object sender, EventArgs e)
                {
                    this.EliminarExplotacion();
                }

                void AgregarExplotacion()
                {
                    if (this.ModoActual == Modo.Actualizar)
                    {

                        EditExplotaciones frmEditExplotaciones = new EditExplotaciones(Modo.Guardar, new Explotacion());
                        if (this.LanzarFormulario(frmEditExplotaciones) == DialogResult.OK)
                            AgregarRelacionTitularExplotacion(frmEditExplotaciones.ObjetoBase);

                    }

                }
                void EliminarExplotacion()
                {
                    this.EliminarObjGrid(this.dtgExplotaciones, "Va a eliminar la Explotación de la Aplicación.\r¿Esta usted seguro de que desea continuar?");
                }

                private void AgregarRelacionTitularExplotacion(GEXVOC.Core.Logic.Explotacion explotacion)
                {

                    if (explotacion != null && explotacion.Id != 0)
                    {  //crear registro en ExpTit

                        ExpTit exptit = new ExpTit();
                        this.IniciarContextoOperacion();
                        try
                        {
                            exptit.IdExplotacion = explotacion.Id;
                            exptit.IdTitular = this.ObjetoBase.Id;
                            exptit.FechaInicio = DateTime.Now;

                            exptit.Insertar();
                            CargarGrids();
                            SeleccionarObjGrid(exptit.Explotacion, this.dtgExplotaciones);//Nota: Puedo utilizar la propiedad Titular pq todavia tengo el contexto Operacion activo.
                            
                        }
                        catch (LogicException ex)
                        {
                            Generic.AvisoAdvertencia("No se ha podido guardar la relación.\rMensaje: " + ex.Message);
                            this.ObjetoBase.ExpTit.Remove(exptit);

                        }
                        catch (Exception ex)
                        {
                            Generic.AvisoError("No se ha podido guardar la relación ExpTit en el formulario EditTitulares.\rMensaje: " + ex.Message);
                            this.ObjetoBase.ExpTit.Remove(exptit);


                        }
                        finally
                        {
                            exptit = null;
                            this.FinalizarContextoOperacion();
                        }


                    }
                }
                private void EliminarRelacionTitularExplotacion()
                {
                    if (this.dtgExplotaciones.SelectedRows.Count == 1 && ModoActual == Modo.Actualizar)
                    {
                        this.IniciarContextoOperacion();

                        try
                        {
                            Explotacion objExplotacion = (Explotacion)this.dtgExplotaciones.CurrentRow.DataBoundItem;
                            ExpTit exptit = ExpTit.Buscar(objExplotacion.Id,this.ObjetoBase.Id);
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
                            Generic.AvisoError("No se ha podido eliminar la relación ExpTit en el formulario EditTitulares.\rMensaje: " + ex.Message);
                        }
                        finally { this.FinalizarContextoOperacion(); ; }


                    }
                }

            #endregion

            #region CUENTAS
                private void NuevaCuenta()
                {
                    if (this.ModoActual == Modo.Actualizar)
                    {
                        Cuenta ObjetoBase = new Cuenta();
                        EditCuentas frmLanzar = new EditCuentas(Modo.Guardar, ObjetoBase) { ValorFijoIdTitular = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgCuentas);

                    }
                }
                private void ModificarCuenta()
                {
                    if (this.ModoActual == Modo.Actualizar && this.dtgCuentas.SelectedRows.Count == 1)
                    {
                        Cuenta ObjetoBase = (Cuenta)this.dtgCuentas.CurrentRow.DataBoundItem;
                        EditCuentas frmLanzar = new EditCuentas(Modo.Actualizar, ObjetoBase) { ValorFijoIdTitular = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgCuentas);

                    }
                }

               
                private void tsbNuevaCuenta_Click(object sender, EventArgs e){NuevaCuenta();}

                private void tsbModificarCuenta_Click(object sender, EventArgs e){ModificarCuenta();}
                private void dtgCuentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e) { ModificarCuenta(); }

                private void tsbEliminarCuenta_Click(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgCuentas, "Va a eliminar la Cuenta.\r¿Esta usted seguro de que desea continuar?");
                }

               
                
            #endregion           

              
          
        #endregion

             

    }
}

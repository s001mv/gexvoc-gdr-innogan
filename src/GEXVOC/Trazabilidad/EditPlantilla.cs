using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Reflection;
using System.Linq;

namespace GEXVOC.UI
{
    public partial class EditPlantilla : GEXVOC.UI.GenericEdit
    {                
        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO

            /// <summary>
            /// Es una propiedad Tipada que nos devuelve la Clase Base sobre la que actúa el Formulario Edit 
            /// El tipo es popio del formulario, pero implementa siempre la interface  IClaseBase)
            /// </summary>
            public Plantilla ObjetoBase { get { return (Plantilla)this.ClaseBase; } }
            public string Descripcion { get { return txtDescripcion.Text; } set { txtDescripcion.Text = value; } }
        #endregion
       
        #region CONSTRUCTOR E INICIALIZACIONES REQUERIDAS

            /// <summary>
            /// Constructor por defecto
            /// </summary>
            public EditPlantilla()
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
            public EditPlantilla(Modo modo, Plantilla ClaseBase) : base(modo, ClaseBase)
            {
                InitializeComponent();
            }

            public EditPlantilla(Modo modo, Plantilla ClaseBase, int numTabSeleccionar) : base(modo, ClaseBase, numTabSeleccionar)
            {
                InitializeComponent();
            }

            public EditPlantilla(Modo modo, Plantilla ClaseBase, string tabSeleccionar) : base(modo, ClaseBase, tabSeleccionar)
            {
                InitializeComponent();
            }      

        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

            /// <summary>
            /// Pasa los Valores de la Clase Base a los Controles del Formulario
            /// </summary>
            protected override void ClaseBaseAControles()
            {
                ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
                ClaseBaseAcontrol(this.ObjetoBase, "Detalle", txtDetalle); 
            }

            /// <summary>
            /// Pasa los valores de los controles a la Clase Base
            /// </summary>
            protected override void ControlesAClaseBase()
            {
                ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
                ControlAClaseBase(this.ObjetoBase, "Detalle", txtDetalle);
            }

            /// <summary>
            /// Validación de los Controles, se produce antes de actualizar la ClaseBase (ControlesAClaseBase)
            /// Si la validación retorna False no se continua con la actualización
            /// </summary>
            /// <returns>Controles Válidos (Sí/No)</returns>
            protected override bool Validar()
            {
                bool Rtno = true;

                if (!Generic.ControlValorado(new Control[] { txtDescripcion }, this.ErrorProvider))
                    Rtno = false;

                return Rtno;
            }

        #endregion
          
        #region CARGAS COMUNES
 
            protected override void CargarGrids()
            {
                dtgEntradas.DataSource = this.ObjetoBase.lstEntradas;
                dtgSalidas.DataSource = this.ObjetoBase.lstSalidas;
                dtgEmpleados.DataSource = this.ObjetoBase.lstEmpleados;
                dtgZonas.DataSource = this.ObjetoBase.lstZonas;
                dtgMaquinas.DataSource = this.ObjetoBase.lstMaquinas;
            }

        #endregion

        #region GRIDS

            #region ENTRADAS

                private void tsbInsertarEntrada_Click(object sender, EventArgs e)
                {
                    NuevaEntrada();
                }

                private void tsbModificarEntrada_Click(object sender, EventArgs e)
                {
                    ModificarEntrada();
                }

                private void tsbEliminarEntrada_Click(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgEntradas, "Va a eliminar la entrada.\r¿Está usted seguro de que desea continuar?");
                }

                private void dtgEntradas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                    ModificarEntrada();
                }

                private void NuevaEntrada()
                {
                    if (this.ModoActual == Modo.Actualizar)
                    {
                        Transformacion ObjNuevo = new Transformacion();
                        EditTransformacion frmLanzar = new EditTransformacion(Modo.Guardar, ObjNuevo) { Plantilla = this.ObjetoBase.Id, Direccion = 'E' };
                        this.LanzarFormulario(frmLanzar, this.dtgEntradas);
                    }
                }

                private void ModificarEntrada()
                {
                    if (this.dtgEntradas.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
                    {
                        Transformacion ObjActualizar = (Transformacion)this.dtgEntradas.CurrentRow.DataBoundItem;
                        EditTransformacion frmLanzar = new EditTransformacion(Modo.Actualizar, ObjActualizar) { Producto = ObjActualizar.IdProducto, Direccion = 'E' };
                        this.LanzarFormulario(frmLanzar, this.dtgEntradas);
                    }
                }

            #endregion

            #region SALIDAS

                private void tsbInsertarSalida_Click(object sender, EventArgs e)
                {
                    NuevaSalida();
                }

                private void tsbModificarSalida_Click(object sender, EventArgs e)
                {
                    ModificarSalida();
                }

                private void tsbEliminarSalida_Click(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgSalidas, "Va a eliminar la salida.\r¿Está usted seguro de que desea continuar?");
                }

                private void dtgSalidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                    ModificarSalida();
                }

                private void NuevaSalida()
                {
                    if (this.ModoActual == Modo.Actualizar)
                    {
                        Transformacion ObjNuevo = new Transformacion();
                        EditTransformacion frmLanzar = new EditTransformacion(Modo.Guardar, ObjNuevo) { Plantilla = this.ObjetoBase.Id, Direccion = 'S' };
                        this.LanzarFormulario(frmLanzar, this.dtgSalidas);
                    }
                }

                private void ModificarSalida()
                {
                    if (this.dtgSalidas.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
                    {
                        Transformacion ObjActualizar = (Transformacion)this.dtgSalidas.CurrentRow.DataBoundItem;
                        EditTransformacion frmLanzar = new EditTransformacion(Modo.Actualizar, ObjActualizar) { Direccion = 'S' };
                        this.LanzarFormulario(frmLanzar, this.dtgSalidas);
                    }
                }

            #endregion

            #region EMPLEADOS

                private void tsbInsertarEmpleado_Click(object sender, EventArgs e)
                {
                    NuevoEmpleado();
                }

                private void tsbEliminarEmpleado_Click(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgEmpleados, "Va a eliminar el empleado.\r¿Está usted seguro de que desea continuar?");
                }

                private void NuevoEmpleado()
                {
                    if (this.ModoActual == Modo.Actualizar)
                    {
                        PlaVet ObjNuevo = new PlaVet();
                        EditPlaVet frmLanzar = new EditPlaVet(Modo.Guardar, ObjNuevo) { Plantilla = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgEmpleados);
                    }
                }

            #endregion

            #region ZONAS

                private void tsbInsertarZona_Click(object sender, EventArgs e)
                {
                    NuevaZona();
                }

                private void tsbEliminarZona_Click(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgZonas, "Va a eliminar la zona.\r¿Está usted seguro de que desea continuar?");
                }

                private void NuevaZona()
                {
                    if (this.ModoActual == Modo.Actualizar)
                    {
                        PlaZon ObjNuevo = new PlaZon();
                        EditPlaZon frmLanzar = new EditPlaZon(Modo.Guardar, ObjNuevo) { Plantilla = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgZonas);
                    }
                }

            #endregion

            #region MAQUINAS

                private void tsbInsertarMaquina_Click(object sender, EventArgs e)
                {
                    NuevaMaquina();
                }

                private void tsbEliminarMaquina_Click(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgMaquinas, "Va a eliminar la máquina.\r¿Está usted seguro de que desea continuar?");
                }

                private void NuevaMaquina()
                {
                    if (this.ModoActual == Modo.Actualizar)
                    {
                        PlaMaq ObjNuevo = new PlaMaq();
                        EditPlaMaq frmLanzar = new EditPlaMaq(Modo.Guardar, ObjNuevo) { Plantilla = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgMaquinas);
                    }
                }

            #endregion

        #endregion
                
        #region FUNCIONAMIENTO GENERAL
            private void btnEjecutar_Click(object sender, EventArgs e)
            {
                try
                {
                    this.IniciarContextoOperacion();

                    if (ModoActual == Modo.Actualizar)
                        ObjetoBase.Ejecutar();
                    else
                        Generic.AvisoInformation("Debe guardar el proceso para poder ejecutarlo.");
                }
                catch (LogicException ex)
                {
                    Generic.AvisoInformation(ex.Message);
                }
                catch (Exception ex)
                {
                    Generic.AvisoError("Error en la ejecución del proceso.");
                    Traza.RegistrarError(ex);
                }
                finally
                {
                    this.FinalizarContextoOperacion();
                }
            }                
        #endregion

    }
}
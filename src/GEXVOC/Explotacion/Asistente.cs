using System;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using System.Collections.Generic;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Controles;

namespace GEXVOC.UI
{
    public partial class Asistente : GEXVOC.UI.GenericMaestro
    {
        #region CONTRUCTORES
            public Asistente()
            {
                InitializeComponent();
                ModoActual = Modo.Actualizar;
            }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            Explotacion _ObjetoBase = null;
            /// <summary>
            /// Se utiliza en el asistente a partir del paso Módulos.
            /// En esta variable se encuentra la explotación que se ha creado con el asistente.
            /// </summary>
            public Explotacion ObjetoBase
            {
                get { return _ObjetoBase; }
                set { _ObjetoBase = value; }
            }
        #endregion        

        #region VALIDACIONES

            /// <summary>
            /// Valida la pagina actual, para ello utiliza llamadas a las validaciones conocidas.
            /// </summary>
            /// <returns></returns>
            protected override bool Validar()
            {
                bool rtno = true;
                if (wzdAsistente.Page == Explotacion)
                    rtno = ValidarExplotacion();
                else if (wzdAsistente.Page == Especies)
                    rtno = ValidarEspecies();

                return rtno;
            }

            /// <summary>
            /// Valida la Página Explotaciones.
            /// </summary>
            /// <returns></returns>
            private bool ValidarExplotacion()
            {
                bool Rtno = true;
                           
                if (!Generic.ControlValorado(new Control[] { txtFecAlta, cmbMunicipio, cmbProvincia, txtNombre, cmbCJuridica, txtCea }, this.ErrorProvider))
                    Rtno = false;

                //Validaciones de tipos de datos (Siempre despues de validar los requeridos, pues son 
                //los que posicionan el foco en el control cuando no tiene valor (La validacion de tipos no lo hace)
                if (!Generic.ControlDatosCorrectos(this.txtFecAlta, this.ErrorProvider, typeof(System.DateTime), true)) Rtno = false;
                if (!Generic.ControlDatosCorrectos(this.txtFecBaja, this.ErrorProvider, typeof(System.DateTime), false)) Rtno = false;

                if (txtCea.Text!=string.Empty && this.txtCea.Text.Length != 14)
                {
                    Generic.PonerError(this.ErrorProvider, txtCea, "El campo CEA debe tener 14 caracteres");
                    Rtno = false;
                }


                return Rtno;
            }

            /// <summary>
            /// Valida la página especies.
            /// </summary>
            /// <returns></returns>
            private bool ValidarEspecies()
            {
                foreach (TreeNode item in trvEspecies.Nodes)
                    if (item.Checked)
                        return true;

                //Si no ha salido por arriba es que no hay nada checkeado, retorno falso.
                Generic.PonerError(ErrorProvider, trvEspecies, "Es necesaria al menos una especie para la explotación");
                return false;

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

                CargarEspecies();
                CargarModulos();
                


            }
            ///// <summary>
            ///// Realiza la carga del combo de municipios en funcion de la provincia seleccionada.
            ///// </summary>
            //private void CargarMunicipios()
            //{
            //    if (this.cmbProvincia.SelectedValue != null)
            //    {
            //        this.cmbMunicipio.DataSource = Municipio.Buscar(string.Empty, string.Empty, (int)this.cmbProvincia.SelectedValue);
            //        this.cmbMunicipio.DisplayMember = "Descripcion";
            //        this.cmbMunicipio.ValueMember = "Id";

            //    }
            //    else
            //        this.cmbMunicipio.DataSource = null;

            //    this.cmbMunicipio.Text = string.Empty;
            //    this.cmbMunicipio.SelectedIndex = -1;

            //}
         

            /// <summary>
            /// Carga los grids existentes en el asistente.
            /// </summary>
            protected override void CargarGrids()
            {
                if (ObjetoBase!=null)                
                    this.dtgTitulares.DataSource = this.ObjetoBase.lstTitulares;          
            }

            /// <summary>
            /// Carga el TreeView Especies con las especies registradas en el sistema.
            /// </summary>
            private void CargarEspecies()
            {
                trvEspecies.Nodes.Clear();
                List<Especie> lstEspecies = Especie.Buscar();
                foreach (Especie item in lstEspecies)
                {
                    TreeNode nodo = new TreeNode(item.Descripcion);
                    nodo.Tag = item;
                    trvEspecies.Nodes.Add(nodo);
                }
            }
            /// <summary>
            /// Carga el TreeView Módulos con los módulos registrados en el sistema.
            /// </summary>
            private void CargarModulos()
            {
                trvModulos.Nodes.Clear();
                List<Modulo> lstModulos = Modulo.Buscar();
                foreach (Modulo item in lstModulos)
                {
                    TreeNode nodo = new TreeNode(item.Descripcion);
                    nodo.Tag = item;
                    trvModulos.Nodes.Add(nodo);
                }
            }

        #endregion         
     
        #region  GRID TITULARES

            #region OPERACIONES
            void ModificarTitular()
            {
                if (this.dtgTitulares.SelectedRows.Count == 1 )
                {
                    //preparo el formulario que voy a lanzar
                    Titular ObjActualizar = (Titular)this.dtgTitulares.CurrentRow.DataBoundItem;
                    this.LanzarFormulario(new EditTitulares(Modo.Actualizar, ObjActualizar) { MostrarTabEsplotaciones=false}, dtgTitulares);
                }
            }
            void AgregarTitular()
            {

               
                    Titular ObjActualizar = new Titular();
                    EditTitulares frmEditTitulares = new EditTitulares(Modo.Guardar, ObjActualizar) { MostrarTabEsplotaciones = false };
                    if (this.LanzarFormulario(frmEditTitulares) == DialogResult.OK)
                        AgregarRelacionTitularExplotacion(frmEditTitulares.ObjetoBase);

               

            }
            void EliminarTitular()
            {
                this.EliminarObjGrid(this.dtgTitulares, "Va a eliminar el Titular de la Aplicación.\rSi el Titular ha sido asignado a otra explotación, se borrará dicha asignación.\r(A causa de este proceso es posible que quede alguna explotación sin Titular).\r¿Esta usted seguro de que desea continuar?");

            }
            private void AgregarRelacionTitularExplotacion(Titular titular)
            {

                if (titular != null && titular.Id != 0)
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
                    finally
                    {
                        exptit = null;
                        this.FinalizarContextoOperacion();
                    }


                }
            }
            private void EliminarRelacionTitularExplotacion()
            {
                if (this.dtgTitulares.SelectedRows.Count == 1)
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
                    ctlBuscarObjeto rdoBusqueda = new ctlBuscarObjeto();
                    FindTitulares frmFindTitulares = new FindTitulares(Modo.Consultar, rdoBusqueda) { MostrarTodosTitulares=true};
                    this.LanzarFormulario(frmFindTitulares);

                    AgregarRelacionTitularExplotacion((Titular)rdoBusqueda.SelectedItem);
              

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
            private void dtgTitulares_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                ModificarTitular();
            }
            #endregion


        #endregion

        #region MOVIMIENTOS DEL ASISTENTE

            /// <summary>
            /// Realizar validación.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void Explotacion_CloseFromNext(object sender, GEXVOC.Core.Controles.Asistente.PageEventArgs e)
            {
                if (!ValidarControles())
                    e.Page = wzdAsistente.Page;
            }

            /// <summary>
            /// Realizar validación.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void Especies_CloseFromNext(object sender, GEXVOC.Core.Controles.Asistente.PageEventArgs e)
            {
                if (!ValidarControles())
                    e.Page = wzdAsistente.Page;
            }

            /// <summary>
            /// Al pulsar siguiente en el paso de módulos, se creará la explotación
            /// y se impide volver atras.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void Modulos_CloseFromNext(object sender, GEXVOC.Core.Controles.Asistente.PageEventArgs e)
            {
                if (ObjetoBase == null)
                {
                    Explotacion explotacion = new Explotacion();
                    BD.IniciarBDOperaciones();
                    try
                    {
                        BD.IniciarTransaccion();


                        Generic.ControlAClaseBase(explotacion, "CEA", txtCea);
                        Generic.ControlAClaseBase(explotacion, "Nombre", txtNombre);
                        Generic.ControlAClaseBase(explotacion, "FechaAlta", txtFecAlta);
                        Generic.ControlAClaseBase(explotacion, "FechaBaja", txtFecBaja);
                        Generic.ControlAClaseBase(explotacion, "IdCJuridica", cmbCJuridica);
                        Generic.ControlAClaseBase(explotacion, "IdMunicipio", cmbMunicipio);
                        Generic.ControlAClaseBase(explotacion, "Direccion", txtDireccion);
                        Generic.ControlAClaseBase(explotacion, "Siglas", txtSigla);
                        Generic.ControlAClaseBase(explotacion, "CodigoCLechero", txtCLechero);

                        foreach (TreeNode item in trvEspecies.Nodes)
                        {
                            if (item.Checked)
                            {
                                ExpEsp expesp = new ExpEsp();
                                expesp.IdEspecie = ((Especie)item.Tag).Id;
                                explotacion.ExpEsp.Add(expesp);

                            }
                        }
                        foreach (TreeNode item in trvModulos.Nodes)
                        {
                            if (item.Checked)
                            {
                                ExpMod expmod = new ExpMod();
                                expmod.IdModulo = ((Modulo)item.Tag).Id;
                                explotacion.ExpMod.Add(expmod);

                            }
                        }

                        explotacion.Insertar();

                        BD.FinalizarTransaccion(true);
                        ObjetoBase = Core.Logic.Explotacion.Buscar(explotacion.Id);
                    }
                    catch (Exception ex)
                    {
                        explotacion = null;
                        e.Page = Modulos;
                        Generic.AvisoError(ex.Message);
                        BD.FinalizarTransaccion(false);
                    }
                    finally
                    {
                        BD.FinalizarBDOperaciones();
                    }
                }

            }

            /// <summary>
            /// No dejo volver atras desde titulares en ningun caso.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void Titulares_ShowFromNext(object sender, EventArgs e)
            {
                wzdAsistente.BackEnabled = false;
                wzdAsistente.CancelEnabled = false;

            }

            /// <summary>
            /// No dejo volver atras desde titulares en ningun caso.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void Titulares_ShowFromBack(object sender, EventArgs e)
            {
                wzdAsistente.BackEnabled = false;
                wzdAsistente.CancelEnabled = false;
            }

        #endregion

        #region COMBOS

            private void cmbProvincia_CrearNuevo(object sender, ctlComboCrearNuevoEventArgs e)
            {

                Provincia ObjetoBase = new Provincia();
                EditProvincia editProvincia = new EditProvincia(Modo.Guardar, ObjetoBase);
                editProvincia.Descripcion = e.TextoCrear;
                editProvincia.AccionDespuesInsertar = GenericEdit.AccionesDespuesInsertar.Cerrar;

                CrearNuevoElementoCombo(editProvincia, sender);
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


                //EditCondicionJuridica editCondicionJuridica = new EditCondicionJuridica(Modo.Guardar, ObjetoBase);
                //editCondicionJuridica.Descripcion = e.TextoCrear;

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
                Generic.PonerError(this.ErrorProvider, cmbMunicipio, string.Empty);
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

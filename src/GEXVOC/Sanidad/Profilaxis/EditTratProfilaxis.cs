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
    public partial class EditTratProfilaxis : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
            public EditTratProfilaxis()
            {
                InitializeComponent();
            }
            public EditTratProfilaxis(Modo modo, TratProfilaxis ClaseBase)
                : base(modo, ClaseBase)
            {
                InitializeComponent();
            }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            public TratProfilaxis ObjetoBase { get { return (TratProfilaxis)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdPrograma", true, this.cmbPrograma, lblPrograma));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, this.txtFecha, lblFecha));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Detalle", false, this.txtDetalle, lblDetalle));           
               

                base.DefinirListaBinding();
            }        

        #endregion

        #region CARGAS COMUNES
            protected override void CargarCombos()
            {
                cmbPrograma.CargarCombo();
            }

            protected override void CargarGrids()
            {
                this.dtgProPro.DataSource = this.ObjetoBase.lstProPro;
                this.dtgAniPro.DataSource = this.ObjetoBase.lstAniPro;
            }

        #endregion

        #region GRID - PROPRO
            private void NuevoProPro()
            {
                if (ModoActual == Modo.Actualizar)
                {
                    ProPro ObjCrear = new ProPro();
                    this.LanzarFormulario(new EditProPro(Modo.Guardar, ObjCrear) { ValorFijoIdTratProfilaxis = this.ObjetoBase.Id }, dtgProPro);

                }
            }
            private void ModificarProPro()
            {

                if (this.dtgProPro.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
                {
                    ProPro ObjActualizar = (ProPro)this.dtgProPro.CurrentRow.DataBoundItem;
                    this.LanzarFormulario(new EditProPro(Modo.Actualizar, ObjActualizar), this.dtgProPro);
                }
            }
            private void tsbNuevoProPro_Click(object sender, EventArgs e)
            {
                NuevoProPro();
            }
            private void tsbModificarProPro_Click(object sender, EventArgs e)
            {
                ModificarProPro();
            }
            private void tsbEliminarProPro_Click(object sender, EventArgs e)
            {
                this.EliminarObjGrid(this.dtgProPro, "Va a eliminar la asociación del producto.\r¿Esta usted seguro de que desea continuar?");
            }
            private void dtgProPro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                ModificarProPro();
            }
        #endregion

        #region GRID - ANIPRO
            private void tsbEliminarAniPro_Click(object sender, EventArgs e)
            {
                this.EliminarObjGrid(this.dtgAniPro, "Va a eliminar el animal de este tratamiento.\r¿Esta usted seguro de que desea continuar?");
            }
            private void tsbNuevoAniPro_Click(object sender, EventArgs e)
            {
                if (this.ModoActual == Modo.Actualizar)
                {//Mostramos el selector de animales, y por cada animal seleccionado creamos un elemento del tipo "AniPro"

                    SelectorAnimales frmSelectorAnimales = new SelectorAnimales();
                    this.LanzarFormulario(frmSelectorAnimales);

                    if (frmSelectorAnimales.LstAnimalesSeleccionadosRtno != null)
                    {
                        string mensajeError = string.Empty;
                        int OperacionesCorrectas = 0;
                        int OperacionesIncorrectas = 0;

                        IniciarContextoOperacion();

                        try
                        {


                            foreach (Animal item in frmSelectorAnimales.LstAnimalesSeleccionadosRtno)
                            {
                                if (AniPro.Buscar((int)this.ObjetoBase.Id, (int)item.Id) == null)
                                {
                                    try
                                    {

                                        AniPro anipro = new AniPro();
                                        anipro.IdTratProfilaxis = this.ObjetoBase.Id;
                                        anipro.IdAnimal = item.Id;
                                        anipro.Insertar();
                                        OperacionesCorrectas += 1;
                                    }
                                    catch (Exception ex)
                                    {
                                        OperacionesIncorrectas += 1;
                                        mensajeError += ex.Message + "\r";
                                    }
                                }
                            }
                            if (mensajeError != string.Empty)
                                Generic.AvisoAdvertencia("Se han producido errores en un total de (" + ((int)OperacionesCorrectas + OperacionesIncorrectas) + ") Operaciones => " +
                                                        "(" + OperacionesCorrectas + ") Correctas y (" + OperacionesIncorrectas + ") Incorrectas.\r" +
                                                        "Resumen e Información adicional: \r" +
                                                          mensajeError);


                        }
                        catch (LogicException ex)
                        {
                            Generic.AvisoAdvertencia(ex.Message);
                        }
                        catch (Exception)                        
                        {
                            Generic.AvisoError("No se ha podido realizar la asociación.");                           
                        }
                        finally { FinalizarContextoOperacion(); }
                            
                        this.CargarGrids();
                    }             
                }
            }        
        #endregion

        #region COMBOS
            private void cmbPrograma_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbPrograma, Programa.Buscar());
            }

            private void cmbPrograma_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                Programa ObjetoBase = new Programa();
                GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ObjetoBase);
                frmLanzar.Titulo = "Programa de Profilaxis";
                frmLanzar.NumColumnas = 2;
                frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción") { ValorDefecto=e.TextoCrear});

                CrearNuevoElementoCombo(frmLanzar, sender);

            }

        #endregion



    }
}
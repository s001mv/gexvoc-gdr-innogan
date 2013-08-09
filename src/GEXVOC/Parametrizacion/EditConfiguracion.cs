using System;
using System.Collections;
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
    public partial class EditConfiguracion : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
            public EditConfiguracion()
            {
                InitializeComponent();
            }
            public EditConfiguracion(Modo modo, Configuracion ClaseBase)
                : base(modo, ClaseBase)
            {
                InitializeComponent();
            }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            public Configuracion ObjetoBase { get { return (Configuracion)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            /// <summary>
            /// Carga en los controles del formulario los correspondientes valores almacenados en la Base de datos.
            /// </summary>
            private void CargarValores()
            {

                foreach (TabPage item in tabEspecies.TabPages)
                {
                    try
                    {
                        pnlOpcioneComunes pnlopciones = (pnlOpcioneComunes)item.Controls[0];

                        pnlopciones.txtMinimoGestacion.Text = Configuracion.ObtenerValor(Claves.DiasMinimoGestacion, (int)pnlopciones.Tag);
                        pnlopciones.txtMaximoGestacion.Text = Configuracion.ObtenerValor(Claves.DiasMaximoGestacion, (int)pnlopciones.Tag);
                        pnlopciones.txtInseminacion.Text = Configuracion.ObtenerValor(Claves.PeriodoInseminacionPostParto, (int)pnlopciones.Tag);
                        pnlopciones.txtAlertaDiagnosticoInicio.Text = Configuracion.ObtenerValor(Claves.DiasAlertaDiagnosticoInicio, (int)pnlopciones.Tag);
                        pnlopciones.txtAlertaDiagnosticoFin.Text = Configuracion.ObtenerValor(Claves.DiasAlertaDiagnosticoFin, (int)pnlopciones.Tag);

                        pnlopciones.txtNormalEstimado.Text = Configuracion.ObtenerValor(Claves.DiasNormalEstimado, (int)pnlopciones.Tag);
                        pnlopciones.txtAbortoConLactacion.Text = Configuracion.ObtenerValor(Claves.DiasAbortoConLactacion, (int)pnlopciones.Tag);
                        pnlopciones.txtVacaciones.Text = Configuracion.ObtenerValor(Claves.DiasVacaciones, (int)pnlopciones.Tag);
                        pnlopciones.cmbValorPredenterminadoNombreAnimal.SelectedValue = Configuracion.ObtenerValorInt(Claves.ValorPredeterminadoNombreAnimal, (int)pnlopciones.Tag) ?? -1;

                        pnlopciones.txtIntervaloCelosInicio.Text = Configuracion.ObtenerValor(Claves.IntervaloCelosInicio, (int)pnlopciones.Tag);
                        pnlopciones.txtIntervaloCelosFin.Text = Configuracion.ObtenerValor(Claves.IntervaloCelosFin, (int)pnlopciones.Tag);
                
                    }
                    catch (Exception)
                    {
                        Generic.AvisoError("Se ha producido un error en la carga de los valores.");
                    }

                }
                
                if (Configuracion.ObtenerValor(Claves.TipoAperturaLactacion)!=string.Empty)                    
                    this.cmbLactacion.SelectedValue = Configuracion.ObtenerValorInt(Claves.TipoAperturaLactacion)??-1;
                
                //if (Configuracion.ObtenerValor(Claves.ValorPredeterminadoNombreAnimal)!=string.Empty)
                //    this.cmbValorPredenterminadoNombreAnimal.SelectedValue = Configuracion.ObtenerValorInt(Claves.ValorPredeterminadoNombreAnimal)??-1;


            }

            /// <summary>
            /// Validación de los Controles, se produce antes de actualizar la ClaseBase.
            /// </summary>
            /// <returns>Controles válidos (Si/No)</returns>
            protected override bool Validar()
            {
                bool rtno = true;
             
                if (!Generic.ControlValorado(new Control[]{cmbLactacion}, this.ErrorProvider)) rtno = false;
                
                foreach (TabPage item in tabEspecies.TabPages)
                {
                    try
                    {
                        pnlOpcioneComunes pnlopciones = (pnlOpcioneComunes)item.Controls[0];
                        if (!Generic.ControlDatosCorrectos(pnlopciones.cmbValorPredenterminadoNombreAnimal, this.ErrorProvider, typeof(Int32), true)) rtno = false;
                        if (!Generic.ControlDatosCorrectos(pnlopciones.txtMinimoGestacion, this.ErrorProvider, typeof(Int32), true)) rtno=false;
                        if (!Generic.ControlDatosCorrectos(pnlopciones.txtMaximoGestacion, this.ErrorProvider, typeof(Int32), true)) rtno=false;
                        if (!Generic.ControlDatosCorrectos(pnlopciones.txtInseminacion, this.ErrorProvider, typeof(Int32), true)) rtno=false;
                        if (!Generic.ControlDatosCorrectos(pnlopciones.txtAlertaDiagnosticoInicio, this.ErrorProvider, typeof(Int32), true)) rtno = false;
                        if (!Generic.ControlDatosCorrectos(pnlopciones.txtAlertaDiagnosticoFin, this.ErrorProvider, typeof(Int32), true)) rtno = false;
                        if (!Generic.ControlDatosCorrectos(pnlopciones.txtNormalEstimado, this.ErrorProvider, typeof(Int32), true)) rtno=false;
                        if (!Generic.ControlDatosCorrectos(pnlopciones.txtAbortoConLactacion, this.ErrorProvider, typeof(Int32), true)) rtno=false;
                        if (!Generic.ControlDatosCorrectos(pnlopciones.txtVacaciones, this.ErrorProvider, typeof(Int32), true)) rtno = false;
                        if (!Generic.ControlDatosCorrectos(pnlopciones.txtIntervaloCelosInicio, this.ErrorProvider, typeof(Int32), true)) rtno = false;
                        if (!Generic.ControlDatosCorrectos(pnlopciones.txtIntervaloCelosFin, this.ErrorProvider, typeof(Int32), true)) rtno = false;

                    }
                    catch (Exception)
                    {


                    }
                }         
               

                return rtno;

            }
            protected override void Guardar()
            {
                if (this.ValidarControles())
                {
                    string valor = Convert.ToString(Generic.ControlAIntNullable(cmbLactacion));
                    Configuracion.GuardarValor(Claves.TipoAperturaLactacion, valor);               
                 

                    foreach (TabPage item in tabEspecies.TabPages)
                    {
                        try
                        {
                            pnlOpcioneComunes pnlopciones = (pnlOpcioneComunes)item.Controls[0];

                            Configuracion.GuardarValor(Claves.DiasMinimoGestacion, pnlopciones.txtMinimoGestacion.Text, (int)pnlopciones.Tag);
                            Configuracion.GuardarValor(Claves.DiasMaximoGestacion, pnlopciones.txtMaximoGestacion.Text, (int)pnlopciones.Tag);
                            Configuracion.GuardarValor(Claves.PeriodoInseminacionPostParto, pnlopciones.txtInseminacion.Text, (int)pnlopciones.Tag);
                            Configuracion.GuardarValor(Claves.DiasAlertaDiagnosticoInicio, pnlopciones.txtAlertaDiagnosticoInicio.Text, (int)pnlopciones.Tag);
                            Configuracion.GuardarValor(Claves.DiasAlertaDiagnosticoFin, pnlopciones.txtAlertaDiagnosticoFin.Text, (int)pnlopciones.Tag);
                            Configuracion.GuardarValor(Claves.DiasNormalEstimado, pnlopciones.txtNormalEstimado.Text, (int)pnlopciones.Tag);
                            Configuracion.GuardarValor(Claves.DiasAbortoConLactacion, pnlopciones.txtAbortoConLactacion.Text, (int)pnlopciones.Tag);
                            Configuracion.GuardarValor(Claves.DiasVacaciones, pnlopciones.txtVacaciones.Text, (int)pnlopciones.Tag);
                            string valorNombre = Convert.ToString(Generic.ControlAIntNullable(pnlopciones.cmbValorPredenterminadoNombreAnimal));
                            Configuracion.GuardarValor(Claves.ValorPredeterminadoNombreAnimal, valorNombre, (int)pnlopciones.Tag);
                            Configuracion.GuardarValor(Claves.IntervaloCelosInicio, pnlopciones.txtIntervaloCelosInicio.Text, (int)pnlopciones.Tag);
                            Configuracion.GuardarValor(Claves.IntervaloCelosFin, pnlopciones.txtIntervaloCelosFin.Text, (int)pnlopciones.Tag);


                        }
                        catch (LogicException ex)
                        {
                            Generic.Aviso(ex.Message, "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        catch (Exception ex)
                        {                       
                            Generic.AvisoError("Error en el proceso de guardado.");
                            Traza.RegistrarError(ex);
                        }

                    }
                    

                    //Despues de guardar todo, recargo configuración.
                    Configuracion.Cargar();
                    this.Close();

                    
                }
                

                
               // base.Guardar();
            }

        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void EditConfiguracion_Load(object sender, EventArgs e)
        {
            //cmbLactacion.DataSource = typeof(Configuracion.TipoAperturaLactacion).to//Enum.GetValues(typeof(Configuracion.TipoAperturaLactacion));

            foreach (Especie item in Especie.Buscar())
            {

                TabPage tab = new TabPage(item.Descripcion);
                pnlOpcioneComunes pnl = new pnlOpcioneComunes();
                this.CargarComboEnum(pnl.cmbValorPredenterminadoNombreAnimal, new Configuracion.ValorPredeterminadoNombreAnimal());
                pnl.Tag = item.Id;
                tab.Controls.Add(pnl);
                tabEspecies.TabPages.Add(tab);  
                
            }

            this.CargarComboEnum(cmbLactacion,  new Configuracion.TipoAperturaLactacion());
            

            
            CargarValores();



        }        
        #endregion
       
    }
}
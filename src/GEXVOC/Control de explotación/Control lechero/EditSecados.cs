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
    public partial class EditSecados : GEXVOC.UI.GenericEdit
    {
    
     
        #region CONSTRUCTOR E INICIALIZACIONES REQUERIDAS
            /// <summary>
            /// Constructor por defecto.
            /// </summary>
            public EditSecados()
            {
                InitializeComponent();
            }

           /// <summary>
           /// Sobrecarga del Constructor que nos permite inicializar un formulario 
           /// GenericEdit con los datos propios del formulario.
           /// </summary>
           /// <param name="modo">Modo de Apertura del Formulario Edit</param>
           /// <param name="ClaseBase">Clase Base sobre la que actúa el formulario Edit.</param>
            public EditSecados(Modo modo, Secado ClaseBase)
                : base(modo, ClaseBase)
            {
                InitializeComponent();
               

            }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            public Secado ObjetoBase { get { return (Secado)this.ClaseBase; } }
            int? _ValorFijoIdHembra = null;
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

                    _ValorFijoIdHembra = value;
                }
            }


        #endregion        

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                cmbHembra.TipoDatos = typeof(Animal);
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTipo", true, this.cmbTipo, lblTipo));                
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdHembra", true, this.cmbHembra, lblHembra));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdMotivo", true, this.cmbMotivoSecado, lblMotivo));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, this.txtFecha, lblFecInicio));

                base.DefinirListaBinding();
            }            
         
        #endregion

        #region CARGAS COMUNES

            protected override void CargarCombos()
            {
                cmbTipo.CargarCombo();
                cmbMotivoSecado.CargarCombo();
            }
            protected override void CargarValoresDefecto()
            {
                Generic.DatetimeAControl(this.txtFecha, DateTime.Now.Date);
            }
        #endregion

        #region FUNCIONALIDAD GENERAL
            private void btnBuscarHembra_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbHembra) { ValorSexoFijo = Convert.ToChar("H") });
            }

            private void ObtenerFecha()
            {
                if (cmbHembra.ClaseActiva != null && cmbTipo.SelectedValue != null)
                    txtFecha.Text = Secado.ObtenerFecha(cmbHembra.ClaseActiva.Id, ObjetoBase.Id, (int)cmbTipo.SelectedValue).ToShortDateString();
            }

        #endregion

        #region COMBOS
            private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
            {
                ObtenerFecha();
            }
            private void cmbHembra_ClaseActivaChanged(object sender, GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs e)
            {
                ObtenerFecha();
            }

            private void cmbTipo_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbTipo, "Descripcion", TipoSecado.Buscar());
            }

            private void cmbTipo_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                
                TipoSecado ObjetoBase = new TipoSecado();
                EditTipoSecado editTipoSecado = new EditTipoSecado(Modo.Guardar, ObjetoBase);
                editTipoSecado.Descripcion = e.TextoCrear;

                CrearNuevoElementoCombo(editTipoSecado, sender);
                
            }

            private void cmbMotivoSecado_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbMotivoSecado, "Descripcion", Motivo.Buscar());
            }

            private void cmbMotivoSecado_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {

                Motivo ObjetoBase = new Motivo();
                GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ObjetoBase);
                frmLanzar.Titulo = "Motivo Secado";
                frmLanzar.NumColumnas = 2;
                frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción") { ValorDefecto = e.TextoCrear });

                CrearNuevoElementoCombo(frmLanzar, sender);    

            }


        #endregion

            private void EditSecados_ControlAPropiedad(object sender, PropiedadBindEventArgs e)
            {
                if (e.Control==txtFecha)
                {
                    if (this.cmbHembra.ClaseActiva!=null)
                    {
                        Animal hembra = (Animal)this.cmbHembra.ClaseActiva;
                        DateTime? FUltimoParto_Aborto = hembra.UltimaFechaParto_Aborto(hembra.Id);
                        DateTime? Fecha=Generic.ControlADatetimeNullable(e.Control);
                        if (Fecha.HasValue && FUltimoParto_Aborto.HasValue)
                        {
                            if (Fecha < FUltimoParto_Aborto.Value)
                            {
                                DialogResult rdo = MessageBox.Show("La fecha del secado que ha introducido es anterior a la última fecha de parto o aborto.\n¿Desea insertar el secado a pesar de las advertencias?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rdo != DialogResult.Yes)
                                {
                                    txtFecha.Focus();
                                    throw new LogicException("No se ha insertado el secado porque no cumple con las especificaciones de configuración");
                                }
                            }
                        }                        
                    }                    
                }
            }

            
    }

}

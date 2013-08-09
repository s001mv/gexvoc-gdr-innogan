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
    public partial class EditControlLeche : GEXVOC.UI.GenericEdit
    {

        #region CONSTRUCTOR E INICIALIZACIONES REQUERIDAS
            public EditControlLeche()
            {
                InitializeComponent();
            }
            public EditControlLeche(Modo modo, ControlLeche ClaseBase)
                : base(modo, ClaseBase)
            {
                InitializeComponent();
               

            }

        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            public ControlLeche ObjetoBase { get { return (ControlLeche)this.ClaseBase; } }

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

            protected override void ClaseBaseAControles()
            {
                         
                ClaseBaseAcontrol(this.ObjetoBase, "IdOrdeno", cmbStatusOrdeno);
                ClaseBaseAcontrol(this.ObjetoBase, "IdControl", cmbStatusControl);
                ClaseBaseAcontrol(this.ObjetoBase, "Fecha", txtFecControl);
                ClaseBaseAcontrol(this.ObjetoBase, "LecheManana", txtManhana);
                ClaseBaseAcontrol(this.ObjetoBase, "LecheTarde", txtTarde);
                ClaseBaseAcontrol(this.ObjetoBase, "LecheNoche", txtNoche);
            }

            protected override void ControlesAClaseBase()
            {

                ControlAClaseBase(this.ObjetoBase, "IdHembra", cmbHembra);
                ControlAClaseBase(this.ObjetoBase, "IdOrdeno", cmbStatusOrdeno);
                ControlAClaseBase(this.ObjetoBase, "IdControl", cmbStatusControl);
                ControlAClaseBase(this.ObjetoBase, "Fecha", txtFecControl);
                //Aunque la base de datos para estos valores permite nulos, no se van a permitir ya que
                //estos datos se utilizan en calculos para lactación extendida.
                this.ObjetoBase.LecheManana = Generic.ControlADecimal(this.txtManhana);
                this.ObjetoBase.LecheTarde = Generic.ControlADecimal(this.txtTarde);
                this.ObjetoBase.LecheNoche = Generic.ControlADecimal(this.txtNoche);
               

               
            }


            /// <summary>
            /// Validación de los Controles, se produce antes de actualizar la ClaseBase.
            /// </summary>
            /// <returns>Controles válidos (Si/No)</returns>
            protected override bool Validar()
            {
                bool Rtno = true;
                this.ErrorProvider.Clear();
                if (!Generic.ControlValorado(new Control[] { txtFecControl, cmbStatusControl, cmbHembra }, this.ErrorProvider))
                    Rtno = false;
                if (!Generic.ControlDatosCorrectos(this.txtFecControl, this.ErrorProvider, "El valor introducido no es del tipo fecha", typeof(System.DateTime), true))
                    Rtno = false;
            
                return Rtno;

            }

            protected override void Guardar(object sender, EventArgs e)
            {
                if (this.Validar())
                {
                    if (cmbHembra != null)
                    {
                        Animal hembra = Animal.Buscar((int)cmbHembra.IdClaseActiva);
                        Lactacion lactacion = hembra.UltimaLactacionAbierta();
                        DateTime? UltimaFechaParto_Aborto = hembra.UltimaFechaParto_Aborto(hembra.Id);
                        Aborto ultimoaborto = hembra.UltimoAborto();

                        if (lactacion != null && UltimaFechaParto_Aborto.HasValue && (lactacion.FechaInicio < UltimaFechaParto_Aborto) && (UltimaFechaParto_Aborto < Generic.ControlADatetime(txtFecControl)))
                        {
                            if (ultimoaborto==null || (ultimoaborto.IdTipo != Configuracion.TipoAbortoSistema(Configuracion.TiposAbortosSistema.ABORTO_CONTINUANDO_LACTACIÓN).Id && ultimoaborto.Fecha == UltimaFechaParto_Aborto))                                    
                            {
                                if (DialogResult.OK == Generic.Aviso("Hay una lactación anterior abierta si continua se cerrará la anterior y se abrirá una nueva ¿Desea Continuar?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))                                        
                                    Guardar();
                            }                                
                            else
                                Guardar();
                         
                        }
                        else
                            Guardar();

                    }
                }
            }
            #endregion

        #region CARGAS COMUNES
            protected override void CargarCombos()
            {
                this.cmbStatusControl.CargarCombo();                
                this.cmbStatusOrdeno.CargarCombo();
            }
            protected override void CargarValoresDefecto()
            {
                Generic.DatetimeAControl(this.txtFecControl, DateTime.Now.Date);

                                
               
            }
        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarHembra_Click(object sender, EventArgs e)
            {
               
                this.LanzarFormularioConsulta( new FindAnimales(Modo.Consultar, this.cmbHembra) { ValorSexoFijo = Convert.ToChar("H") });
            }
        #endregion

        #region COMBOS
            private void cmbStatusOrdeno_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbStatusOrdeno, StatusOrdeno.Buscar());
            }
            private void cmbStatusOrdeno_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                
                StatusOrdeno ObjetoBase = new StatusOrdeno();
                EditStatusOrdeno editStatusOrdeno = new EditStatusOrdeno(Modo.Guardar, ObjetoBase);
                editStatusOrdeno.Descripcion = e.TextoCrear;

                CrearNuevoElementoCombo(editStatusOrdeno, sender);

            }

            private void cmbStatusControl_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbStatusControl, StatusControl.Buscar());
            }
            private void cmbStatusControl_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                
                StatusControl ObjetoBase = new StatusControl();
                EditStatusControl editStatusControl = new EditStatusControl(Modo.Guardar, ObjetoBase);
                editStatusControl.Descripcion = e.TextoCrear;

                CrearNuevoElementoCombo(editStatusControl, sender);

                
            }

     
        #endregion

    }
}

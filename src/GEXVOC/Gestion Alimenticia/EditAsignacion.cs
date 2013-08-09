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
    public partial class EditAsignacion : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES
        public EditAsignacion()
        {
            InitializeComponent();
            CargarValoresDefecto();
            
        }
        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga el combo del formulario
        /// </summary>
        protected override void CargarCombos()
        {
            cargando = true;
            try
            {
                    this.CargarCombo(this.cmbLote, "Descripcion", "Id", LoteAnimal.Buscar(Configuracion.Explotacion.Id, string.Empty,null,null,null,null ));
                    cmbRacion.CargarCombo();
                    
            }
            catch (Exception){}
            finally
            { cargando = false; }

           
                   
                                  
        }
        

        
        /// <summary>
        /// Carga los valores por defecto del formulario.
        /// </summary>
        protected override void CargarValoresDefecto()
        {
            Generic.DatetimeAControl(this.txtFechaAsignacion, DateTime.Now.Date);
            Generic.IntAControl(txtPorcentaje, 100);
            
        }
        #endregion

        #region BINDING(Intercambio entre la clase base y los controles del formulario)

       
        /// <summary>
        /// Guarda los datos introducidos en el Grid.
        /// </summary>
        protected override void Guardar()
        {
            this.Validate(true);
            if (Validar())
            {
                IniciarContextoOperacion();
                string mensajeError = string.Empty;
                MensajeNotificarVarios = string.Empty;
                int OperacionesCorrectas = 0;
                int OperacionesIncorrectas = 0;

                Asignacion Objeto = null;
                int n = dtgAsignaciones.RowCount;
                int j = 0;
                try
                {
                    for (j = 0; j < n; j++)
                    {
                        if (this.dtgAsignaciones.Rows[j].Cells["idAsignacion"].Value != null)//compruebo que exista una asignación.
                        {

                            Objeto = Asignacion.Buscar((int)this.dtgAsignaciones.Rows[j].Cells["idAsignacion"].Value);
                            Objeto =(Asignacion) Objeto.CargarContextoOperacion(TipoContexto.Modificacion);
                            if (this.dtgAsignaciones.Rows[j].Cells["cmbRacionGrid"].Value != null)
                                Objeto.IdRacion = (int)dtgAsignaciones.Rows[j].Cells["cmbRacionGrid"].Value;                            
                            if (this.dtgAsignaciones.Rows[j].Cells["idAnimal"].Value != null)
                                Objeto.IdAnimal = (int)dtgAsignaciones.Rows[j].Cells["idAnimal"].Value;
                            if (this.dtgAsignaciones.Rows[j].Cells["Porcentaje"].Value != null)
                                Objeto.Porcentaje = Convert.ToDecimal(dtgAsignaciones.Rows[j].Cells["Porcentaje"].Value);
                            else
                                Objeto.Porcentaje = 0;
                            if (this.dtgAsignaciones.Rows[j].Cells["FechaInicio"].Value != null)
                                Objeto.FechaInicio = (DateTime)(dtgAsignaciones.Rows[j].Cells["FechaInicio"].Value);
                            else
                                Objeto.FechaInicio = Generic.ControlADatetime(txtFechaAsignacion);
                            if (this.dtgAsignaciones.Rows[j].Cells["Dias"].Value != null)
                            {
                                if (Convert.ToInt32(this.dtgAsignaciones.Rows[j].Cells["Dias"].Value) == 0)
                                    Objeto.FechaFin = Convert.ToDateTime(dtgAsignaciones.Rows[j].Cells["FechaInicio"].Value);
                                else
                                    Objeto.FechaFin = Convert.ToDateTime(dtgAsignaciones.Rows[j].Cells["FechaInicio"].Value).AddDays(Convert.ToInt32(dtgAsignaciones.Rows[j].Cells["Dias"].Value) - 1);

                            }
                            else
                                Objeto.FechaFin=Convert.ToDateTime(dtgAsignaciones.Rows[j].Cells["FechaInicio"].Value);

                            if (Objeto.GetType().GetInterface(typeof(INotificable).Name) != null)
                                ((INotificable)Objeto).Notificar += new EventHandler<NotificableEventArgs>(this.NotificarVarios); 

                            Objeto.Actualizar();
                            OperacionesCorrectas +=1;

                        }
                        else 
                        {
                            if (CrearNuevaAsignacion(j))
                            {
                                Objeto = new Asignacion();
                                Objeto.CargarContextoOperacion(TipoContexto.Insercion);
                                if (this.dtgAsignaciones.Rows[j].Cells["idAnimal"].Value != null)
                                    Objeto.IdAnimal = (int)dtgAsignaciones.Rows[j].Cells["idAnimal"].Value;
                                if (this.dtgAsignaciones.Rows[j].Cells["cmbRacionGrid"].Value != null)
                                    Objeto.IdRacion = (int)dtgAsignaciones.Rows[j].Cells["cmbRacionGrid"].Value;
                                if (this.dtgAsignaciones.Rows[j].Cells["Porcentaje"].Value != null)
                                    Objeto.Porcentaje = Convert.ToDecimal(dtgAsignaciones.Rows[j].Cells["Porcentaje"].Value);
                                else
                                    Objeto.Porcentaje = 0;
                                if (this.dtgAsignaciones.Rows[j].Cells["FechaInicio"].Value != null)
                                    Objeto.FechaInicio = Convert.ToDateTime(dtgAsignaciones.Rows[j].Cells["FechaInicio"].Value);
                                else
                                    Objeto.FechaInicio = Generic.ControlADatetime(txtFechaAsignacion);
                                if (this.dtgAsignaciones.Rows[j].Cells["Dias"].Value != null)
                                {
                                    if (Convert.ToInt32(this.dtgAsignaciones.Rows[j].Cells["Dias"].Value) == 0)
                                        Objeto.FechaFin = Convert.ToDateTime(dtgAsignaciones.Rows[j].Cells["FechaInicio"].Value);
                                    else
                                        Objeto.FechaFin = Convert.ToDateTime(dtgAsignaciones.Rows[j].Cells["FechaInicio"].Value).AddDays(Convert.ToInt32(dtgAsignaciones.Rows[j].Cells["Dias"].Value) - 1);

                                }
                                else
                                    Objeto.FechaFin = Convert.ToDateTime(dtgAsignaciones.Rows[j].Cells["FechaInicio"].Value);


                                if (Objeto.GetType().GetInterface(typeof(INotificable).Name) != null)
                                    ((INotificable)Objeto).Notificar += new EventHandler<NotificableEventArgs>(this.NotificarVarios); 

                                Objeto.Insertar();
                                OperacionesCorrectas += 1;
                            }



                        }
                    }
                }
                catch(Exception ex) 
                {
                    OperacionesIncorrectas += 1;
                    mensajeError += ex.Message + "\r";
                }

                FinalizarContextoOperacion();

                if (!string.IsNullOrEmpty(MensajeNotificarVarios))//Si se han producido notificaciones de una clase del tipo INotificable, las muestro                        
                    Principal.Mostrar_Mensaje(this.MensajeNotificarVarios);

                if (mensajeError != string.Empty)
                    Generic.AvisoAdvertencia("Se han producido errores en un total de (" + ((int)OperacionesCorrectas + OperacionesIncorrectas) + ")Opereaciones=>" + "(" + OperacionesCorrectas + ")Correctas y (" + OperacionesIncorrectas + ")Incorrectas.\r" + "Resumen e Información adicional:\r" + mensajeError);
                //this.Close();
                this.Limpiar();
            
            }
            
            
        }
        /// <summary>
        /// Función que se utiliza para reconocer si lo que se guarda es una nueva asignación o no.
        /// Se utiliza porque como la fecha de inicio y el porcentaje se pone por defecto a la hora 
        /// de guardar que solo se tengan en cuenta aquellas que el usuario crea.
        /// </summary>
        /// <param name="nfila"></param>
        /// <returns></returns>
        private bool CrearNuevaAsignacion(int nfila)
        {
            Boolean Rtno = false;
            
                if (this.dtgAsignaciones.Rows[nfila].Cells["cmbRacionGrid"].Value != null)
                    Rtno = true;
                
                if (this.dtgAsignaciones.Rows[nfila].Cells["Dias"].Value != null)
                    Rtno = true;
            
            return Rtno;
        
        }
        /// <summary>
        /// Valida los datos introducidos antes de guardarlos.
        /// </summary>
        /// <returns></returns>
        protected override bool Validar()
        {
            bool Rtno = true;
            this.ErrorProvider.Clear();           
            int n=dtgAsignaciones.RowCount;
            int j=0;
            for (j=0; j<n; j++)
            {
                if (CrearNuevaAsignacion(j))
                {
                    

                    if (!Generic.DatosRequeridosGrid(dtgAsignaciones.Rows[j].Cells["cmbRacionGrid"],  "Para guardar la asignación este dato es requerido"))
                        Rtno = false;
                    if (!Generic.DatosRequeridosGrid(dtgAsignaciones.Rows[j].Cells["Porcentaje"], "Para guardar la asignación este dato es requerido"))
                        Rtno = false;
                    if (!Generic.DatosRequeridosGrid(dtgAsignaciones.Rows[j].Cells["FechaInicio"], "Para guardar la asignación este dato es requerido"))
                        Rtno = false;
                
                }

                if(dtgAsignaciones.Rows[j].Cells["Porcentaje"].Value!=null)
                    if (!Validacion.EsNumero(dtgAsignaciones.Rows[j].Cells["Porcentaje"].Value))
                    {
                        dtgAsignaciones.Rows[j].Cells["Porcentaje"].ErrorText = "No es un número";
                        Rtno = false;
                    }
                if (dtgAsignaciones.Rows[j].Cells["FechaInicio"].Value != null)
                    if (!Generic.DatosCorrectoGrid(dtgAsignaciones.Rows[j].Cells["FechaInicio"],"El dato no es de tipo Fecha.",typeof(System.DateTime)))                       
                        Rtno = false;

                if (dtgAsignaciones.Rows[j].Cells["Dias"].Value != null)
                    if (!Validacion.EsEnteroPositivo(dtgAsignaciones.Rows[j].Cells["Dias"].Value))
                    {
                        dtgAsignaciones.Rows[j].Cells["Dias"].ErrorText = "No es un número entero positivo";
                        Rtno = false;
                    }
                                   
            }

            return Rtno;
        }

        /// <summary>
        /// Elimina las asignaciones seleccionadas del Grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbEliminarAsignacion_Click(object sender, EventArgs e)
        {
            this.IniciarContextoOperacion();
            try
            {
                if (dtgAsignaciones.SelectedRows.Count > 0)
                {
                    int OperacionesCorrectas = 0;
                    int OperacionesIncorrectas = 0;
                    if (DialogResult.Yes == Generic.Aviso("Va a eliminar las asignaciones seleccionadas ¿Está seguro que desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        string mensajeError = string.Empty;
                        MensajeNotificarVarios = String.Empty;

                        foreach (DataGridViewRow item in dtgAsignaciones.SelectedRows)
                        {
                            try
                            {
                                if (dtgAsignaciones.Rows[item.Index].Cells["idAsignacion"].Value != null)
                                {
                                    Asignacion ObjetoEliminar = Asignacion.Buscar((int)dtgAsignaciones.Rows[item.Index].Cells["idAsignacion"].Value);
                                    if (ObjetoEliminar != null)
                                    {
                                        if (ObjetoEliminar.GetType().GetInterface(typeof(INotificable).Name) != null)
                                            ((INotificable)ObjetoEliminar).Notificar += new EventHandler<NotificableEventArgs>(this.NotificarVarios); 

                                        ObjetoEliminar.Eliminar();
                                    }

                                    OperacionesCorrectas += 1;
                                }


                            }
                            catch (Exception ex)
                            {
                                mensajeError += ex.Message + "\r";
                                OperacionesIncorrectas += 1;
                            }
                        }

                        if (!string.IsNullOrEmpty(MensajeNotificarVarios))//Si se han producido notificaciones de una clase del tipo INotificable, las muestro                        
                            Principal.Mostrar_Mensaje(this.MensajeNotificarVarios);

                        if (mensajeError != string.Empty)
                        {
                            Generic.AvisoAdvertencia("Se han producido errores en un total de (" + ((int)OperacionesCorrectas + OperacionesIncorrectas) + ") Operaciones => " +
                                                 "(" + OperacionesCorrectas + ") Correctas y (" + OperacionesIncorrectas + ") Incorrectas.\r" +
                                                 "Resumen e Información adicional: \r" +
                                                   mensajeError);
                        }

                        Buscar();
                    }
                }
            }
            catch (Exception ex)
            {
                Generic.AvisoError("Error eliminando.\rMensaje: " + ex.Message);
            }
            finally
            { this.FinalizarContextoOperacion(); }
        }


        #endregion

        #region GRID
        /// <summary>
        /// Busca las asignaciones segun fecha y según animales seleccionados, si no se selecciona
        /// ningun animal busca las asignaciones para una determinada fecha para todos los animales
        /// de la explotación.
        /// </summary>    
        protected override void Buscar()
        {
            List<Animal> lstAnimales = null;
            if (cmbLote.SelectedValue == null && cmbSeleccionAnimales.SelectedValue == null)
                lstAnimales = Animal.Buscar(Configuracion.Explotacion.Id, null, false);
            else if (cmbLote.SelectedValue != null)
            {
                LoteAnimal loteAnimal = LoteAnimal.Buscar((int)cmbLote.SelectedValue);
                lstAnimales = loteAnimal.lstAnimales;
            }
            else if (cmbSeleccionAnimales.SelectedValue != null)
                lstAnimales = (List<Animal>)this.cmbSeleccionAnimales.DataSource;

            CargarGridAsignacion(lstAnimales);

        }

        /// <summary>
        /// Carga el Grid después de darle a la opción busqueda de asignaciones.
        /// </summary>
        /// <param name="lstAnimales"></param>
        private void CargarGridAsignacion(List<Animal> lstAnimales)
        {
            try
            {
                if (ValidarBusqueda())
                {
                    this.dtgAsignaciones.Rows.Clear();
                    lblBarraEstado.Text = "Buscando..";
                    if (lstAnimales != null)
                        {
                            
                            foreach (Animal animal in lstAnimales)
                            {
                                Asignacion asignacion = null;
                                foreach (Asignacion A in animal.lstAsignacion)
                                    if (A.FechaInicio == Generic.ControlADatetime(txtFechaAsignacion))
                                    {
                                        asignacion = A;
                                        
                                        int? idAsignacion = null;
                                        decimal? porcentaje = null;
                                        int? racion = null;
                                        DateTime? fechaInicio = null;
                                        int? dias = null;
                                        if (asignacion != null)
                                        {
                                            idAsignacion = asignacion.Id;
                                            porcentaje = asignacion.Porcentaje;
                                            fechaInicio = asignacion.FechaInicio;
                                            dias = ((DateTime)asignacion.FechaFin - (DateTime)asignacion.FechaInicio).Days + 1;
                                            racion = asignacion.IdRacion;
                                            dtgAsignaciones.Rows.Add(animal.Id, idAsignacion, animal.Identificador, animal.Nombre, animal.DescEstado, racion, porcentaje, fechaInicio, dias);
                                        }

                                    }
                                asignacion = null;
                                

                            }
                        }
                        
                    }
                    this.lblBarraEstado.Text = "Búsqueda finalizada. (Registros: " + dtgAsignaciones.Rows.Count.ToString() + ") ";
                }
                catch (Exception ex)
                {
                    Generic.AvisoError("Error en la busqueda.\rMensaje:" + ex.Message);
                }

        
        }

        /// <summary>
        /// Carga el Grid con los animales seleccionados para así poder crear nuevas asignaciones.
        /// </summary>
        /// <param name="lstAnimales"></param>
        private void CargarGridSinAsignacion(List<Animal> lstAnimales)
        {
            try
            {
                if (ValidarBusqueda())
                {
                    this.dtgAsignaciones.Rows.Clear();
                    lblBarraEstado.Text = "Buscando..";
                    if (lstAnimales != null)
                    {
                        decimal? porcentaje = null;
                        DateTime? fechaInicio = null;
                        foreach (Animal animal in lstAnimales)
                        {
                            
                            porcentaje = Generic.ControlAInt(txtPorcentaje);
                            fechaInicio = Generic.ControlADatetime(txtFechaAsignacion);
                            dtgAsignaciones.Rows.Add(animal.Id, null, animal.Identificador, animal.Nombre, animal.DescEstado, null, porcentaje, fechaInicio, null);

                            
                        }
                    }

                }
                this.lblBarraEstado.Text = "Búsqueda finalizada. (Registros: " + dtgAsignaciones.Rows.Count.ToString() + ") ";
            }
            catch (Exception ex)
            {
                Generic.AvisoError("Error en la busqueda.\rMensaje:" + ex.Message);
            }

        
        
        }
       
        /// <summary>
        /// Valida que la fecha de asignación utilizada en la busqueda sea una fecha, se realiza la 
        /// validación antes de la busqueda.
        /// </summary>
        /// <returns></returns>
        private bool ValidarBusqueda()
        {
            bool Rtno = true;
            this.ErrorProvider.Clear();

            //if (!Generic.ControlValorado(cmbLote, this.ErrorProvider, "Tiene que seleccionar algun animal") && !Generic.ControlValorado(cmbSeleccionAnimales, this.ErrorProvider, "Tiene que seleccionar algun animal"))
            //    Rtno = false;
            if (!Generic.ControlDatosCorrectos(txtFechaAsignacion, this.ErrorProvider, "El dato requerido para la busqueda no es de tipo fecha", typeof(System.DateTime), true))
                Rtno = false;
            return Rtno;

        }

        #endregion

        #region FUNCIONAMIENTO GENERAL

        /// <summary>
        /// Se captura este evento para el textbox txtPorcentaje para poder seleccionar un valor por defecto
        /// del porcentaje de ración que se va a dar a cada uno de los animales previamente seleccionados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPorcentaje_TextChanged(object sender, EventArgs e)
        {
            int n = dtgAsignaciones.RowCount;
            int j = 0;
            for (j = 0; j < n; j++)
            {
                if (txtPorcentaje.Text != string.Empty)
                    this.dtgAsignaciones.Rows[j].Cells["Porcentaje"].Value = txtPorcentaje.Text;
                else
                    this.dtgAsignaciones.Rows[j].Cells["Porcentaje"].Value = string.Empty;
            }

        }
        
        /// <summary>
        /// Se captura este evento para el textbox txtDias para poder seleccionar un valor por defecto de la
        /// cantidad de días para la cual se distribuye cada ración, por animal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            int n = dtgAsignaciones.RowCount;
            int j = 0;
            for (j = 0; j < n; j++)
            {
                if (txtDias.Text != string.Empty)
                    this.dtgAsignaciones.Rows[j].Cells["Dias"].Value = txtDias.Text;
                else
                    this.dtgAsignaciones.Rows[j].Cells["Dias"].Value = string.Empty;
            }

        }

        /// <summary>
        /// Se captura este evento para indicar con un color de fondo diferente aquellas filas del Grid 
        /// que corresponda con animales enfermos en el periodo en el que se quiere crear la asignación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgAsignaciones_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (Animal.AnimalEnfermo((int)dtgAsignaciones.Rows[e.RowIndex].Cells["idAnimal"].Value, Generic.ControlADatetime(txtFechaAsignacion)))
                dtgAsignaciones.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Coral;
        }
        /// <summary>
        /// Se captura este evento para poder consultar el diagnostico de aquellos animales enfermos en la 
        /// fecha de asignación alimenticia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgAsignaciones_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgAsignaciones.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.Coral)
            {
                Animal animalConsultar = Animal.Buscar((int)this.dtgAsignaciones.Rows[e.RowIndex].Cells["idAnimal"].Value);
                DiagAnimal diagAnimal = animalConsultar.UltimoDiagnosticoAnimal();    
                EditDiagAnimal  frmEditDiagAnimal = new EditDiagAnimal(Modo.Actualizar,diagAnimal); 
                this.LanzarFormulario(frmEditDiagAnimal, dtgAsignaciones);
            }

        }

        /// <summary>
        /// Se captura este evento para lanzar el formulario SelectorAnimales. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarAnimales_Click(object sender, EventArgs e)
        {
            SelectorAnimales frmSelectorAnimales = new SelectorAnimales(Modo.Consultar, (List<Animal>)this.cmbSeleccionAnimales.DataSource);
            this.LanzarFormulario(frmSelectorAnimales);
            if (frmSelectorAnimales.LstAnimalesSeleccionadosRtno != null)
            {
                this.cmbSeleccionAnimales.DataSource = frmSelectorAnimales.LstAnimalesSeleccionadosRtno;
                this.cmbSeleccionAnimales.Text = "(" + frmSelectorAnimales.LstAnimalesSeleccionadosRtno.Count + ")Animales en selección";

            
            }
        }
      
        /// <summary>
        /// Se captura este evento para que una vez seleccionado un grupo de animales en el formulario
        /// SelectorAnimales se muestren en el Grid para poder crear sus asignaciones alimenticias.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSeleccionAnimales_TextChanged(object sender, EventArgs e)
        {
            List<Animal> lstAnimales = null;
            if (cmbSeleccionAnimales.SelectedValue != null)
            {
                lstAnimales = (List<Animal>)this.cmbSeleccionAnimales.DataSource;
                CargarGridSinAsignacion(lstAnimales);
            }
        }

        bool cargando = false;
        /// <summary>
        /// Se captura este evento para que una vez seleccionado un valor en combo de lotes de animales
        /// se carge la lista de animales que componen el lote en el Grid para poder crear sus asignaciones
        /// alimenticias.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbLote_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cargando)
            {
                List<Animal> lstAnimales = null;
                if (cmbLote.SelectedValue!=null)
                {
                    LoteAnimal loteAnimal = LoteAnimal.Buscar((int)cmbLote.SelectedValue);
                    lstAnimales = loteAnimal.lstAnimales;
                    CargarGridSinAsignacion(lstAnimales);
                }

            }

        }


        #endregion

        #region COMBOS

        /// <summary>
        /// Se captura este evento para el combo cmbRacion para poder seleccionar un valor por defecto
        /// en la ración (combo de la ración del Grid) para todos los animales previamente seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbRacion_SelectedValueChanged(object sender, EventArgs e)
        {
            int n = dtgAsignaciones.RowCount;
            int j = 0;
            for (j = 0; j < n; j++)
            {
                int? idRacion= Generic.ControlAIntNullable(cmbRacion);
                if (idRacion.HasValue)
                    this.dtgAsignaciones.Rows[j].Cells["cmbRacionGrid"].Value = idRacion;

            }
        }
        private void cmbRacion_CargarContenido(object sender, EventArgs e)
        {
           
            this.cmbRacionGrid.ValueMember = "Id";
            this.cmbRacionGrid.DisplayMember = "Descripcion";
            Racion racionnula = new Racion();
            List<Racion> listatotal = Racion.Buscar();
            listatotal.Add(racionnula);
            this.cmbRacionGrid.DataSource = listatotal;

            this.CargarCombo(this.cmbRacion, Racion.Buscar());
        }
        private void cmbRacion_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
        {
            
            Racion ObjetoBase = new Racion();
            EditRacion editRacion = new EditRacion(Modo.Guardar, ObjetoBase);
            editRacion.Descripcion = e.TextoCrear;

            CrearNuevoElementoCombo(editRacion, sender);
         
        }


        #endregion

    }
}

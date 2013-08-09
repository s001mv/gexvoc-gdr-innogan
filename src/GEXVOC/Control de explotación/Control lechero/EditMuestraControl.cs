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
    public partial class EditMuestraControl : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES

        public EditMuestraControl()
        {
            InitializeComponent();            
            CargarValoresDefecto();
        }
        
        
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        

       
        
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

        /// <summary>
        /// Carga los datos de en los combos  estado de control y estado ordeño y en el textbox de la fecha,
        /// de cada una de las filas seleccionadas en el datagrid.
        /// </summary>
        private void CargarDatos()
        {
            if (dtgControles.SelectedRows[0] != null)
            {
                ControlLeche Objeto = null;

                if (dtgControles.SelectedRows[0].Cells[1].Value != null)
                    Objeto = ControlLeche.Buscar((int)dtgControles.SelectedRows[0].Cells[1].Value);
                
                if (Objeto != null)
                {              
                    cmbStatusControl.SelectedValue = dtgControles.SelectedRows[0].Cells[2].Value;
                    if (dtgControles.SelectedRows[0].Cells[3].Value != null)
                        cmbStatusOrdeno.SelectedValue = dtgControles.SelectedRows[0].Cells[3].Value;
                    if (dtgControles.SelectedRows[0].Cells[3].Value == null)
                        cmbStatusOrdeno.SelectedValue = 0;
                    Generic.DatetimeAControl(txtFechaControl, Objeto.Fecha);

                }
                else
                {
                    Objeto = new ControlLeche();
                    cmbStatusControl.SelectedValue = Objeto.IdControl;
                    cmbStatusOrdeno.SelectedValue = 0;
                }
                


            }
            

        }

        /// <summary>
        /// Se utiliza para comprobar que existe una lactación abierta anterior al control lechero introducido.
        /// (Ocurre cuando hay dos partos o un parto y un aborto con lactación y no hay un secado en medio)
        /// Esta función se utiliza para avisar al usuario de la existencia de una lactación abierta anterior
        /// y darle la opción de cancelar la operación y así el cerrar la lactación anterior introduciendo un
        /// secado o bien si continua con la operación se le cerrará automaticamente la lactación anterior 
        /// insertandose un secado, esto se controla en la logica.
        /// </summary>
        /// <param name="nfila"></param>
        /// <returns></returns>
        private bool ComprobarLactacionAbierta(int nfila)
        {
           bool rtno = false;

           if (CrearNuevoControl(nfila))
           {
               if (dtgControles.Rows[nfila].Cells[0].Value != null)
               {
                   Animal hembra = Animal.Buscar((int)dtgControles.Rows[nfila].Cells[0].Value);
                   Lactacion lactacion = hembra.UltimaLactacionAbierta();

                   DateTime? UltimaFechaParto_Aborto = hembra.UltimaFechaParto_Aborto(hembra.Id);
                   Aborto ultimoaborto = hembra.UltimoAborto();

                   ///Hay que tener en cuenta que si lo que ocurre es que es un aborto continuando lactacion la funcion debe retornar falso,
                   ///porque aunque exista lactacion abierta, no se debe cerrar, puesto que se continua.

                   if (lactacion != null && UltimaFechaParto_Aborto.HasValue && (lactacion.FechaInicio < UltimaFechaParto_Aborto && (UltimaFechaParto_Aborto < Generic.ControlADatetime(txtFechaControl))))
                   {
                       if (ultimoaborto == null || (ultimoaborto.IdTipo != Configuracion.TipoAbortoSistema(Configuracion.TiposAbortosSistema.ABORTO_CONTINUANDO_LACTACIÓN).Id && ultimoaborto.Fecha == UltimaFechaParto_Aborto))                      
                           rtno = true;
                   }
               }
           }
            
            return rtno;
        }

        
        /// <summary>
        /// Llama a la función guardar o en el caso de la existencia de una lactación abierta anterior da la 
        /// ópción de cancelar o seguir con la operación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void Guardar(object sender, EventArgs e)
        {
            string nombres = string.Empty;
                int n = dtgControles.RowCount;
                int j = 0;
                for (j = 0; j < n; j++)
                {
                    if(ComprobarLactacionAbierta(j))
                    {
                        nombres +=dtgControles.Rows[j].Cells[4].Value.ToString()+" ";
                    }            
                }
                if (nombres != string.Empty)
                {
                    DialogResult rdo = MessageBox.Show("La/s hembra/s: " + nombres+ " tiene/n lactaciones abiertas anteriores al último parto o aborto si continua se cerrará la lactación anterior y se abrirá una nueva,¿Desea continuar?", "Pregunta:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rdo == DialogResult.Yes)
                        Guardar();
                    else
                        Buscar();
                }
                else
                    Guardar();
            
            
        }
        /// <summary>
        /// Guarda las actualizaciones o los nuevos controles lecheros introducidos.
        /// </summary>
        protected override void Guardar()
        {
            this.Validate(true);
                
                if(Validar())
                {
                    IniciarContextoOperacion();
                    string mensajeError = string.Empty;
                    int OperacionesCorrectas = 0;
                    int OperacionesIncorrectas = 0;

                    ControlLeche Objeto=null;
                    int n = dtgControles.RowCount;
                    int j = 0;
                    try
                    {
                        
                        for (j = 0; j < n; j++)
                        {
                            if (this.dtgControles.Rows[j].Cells[1].Value != null)
                            {
                                Objeto = ControlLeche.Buscar((int)this.dtgControles.Rows[j].Cells[1].Value);
                                Objeto=(ControlLeche)Objeto.CargarContextoOperacion(TipoContexto.Modificacion);
                                if (this.dtgControles.Rows[j].Cells[0].Value != null)
                                    Objeto.IdHembra = (int)dtgControles.Rows[j].Cells[0].Value;           
                                Generic.ControlAClaseBase(Objeto, "Fecha", txtFechaControl);                                
                                if (this.dtgControles.Rows[j].Cells[2].Value != null)
                                    Objeto.IdControl = (int)dtgControles.Rows[j].Cells[2].Value;                                
                                if (this.dtgControles.Rows[j].Cells[3].Value != null)
                                    Objeto.IdOrdeno = (int)dtgControles.Rows[j].Cells[3].Value;
                                if (this.dtgControles.Rows[j].Cells[7].Value != null)
                                    Objeto.LecheManana = Convert.ToDecimal(dtgControles.Rows[j].Cells[7].Value);
                                else
                                    Objeto.LecheManana = 0;
                                if (this.dtgControles.Rows[j].Cells[8].Value != null)
                                    Objeto.LecheTarde = Convert.ToDecimal(dtgControles.Rows[j].Cells[8].Value);
                                else
                                    Objeto.LecheTarde = 0;
                                if (this.dtgControles.Rows[j].Cells[9].Value != null)
                                    Objeto.LecheNoche = Convert.ToDecimal(dtgControles.Rows[j].Cells[9].Value);
                                else
                                    Objeto.LecheNoche = 0;
                                Objeto.Actualizar();
                            }
                            else
                            {
                                if (CrearNuevoControl(j))
                                {
                                    Objeto = new ControlLeche();
                                    Objeto=(ControlLeche)Objeto.CargarContextoOperacion(TipoContexto.Insercion);
                                    if (this.dtgControles.Rows[j].Cells[0].Value != null)
                                        Objeto.IdHembra = (int)dtgControles.Rows[j].Cells[0].Value;
                                    Generic.ControlAClaseBase(Objeto, "Fecha", txtFechaControl);                                    
                                    if (this.dtgControles.Rows[j].Cells[2].Value != null)
                                        Objeto.IdControl = (int)dtgControles.Rows[j].Cells[2].Value;                                    
                                    if (this.dtgControles.Rows[j].Cells[3].Value != null)
                                        Objeto.IdOrdeno = (int)dtgControles.Rows[j].Cells[3].Value;
                                    if (this.dtgControles.Rows[j].Cells[7].Value != null)
                                        Objeto.LecheManana = Convert.ToDecimal(dtgControles.Rows[j].Cells[7].Value);
                                    else
                                        Objeto.LecheManana = 0;
                                    if (this.dtgControles.Rows[j].Cells[8].Value != null)
                                        Objeto.LecheTarde = Convert.ToDecimal(dtgControles.Rows[j].Cells[8].Value);
                                    else
                                        Objeto.LecheTarde = 0;
                                    if (this.dtgControles.Rows[j].Cells[9].Value != null)
                                        Objeto.LecheNoche = Convert.ToDecimal(dtgControles.Rows[j].Cells[9].Value);
                                    else
                                        Objeto.LecheNoche = 0;


                                    Objeto.Insertar();
                                    OperacionesCorrectas += 1;
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        OperacionesIncorrectas += 1;
                        mensajeError += ex.Message + "\r";

                    }
                    FinalizarContextoOperacion();
                    if (mensajeError != string.Empty)
                        Generic.AvisoAdvertencia("Se han producido errores en un total de (" + ((int)OperacionesCorrectas + OperacionesIncorrectas) + ")Opereaciones=>" + "(" + OperacionesCorrectas + ")Correctas y (" + OperacionesIncorrectas + ")Incorrectas.\r" + "Resumen e Información adicional:\r" + mensajeError);
                    this.Limpiar();
                }
                

            
        }


        /// <summary>
        /// Validación de los Controles, se realiza antes de guardar en la base de datos.
        /// </summary>
        /// <returns>Controles válidos (Si/No)</returns>
        protected override bool Validar()
        {
            bool Rtno = true;
            this.ErrorProvider.Clear();
                     

            if (!Generic.ControlValorado(new Control[] { cmbStatusControl, txtFechaControl }, this.ErrorProvider, "Faltan datos requeridos"))
                    Rtno = false;
            if (!Generic.ControlDatosCorrectos(txtFechaControl, this.ErrorProvider, "El dato requerido es de tipo fecha", typeof(System.DateTime), true))
                Rtno = false;
            int n = dtgControles.RowCount;
            int j = 0;
            for (j = 0; j < n; j++)
            {
                if (dtgControles.Rows[j].Cells[7].Value != null)
                    if (!Validacion.EsNumero(dtgControles.Rows[j].Cells[7].Value))
                    {
                        dtgControles.Rows[j].Cells[7].ErrorText = "No es un número";
                        Rtno = false;
                    }
                if (dtgControles.Rows[j].Cells[8].Value != null)
                    if (!Validacion.EsNumero(dtgControles.Rows[j].Cells[8].Value))
                    {
                        dtgControles.Rows[j].Cells[8].ErrorText = "No es un número";
                        Rtno = false;
                    }
                if (dtgControles.Rows[j].Cells[9].Value != null)
                    if (!Validacion.EsNumero(dtgControles.Rows[j].Cells[9].Value))
                    {
                        dtgControles.Rows[j].Cells[9].ErrorText = "No es un número";
                        Rtno = false;
                    }

            }

            return Rtno;

        }

        /// <summary>
        /// Función que se utiliza para saber si lo que se guarda es un nuevo control o no.
        /// Se utiliza porque el estado control y el estado ordeño son valores que se ponen
        /// por defecto para todas las hembras que se listan en el DataGrid y a lo mejor no a 
        /// todas se le crea un nuevo control lechero.
        /// </summary>
        /// <param name="nfila"></param>
        /// <returns></returns>
        private bool CrearNuevoControl(int nfila)
        {
            Boolean Rtno = false;

            if (this.dtgControles.Rows[nfila].Cells["txtManana"].Value != null)
                Rtno = true;
            if (this.dtgControles.Rows[nfila].Cells["txtTarde"].Value != null)
                Rtno = true;
            if (this.dtgControles.Rows[nfila].Cells["txtNoche"].Value != null)
                Rtno = true;
            return Rtno;

        }

        /// <summary>
        /// Elimina los controles lecheros seleccionados por el usuario en el DataGrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbEliminarControl_Click(object sender, EventArgs e)
        {

            this.IniciarContextoOperacion();
            try
            {
                if (dtgControles.SelectedRows.Count > 0)
                {
                    int OperacionesCorrectas = 0;
                    int OperacionesIncorrectas = 0;
                    if (DialogResult.Yes == Generic.Aviso("Va a eliminar los controles seleccionados ¿Está seguro que desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        string mensajeError = string.Empty;

                        foreach (DataGridViewRow item in dtgControles.SelectedRows)
                        {
                            try
                            {
                                if (dtgControles.Rows[item.Index].Cells[1].Value != null)
                                {
                                    ControlLeche ObjetoEliminar = ControlLeche.Buscar((int)dtgControles.Rows[item.Index].Cells[1].Value);
                                    if (ObjetoEliminar != null)
                                    {
                                        ObjetoEliminar.IdHembra = (int)dtgControles.Rows[item.Index].Cells[0].Value;
                                        ObjetoEliminar.Eliminar();
                                    }
                                }
                                OperacionesCorrectas += 1;
                            }
                            catch (Exception ex)
                            {
                                mensajeError += ex.Message + "\r";
                                OperacionesIncorrectas += 1;
                            }

                            if (mensajeError != string.Empty)
                            {
                                Generic.AvisoAdvertencia("Se han producido errores en un total de (" + ((int)OperacionesCorrectas + OperacionesIncorrectas) + ") Operaciones => " +
                                                     "(" + OperacionesCorrectas + ") Correctas y (" + OperacionesIncorrectas + ") Incorrectas.\r" +
                                                     "Resumen e Información adicional: \r" +
                                                       mensajeError);
                            }


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

        #region CARGAS COMUNES
        /// <summary>
        /// Carga como valor por defecto la fecha del control del formulario.
        /// </summary>
        protected override void CargarValoresDefecto()
        {
            Generic.DatetimeAControl(this.txtFechaControl, DateTime.Now.Date);
            //txtExplotacion.Text = Configuracion.Explotacion.Nombre;
            //if (cmbEspecie.SelectedValue == null)
            //{
            //    cmbEspecie.SelectedValue = 1;
            //}
        }

        /// <summary>
        /// Carga los combos del formulario.
        /// </summary>
        protected override void CargarCombos()
        {

           
            this.CargarCombo(this.cmbEspecie, "Descripcion", Configuracion.Explotacion.lstEspecies, true);
            this.CargarCombo(cmbStatusControl, "Descripcion", "Id", StatusControl.Buscar());
            this.CargarCombo(cmbStatusOrdeno, "Descripcion", "Id", StatusOrdeno.Buscar());


        }
        
        #endregion

        #region GRIDS

        
        /// <summary>
        /// Busca todos aquellas hembras que están en periodo de lactación bien porque tuvieron un parto
        /// o un aborto seguido de lactación. La busqueda se realiza por fecha y por especie.
        /// </summary>
        protected override void Buscar()
        {
            try
            {
                if (ValidarBusqueda())
                {
                    lblBarraEstado.Text = "Buscando...";

                    this.dtgControles.Rows.Clear();
                    
                    foreach (Animal animal in Animal.Buscar(Configuracion.Explotacion.Id, (int)cmbEspecie.SelectedValue, false))
                    {
                        Lactacion lactacion = Lactacion.BuscarLactacionAbierta(animal.Id);

                        int? idControlLeche = null;
                        decimal? manana = null;
                        decimal? tarde = null;
                        decimal? noche = null;
                        int? statuscontrol = Generic.ControlAIntNullable(cmbStatusControl);
                        int? statusordeno = Generic.ControlAIntNullable(cmbStatusOrdeno); 

                        Parto P = animal.UltimoParto();
                        Aborto A = animal.UltimoAbortoConLactacion();
                        Secado S = animal.UltimoSecado();

                        // Fecha del último evento ocurrido entre los partos y abortos de la hembra.
                        DateTime? Fecha = null;

                        if (P != null)
                            Fecha = P.Fecha;

                        if (A != null && (Fecha == null || A.Fecha > Fecha))
                            Fecha = A.Fecha;

                        if (Fecha != null && Fecha <= Generic.ControlADatetime(txtFechaControl) && (S == null || Fecha > S.Fecha))
                        {
                            if (lactacion != null && Generic.ControlADatetime(txtFechaControl) >= lactacion.PrimerControl().Fecha)
                            {
                                ControlLeche control = null;

                                foreach (ControlLeche controlLeche in lactacion.lstControlesLeche)
                                    if (controlLeche.Fecha == Generic.ControlADatetime(txtFechaControl))
                                    {
                                        control = controlLeche;
                                        break;
                                    }

                                if (control != null)
                                {
                                    idControlLeche = control.Id;

                                    if (control.LecheManana != 0) manana = control.LecheManana;
                                    if (control.LecheTarde != 0) tarde = control.LecheTarde;
                                    if (control.LecheNoche != 0) noche = control.LecheNoche;
                                    if (control.StatusControl != null) statuscontrol = control.IdControl;
                                    if (control.StatusOrdeno != null) statusordeno = control.IdOrdeno;
                                }

                                control = null;
                            }

                            if (lactacion == null || Generic.ControlADatetime(txtFechaControl) >= lactacion.PrimerControl().Fecha)
                                this.dtgControles.Rows.Add(animal.Id, idControlLeche, statuscontrol, statusordeno, animal.Nombre, animal.Identificador, lactacion == null ? 1 : lactacion.lstControlesLeche.Count + 1, manana, tarde, noche);
                        }

                        lactacion = null;

                        P = null;
                        A = null;
                        S = null;
                    }
                }

                this.lblBarraEstado.Text = "Búsqueda finalizada. (Registros: " + dtgControles.Rows.Count.ToString() + ") ";
            }
            catch (Exception ex)
            {
                Generic.AvisoError("Error en la busqueda.\rMensaje: " + ex.Message);
            }
         }

        /// <summary>
        /// Se realiza antes de la busqueda de las hembras en periodo de lactación, se controla que la especie
        /// y la fecha no estean nulos y que la fecha sea un dato correcto.
        /// </summary>
        /// <returns></returns>
        private bool ValidarBusqueda()
        {
            bool Rtno = true;
            this.ErrorProvider.Clear();

            if (!Generic.ControlValorado(new Control[] { txtFechaControl, cmbEspecie }, this.ErrorProvider, "Faltan datos requeridos para la busqueda"))
                Rtno = false;
            if (!Generic.ControlDatosCorrectos(txtFechaControl, this.ErrorProvider, "El dato requerido para la busqueda no es de tipo fecha", typeof(System.DateTime), true))
                Rtno = false;
            return Rtno;

        }
       
        
        
        
        #endregion

        #region FUNCIONAMIENTO GENERAL

        /// <summary>
        /// Se captura este evento del DataGrid para que cada vez que se seleccione una fila del DataGrid
        /// se llame a la función CargarDatos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgControles_SelectionChanged(object sender, EventArgs e)
            {
            if (dtgControles.Rows.Count > 0)
            {
                if (dtgControles.SelectedRows.Count == 1)
                    CargarDatos();

            }
        }

       
       

        #endregion

        #region COMBOS
            
            private void cmbStatusOrdeno_SelectedValueChanged(object sender, EventArgs e)
            {
                int n = dtgControles.RowCount;
                int j = 0;
                for (j = 0; j < n; j++)
                {
                    if (cmbStatusOrdeno.SelectedValue != null)
                        this.dtgControles.Rows[j].Cells["IdOrdeno"].Value = (int)cmbStatusOrdeno.SelectedValue;


                }
            }
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

            private void cmbStatusControl_SelectedValueChanged(object sender, EventArgs e)
            {
                int n = dtgControles.RowCount;
                int j = 0;
                for (j = 0; j < n; j++)
                {
                    if (cmbStatusControl.SelectedValue != null)
                        this.dtgControles.Rows[j].Cells["IdStatusControl"].Value = (int)cmbStatusControl.SelectedValue;


                }
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

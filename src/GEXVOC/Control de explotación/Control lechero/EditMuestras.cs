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
    public partial class EditMuestras : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES
        public EditMuestras()
        {
            InitializeComponent();
            CargarValoresDefecto();
        }
        
        #endregion 

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        

        
        #endregion

        #region BINDING (Intercambio datos entre la base datos y los controles del formulario)
        ///// <summary>
        ///// Carga los datos de la fecha de analisis y el laboratorio una vez seleccionada una fila del
        ///// DataGrid para poder consultarlos o modificarlos.
        ///// </summary>
        //protected void CargarDatos()
        //{
        //    if (dtgMuestras.SelectedRows[0] != null)
        //    {
        //        MuestraControl Objeto = null;
        //        if (dtgMuestras.SelectedRows[0].Cells["IdMuestra"].Value != null)
        //            Objeto = MuestraControl.Buscar((int)dtgMuestras.SelectedRows[0].Cells["IdMuestra"].Value);


        //        if (Objeto != null)
        //        {
        //            //dtgMuestras.SelectedRows[0].Cells["IdLaboratorio"].Value = Objeto.IdLaboratorio;
        //            if (dtgMuestras.SelectedRows[0].Cells["IdLaboratorio"].Value != null)
        //                cmbLaboratorio.SelectedValue = (int)dtgMuestras.SelectedRows[0].Cells["IdLaboratorio"].Value);
        //            Generic.DatetimeAControl(txtFechaAnalisis, Objeto.Fecha);

        //        }
        //        else
        //            cmbLaboratorio.ClaseActiva = null;
        //    }
        
        //}
        
        /// <summary>
        /// Guarda las nuevas muestras y la actualización de muestras anteriores.
        /// </summary>
        protected override void  Guardar()

        {
            this.Validate(true);
                
                if(Validar())
                {
                    IniciarContextoOperacion();
                    string mensajeError = string.Empty;
                    int OperacionesCorrectas = 0;
                    int OperacionesIncorrectas = 0;

                    MuestraControl Objeto=null;
                    int n = dtgMuestras.RowCount;
                    int j = 0;
                    try
                    {

                        for (j = 0; j < n; j++)
                        {
                            if (this.dtgMuestras.Rows[j].Cells["IdMuestra"].Value != null)
                            {
                                Objeto = MuestraControl.Buscar((int)this.dtgMuestras.Rows[j].Cells["IdMuestra"].Value);
                                Objeto=(MuestraControl)Objeto.CargarContextoOperacion(TipoContexto.Modificacion);
                                if (this.dtgMuestras.Rows[j].Cells["IdControl"].Value != null)
                                    Objeto.IdControl = (int)dtgMuestras.Rows[j].Cells["IdControl"].Value;
                                //Generic.ControlAClaseBase(ObjActualizar, "IdLaboratorio", cmbLaboratorio);
                                //this.dtgMuestras.Rows[j].Cells["IdLaboratorio"].Value = cmbLaboratorio.IdClaseActiva;
                                if (this.dtgMuestras.Rows[j].Cells["IdLaboratorio"].Value != null)
                                    Objeto.IdLaboratorio = (int)this.dtgMuestras.Rows[j].Cells["IdLaboratorio"].Value;
                                if (this.dtgMuestras.Rows[j].Cells["FechaAnalisis"].Value != null)
                                    Objeto.Fecha = Convert.ToDateTime(this.dtgMuestras.Rows[j].Cells["FechaAnalisis"].Value);
                                if (this.dtgMuestras.Rows[j].Cells["RctoCelular"].Value != null)
                                    Objeto.RctoCelular = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["RctoCelular"].Value);
                                else
                                    Objeto.RctoCelular = 0;
                                if (this.dtgMuestras.Rows[j].Cells["Grasa"].Value != null)
                                    Objeto.Grasa = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["Grasa"].Value);
                                else
                                    Objeto.Grasa = 0;
                                if (this.dtgMuestras.Rows[j].Cells["Urea"].Value != null)
                                    Objeto.Urea = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["Urea"].Value);
                                else
                                    Objeto.Urea = 0;
                                if (this.dtgMuestras.Rows[j].Cells["Proteina"].Value != null)
                                    Objeto.Proteina = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["Proteina"].Value);
                                else
                                    Objeto.Proteina = 0;
                                if (this.dtgMuestras.Rows[j].Cells["Lactosa"].Value != null)
                                    Objeto.Lactosa = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["Lactosa"].Value);
                                else
                                    Objeto.Lactosa = 0;
                                if (this.dtgMuestras.Rows[j].Cells["ExtractoSeco"].Value != null)
                                    Objeto.ExtractoSeco = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["ExtractoSeco"].Value);
                                else
                                    Objeto.ExtractoSeco = 0;
                                if (this.dtgMuestras.Rows[j].Cells["ExtrSecoMagro"].Value != null)
                                    Objeto.ExtractoSecoMagro = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["ExtrSecoMagro"].Value);
                                else
                                    Objeto.ExtractoSecoMagro = 0;
                                if (this.dtgMuestras.Rows[j].Cells["ExtrQuesero"].Value != null)
                                    Objeto.ExtractoQuesero = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["ExtrQuesero"].Value);
                                else
                                    Objeto.ExtractoQuesero = 0;
                                if (this.dtgMuestras.Rows[j].Cells["LinealPto"].Value != null)
                                    Objeto.LinealPto = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["LinealPto"].Value);
                                else
                                    Objeto.LinealPto = 0;
                                if (this.dtgMuestras.Rows[j].Cells["Germenes"].Value != null)
                                    Objeto.Germenes = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["Germenes"].Value);
                                else
                                    Objeto.Germenes = 0;
                                if (this.dtgMuestras.Rows[j].Cells["PtoCrioscopico"].Value != null)
                                    Objeto.PuntoCrioscopico = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["PtoCrioscopico"].Value);
                                else
                                    Objeto.PuntoCrioscopico = 0;
                                if (this.dtgMuestras.Rows[j].Cells["Ionhibidores"].Value != null)
                                    Objeto.Ionhibidores = Convert.ToBoolean(dtgMuestras.Rows[j].Cells["Ionhibidores"].Value);
                                else
                                    Objeto.Ionhibidores = false;
                                Objeto.Actualizar();
                                OperacionesCorrectas += 1;
                            }
                            else
                            {
                                if (CrearNuevaMuestraControl(j))
                                {
                                    Objeto = new MuestraControl();
                                    Objeto=(MuestraControl)Objeto.CargarContextoOperacion(TipoContexto.Insercion);
                                    if (this.dtgMuestras.Rows[j].Cells["IdControl"].Value != null)
                                        Objeto.IdControl = (int)dtgMuestras.Rows[j].Cells["IdControl"].Value;
                                    //Generic.ControlAClaseBase(ObjetoBase, "IdLaboratorio", cmbLaboratorio);
                                    //this.dtgMuestras.Rows[j].Cells["IdLaboratorio"].Value = cmbLaboratorio.IdClaseActiva;
                                    if (this.dtgMuestras.Rows[j].Cells["IdLaboratorio"].Value != null)
                                        Objeto.IdLaboratorio = (int)this.dtgMuestras.Rows[j].Cells["IdLaboratorio"].Value;
                                    if (this.dtgMuestras.Rows[j].Cells["FechaAnalisis"].Value != null)
                                        Objeto.Fecha = Convert.ToDateTime(this.dtgMuestras.Rows[j].Cells["FechaAnalisis"].Value);
                                    if (this.dtgMuestras.Rows[j].Cells["RctoCelular"].Value != null)
                                        Objeto.RctoCelular = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["RctoCelular"].Value);
                                    else
                                        Objeto.RctoCelular = 0;
                                    if (this.dtgMuestras.Rows[j].Cells["Grasa"].Value != null)
                                        Objeto.Grasa = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["Grasa"].Value);
                                    else
                                        Objeto.Grasa = 0;
                                    if (this.dtgMuestras.Rows[j].Cells["Urea"].Value != null)
                                        Objeto.Urea = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["Urea"].Value);
                                    else
                                        Objeto.Urea = 0;
                                    if (this.dtgMuestras.Rows[j].Cells["Proteina"].Value != null)
                                        Objeto.Proteina = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["Proteina"].Value);
                                    else
                                        Objeto.Proteina = 0;
                                    if (this.dtgMuestras.Rows[j].Cells["Lactosa"].Value != null)
                                        Objeto.Lactosa = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["Lactosa"].Value);
                                    else
                                        Objeto.Lactosa = 0;
                                    if (this.dtgMuestras.Rows[j].Cells["ExtractoSeco"].Value != null)
                                        Objeto.ExtractoSeco = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["ExtractoSeco"].Value);
                                    else
                                        Objeto.ExtractoSeco = 0;
                                    if (this.dtgMuestras.Rows[j].Cells["ExtrSecoMagro"].Value != null)
                                        Objeto.ExtractoSecoMagro = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["ExtrSecoMagro"].Value);
                                    else
                                        Objeto.ExtractoSecoMagro = 0;
                                    if (this.dtgMuestras.Rows[j].Cells["ExtrQuesero"].Value != null)
                                        Objeto.ExtractoQuesero = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["ExtrQuesero"].Value);
                                    else
                                        Objeto.ExtractoQuesero = 0;
                                    if (this.dtgMuestras.Rows[j].Cells["LinealPto"].Value != null)
                                        Objeto.LinealPto = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["LinealPto"].Value);
                                    else
                                        Objeto.LinealPto = 0;
                                    if (this.dtgMuestras.Rows[j].Cells["Germenes"].Value != null)
                                        Objeto.Germenes = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["Germenes"].Value);
                                    else
                                        Objeto.Germenes = 0;
                                    if (this.dtgMuestras.Rows[j].Cells["PtoCrioscopico"].Value != null)
                                        Objeto.PuntoCrioscopico = Convert.ToDecimal(dtgMuestras.Rows[j].Cells["PtoCrioscopico"].Value);
                                    else
                                        Objeto.PuntoCrioscopico = 0;
                                    if (this.dtgMuestras.Rows[j].Cells["Ionhibidores"].Value != null)
                                        Objeto.Ionhibidores = Convert.ToBoolean(dtgMuestras.Rows[j].Cells["Ionhibidores"].Value);
                                    else
                                        Objeto.Ionhibidores = false;
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
        /// Valida los datos introducidos por el usuario antes de guardarlos en la base de datos.
        /// </summary>
        /// <returns></returns>
        protected override bool Validar()
        {
            bool Rtno = true;
            this.ErrorProvider.Clear();
            
            //if (!Generic.ControlValorado(new Control[] { txtFechaAnalisis, cmbLaboratorio }, this.ErrorProvider, "Faltan datos requeridos"))
            //    Rtno = false;
            //if (!Generic.ControlDatosCorrectos( txtFechaAnalisis, this.ErrorProvider, "El dato requerido es de tipo fecha", typeof(System.DateTime), true))
            //    Rtno = false;
            int n = dtgMuestras.RowCount;
            int j = 0;
            for (j = 0; j < n; j++)
            {
                dtgMuestras.Rows[j].Cells["IdLaboratorio"].ErrorText = string.Empty;
                dtgMuestras.Rows[j].Cells["FechaAnalisis"].ErrorText = string.Empty;

                if (!Generic.DatosRequeridosGrid(dtgMuestras.Rows[j].Cells["IdLaboratorio"], "El valor es requerido"))
                    Rtno = false;
                if (!Generic.DatosRequeridosGrid(dtgMuestras.Rows[j].Cells["FechaAnalisis"], "El valor es requerido"))
                    Rtno = false;
                if (!Generic.DatosCorrectoGrid(dtgMuestras.Rows[j].Cells["FechaAnalisis"], "Este valor no es una fecha", typeof(System.DateTime)))
                    Rtno = false;
                if(dtgMuestras.Rows[j].Cells["RctoCelular"].Value!=null)
                    if (!Validacion.EsNumero(dtgMuestras.Rows[j].Cells["RctoCelular"].Value))
                    {
                        dtgMuestras.Rows[j].Cells["RctoCelular"].ErrorText = "No es un número";
                        Rtno = false;
                    }
                if (dtgMuestras.Rows[j].Cells["Grasa"].Value != null)
                    if (!Validacion.EsNumero(dtgMuestras.Rows[j].Cells["Grasa"].Value))
                    {
                        dtgMuestras.Rows[j].Cells["Grasa"].ErrorText = "No es un número";
                        Rtno = false;
                    }
                if (dtgMuestras.Rows[j].Cells["Urea"].Value != null)
                    if (!Validacion.EsNumero(dtgMuestras.Rows[j].Cells["Urea"].Value))
                    {
                        dtgMuestras.Rows[j].Cells["Urea"].ErrorText = "No es un número";
                        Rtno = false;
                    }
                if (dtgMuestras.Rows[j].Cells["Proteina"].Value != null)
                    if (!Validacion.EsNumero(dtgMuestras.Rows[j].Cells["Proteina"].Value))
                    {
                        dtgMuestras.Rows[j].Cells["Proteina"].ErrorText = "No es un número";
                        Rtno = false;
                    }
                if (dtgMuestras.Rows[j].Cells["Lactosa"].Value != null)
                    if (!Validacion.EsNumero(dtgMuestras.Rows[j].Cells["Lactosa"].Value))
                    {
                        dtgMuestras.Rows[j].Cells["Lactosa"].ErrorText = "No es un número";
                        Rtno = false;
                    }
                if (dtgMuestras.Rows[j].Cells["ExtractoSeco"].Value != null)
                    if (!Validacion.EsNumero(dtgMuestras.Rows[j].Cells["ExtractoSeco"].Value))
                    {
                        dtgMuestras.Rows[j].Cells["ExtractoSeco"].ErrorText = "No es un número";
                        Rtno = false;
                    }
                if (dtgMuestras.Rows[j].Cells["ExtrSecoMagro"].Value != null)
                    if (!Validacion.EsNumero(dtgMuestras.Rows[j].Cells["ExtrSecoMagro"].Value))
                    {
                        dtgMuestras.Rows[j].Cells["ExtrSecoMagro"].ErrorText = "No es un número";
                        Rtno = false;
                    }
                if (dtgMuestras.Rows[j].Cells["ExtrQuesero"].Value != null)
                    if (!Validacion.EsNumero(dtgMuestras.Rows[j].Cells["ExtrQuesero"].Value))
                    {
                        dtgMuestras.Rows[j].Cells["ExtrQuesero"].ErrorText = "No es un número";
                        Rtno = false;
                    }
                if (dtgMuestras.Rows[j].Cells["LinealPto"].Value != null)
                    if (!Validacion.EsNumero(dtgMuestras.Rows[j].Cells["LinealPto"].Value))
                    {
                        dtgMuestras.Rows[j].Cells["LinealPto"].ErrorText = "No es un número";
                        Rtno = false;
                    }
                if (dtgMuestras.Rows[j].Cells["Germenes"].Value != null)
                    if (!Validacion.EsNumero(dtgMuestras.Rows[j].Cells["Germenes"].Value))
                    {
                        dtgMuestras.Rows[j].Cells["Germenes"].ErrorText = "No es un número";
                        Rtno = false;
                    }
                if (dtgMuestras.Rows[j].Cells["PtoCrioscopico"].Value != null)
                    if (!Validacion.EsNumero(dtgMuestras.Rows[j].Cells["PtoCrioscopico"].Value))
                    {
                        dtgMuestras.Rows[j].Cells["PtoCrioscopico"].ErrorText = "No es un número";
                        Rtno = false;
                    }
            }
            return Rtno;
        }

        /// <summary>
        /// Se utiliza para comprobar si realmente se quiere crear una nueva Muestra o no ya que a todos
        /// los controles lecheros que se muestran en el DataGrid se le asigna por defecto una fecha de 
        /// analisis y un laboratorio, y si no se introducen más datos se entiende que para ese control
        /// no tenemos muestra.
        /// </summary>
        /// <param name="nfila"></param>
        /// <returns></returns>
        private bool CrearNuevaMuestraControl(int nfila)
        {
            Boolean Rtno = false;

            if (dtgMuestras.Rows[nfila].Cells["RctoCelular"].Value != null)
                Rtno = true;
            if (dtgMuestras.Rows[nfila].Cells["Grasa"].Value != null)
                Rtno = true;
            if (dtgMuestras.Rows[nfila].Cells["Urea"].Value != null)
                Rtno = true;
            if (dtgMuestras.Rows[nfila].Cells["Proteina"].Value != null)
                Rtno = true;
            if (dtgMuestras.Rows[nfila].Cells["Lactosa"].Value != null)
                Rtno = true;
            if (dtgMuestras.Rows[nfila].Cells["ExtractoSeco"].Value != null)
                Rtno = true;
            if (dtgMuestras.Rows[nfila].Cells["ExtrSecoMagro"].Value != null)
                Rtno = true;
            if (dtgMuestras.Rows[nfila].Cells["ExtrQuesero"].Value != null)
                Rtno = true;
            if (dtgMuestras.Rows[nfila].Cells["LinealPto"].Value != null)
                Rtno = true;
            if (dtgMuestras.Rows[nfila].Cells["Germenes"].Value != null)
                Rtno = true;
            if (dtgMuestras.Rows[nfila].Cells["PtoCrioscopico"].Value != null)
                Rtno = true;
            if (dtgMuestras.Rows[nfila].Cells["Ionhibidores"].Value != null)
                Rtno = true;

            return Rtno;

        }

        /// <summary>
        /// Elimina las Muestras seleccionadas por el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbEliminarMuestra_Click(object sender, EventArgs e)
        {
            this.IniciarContextoOperacion();
            try
            {
                if (dtgMuestras.SelectedRows.Count > 0)
                {
                    int OperacionesCorrectas = 0;
                    int OperacionesIncorrectas = 0;
                    if (DialogResult.Yes == Generic.Aviso("Va a eliminar los controles seleccionados ¿Está seguro que desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        string mensajeError = string.Empty;

                        foreach (DataGridViewRow item in dtgMuestras.SelectedRows)
                        {
                            try
                            {
                                if (dtgMuestras.Rows[item.Index].Cells["IdMuestra"].Value != null)
                                {
                                    MuestraControl ObjetoEliminar = MuestraControl.Buscar((int)dtgMuestras.Rows[item.Index].Cells["IdMuestra"].Value);
                                    if (ObjetoEliminar != null)
                                        ObjetoEliminar.Eliminar();
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

        #region GRID

        /// <summary>
        /// Busca los controles por fecha de control y los muestra en el DataGrid.
        /// </summary>
        protected override void Buscar()
        {
            try
            {
                if (ValidarBusqueda())
                {
                dtgMuestras.Rows.Clear();
                lblBarraEstado.Text = "Buscando...";
                List<Raza> lstRazasExplotacion = Raza.Buscar(string.Empty, (int)cmbEspecie.SelectedValue);
                foreach (Raza raza in lstRazasExplotacion)
                {
                    List<Animal> lstAnimalExplotacionPorEspecie = Animal.Buscar(null, raza.Id, null, null, null, Configuracion.Explotacion.Id, string.Empty, string.Empty, string.Empty, string.Empty, null, null, null, null, null,null);


                    foreach (Animal animal in lstAnimalExplotacionPorEspecie)
                    {
                        Lactacion lactacion = Lactacion.BuscarLactacionAbierta(animal.Id);


                        int? idControl = null;
                        int? idMuestra = null;
                        int? idLaboratorio = null;
                        DateTime? fechaAnalisis = null;
                        decimal? rctoCelular = null;
                        decimal? grasa = null;
                        decimal? urea = null;
                        decimal? proteina = null;
                        decimal? lactosa = null;
                        decimal? extractoSeco = null;
                        decimal? extractoSecoMagro = null;
                        decimal? extratoQuesero = null;
                        decimal? linealPto = null;
                        decimal? germenes = null;
                        decimal? ptoCrioscopico = null;
                        Boolean? ionhibidores = null;

                        if (lactacion != null && lactacion.lstControlesLeche.Count>0 && Generic.ControlADatetime(txtFechaControl) >= lactacion.PrimerControl().Fecha)
                        {
                            ControlLeche control = null;
                            MuestraControl muestra = null;
                            foreach (ControlLeche C in lactacion.lstControlesLeche)
                                if (C.Fecha == Generic.ControlADatetime(txtFechaControl))
                                {
                                    control = C;
                                    break;
                                }


                            if (control != null)
                            {
                                idControl = control.Id;                                
                                if (control.lstMuestrasControl.Count == 1)
                                    muestra = (MuestraControl)control.lstMuestrasControl[0];
                                if (muestra != null)
                                {
                                    idMuestra = muestra.Id;
                                    fechaAnalisis = muestra.Fecha;
                                    if (muestra.RctoCelular != 0)
                                        rctoCelular = muestra.RctoCelular;
                                    if (muestra.Grasa != 0)
                                        grasa = muestra.Grasa;
                                    if (muestra.Urea != 0)
                                        urea = muestra.Urea;
                                    if (muestra.Proteina != 0)
                                        proteina = muestra.Proteina;
                                    if (muestra.Lactosa != 0)
                                        lactosa = muestra.Lactosa;
                                    if (muestra.ExtractoSeco != 0)
                                        extractoSeco = muestra.ExtractoSeco;
                                    if (muestra.ExtractoSecoMagro != 0)
                                        extractoSecoMagro = muestra.ExtractoSecoMagro;
                                    if (muestra.ExtractoQuesero != 0)
                                        extratoQuesero = muestra.ExtractoQuesero;
                                    if (muestra.LinealPto != 0)
                                        linealPto = muestra.LinealPto;
                                    if (muestra.Germenes != 0)
                                        germenes = muestra.Germenes;
                                    if (muestra.PuntoCrioscopico != 0)
                                        ptoCrioscopico = muestra.PuntoCrioscopico;
                                    if (muestra.Ionhibidores != null)
                                        ionhibidores = muestra.Ionhibidores;
                                    if (muestra.IdLaboratorio != 0)
                                        idLaboratorio = muestra.IdLaboratorio;
                                }
                                else
                                {
                                    //Valores por defecto, si todavia no ha sido creada la muestra.
                                    if (Generic.ControlADatetimeNullable(txtFechaAnalisis)!=null)                                    
                                        fechaAnalisis = Generic.ControlADatetime(txtFechaAnalisis);
                                    if (Generic.ControlAIntNullable(cmbLaboratorio)!=null)                                    
                                        idLaboratorio = Generic.ControlAInt(cmbLaboratorio);
                                        
                                    

                                    

                                }
                                this.dtgMuestras.Rows.Add(animal.Id, idMuestra, idControl, animal.Nombre, animal.Identificador,idLaboratorio,fechaAnalisis, rctoCelular, grasa, urea, proteina, lactosa, extractoSeco, extractoSecoMagro, extratoQuesero, linealPto, germenes, ptoCrioscopico, ionhibidores);
                            }
                            control = null;
                            muestra = null;
                        }

                        lactacion = null;

                    }
                }
                this.lblBarraEstado.Text = "Búsqueda finalizada. (Registros: " + dtgMuestras.Rows.Count.ToString() + ") ";
            }
        }
            catch (Exception ex)
            {
                Generic.AvisoError("Error en la busqueda.\rMensaje: " + ex.Message);
            }
               

        }
        /// <summary>
        /// Valida los datos requeridos para la busqueda antes de realizarla.
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

        #region  CARGAS COMUNES
        /// <summary>
        /// Carga por defecto las fechas de analisis y de control con la fecha actual y el combo de especie.
        /// </summary>
        protected override void CargarValoresDefecto()
        {
            Generic.DatetimeAControl(txtFechaControl, DateTime.Now.Date);
            Generic.DatetimeAControl(txtFechaAnalisis, DateTime.Now.Date);         
        }
        /// <summary>
        /// Carga el combo de especie del formulario.
        /// </summary>
        protected override void CargarCombos()
        {
            cmbLaboratorio.CargarCombo();

            this.CargarCombo(this.cmbEspecie, "Descripcion", Configuracion.Explotacion.lstEspecies, true);
       
        }
        #endregion

        #region FUNCIONAMIENTO GENERAL

        
        /// <summary>
        /// Se captura este evento para cada vez que se seleccione una fila lanza la función CargarDatos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgMuestras_SelectionChanged(object sender, EventArgs e)
        {
            //if (dtgMuestras.Rows.Count > 0)
            //{
            //    if (dtgMuestras.SelectedRows.Count == 1)
            //        CargarDatos();
            //}
        }


        private void txtFechaAnalisis_ValueChanged(object sender, GEXVOC.Core.Controles.ctlFechaEventArgs e)
        {
            int n = dtgMuestras.RowCount;
            int j = 0;
            for (j = 0; j < n; j++)
            {
                if (e.Value != null)
                    this.dtgMuestras.Rows[j].Cells["FechaAnalisis"].Value = e.Value;
                else
                    this.dtgMuestras.Rows[j].Cells["FechaAnalisis"].Value = string.Empty;
            }
        }

        #endregion

        #region COMBOS
                
        private void cmbLaboratorio_SelectedValueChanged(object sender, EventArgs e)
        {
            int n = dtgMuestras.RowCount;
            int j = 0;
            for (j = 0; j < n; j++)
            {
                int? idLaboratorio = Generic.ControlAIntNullable(cmbLaboratorio);

                if (idLaboratorio.HasValue)
                    this.dtgMuestras.Rows[j].Cells["IdLaboratorio"].Value = idLaboratorio;

            }
        }

        private void cmbLaboratorio_CargarContenido(object sender, EventArgs e)
        {
            

            this.IdLaboratorio.ValueMember = "Id";
            this.IdLaboratorio.DisplayMember = "Nombre";
            Laboratorio laboratorionulo = new Laboratorio();
            List<Laboratorio> listatotal = Laboratorio.Buscar();
            listatotal.Add(laboratorionulo);
            this.IdLaboratorio.DataSource = listatotal;


            this.CargarCombo(this.cmbLaboratorio, "Nombre", Laboratorio.Buscar());

        }

        private void cmbLaboratorio_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
        {

            Laboratorio ObjetoBase = new Laboratorio();
            EditLaboratorios editLaboratorio = new EditLaboratorios(Modo.Guardar, ObjetoBase);
            editLaboratorio.Nombre = e.TextoCrear;

            CrearNuevoElementoCombo(editLaboratorio, sender);
        }

        #endregion

        private void txtFechaControl_ValueChanged(object sender, GEXVOC.Core.Controles.ctlFechaEventArgs e)
        {
            txtFechaAnalisis.Value = txtFechaControl.Value;
        }

    }
}
   //private void txtFechaAnalisis_TextChanged(object sender, EventArgs e)
        //{
        //    int n = dtgMuestras.RowCount;
        //    int j = 0;
        //    for (j = 0; j < n; j++)
        //    {
        //        if (txtFechaAnalisis.Text != string.Empty)
        //            this.dtgMuestras.Rows[j].Cells["FechaAnalisis"].Value = txtFechaAnalisis.Text;
        //        else
        //            this.dtgMuestras.Rows[j].Cells["FechaAnalisis"].Value = string.Empty;
        //    }
        //}

        


      
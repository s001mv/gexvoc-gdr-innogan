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
    public partial class EditDestete : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditDestete()
        {
            InitializeComponent();
        }
        public EditDestete(Modo modo)            
        {
            InitializeComponent();
            ModoActual = modo;
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Animal ObjetoBase { get { return (Animal)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
     
        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Se ha tenido que sobreescribir guardar, para dar la funcionalidad de inserción en lotes
        /// una característica importante que deriba de esto es que si existe mas de un animal en la selección, 
        /// el peso proporcionado se divide entre el número total de animales.
        /// PE: peso 3 animales, indico peso 3,30, se daran de alta 3 registros, uno por cada animal, en los que el peso será 1,10 
        /// </summary>
        protected override void Guardar()
        {
            if (ModoActual == Modo.GuardarMultiple)
            {
                if (ValidarControles())
                {
                   

                    string mensajeError = string.Empty;
                    int OperacionesCorrectas = 0;
                    int OperacionesIncorrectas = 0;

                    foreach (Animal item in cmbAnimal.Items)
                    {
                        try
                        {
                            IniciarContextoOperacion();
                            Animal animal = item;
                            if (animal.FechaDestete.HasValue)
                                throw new LogicException("No es posible asignar la fecha de destete al animal: " + item.Nombre + " porque ya tiene una fecha de destete asignada. (" + item.FechaDestete.Value.ToShortDateString() + ")");

                            animal = (Animal)animal.CargarContextoOperacion(TipoContexto.Modificacion);
                            animal.FechaDestete = Generic.ControlADatetimeNullable(txtFecha);

                            animal.Actualizar();
                            OperacionesCorrectas += 1;
                        }
                        catch (Exception ex)
                        {
                            OperacionesIncorrectas += 1;
                            mensajeError += ex.Message + "\r";
                        }
                        finally { FinalizarContextoOperacion(); }
                    }
                    

                    if (mensajeError != string.Empty)
                        Generic.AvisoAdvertencia("Se han producido errores en un total de (" + ((int)OperacionesCorrectas + OperacionesIncorrectas) + ") Operaciones => " +
                                                "(" + OperacionesCorrectas + ") Correctas y (" + OperacionesIncorrectas + ") Incorrectas.\r" +
                                                "Resumen e Información adicional: \r" +
                                                  mensajeError);
                    this.Close();
                }
            }        


            //base.Guardar();
        }

        protected override bool Validar()
        {
            bool Rtno = true;
            if (!Generic.ControlValorado(cmbAnimal, this.ErrorProvider)) Rtno = false;
            if (!Generic.ControlDatosCorrectos(txtFecha, this.ErrorProvider, typeof(DateTime), true)) Rtno = false;
            return Rtno;
        }
        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarAnimal_Click(object sender, EventArgs e)
            {
                if (ModoActual == Modo.GuardarMultiple)
                {
                    SelectorAnimales frmSelectorAnimales = new SelectorAnimales(Modo.Consultar, (List<Animal>)this.cmbAnimal.DataSource);
                    this.LanzarFormulario(frmSelectorAnimales);


                    if (frmSelectorAnimales.LstAnimalesSeleccionadosRtno != null)
                    {
                        this.cmbAnimal.DataSource = frmSelectorAnimales.LstAnimalesSeleccionadosRtno;
                        this.cmbAnimal.Text = "(" + frmSelectorAnimales.LstAnimalesSeleccionadosRtno.Count + ") Elementos en selección";
                    }
                }
            }


        #endregion
    }
}
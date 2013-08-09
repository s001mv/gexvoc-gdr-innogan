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
    public partial class EditPartosMultiples : GEXVOC.UI.GenericEdit
    {
        #region CONSTUCTORES
            /// <summary>
            /// Constuctor.
            /// </summary>
            public EditPartosMultiples()
            {
                InitializeComponent();
            }

        #endregion
        
        #region VARIABLES Y OBJETOS PRINCIPALES
            /// <summary>
            /// Lista principal que almacena objetos del tipo PartoMultiple, que 
            /// son actualizados directamente desde el grid principal.        
            /// Se rellena cuando pulsamos buscar, y se almacena cuando pulsamos guardar.
            /// Cuando se pulsa guardar, todos los elementos contenidos se almacenarán en la Base de Datos como
            /// elementos del tipo Parto.
            /// </summary>
            List<PartoMultiple> lstPartosMultiples = null;
        #endregion       

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            /// <summary>
            /// Comprueba la fila actual y nos indica si está apta para convertirse en un parto o no.
            /// A) Comprueba que el intervalo de la ultima inseminacion o cubricion del animal y la fecha del parto, se encuentre
            /// dentro de los valores especificos de configuración.
            /// B) Comprueba también que el número de animales que refleja el tipo de parto, sea acorde con el número de animales 
            /// especificados en la suma Vivos + Muertos.
            /// Ej: Parto Gemelos Macho-Hembra: La suma Vivos + Muertos debe ser 2, de lo contrario se informará del error.
            /// Para comprobar esta información tenemos el campo TipoParto.Crias, que nos especifica si el tipo de parto tiene asociado
            /// un número específico de crias  o no.
            /// Nota: Si el tipo de parto no tiene especificado el campo Crias, la comprobación B se omite.
            /// </summary>
            /// <param name="item"></param>
            /// <returns></returns>
            private bool ValidarFila(DataGridViewRow item)
            {
                bool rtno = true;
                foreach (DataGridViewCell celda in item.Cells)            
                    celda.ErrorText = string.Empty;//Quito los errores en todas las celdas.
                
                ////Compruebo que la fecha del parto sea correcta.
                PartoMultiple partoMultiple = (PartoMultiple)item.DataBoundItem;
           
                if (partoMultiple!=null)
                {
                    //Comprobar datos requeridos
                    if (partoMultiple.FechaParto==null)
                    {
                        dtgPartosMultiples.Rows[item.Index].Cells[FechaGrid.Index].ErrorText = "La fecha del parto es requerida.";
                        rtno = false;
                    }

                    //Comprobar que el parto se encuentre entre los dias minimo y maximo de gestacion
                    if (partoMultiple.FechaParto < ((DateTime)partoMultiple.UltimaFechaInseminacion_Cubricion).AddDays(partoMultiple.MinimoGestacion)
                          || partoMultiple.FechaParto > ((DateTime)partoMultiple.UltimaFechaInseminacion_Cubricion).AddDays(partoMultiple.MaximoGestacion))
                    {
                        dtgPartosMultiples.Rows[item.Index].Cells[FechaGrid.Index].ErrorText = "La fecha de parto para la hembra: " + partoMultiple.DescMadre + "  no es válida. No se ha respetado el período de gestación establecido.\r"
                            + "La fecha del parto debe estar comprendida entre: " + ((DateTime)partoMultiple.UltimaFechaInseminacion_Cubricion).AddDays(partoMultiple.MinimoGestacion).ToShortDateString()
                            + " y " + ((DateTime)partoMultiple.UltimaFechaInseminacion_Cubricion).AddDays(partoMultiple.MaximoGestacion).ToShortDateString();

                        rtno = false;

                    }

                    //Compruebo que el número de animales se corresponde con el tipo de parto.
                    if (partoMultiple.TipoParto != null && partoMultiple.TipoParto.Crias != null)
                    {
                        if (partoMultiple.TipoParto.Crias != ((partoMultiple.Vivos ?? 0) + (partoMultiple.Muertos ?? 0)))
                        {
                            dtgPartosMultiples.Rows[item.Index].Cells[cmbTipoPartoGrid.Index].ErrorText = "La suma de Vivos y Muertos tiene que producir un total de: " +
                                ((int)partoMultiple.TipoParto.Crias).ToString() + " crías, como corresponde al Tipo de Parto: " + partoMultiple.TipoParto.Descripcion;
                            rtno = false;
                        }
                    }
                }     
                return rtno;
            }

            /// <summary>
            /// Recoge todos los objetos del tipo PartoMultiple que se modifican desde el grid principal, y uno a uno los va 
            /// dando de alta como partos.
            /// Nota: En este proceso no se tendrán en cuenta los datos contenidos en Animales Descartados.
            /// </summary>
            protected override void Guardar()
            {

                if (lstPartosMultiples != null && lstPartosMultiples.Count > 0)
                {
                    //Si el grid esta en modo edición, confirmamos la modificación.
                    if (dtgPartosMultiples.IsCurrentCellInEditMode)
                        dtgPartosMultiples.EndEdit();

                    //Comprobamos si todos los objetos del tipo PartoMultiple contienen  datos correctos.
                    if (ValidarGuardar())
                    {
                      
                        this.IniciarContextoOperacion();
                        try
                        {
                            IniciarEspera();
                            pantallaEspera.NumeroPasos = lstPartosMultiples.Count;

                            int OperacionesCorrectas = 0;
                            int OperacionesIncorrectas = 0;
                            string mensajeError = string.Empty;

                            foreach (PartoMultiple item in lstPartosMultiples)
                            {
                                try
                                {
                                    Parto parto = new Parto();
                                    parto.IdHembra = item.animal.Id;
                                    parto.IdFacilidad = (int)item.IdFacilidad;
                                    parto.IdTipo = (int)item.IdTipoParto;
                                    parto.Fecha = (DateTime)item.FechaParto;
                                    parto.Vivos = item.Vivos;
                                    parto.Muertos = item.Muertos;
                                    parto.Insertar();

                                    OperacionesCorrectas += 1;
                                }
                                catch (Exception ex)
                                {
                                    mensajeError += ex.Message + "\r";
                                    OperacionesIncorrectas += 1;
                                }
                                pantallaEspera.Avanzar();
                            }

                            FinalizarEspera();

                            if (mensajeError != string.Empty)
                            {
                                Generic.AvisoAdvertencia("Se han producido errores en un total de (" + ((int)OperacionesCorrectas + OperacionesIncorrectas) + ") Operaciones => " +
                                                     "(" + OperacionesCorrectas + ") Correctas y (" + OperacionesIncorrectas + ") Incorrectas.\r" +
                                                     "Resumen e Información adicional: \r" +
                                                       mensajeError);
                            }
                            Limpiar();

                        }
                        catch (Exception ex)
                        {
                            FinalizarEspera();
                            Generic.AvisoError("Error eliminando.\rMensaje: " + ex.Message);
                          
                        }
                        finally
                        { 
                            this.FinalizarContextoOperacion();                        
                           
                        }
                    }

                }
                else                
                    Generic.AvisoInformation("El formulario debe tener datos antes de proceder a las características de guardado.");
                
                
            }

            protected override void Limpiar()
            {
                lstPartosMultiples = null;    
                base.Limpiar();
            }

            /// <summary>
            /// Comrpueba que se los datos mínimos requeridos en el formulario se encuentren valorados y sean del tipo correcto
            /// antes de poder hacer la búsqueda.
            /// </summary>
            /// <returns></returns>
            protected override bool Validar()
            {

                bool rtno = true;
                if (!Generic.ControlDatosCorrectos(txtFechaParto, ErrorProvider, typeof(DateTime), true))
                    rtno = false;
                if (!Generic.ControlValorado(cmbLote, ErrorProvider))
                    rtno = false;
                if (!Generic.ControlValorado(cmbTipoParto, ErrorProvider))
                    rtno = false;
                if (!Generic.ControlValorado(cmbFacilidad, ErrorProvider))
                    rtno = false;

                return rtno;
            }

            /// <summary>
            /// Valida que todos los objetos contenidos en la lista principal del tipo PartoMultiple, contengan datos correctos.
            /// Se utiliza antes de guardar.
            /// </summary>
            /// <returns></returns>
            bool ValidarGuardar ()
            {
                bool rtno = true;
                foreach (DataGridViewRow item in dtgPartosMultiples.Rows)
                    if (!ValidarFila(item)) rtno = false;
                return rtno;
            }

            void RefrescarGrid()
            {
                ValidarGuardar();
                ActualizarEstadisticas();
                dtgPartosMultiples.Refresh();
            }

        #endregion

        #region CARGAS COMUNES
            /// <summary>
            /// Carga los combos del formulario, tanto los simples como los de dentro del grid.
            /// </summary>
            protected override void CargarCombos()
        {

            //cargando = true;
            try
            {
             
                this.CargarCombo(this.cmbTipoParto, TipoParto.Buscar());
                this.CargarCombo(this.cmbFacilidad, Facilidad.Buscar());

                this.cmbTipoPartoGrid.ValueMember = "Id";
                this.cmbTipoPartoGrid.DisplayMember = "Descripcion";
                this.cmbTipoPartoGrid.DataSource = TipoParto.Buscar();

                this.cmbFacilidadGrid.ValueMember = "Id";
                this.cmbFacilidadGrid.DisplayMember = "Descripcion";
                this.cmbFacilidadGrid.DataSource = Facilidad.Buscar();




            }
            catch (Exception) { }
            finally
            { //cargando = false; 
            }


            base.CargarCombos();
        }

            /// <summary>
            /// Añade un animal a la lista de animales inferior, animales descartados,
            /// lista que implica que no se seguirá trabajando con dicho animal.
            /// </summary>
            /// <param name="Nombre"></param>
            /// <param name="Motivo"></param>
            void AgregarAnimalDescartado(string Nombre, string Motivo)
            {
                ListViewItem elemento = new ListViewItem();
                elemento.Text = Nombre.ToUpper();
                elemento.SubItems.Add(Motivo.ToUpper());
                lstAnimalesDescartados.Items.Add(elemento);
                lstAnimalesDescartados.Refresh();
                Application.DoEvents();
            }


            //PantallaEspera pantalla = new PantallaEspera();
            /// <summary>
            /// Valida los controles del formulario y ejecuta la búsqueda de animales del lote espeficicado
            /// Hay 2 destinos diferenciados de esta carga:
            /// - Grid de Partos: Aplica los criterios necesarios para saber si el animal es susceptible de tener un parto, el animal pertenecerá a este grupo si se validan los criterios.
            /// - Animales descartados: Si el animal no cumple con los criterios anteriores pasa a una lista de información, no se volverán a utilizar estos datos.
            /// </summary>
            protected override void Buscar()
            {
                if (ValidarControles())
                {
                   
                        if (cmbLote.ClaseActiva != null)
                        {
                            try
                            {

                                
                                IniciarEspera();
                         
                                                        
                            //Limpio los controles que pueden tener datos si ejecuto varias busquedas
                            lstAnimalesDescartados.Items.Clear();
                            dtgPartosMultiples.DataSource = null;
                            Application.DoEvents();

                            //inicio la busqueda...
                            lstPartosMultiples = new List<PartoMultiple>();
                            List<Animal> lstAnimales = ((LoteAnimal)cmbLote.ClaseActiva).lstAnimales;
                            pantallaEspera.NumeroPasos = lstAnimales.Count;                            

                            foreach (Animal item in lstAnimales)
                            {
                                if (item.Sexo == char.Parse("H"))//Solo introduzco hembras
                                {
                                    bool cubricionAbierta = false;
                                    DateTime? UFInseminacionCubricion = item.UltimaFechaInseminacion_Cubricion(item.Id, ref cubricionAbierta);
                                    DateTime? UFPartoAborto = item.UltimaFechaParto_Aborto(item.Id);
                                    if (UFInseminacionCubricion != null && !cubricionAbierta)//La hembra debe estar inseminada o cubierta
                                    {

                                        if (UFPartoAborto == null || UFInseminacionCubricion > UFPartoAborto)
                                        //Si la hembra tiene algun parto o aborto, la fecha de la ultima inseminacion
                                        //Debe ser mayor que la del parto o aborto, de lo contrario significaría que no ha sido inseminada o cubierta desde 
                                        //el ultimo parto o aborto.                                                           
                                        {//Cumplimos todas las condiciones, creamos un objeto del tipo PartoMultiple para añadir al grid.                                    
                                            PartoMultiple partomultiple = new PartoMultiple();
                                            partomultiple.animal = item;
                                            partomultiple.FechaParto = Generic.ControlADatetimeNullable(txtFechaParto);
                                            partomultiple.TipoParto = (TipoParto)cmbTipoParto.SelectedItem;
                                            partomultiple.IdFacilidad = Generic.ControlAIntNullable(cmbFacilidad);
                                            partomultiple.UltimaFechaParto_Aborto = UFPartoAborto;
                                            partomultiple.UltimaFechaInseminacion_Cubricion = UFInseminacionCubricion;
                                            partomultiple.TipoInsCub.ToString();
                                            lstPartosMultiples.Add(partomultiple);
                                        }
                                        else
                                            AgregarAnimalDescartado(item.Nombre, "La hembra no ha sido inseminada o cubierta desde el último parto o aborto.");

                                    }
                                    else
                                    {
                                        if (UFInseminacionCubricion == null)
                                            AgregarAnimalDescartado(item.Nombre, "La hembra no ha sido inseminada o cubierta.");
                                        if (cubricionAbierta)
                                            AgregarAnimalDescartado(item.Nombre, "La hembra se encuentra en una cubrición abierta.");
                                    }
                                }
                                else
                                    AgregarAnimalDescartado(item.Nombre, "No es una hembra.");
                                                                
                                pantallaEspera.Avanzar();
                            }

                            dtgPartosMultiples.DataSource = lstPartosMultiples;
                           
                            ////ActualizarEstadisticas();//Actualizo la información de los controles del grupo estadisticas.
                            ////ValidarGuardar();//Me interesa que aparezcan los errores en las celdas si los hay.
                            RefrescarGrid();

                            }
                            catch (Exception ex)
                            {

                                Traza.RegistrarError(ex);
                                Generic.AvisoError("Se ha producido un error cargando los elementos.\n" +
                                                   "Detalles: " + ex.Message); 
                                //throw;
                            }
                            finally
                            {
                                FinalizarEspera();                            
                            }

                            //Application.DoEvents();
                            //pantalla.Dispose();
                        }
                       // this.Enabled = true;
                    }
            }
        #endregion

        #region FUNCIONAMIENTO GENERAL
            /// <summary>
            /// Cuando hay cualquier actualización en una celda, actualizamos las estadísticas y a demas recargamos la fila completa, ya 
            /// que un cambio en una celda puede probocar que otra celda de la misma fila cambie tambien.
            /// Por ultimo validamos la fila, poniendo información de los errores si es necesario, en cada celda individualmente.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void dtgAsignaciones_CellValueChanged(object sender, DataGridViewCellEventArgs e)
                {
                    if (e.RowIndex == -1 || e.ColumnIndex == -1)
                        return;

                    ActualizarEstadisticas();
                    dtgPartosMultiples.InvalidateRow(e.RowIndex);
                    ValidarFila(dtgPartosMultiples.Rows[e.RowIndex]);
                }

            /// <summary>
            /// Actualiza los controles del grupo Estadísticas.
            /// Toma como base los datos cargados en el grid.
            /// </summary>
            private void ActualizarEstadisticas()
            {
                if (lstPartosMultiples!=null)
                {
                    int TotalVivos = 0;
                    int TotalMuertos = 0;
                    foreach (PartoMultiple item in lstPartosMultiples)
                    {
                        TotalVivos += item.Vivos ?? 0;
                        TotalMuertos += item.Muertos ?? 0;
                    }

                    Generic.IntAControl(txtVivos, TotalVivos);
                    Generic.IntAControl(txtMuertos, TotalMuertos);                    
                }                
            }

            /// <summary>
            /// Funcionamiento general del control Buscar Objeto.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnbuscarLote_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindLoteAnimal(Modo.Consultar, this.cmbLote));
            }

            /// <summary>
            /// Evento capturado para que no se muestren los errores de datos al usuario.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void dtgAsignaciones_DataError(object sender, DataGridViewDataErrorEventArgs e) { }


            private void btnExtenderFechaGrid_Click(object sender, EventArgs e)
            {
                ErrorProvider.Clear();
                if (Generic.ControlDatosCorrectos(txtFechaParto, this.ErrorProvider, typeof(DateTime), true) && lstPartosMultiples != null)
                {
                    foreach (PartoMultiple item in lstPartosMultiples)
                        item.FechaParto = Generic.ControlADatetimeNullable(txtFechaParto);
                }
                ValidarGuardar();
                dtgPartosMultiples.Refresh();
                RefrescarGrid();
            }

            private void btnExtenderTipoPartoGrid_Click(object sender, EventArgs e)
            {
                if (cmbTipoParto.SelectedItem != null && lstPartosMultiples != null)
                {
                    foreach (PartoMultiple item in lstPartosMultiples)
                        item.TipoParto = (TipoParto)cmbTipoParto.SelectedItem;


                }
                RefrescarGrid();
            }

            private void btnExtenderFacilidadGrid_Click(object sender, EventArgs e)
            {
                if (cmbFacilidad.SelectedItem != null && lstPartosMultiples != null)
                {
                    foreach (PartoMultiple item in lstPartosMultiples)
                        item.IdFacilidad = Generic.ControlAIntNullable(cmbFacilidad);
                }
                RefrescarGrid();
            }



            private void tsmDescartar_Click(object sender, EventArgs e)
            {
                if (!(dtgPartosMultiples.SelectedRows == null || dtgPartosMultiples.SelectedRows.Count == 0))
                {
                    List<PartoMultiple> lstPartoDescartar = new List<PartoMultiple>();


                    foreach (DataGridViewRow item in dtgPartosMultiples.SelectedRows)
                        lstPartoDescartar.Add((PartoMultiple)item.DataBoundItem);

                    foreach (PartoMultiple item in lstPartoDescartar)
                    {
                        this.AgregarAnimalDescartado(item.DescMadre, "Descartado por el usuario");
                        lstPartosMultiples.Remove(item);
                    }


                    Application.DoEvents();

                    dtgPartosMultiples.DataSource = null;
                    dtgPartosMultiples.DataSource = lstPartosMultiples;

                    RefrescarGrid();
                }

                //foreach (Animal item in lst)
                //{

                //}
            }

            private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
            {
                tsmDescartar.Enabled = !(dtgPartosMultiples.SelectedRows == null || dtgPartosMultiples.SelectedRows.Count == 0);
            }

       
        #endregion

    }
}

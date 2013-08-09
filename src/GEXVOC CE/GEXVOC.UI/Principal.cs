using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Collections;



namespace GEXVOC.UI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        static bool buttonPress;
        /// <summary>
        /// Contructor personalizado.
        /// </summary>
        /// <param name="version">Versión de la aplicación.</param>
        public Principal(string version) : this()
        {
            this.Text += version;
        }

        /// <summary>
        /// Especifica si el formulario es el principal.
        /// </summary>
        /// <param name="nombre">Nombre del formulario a comprobar.</param>
        /// <returns>Naturaleza del formulario.</returns>
        protected bool EsPrincipal(string nombre)
        {
            return this.Name == "Principal";
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if (EsPrincipal(this.Name))
                imgLogo.Visible = true;              
        }
        private void Principal_Closing(object sender, CancelEventArgs e)
        {
            if (EsPrincipal(this.Name))
                e.Cancel = true;
        }
        private void miSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region acciones
        private void Animales_Click(object sender, EventArgs e)
        {            
            Program.MostrarCursorEspera();
            if (Verificar_BD())
            {
                if (Verificar_Explo())
                {
                    Animal mForm = (Animal)FormFactory.Obtener(Formulario.Animal);
                    mForm.RefrescarPantalla("todos");
                    Program.OcultarCursorEspera();
                    mForm.Show();                 
                }
                else
                {
                    MessageBox.Show("Seleccione Primero una explotacion");
                    Explotaciones mForm = (Explotaciones)FormFactory.Obtener(Formulario.Explotaciones);
                    mForm.Activate();
                    mForm.Refrescar_Pantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();
                }
            }
            else
            {
                Program.OcultarCursorEspera();
                MessageBox.Show("La base de datos no existe, creela");
                Sincronizar mForm = (Sincronizar)FormFactory.Obtener(Formulario.Sincronizar);
                mForm.Show();

            }
        } //OK verificando BD y explo
        private void Inseminaciones_Click(object sender, EventArgs e)
        {
            Program.MostrarCursorEspera();
            if (Verificar_BD())
            {
                if (Verificar_Explo())
                {
                    Inseminaciones mForm = (Inseminaciones)FormFactory.Obtener(Formulario.Inseminaciones);
                    mForm.RefrescarPantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();
                }
                else
                {
                    MessageBox.Show("Seleccione Primero una explotacion"); Explotaciones mForm = (Explotaciones)FormFactory.Obtener(Formulario.Explotaciones);
                    mForm.Refrescar_Pantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();
                }
            }
            else
            {
                Program.OcultarCursorEspera();
                MessageBox.Show("La base de datos no existe, creela");
                Sincronizar mForm = (Sincronizar)FormFactory.Obtener(Formulario.Sincronizar);
                mForm.Show();

            }
        } //OK verificando BD y explo
        private void Partos_Click(object sender, EventArgs e)
        { Program.MostrarCursorEspera();
            if (Verificar_BD())
            {
                if (Verificar_Explo())
                {
                    Program.MostrarCursorEspera();
                    Partos mForm = (Partos)FormFactory.Obtener(Formulario.Partos);
                    mForm.RefrescarPantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();
                    
                    
                }
                else
                {
                    MessageBox.Show("Seleccione Primero una explotacion");
                    Explotaciones mForm = (Explotaciones)FormFactory.Obtener(Formulario.Explotaciones);
                    mForm.Refrescar_Pantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();
                }
            }
            else
            {
                Program.OcultarCursorEspera();
                MessageBox.Show("La base de datos no existe, creela");
                Sincronizar mForm = (Sincronizar)FormFactory.Obtener(Formulario.Sincronizar);
                mForm.Show();

            }
        }//OK verificando BD y explo
        private void PartosMultiples_Click(object sender, EventArgs e)//Partos multiples
        {
            Program.MostrarCursorEspera();
            if (Verificar_BD())
            {
                if (Verificar_Explo())
                {
                    InsertarPartosMultiples mForm = (InsertarPartosMultiples)FormFactory.Obtener(Formulario.InsertarPartosMultiples);
                    mForm.refresca_Pantala();
                    Program.OcultarCursorEspera();
                    mForm.Show();
                }
                else
                {
                    MessageBox.Show("Seleccione Primero una explotacion");
                    Explotaciones mForm = (Explotaciones)FormFactory.Obtener(Formulario.Explotaciones);
                    mForm.Refrescar_Pantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();
                }
            }
            else
            {
                Program.OcultarCursorEspera();
                MessageBox.Show("La base de datos no existe, creela");
                Sincronizar mForm = (Sincronizar)FormFactory.Obtener(Formulario.Sincronizar);
                mForm.Show();

            }
        }
        private void Pesos_Click(object sender, EventArgs e)
        {
             Program.MostrarCursorEspera();
             if (Verificar_BD())
             {
                 if (Verificar_Explo())
                 {
                     Pesos mForm = (Pesos)FormFactory.Obtener(Formulario.Pesos);
                     mForm.refrescar();
                     Program.OcultarCursorEspera();
                     mForm.Show();
                     
                 }
                 else
                 {
                     MessageBox.Show("Seleccione Primero una explotacion");
                     Explotaciones mForm = (Explotaciones)FormFactory.Obtener(Formulario.Explotaciones);
                     mForm.Refrescar_Pantalla();
                     Program.OcultarCursorEspera();
                     mForm.Show();
                 }
            }
            else
            {
                Program.OcultarCursorEspera();
                MessageBox.Show("La base de datos no existe, creela");
                Sincronizar mForm = (Sincronizar)FormFactory.Obtener(Formulario.Sincronizar);
                mForm.Show();

            }
        }
        private void LechesB_Click(object sender, EventArgs e)
        {
            Program.MostrarCursorEspera();
            if (Verificar_BD())
            {
                if (Verificar_Explo())
                {                   
                    Controles mForm = (Controles)FormFactory.Obtener(Formulario.Controles);
                    mForm.Refrescar_Pantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();                   
                }
                else
                {
                    MessageBox.Show("Seleccione Primero una explotacion");
                    Explotaciones mForm = (Explotaciones)FormFactory.Obtener(Formulario.Explotaciones);
                    mForm.Refrescar_Pantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();
                }
            }
            else
            {
                Program.OcultarCursorEspera();
                MessageBox.Show("La base de datos no existe, creela");
                Sincronizar mForm = (Sincronizar)FormFactory.Obtener(Formulario.Sincronizar);
                mForm.Show();

            }           
        }//Leches
        private void Sincronizar_Click(object sender, EventArgs e)
        {
            Sincronizar mForm = (Sincronizar)FormFactory.Obtener(Formulario.Sincronizar);
            mForm.Show();
        }       
        private void menuItem2_Click(object sender, EventArgs e)//Explotaciones
        {
            if (Verificar_BD())
            {
                Program.MostrarCursorEspera();
                Explotaciones mForm = (Explotaciones)FormFactory.Obtener(Formulario.Explotaciones);
                mForm.Refrescar_Pantalla();
                Program.OcultarCursorEspera();
                mForm.Show();
            }
            else
            {
                Program.OcultarCursorEspera();
                MessageBox.Show("Cree la Base de datos");
                Sincronizar mForm = (Sincronizar)FormFactory.Obtener(Formulario.Sincronizar);
                mForm.Show();
            }
        }
        private void menuItem3_Click(object sender, EventArgs e) //Diagnostico inseminacion
        {
            Program.MostrarCursorEspera();
            if (Verificar_BD())
            {
                if (Verificar_Explo())
                {
                    Program.MostrarCursorEspera();
                    DiagnosticoGestacion mForm = (DiagnosticoGestacion)FormFactory.Obtener(Formulario.DiagnosticoGestacion);
                    //mForm.RefrescarPantalla();
                    mForm.Refrescar_Pantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();
                }
                else
                {
                    MessageBox.Show("Seleccione Primero una explotacion");
                    Explotaciones mForm = (Explotaciones)FormFactory.Obtener(Formulario.Explotaciones);
                    mForm.Refrescar_Pantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();
                }
            }
            else
            {
                Program.OcultarCursorEspera();
                MessageBox.Show("La base de datos no existe, creela");
                Sincronizar mForm = (Sincronizar)FormFactory.Obtener(Formulario.Sincronizar);
                mForm.Show();

            }
        }
        private void menuItem4_Click(object sender, EventArgs e)//Condiciones Corporales
        {
            Program.MostrarCursorEspera();
            if (Verificar_BD())
            {
                if (Verificar_Explo())
                {
                    Program.MostrarCursorEspera();
                    CondicionCorporal mForm = (CondicionCorporal)FormFactory.Obtener(Formulario.CondicionCorporal);
                    mForm.refres_Pantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();
                }
                else
                {
                    MessageBox.Show("Seleccione Primero una explotacion");
                    Explotaciones mForm = (Explotaciones)FormFactory.Obtener(Formulario.Explotaciones);
                    mForm.Refrescar_Pantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();
                }
            }
            else
            {
                Program.OcultarCursorEspera();
                MessageBox.Show("La base de datos no existe, creela");
                Sincronizar mForm = (Sincronizar)FormFactory.Obtener(Formulario.Sincronizar);
                mForm.Show();

            }
        }
        private void menuItem8_Click(object sender, EventArgs e)//Diagnosticos
        {
            Program.MostrarCursorEspera();
            if (Verificar_BD())
            {
                if (Verificar_Explo())
                {
                    Diagnosticos mForm = (Diagnosticos)FormFactory.Obtener(Formulario.Diagnosticos);
                    mForm.refrescar_Pantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();

                }
                else
                {
                    MessageBox.Show("Seleccione Primero una explotacion");
                    Explotaciones mForm = (Explotaciones)FormFactory.Obtener(Formulario.Explotaciones);
                    mForm.Refrescar_Pantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();
                }
            }
            else
            {
                Program.OcultarCursorEspera();
                MessageBox.Show("La base de datos no existe, creela");
                Sincronizar mForm = (Sincronizar)FormFactory.Obtener(Formulario.Sincronizar);
                mForm.Show();

            }
        }
        private void menuItem9_Click(object sender, EventArgs e)//Tratamientos
        {
            Program.MostrarCursorEspera();
            if (Verificar_BD())
            {
                if (Verificar_Explo())
                {
                    Tratamientos mForm = (Tratamientos)FormFactory.Obtener(Formulario.Tratamientos);
                    mForm.refrescar_pantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();

                }
                else
                {
                    MessageBox.Show("Seleccione Primero una explotacion");
                    Explotaciones mForm = (Explotaciones)FormFactory.Obtener(Formulario.Explotaciones);
                    mForm.Refrescar_Pantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();
                }
            }
            else
            {
                Program.OcultarCursorEspera();
                MessageBox.Show("La base de datos no existe, creela");
                Sincronizar mForm = (Sincronizar)FormFactory.Obtener(Formulario.Sincronizar);
                mForm.Show();

            }
        }
        private void menuItem10_Click(object sender, EventArgs e)
        {
            Program.MostrarCursorEspera();
            if (Verificar_BD())
            {
                if (Verificar_Explo())
                {
                    Secados mForm = (Secados)FormFactory.Obtener(Formulario.Secados);
                    mForm.refrescar_Pantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();

                }
                else
                {
                    MessageBox.Show("Seleccione Primero una explotacion");
                    Explotaciones mForm = (Explotaciones)FormFactory.Obtener(Formulario.Explotaciones);
                    mForm.Refrescar_Pantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();
                }
            }
            else
            {
                Program.OcultarCursorEspera();
                MessageBox.Show("La base de datos no existe, creela");
                Sincronizar mForm = (Sincronizar)FormFactory.Obtener(Formulario.Sincronizar);
                mForm.Show();

            }
        }//Secados
        private void menuItem11_Click(object sender, EventArgs e)
        {
            Program.MostrarCursorEspera();
            if (Verificar_BD())
            {
                if (Verificar_Explo())
                {
                    Cubriciones mForm = (Cubriciones)FormFactory.Obtener(Formulario.Cubriciones);
                    mForm.Refrescar_Pantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();

                }
                else
                {
                    MessageBox.Show("Seleccione Primero una explotacion");
                    Explotaciones mForm = (Explotaciones)FormFactory.Obtener(Formulario.Explotaciones);
                    mForm.Refrescar_Pantalla();
                    Program.OcultarCursorEspera();
                    mForm.Show();
                }
            }
            else
            {
                Program.OcultarCursorEspera();
                MessageBox.Show("La base de datos no existe, creela");
                Sincronizar mForm = (Sincronizar)FormFactory.Obtener(Formulario.Sincronizar);
                mForm.Show();

            }
        }//Cubriciones
        #endregion

        #region ORDENAR
        public static void ordenar_down(object sender, MouseEventArgs e)
        {
            try
            {
                DataGrid.HitTestInfo hitTest;

                // Use only left mouse button clicks.
                if (e.Button == MouseButtons.Left)
                {
                    // Set dataGrid equal to the object that called this event handler.
                    DataGrid dataGrid = (DataGrid)sender;

                    // Perform a hit test to determine where the mousedown event occured.
                    hitTest = dataGrid.HitTest(e.X, e.Y);

                    // If the mousedown event occured on a column header,
                    // then perform the sorting operation.

                    if (hitTest.Type == DataGrid.HitTestType.ColumnHeader)
                    {
                        // Reset mouse button state.
                        buttonPress = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ordenar los Partos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, System.Windows.Forms.MessageBoxDefaultButton.Button1);
            }
        }
        public static void ordenar_up(object sender, MouseEventArgs e)
        {
            Program.MostrarCursorEspera();

            try
            {
                System.Data.DataView dataView;
                DataGrid.HitTestInfo hitTest;
                string columnName;
                int numeroColumna;
                DataGrid dataGrid;
                dataGrid = (DataGrid)sender;
                if ((e.Button == MouseButtons.Left) && buttonPress)// Use only left mouse button clicks.
                {
                    buttonPress = false;// Reset mouse button state.  dataGrid = (DataGrid)sender;//Igual el datagrid declarado aquí al objeto enviado
                    if (dataGrid.DataSource != null)//si el datagrid no está vacio
                    {
                        hitTest = dataGrid.HitTest(e.X, e.Y);// Perform a hit test to determine where the mousedown event occured.
                        //Calculo en donde fue tocado
                        // If the MouseDown event occured on a column header,
                        // then perform the sorting operation.                        
                        if (hitTest.Type == DataGrid.HitTestType.ColumnHeader)//Si fue tocado en un nombre de coulmna
                        {
                            System.Data.DataTable dtordenamiento = (System.Data.DataTable)dataGrid.DataSource;
                            dataView = dtordenamiento.DefaultView;
                            numeroColumna = hitTest.Column;//Calculo el numero de la columna                            
                            columnName = NombreColumna(numeroColumna, dataGrid);   //Envio le numero de la coulmna y el datagrid
                            //para calcular el nombre de la columna
                            if (Program.ordenamientoparagrids != "DESC")
                            {
                                dataView.Sort = columnName + " DESC";
                                Program.ordenamientoparagrids = "DESC";
                                dataGrid.DataSource = CreateTable(dataView);
                              //  dataGrid.Refresh();
                            }
                            else
                            {
                                dataView.Sort = columnName;
                                Program.ordenamientoparagrids = "";
                                dataGrid.DataSource = CreateTable(dataView);
                                //dataGrid.Refresh();
                            }
                        }
                    }
                }
                Program.OcultarCursorEspera();
            }
            catch (Exception ex)
            {
                Program.OcultarCursorEspera();
                MessageBox.Show("Error Ordenando.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, System.Windows.Forms.MessageBoxDefaultButton.Button1);
            }
        }
        public static string NombreColumna(int numero, DataGrid datagrid)
        {
            switch (datagrid.Name)
            {
                case "DgAnimales":
                    switch (numero)
                    {
                        case 0:
                            return "Nombre"; //aqui hay que poner lo que tengas puesto en el mappingName
                        case 1:
                            return "DIB";
                        case 2:
                            return "Crotal";
                        case 3:
                            return "Tatuaje";
                        case 4:
                            return "Sexo";
                        case 5:
                            return "FechaNacimiento";
                        case 6:
                            return "Especie";
                        case 7:
                            return "Raza";
                    }
                    break;
                case "DgInseminaciones":
                    switch (numero)
                    {
                        case 0:
                            return "Fecha"; //aqui hay que poner lo que tengas puesto en el mappingName
                        case 1:
                            return "Descripcion";
                        case 2:
                            return "Hembra";
                        case 3:
                            return "Macho";    
                    }
                    break;
                case "DgExplotaciones":
                    switch (numero)
                    {
                        case 0:
                            return "Nombre"; //aqui hay que poner lo que tengas puesto en el mappingName                        
                    }
                    break;
                case "dgPartos":
                    switch (numero)
                    {
                        case 0:
                            return "Fecha"; //aqui hay que poner lo que tengas puesto en el mappingName                        
                        case 1:
                            return "Nombre"; //aqui hay que poner lo que tengas puesto en el mappingName                        
                        case 2:
                            return "DescripcionTipoParto"; //aqui hay que poner lo que tengas puesto en el mappingName                        
                        case 3:
                            return "Descripcion"; //aqui hay que poner lo que tengas puesto en el mappingName                        
                        case 4:
                            return "Vivos"; //aqui hay que poner lo que tengas puesto en el mappingName                        
                        case 5:
                            return "Muertos"; //aqui hay que poner lo que tengas puesto en el mappingName                        
                    }
                    break;
            }
            return null;
        }
        public static DataTable CreateTable(DataView obDataView)
        {
            if (null == obDataView)
            {
                throw new ArgumentNullException
                ("DataView", "Invalid DataView object specified");
            }

            DataTable obNewDt = obDataView.Table.Clone();
            int idx = 0;
            string[] strColNames = new string[obNewDt.Columns.Count];
            foreach (DataColumn col in obNewDt.Columns)
            {
                strColNames[idx++] = col.ColumnName;
            }

            IEnumerator viewEnumerator = obDataView.GetEnumerator();
            while (viewEnumerator.MoveNext())
            {
                DataRowView drv = (DataRowView)viewEnumerator.Current;
                DataRow dr = obNewDt.NewRow();
                try
                {
                    foreach (string strName in strColNames)
                    {
                        dr[strName] = drv[strName];
                    }
                }
                catch (Exception)
                {
                    

                }
                obNewDt.Rows.Add(dr);
            }

            return obNewDt;
        }
        #endregion

        public static void ActualizaEstado()
        {
            //string textoExplotacion = "Explotación: ";
            string textoVaca = "Nombre de la Explotacion: ";

            try
            {

                if (Program.Nombre != "")
                {

                    textoVaca = textoVaca + Program.Nombre;
                    //Program.ceares = BL.Vacas.ObtenerVacaPorCrotal(Program.crovaca).Rows[0]["ceares"].ToString();
                    Program.estado = textoVaca;
                    FormFactory.ActualizarBarrasEstado();

                }
                else
                {
                    textoVaca = textoVaca + "----";
                }
                
            }
            catch
            {
               
            }

            


        }
        private void Principal_Activated(object sender, EventArgs e)
        {
          
        }
      

        private bool Verificar_BD()
        {
            if (!System.IO.File.Exists(GEXVOC.Core.Logic.Configurador.BD))
            {             
                return false;
            }
            return true;
        }
        private bool Verificar_Explo()
        {
            if (Program.IdExplotacion==0)
            {
                return false;
            }
            return true;
        }

        

        

       
    }
}
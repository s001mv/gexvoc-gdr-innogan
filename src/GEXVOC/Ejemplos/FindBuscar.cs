using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;




namespace GEXVOC.UI.Ejemplos
{
    public partial class FindBuscar : GEXVOC.UI.GenericFind
    {
        /// <summary>
        /// Ejemplo sencillo de como hacer un control de búsqueda a través de 
        /// un formulario find.
        /// Nota: La plantilla ya esta preparada para esto, el combo no es necsario
        /// cargarlo, pues es el la plantilla (Find) quien lo carga y selecciona el elemento correspondiente
        /// </summary>
        public FindBuscar()
        {
            InitializeComponent();
        }


        #region CODIGO ESPECIFICO PARA PONER UN COMBO QUE BUSCA A TRAVES DE UN FORMULARIO FIND

            /// <summary>
            /// Lanzar el formulario find que nos interese
            /// Nota: Para que un formulario Find pueda ser lanzado de este modo, debe tener un 
            /// constructor que lo permita, el codigo del constructor es siempre el mismo.
            /// Ejemplo:  
            /// public FindExplotaciones(ref ComboBox controlBusqueda, Modo modoActual){
            ///        InitializeComponent();
            ///        base.InicializarGenericFind(ref controlBusqueda, modoActual);
            /// }
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnBuscarExplotacion_Click(object sender, EventArgs e)
            {
                FindExplotaciones FormFindExplotacion = new FindExplotaciones(Modo.Consultar, this.cmbExplotacion);
                FormFindExplotacion.MinimizeBox = false;
                FormFindExplotacion.ShowDialog(this);
                FormFindExplotacion.Dispose();
            }

            

            protected override void CargarCombos()
            {
                Producto prod = new Producto();
                List<Producto> lstProductos=Producto.Buscar();
                lstProductos.Add(prod);

                CargarCombo(comboBox1, lstProductos);
                base.CargarCombos();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                if (cmbAnimal.IdClaseActivaNullable == null)
                    return;
                
                DateTime?  fecha1=null,fecha2=null;
                if (Animal.AnimalEnfermo(cmbAnimal.IdClaseActiva,dateTimePicker1.Value, ref fecha1, ref fecha2))                
                {
                   lblEnferma.Text = "Enfermo";  
                   dateTimePicker2.Value = (DateTime)fecha1;
                   dateTimePicker2.Checked = true;
                   dateTimePicker3.Value = (DateTime)fecha2;
                   dateTimePicker3.Checked = true;

                }
                else                
                {
                    lblEnferma.Text = "Sano";
                    dateTimePicker2.Checked = false;
                    dateTimePicker3.Checked = false;
                }

                


                
            }

            private void btnBuscarAnimal_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, cmbAnimal));
            }

            private void button2_Click(object sender, EventArgs e)
            {
               
            }
            //NOTA: hay que acordarse de establecer en diseño la propiedad DisplayMember del CtlBuscarObjeto
            //esta propiedad mostrará el dato que quereis de la clase en cuentión.
            //Ej: Clase: Explotacion 
            //    DisplayMember: Nombre
            //En este caso cada vez que seleccionemos un elemento, se mostrará su propiedad nombre.


        


        #endregion

          

          

           
          
            
       
      
    }
}

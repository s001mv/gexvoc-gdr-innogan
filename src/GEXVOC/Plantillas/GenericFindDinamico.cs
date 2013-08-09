using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Controles;
using GEXVOC.Core.Logic;
using System.Reflection;
using System.Data.Linq;
using GEXVOC.UI.Clases;


namespace GEXVOC.UI
{
    public partial class GenericFindDinamico : GenericFind
    {

        #region CONSTRUCTORES
        public GenericFindDinamico()
        {
            InitializeComponent();
        }
        public GenericFindDinamico(Modo modo, ctlBuscarObjeto controlBusqueda):base(modo,controlBusqueda)
        {
                InitializeComponent();
        }    
        #endregion

        #region VARIABLES Y PROPIEDADES

        /// <summary>
        /// Variable Principal sobre la que actuará el formulario Edit
        /// Es asignada en el método InicializarGenericEdit()
        /// </summary>
        public IClaseBase ClaseBase = null;

        public int NumColumnas
        {
            get { return this.tableLayoutPanel1.ColumnCount; }
            set
            {
                this.tableLayoutPanel1.AutoScroll = true;
                this.tableLayoutPanel1.ColumnCount = value;
                foreach (ColumnStyle item in this.tableLayoutPanel1.ColumnStyles)
                    item.SizeType = SizeType.AutoSize;

            }
        }

        string _Titulo = string.Empty;
        public string Titulo
        {
            get { return _Titulo; }
            set
            {
                this.Text = value;
                _Titulo = value;
            }
        }

        #endregion

        #region CARGAS COMUNES
        public override void Cargar()
        {
            foreach (BindingMaestro item in this.lstBinding)
            {
                this.tableLayoutPanel1.Controls.Add(item.LblAsociado);
                this.tableLayoutPanel1.Controls.Add(item.ControlAsociado);
            }

            base.Cargar();
        }
        protected override void GenerarEstiloGrid()
        {
            //dtgResultado.Columns.Add("Descripcion", "Descripcion");
            //dtgResultado.Columns[0].DataPropertyName = "Descripcion";
            //dtgResultado.AutoGenerateColumns = true;
            dtgResultado.Columns.Clear();
            foreach (BindingMaestro item in lstBinding)
            {
                int numColumna = dtgResultado.Columns.Add(item.NombrePropiedad, item.NombreVisible);
                dtgResultado.Columns[numColumna].DataPropertyName = item.NombrePropiedad;

                if (item.TipoDatos == typeof(string))
                    dtgResultado.Columns[numColumna].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                //dtgResultado.Columns.Add(Columna);                
            }

        }
        #endregion

        #region FUNCIONAMIENTO GENERAL
        private void pnlBusqueda_SizeChanged(object sender, EventArgs e)
        {
            panel1.Size = new Size(pnlBusqueda.Size.Width, 315 - (pnlBusqueda.Size.Height - 69));
            panel1.Location = new Point(12, 103 + (pnlBusqueda.Size.Height - 69));
        }
        protected override void Buscar()
        {
            //DataLoadOptions options = new DataLoadOptions();
            ////Load my object along with nested object with it,
            ////as an example MyObject = Customer, MyNestObject=Orders
            //options.LoadWith<Cliente>(E=>E.Venta);

            //base.Get(options, m =>, 0, 100);
            //ClienteData.GetClientes(E=>E.Nombre.Contains(txt

            ////foreach (BindingMaestro item in lstBinding)
            ////{
            ////    if (Generic.ControlValorado(item.ControlAsociado))
            ////    {

            ////    }

            ////}
            foreach (MethodInfo item in ClaseBase.GetType().GetMethods())
            {
                if (item.Name == "BuscarDinamico")
                {
                    List<object> parametros = new List<object>();
                    foreach (ParameterInfo parametro in item.GetParameters())
                    {
                        //if (parametro.Name )
                        //{

                        object valor = null;
                        if (parametro.ParameterType == typeof(string))
                            valor = string.Empty;

                        foreach (BindingMaestro bind in lstBinding)
                        {

                            if (bind.NombrePropiedad.ToLower() == parametro.Name.ToLower())
                            {
                                try
                                {
                                    Generic.ControlAClaseBase(this.ClaseBase, bind.NombrePropiedad, bind.ControlAsociado);
                                    valor = this.ClaseBase.GetType().GetProperty(bind.NombrePropiedad).GetValue(this.ClaseBase, null);

                                }
                                catch (Exception)
                                {

                                    //     throw;
                                }


                            }


                        }

                        parametros.Add(valor);
                        //}


                    }
                    dtgResultado.DataSource = item.Invoke(this.ClaseBase, parametros.ToArray());
                }


            }
            //dtgResultado.DataSource = Enfermedad.Buscar(Generic.ControlAIntNullable(cmbTipo), txtDescripcion.Text);

        }

        /// <summary>
        /// Lanza el formulario de edicion de tipo de enfermedad en modo guardar.
        /// </summary>
        protected override void Insertar()
        {


            //TipoEnfermedad ObjetoBase = new TipoEnfermedad();
            GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, (IClaseBase)ClaseBase.GetType().Assembly.CreateInstance(ClaseBase.GetType().ToString()));
            frmLanzar.Titulo = this.Titulo;
            frmLanzar.NumColumnas = NumColumnas;
            foreach (BindingMaestro item in lstBinding)
                frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, item.NombrePropiedad, item.NombreVisible) { Requerido = item.Requerido, ValidacionEspecial = item.ValidacionEspecial });



            this.LanzarFormulario(frmLanzar, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario de edicion de tipo de enfermedad en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                IClaseBase ObjetoBase = (IClaseBase)this.dtgResultado.CurrentRow.DataBoundItem;

                GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Actualizar, ObjetoBase);
                frmLanzar.Titulo = this.Titulo;
                frmLanzar.NumColumnas = NumColumnas;

                foreach (BindingMaestro item in lstBinding)
                    frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, item.NombrePropiedad, item.NombreVisible) { Requerido = item.Requerido, ValidacionEspecial = item.ValidacionEspecial });


                this.LanzarFormulario(frmLanzar, this.dtgResultado);

            }
        }
        #endregion


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Controles;

namespace GEXVOC.UI
{
    public partial class FindTipoPersonal : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindTipoPersonal()
        {
            InitializeComponent();
        }
        public FindTipoPersonal(Modo modo, ctlBuscarObjeto controlBusqueda)
            : base(modo, controlBusqueda)
        {
            InitializeComponent();
        }
        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera el estilo del Grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Descripcion", "Descripcion");
            dtgResultado.Columns[0].DataPropertyName = "descripcion";
            dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<TipoPersonal>(TipoPersonal.Buscar(txtDescripcion.Text));
            //dtgResultado.DataSource = TipoPersonal.Buscar(txtDescripcion.Text);
        }

        


        /// <summary>
        /// Lanza el formulario de edicion de momentos de peso en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            TipoPersonal ObjetoBase = new TipoPersonal();
            GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ObjetoBase);
            frmLanzar.Titulo = "Tipo Personal";
            frmLanzar.NumColumnas = 2;
            frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción"));


            this.LanzarFormulario(frmLanzar, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario de edicion de momentos peso en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                TipoPersonal ObjetoBase = (TipoPersonal)this.dtgResultado.CurrentRow.DataBoundItem;
                GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Actualizar, ObjetoBase);
                frmLanzar.Titulo = "Tipo Personal";
                frmLanzar.NumColumnas = 2;
                frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción"));


                this.LanzarFormulario(frmLanzar, this.dtgResultado);

            }
        }

        #endregion
    
    }
}
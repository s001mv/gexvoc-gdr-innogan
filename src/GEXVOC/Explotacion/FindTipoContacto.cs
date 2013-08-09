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
    public partial class FindTipoContacto : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindTipoContacto()
        {
            InitializeComponent();
        }
        public FindTipoContacto(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            AsignarOrigenDatos<TipoContacto>(TipoContacto.Buscar(txtDescripcion.Text, null));
            //dtgResultado.DataSource = TipoContacto.Buscar(txtDescripcion.Text,null);
        }
        /// <summary>
        /// Lanza el formulario de edición de TipoContacto en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            //TipoContacto ObjetoBase = new TipoContacto();
            //this.LanzarFormulario(new EditTipoContacto(Modo.Guardar, ObjetoBase), this.dtgResultado);

            TipoContacto ObjetoBase = new TipoContacto();
            GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ObjetoBase);
            frmLanzar.Titulo = "Tipo de Contacto";
            frmLanzar.NumColumnas = 2;
            frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción"));


            this.LanzarFormulario(frmLanzar, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de TipoContacto en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            //if (dtgResultado.SelectedRows.Count == 1)
            //{
            //    //TipoContacto ObjetoBase = (TipoContacto)this.dtgResultado.CurrentRow.DataBoundItem;
            //    //this.LanzarFormulario(new EditTipoContacto(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            //}

            if (dtgResultado.SelectedRows.Count == 1)
            {
                TipoContacto ObjetoBase = (TipoContacto)this.dtgResultado.CurrentRow.DataBoundItem;

                GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Actualizar, ObjetoBase);
                frmLanzar.Titulo = "Tipo de Contacto";
                frmLanzar.NumColumnas = 2;
                frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción"));


                this.LanzarFormulario(frmLanzar, this.dtgResultado);
            }
        }

        #endregion
    }
}
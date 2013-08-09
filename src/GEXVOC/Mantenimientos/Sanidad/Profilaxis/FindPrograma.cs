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
    public partial class FindPrograma : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindPrograma()
        {
            InitializeComponent();
        }
        public FindPrograma(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            AsignarOrigenDatos<Programa>(Programa.Buscar(txtDescripcion.Text));
            //dtgResultado.DataSource = Programa.Buscar(txtDescripcion.Text);

        }
        /// <summary>
        /// Lanza el formulario de edición de Programa en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Programa ObjetoBase = new Programa();
            GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ObjetoBase);
            frmLanzar.Titulo = "Programa de Profilaxis";
            frmLanzar.NumColumnas = 2;
            frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción"));


            this.LanzarFormulario(frmLanzar, this.dtgResultado);

        }
        /// <summary>
        /// Lanza el formulario edicion de Programa en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Programa ObjetoBase = (Programa)this.dtgResultado.CurrentRow.DataBoundItem;
                GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Actualizar, ObjetoBase);
                frmLanzar.Titulo = "Programa de Profilaxis";
                frmLanzar.NumColumnas = 2;
                frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción"));


                this.LanzarFormulario(frmLanzar, this.dtgResultado);
            }
        }

        #endregion
    }
}
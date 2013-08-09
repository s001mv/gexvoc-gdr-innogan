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
    public partial class FindParcela : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
            public FindParcela()
            {
                InitializeComponent();
            }
            public FindParcela(Modo modo, ctlBuscarObjeto controlBusqueda)
                : base(modo, controlBusqueda)
            {
                InitializeComponent();
            }
        #endregion

        #region CARGAS COMUNES
            protected override void CargarCombos()
            {
                CargarCombo(cmbTitular, "NombreCompleto", Configuracion.Explotacion.lstTitulares);           

                base.CargarCombos();
            }
        #endregion

        #region FUNCIONES SOBREECRITAS
        protected override void Buscar()
        {
            AsignarOrigenDatos<Parcela>(Parcela.Buscar(null, Generic.ControlAIntNullable(this.cmbTitular), 
                                                       txtNombreParcela.Text, txtPoligono.Text, null));
            //this.dtgResultado.DataSource = Parcela.Buscar(null,Generic.ControlAIntNullable(this.cmbTitular),txtNombreParcela.Text, txtPoligono.Text,null);
            //base.Buscar();
        }
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Nombre", "Parcela");
            dtgResultado.Columns[0].DataPropertyName = "Nombre";
            dtgResultado.Columns.Add("Titular", "Titular");
            dtgResultado.Columns[1].DataPropertyName = "DescTitular";
            dtgResultado.Columns.Add("Poligono", "Polígono");
            dtgResultado.Columns[2].DataPropertyName = "Poligono";
            dtgResultado.Columns.Add("Extension", "Extensión");
            dtgResultado.Columns[3].DataPropertyName = "Extension";
            dtgResultado.Columns[3].DefaultCellStyle.Format = "N";
            dtgResultado.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgResultado.Columns.Add("DescRacion", "Raciones Soportadas");
            dtgResultado.Columns[4].DataPropertyName = "DescRacion";
            dtgResultado.Columns[4].DefaultCellStyle.Format = "N";
            dtgResultado.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

  
        }


        protected override void Insertar()
        {
            Parcela ObjetoBase = new Parcela();
            this.LanzarFormulario(new EditParcela(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Racion en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Parcela ObjetoBase = (Parcela)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditParcela(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion            

    }
}

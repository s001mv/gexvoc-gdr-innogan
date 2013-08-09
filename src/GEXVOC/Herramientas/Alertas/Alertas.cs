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
    public partial class Alertas : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
            public Alertas()
            {
                InitializeComponent();

                Generic.EliminarAutogenerateColumns(this);
                //Oculto los botones insertar, actualizar, y eliminar
                this.ControlModo(true);
                this.btnBuscar.Visible = false;
                this.btnBuscar.Enabled = false;
                this.btnLimpiar.Visible = false;
                this.btnLimpiar.Enabled = false;

                CargarElementos();         
            }
        #endregion

        #region CARGAS COMUNES
            public void CargarElementos()
            {          
                if (Core.Logic.Alertas.alertas.ContainsKey("Enfermas"))
                    this.AsignarOrigenDatos<AlertarEnfermas>((List<AlertarEnfermas>)Core.Logic.Alertas.alertas["Enfermas"], this.dtgEnfermas);
                if (Core.Logic.Alertas.alertas.ContainsKey("Secadas"))
                    this.AsignarOrigenDatos<AlertarSecadas>((List<AlertarSecadas>)Core.Logic.Alertas.alertas["Secadas"], this.dtgSecadas);
                if (Core.Logic.Alertas.alertas.ContainsKey("Paridas"))
                    this.AsignarOrigenDatos<AlertarParidas>((List<AlertarParidas>)Core.Logic.Alertas.alertas["Paridas"], this.dtgParidas);
                if (Core.Logic.Alertas.alertas.ContainsKey("Diagnosticos"))
                    this.AsignarOrigenDatos<AlertarDiagnosticos>((List<AlertarDiagnosticos>)Core.Logic.Alertas.alertas["Diagnosticos"], this.dtgDiagnosticos);
            }
        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void dtgEnfermas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                AlertarEnfermas Alerta = null;
                try
                {
                    Alerta = (AlertarEnfermas)this.dtgEnfermas.Rows[e.RowIndex].DataBoundItem;
                    if (Alerta!=null)
                    {
                        TratEnfermedad ObjetoBase = (TratEnfermedad)Alerta.Tag;

                        if (ObjetoBase != null)
                        {
                            EditTratEnfermedad editTratamiento = new EditTratEnfermedad(Modo.Actualizar, ObjetoBase);
                            this.LanzarFormulario(editTratamiento, this.dtgResultado);
                        }                    
                    }                
                }
                catch (Exception){}
            }


        #endregion
    }
}



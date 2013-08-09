using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Data;

namespace GEXVOC.UI
{
    public partial class InsertarCubricion : GEXVOC.UI.Principal
    {
        public InsertarCubricion()
        {
            InitializeComponent();
        }
        public void refrescar_Lote(string descripcion)
        {
            TbLote.Text = descripcion;
        }
        public void refrescar_pantalla()
        {
            //Combo de especies

            CbTipo.DataSource = TipoCubricionTA.ObtenerTipos();
            CbTipo.DisplayMember = "Descripcion";
            CbTipo.ValueMember = "Id";
            CbTipo.Refresh();
        }
        private void InsertarCubricion_Closing(object sender, CancelEventArgs e)
        {

            DialogResult r = Program.Preguntar("¿Desea guardar la cubricion?");
            if (r == DialogResult.Yes)
            {
                if (Validar())
                {
                    //DateTime FechaIni;
                    DateTime? FechaFin = null;
                    if (TbFechaFIn.Text == dtFechaFin.Value.Date.ToString())
                        FechaFin = dtFechaFin.Value.Date;
                    CubricionTA.InsertarNueva(Program.IdLote, Convert.ToInt32(CbTipo.SelectedValue.ToString()), dtFechaIni.Value.Date, FechaFin);
                    e.Cancel = true;
                }
                {

                }


                e.Cancel = true;
            }
            else
            {
                e.Cancel = true;
            }
        }
        private bool Validar()
        {
            //Mirar que las fechas pertenezcan al rango de ese lote
            //Mirar que cada animal pueda estar en esa cubricion haciendo la misma validacion que para las inseminaciones
            if (TbLote.Text != "")
            {
                DataTable AniLot = AniLotTa.ObtenerAnimalesSegunLote(Program.IdLote);
                int i;
                for (i = 0; i < AniLot.Rows.Count; i++)
                {
                    Program.IdAnimal = Convert.ToInt32(AniLot.Rows[i]["IdAnimal"].ToString());
                    //string Nombre = AniLot.Rows[i]["Nombre"].ToString();
                    //Aquí compruebo animal por animal
                    //Logica No puede ser el mismo día
                    #region mismo dia
                    ////No puede haber varias inseminaciones el mismo día
                    ///************************************************************************/
                    //DataTable dtNum = InseminacionesTA.ObtenerInseminacionesDiaIdVaca(dtFecha.Value.Date, Program.IdAnimal);
                    //if (dtNum.Rows.Count > 0)
                    //{
                    //    Program.Informar("No puede haber varías inseminaciones el mismo día para la vaca." + Nombre);                        
                    //}
                    #endregion
                    //No puede ser hasta x días despues del parto
                    #region x días despues de parto
                    //Obtengo la especie del animal para buscar la parametrizacion
                    DataTable especies = AnimalTA.ObtenerEspecie(Program.IdAnimal);
                    string especie = especies.Rows[0]["Especie"].ToString();
                    string clave = "PeriodoInseminacionPostParto_" + especie;
                    /**************************************************************************/
                    //No se puede inseminar hasta X dias despues de un parto previo
                    /******************************************************************/

                    double PeriodoInseminacionPostParto = Convert.ToDouble(Parametrizacion.ObtenerParametrizacionPorClave(clave));
                    if (PartosTA.ExistePartoEntreFechasIdVaca(dtFechaIni.Value.AddDays(-PeriodoInseminacionPostParto).Date,
                                                                dtFechaIni.Value.Date,
                                                                Program.IdAnimal).Rows.Count > 0)
                    {
                        //TODO: Mensaje error
                        Program.Informar("Non se pode inseminar ata ó número de días parametrizado, despois dun parto para la vaca.");
                        return false;
                    }
                    /******************************************************************/
                    #endregion

                    //no puede haber un parto o un aborto posterior
                    #region parto aborto posterior
                    //No se pueden Modificar/Eliminar inseminaciones con parto posterior
                    /******************************************************************/
                    if (PartosTA.ObtenerPartosPosterioresAFechaIdVaca(dtFechaFin.Value.Date, Program.IdAnimal).Rows.Count > 0)
                    {
                        //TODO: Mensaje error
                        Program.Informar("No puede agregar una inseminacion a una vaca que tenga un parto posterior para la vaca");
                        return false;
                    }
                    /******************************************************************/
                    //No se puede insertar inseminacines con aborto posterior
                    if (AbortosTA.ObtenerAbortosDesdeFechaIdVaca(dtFechaFin.Value.Date, Program.IdAnimal).Rows.Count > 0)
                    {
                        Program.Informar("No puede agregar una inseminacion a una vaca que tenga un aborto posterior para la vaca " );
                        return false;
                    }
                    #endregion

                    //El animal está en una cubricion sin fecha fin o en una cubricion
                    #region cubricion abierta
                    DataTable cubricionesAbiertas = CubricionTA.ObtenerCubricionesAbiertas(Program.IdHembrarParaInsertarPartos);
                    if (cubricionesAbiertas.Rows.Count > 0)
                    {
                        Program.Informar("La hembra:  tiene una cubricion, pero se encuentra sin fecha fin, el proceso no puede continuar sin una fecha fin válida.");
                        return false;
                    }
                    #endregion

                    //no puede haber una inseminacion posterior
                    #region inseminacion posterior
                    /******************************************************************/
                    //No se puede insertar inseminacines con inseminacion posterior
                    if (InseminacionesTA.ObtenerInseminacionesDesdeFechaIddVaca(dtFechaFin.Value.Date, Program.IdAnimal).Rows.Count > 0)
                    {
                        Program.Informar("Tiene Inseminaciones Posteriores");
                        return false;
                    }
                    #endregion

                    #region dosis
                    ///******************************************************************/
                    ////TODO:Validar Dosis
                    ///******************************************************************/
                    //if (Cbtipo.Text == "INSEMINACIÓN ARTIFICIAL")
                    //{
                    //    if (TbDosis.Text == "")
                    //    {
                    //        Program.Informar("el campos dosis está vacio");
                    //        return false;
                    //    }

                    //    if (!Program.EsEntero(TbDosis.Text))
                    //    {
                    //        Program.Informar("el campo dosis debe ser numerico");
                    //        return false;
                    //    }
                    //}
                    ///******************************************************************/
                    #endregion
                    //Comentada                    
                    //************************************************************/
                }
            }
            else
            {
                Program.Informar("Seleccione Lote");
                return false;
            }
            return true;
        }

        private void PbFiltrar_Click(object sender, EventArgs e)
        {
            Program.dedonde = "Cubriciones";
            SeleccionarLotes mForm = (SeleccionarLotes)FormFactory.Obtener(Formulario.SeleccionarLotes);
            mForm.refrescar_Pantalla();
            mForm.Show();
        }

        private void dtFechaFin_ValueChanged(object sender, EventArgs e)
        {
            TbFechaFIn.Text = dtFechaFin.Value.Date.ToString();
        }
    }
}


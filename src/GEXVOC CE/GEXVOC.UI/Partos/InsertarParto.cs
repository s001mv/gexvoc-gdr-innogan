﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Data;
using GEXVOC.Core.Logic;
using System.Globalization;
namespace GEXVOC.UI
{
    public partial class InsertarPartoMultiples : GEXVOC.UI.Principal
    {
        public InsertarPartoMultiples()
        {
            InitializeComponent();
        }
        public void refrescar_pantalla()
        {
            //Combobox de tipo

            cbTipo.DataSource = TipoPartoTA.ObtenerTiposPartos();
            cbTipo.DisplayMember = "Descripcion";
            cbTipo.ValueMember = "Id";
            cbTipo.Refresh();
            /**************************************************************/
            //Combobox de dificultad            
            CbFacilidad.DataSource = FacilidadTA.ObtenerFacilidades();
            CbFacilidad.DisplayMember = "Descripcion";
            CbFacilidad.ValueMember = "Id";
            CbFacilidad.Refresh();
        }

        public void refrescar_TbHembra(string nombre)
        {
            textBox1.Text = nombre;
        }

        private void InsertarParto_Closing(object sender, CancelEventArgs e)
        {            
              DialogResult r = Program.Preguntar("¿Desea guardar el Parto?");
              if (r == DialogResult.Yes)
              {
                  if (validar())
                  {
                      string causadelamuerte = "";
                      if (TbCausaDeLamuerte.Text != "")
                          causadelamuerte = TbCausaDeLamuerte.Text;
                      int vivos;
                      int muertos;
                      if (Tbvivos.Text != "")
                          vivos = Convert.ToInt32(Tbvivos.Text);
                      else
                          vivos = 0;

                      if (tbMuertos.Text != "")
                          muertos = Convert.ToInt32(tbMuertos.Text);
                      else
                          muertos = 0;
                      PartosTA.InsertarNueva(Program.IdHembrarParaInsertarPartos, Convert.ToInt32(cbTipo.SelectedValue.ToString()), Convert.ToInt32(CbFacilidad.SelectedValue.ToString()),vivos, muertos, causadelamuerte, dtFecha.Value.Date);
                      e.Cancel = true;
                      InsertarPartoMultiples mForm = (InsertarPartoMultiples)FormFactory.Obtener(Formulario.InsertarParto);
                      mForm.Hide();
                  }
                  else
                  {
                      e.Cancel = true;
                      InsertarPartoMultiples mForm = (InsertarPartoMultiples)FormFactory.Obtener(Formulario.InsertarParto);
                      mForm.Show();
                  }
              }
              else
              {
                  e.Cancel = true;
                  InsertarPartoMultiples mForm = (InsertarPartoMultiples)FormFactory.Obtener(Formulario.InsertarParto);
                  //mForm.Refrescar_Pantalla();
                  //Program.OcultarCursorEspera();
                  mForm.Hide();
              }
        }

        private void pbBuscarhembra_Click(object sender, EventArgs e)
        {
            Program.queSeleccion = "HembrasInsertarParto";
            Program.MostrarCursorEspera();
            Animal mForm = (Animal)FormFactory.Obtener(Formulario.Animal);
            mForm.RefrescarPantalla("H");
            Program.OcultarCursorEspera();
            mForm.Show();
        }

        private bool validar()
        {
            DateTime Fecha = dtFecha.Value.Date;

            #region Vivos y muertos
            DataTable crias = TipoPartoTA.ObtenerCriasPartosPorTipo(Convert.ToInt32(cbTipo.SelectedValue.ToString()));
            if (crias.Rows[0]["crias"].ToString() != "")
            {
                int CuantasCrias = Convert.ToInt32(crias.Rows[0]["crias"].ToString());
                int vivos;
                int muertos;
                if (Tbvivos.Text != "")
                    vivos = Convert.ToInt32(Tbvivos.Text);
                else
                    vivos = 0;

                if (tbMuertos.Text != "")
                    muertos = Convert.ToInt32(tbMuertos.Text);
                else
                    muertos = 0;

                int NacieronCrias = vivos + muertos;

                if (NacieronCrias != CuantasCrias)
                {
                    Program.Informar("Revise las cifras de vivos y muertos, no coinciden con el tipo del parto");
                    return false;
                }
            }


            #endregion



           
            if (Program.IdHembrarParaInsertarPartos != 0)
            {
                //Primero Miro La ultima fecha de inseminacion/Cubricion
                #region cubriciones abiertas
                //Miro que no tenga ninguna cubrición abierta
                DataTable cubricionesAbiertas = CubricionTA.ObtenerCubricionesAbiertas(Program.IdHembrarParaInsertarPartos);
                if (cubricionesAbiertas.Rows.Count > 0)
                {
                    Program.Informar("La hembra: " + Program.NombreVacaPartos + " tiene una cubricion, pero se encuentra sin fecha fin, el proceso no puede continuar sin una fecha fin válida.");
                    return false;
                }
                #endregion
                #region esta inseminada?
                DateTime? UltimaFechaInseminacionCubricion = null; //Busco la ultima inseminacion o la ultima cubricion, lo q sea >
                DateTime? UltimaFechaPartoAborto = null; //busco parto o aborto, lo que sea mayor
                UltimaFechaPartoAborto = CalcularFechaUltimoPartoAborot(Program.IdHembrarParaInsertarPartos);
                UltimaFechaInseminacionCubricion = CalcularFechaUltimaInseminacionCubricion(Program.IdHembrarParaInsertarPartos);

                if (UltimaFechaInseminacionCubricion == null)
                {
                    Program.Informar("La hembra: " + Program.NombreVacaPartos + " no ha sido inseminada ni dispone de cubriciones.");
                    return false;
                }
                else
                {
                    if (UltimaFechaPartoAborto != null)
                    {
                        if (UltimaFechaInseminacionCubricion < UltimaFechaPartoAborto)
                        {
                            Program.Informar("La hembra: " + Program.NombreVacaPartos + " no ha sido inseminada ni dispone de cubriciones desde el último parto o aborto.");
                            return false;
                        }
                    }
                }
            #endregion
                #region periodo de gestacion
                //Mirar días de gestacion
                //Obtengo la especie del animal para buscar la parametrizacion
                DataTable especies = AnimalTA.ObtenerEspecie(Program.IdHembrarParaInsertarPartos);
                string especie = especies.Rows[0]["Especie"].ToString();
                string claveMinimoGestacion = "DiasMinimoGestacion_" + especie;
                string claveMaximoGestacion = "DiasMaximoGestacion_" + especie;
                double Minimo = Convert.ToDouble(Parametrizacion.ObtenerParametrizacionPorClave(claveMinimoGestacion));
                double Maximo = Convert.ToDouble(Parametrizacion.ObtenerParametrizacionPorClave(claveMaximoGestacion));
                if (Fecha < ((DateTime)UltimaFechaInseminacionCubricion).AddDays(Minimo)
                              || Fecha > ((DateTime)UltimaFechaInseminacionCubricion).AddDays(Maximo))
                {
                    Program.Informar("La fecha de parto para la hembra: " + Program.NombreVacaPartos + "  no es válida. No se ha respetado el período de gestación establecido.\r"
                        + "La fecha del parto debe estar comprendida entre: " + ((DateTime)UltimaFechaInseminacionCubricion).AddDays(Minimo).ToShortDateString()
                        + " y " + ((DateTime)UltimaFechaInseminacionCubricion).AddDays(Maximo).ToShortDateString());
                    return false;
                }
                #endregion
                return true;
            }
            else
            {
                Program.Informar("Seleccione hembra");
                return false;
            }
        }
        private DateTime? CalcularFechaUltimaInseminacionCubricion(int IdHembra)
        {
            DateTime? fechaultimainseminacion = null;
            DateTime? fechaultimacubricion = null;
            DataTable ultimainseminacion = InseminacionesTA.ObtenerUltimaFechaInseminacionDeVaca(IdHembra);
            if (ultimainseminacion.Rows.Count > 0)
                fechaultimainseminacion = Convert.ToDateTime(ultimainseminacion.Rows[0]["fecha"].ToString());
            else
                fechaultimainseminacion = null;

            DataTable ultimacubricion = CubricionTA.ObtenerCubricionIdVaca(IdHembra);
            if (ultimacubricion.Rows.Count > 0)
                fechaultimacubricion = Convert.ToDateTime(ultimacubricion.Rows[0]["FechaInicio"].ToString());
            else
                fechaultimacubricion = null;
            if (fechaultimacubricion != null && fechaultimainseminacion != null)
            {
                if (fechaultimacubricion > fechaultimainseminacion)
                    return fechaultimacubricion;
                else if (fechaultimainseminacion > fechaultimacubricion)
                    return fechaultimainseminacion;
            }
            else if (fechaultimainseminacion != null && fechaultimacubricion == null)
                return fechaultimainseminacion;
            else if (fechaultimainseminacion == null && fechaultimacubricion != null)
                return fechaultimacubricion;

            return null;
        }
        public DateTime? CalcularFechaUltimoPartoAborot(int IdHembra)
        {
            DateTime? fechaultimoparto;
            DateTime? fechaultimoaborto;
            DataTable Dtfechasultimoparto = PartosTA.ObtenerFechaUltimoParto(IdHembra);
            DataTable Dtfechasultimoaborto = AbortosTA.ObtenerUltimoAborto(IdHembra);
            if (Dtfechasultimoaborto.Rows.Count > 0)
                fechaultimoaborto = Convert.ToDateTime(Dtfechasultimoaborto.Rows[0]["Fecha"].ToString());
            else
                fechaultimoaborto = null;
            if (Dtfechasultimoparto.Rows.Count > 0)
                fechaultimoparto = Convert.ToDateTime(Dtfechasultimoparto.Rows[0]["Fecha"].ToString());
            else
                fechaultimoparto = null;


            if (fechaultimoaborto != null && fechaultimoparto != null)
            {
                if (fechaultimoparto > fechaultimoaborto)
                    return fechaultimoparto;
                else if (fechaultimoaborto > fechaultimoparto)
                    return fechaultimoaborto;
            }
            else if (fechaultimoaborto != null && fechaultimoparto == null)
                return fechaultimoaborto;
            else if (fechaultimoaborto == null && fechaultimoparto != null)
                return fechaultimoparto;

            return null;

        }

    }
}


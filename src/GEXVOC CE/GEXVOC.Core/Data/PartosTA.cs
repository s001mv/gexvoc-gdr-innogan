using System;
using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;
using System.Globalization;

namespace GEXVOC.Core.Data
{
    public class PartosTA : PartoTableAdapter
    {
        public static GexvocDataSet.PartoDataTable ObtenerPartosDeExplotacion(int IdExplotacion)
        {
            PartoTableAdapter partos = new PartoTableAdapter();
            return partos.ObtenerPartosDeExplotacion(IdExplotacion);
        }
        public static GexvocDataSet.PartoDataTable ExistePartoEntreFechasIdVaca(DateTime FechaIni, DateTime FechaFin, int IdVaca)
        {
            PartoTableAdapter partos = new PartoTableAdapter();
            return partos.ObtenerPartosEntreFechas(FechaIni, FechaFin, IdVaca);
        }
        public static GexvocDataSet.PartoDataTable ObtenerPartosPosterioresAFechaIdVaca(DateTime Fecha, int IdVaca)
        {
            PartoTableAdapter partos = new PartoTableAdapter();
            return partos.ObtenerPartoDespuesDeFechaIdVAca(Fecha, IdVaca);
        }
        public static GexvocDataSet.PartoDataTable ObtenerFechaUltimoParto(int IdHembra)
        {
            PartoTableAdapter partos = new PartoTableAdapter();
            return partos.ObtenerFechaUltimoParto(IdHembra);

        }
        public static void InsertarNueva(int IdHembra,int IdTipo,int IdFacilidad,int vivos,int muertos,string causamuerte,DateTime Fecha)
        {
            PartoTableAdapter partos = new PartoTableAdapter();
            int? vivoss = null;
            int? muertoss = null;
            if (vivos != 0)
                vivoss = vivos;
            if (muertos != 0)
                muertoss = muertos;
            partos.InsertarParto(Convert.ToInt32(ObtenerMaxIdParto()), IdHembra, IdTipo, IdFacilidad,Convert.ToInt32(ObtenerMaxParto(IdHembra)), vivoss, muertoss, causamuerte, Fecha, true);
        }
        public static int ObtenerMaxIdParto()
        {
            int iResult = 1;
            long? lMax;
            PartoTableAdapter partos = new PartoTableAdapter();
            lMax = partos.ObtenerMaxId();
            if (lMax != null)
                if (lMax > 0)
                    iResult = Convert.ToInt32(lMax) + 1;

            return iResult;
        }
        public static int ObtenerMaxParto(int IdAnimal)
        {
            int iResult = 1;
            int lMax = -1;
            PartoTableAdapter partos = new PartoTableAdapter();
            lMax =Convert.ToInt32(partos.ObtenerMaxNumeroPartodeHembra(IdAnimal).ToString());
            if (lMax != -1)
                if (lMax > 0)
                    iResult = Convert.ToInt32(lMax) + 1;

            return iResult;
        }
        #region filtrar
        public static GexvocDataSet.PartoDataTable FiltrarPartos(int IdTipo, int IdDificultad, int IdHembra, int vivos, int Muertos, string Fdesde, string FHasta,int IdExplotacion)
        {           
            try
            {                
                StringBuilder sql = new StringBuilder();
                if (IdTipo != 0)
                {
                    sql.Append(String.Format(" AND IdTipo = '{0}' ", IdTipo));
                }
                if (IdDificultad != 0)
                {
                    sql.Append(String.Format(" AND IdFacilidad = '{0}' ", IdDificultad));
                }
                if (IdHembra != 0)
                {
                    sql.Append(String.Format(" AND Parto.IdHembra = '{0}' ", IdHembra));
                }
                if (vivos != 0)
                {
                    sql.Append(String.Format(" AND vivos = '{0}' ", vivos));
                }
                if (Muertos != 0)
                {
                    sql.Append(String.Format(" AND Muertos = '{0}' ", Muertos));
                }
                if (Fdesde!="")
                {   
                    sql.Append(String.Format(" AND Fecha > '{0}' ", Fdesde));
                }
                if (FHasta!="")
                {
                    sql.Append(String.Format(" AND Fecha < '{0}' ", FHasta));
                }
                GexvocDataSet.PartoDataTable filtro = new GexvocDataSet.PartoDataTable();
                PartosTA partoflitra = new PartosTA();
                partoflitra.FiltroPartos(filtro, sql.ToString(), IdExplotacion);
                return filtro;
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
            }
            return null;
        }

        public int FiltroPartos(GexvocDataSet.PartoDataTable dataTable, string whereExpression, int IdExplotacion)
        {
            
            string text1 = this.CommandCollection[0].CommandText;

            try
            {
                this.CommandCollection[0].CommandText += " " +
                "WHERE   (Parto.IdHembra IN" +
                          "(SELECT     Id " +
                            "FROM Animal WHERE IdExplotacion = " + IdExplotacion + "))";
                if (!(whereExpression == ""))
                {
                    this.CommandCollection[0].CommandText += " " + whereExpression;
                }

                return this.Fill(dataTable);
            }
            finally
            {
                this.CommandCollection[0].CommandText = text1;
            }
        }
        #endregion
    }
}

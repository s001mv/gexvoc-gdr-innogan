using System;
using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;


namespace GEXVOC.Core.Data
{
    public class CondicionCorporalTA : CondicionCorporalTableAdapter
    {
        public static GexvocDataSet.CondicionCorporalDataTable Obtener(int IdExplotacion)
        {
            CondicionCorporalTableAdapter Condiciones = new CondicionCorporalTableAdapter();
            return Condiciones.ObtenerCondicionesCorporales(IdExplotacion);
        }
        public static void InsertarNueva(int IdTipo, int IdHembra, DateTime Fecha)
        {
            CondicionCorporalTableAdapter Condiciones = new CondicionCorporalTableAdapter();
            Condiciones.Insertar(ObtenerMaxIdInseminacion(), IdTipo, IdHembra, Fecha);
        }
        public static int ObtenerMaxIdInseminacion()
        {
            int iResult = 1;
            long? lMax;
            CondicionCorporalTableAdapter Condiciones = new CondicionCorporalTableAdapter();
            lMax = Condiciones.ObtenerMaxId();
            if (lMax != null)
                if (lMax > 0)
                    iResult = Convert.ToInt32(lMax) + 1;

            return iResult;
        }
        #region filtrar
        public static GexvocDataSet.CondicionCorporalDataTable FiltrarCondiciones(int IdTipo,int IdHembra,string fecha,int IdExplotacion)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                if (IdTipo != 0)
                {
                    sql.Append(String.Format(" AND CondicionCorporal.IdTipo = '{0}' ", IdTipo));
                }
               
                if (IdHembra != 0)
                {
                    sql.Append(String.Format(" AND CondicionCorporal.IdHembra = '{0}' ", IdHembra));
                }
               
                if (fecha != "")
                {
                    sql.Append(String.Format(" AND Fecha = '{0}' ", fecha));
                }
              

                GexvocDataSet.CondicionCorporalDataTable filtro = new GexvocDataSet.CondicionCorporalDataTable();
                CondicionCorporalTA condicionfiltra = new CondicionCorporalTA();
                condicionfiltra.FiltroCondiciones(filtro, sql.ToString(), IdExplotacion);
                return filtro;
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
            }
            return null;
        }

        public int FiltroCondiciones(GexvocDataSet.CondicionCorporalDataTable dataTable, string whereExpression, int IdExplotacion)
        {

            string text1 = this.CommandCollection[0].CommandText;

            try
            {
                this.CommandCollection[0].CommandText += " " +
                "WHERE   (CondicionCorporal.IdHembra IN" +
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

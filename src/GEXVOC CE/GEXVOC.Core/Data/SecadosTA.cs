using System;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
   public class SecadosTA : SecadoTableAdapter
    {

       public static GexvocDataSet.SecadoDataTable ObtenerUltimoSecado(int IdHembra)
       {
           SecadoTableAdapter secados = new SecadoTableAdapter();
           return secados.ObtenerFechaUltimoSecado(IdHembra);
       }
       public static GexvocDataSet.SecadoDataTable ObtenerTodosSecados(int IdExplotacion)
       {
           SecadoTableAdapter secados = new SecadoTableAdapter();
           return secados.ObtenerSecados(IdExplotacion);
       }
       public static void  InsertarNueva(int? IdTipo,int? IdMotivo, int IdHembra,DateTime Fecha)
       {
           SecadoTableAdapter secados = new SecadoTableAdapter();
           secados.InsertarSecado(Convert.ToInt32(ObtenerMaxIdControl()), IdTipo, IdMotivo, IdHembra, Fecha, true);
       }
       public static int ObtenerMaxIdControl()
       {
           int iResult = 1;
           long? lMax;
           SecadoTableAdapter secados = new SecadoTableAdapter();
           lMax = secados.ObtenerMaxId();
           if (lMax != null)
               if (lMax > 0)
                   iResult = Convert.ToInt32(lMax) + 1;

           return iResult;
       }
       //#region filtrar
       //public static GexvocDataSet.SecadoDataTable FiltrarSecados(string FechaDesde, string FechaHasta, int Idmotivo,int IdTipo,int IdHembra, int IdExplotacion)
       //{
       //    try
       //    {
       //        StringBuilder sql = new StringBuilder();
       //        if (Fecha != "")
       //        {
       //            sql.Append(String.Format(" AND Control.Fecha = '{0}' ", Fecha));
       //        }
       //        if (IdControl != 0)
       //        {
       //            sql.Append(String.Format(" AND Control.IdControl = '{0}' ", IdControl));
       //        }
       //        if (IdestadoOrdeno != 0)
       //        {
       //            sql.Append(String.Format(" AND Control.IdOrdeno = '{0}' ", IdestadoOrdeno));
       //        }
       //        // sql.Append(String.Format(" AND Id NOT IN(Select IdAnimal FROM baja)"));

       //        GexvocDataSet.ControlDataTable filtro = new GexvocDataSet.ControlDataTable();
       //        LechesTA Leches = new LechesTA();
       //        Leches.FiltroLeches(filtro, sql.ToString(), IdExplotacion);
       //        return filtro;
       //    }
       //    catch (Exception ex)
       //    {
       //        Traza.Registrar(ex);
       //    }
       //    return null;
       //}

       //public int FiltroLeches(GexvocDataSet.ControlDataTable dataTable, string whereExpression, int IdExplotacion)
       //{
       //    string text1 = this.CommandCollection[0].CommandText;

       //    try
       //    {
       //        this.CommandCollection[0].CommandText += " " +
       //        "WHERE  (Animal.IdExplotacion=" + IdExplotacion + ") AND  (Animal.Id NOT IN" +
       //                  "(SELECT     IdAnimal " +
       //                    "FROM          Baja))";
       //        if (!(whereExpression == ""))
       //        {
       //            this.CommandCollection[0].CommandText += " " + whereExpression;
       //        }

       //        return this.Fill(dataTable);
       //    }
       //    finally
       //    {
       //        this.CommandCollection[0].CommandText = text1;
       //    }
       //}
       //#endregion
    }
}
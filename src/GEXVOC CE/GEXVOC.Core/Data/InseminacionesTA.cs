using System;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;


namespace GEXVOC.Core.Data
{
   public class InseminacionesTA : InseminacionTableAdapter
    {
       public static GexvocDataSet.InseminacionDataTable ObtenerTodasInseminaciones(int IdExplotacion)
       {
           InseminacionTableAdapter inseminaciones = new InseminacionTableAdapter();
           return inseminaciones.ObtenerTodasInseminaciones(IdExplotacion);           
       }
       public static GexvocDataSet.InseminacionDataTable ObtenerInseminacionesDiaIdVaca(DateTime fecha,int IdVaca)
       {
           InseminacionTableAdapter inseminaciones = new InseminacionTableAdapter();
           return inseminaciones.ObtenerIdSegunFechaVaca(fecha,IdVaca);
       }
       public static GexvocDataSet.InseminacionDataTable ObtenerInseminacionesDesdeFechaIddVaca(DateTime fecha, int IdVaca)
       {
           InseminacionTableAdapter inseminaciones = new InseminacionTableAdapter();
           return inseminaciones.ObtenerInseminacionPosteriorAfechaIdVaca(fecha, IdVaca);
       }
       public static GexvocDataSet.InseminacionDataTable ObtenerUltimaFechaInseminacionDeVaca(int IdVaca)
       {
           InseminacionTableAdapter inseminaciones = new InseminacionTableAdapter();
           return inseminaciones.ObtenerFechaUltimaInseminacionDeHembra(IdVaca);
       }
       public static void InsertarNueva(int IdMacho,int IdHembra,int IdTipo,int IdVeterinario,int IdEmbrion,string Dosis,DateTime Fecha)
       {
           int? Dosiis;
           if (Dosis != "")
               Dosiis = Convert.ToInt32(Dosis);
           else
               Dosiis = null;
           InseminacionTableAdapter inseminaciones = new InseminacionTableAdapter();
           inseminaciones.InsertarInseminacion(Convert.ToInt32(ObtenerMaxIdInseminacion()), IdMacho, IdHembra, IdTipo, IdVeterinario, IdEmbrion,Convert.ToInt32(ObtenerMaxInseminacion(IdHembra)), Dosiis, Fecha);
       }
       public static int ObtenerMaxInseminacion(int IdAnimal)
       {
           int iResult = 1;
           long? lMax;
           InseminacionTableAdapter inseminaciones = new InseminacionTableAdapter();
           lMax = inseminaciones.ObtenerMaxNumeroInseminacion(IdAnimal);
           if (lMax != null)
               if (lMax > 0)
                   iResult = Convert.ToInt32(lMax) + 1;

           return iResult;
       }
       public static int ObtenerMaxIdInseminacion()
       {
           int iResult = 1;
           long? lMax;
           InseminacionTableAdapter inseminaciones = new InseminacionTableAdapter();
           lMax = inseminaciones.ObtenerMaxIdInseminacion();
           if (lMax != null)
               if (lMax > 0)
                   iResult = Convert.ToInt32(lMax) + 1;

           return iResult;
       }
      

       #region filtrar
       public static GexvocDataSet.InseminacionDataTable FiltrarInseminaciones(DateTime Fecha, int IdHembra, int IdMacho,int IdTipo)
       {
           try
           {
               StringBuilder sql = new StringBuilder();
               //if (!Fecha.Equals(String.Empty))
               //{
               //    sql.Append(String.Format(" AND Fecha = '{0}' ", Fecha));
               //}
               if (IdHembra!=0)
               {
                   sql.Append(String.Format(" AND IdHembra = '{0}' ", IdHembra));
               }
               if (IdMacho!=0)
               {
                   sql.Append(String.Format(" AND IdMacho = '{0}' ", IdMacho));
               }
               if (IdTipo!=0)
               {
                   sql.Append(String.Format(" AND IdTipo = '{0}' ", IdTipo));
               }
               GexvocDataSet.InseminacionDataTable filtro = new GexvocDataSet.InseminacionDataTable();
               InseminacionesTA inseminacionesFiltra = new InseminacionesTA();
               inseminacionesFiltra.FiltroInseminaciones(filtro, sql.ToString());
               return filtro;
           }
           catch (Exception ex)
           {
               Traza.Registrar(ex);
           }
           return null;
       }

       public int FiltroInseminaciones(GexvocDataSet.InseminacionDataTable dataTable, string whereExpression)
       {
           string text1 = this.CommandCollection[0].CommandText;

           try
           {
               if (!(whereExpression == ""))
               {
                   if (this.CommandCollection[0].CommandText.IndexOf("WHERE") == -1)
                   {
                       //quitamos el AND al principio del whereExpression
                       if (whereExpression.IndexOf("AND") > -1)
                           whereExpression = whereExpression.Substring(" AND".Length);
                       this.CommandCollection[0].CommandText += " WHERE " + whereExpression;
                   }
                   else
                   {
                       this.CommandCollection[0].CommandText += " " + whereExpression;
                   }
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

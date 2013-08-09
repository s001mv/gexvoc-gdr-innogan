using System;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
   public class DiagnosticoInseminacionTA : DiagInseminacionTableAdapter
    {
       public static GexvocDataSet.DiagInseminacionDataTable ObtenerDiagnosticoInseminacionExplotacion(int IdExplo)
       {
           DiagInseminacionTableAdapter DiagInseminacion = new DiagInseminacionTableAdapter();
           return DiagInseminacion.ObtenerDiagnosticosPorExplotacion(IdExplo);
       }
       public static void Insertar_Nuevo(int IdTipo,int IdAnimal,DateTime Fecha,bool Resultado,int? DiasGestacion)
       {
           DiagInseminacionTableAdapter DiagInseminacion = new DiagInseminacionTableAdapter();
           DiagInseminacion.InsertarDiagnostico(Convert.ToInt32(ObtenerMaxIdDiagnostico()), IdTipo, IdAnimal, Fecha, Resultado, DiasGestacion);
       }
       public static int ObtenerMaxIdDiagnostico()
       {
           int iResult = 1;
           long? lMax;
           DiagInseminacionTableAdapter DiagInseminacion = new DiagInseminacionTableAdapter();
           lMax = DiagInseminacion.ObtenerMaxIdDiagnostico();
           if (lMax != null)
               if (lMax > 0)
                   iResult = Convert.ToInt32(lMax) + 1;

           return iResult;
       }
       #region filtrar
       public static GexvocDataSet.DiagInseminacionDataTable FiltrarDiagnosticos(int IdHembra,string fecha,int IdTipo,int IdExplotacion)
       {
           try
           {
               StringBuilder sql = new StringBuilder();

               if (fecha!="")
               {
                  // DateTime fechaa = Convert.ToDateTime(fecha);
                   sql.Append(String.Format(" AND Fecha = '{0}' ", fecha));
               }
               if (IdHembra != 0)
               {
                   sql.Append(String.Format(" AND IdAnimal = '{0}' ", IdHembra));
               }
               else if (IdTipo != 0)
               {
                   sql.Append(String.Format("AND IdTipo  = '{0}'", IdTipo));
               }
               // sql.Append(String.Format(" AND Id NOT IN(Select IdAnimal FROM baja)"));

               GexvocDataSet.DiagInseminacionDataTable filtro = new GexvocDataSet.DiagInseminacionDataTable();
               DiagnosticoInseminacionTA diagfiltra = new DiagnosticoInseminacionTA();
               diagfiltra.FiltroDiagnosticos(filtro, sql.ToString(), IdExplotacion);
               return filtro;
           }
           catch (Exception ex)
           {
               Traza.Registrar(ex);
           }
           return null;
       }

       public int FiltroDiagnosticos(GexvocDataSet.DiagInseminacionDataTable dataTable, string whereExpression, int IdExplotacion)
       {
           string text1 = this.CommandCollection[0].CommandText;

           try
           {
               this.CommandCollection[0].CommandText += " " +
                "WHERE   (DiagInseminacion.IdAnimal IN" +
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

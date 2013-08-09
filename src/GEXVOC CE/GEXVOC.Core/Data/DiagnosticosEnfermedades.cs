using System;
using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;


namespace GEXVOC.Core.Data
{
   public class DiagnosticosEnfermedades : DiagAnimalTableAdapter
    {
       public static GexvocDataSet.DiagAnimalDataTable ObtenerDiagnosticos(int IdExplotacion)
       {
           DiagAnimalTableAdapter diagnosticos = new DiagAnimalTableAdapter();
           return diagnosticos.ObTenerDiagnosticos(IdExplotacion);
       }
       public static GexvocDataSet.DiagAnimalDataTable ObtenerDiagnosticos2(int IdExplotacion)
       {
           DiagAnimalTableAdapter diagnosticos = new DiagAnimalTableAdapter();
           return diagnosticos.ObtenerDiagnosticosYTratamientos(IdExplotacion);
       }
       #region filtrar
       public static GexvocDataSet.DiagAnimalDataTable FiltrarDiagnosticos(int IdAnimal,int IdEnfermedad,string Fdesde,string FHasta, int IdExplotacion)
       {
           try
           {
               StringBuilder sql = new StringBuilder();
               if (IdAnimal != 0)
               {
                   sql.Append(String.Format(" AND DiagAnimal.IdAnimal = '{0}' ", IdAnimal));
               }
               if (IdEnfermedad != 0)
               {
                   sql.Append(String.Format(" AND DiagAnimal.IdEnfermedad = '{0}' ", IdEnfermedad));
               }              
               if (Fdesde != "")
               {
                   sql.Append(String.Format(" AND DiagAnimal.Fecha > '{0}' ", Fdesde));
               }
               if (FHasta != "")
               {
                   sql.Append(String.Format(" AND DiagAnimal.Fecha < '{0}' ", FHasta));
               }
               GexvocDataSet.DiagAnimalDataTable filtro = new GexvocDataSet.DiagAnimalDataTable();
               DiagnosticosEnfermedades filtrodiag = new DiagnosticosEnfermedades();
               filtrodiag.FiltroDiagn(filtro, sql.ToString(), IdExplotacion);
               return filtro;
           }
           catch (Exception ex)
           {
               Traza.Registrar(ex);
           }
           return null;
       }

       public int FiltroDiagn(GexvocDataSet.DiagAnimalDataTable dataTable, string whereExpression, int IdExplotacion)
       {

           string text1 = this.CommandCollection[0].CommandText;

           try
           {
               this.CommandCollection[0].CommandText += " " +
               "WHERE   DiagAnimal.IdAnimal IN" +
                         "(SELECT     Id " +
                           "FROM Animal WHERE IdExplotacion = " + IdExplotacion + ") AND  (Animal.Id NOT IN" +
                          "(SELECT     IdAnimal " +
                            "FROM          Baja))";
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
       public static void InsertarNueva(int IdAnimal,int? IdEnfermedad,int? IdVeterinario,string Diagnostico,DateTime  Fecha)
       {
           
           DiagAnimalTableAdapter diagnosticos = new DiagAnimalTableAdapter();                     
           diagnosticos.Insertar(ObtenerMaxIdDiagAnimal(),IdAnimal,IdEnfermedad,IdVeterinario,Diagnostico,Fecha,true);
           
           //diagnosticos.Insertar(ObtenerMaxIdDiagAnimal(),IdAnimal,IdEnfermedad,IdVeterinario,,true);           
       }
       public static int ObtenerMaxIdDiagAnimal()
       {
           int iResult = 1;
           long? lMax;
           DiagAnimalTableAdapter diagnosticos = new DiagAnimalTableAdapter();
           lMax = diagnosticos.ObtenerMaxId();
           if (lMax != null)
               if (lMax > 0)
                   iResult = Convert.ToInt32(lMax) + 1;

           return iResult;
       }
    }
}

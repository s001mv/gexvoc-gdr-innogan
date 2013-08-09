using System;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
   public class TratEnfermedadTA : TratEnfermedadTableAdapter
    {
       public static GexvocDataSet.TratEnfermedadDataTable ObtenerTratamientoss(int IdExplotacion)
       {
           TratEnfermedadTableAdapter tratamientos = new TratEnfermedadTableAdapter();
           return tratamientos.ObtenerTratamientos(IdExplotacion);
       }
       #region filtrar
       public static GexvocDataSet.TratEnfermedadDataTable FiltrarTratamientos(int IdAnimal,string Fdesde,string FHasta, int IdExplotacion)
       {
           try
           {
               StringBuilder sql = new StringBuilder();
             
               if (IdAnimal != 0)
               {
                   sql.Append(String.Format(" AND Animal.Id = '{0}' ", IdAnimal));
               }               
               if (Fdesde != "")
               {
                   sql.Append(String.Format(" AND  TratEnfermedad.Fecha > '{0}' ", Fdesde));
               }
               if (FHasta != "")
               {
                   sql.Append(String.Format(" AND TratEnfermedad.Fecha < '{0}' ", FHasta));
               }
               // sql.Append(String.Format(" AND Id NOT IN(Select IdAnimal FROM baja)"));

               GexvocDataSet.TratEnfermedadDataTable filtro = new GexvocDataSet.TratEnfermedadDataTable();
               TratEnfermedadTA tratfiltra = new TratEnfermedadTA();
               tratfiltra.FiltroTratamientos(filtro, sql.ToString(), IdExplotacion);
               return filtro;
           }
           catch (Exception ex)
           {
               Traza.Registrar(ex);
           }
           return null;
       }

       public int FiltroTratamientos(GexvocDataSet.TratEnfermedadDataTable dataTable, string whereExpression, int IdExplotacion)
       {
           string text1 = this.CommandCollection[0].CommandText;

           try
           {
               this.CommandCollection[0].CommandText += " " +
               "WHERE  (Animal.IdExplotacion=" + IdExplotacion + ") AND  (Animal.Id NOT IN" +
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
       public static void InsertarNueva(int IdDiagnostico,int personal,int? supresionLeche,int? supresioncarne,DateTime fecha,int duracion, string detalle)
       {
           TratEnfermedadTableAdapter tratamientos = new TratEnfermedadTableAdapter();
           tratamientos.Insertar(ObtenerMaxIdTratEnfermedad(), IdDiagnostico, personal, detalle, duracion, supresionLeche, supresioncarne, fecha, true);
           
           //diagnosticos.Insertar(ObtenerMaxIdDiagAnimal(), IdAnimal, IdEnfermedad, IdVeterinario, Diagnostico, Fecha, true);
       }
       public static int ObtenerMaxIdTratEnfermedad()
       {
           int iResult = 1;
           long? lMax;
           TratEnfermedadTableAdapter tratamientos = new TratEnfermedadTableAdapter();
           lMax = tratamientos.ObtenerMaxId();
           if (lMax != null)
               if (lMax > 0)
                   iResult = Convert.ToInt32(lMax) + 1;

           return iResult;
       }
    }
}

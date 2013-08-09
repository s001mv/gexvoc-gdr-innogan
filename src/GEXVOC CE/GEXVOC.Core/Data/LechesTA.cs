using System;
using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;


namespace GEXVOC.Core.Data
{
   public class LechesTA : ControlTableAdapter 
    {
       public static GexvocDataSet.ControlDataTable ObtenerControles(int IdExplotacion)
       {
           
           ControlTableAdapter Leches = new ControlTableAdapter();
           return Leches.ObtenerControlesLecheros(IdExplotacion);
       }
       public static int InsertarNueva(int IdControl,int IdOrdeno,int IdLactacion,DateTime Fecha,Decimal LecheManana,Decimal LecheTarde,Decimal LecheNoche)
        {
            ControlTableAdapter Leches = new ControlTableAdapter();
            Leches.InsertarControlLechero(ObtenerMaxIdControl(), IdLactacion, IdControl, IdOrdeno, ObtenerMaxNumeroControl(IdLactacion), Fecha, LecheManana, LecheTarde, LecheNoche,true);
            return ObtenerMaxIdControl();            
        }
       public static GexvocDataSet.ControlDataTable ObtenerUltimaFecha(int IdAnimal)
        {
            ControlTableAdapter controles = new ControlTableAdapter();
            return controles.ObtenerFechaUltimoControl(IdAnimal);
            
        }
       public static int ObtenerMaxIdControl()
        {
            int iResult = 1;
            long? lMax;
            ControlTableAdapter Lactaciones = new ControlTableAdapter();
            lMax = Lactaciones.ObtenerMaxId();
            if (lMax != null)
                if (lMax > 0)
                    iResult = Convert.ToInt32(lMax) + 1;

            return iResult;
        }
       public static int ObtenerMaxNumeroControl(int IdAnimal)
        {
            int iResult = 1;
            int lMax = -1;
            ControlTableAdapter Lactaciones = new ControlTableAdapter();
            if (Lactaciones.ObtenerMaxNumero(IdAnimal) != null)
            {
                lMax = Convert.ToInt32(Lactaciones.ObtenerMaxNumero(IdAnimal).ToString());
                if (lMax != -1)
                    if (lMax > 0)
                        iResult = Convert.ToInt32(lMax) + 1;
            }

                return iResult;
       

        }
       #region filtrar
       public static GexvocDataSet.ControlDataTable FiltrarLeches(string Fecha,int IdControl,int IdestadoOrdeno,int IdExplotacion)
       {
           try
           {
               StringBuilder sql = new StringBuilder();
               if (Fecha != "")
               {
                   sql.Append(String.Format(" AND Control.Fecha = '{0}' ", Fecha));
               }
               if (IdControl != 0)
               {
                   sql.Append(String.Format(" AND Control.IdControl = '{0}' ", IdControl));
               }
               if (IdestadoOrdeno != 0)
               {
                   sql.Append(String.Format(" AND Control.IdOrdeno = '{0}' ", IdestadoOrdeno));
               }
               // sql.Append(String.Format(" AND Id NOT IN(Select IdAnimal FROM baja)"));

               GexvocDataSet.ControlDataTable filtro = new GexvocDataSet.ControlDataTable();
               LechesTA Leches = new LechesTA();
               Leches.FiltroLeches(filtro, sql.ToString(), IdExplotacion);
               return filtro;
           }
           catch (Exception ex)
           {
               Traza.Registrar(ex);
           }
           return null;
       }

       public int FiltroLeches(GexvocDataSet.ControlDataTable dataTable, string whereExpression, int IdExplotacion)
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
    }
}

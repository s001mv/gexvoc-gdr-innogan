using System;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;
namespace GEXVOC.Core.Data
{
   public class LactacionTA : LactacionTableAdapter
    {
       public static GexvocDataSet.LactacionDataTable ObtenerLactaciones(DateTime Fecha, int IdHembra)
       {
           LactacionTableAdapter Lactaciones = new LactacionTableAdapter();
           return Lactaciones.ObtenerLactacionFechaIdAnimal(IdHembra);
       }

       public static int InsertarNueva(int IdHembra,DateTime FechaInicio)
       {
           
               LactacionTableAdapter Lactacion = new LactacionTableAdapter();
               int rtno = Convert.ToInt32(ObtenerMaxIdLactacion());
               Lactacion.InsertarLactacion(ObtenerMaxIdLactacion(), IdHembra, ObtenerMaxNumeroLactacion(IdHembra), FechaInicio, true);
               
               return rtno;
           
       }
       public static int ObtenerMaxIdLactacion()
       {
           int iResult = 1;
           long? lMax;
           LactacionTableAdapter Lactaciones = new LactacionTableAdapter();
           lMax = Lactaciones.ObtenerMaxId();
           if (lMax != null)
               if (lMax > 0)
                   iResult = Convert.ToInt32(lMax) + 1;

           return iResult;
       }
       public static int ObtenerMaxNumeroLactacion(int IdAnimal)
       {
           int iResult = 1;
           int lMax = -1;
           LactacionTableAdapter Lactaciones = new LactacionTableAdapter();

           if (Lactaciones.ObtenerMaxNumero(IdAnimal) != null)
           {
               lMax = Convert.ToInt32(Lactaciones.ObtenerMaxNumero(IdAnimal).ToString());
               if (lMax != -1)
                   if (lMax > 0)
                       iResult = Convert.ToInt32(lMax) + 1;
           }

           return iResult;
       }
       public static GexvocDataSet.LactacionDataTable ObtenerLactacionesAbiertas(int IdHembra)
       {
           LactacionTableAdapter Lactaciones = new LactacionTableAdapter();
           return Lactaciones.ObtenerLactacionesAbiertas(IdHembra);
       }
    }
}

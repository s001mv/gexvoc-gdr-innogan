using System;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;


namespace GEXVOC.Core.Data
{
   public class Parametrizacion : ConfiguracionTableAdapter
    {
       public static int ObtenerParametrizacionPorClave(string Clave)
       {
           int iResult;
           ConfiguracionTableAdapter parametro = new ConfiguracionTableAdapter();
           GexvocDataSet.ConfiguracionDataTable dt = new GexvocDataSet.ConfiguracionDataTable();
           dt = parametro.GetDataByClave(Clave);
           if (dt.Rows.Count > 0)
               iResult = Convert.ToInt32(dt.Rows[0]["Valor"]);
           else
               iResult = 0;
           return iResult;
       }

       public static string tipoAperturaLactacion()
       {
           int tipo;
           int iResult;
           ConfiguracionTableAdapter parametro = new ConfiguracionTableAdapter();
           GexvocDataSet.ConfiguracionDataTable dt = new GexvocDataSet.ConfiguracionDataTable();
           dt = parametro.GetDataByClave("TipoAperturaLactacion");

           iResult = Convert.ToInt32(dt.Rows[0]["Valor"]);
           tipo = iResult;
           if (tipo == 1)
               return "Lactacion";
           else if (tipo == 0)
               return "Parto";
           return "error";
              
       }
    }
}

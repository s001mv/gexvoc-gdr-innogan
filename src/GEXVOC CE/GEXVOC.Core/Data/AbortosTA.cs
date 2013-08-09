using System;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;
namespace GEXVOC.Core.Data
{
   public class AbortosTA :AbortoTableAdapter
    {
       public static GexvocDataSet.AbortoDataTable ObtenerAbortosDesdeFechaIdVaca(DateTime Fecha, int IdVaca)
       {
           AbortoTableAdapter abortos = new AbortoTableAdapter();
           return abortos.ObtenerAbortoDesdeFechaIdVaca(Fecha, IdVaca);
       }
       public static GexvocDataSet.AbortoDataTable ObtenerUltimoAborto(int IdHembra)
       {
           AbortoTableAdapter abortos = new AbortoTableAdapter();
           return abortos.ObtenerFechaUltimoAborto(IdHembra);
       }
    }
}

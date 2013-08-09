using System;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;


namespace GEXVOC.Core.Data
{
   public class AniLotTa :AniLotTableAdapter
    {
       public static GexvocDataSet.AniLotDataTable ObtenerAnimalesSegunLote(int IdLote)
       {
           AniLotTableAdapter aniLote = new AniLotTableAdapter();
           return aniLote.ObtenerAnimalesDeLote(IdLote);
       }
    }
}

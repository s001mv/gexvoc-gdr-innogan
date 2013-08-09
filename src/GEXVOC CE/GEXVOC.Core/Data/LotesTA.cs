using System;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
   public class LotesTA : LoteAnimalTableAdapter
    {
       public static GexvocDataSet.LoteAnimalDataTable ObtenerLotes()
       {
           LoteAnimalTableAdapter lotes = new LoteAnimalTableAdapter();
           return lotes.GetData();
       }
    }
}

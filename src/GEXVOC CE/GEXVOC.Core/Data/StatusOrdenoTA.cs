using System;
using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
   public class StatusOrdenoTA : StatusOrdenoTableAdapter
    {
       public static GexvocDataSet.StatusOrdenoDataTable ObtenerStatusOrdeno()
       {
           StatusOrdenoTableAdapter statusordeno = new StatusOrdenoTableAdapter();
           return statusordeno.GetData();
       }
    }
}

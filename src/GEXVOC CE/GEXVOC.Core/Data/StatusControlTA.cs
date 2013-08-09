using System;
using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
   public class StatusControlTA : StatusControlTableAdapter
    {
       public static GexvocDataSet.StatusControlDataTable ObtenerStatusOrdeno()
       {
           StatusControlTableAdapter statuscontrol = new StatusControlTableAdapter();
           return statuscontrol.GetData();
       }
    }
}

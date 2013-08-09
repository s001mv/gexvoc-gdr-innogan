using System;

using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;


namespace GEXVOC.Core.Data
{
   public class MomentoTA : MomentoTableAdapter
    {
       public static GexvocDataSet.MomentoDataTable Obtenermomentos()
       {
           MomentoTableAdapter momentos = new MomentoTableAdapter();
           return momentos.GetData();
       }
    }
}

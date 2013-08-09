using System;

using System.Collections.Generic;
using System.Text;

using GEXVOC.Core.Data.GexvocDataSetTableAdapters;

namespace GEXVOC.Core.Data
{
    public class EspecieTA : EspecieTableAdapter
    {
        public static GexvocDataSet.EspecieDataTable ObtenerEspecies()
        {
            EspecieTableAdapter especies = new EspecieTableAdapter();
            return especies.GetData();
        }
    }
}

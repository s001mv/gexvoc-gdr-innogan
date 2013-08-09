using System;

using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;

namespace GEXVOC.Core.Data
{
    public class TallaTA : TallaTableAdapter
    {
        public static GexvocDataSet.TallaDataTable ObtenerTallas()
        {
            TallaTableAdapter tallas = new TallaTableAdapter();
            return tallas.GetData();
        }
    }
}

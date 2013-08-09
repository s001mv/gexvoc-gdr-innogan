using System;

using System.Collections.Generic;
using System.Text;

using GEXVOC.Core.Data.GexvocDataSetTableAdapters;

namespace GEXVOC.Core.Data
{
    public class ConformacionActualTAcs : ConformacionTableAdapter
    {
        public static GexvocDataSet.ConformacionDataTable ObtenerConformaciones()
        {
            ConformacionTableAdapter conformaciones = new ConformacionTableAdapter();
            return conformaciones.GetData();
        }
    }
}

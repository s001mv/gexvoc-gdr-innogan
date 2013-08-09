using System;
using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoInseminacionTA : TipoInseminacionTableAdapter
    {
        public static GexvocDataSet.TipoInseminacionDataTable ObtenerTiposInseminaciones()
        {
            TipoInseminacionTableAdapter TiposInseminaciones = new TipoInseminacionTableAdapter();
            return TiposInseminaciones.GetData();
        }
    }
}

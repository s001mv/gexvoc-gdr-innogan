using System;
using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;
namespace GEXVOC.Core.Data
{
    public class FacilidadTA: FacilidadTableAdapter
    {
        public static GexvocDataSet.FacilidadDataTable ObtenerFacilidades()
        {
            FacilidadTableAdapter Facilidades = new FacilidadTableAdapter();
            return Facilidades.GetData();
        }
    }
}
 
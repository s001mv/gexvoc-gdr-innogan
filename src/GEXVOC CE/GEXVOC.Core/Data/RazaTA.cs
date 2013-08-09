using System;

using System.Collections.Generic;
using System.Text;

using GEXVOC.Core.Data.GexvocDataSetTableAdapters;

namespace GEXVOC.Core.Data
{
    public class RazaTA : RazaTableAdapter
    {
        public static GexvocDataSet.RazaDataTable ObtenerRazas()
        {
            RazaTableAdapter razas = new RazaTableAdapter();
            return razas.GetData();
        }
        public static GexvocDataSet.RazaDataTable ObtenerRazasPorEspecie(int IdEspecie)
        {
            RazaTableAdapter razas = new RazaTableAdapter();
            return razas.GetDataByEspecie(IdEspecie);
        }
    }
}

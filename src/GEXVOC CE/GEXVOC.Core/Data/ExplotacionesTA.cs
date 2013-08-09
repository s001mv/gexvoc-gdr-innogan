using System;
using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;


namespace GEXVOC.Core.Data
{
    public class ExplotacionesTA : ExplotacionTableAdapter
    {
        public static GexvocDataSet.ExplotacionDataTable ObtenerTodasExplotaciones()
        {
            ExplotacionTableAdapter explotaciones = new ExplotacionTableAdapter();
            return explotaciones.GetData();
        }
    }
}

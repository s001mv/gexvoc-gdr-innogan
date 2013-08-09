using System;

using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;

namespace GEXVOC.Core.Data
{
    public class EstadoTA : EstadoTableAdapter
    {
        public static GexvocDataSet.EstadoDataTable ObtenerEstados()
        {
            EstadoTableAdapter estados = new EstadoTableAdapter();
            return estados.GetData();
        }
    }
}

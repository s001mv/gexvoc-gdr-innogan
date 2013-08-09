using System;
using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;


namespace GEXVOC.Core.Data
{
    public class TipoCubricionTA : TipoCubricionTableAdapter
    {
        public static GexvocDataSet.TipoCubricionDataTable ObtenerTipos()
        {
            TipoCubricionTableAdapter TiposCubriciones = new TipoCubricionTableAdapter();
            return TiposCubriciones.GetData();
        }
    }
}

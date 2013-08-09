using System;

using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;

namespace GEXVOC.Core.Data
{
    public class TipoAltaTA : TipoAltaTableAdapter
    {
        public static GexvocDataSet.TipoAltaDataTable ObtenerTiposDeAlta()
        {
            TipoAltaTableAdapter TiposAltas = new TipoAltaTableAdapter();
            return TiposAltas.GetData();
        }
    }
}

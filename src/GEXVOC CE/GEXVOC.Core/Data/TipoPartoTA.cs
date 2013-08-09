using System;
using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoPartoTA : TipoPartoTableAdapter
    {
        public static GexvocDataSet.TipoPartoDataTable ObtenerTiposPartos()
        {
            TipoPartoTableAdapter TiposPartos = new TipoPartoTableAdapter();
            return TiposPartos.GetData();
        }
        public static GexvocDataSet.TipoPartoDataTable ObtenerCriasPartosPorTipo(int IdTipo)
        {
            TipoPartoTableAdapter TiposPartos = new TipoPartoTableAdapter();
            return TiposPartos.ObtenerCriasPorTipo(IdTipo);
        }
    }
}

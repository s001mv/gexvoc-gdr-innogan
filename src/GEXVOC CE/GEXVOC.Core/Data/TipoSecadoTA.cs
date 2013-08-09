using System;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;
namespace GEXVOC.Core.Data
{
    public class TipoSecadoTA :TipoSecadoTableAdapter
    {
        public static GexvocDataSet.TipoSecadoDataTable ObtenerTiposSecados()
        {
            TipoSecadoTableAdapter TiposSecados = new TipoSecadoTableAdapter();
            return TiposSecados.GetData();
        }
    }
}

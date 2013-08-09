using System;
using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;
using System.Globalization;
namespace GEXVOC.Core.Data
{
    public class TiposCondicionesCorporales : TipoCondicionTableAdapter
    {
        public static GexvocDataSet.TipoCondicionDataTable ObtenerTipos(int IdEspecie)
        {
            TipoCondicionTableAdapter TipoCondiciones = new TipoCondicionTableAdapter();
            return TipoCondiciones.GetByEspecie(IdEspecie);
        }
    }
}

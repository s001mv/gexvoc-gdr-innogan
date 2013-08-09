using System;

using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;

namespace GEXVOC.Core.Data
{
   public class TipoBaja : TipoBajaTableAdapter
    {
       public static GexvocDataSet.TipoBajaDataTable ObtenerTiposDebaja()
       {
           TipoBajaTableAdapter TiposBaja = new TipoBajaTableAdapter();
           return TiposBaja.GetData();
       }
    }
}

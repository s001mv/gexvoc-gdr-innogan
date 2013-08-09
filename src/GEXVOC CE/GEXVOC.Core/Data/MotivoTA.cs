using System;

using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;

namespace GEXVOC.Core.Data
{
  public  class MotivoTA :MotivoTableAdapter
    {
      public static GexvocDataSet.MotivoDataTable ObtenerMotivos()
      {
          MotivoTableAdapter Motivo = new MotivoTableAdapter();
          return Motivo.GetData();
      }
    }
}

using System;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
   public class TipoDiagnosticoTA :TipoDiagnosticoTableAdapter
    {
       public static GexvocDataSet.TipoDiagnosticoDataTable ObtenerTiposDiagnosticos()
       {
           TipoDiagnosticoTableAdapter TiposDiagnosticos = new TipoDiagnosticoTableAdapter();
           return TiposDiagnosticos.GetData();
       }
    }
}

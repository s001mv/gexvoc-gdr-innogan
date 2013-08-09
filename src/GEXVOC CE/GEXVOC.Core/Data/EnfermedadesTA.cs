using System;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
   public class EnfermedadesTA : EnfermedadTableAdapter
    {
       public static GexvocDataSet.EnfermedadDataTable ObtenerTodasEnfermedades()
       {
           EnfermedadTableAdapter enfermedades = new EnfermedadTableAdapter();
           return enfermedades.ObtenerEnfermedades();
       }
    }
}

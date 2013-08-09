using System;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
   public class VeterinarioTA : VeterinarioTableAdapter
    {
       public static GexvocDataSet.VeterinarioDataTable ObtenerVeterinarios(int IdExplotacion)
       {
           VeterinarioTableAdapter Veterinarios = new VeterinarioTableAdapter();
           return Veterinarios.ObtenerInseminadores(IdExplotacion);
       }
    }
}

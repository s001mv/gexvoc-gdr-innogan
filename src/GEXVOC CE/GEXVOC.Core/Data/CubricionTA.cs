using System;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;
namespace GEXVOC.Core.Data
{
   public class CubricionTA : CubricionTableAdapter
    {
        public static GexvocDataSet.CubricionDataTable ObtenerCubricionIdVaca(int IdVaca)
        {
            CubricionTableAdapter cubriciones = new CubricionTableAdapter();
            return cubriciones.ObtenerFechasCubricionesIdVaca(IdVaca);
        }
        public static GexvocDataSet.CubricionDataTable ObtenerTodasCubriciones()
        {
            CubricionTableAdapter cubriciones = new CubricionTableAdapter();
            return cubriciones.ObtenerCubriciones();
        }
        public static  GexvocDataSet.CubricionDataTable ObtenerCubricionesAbiertas(int IdVaca)
        {
            CubricionTableAdapter cubriciones = new CubricionTableAdapter();
            return cubriciones.ObtenerCubiricionesAbiertas(IdVaca);   
        }
        public static void InsertarNueva(int Idlote,int Tipo,DateTime FechaIni,DateTime? FechaFin)
        {
            CubricionTableAdapter cubriciones = new CubricionTableAdapter();
            cubriciones.Insertar(ObtenerMaxIdInseminacion(), Tipo, Idlote, FechaIni, FechaFin, true);
        }
        public static int ObtenerMaxIdInseminacion()
        {
            int iResult = 1;
            long? lMax;
            CubricionTableAdapter cubriciones = new CubricionTableAdapter();
            lMax = cubriciones.ObtenerMaxId();
            if (lMax != null)
                if (lMax > 0)
                    iResult = Convert.ToInt32(lMax) + 1;

            return iResult;
        }
    }
}

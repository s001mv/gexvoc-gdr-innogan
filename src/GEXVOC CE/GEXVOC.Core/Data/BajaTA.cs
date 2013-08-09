using System;
using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;
using GEXVOC.Core.Logic;


namespace GEXVOC.Core.Data
{
    public class BajaTA : BajaTableAdapter
    {
        public static void InsertarBaja(int IdTipo,int IdAnimal,string Detalle, DateTime Fecha)
        {
            try
            {
                BajaTableAdapter bajas = new BajaTableAdapter();
                bajas.InsertarBaja(Convert.ToInt32(CalcularMaxId()), IdTipo, IdAnimal, Detalle, Fecha);
            }
            catch (Exception ex)
            {
                Traza.Registrar(ex);
            }
        }
        public static int? CalcularMaxId()
        {
            BajaTableAdapter bajas = new BajaTableAdapter();
            int? MaxId = bajas.ObtenerMaxId();
            MaxId = MaxId + 1;
            return MaxId;
        }
    }
}

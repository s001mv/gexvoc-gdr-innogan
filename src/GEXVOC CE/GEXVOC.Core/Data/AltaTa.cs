using System;
using System.Collections.Generic;
using System.Text;
using GEXVOC.Core.Data.GexvocDataSetTableAdapters;

namespace GEXVOC.Core.Data
{
    public class AltaTa :AltaTableAdapter
    {
        public static int? ObtenerMaxId()
        {
            AltaTableAdapter altas = new AltaTableAdapter();
            int? MaxId = altas.ObtenerMaxId();
            MaxId = MaxId + 1;
            return MaxId;
        }
        public static void InsertarAltaNueva(int IdTipo,int IdAnimal,string Detalle,DateTime Fecha)
        {
            AltaTableAdapter altas = new AltaTableAdapter();
            altas.InsertarAlta(Convert.ToInt32(ObtenerMaxId()),IdTipo, IdAnimal, Detalle, Fecha);
        }
    }
}

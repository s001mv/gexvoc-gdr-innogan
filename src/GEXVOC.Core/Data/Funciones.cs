using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data.Linq;

namespace GEXVOC.Core.Data
{
    public class Funciones
    {
        public static void DescubrirPropiedades(IQueryable Consulta)
        {
            DescubrirPropiedades(Consulta, "Desc");

        }
        public static void DescubrirPropiedades(IQueryable Consulta,string prefijo)
        {
            try
            {
                foreach (object obj in Consulta)
                    if (obj != null)
                        foreach (System.Reflection.PropertyInfo item in obj.GetType().GetProperties().Where(e => e.Name.StartsWith(prefijo)))
                            item.GetValue(obj, null);
            }
            catch (Exception) { }

        }
        public static void DescubrirPropiedades(object obj,string prefijo)
        {
            try
            {                
                    if (obj != null)
                        foreach (System.Reflection.PropertyInfo item in obj.GetType().GetProperties().Where(e => e.Name.StartsWith(prefijo)))
                            item.GetValue(obj, null);
            }
            catch (Exception) { }

        }
        public static void DescubrirPropiedades(object obj)
        {
            DescubrirPropiedades(obj, "Desc");
        }      
    }
}

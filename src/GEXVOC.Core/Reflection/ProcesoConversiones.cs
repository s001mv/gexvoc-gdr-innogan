
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Globalization;
using System.Reflection;


namespace GEXVOC.Core.Reflection
{
    public static class ProcesoConversiones
    {
        public static ProcesoDescripcion GetProceso(this PropertyInfo value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            ProcesoDescripcion proceso = null;           
            ProcesoDescripcion[] attributes = (ProcesoDescripcion[])value.GetCustomAttributes( typeof(ProcesoDescripcion), false);

            if (attributes != null && attributes.Length > 0)
            {
                proceso = attributes[0];
            }            
            return proceso;
        }

       

    }
}

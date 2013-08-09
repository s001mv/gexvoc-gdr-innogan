using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Globalization;
using System.Reflection;


namespace GEXVOC.Core.Reflection
{
    public static class EnumConversiones
    {
        public static string GetDescripcion(this Enum value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            string description= value.ToString().Replace("_"," ");//por defecto la descripcion vale el detalle de la enumeracion quitandole los caracteres '_'
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            EnumDescription[] attributes=null;
            if (fieldInfo != null)            
               attributes  = (EnumDescription[])fieldInfo.GetCustomAttributes(typeof(EnumDescription), false);
            
           
            if (attributes != null && attributes.Length > 0)            
                description = attributes[0].Descripcion;
            
            return description;
        }

        /// <summary>
        /// Convierte una enumeración en una lista.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static IList ToList<T>(this Type tipo)
        {
            if (tipo == null)            
                throw new ArgumentNullException("tipo");            

            if (!tipo.IsEnum)            
                throw new ArgumentException("Debe proporcionar un tipo de enumeración", "tipo");
            

            ArrayList list = new ArrayList();
            Array enumValues = Enum.GetValues(tipo);

            foreach (Enum value in enumValues)
            {
                list.Add(new KeyValuePair<T, string>((T)Convert.ChangeType(value, typeof(T), CultureInfo.InvariantCulture), GetDescripcion(value)));
            }

            return list;
        }


      

    }
}

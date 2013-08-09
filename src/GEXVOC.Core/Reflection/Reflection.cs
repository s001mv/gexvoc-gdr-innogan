using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;

namespace GEXVOC.Core.Reflection
{
    public static class Reflection
    {

        /// <summary>
        /// Asigna a las propiedades del objeto, los valores contenidos en un stringDictionary, donde
        /// 'Keys' representan los nombres de las propiedades y 'values' los valores.
        /// Los nombres de las propiedades no dintinguirán entre mayúsculas y minúsculas.
        /// </summary>
        /// <param name="strDefControl"></param>
        public static void AsignarValoresAPropiedades(StringDictionary strDefControl, object obj)
        {
            ///Obtengo la lista de las propiedades, ya que en el dictionary vienen en minúsculas
            ///utilizo una lista generica para hacer las busquedas con sintaxis linq.
            List<System.Reflection.PropertyInfo> lstPropiedades = new List<System.Reflection.PropertyInfo>();
            lstPropiedades = obj.GetType().GetProperties().ToList();

            foreach (string item in strDefControl.Keys)
            {
                ///Busco la propiedad con el nombre en la lista
                System.Reflection.PropertyInfo Propiedad = lstPropiedades.SingleOrDefault(E => E.Name.ToLower() == item);

                ///Si encontramos la propiedad
                if (Propiedad != null)
                {



                    try
                    {
                        ///Variable que representa el valor que será asignado a la propiedad
                        ///La utilizamos para realizar operaciones del tipo casting.
                        object valor = null;
                        ///Convertimos el string en int o int?
                        if (Propiedad.PropertyType == typeof(int) || Propiedad.PropertyType == typeof(int?))
                        {
                            int? ValorCast = int.Parse(strDefControl[item]);
                            valor = ValorCast;
                        }
                        ///Convertimos el string en datetime o datetime?
                        if (Propiedad.PropertyType == typeof(DateTime) || Propiedad.PropertyType == typeof(DateTime?))
                        {
                            DateTime? ValorCast = DateTime.Parse(strDefControl[item]);
                            valor = ValorCast;
                        }
                        ///Convertimos el string en decimal o decimal? 
                        ///Ojo: Cambiamos los "." por ","
                        if (Propiedad.PropertyType == typeof(decimal) || Propiedad.PropertyType == typeof(decimal?))
                        {
                            decimal? ValorCast = decimal.Parse(strDefControl[item].Replace(".", ","));
                            valor = ValorCast;
                        }
                        /////Convertimos el string en bool o bool?
                        if (Propiedad.PropertyType == typeof(bool) || Propiedad.PropertyType == typeof(bool?))
                        {
                            bool? ValorCast = bool.Parse(strDefControl[item]);
                            valor = ValorCast;
                        }
                        ///Si no hemos realizado ninguna operacion de cast asignamos el valor por defecto que es el string.
                        if (valor == null)
                            valor = strDefControl[item];

                        ///Asignamos el valor a la propiedad.
                        Propiedad.SetValue(obj, valor, null);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error asignando el valor: " + strDefControl[item] + " a la propiedad: " + Propiedad.Name + ".Detalle: " + ex.Message);
                    }

                }
            }
        }
              

    }
}

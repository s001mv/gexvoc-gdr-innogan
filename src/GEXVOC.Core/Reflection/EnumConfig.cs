
using System;
using System.Diagnostics;
using System.Collections.Generic;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Reflection
{
    /// <summary>
    /// Atributo que se puede especificar a cada uno de los valores de una enumeración
    /// Esto nos vale por ejemplo para personalizar las descripciones de cada uno de los valores.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class EnumConfig : Attribute
    {
      
        public List<KeyValuePair<string, object>> Valores = new    List<KeyValuePair<string,object>>();
        public System.Type TipoClaseBase { get; set; }

        /// <summary>
        /// Establece el detalle (descripcion) para el atributo
        /// este detalle es utilizado para mostrar al usuario final valores claramente reconocibles.
        /// </summary>
        /// <param name="descripcion">cadena de detalle</param>
        public EnumConfig(string[] nombres, object[] valores, System.Type tipoClaseBase)
        {
            
            if (nombres.Length!=valores.Length)                 
                throw new ArgumentNullException("nombres");


            TipoClaseBase = tipoClaseBase;
            valoresOriginales = valores;
            for (int i = 0; i < nombres.Length; i++)            
                Valores.Add(new KeyValuePair<string,object>((string)nombres.GetValue(i), valores[i]));                
            
            
        }
        object[] valoresOriginales = null;


        //public void CrearPersistencia()
        //{
        //    try
        //    {
        //        object claseBase = this.GetType().Assembly.CreateInstance(this.TipoClaseBase.FullName);
        //        if (claseBase != null)
        //        {
        //            foreach (KeyValuePair<string, object> item in Valores)
        //            {
        //                System.Reflection.PropertyInfo Propiedad = claseBase.GetType().GetProperty(item.Key);
        //                if (Propiedad != null)
        //                    Propiedad.SetValue(claseBase, item.Value, null);
        //            }
        //            ((IClaseBase)claseBase).Insertar();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Traza.RegistrarError(ex);
        //    }

        //}
    }
}
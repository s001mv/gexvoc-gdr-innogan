using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEXVOC.Core.Logic
{
    public partial class ControlesMuestras
    {
        //public static string nombreAnimal = string.Empty;
        //public static string nombreCrotal = string.Empty;
        //public static ControlLeche control = null;
        ////public static int? idControl = null;
        ////public static decimal? manana = null;
        ////public static decimal? tarde = null;
        ////public static decimal? noche = null;

        
        //public static void CargarDatosControles(DateTime? fechaControl)
        //{
        //    foreach (Animal animal in Configuracion.Explotacion.lstAnimales)
        //    {
        //        if (animal != null)
        //        {
                    
        //            Lactacion lactacion = Lactacion.BuscarLactacionAbierta(animal.Id);
        //            Parto partos = null;
        //            Secado secados = null;
                    
        //            if (animal.lstPartos.Count > 0)
        //                partos = (Parto)animal.lstPartos[animal.lstPartos.Count - 1];
        //            if (animal.lstSecados.Count > 0)
        //                secados = (Secado)animal.lstSecados[animal.lstSecados.Count - 1];


        //            if (partos != null && partos.Fecha <= fechaControl && (secados == null || partos.Fecha > secados.Fecha))
        //            {
        //                nombreAnimal = animal.Crotal;
        //                nombreCrotal = animal.Crotal;
        //                if (lactacion != null && fechaControl >= ((ControlLeche)lactacion.lstControlesLeche[0]).Fecha)
        //                {
                            
        //                    foreach (ControlLeche C in lactacion.lstControlesLeche)
        //                        if (C.Fecha == fechaControl)
        //                        {
        //                            control = C;
        //                            break;
        //                        }

        //                    control = null;
        //                }
        //                lactacion = null; 
        //            }
                    
        //        }
                
        //    }
        //}
    }
}

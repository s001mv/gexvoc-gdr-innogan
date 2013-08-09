using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEXVOC.Core.Logic
{
    public abstract class ClaseBase:Notificable//,IClaseBase
    {

        //public abstract void Insertar();
        //public abstract void Actualizar();
        //public abstract void Eliminar();
        //public abstract ClaseBase Buscar(int id);

        

        //public abstract IClaseBase CargarContextoOperacion(TipoContexto Modo);

        ////public abstract int Id
        ////{
        ////    get;
        ////    set;
        ////}

     

        //public virtual int[] Clave
        //{ 
        //    get
        //    {                
        //        int[] rtno={Id};
        //        return rtno;         
        //    }
         
        //}

        //public void EliminarForaneas(List<IClaseBase> lstForaneas)
        //{
        //    MensajeNotificarVarios = string.Empty;
        //    foreach (IClaseBase item in lstForaneas)
        //    {
        //        if (item.GetType().GetInterface(typeof(INotificable).Name)!=null)
        //            ((INotificable)item).Notificar += NotificarVarios;
                
        //        item.Eliminar();                
        //    }
        //    if (!string.IsNullOrEmpty(MensajeNotificarVarios))            
        //        MensajeNotificar = new ResultadoOperacion() { Mensaje = MensajeNotificarVarios, OperacionCorrecta = true };       
        
        //}


        //public string MensajeNotificarVarios = string.Empty;
        //public void NotificarVarios(object sender, NotificableEventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(e.Mensaje.Mensaje))
        //        MensajeNotificarVarios += e.Mensaje.Mensaje + "\r";
        //}
    }
}

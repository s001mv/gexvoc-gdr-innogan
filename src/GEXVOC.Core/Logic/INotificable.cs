using System;
namespace GEXVOC.Core.Logic
{
    public interface INotificable
    {
        event EventHandler<NotificableEventArgs> Notificar;
        ResultadoOperacion MensajeNotificar { get; set; }
    }
}

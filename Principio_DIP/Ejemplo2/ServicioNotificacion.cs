using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    public class ServicioNotificacion
    {
        private readonly INotificador _notificador;

        public ServicioNotificacion(INotificador notificador)
        {
            _notificador = notificador;
        }

        public void NotificarUsuario(string mensaje)
        {
            _notificador.EnviarMensaje(mensaje);
        }
    }
}

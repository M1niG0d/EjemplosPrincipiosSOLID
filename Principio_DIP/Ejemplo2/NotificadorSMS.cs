using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    public class NotificadorSMS : INotificador
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine($" Enviando SMS: {mensaje}");
        }
    }
}

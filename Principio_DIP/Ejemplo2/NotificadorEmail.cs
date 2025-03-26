using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    public class NotificadorEmail : INotificador
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine($" Enviando Email: {mensaje}");
        }
    }
}

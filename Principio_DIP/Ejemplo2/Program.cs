using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            INotificador notificadorEmail = new NotificadorEmail();
            INotificador notificadorSMS = new NotificadorSMS();

            ServicioNotificacion servicio1 = new ServicioNotificacion(notificadorEmail);
            servicio1.NotificarUsuario("Hola, este es un mensaje por Email!");

            ServicioNotificacion servicio2 = new ServicioNotificacion(notificadorSMS);
            servicio2.NotificarUsuario("Hola, este es un mensaje por SMS!");

            Console.ReadLine();
        }
    }
}

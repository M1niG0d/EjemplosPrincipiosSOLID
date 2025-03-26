using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    public class Recepcionista : IAtencion, ICitas
    {
        public void AtenderPaciente()
        {
            Console.WriteLine(" Recepcionista atendiendo al paciente en la entrada.");
        }

        public void AgendarCita()
        {
            Console.WriteLine(" Recepcionista agendando cita.");
        }
    }
}

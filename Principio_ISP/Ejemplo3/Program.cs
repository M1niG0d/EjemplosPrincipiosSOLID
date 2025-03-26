using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    public class Program
    {
        static void Main(string[] args)
        {
            IAtencion recepcionista = new Recepcionista();
            recepcionista.AtenderPaciente();

            ICitas agenda = new Recepcionista();
            agenda.AgendarCita();

            IAtencion doctor = new Doctor();
            doctor.AtenderPaciente();

            ICirugia cirujano = new Doctor();
            cirujano.RealizarCirugia();

            Console.ReadLine();
        }
    }
}

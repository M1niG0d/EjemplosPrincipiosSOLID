using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    public class Doctor : IAtencion, ICirugia
    {
        public void AtenderPaciente()
        {
            Console.WriteLine(" Doctor atendiendo al paciente.");
        }

        public void RealizarCirugia()
        {
            Console.WriteLine(" Doctor realizando cirugía.");
        }
    }
}

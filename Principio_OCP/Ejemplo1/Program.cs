using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var reportes = new List<SalarioBase>
            {
                new SalarioRepartidor (new Reporte { Nombre = "Juan", Puesto = "Repartidor", CostoPorHora = 40, HorasTrabajadas = 50}),
                new SalarioRecepcion (new Reporte { Nombre = "Maria", Puesto = "Recepcion", CostoPorHora = 20, HorasTrabajadas = 60}),
                new SalarioDesarrollador (new Reporte { Nombre = "Daniel", Puesto = "Desarrollador", CostoPorHora = 10, HorasTrabajadas = 5})
            };

            var calculadora = new Calculadora(reportes);
            var total = calculadora.Calcular();
            Console.WriteLine("El total a pagar esta quincena es " + total);

            Console.ReadKey();
        }
    }
}

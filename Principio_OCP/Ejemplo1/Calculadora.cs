using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    public class Calculadora
    {
        private IEnumerable<SalarioBase> Salarios { get; }
        public Calculadora(IEnumerable<SalarioBase> salarios)
        {
            Salarios = salarios;
        }

        public double Calcular()
        {
            double total = 0;
            foreach (var salario in Salarios)
                total += salario.Calcular();
            return total;
        }

    }
}

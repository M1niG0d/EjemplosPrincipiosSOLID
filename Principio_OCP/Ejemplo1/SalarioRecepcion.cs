using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    public class SalarioRecepcion : SalarioBase
    {
        public SalarioRecepcion(Reporte reporte) : base(reporte)
        {

        }

        public override double Calcular()
        {
            return (Reporte.CostoPorHora * Reporte.HorasTrabajadas) * 1.2;
        }
    }
}

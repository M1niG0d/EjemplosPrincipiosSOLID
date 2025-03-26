using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    public class SalarioBase
    {
        protected Reporte Reporte { get; }
        public SalarioBase(Reporte reporte)
        {
            Reporte = Reporte;
        }
        public virtual double Calcular()
        { 
            return Reporte.CostoPorHora * Reporte.HorasTrabajadas;
        }
    }
}

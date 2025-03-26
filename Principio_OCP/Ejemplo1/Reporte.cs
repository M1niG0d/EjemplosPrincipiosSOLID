using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    public class Reporte
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public int HorasTrabajadas { get; set; }
        public int CostoPorHora { get; set;  }
    }
}

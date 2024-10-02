using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClases
{
    public class Coche
    {
       public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public double Consumo { get; set; }
        public int Cilindrada { get; set; }
        public int NumeroPuertas { get; set; }
        public int NumeroRuedas { get; set; }
        public int NumeroAsientos { get; set; }
        public Motor Motor { get; set; }
    }
}

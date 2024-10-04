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
        public string Consumo { get; set; }
        public string Cilindrada { get; set; }
        public string NumeroPuertas { get; set; }
        public string NumeroRuedas { get; set; }
        public string NumeroAsientos { get; set; }
        public Motor Motor { get; set; }
    }
}

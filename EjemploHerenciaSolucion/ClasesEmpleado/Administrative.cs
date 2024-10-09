using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClasesEmpleado
{
    public class Administrative : Worker
    {
        public Administrative(string nombre, int años) : base(nombre, años)
        {
        }

        public override string ToString()
        {
            return $"Administrative: {Nombre} ({Años} años)";
        }
    }
}
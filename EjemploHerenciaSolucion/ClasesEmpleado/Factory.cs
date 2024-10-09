using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesEmpleado
{
    public class Factory : Worker
    {
        public Factory(string nombre, int años)
        : base(nombre, años)
        { }
        public override string ToString()
        {
            return $"Factory: {Nombre} ({Años} años)";
        }
    }
}
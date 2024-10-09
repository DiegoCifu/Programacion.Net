using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesEmpleado
{
    public class MiddleMgmt : Manager
    {
        public MiddleMgmt(string nombre, int años) : base(nombre, años)
        {
        }

        public override string ToString()
        {
            return $"Middle Management: {Nombre} ({Años} años)";
        }
    }
}
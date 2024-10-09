using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesEmpleado
{
    public class SeniorMgmt : Manager
    {
        public SeniorMgmt(string nombre, int años) : base(nombre, años)
        {
        }

        public override string ToString()
        {
            return $"Senior Management: {Nombre} ({Años} años)";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEmpleado
{
    public class Employee
    {

        // Propiedad Nombre
        public string Nombre { get; set; }

        // Propiedad Años en la empresa
        public int Años { get; set; }

        public int CompanyId
        {
            set; get;
        }

        public int Id
        {
            get; set;
        }

        // Constructor que recibe el nombre y los años
        public Employee(string nombre, int años)
        {
            Nombre = nombre;
            Años = años;
        }
    }
}

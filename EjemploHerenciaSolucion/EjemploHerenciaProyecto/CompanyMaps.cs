using ClasesEmpleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerenciaProyecto
{
    public class CompanyMap : ClassMap<Company>
    {
        public CompanyMap()
        {
            // Define el mapeo para que los campos se escriban en minúsculas
            Map(m => m.Name).Name("name");
            Map(m => m.Id).Name("id");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClasesEmpleado
{
    public class Company
    {

        public Company(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public string Name
        {
            get; set;
        }

        public int Id
        {
            get; set;
        }

        public override string ToString()
        {
            return $"Company: {Id}-{Name} ";
        }
    }
}

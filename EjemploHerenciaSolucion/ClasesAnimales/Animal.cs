using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesAnimales
{
    public class Animal
    {
        //Propiedades
        public string Nombre { get; set; }
        public int Edad { get; set; }
    
    // Constructor
    public Animal(string nombre, int edad) {
        Nombre = nombre;
        Edad = edad;
        }
    }

}
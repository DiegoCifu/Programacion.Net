using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBook
{
    // La clase abstracta Fiction hereda de la clase Book.
    // Al ser abstracta, no se puede instanciar directamente.
    public abstract class Fiction : Book
    {
        // Constructor de la clase Fiction que recibe el título, el autor y el número de páginas del libro.
        // Utiliza el constructor de la clase base (Book) para inicializar estos valores.
        public Fiction(string title, string author, int pages)
            : base(title, author, pages)
        {
        }
    }
}

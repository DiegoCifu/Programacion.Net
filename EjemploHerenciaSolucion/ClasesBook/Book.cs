using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBook
{
    // La clase Book es abstracta, lo que significa que no se puede instanciar directamente.
    // Debe ser heredada por otras clases que implementen sus métodos abstractos.
    public abstract class Book
    {
        // Propiedad que representa el título del libro.
        public string Title { get; set; }

        // Propiedad que representa el autor del libro.
        public string Author { get; set; }

        // Propiedad que representa el número de páginas del libro.
        public int Pages { get; set; }

        // Constructor de la clase Book que inicializa las propiedades Title, Author y Pages.
        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        // Método abstracto que debe ser implementado por las clases derivadas.
        // Este método se utilizará para mostrar la información del libro.
        public abstract void DisplayInfo();
    }
}

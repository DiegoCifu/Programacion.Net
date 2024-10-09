using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBook
{
    public class Popular : Fiction
    {
        public Popular(string title, string author, int pages) 
            : base(title, author, pages)
        {
        }
        public override void DisplayInfo()
        {
            Console.Write($"Popular Fiction Book: {Title}, by {Author}, {Pages} pages.");
        }

    }
}

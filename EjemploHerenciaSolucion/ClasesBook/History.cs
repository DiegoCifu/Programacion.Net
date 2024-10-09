using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBook
{
    public class History : NoFiction
    {
        public History(string title, string author, int pages)
            : base(title, author, pages)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"History Book: {Title}, by {Author}, {Pages} pages.");
        }
    }
}

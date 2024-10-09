using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBook
{
    public class Science : NoFiction
    {
        public Science(string title, string author, int pages)
            : base(title, author, pages)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Science Book: {Title}, by {Author}, {Pages} pages.");
        }
    }
}
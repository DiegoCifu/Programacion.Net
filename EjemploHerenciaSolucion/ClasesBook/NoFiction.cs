using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBook
{
    public class NoFiction : Book
    {
        public NoFiction(string title, string author, int pages)
            : base(title, author, pages)
        {
        }
    }
}

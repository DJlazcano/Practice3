using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.ExceptionsC
{
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException() { }

        public BookNotFoundException(string message)
            : base(message) { }
    }
}

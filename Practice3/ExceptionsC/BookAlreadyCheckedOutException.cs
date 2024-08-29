using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.ExceptionsC
{
    public class BookAlreadyCheckedOutException : Exception
    {
        public BookAlreadyCheckedOutException() { }

        public BookAlreadyCheckedOutException(string message)
            : base(message) { }
    }
}

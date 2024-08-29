using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.ExceptionsC
{
    public class BookNotCheckedOutException : Exception
    {
        public BookNotCheckedOutException() { }

        public BookNotCheckedOutException(string message)
            : base(message) { }
    }
}

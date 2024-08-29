using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.LBClasses
{
    public class Book
    {
        public string Title { get; set; }
        public int ISBN { get; set; }
        public bool IsCheckedOut { get; set; }

        public Book(string title, int iSBN, bool isCheckedOut = false)
        {
            Title = title;
            ISBN = iSBN;
            IsCheckedOut = isCheckedOut;
        }
    }
}

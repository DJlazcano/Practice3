using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.LBClasses
{
    public class Library
    {
        public List<Book> books = new List<Book>();

        public void AddBook(Book b)
        {
            books.Add(b);
        }

        public void RemoveBook(int isbn)
        {
            Book tempBook = books.Find(b => b.ISBN == isbn);
            books.Remove(tempBook);
            Console.WriteLine($"\nBook {tempBook.Title} removed.\n");
        }
    }
}

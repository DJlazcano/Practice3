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

        public void CheckOutBook(int isbn)
        {
            int bookIndex = books.FindIndex(b => b.ISBN == isbn);
            books[bookIndex].IsCheckedOut = true;

            Console.WriteLine($"\n {books[bookIndex]} has been CheckOut.\n");
        }

        public void ReturnBook(int isbn)
        {
            int bookIndex = books.FindIndex(b => b.ISBN == isbn);
            
            books[bookIndex].IsCheckedOut = false;

            Console.WriteLine($"\n {books[bookIndex]} has been Returned.\n");
        }

        public void ListBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}

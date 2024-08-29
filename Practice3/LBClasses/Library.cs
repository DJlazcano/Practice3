using Practice3.ExceptionsC;
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
            try
            {
                Book tempBook = books.Find(b => b.ISBN == isbn);
                books.Remove(tempBook);
               //Console.WriteLine($"\nBook {tempBook.Title} removed.\n");
            }
            catch (BookNotFoundException ex)
            {

                throw new BookNotFoundException($"Book with ISBN: {isbn} not found"); ;
            }

        }

        public void CheckOutBook(int isbn)
        {
            try
            {
                int bookIndex = books.FindIndex(b => b.ISBN == isbn);

                if (books[bookIndex].IsCheckedOut)
                {
                    throw new BookAlreadyCheckedOutException($"The book {(books[bookIndex].Title)} is already checked out");
                }

                books[bookIndex].IsCheckedOut = true;
                Console.WriteLine($"\n {books[bookIndex]} has been CheckOut.\n");

            }
            catch (BookAlreadyCheckedOutException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (BookNotFoundException ex)
            {
                throw new BookNotFoundException($"Book with ISBN: {isbn} not found");
            }
        }

        public void ReturnBook(int isbn)
        {
            try
            {
                int bookIndex = books.FindIndex(b => b.ISBN == isbn);

                if (books[bookIndex].IsCheckedOut == false)
                {
                    throw new BookNotCheckedOutException($"The book {(books[bookIndex].Title)} has Not Been checked out");
                }
                books[bookIndex].IsCheckedOut = false;

                Console.WriteLine($"\n {books[bookIndex]} has been Returned.\n");
            }
            catch (BookNotCheckedOutException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (BookNotFoundException ex)
            {
                throw new BookNotFoundException($"Book with ISBN: {isbn} not found");
            }
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

using Practice3.LBClasses;

namespace Practice3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice 3\n");

            Library library = new Library();
            Book book = new Book("Dracula", 56099, true);

            //Adding books to collection
            library.AddBook(book);
            library.AddBook(new Book("Harry Potter", 1234, false));
            library.AddBook(new Book("Game of Thrones", 54583, false));
            library.AddBook(new Book("Androids", 4321, false));

            Console.WriteLine("Books List:");
            //Listing books
            library.ListBooks();
            
            //Removing Books by ISBN
            library.RemoveBook(1234);

            //CheckOut Book by ISBN
            library.CheckOutBook(4321);

            //Return Book by ISBN
            library.ReturnBook(56099);

            //List Books after alterations
            Console.WriteLine("Books List After:");
            library.ListBooks();

            //Causing Exceptions (Test)
            Console.WriteLine("\nCausing Exceptions:\n");
            
            //Removing None existing book Exception
            library.RemoveBook(1);

            library.AddBook(new Book("House of Dragons", 54444, false));
            library.AddBook(new Book("Horses", 3456, true));

            //Returning a Not Checked Out book Exception
            library.ReturnBook(54444);

            //Checking Out an already CheckedOut Book Exception
            library.CheckOutBook(3456);
        }
    }
}

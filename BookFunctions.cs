using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace HanterarEnSamlingBooks
{
    internal class BookFunctions
    {
        public List<Book> books = new List<Book>();
        public BookFunctions(List<Book> Librarybooks)
        {
            books = Librarybooks;
        }

        public void AddBook()
        {
            Console.WriteLine("Please Enter the book title that you want to add:\n");

            string title = Console.ReadLine()!;

            Console.WriteLine("Excellent, new enter the author's name:\n");

            string author = Console.ReadLine()!;

            Console.WriteLine("Great, new Enter the year Published:\n");

            string yearPublished= Console.ReadLine()!;

            books.Add(new Book(title, author, yearPublished));

            Console.WriteLine($"The book {title} has been successfully enterd ");

        }

        public void serchBok() 
        {
            Console.WriteLine("Enter the name of the book you are looking for ");

            string titleToSearch = Console.ReadLine()!;

            Book foundBook = books.Find(book => book.Title.Equals(titleToSearch, StringComparison.OrdinalIgnoreCase))!;

            if (foundBook != null)
            {
                Console.WriteLine($"Book found: {foundBook.Title}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }

        }

        public void DisplayAllBooks()
        {
            if (!books.Any())
            {
                Console.WriteLine("There are no books in the library\n");
                return;
            }

            Console.WriteLine("This is a list of all the books in the library ");
            foreach (Book book in books)
            {
                Console.WriteLine('\n');
                book.VisabokInfo();
            }
        }
    }
}
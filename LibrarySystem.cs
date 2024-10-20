using static System.Reflection.Metadata.BlobBuilder;

namespace HanterarEnSamlingBooks
{
    internal class LibrarySystem
    {

        public BookFunctions BookCore { get; set; }

        public List<Book> Books { get; set; }

        public LibrarySystem() 
        {
            Books = new List<Book>();
            BookCore = new BookFunctions(Books); 
        }

        public void AddBook() 
        {
            BookCore.AddBook();
        }

        public void serchBok(string title) 
        
        {
            BookCore.serchBok();
        }

        public void DisplayAllBooks()
        {
            BookCore.DisplayAllBooks();
        }
    }
}

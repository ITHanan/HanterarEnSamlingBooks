

namespace HanterarEnSamlingBooks
{
    internal class DisplayUserLibrarySysteminteraction
    {
        LibrarySystem books = new LibrarySystem();

        public DisplayUserLibrarySysteminteraction(LibrarySystem bok)
        {
            this.books = bok;
        }

        public void DisplayMenu()
        {

            Console.WriteLine("\n------ Library Menu ------");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Search Book");
            Console.WriteLine("3. Display All Books");
            Console.WriteLine("4. Exit");

        }

        public void RunSystem() 
        { 
          bool running = true;

            while (running)
            { 
               DisplayMenu();
               string usreInput = Console.ReadLine()!;

                switch (usreInput) 
                {

                    case "1":
                        books.AddBook();
                        break;
                    case "2":
                        Console.WriteLine("Enter the title of the book you want to search:");
                        string titleToSearch = Console.ReadLine()!;
                        books.serchBok(titleToSearch);
                        break;

                        case "3":
                        books.DisplayAllBooks();
                        break;

                    case "4":
                        Console.WriteLine("Exit...");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again!");
                        break;

                }
            
            
            }
        
        
        
        }

    }
}

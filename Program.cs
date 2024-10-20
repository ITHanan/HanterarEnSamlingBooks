namespace HanterarEnSamlingBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");

            LibrarySystem books = new LibrarySystem();
            DisplayUserLibrarySysteminteraction displayMenu = new DisplayUserLibrarySysteminteraction(books);
            displayMenu.RunSystem();
        }
    }
}

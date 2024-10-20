namespace HanterarEnSamlingBooks
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string YearPublished { get; set; }

        public Book(String title ,string author, string yearPublished)
        {
            Title=title;
            Author=author;
            YearPublished=yearPublished;
        }

        public void VisabokInfo() 
        {
            Console.WriteLine($"Title : {Title}\nAouthor: {Author}\nYear of Publied{YearPublished}");
        }
    }
}

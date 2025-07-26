class Book : Tracker
{
    private int _pageCount;
    private int _volume;
    private string _seriesCheck;
    private List<Book> books = new List<Book>();
    public Book()
    {}
    public Book(string name, string author, string desc, string genre, int pageCount)
    {
        _name = name;
        _author = author;
        _desc = desc;
        _genre = genre;
        _pageCount = pageCount;
        _volume = 0;
        _isCompleted = false;
    }
    public override void CreateEntry()
    {
        Console.WriteLine("What is the name of the book?");
        _name = Console.ReadLine();
        Console.WriteLine("Who is the author?");
        _author = Console.ReadLine();
        Console.WriteLine("What is the genre?");
        _genre = Console.ReadLine();
        Console.WriteLine("Give a brief description of the book");
        _desc = Console.ReadLine();
        Console.WriteLine("How many pages is the book?");
        _pageCount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Is this book apart of a series?");
        _seriesCheck = Console.ReadLine();
        if (_seriesCheck == "yes")
        {
            Console.WriteLine("Which volume is this book?");
            _volume = Convert.ToInt32(Console.ReadLine());
        }

        Book newBook = new Book(_name, _author, _desc, _genre, _pageCount);
        books.Add(newBook);

    }
    public override void DisplayList()
    {
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {_name}");
            Console.Write($"Author: {_author}  ");
            Console.WriteLine($"Genre: {_genre}");
            if (_volume != 0)
            {
                Console.Write($"Volume Number: {_volume}  ");
            }
            Console.WriteLine($"Page Count: {_pageCount}");
            Console.WriteLine($"Description: {_desc}");
            if (_isCompleted == true)
            {
                Console.WriteLine("Completed: [X]");
            }
            else
            {
                Console.WriteLine("Completed: [ ]");
            }
            Console.WriteLine();
        }
    }
}
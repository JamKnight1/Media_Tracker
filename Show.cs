class Show : Tracker
{
    private int _seasonCount;
    private int _avgEpisodeCount;
    public Show()
    {}
    public Show(string name, string author, string genre, string desc, int seasonCount, int avgEpisodeCount)
    {
        _name = name;
        _author = author;
        _genre = genre;
        _desc = desc;
        _seasonCount = seasonCount;
        _avgEpisodeCount = avgEpisodeCount;
        _isCompleted = false;
    }
    
  public override void CreateEntry()
    {
        Console.WriteLine("What is the name of the show?");
        _name = Console.ReadLine();
        Console.WriteLine("Who is the show's creator(s)?");
        _author = Console.ReadLine();
        Console.WriteLine("What is the genre of the show?");
        _genre = Console.ReadLine();
        Console.WriteLine("Give a brief description of the show.");
        _desc = Console.ReadLine();
        Console.WriteLine("How many seasons does the show have?");
        _seasonCount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the typical episode count per season?");
        _avgEpisodeCount = Convert.ToInt32(Console.ReadLine());

    }
    public override void DisplayList()
    {
        
            Console.WriteLine($"Title: {_name}"); 
            Console.Write($"Show Creator: {_author}  ");
            Console.WriteLine($"Genre: {_genre}");
            Console.Write($"Season Count: {_seasonCount}  ");
            Console.WriteLine($"Average Episode Count: {_avgEpisodeCount}");
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
    public override void MarkComplete()
    {
        base.MarkComplete();
    }
}
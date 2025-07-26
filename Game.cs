public class Game : Tracker
{
    private string _platform;
    private bool _multiplayer;
    private string _developer;
    private string _multiCheck;
    private int _gReleaseYear;
    private List<Game> games = new List<Game>();

    public Game()
    {
    }

    public Game(string name, string developer, string desc, string genre, string platform, int releaseYear)
    {
        _name = name;
        _developer = developer;
        _desc = desc;
        _genre = genre;
        _isCompleted = false;
        _platform = platform;
        _multiplayer = false;
        _gReleaseYear = releaseYear;
        
    }
    public override void CreateEntry()
    {
        Console.WriteLine("What is the name of the game?");
        _name = Console.ReadLine();
        Console.WriteLine("Who was the main developer?");
        _developer = Console.ReadLine();
        Console.WriteLine("What is the genre of the game?");
        _genre = Console.ReadLine();
        Console.WriteLine("What platform did you play it on?");
        _platform = Console.ReadLine();
        Console.WriteLine("Give a brief description of the game.");
        _desc = Console.ReadLine();
        Console.WriteLine("What year was this game released?");
        _gReleaseYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Is this game multiplayer focused?");
        _multiCheck = Console.ReadLine();
        if (_multiCheck == "yes")
        {
            _multiplayer = true;
        }
        Game newGame = new Game(_name, _developer, _desc, _genre, _platform, _gReleaseYear);
        games.Add(newGame);
    }
    public override void MarkComplete()
    {

    }

    public override void DisplayList()
    {
        foreach (var game in games)
        {
            Console.WriteLine($"Title: {_name}");
            Console.Write($"Developer: {_developer}  ");
            Console.WriteLine($"Genre: {_genre}");
            Console.Write($"Release Year: {_gReleaseYear}  ");
            Console.WriteLine($"Platorm: {_platform}");
            Console.WriteLine($"Description: {_desc}");
            if (_multiplayer == true)
            {
                Console.Write("Multiplayer: [X]  ");
            }
            else
            {
                Console.Write("Multiplayer: [ ]  ");
            }
            if (_isCompleted == true)
            {
                Console.Write("Completed: [X]  ");
            }
            else
            {
                Console.Write("Completed: [ ]  ");
            }
            Console.WriteLine();
        }
    }

}
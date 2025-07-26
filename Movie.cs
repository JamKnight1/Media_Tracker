class Movie : Tracker
{
    private int _runTime;
    private int _releaseYear;
    private List<Movie> movies = new List<Movie>();
    public Movie()
    {}
    
    public Movie(string name, string author, string desc, string genre, int runTime, int releaseYear)
    {
        _name = name;
        _author = author;
        _desc = desc;
        _genre = genre;
        _runTime = runTime;
        _releaseYear = releaseYear;
        _isCompleted = false;
    }

  public override void CreateEntry()
    {
        Console.WriteLine("What is the name of the movie?");
        _name = Console.ReadLine();
        Console.WriteLine("Who is the director?");
        _author = Console.ReadLine();
        Console.WriteLine("What is the genre of the film?");
        _genre = Console.ReadLine();
        Console.WriteLine("What year was the film released?");
        _releaseYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How long is the movie (in minutes)?");
        _runTime = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Give a brief description of the movie.");
        _desc = Console.ReadLine();

        Movie newMovie = new Movie(_name, _author, _desc, _genre, _runTime, _releaseYear);
        movies.Add(newMovie);
    }
    public override void DisplayList()
    {
        foreach (var movie in movies)
        {
            Console.WriteLine($"Title: {_name}");
            Console.Write($"Director: {_author}  ");
            Console.WriteLine($"Genre: {_genre}");
            Console.Write($"Release Year: {_releaseYear}  ");
            Console.WriteLine($"Run Time: {_runTime}");
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
using System;
using System.Data;

class Program
{
    private static string userChoice;
    private static string typeChoice;
    private static string completeChoice;
    static List<Tracker> entries = new List<Tracker>();
    static List<Review> reviews = new List<Review>();
    static List<WatchLater> recommendations = new List<WatchLater>();
    static List<Show> shows = new List<Show>();
    static List<Movie> movies = new List<Movie>();
    static List<Book> books = new List<Book>();
    static List<Game> games = new List<Game>();
    static void Main(string[] args)
    {
        

        while (userChoice != "9")
        {
            WatchLater w = new WatchLater();
            Review r = new Review();
            Game g = new Game();
            Book b = new Book();
            Movie m = new Movie();
            Show s = new Show();
            
            
            Console.WriteLine("Welcome to your Media List!");
            Console.WriteLine("Please select an option: ");

            Console.WriteLine("1. Create an Entry");
            Console.WriteLine("2. Complete an Entry");
            Console.WriteLine("3. Display List");
            Console.WriteLine("4. Write a Review");
            Console.WriteLine("5. View a Review");
            Console.WriteLine("6. Save a Recommendation");
            Console.WriteLine("7. View Recommendation List");
            Console.WriteLine("8. Delete Recommendation");
            Console.WriteLine("9. Quit");

            userChoice = Console.ReadLine();

            switch(userChoice)
            {
                case "1":
                    Console.WriteLine("What type of media do you want to add?");

                    Console.WriteLine("1. Book");
                    Console.WriteLine("2. Game");
                    Console.WriteLine("3. Movie");
                    Console.WriteLine("4. Show");

                    typeChoice = Console.ReadLine();

                    switch(typeChoice)
                    {
                        case "1":
                            b.CreateEntry();
                            entries.Add(b);
                            break;
                        case "2":
                            g.CreateEntry();
                            entries.Add(g);
                            break;
                        case "3":
                            m.CreateEntry();
                            entries.Add(m);
                            break;
                        case "4":
                            s.CreateEntry();
                            entries.Add(s);
                            break;
                        case "default":
                        Console.WriteLine("Please choose a valid option");
                        break;
                    }
                    break;
                case "2":
                    Console.WriteLine("What is the type of entry finished?");
                    Console.WriteLine("1. Book");
                    Console.WriteLine("2. Game");
                    Console.WriteLine("3. Movie");
                    Console.WriteLine("4. Show");

                    completeChoice = Console.ReadLine();
                    
                    switch(completeChoice)
                    {
                        case "1":
                            b.MarkComplete();
                            break;
                        case "2":
                            g.MarkComplete();
                            break;
                        case "3":
                            m.MarkComplete();
                            break;
                        case "4":
                            s.MarkComplete();
                            break;
                        case "default":
                        Console.WriteLine("Please choose a valid option");
                        break;
                    }
                    break;
                case "3":
                   Tracker.DisplayAll(entries);
                    break;

                case "4":
                    r.WriteReview(reviews);
                    break;
                case "5":
                    r.DisplayReview(reviews);
                    break;
                case "6":
                    w.CreateRecommendation(recommendations);
                    break;
                case "7":
                    w.DisplayRecommendations(recommendations);
                    break;
                case "8":
                    w.RemoveRecommendation(recommendations);
                    break;
                case "9":
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;
                case "default":
                    Console.WriteLine("Sorry, that's not an option");
                    break;
            }
        }

    }
}
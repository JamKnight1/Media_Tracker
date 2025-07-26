class WatchLater
{
    private string _wName;
    private string _wType;
    private string _friend;
    private string _remove;

    public WatchLater()
    {

    }
    public WatchLater(string name, string type, string friend)
    {
        _wName = name;
        _wType = type;
        _friend = friend;
    }
   
    public void CreateRecommendation(List<WatchLater> recommendations)
    {
        Console.WriteLine("What is the name of the recommendation?");
        _wName = Console.ReadLine();
        Console.WriteLine("What is the type of recommendation?");
        _wType = Console.ReadLine();
        Console.WriteLine("Who gave the recommendation?");
        _friend = Console.ReadLine();

        WatchLater newRecommend = new WatchLater(_wName, _wType, _friend);
        recommendations.Add(newRecommend);
    }
    public void RemoveRecommendation(List<WatchLater> recommendations)
    {
        Console.WriteLine("What is the name of the recommendation you've finished?");
        _remove = Console.ReadLine();

        WatchLater removeRecommendation = recommendations.FirstOrDefault(r => r._wName.Equals(_remove, StringComparison.OrdinalIgnoreCase));
        if (removeRecommendation != null)
        {
          
            recommendations.Remove(removeRecommendation);
            Console.WriteLine($"{_remove} has been removed");
        }
        else
        {
            Console.WriteLine($"There is no recommendation with the name {_remove}");
        }

    }
    public void DisplayRecommendations(List<WatchLater> recommendations)
    {
        foreach (var recommendation in recommendations)
        {
            Console.WriteLine($"Title: {recommendation._wName}");
            Console.WriteLine($"Media Type: {recommendation._wType}");
            Console.WriteLine($"Who recommended it: {recommendation._friend}");
            Console.WriteLine();
        }
    }
}
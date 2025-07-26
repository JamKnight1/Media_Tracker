public abstract class Tracker
{
    protected string _name;
    protected string _author;
    protected string _desc;
    protected string _genre;
    protected bool _isCompleted = false;
    private string _userComplete;
    
    
    public abstract void CreateEntry();
    public virtual void MarkComplete()
    {   
        Console.WriteLine("What is the entry you finished?");
        _userComplete = Console.ReadLine();

        if (_userComplete == _name)
        {
            _isCompleted = true;
            Console.WriteLine("Nice job finishing!");
        }
        else
        {
            Console.WriteLine("That title is not listed or is already finished");
        }

    }
    
    public abstract void DisplayList();
    public static void DisplayAll(List<Tracker> items)
    {
        foreach (var item in items)
        {
            item.DisplayList();
            Console.WriteLine();
        }
    }
}
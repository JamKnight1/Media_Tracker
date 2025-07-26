using System.Diagnostics.Contracts;

class Review
{
    private string _rName;
    private string _review;
    private int _score;
    private string _reviewChoice;

    public Review()
    {}

    public Review(string rName, int score, string review)
    {
        _rName = rName;
        _score = score;
        _review = review;
    }
    public void WriteReview(List<Review> reviews)
    {
        Console.WriteLine("What is the title of the item being reviewed?");
        _rName = Console.ReadLine();
        Console.WriteLine("What rating would you give it?(Out of 10)");
        _score = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is your review?");
        _review = Console.ReadLine();

        Review newReview = new Review(_rName, _score, _review);
        reviews.Add(newReview);

    }
    public void DisplayReview(List<Review> reviews)
    {
        Console.WriteLine("What is the review you are looking for?");
        _reviewChoice = Console.ReadLine();

        bool found = false;

        foreach (var review in reviews)
        {
            if (review._rName.Equals(_reviewChoice, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Title: {review._rName}");
                Console.WriteLine($"Rating: {review._score}/10");
                Console.WriteLine(review._review);
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("Review not found.");
        }
    }

}
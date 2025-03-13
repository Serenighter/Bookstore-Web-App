namespace BookstoreApp.Core.Entities;

public class ReviewDb
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Rating { get; set; }
    public string Description { get; set; }
    public IEnumerable<BookDb> Books { get; set; }

    public ReviewDb() { }

    public ReviewDb(string title, int rating, string description)
    {
        Title = title;
        Rating = rating;
        Description = description;
    }
}

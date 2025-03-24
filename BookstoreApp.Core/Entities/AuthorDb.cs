namespace BookstoreApp.Core.Entities;

public class AuthorDb
{
    public int Id { get; set; }
    public string Name { get; set; }
    //public int BookId { get; set; }
    public List<AuthorBookDb> AuthorBooks { get; set; } = new List<AuthorBookDb>();
    //public BookDb Book { get; set; }

    public AuthorDb() { }

    public AuthorDb(string name)
    {
        Name = name;
    }
}

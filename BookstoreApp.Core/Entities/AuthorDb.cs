namespace BookstoreApp.Core.Entities;

public class AuthorDb
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<AuthorBookDb> AuthorBooks { get; set; } = new List<AuthorBookDb>();

    public AuthorDb() { }

    public AuthorDb(string name)
    {
        Name = name;
    }
}

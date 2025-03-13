namespace BookstoreApp.Core.Entities;

public class AuthorDb
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<BookDb> Books { get; set; }

    public AuthorDb() { }

    public AuthorDb(string name)
    {
        Name = name;
    }
}

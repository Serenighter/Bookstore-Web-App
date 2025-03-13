namespace BookstoreApp.Core.Entities;
public class EditionDb
{
    public int Id { get; set; }
    public string EditionName { get; set; }
    public IEnumerable<BookDb> Books { get; set; }

    public EditionDb()
    {
    }
    public EditionDb(string editionname)
    {
        EditionName = editionname;
    }
}
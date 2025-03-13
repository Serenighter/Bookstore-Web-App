namespace BookstoreApp.Core.Entities;

public class LanguageDb
{
    public int Id { get; set; }
    public string LanguageName { get; set; }
    public IEnumerable<BookDb> Books { get; set; }

    public LanguageDb() 
    {
    }
    public LanguageDb(string name) 
    {
        LanguageName = name;
    }

}

namespace BookstoreApp.Core.Entities;

public class BookDb
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public int CategoryId { get; set; }
    public int PublisherId { get; set; }
    public int EditionId { get; set; }
    public int LanguageId { get; set; }
    public int ClientId { get; set; }
    public CategoryDb Category { get; set; }
    public PublisherDb Publisher { get; set; }
    public EditionDb Edition { get; set; }
    public LanguageDb Language { get; set; }
    public ClientDb Client { get; set; }

    public IEnumerable<AuthorDb> Authors { get; set; }

    public BookDb()
    {

    }

    public BookDb(string title, string author, int categoryId, int publisherId, int editionId, int languageId, int clientId)
    {
        Title = title;
        Author = author;
        CategoryId = categoryId;
        PublisherId = publisherId;
        EditionId = editionId;
        LanguageId = languageId;
        ClientId = clientId;
    }
}
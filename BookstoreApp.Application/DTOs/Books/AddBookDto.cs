namespace BookstoreApp.Application.DTOs.Books;

public class AddBookDto
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int CategoryId { get; set; }
    public int PublisherId { get; set; }
    public int EditionId { get; set; }
    public int LanguageId { get; set; }
    public int ClientId { get; set; }
}

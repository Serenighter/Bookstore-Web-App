
namespace BookstoreApp.Application.DTOs.AuthorBooks;

public class AuthorBookDto
{
    public int BookId { get; set; }
    public int AuthorId { get; set; }
    public BookDto Book { get; set; }
    public AuthorDto Author { get; set; }
}

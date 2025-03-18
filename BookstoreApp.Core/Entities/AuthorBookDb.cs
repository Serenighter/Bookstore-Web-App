
namespace BookstoreApp.Core.Entities;

public class AuthorBookDb
{
    public int BookId { get; set; }
    public int AuthorId { get; set; }
    public BookDb Book { get; set; }
    public AuthorDb Author { get; set; }
}

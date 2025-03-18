
using System.ComponentModel.DataAnnotations;

namespace BookstoreApp.Application.DTOs.AuthorBooks;

public class AddAuthorBookDto
{
    [Required]
    public int BookId { get; set; }
    [Required]
    public int AuthorId { get; set; }
}

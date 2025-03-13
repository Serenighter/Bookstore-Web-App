using BookstoreApp.Application.DTOs.Categories;
using BookstoreApp.Application.DTOs.Clients;
using BookstoreApp.Application.DTOs.Editions;
using BookstoreApp.Application.DTOs.Languages;
using BookstoreApp.Application.DTOs.Publishers;

namespace BookstoreApp.Application.DTOs.Books;

public class BookDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public CategoryDto Category { get; set; }
    public PublisherDto Publisher { get; set; }
    public EditionDto Edition { get; set; }
    public LanguageDto Language { get; set; }
    public ClientDto Client { get; set; }
}

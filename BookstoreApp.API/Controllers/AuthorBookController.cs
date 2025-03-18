using BookstoreApp.Application.DTOs.AuthorBooks;

namespace BookstoreApp.API.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorBookController : ControllerBase
{
    private readonly IAuthorBookService _authorBookService;

    public AuthorBookController(IAuthorBookService authorBookService)
    {
        _authorBookService = authorBookService;
    }

    [HttpGet("AuthorBook")]
    public async Task<IActionResult> GetAuthorBook()
        => Ok(await _authorBookService.GetAllAsync());

    [HttpPost]
    public async Task<IActionResult> AddAuthorBook(AddAuthorBookDto model)
    {
        await _authorBookService.AddAsync(model);
        return Ok();
    }
}

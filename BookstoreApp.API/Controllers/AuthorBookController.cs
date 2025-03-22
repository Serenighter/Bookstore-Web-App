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

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAuthorBook(int id)
    {
        await _authorBookService.DeleteAsync(id);
        return Ok();
    }
}

using BookstoreApp.Application.DTOs.Authors;

namespace BookstoreApp.API.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController : ControllerBase
{
    private readonly IAuthorRepository _authorRepository;
    private readonly IAuthorService _authorService;

    public AuthorController(IAuthorRepository authorRepository, IAuthorService authorService)
    {
        _authorRepository = authorRepository;
        _authorService = authorService;
    }
    [HttpGet("Authors")]
    public async Task<IActionResult> GetAuthors()
        => Ok(await _authorService.GetAllAsync());

    [HttpPost]
    public async Task<IActionResult> AddAuthor(AddAuthorDto model)
    {
        await _authorService.AddAsync(model);
        return Ok();
    }
}

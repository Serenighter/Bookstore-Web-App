using BookstoreApp.Application.DTOs.AuthorBooks;
using Microsoft.AspNetCore.Authorization;

namespace BookstoreApp.API.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class AuthorBookController : ControllerBase
{
    private readonly IAuthorBookService _authorBookService;

    public AuthorBookController(IAuthorBookService authorBookService)
    {
        _authorBookService = authorBookService;
    }

    [AllowAnonymous]
    [HttpGet("AuthorBook")]
    public async Task<IActionResult> GetAuthorBook()
        => Ok(await _authorBookService.GetAllAsync());

    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> AddAuthorBook(AddAuthorBookDto model)
    {
        await _authorBookService.AddAsync(model);
        return Ok();
    }

    [AllowAnonymous]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAuthorBook(int id)
    {
        await _authorBookService.DeleteAsync(id);
        return Ok();
    }
}

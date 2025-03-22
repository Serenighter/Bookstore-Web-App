using BookstoreApp.Application.DTOs.Books;
using Microsoft.AspNetCore.Authorization;

namespace BookstoreApp.API.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;
    private readonly IBookRepository _bookRepository;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [AllowAnonymous]
    [HttpGet("books")]
    public async Task<IActionResult> GetBooks()
        => Ok(await _bookService.GetAllAsync());

    [HttpPost]
    public async Task<IActionResult> AddBook(AddBookDto model)
    {
        await _bookService.AddAsync(model);
        return Ok();
    }

    [AllowAnonymous]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBook(int id)
    {
        await _bookService.DeleteAsync(id);
        return Ok();
    }
}

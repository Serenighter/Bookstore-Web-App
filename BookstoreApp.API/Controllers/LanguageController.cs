using BookstoreApp.Application.DTOs.Languages;

namespace BookstoreApp.API.Controllers;

[ApiController]
[Route("[controller]")]
public class LanguageController : ControllerBase
{
    private readonly ILanguageRepository _languageRepository;
    private readonly ILanguageService _languageService;

    public LanguageController(ILanguageService languageService)
    {
        _languageService = languageService;
    }

    [HttpGet("Languages")]
    public async Task<IActionResult> GetLanguages()
        => Ok(await _languageService.GetAllAsync());

    [HttpPost]
    public async Task<IActionResult> AddLanguage(AddLanguageDto model)
    {
        await _languageService.AddAsync(model);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteLanguage(int id)
    {
        await _languageService.DeleteAsync(id);
        return Ok();
    }
}

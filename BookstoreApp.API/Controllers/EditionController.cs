using BookstoreApp.Application.DTOs.Editions;

namespace BookstoreApp.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EditionController : ControllerBase
{
    private readonly IEditionRepository _editionRepository;
    private readonly IEditionService _editionService;

    public EditionController(IEditionService editionService)
    {
        _editionService = editionService;
    }
    [HttpGet("Editions")]
    public async Task<IActionResult> GetEditions()
        => Ok(await _editionService.GetAllAsync());

    [HttpPost]
    public async Task<IActionResult> AddEdition(AddEditionDto model)
    {
        await _editionService.AddAsync(model);
        return Ok();
    }
}

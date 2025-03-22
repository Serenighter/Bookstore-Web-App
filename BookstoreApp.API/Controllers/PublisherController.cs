using BookstoreApp.Application.DTOs.Publishers;

namespace BookstoreApp.API.Controllers;

[ApiController]
[Route("[controller]")]
public class PublisherController : ControllerBase
{
    private readonly IPublisherRepository _publisherRepository;
    private readonly IPublisherService _publisherService;

    public PublisherController(IPublisherService publisherService)
    {
        _publisherService = publisherService;
    }

    [HttpGet("Publishers")]
    public async Task<IActionResult> GetPublishers()
        => Ok(await _publisherService.GetAllAsync());

    [HttpPost]
    public async Task<IActionResult> AddPublisher(AddPublisherDto model)
    {
        await _publisherService.AddAsync(model);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePublisher(int id)
    {
        await _publisherService.DeleteAsync(id);
        return Ok();
    }
}

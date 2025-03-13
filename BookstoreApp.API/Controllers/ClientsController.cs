using BookstoreApp.Application.DTOs.Clients;
namespace BookstoreApp.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientsController : ControllerBase
{
    private readonly IClientsRepository _clientsRepository;
    private readonly IClientService _clientService;
    
    public ClientsController(IClientService clientService)
    {
        _clientService = clientService;
    }

    [HttpGet("Clients")]
    public async Task<IActionResult> GetClients()
        => Ok(await _clientService.GetAllAsync());

    [HttpPost]
    public async Task<IActionResult> AddClient(AddClientDto model)
    {
        await _clientService.AddAsync(model);
        return Ok();
    }
}

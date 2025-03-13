using Microsoft.Extensions.Configuration;

namespace BookstoreApp.Application.Services;

public class ClientService : IClientService
{
    private readonly IClientsRepository _clientRepository;
    private readonly IConfiguration _configuration;
    private readonly IMapper _mapper;

    public ClientService(IClientsRepository clientRepository, IConfiguration configuration, IMapper mapper)
    {
        _clientRepository = clientRepository;
        _configuration = configuration;
        _mapper = mapper;
    }

    public async Task AddAsync(AddClientDto model)
    {
        var newClientsDb = new ClientDb(model.Name, model.Surname, model.Email, model.PhoneNumber);
        
        await _clientRepository.AddAsync(newClientsDb);
    }
    public async Task<IEnumerable<ClientDto>> GetAllAsync()
    {
        var clientDbs = await _clientRepository.GetAllAsync();

        var clientDtos = _mapper.Map<IEnumerable<ClientDto>>(clientDbs);

        /*var clientDtos = new List<ClientDto>();

        foreach (var clientDb in clientDbs)
        {
            var clientDto = new ClientDto
            {
                Id = clientDb.Id,
                Name = clientDb.Name,
                Surname = clientDb.Surname,
                Email = clientDb.Email,
                PhoneNumber = clientDb.PhoneNumber,
            };
            clientDtos.Add(clientDto);
        }*/
        return clientDtos;
    }
}

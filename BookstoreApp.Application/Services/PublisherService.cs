using Microsoft.Extensions.Configuration;

namespace BookstoreApp.Application.Services;

public class PublisherService : IPublisherService
{
    private readonly IPublisherRepository _publisherRepository;
    private readonly IConfiguration _configuration;
    private readonly IMapper _mapper;

    public PublisherService(IPublisherRepository publisherRepository, IConfiguration configuration, IMapper mapper)
    {
        _publisherRepository = publisherRepository;
        _configuration = configuration;
        _mapper = mapper;
    }

    public async Task AddAsync(AddPublisherDto model)
    {
        var newPublisherDb = new PublisherDb(model.Name);

        await _publisherRepository.AddAsync(newPublisherDb);
    }

    public async Task<IEnumerable<PublisherDto>> GetAllAsync()
    {
        var publisherDbs = await _publisherRepository.GetAllAsync();

        var publisherDtos = _mapper.Map<IEnumerable<PublisherDto>>(publisherDbs);

        /*var publisherDtos = new List<PublisherDto>();

        foreach (var publisherDb in publisherDbs)
        {
            var publisherDto = new PublisherDto
            {
                Id = publisherDb.Id,
                Name = publisherDb.Name,
            };
            publisherDtos.Add(publisherDto);
        }*/
        return publisherDtos;
    }
    public async Task DeleteAsync(int id)
    {
        await _publisherRepository.DeleteAsync(id);
    }
}

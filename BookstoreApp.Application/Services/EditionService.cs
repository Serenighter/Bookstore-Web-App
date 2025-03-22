using Microsoft.Extensions.Configuration;

namespace BookstoreApp.Application.Services;

public class EditionService : IEditionService
{
    private readonly IEditionRepository _editionRepository;
    private readonly IConfiguration _configuration;
    private readonly IMapper _mapper;

    public EditionService(IEditionRepository editionRepository, IConfiguration configuration, IMapper mapper)
    {
        _editionRepository = editionRepository;
        _configuration = configuration;
        _mapper = mapper;
    }

    public async Task AddAsync(AddEditionDto model)
    {
        var newEditionDb = new EditionDb(model.EditionName);

        await _editionRepository.AddAsync(newEditionDb);
    }

    public async Task<IEnumerable<EditionDto>> GetAllAsync()
    {
        var editionDbs = await _editionRepository.GetAllAsync();

        var editionDtos = _mapper.Map<IEnumerable<EditionDto>>(editionDbs);

        /*var editionDtos = new List<EditionDto>();

        foreach (var editionDb in editionDbs)
        {
            var editionDto = new EditionDto
            {
                Id = editionDb.Id,
                EditionName = editionDb.EditionName,
            };
            editionDtos.Add(editionDto);
        }*/
        return editionDtos;
    }
    public async Task DeleteAsync(int id)
    {
        await _editionRepository.DeleteAsync(id);
    }
}

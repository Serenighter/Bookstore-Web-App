using Microsoft.Extensions.Configuration;
namespace BookstoreApp.Application.Services;

public class LanguageService : ILanguageService
{
    private readonly ILanguageRepository _languageRepository;
    private readonly IConfiguration _configuration;
    private readonly IMapper _mapper;

    public LanguageService(ILanguageRepository languageRepository, IConfiguration configuration, IMapper mapper)
    {
        _languageRepository = languageRepository;
        _configuration = configuration;
        _mapper = mapper;
    }

    public async Task AddAsync(AddLanguageDto model)
    {
        var newLanguageDb = new LanguageDb(model.LanguageName);

        await _languageRepository.AddAsync(newLanguageDb);
    }

    public async Task<IEnumerable<LanguageDto>> GetAllAsync()
    {
        var languageDbs = await _languageRepository.GetAllAsync();

        var languageDtos = _mapper.Map<IEnumerable<LanguageDto>>(languageDbs);

        /*var languageDtos = new List<LanguageDto>();

        foreach (var languageDb in languageDbs)
        {
            var languageDto = new LanguageDto
            {
                Id = languageDb.Id,
                LanguageName = languageDb.LanguageName
            };
            languageDtos.Add(languageDto);
        }*/
        return languageDtos;
    }
    public async Task DeleteAsync(int id)
    {
        await _languageRepository.DeleteAsync(id);
    }
}

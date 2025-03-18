
using Microsoft.Extensions.Configuration;

namespace BookstoreApp.Application.Services;

public class AuthorService : IAuthorService
{
    private readonly IAuthorRepository _authorRepository;
    private readonly IConfiguration _configuration;
    private readonly IMapper _mapper;

    public AuthorService(IAuthorRepository authorRepository, IConfiguration configuration, IMapper mapper)
    {
        _authorRepository = authorRepository;
        _configuration = configuration;
        _mapper = mapper;
    }

    public async Task AddAsync(AddAuthorDto model) 
    {
        var newAuthorDb = new AuthorDb(model.Name);
        await _authorRepository.AddAsync(newAuthorDb);
    }

    public async Task<IEnumerable<AuthorDto>> GetAllAsync()
    {
        var authorDbs = await _authorRepository.GetAllAsync();
        var authorDtos = _mapper.Map<IEnumerable<AuthorDto>>(authorDbs);

        return authorDtos;
    }

}


namespace BookstoreApp.Application.Services;

public class AuthorBookService : IAuthorBookService
{
    private readonly IAuthorBookRepository _authorBookRepository;
    private readonly IAuthorRepository _authorRepository;
    private readonly IBookRepository _bookRepository;
    private readonly IMapper _mapper;

    public AuthorBookService(IAuthorBookRepository authorBookRepository, IAuthorRepository authorRepository, IBookRepository bookRepository, IMapper mapper)
    {
        _authorBookRepository = authorBookRepository;
        _authorRepository = authorRepository;
        _bookRepository = bookRepository;
        _mapper = mapper;
    }

    public async Task AddAsync(AddAuthorBookDto model)
    {
        var authorBook = new AuthorBookDb
        {
            AuthorId = model.AuthorId,
            BookId = model.BookId,
        };

        await _authorBookRepository.AddAsync(authorBook);
    }

    public async Task<IEnumerable<AuthorBookDto>> GetAllAsync()
    {
        var authorBooks = await _authorBookRepository.GetAllAsync();
        var authorBookDtos = _mapper.Map<IEnumerable<AuthorBookDto>>(authorBooks);
        return authorBookDtos;
    }
    public async Task DeleteAsync(int id)
    {
        await _authorBookRepository.DeleteAsync(id);
    }
}

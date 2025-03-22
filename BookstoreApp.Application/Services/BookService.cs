using Microsoft.Extensions.Configuration;

namespace BookstoreApp.Application.Services;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;
    private readonly IConfiguration _configuration;
    private readonly IMapper _mapper;

    public BookService(IBookRepository bookRepository, IConfiguration configuration, IMapper mapper)
    {
        _bookRepository = bookRepository;
        _configuration = configuration;
        _mapper = mapper;
    }

    public async Task AddAsync(AddBookDto model)
    {
        var newBookDb = new BookDb(model.Title,/* model.Author,*/ model.CategoryId, model.PublisherId, model.EditionId, model.LanguageId, model.ClientId);

        await _bookRepository.AddAsync(newBookDb);
    }

    public async Task<IEnumerable<BookDto>> GetAllAsync()
    {
        var bookDbs = await _bookRepository.GetAllAsync();

        var bookDtos = _mapper.Map<IEnumerable<BookDto>>(bookDbs);

        /*var bookDtos = new List<BookDto>();

        foreach(var bookDb in bookDbs)
        {
            var bookDto = new BookDto
            {
                Id = bookDb.Id,
                Title = bookDb.Title,
                Author = bookDb.Author,
                Category = new CategoryDto
                {
                    Id = bookDb.Category.Id,
                    Name = bookDb.Category.Name
                },
                Publisher = new PublisherDto { Id = bookDb.Publisher.Id, Name = bookDb.Publisher.Name },
                Edition = new EditionDto { Id = bookDb.Edition.Id, EditionName = bookDb.Edition.EditionName },
                Language = new LanguageDto { Id = bookDb.Language.Id, LanguageName = bookDb.Language.LanguageName },
                Client = new ClientDto 
                {
                    Id = bookDb.Client.Id,
                    Name = bookDb.Client.Name,
                    Surname = bookDb.Client.Surname,
                    Email = bookDb.Client.Email,
                    PhoneNumber = bookDb.Client.PhoneNumber
                }
            };

            bookDtos.Add(bookDto);
        }*/

        return bookDtos;
    }
    public async Task DeleteAsync(int id)
    {
        await _bookRepository.DeleteAsync(id);
    }
}

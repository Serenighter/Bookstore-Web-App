
namespace BookstoreApp.Application.Services;

public interface IBookService
{
    public Task AddAsync(AddBookDto model);
    public Task<IEnumerable<BookDto>> GetAllAsync();
}

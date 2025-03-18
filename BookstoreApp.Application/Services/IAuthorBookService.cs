
namespace BookstoreApp.Application.Services;

public interface IAuthorBookService
{
    public Task AddAsync(AddAuthorBookDto model);
    public Task<IEnumerable<AuthorBookDto>> GetAllAsync();
}

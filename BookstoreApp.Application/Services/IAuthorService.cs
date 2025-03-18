
namespace BookstoreApp.Application.Services;

public interface IAuthorService
{
    public Task AddAsync(AddAuthorDto model);
    public Task<IEnumerable<AuthorDto>> GetAllAsync();
}

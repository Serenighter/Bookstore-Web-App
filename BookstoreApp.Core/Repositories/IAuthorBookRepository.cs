
namespace BookstoreApp.Core.Repositories;

public interface IAuthorBookRepository
{
    public Task AddAsync(AuthorBookDb authorBook);
    public Task<IEnumerable<AuthorBookDb>> GetAllAsync();
}

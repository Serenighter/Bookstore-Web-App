namespace BookstoreApp.Core.Repositories;

public interface IAuthorRepository
{
    public Task AddAsync(AuthorDb authorDb);
    public Task<IEnumerable<AuthorDb>> GetAllAsync();
}

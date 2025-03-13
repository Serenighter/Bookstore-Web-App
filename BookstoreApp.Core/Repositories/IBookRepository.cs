namespace BookstoreApp.Core.Repositories;

public interface IBookRepository
{
    public Task AddAsync(BookDb clientDb);
    public Task<IEnumerable<BookDb>> GetAllAsync();
}

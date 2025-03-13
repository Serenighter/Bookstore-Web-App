namespace BookstoreApp.Core.Repositories;

public interface ICategoryRepository
{
    public Task AddAsync(CategoryDb categoryDb);
    public Task<IEnumerable<CategoryDb>> GetAllAsync();
}

namespace BookstoreApp.Core.Repositories;

public interface IEditionRepository
{
    public Task AddAsync(EditionDb editionDb);

    public Task<IEnumerable<EditionDb>> GetAllAsync();
    public Task DeleteAsync(int id);
}

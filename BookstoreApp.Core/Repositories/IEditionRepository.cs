namespace BookstoreApp.Core.Repositories;

public interface IEditionRepository
{
    public Task AddAsync(EditionDb editionDb);

    public Task<IEnumerable<EditionDb>> GetAllAsync();
}

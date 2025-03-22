namespace BookstoreApp.Core.Repositories;

public interface ILanguageRepository
{
    public Task AddAsync(LanguageDb languageDb);
    public Task<IEnumerable<LanguageDb>> GetAllAsync();
    public Task DeleteAsync(int id);
}

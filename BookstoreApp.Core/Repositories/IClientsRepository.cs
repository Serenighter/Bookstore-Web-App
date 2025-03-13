namespace BookstoreApp.Core.Repositories;

public interface IClientsRepository
{
    public Task AddAsync(ClientDb clientDb);
    public Task<IEnumerable<ClientDb>> GetAllAsync();
}

namespace BookstoreApp.Core.Repositories;

public interface IPublisherRepository
{
    public Task AddAsync(PublisherDb publisherDb);
    public Task<IEnumerable<PublisherDb>> GetAllAsync();
}

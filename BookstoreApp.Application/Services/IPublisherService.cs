using BookstoreApp.Application.DTOs.Publishers;

namespace BookstoreApp.Application.Services;

public interface IPublisherService
{
    public Task AddAsync(AddPublisherDto model);
    public Task<IEnumerable<PublisherDto>> GetAllAsync();
    public Task DeleteAsync(int id);
}

using BookstoreApp.Application.DTOs.Editions;

namespace BookstoreApp.Application.Services;

public interface IEditionService
{
    public Task AddAsync(AddEditionDto model);
    public Task<IEnumerable<EditionDto>> GetAllAsync();
    public Task DeleteAsync(int id);
}

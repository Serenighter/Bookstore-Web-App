using BookstoreApp.Application.DTOs.Languages;

namespace BookstoreApp.Application.Services;

public interface ILanguageService
{
    public Task AddAsync(AddLanguageDto model);
    public Task<IEnumerable<LanguageDto>> GetAllAsync();
    public Task DeleteAsync(int id);
}

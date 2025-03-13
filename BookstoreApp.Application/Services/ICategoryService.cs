
namespace BookstoreApp.Application.Services;

public interface ICategoryService
{
    public Task AddAsync(AddCategoryDto model);
    public Task<IEnumerable<CategoryDto>> GetAllAsync();
}

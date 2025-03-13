using Microsoft.Extensions.Configuration;

namespace BookstoreApp.Application.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IConfiguration _configuration;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository, IConfiguration configuration, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _configuration = configuration;
        _mapper = mapper;
    }

    public async Task AddAsync(AddCategoryDto model)
    {
        var newCategoryDb = new CategoryDb(model.Name);

        await _categoryRepository.AddAsync(newCategoryDb);
    }

    public async Task<IEnumerable<CategoryDto>> GetAllAsync()
    {
        var categoryDbs = await _categoryRepository.GetAllAsync();

        var categoryDtos = _mapper.Map<IEnumerable<CategoryDto>>(categoryDbs);

        /*var categoryDtos = new List<CategoryDto>();

        foreach (var categoryDb in categoryDbs)
        {
            var categoryDto = new CategoryDto 
            {
                Id = categoryDb.Id,
                Name = categoryDb.Name,
            };

            categoryDtos.Add(categoryDto);
        }*/

        return categoryDtos;
    }
}

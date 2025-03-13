using BookstoreApp.Application.DTOs.Categories;

namespace BookstoreApp.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    [HttpGet("Categories")]
    public async Task<IActionResult> GetCategories()
        => Ok(await _categoryService.GetAllAsync());
    
    [HttpPost]
    public async Task<IActionResult> AddCategory(AddCategoryDto model)
    {
        await _categoryService.AddAsync(model);
        return Ok();
    }

    /*[HttpDelete]
    public async Task<IActionResult> DeleteCategory(int id)
    {

    }*/
}

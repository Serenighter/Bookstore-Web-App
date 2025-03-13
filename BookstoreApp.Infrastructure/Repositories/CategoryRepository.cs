namespace BookstoreApp.Infrastructure.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _context;

    public CategoryRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<CategoryDb>> GetAllAsync()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task AddAsync(CategoryDb categoryDb)
    {
        await _context.Categories.AddAsync(categoryDb);
        await _context.SaveChangesAsync();
    }
}
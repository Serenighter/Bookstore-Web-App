namespace BookstoreApp.Infrastructure.Repositories;

public class LanguageRepository : ILanguageRepository
{
    private readonly ApplicationDbContext _context;

    public LanguageRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<LanguageDb>> GetAllAsync()
    {
        return await _context.Languages.ToListAsync();
    }

    public async Task AddAsync(LanguageDb language)
    {
        await _context.Languages.AddAsync(language);
        await _context.SaveChangesAsync();
    }
    public async Task DeleteAsync(int id)
    {
        var language = await _context.Languages.FindAsync(id);
        _context.Languages.Remove(language);
        await _context.SaveChangesAsync();
    }
}

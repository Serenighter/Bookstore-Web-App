namespace BookstoreApp.Infrastructure.Repositories;

public class EditionRepository : IEditionRepository
{
    private readonly ApplicationDbContext _context;

    public EditionRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<EditionDb>> GetAllAsync()
    {
        return await _context.Editions.ToListAsync();
    }

    public async Task AddAsync(EditionDb editionDb)
    {
        await _context.Editions.AddAsync(editionDb);
        await _context.SaveChangesAsync();
    }
    public async Task DeleteAsync(int id)
    {
        var editionDb = await _context.Editions.FindAsync(id);
        _context.Editions.Remove(editionDb);
        await _context.SaveChangesAsync();
    }








}

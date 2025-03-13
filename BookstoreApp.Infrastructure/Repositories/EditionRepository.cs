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









}

namespace BookstoreApp.Infrastructure.Repositories;

public class PublisherRepository : IPublisherRepository
{
    private readonly ApplicationDbContext _context;

    public PublisherRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<PublisherDb>> GetAllAsync() 
    {
        return await _context.Publishers.ToListAsync();
    }

    public async Task AddAsync(PublisherDb publisher)
    {
        await _context.Publishers.AddAsync(publisher);
        await _context.SaveChangesAsync();
    }
    public async Task DeleteAsync(int id)
    {
        var publisher = await _context.Publishers.FindAsync(id);
        _context.Publishers.Remove(publisher);
        await _context.SaveChangesAsync();
    }
}

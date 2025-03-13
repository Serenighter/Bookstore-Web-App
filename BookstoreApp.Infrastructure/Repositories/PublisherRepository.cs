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
}

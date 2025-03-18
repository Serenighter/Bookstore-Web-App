
namespace BookstoreApp.Infrastructure.Repositories;

public class AuthorRepository : IAuthorRepository
{
    private readonly ApplicationDbContext _context;

    public AuthorRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<AuthorDb>> GetAllAsync()
    {
        return await _context.Authors.ToListAsync();
    }

    public async Task AddAsync(AuthorDb author)
    {
        await _context.Authors.AddAsync(author);
        await _context.SaveChangesAsync();
    }
}

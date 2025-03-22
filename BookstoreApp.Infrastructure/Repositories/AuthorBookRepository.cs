using Microsoft.EntityFrameworkCore.Query;
namespace BookstoreApp.Infrastructure.Repositories;

public class AuthorBookRepository : IAuthorBookRepository
{
    private readonly ApplicationDbContext _context;

    public AuthorBookRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<AuthorBookDb>> GetAllAsync()
    {
        return await _context.AuthorsBooks
            .Include(ab => ab.Author)
            .Include(ab => ab.Book)
                .ThenInclude(b => b.Category)
            .Include(ab => ab.Book)
                .ThenInclude(b => b.Publisher)
            .Include(ab => ab.Book)
                .ThenInclude(b => b.Edition)
            .Include(ab => ab.Book)
                .ThenInclude(b => b.Language)
            .Include(ab => ab.Book)
                .ThenInclude(b => b.Client)
            .ToListAsync();
    }

    public async Task AddAsync(AuthorBookDb authorBookDb)
    {
        await _context.AuthorsBooks.AddAsync(authorBookDb);
        await _context.SaveChangesAsync();
    }
}
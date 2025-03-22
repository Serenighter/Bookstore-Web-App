namespace BookstoreApp.Infrastructure.Repositories;

public class BookRepository : IBookRepository
{
    private readonly ApplicationDbContext _context;

    public BookRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<BookDb>> GetAllAsync()
    {
         return await _context.Books
            .Include(x => x.Category)
            .Include(x => x.Publisher)
            .Include(x => x.Edition)
            .Include(x => x.Language)
            .Include(x => x.Client)
            .ToListAsync();
    }

    public async Task AddAsync(BookDb bookDb)
    {
        await _context.Books.AddAsync(bookDb);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var bookDb = await _context.Books.FindAsync(id);
        _context.Books.Remove(bookDb);
        await _context.SaveChangesAsync();
    }
}

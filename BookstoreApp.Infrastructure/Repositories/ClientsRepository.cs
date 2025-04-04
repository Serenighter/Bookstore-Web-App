﻿namespace BookstoreApp.Infrastructure.Repositories;

public class ClientsRepository : IClientsRepository
{
    private readonly ApplicationDbContext _context;

    public ClientsRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ClientDb>> GetAllAsync()
    {
        return await _context.Clients.ToListAsync();
    }

    public async Task AddAsync(ClientDb clientDb)
    {
        await _context.Clients.AddAsync(clientDb);
        await _context.SaveChangesAsync();
    }
}

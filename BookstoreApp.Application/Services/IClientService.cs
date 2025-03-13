using BookstoreApp.Application.DTOs.Clients;
namespace BookstoreApp.Application.Services;

public interface IClientService
{
    public Task AddAsync(AddClientDto model);
    public Task<IEnumerable<ClientDto>> GetAllAsync();
}

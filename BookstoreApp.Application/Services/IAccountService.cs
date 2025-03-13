
using BookstoreApp.Application.DTOs.Account;

namespace BookstoreApp.Application.Services;

public interface IAccountService
{
    public Task SignUpAsync(SignUpModelDto model);
    public Task<string> SignInAsync(SignInModelDto model);
}

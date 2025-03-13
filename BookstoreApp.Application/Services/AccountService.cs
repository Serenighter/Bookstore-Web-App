
using BookstoreApp.Application.DTOs.Account;
using BookstoreApp.Application.Services.JWT;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;

namespace BookstoreApp.Application.Services;

public class AccountService : IAccountService
{
    private readonly UserManager<UserDb> _userManager;
    private readonly SignInManager<UserDb> _signInManager;
    private readonly IJsonWebTokenService _jsonWebTokenService;

    public AccountService(UserManager<UserDb> userManager, SignInManager<UserDb> signInManager, IJsonWebTokenService jsonWebTokenService)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _jsonWebTokenService = jsonWebTokenService;
    }

    public async Task SignUpAsync(SignUpModelDto model)
    {
        if (model.Password != model.PasswordConfirmed)
        {
            throw new Exception("Podane hasla sa rozne");
        }

        var userDb = new UserDb
        {
            Email = model.Email,
            UserName = model.UserName
        };

        var result = await _userManager.CreateAsync(userDb, model.Password);

        if (!result.Succeeded)
        {
            throw new Exception(result.Errors.First().Description);
        }

    }
    public async Task<string> SignInAsync(SignInModelDto model)
    {
        var userDb = await _userManager.FindByEmailAsync(model.Email);

        if (userDb == null)
        {
            throw new Exception("Błędny login lub hasło");
        }

        var result = await _signInManager.PasswordSignInAsync(userDb, model.Password, false, false);

        if (!result.Succeeded)
        {
            throw new Exception("Błędny login lub hasło");
        }

        var token = _jsonWebTokenService.CreateToken(userDb);
        return token;
        
    }
}


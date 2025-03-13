using BookstoreApp.Core.Entities;
using Microsoft.AspNetCore.Identity;
using BookstoreApp.Application.DTOs.Account;
using Microsoft.AspNetCore.Authorization;
using BookstoreApp.Infrastructure.Migrations;
using BookstoreApp.Application.Services.JWT;
namespace BookstoreApp.API.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }
    [AllowAnonymous]
    [HttpPost("sign_up")]
    public async Task<IActionResult> SignUp([FromBody] SignUpModelDto model)
    {
        await _accountService.SignUpAsync(model);
        return Ok();
    }
    [AllowAnonymous]
    [HttpPost("sign_in")]
    public async Task<IActionResult> SignIn([FromBody] SignInModelDto model)
    {
        var token = await _accountService.SignInAsync(model);
        return Ok(token);
    }
}

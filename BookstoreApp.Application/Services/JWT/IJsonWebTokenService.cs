namespace BookstoreApp.Application.Services.JWT;

public interface IJsonWebTokenService
{
    public string CreateToken(UserDb userDb, IList<string> roles);
}

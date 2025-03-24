using Microsoft.IdentityModel.JsonWebTokens;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Data;

namespace BookstoreApp.Application.Services.JWT;

public class JsonWebTokenService : IJsonWebTokenService
{
    private readonly SymmetricSecurityKey _key;

    public JsonWebTokenService(IConfiguration configuration)
    {
        _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"]));
    }

    public string CreateToken(UserDb userDb, IList<string> roles)
    {
        var credentials = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);

        var claims = new List<Claim>
        {
            new Claim(Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Sub, userDb.Id)
        };

        foreach (var role in roles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        }

        var expirationDate = DateTime.Now.AddHours(1);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = expirationDate,
            SigningCredentials = credentials,
        };

        var tokenHandler = new JwtSecurityTokenHandler();

        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }
}

using BookstoreApp.Application.Services;
using BookstoreApp.Application.Services.JWT;
using Microsoft.Extensions.DependencyInjection;
namespace BookstoreApp.Application;

public static class ApplicationExtensions
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IBookService, BookService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IPublisherService, PublisherService>();
        services.AddScoped<IEditionService, EditionService>();
        services.AddScoped<IClientService, ClientService>();
        services.AddScoped<ILanguageService, LanguageService>();
        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<IJsonWebTokenService, JsonWebTokenService>();
        
    }
}

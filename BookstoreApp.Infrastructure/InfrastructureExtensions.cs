
using BookstoreApp.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BookstoreApp.Infrastructure;

public static class InfrastructureExtensions
{
    public static void AddInfrastuctureServices(this IServiceCollection services)
    {
        services.AddScoped<IBookRepository, BookRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IPublisherRepository, PublisherRepository>();
        services.AddScoped<IEditionRepository, EditionRepository>();
        services.AddScoped<ILanguageRepository, LanguageRepository>();
        services.AddScoped<IClientsRepository, ClientsRepository>();
        services.AddScoped<IAuthorRepository, AuthorRepository>();
        services.AddScoped<IAuthorBookRepository, AuthorBookRepository>();
    }
}

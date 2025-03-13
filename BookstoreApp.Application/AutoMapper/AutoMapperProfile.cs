
namespace BookstoreApp.Application.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile() 
    {
        CreateMap<BookDb, BookDto>();
        CreateMap<CategoryDb, CategoryDto>();
        CreateMap<ClientDb, ClientDto>();
        CreateMap<PublisherDb, PublisherDto>();
        CreateMap<LanguageDb, LanguageDto>();
        CreateMap<EditionDb, EditionDto>();
    }
}

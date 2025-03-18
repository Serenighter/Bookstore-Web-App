
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
        CreateMap<AuthorDb, AuthorDto>();
        CreateMap<AuthorBookDb, AuthorBookDto>()
            .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author))
            .ForMember(dest => dest.Book, opt => opt.MapFrom(src => src.Book));
    }
}

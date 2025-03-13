
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreApp.Infrastructure.Configurations;

public class LanguageDbConfiguration : IEntityTypeConfiguration<LanguageDb>
{
    public void Configure(EntityTypeBuilder<LanguageDb> builder)
    {
        builder.ToTable("Languages");

        builder.HasMany(x => x.Books)
            .WithOne(x => x.Language)
            .HasForeignKey(x => x.LanguageId);
    }
}

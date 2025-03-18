
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreApp.Infrastructure.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<AuthorDb>
{
    public void Configure(EntityTypeBuilder<AuthorDb> builder)
    {
        builder.ToTable("Authors");

        builder.HasMany(x => x.AuthorBooks)
            .WithOne(x => x.Author)
            .HasForeignKey(x => x.AuthorId);
    }
}

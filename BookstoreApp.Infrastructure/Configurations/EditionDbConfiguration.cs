
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreApp.Infrastructure.Configurations;

public class EditionDbConfiguration : IEntityTypeConfiguration<EditionDb>
{
    public void Configure(EntityTypeBuilder<EditionDb> builder)
    {
        builder.ToTable("Editions");

        builder
            .HasMany(x => x.Books)
            .WithOne(x => x.Edition)
            .HasForeignKey(x => x.EditionId);
    }
}

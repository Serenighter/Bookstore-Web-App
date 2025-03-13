
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreApp.Infrastructure.Configurations;

public class CategoryDbConfiguration : IEntityTypeConfiguration<CategoryDb>
{
    public void Configure(EntityTypeBuilder<CategoryDb> builder)
    {
        builder.ToTable("Categories"); //"Category"?

        builder.HasMany(x => x.Books)
            .WithOne(x => x.Category)
            .HasForeignKey(x => x.CategoryId);
    }
}

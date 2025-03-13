
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreApp.Infrastructure.Configurations;

public class PublisherDbConfiguration : IEntityTypeConfiguration<PublisherDb>
{
    public void Configure(EntityTypeBuilder<PublisherDb> builder)
    {
        builder.ToTable("Publishers");

        builder
            .HasMany(x => x.Books)
            .WithOne(x => x.Publisher)
            .HasForeignKey(x => x.PublisherId);
    }
}

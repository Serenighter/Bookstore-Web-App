
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreApp.Infrastructure.Configurations;

public class ClientsDbConfiguration : IEntityTypeConfiguration<ClientDb>
{
    public void Configure(EntityTypeBuilder<ClientDb> builder)
    {
        builder.ToTable("Clients");

        builder.HasMany(x => x.Books)
            .WithOne(x => x.Client)
            .HasForeignKey(x => x.ClientId);
    }
}

﻿
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreApp.Infrastructure.Configurations;

public class BookDbConfiguration : IEntityTypeConfiguration<BookDb>
{
    public void Configure(EntityTypeBuilder<BookDb> builder)
    {
        builder.ToTable("Books");

        builder.HasOne(x => x.Category)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.CategoryId);
    }
}

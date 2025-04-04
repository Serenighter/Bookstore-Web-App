﻿using System.Reflection;
using BookstoreApp.Infrastructure.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BookstoreApp.Infrastructure;

public class ApplicationDbContext : IdentityDbContext<UserDb>
{
    public DbSet<BookDb> Books { get; set; }
    public DbSet<CategoryDb> Categories { get; set; }
    public DbSet<ClientDb> Clients { get; set; }
    public DbSet<PublisherDb> Publishers { get; set; }
    public DbSet<EditionDb> Editions { get; set; }
    public DbSet<LanguageDb> Languages { get; set; }
    public DbSet<AuthorDb> Authors { get; set; }
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //modelBuilder.ApplyConfiguration(new BookDbConfiguration());

        
        modelBuilder.Entity<BookDb>()
            .HasMany(x => x.Authors)
            .WithMany(x => x.Books)
            .UsingEntity(x => x.ToTable("BookDbAuthorDb"));
        /*
        modelBuilder.Entity<BookDb>()
            .HasOne(x => x.Category)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.CategoryId);
        
        modelBuilder.Entity<CategoryDb>()
            .HasMany(x => x.Books)
            .WithOne(x => x.Category)
            .HasForeignKey(x => x.CategoryId);
        modelBuilder.Entity<PublisherDb>()
            .HasMany(x => x.Books)
            .WithOne(x => x.Publisher)
            .HasForeignKey(x => x.PublisherId);
        modelBuilder.Entity<EditionDb>()
            .HasMany(x => x.Books)
            .WithOne(x => x.Edition)
            .HasForeignKey(x => x.EditionId);
        modelBuilder.Entity<LanguageDb>()
            .HasMany(x => x.Books)
            .WithOne(x => x.Language)
            .HasForeignKey(x => x.LanguageId);
        modelBuilder.Entity<ClientDb>()
            .HasMany(x => x.Books)
            .WithOne(x => x.Client)
            .HasForeignKey(x =>x.ClientId);*/
        /*modelBuilder.Entity<CategoryDb>(entity =>
        {
            entity.HasIndex(x => x.Name).IsUnique();
        });*/

    }
}

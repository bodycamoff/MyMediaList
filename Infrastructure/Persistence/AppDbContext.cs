using Domain.Entities;
using Domain.Metadata;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<MediaItem> MediaItems => Set<MediaItem>();
    public DbSet<Review> Reviews => Set<Review>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        modelBuilder.Entity<User>(opt =>
        {
            opt.ToTable("users");
            opt.HasKey(x => x.Id);
            opt.Property(x => x.Email).HasMaxLength(100).IsRequired();
            opt.Property(x => x.UserName).HasMaxLength(50).IsRequired();
            opt.Property(x => x.Role).HasConversion<string>();
        });


        modelBuilder.Entity<MediaItem>(e =>
        {
            e.HasKey(x => x.Id);
            e.HasOne(x => x.BookMetadata).WithOne(b => b.MediaItem).HasForeignKey<BookMetadata>(b => b.MediaItemId);
            e.HasOne(x => x.GameMetadata).WithOne(g => g.MediaItem).HasForeignKey<GameMetadata>(g => g.MediaItemId);
            e.HasOne(x => x.MovieMetadata).WithOne(m => m.MediaItem).HasForeignKey<MovieMetadata>(m => m.MediaItemId);
            e.HasOne(x => x.SeriesMetadata).WithOne(s => s.MediaItem).HasForeignKey<SeriesMetadata>(s => s.MediaItemId);
            e.HasOne(x => x.MangaMetadata).WithOne(m => m.MediaItem).HasForeignKey<MangaMetadata>(x => x.MediaItemId);
            
            e.Property(x => x.Title).HasMaxLength(100).IsRequired();
            e.Property(x => x.Description).HasMaxLength(500);
        });

        modelBuilder.Entity<BookMetadata>(e => e.HasKey(x => x.MediaItemId));
        modelBuilder.Entity<GameMetadata>(e => e.HasKey(x => x.MediaItemId));
        modelBuilder.Entity<MangaMetadata>(e => e.HasKey(x => x.MediaItemId));
        modelBuilder.Entity<SeriesMetadata>(e => e.HasKey(x => x.MediaItemId));
        modelBuilder.Entity<MovieMetadata>(e => e.HasKey(x => x.MediaItemId));
    }
}
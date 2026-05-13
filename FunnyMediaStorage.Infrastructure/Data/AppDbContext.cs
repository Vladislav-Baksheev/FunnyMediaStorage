using FunnyMediaStorage.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FunnyMediaStorage.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<User> Users => Set<User>();
    public DbSet<MediaFile> MediaFiles => Set<MediaFile>();
}
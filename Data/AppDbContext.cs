using Microsoft.EntityFrameworkCore;
using PoCEmPRESA.Data;
using PoCEmPRESA.Models;

namespace PoCEmPRESA.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base (options)
    {
        
    }

    public DbSet<Client> Clients => Set<Client>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Client>()
            .HasIndex(client => client.Email)
            .IsUnique();
    }

}
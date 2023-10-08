using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Alloro.DisasterEmergency.Api.Entities;

namespace Alloro.DisasterEmergency.Api.Repositories;

public class DisasterEmergencyContext : DbContext
{
    private readonly IConfiguration _configuration;

    public DbSet<Disaster> Disaster { get; set; }

    public DbSet<DisasterLevel> DisasterLevel { get; set; }

    public DbSet<DisasterType> DisasterType { get; set; }

    public DbSet<Resource> Resource { get; set; }

    public DbSet<ResourceType> ResourceType { get; set; }

    public DisasterEmergencyContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
    {
        dbContextOptionsBuilder.UseSqlServer(_configuration["ConnectionStrings:DbConnectionString"]);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DisasterLevel>().HasMany(d => d.Disasters).WithOne(l => l.DisasterLevel);

        modelBuilder.Entity<DisasterType>().HasMany(d => d.Disasters).WithOne(t => t.DisasterType);

        modelBuilder.Entity<Resource>().HasMany(d => d.Disasters).WithOne(r => r.Resource);

        modelBuilder.Entity<ResourceType>().HasMany(r => r.Resources).WithOne(t => t.ResourceType);
    }
}
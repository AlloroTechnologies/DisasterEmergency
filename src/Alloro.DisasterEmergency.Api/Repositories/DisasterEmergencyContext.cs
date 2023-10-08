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
}
using Microsoft.EntityFrameworkCore;
using Alloro.DisasterEmergency.Api.Entities;

namespace Alloro.DisasterEmergency.Api.Repositories;

public class DisasterEmergencyContext : DbContext
{
    public DbSet<Disaster> Disaster { get; set; }

    public DbSet<DisasterLevel> DisasterLevel { get; set; }

    public DbSet<DisasterType> DisasterType { get; set; }

    public DbSet<Resource> Resource { get; set; }

    public DbSet<ResourceType> ResourceType { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
    {
        dbContextOptionsBuilder.UseSqlServer("Server=allorodisasteremergency.database.windows.net;Database=disasteremergency;");
    }
}
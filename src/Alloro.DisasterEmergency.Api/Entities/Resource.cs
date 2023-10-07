namespace Alloro.DisasterEmergency.Api.Entities;

public class Resource
{
    public int ResourceId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int ResourceTypeId { get; set; }

    public ResourceType ResourceType { get; set; }

    public List<Disaster> Disasters { get; set; }
}
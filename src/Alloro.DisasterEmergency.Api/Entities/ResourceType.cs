using System.Collections.Generic;

namespace Alloro.DisasterEmergency.Api.Entities;

public class ResourceType
{
    public int ResourceTypeId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public List<Resource> Resources { get; set; }
}
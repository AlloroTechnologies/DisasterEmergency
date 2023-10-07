using System.Collections.Generic;

namespace Alloro.DisasterEmergency.Api.Entities;

public class DisasterType
{
    public int DisasterTypeId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public List<Disaster> Disasters { get; set; }
}
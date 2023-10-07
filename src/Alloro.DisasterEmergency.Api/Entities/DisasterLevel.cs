using System.Collections.Generic;

namespace Alloro.DisasterEmergency.Api.Entities;

public class DisasterLevel
{
    public int DisasterLevelId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public double Priority { get; set; }

    public List<Disaster> Disasters { get; set; }
}
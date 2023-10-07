using Alloro.DisasterEmergency.Api.Entities;

namespace Alloro.DisasterEmergency.Api.Models;

public class Params
{
    public List<DisasterLevel> DisasterLevels { get; set; }

    public List<DisasterType> DisasterTypes { get; set; }

    public List<Resource> Resources { get; set; }
}
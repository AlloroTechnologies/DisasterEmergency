using Alloro.DisasterEmergency.Mobile.Entities;

namespace Alloro.DisasterEmergency.Mobile.Models;

public class Params
{
    public List<DisasterLevel> DisasterLevels { get; set; } = new();

    public List<DisasterType> DisasterTypes { get; set; } = new();

    public List<Alloro.DisasterEmergency.Mobile.Entities.Resource> Resources { get; set; } = new();
}
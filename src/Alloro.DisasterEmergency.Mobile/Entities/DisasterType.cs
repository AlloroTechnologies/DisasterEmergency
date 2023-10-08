namespace Alloro.DisasterEmergency.Mobile.Entities;

public class DisasterType
{
    public int DisasterTypeId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public List<Disaster> Disasters { get; set; }
}
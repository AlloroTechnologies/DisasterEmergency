using System;

namespace Alloro.DisasterEmergency.Api.Entities;

public class Disaster
{
    public int DisasterId { get; set; }

    public string Comments { get; set; }

    public double Lattitude { get; set; }

    public double Longitude { get; set; }

    public DateTime NotificationDate { get; set; }

    public int DisasterTypeId { get; set; }

    public DisasterType DisasterType { get; set; }

    public int DisasterLevelId { get; set; }

    public DisasterLevel DisasterLevel { get; set; }

    public int ResourceId { get; set; }

    public Resource Resource { get; set; }

    public string NotificationUserName { get; set; }
}
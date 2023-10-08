using CommunityToolkit.Mvvm.ComponentModel;
using Alloro.DisasterEmergency.Mobile.ServiceAgents;
using Alloro.DisasterEmergency.Mobile.Entities;
using System.Collections.ObjectModel;

public partial class DisasterMapViewModel : ObservableObject
{
    public ObservableCollection<Disaster> Disasters { get; private set; } = new ObservableCollection<Disaster>();

    public async Task GetDisastersAsync()
    {
      var disasterService = new DisasterService();

      var existingDisasters = await disasterService.GetDisastersAsync();

      existingDisasters.ForEach(Disasters.Add);
    }
}
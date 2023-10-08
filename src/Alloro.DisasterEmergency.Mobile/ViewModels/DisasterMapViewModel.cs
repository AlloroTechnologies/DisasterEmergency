using CommunityToolkit.Mvvm.ComponentModel;
using Alloro.DisasterEmergency.Mobile.ServiceAgents;
using Alloro.DisasterEmergency.Mobile.Entities;
using System.Collections.ObjectModel;

public partial class DisasterMapViewModel : ObservableObject
{
    public async Task<List<Disaster>> GetDisastersAsync()
    {
      var disasterService = new DisasterService();

      return await disasterService.GetDisastersAsync();
    }
}
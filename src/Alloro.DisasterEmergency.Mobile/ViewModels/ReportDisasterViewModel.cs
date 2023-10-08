using CommunityToolkit.Mvvm.ComponentModel;
using Alloro.DisasterEmergency.Mobile.ServiceAgents;
using Alloro.DisasterEmergency.Mobile.Entities;
using System.Collections.ObjectModel;

public partial class ReportDisasterViewModel : ObservableObject
{
    public ObservableCollection<DisasterLevel> DisasterLevels { get; private set; } = new ObservableCollection<DisasterLevel>();

    public ObservableCollection<DisasterType> DisasterTypes { get; private set; } = new ObservableCollection<DisasterType>();

    public ObservableCollection<Alloro.DisasterEmergency.Mobile.Entities.Resource> Resources { get; private set; } = new ObservableCollection<Alloro.DisasterEmergency.Mobile.Entities.Resource>();

    [ObservableProperty]
    public int disasterLevelSelectedIndex = -1;

    [ObservableProperty]
    public int disasterTypeSelectedIndex = -1;

    [ObservableProperty]
    public int resourceSelectedIndex = -1;

    [ObservableProperty]
    public string comments;

    public async Task GetParamsAsync()
    {
      var paramsService = new ParamsService();

      var result = await paramsService.GetParamsAsync();

      DisasterLevels.Clear();

      result.DisasterLevels.ForEach(DisasterLevels.Add);

      DisasterTypes.Clear();

      result.DisasterTypes.ForEach(DisasterTypes.Add);

      Resources.Clear();

      result.Resources.ForEach(Resources.Add);
    }

    public async Task NotifyDisasterAsync(Disaster disaster)
    {
      var disasterService = new DisasterService();

      await disasterService.NotifyDisasterAsync(disaster);
    }
}
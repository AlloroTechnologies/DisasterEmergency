using Microsoft.Maui.Controls.Maps;

namespace Alloro.DisasterEmergency.Mobile.Views;

public partial class DisasterMapPage : ContentPage
{
	private readonly DisasterMapViewModel viewModel;

	public DisasterMapPage()
	{
		InitializeComponent();

		viewModel = new DisasterMapViewModel();
	}

	protected async override void OnAppearing()
	{
		base.OnAppearing();

		var existingDisasters = await viewModel.GetDisastersAsync();

		_map.Pins.Clear();

		foreach(var item in existingDisasters)
		{
			_map.Pins.Add(
				new Pin()
				{
					Address = $"Type: {item.DisasterType.Name} - Level: {item.DisasterLevel.Name}",
					Label = item.Resource.Name,
					Location = new Location(item.Lattitude, item.Longitude),
					Type = PinType.Generic
				}
			);
		}
	}
}
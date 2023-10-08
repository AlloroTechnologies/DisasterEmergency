using Alloro.DisasterEmergency.Mobile.Entities;

namespace Alloro.DisasterEmergency.Mobile.Views;

public partial class ReportDisasterPage : ContentPage
{
	private readonly ReportDisasterViewModel viewModel;

	public ReportDisasterPage()
	{
		InitializeComponent();

		viewModel = new ReportDisasterViewModel();

		BindingContext = viewModel;
	}

	protected async override void OnAppearing()
	{
		base.OnAppearing();

		await viewModel.GetParamsAsync();

		_comments.Text = string.Empty;
	}

	async void OnNotifyClicked(object sender, EventArgs args)
    {
		GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));

        var cancelTokenSource = new CancellationTokenSource();

        Location location = await Geolocation.Default.GetLocationAsync(request, cancelTokenSource.Token);

		var disaster = new Disaster()
		{
			Comments = viewModel.Comments,
			Lattitude = location.Latitude,
			Longitude = location.Longitude,
			NotificationDate = DateTime.Now,
			DisasterTypeId = viewModel.DisasterTypes[viewModel.DisasterTypeSelectedIndex].DisasterTypeId,
			DisasterLevelId = viewModel.DisasterLevels[viewModel.DisasterLevelSelectedIndex].DisasterLevelId,
			ResourceId = viewModel.Resources[viewModel.ResourceSelectedIndex].ResourceId,
			NotificationUserName = "System"
		};

        await viewModel.NotifyDisasterAsync(disaster);
    }
}
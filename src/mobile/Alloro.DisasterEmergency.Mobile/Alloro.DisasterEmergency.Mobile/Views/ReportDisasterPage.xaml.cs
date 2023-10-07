namespace Alloro.DisasterEmergency.Mobile.Views;

public partial class ReportDisasterPage : ContentPage
{
	public ReportDisasterPage(ReportDisasterViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

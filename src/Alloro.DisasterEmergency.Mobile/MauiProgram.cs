namespace Alloro.DisasterEmergency.Mobile;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiMaps()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<WelcomePage>();

		builder.Services.AddSingleton<DisasterMapPage>();

		builder.Services.AddSingleton<ReportDisasterPage>();

		// TODO: Add App Center secrets
		AppCenter.Start(
			"windowsdesktop={Your Windows App secret here};" +
			"android=7cb62235-b871-4d9f-897b-89dc3f076d9b;" +
			"ios=fa4b1eb2-0948-4c3d-b3d3-879b5b6591be;" +
			"macos={Your macOS App secret here};",
			typeof(Analytics), typeof(Crashes));

		return builder.Build();
	}
}
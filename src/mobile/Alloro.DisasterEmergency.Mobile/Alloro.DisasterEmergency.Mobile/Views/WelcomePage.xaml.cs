﻿namespace Alloro.DisasterEmergency.Mobile.Views;

public partial class WelcomePage : ContentPage
{
	public WelcomePage(WelcomeViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
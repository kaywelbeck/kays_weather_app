namespace Kay_Weather_App;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private void BtnProceed_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new WeatherPage());
    }
}
namespace CompanyApp;

public partial class RegistrationPage : ContentPage
{
	public RegistrationPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await DisplayAlert("Alert", "Succesfull Registration","OK");
		await Navigation.PopAsync();
    }


}
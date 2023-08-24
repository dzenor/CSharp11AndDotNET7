namespace CompanyApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;

	}

	public List<Test> customList { get; set; } =  new List<Test>() { new(){MyProperty="Item1"}, new() { MyProperty="Item2" }, new() { MyProperty="Item3" } };

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new RegistrationPage());
    }
}

public class Test
{
    public string MyProperty { get; set; }
}




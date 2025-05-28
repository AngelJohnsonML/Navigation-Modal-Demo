namespace Navigation_Modal_Demo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	async void NavigationButton_Clicked(System.Object sender, System.EventArgs e)
	{
		var page1 = new Page1();
		await Navigation.PushModalAsync(page1);

		AuthenticationInputModel result = await page1.Result;

		if (result != null)
		{
			await DisplayAlert("Welcome", $"Username: {result.UserName}\nPassword: {result.Password}", "OK");
		}
		else
		{
			await DisplayAlert("Result", "No result returned", "OK");

		}
	}
}



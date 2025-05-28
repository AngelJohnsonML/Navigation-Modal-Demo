namespace Navigation_Modal_Demo;

public partial class Page1 : ContentPage
{

    private TaskCompletionSource<AuthenticationInputModel> _resultSource = new TaskCompletionSource<AuthenticationInputModel>();

    public Task<AuthenticationInputModel> Result => _resultSource.Task;

    public Page1()
	{
		InitializeComponent();
	}



    void OnLoginClicked(object sender, EventArgs e)
    {
        AuthenticationInputModel authenticationInputs = new AuthenticationInputModel
        {
            UserName = this.Username.Text,
            Password = this.Password.Text

        };

        _resultSource.TrySetResult(authenticationInputs);
        Navigation.PopModalAsync(); // Close the modal
    }

    protected override bool OnBackButtonPressed()
    {
        _resultSource.TrySetResult(null); // Indicate cancel
        return base.OnBackButtonPressed();
    }
}

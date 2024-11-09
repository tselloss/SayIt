namespace SayIt.Pages
{
    public partial class LoginPage : ContentPage
    {
        private readonly LoginPageModel _loginPageModel;

        public LoginPage(LoginPageModel loginPageModel)
        {
            InitializeComponent();
            _loginPageModel = loginPageModel;
            BindingContext = _loginPageModel;
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            try
            {
                // Attempt to log in using the LoginPageModel's LoginAsync method
                await _loginPageModel.LoginAsync();
                await DisplayAlert("Success", "Login successful!", "OK");

                // Navigate to the home page after successful login
                await Shell.Current.GoToAsync("//HomePage");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Login failed: {ex.Message}", "OK");
            }
        }

        private async void OnRegisterTapped(object sender, EventArgs e)
        {
            // Navigate to the Registration page
            await Shell.Current.GoToAsync("//RegistrationPage");
        }
    }
}

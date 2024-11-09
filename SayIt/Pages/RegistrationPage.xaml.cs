using Firebase.Auth;
using System;
using Microsoft.Maui.Controls;

namespace SayIt.Pages
{
    public partial class RegistrationPage : ContentPage
    {
        private readonly RegistrationPageModel _registrationPageModel;

        public RegistrationPage(RegistrationPageModel registrationPageModel)
        {
            InitializeComponent();
            _registrationPageModel = registrationPageModel;
            BindingContext = _registrationPageModel;
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            // Attempt registration using the RegistrationPageModel's Register method
            try
            {
                await _registrationPageModel.RegisterAsync();
                await DisplayAlert("Success", "Registration successful!", "OK");

                // Navigate to login page or home page after successful registration
                await Shell.Current.GoToAsync("//LoginPage");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Registration failed: {ex.Message}", "OK");
            }
        }

        private async void OnLoginTapped(object sender, EventArgs e)
        {
            // Navigate to the Login page
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}

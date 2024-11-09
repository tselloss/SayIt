using Firebase.Auth;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SayIt.Pages
{
    public class RegistrationPageModel : INotifyPropertyChanged
    {
        private readonly FirebaseAuthClient _client;

        private string _email;
        private string _password;
        private string _confirmPassword;

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public string ConfirmPassword
        {
            get => _confirmPassword;
            set
            {
                _confirmPassword = value;
                OnPropertyChanged();
            }
        }

        public RegistrationPageModel(FirebaseAuthClient firebaseAuthClient)
        {
            _client = firebaseAuthClient;
        }

        public async Task RegisterAsync()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(ConfirmPassword))
            {
                throw new Exception("All fields are required.");
            }

            if (Password != ConfirmPassword)
            {
                throw new Exception("Passwords do not match.");
            }

            try
            {
                // Register the user on Firebase
                var authResult = await _client.CreateUserWithEmailAndPasswordAsync(Email, Password);

                if (authResult == null)
                {
                    throw new Exception("Registration failed.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error during registration: {ex.Message}");
            }
        }

        // Update Properties when changed
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

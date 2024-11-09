using Firebase.Auth;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SayIt.Pages
{
    public class LoginPageModel : INotifyPropertyChanged
    {
        private readonly FirebaseAuthClient _client;

        private string _email;
        private string _password;

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

        public LoginPageModel(FirebaseAuthClient firebaseAuthClient)
        {
            _client = firebaseAuthClient;
        }

        public async Task LoginAsync()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                throw new Exception("Email and password are required for Login.");
            }

            try
            {
                // Attempt to login using Firebase Authentication
                var authResult = await _client.SignInWithEmailAndPasswordAsync(Email, Password);

                if (authResult == null)
                {
                    throw new Exception("Login failed.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error during login: {ex.Message}");
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

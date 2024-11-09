using Firebase.Auth;
using Firebase.Auth.Providers;
using Microsoft.Extensions.Logging;
using SayIt.Pages;

namespace SayIt
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder             
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton(new FirebaseAuthClient(new FirebaseAuthConfig()
            {
                ApiKey = "AIzaSyCVvHEGUCzR15SfuFSXX1pydSawopKCJWM",
                AuthDomain = "sayit-efc27.firebaseapp.com",
                Providers = new Firebase.Auth.Providers.FirebaseAuthProvider[] {
                 new EmailProvider()                
                }
            }));

            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<LoginPageModel>();
            builder.Services.AddSingleton<RegistrationPage>();
            builder.Services.AddSingleton<RegistrationPageModel>();

            return builder.Build();
        }
    }
}

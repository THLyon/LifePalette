using LifePalette.Views;
using LifePalette.Services;

namespace LifePalette.Views
{
    public partial class MainPage : ContentPage
    {
        private readonly IAuthService _authService;

        public MainPage()
        {
            InitializeComponent();
            // _authService = DependencyService.Get<IAuthService>();
            _authService = (Application.Current as App)?.ServiceProvider?.GetService<IAuthService>();
            CheckAuthentication();
        }

        private async void CheckAuthentication()
        {

            if (!_authService.IsUserSignedIn())
            {
                // Navigate to LoginPage if the user is not signed in
                await Navigation.PushAsync(new LoginPage());
            }
        }

        private async void OnSignUpClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private async void OnCalendarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalendarPage());
        }
    }
}

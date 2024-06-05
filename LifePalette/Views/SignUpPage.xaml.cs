using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePalette.Views
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }
        private async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            // Implement your sign-up logic here

            // If sign-up is successful, navigate to the MainPage
            await Navigation.PopAsync();
        }
    }
}

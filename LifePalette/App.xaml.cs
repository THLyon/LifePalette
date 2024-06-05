using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Extensions.DependencyInjection;
using LifePalette.Views; // Ensure this using directive is included

namespace LifePalette
{
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            ServiceProvider = serviceProvider;
            MainPage = new NavigationPage(new MainPage());
        }
    }
}

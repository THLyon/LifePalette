using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls; 

namespace LifePalette.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string _greeting;

        public string Greeting
        {
            get => _greeting;
            set
            {
                if (_greeting != value)
                {
                    _greeting = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand LoadGreetingCommand { get; }

        public MainPageViewModel()
        {
            LoadGreetingCommand = new Command(OnLoadGreeting);
        }

        private void OnLoadGreeting()
        {
            Greeting = "Welcome to LifePalette!";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
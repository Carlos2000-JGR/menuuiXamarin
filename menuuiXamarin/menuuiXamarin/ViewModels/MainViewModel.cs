using menuuiXamarin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace menuuiXamarin.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        public MenuOption Option1 { get; }
        public MenuOption Option2 { get; }
        public MenuOption Option3 { get; }
        public MenuOption Option4 { get; }
        public MenuOption Option5 { get; }
        public MenuOption Option6 { get; }
        public MainViewModel()
        {
            Option1 = new MenuOption("Places", "IconLocation.jpg", "42 Places");
            Option2 = new MenuOption("Food", "Food.png", "21 Places");
            Option3 = new MenuOption("Education", "School.jpg", "28 Places");
            Option4 = new MenuOption("Beach", "Beach.png", "15 Places");
            Option5 = new MenuOption("Pharmacy", "Pharmacy.png", "29 Places");
            Option6 = new MenuOption("Hardware ", "Tools.png", "34 Places");


        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

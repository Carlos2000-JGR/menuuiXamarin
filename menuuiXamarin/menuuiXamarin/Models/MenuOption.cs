using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace menuuiXamarin.Models
{
    public class MenuOption
    {
        public string Title { get; }
        public string Image { get; }
        public string Detail { get; }

        

        public MenuOption(string title, string image, string detail )
        {
            Title = title;
            Image = image;
            Detail = detail;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

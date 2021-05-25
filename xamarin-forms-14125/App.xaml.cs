using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_forms_14125
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}

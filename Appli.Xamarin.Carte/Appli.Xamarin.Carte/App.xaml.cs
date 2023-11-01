using Appli.Xamarin.Carte.Services;
using Appli.Xamarin.Carte.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appli.Xamarin.Carte
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pareto.Services;
using Pareto.Views;
using MonkeyCache.SQLite;

namespace Pareto
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new Pages.Landing());
        }

        protected override void OnStart()
        {
            Barrel.ApplicationId = "your_unique_name_here";

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pareto.Services;
using Pareto.Views;

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
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

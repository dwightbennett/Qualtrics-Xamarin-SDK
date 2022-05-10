using Qualtrics.Xamarin.SDK.Example.Services;
using Qualtrics.Xamarin.SDK.Example.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Qualtrics.Xamarin.SDK.Example
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

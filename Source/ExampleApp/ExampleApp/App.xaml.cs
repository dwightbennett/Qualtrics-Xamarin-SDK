using ExampleApp.Services;
using ExampleApp.Surveys;
using ExampleApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExampleApp
{
    public partial class App : Application
    {
        public static ISurvey Survey;

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

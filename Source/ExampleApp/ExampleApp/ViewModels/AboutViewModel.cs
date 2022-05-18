using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ExampleApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(ShowSurvey);
        }

        private void ShowSurvey(object obj)
        {
            App.Survey.ShowQualtricsSurvey();
        }

        public ICommand OpenWebCommand { get; }
    }
}
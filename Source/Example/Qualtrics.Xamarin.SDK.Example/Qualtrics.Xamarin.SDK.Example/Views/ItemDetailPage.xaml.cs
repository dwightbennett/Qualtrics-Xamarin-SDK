using Qualtrics.Xamarin.SDK.Example.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Qualtrics.Xamarin.SDK.Example.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
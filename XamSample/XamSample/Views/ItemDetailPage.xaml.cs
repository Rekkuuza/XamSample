using System.ComponentModel;

using Xamarin.Forms;

using XamSample.ViewModels;

namespace XamSample.Views
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
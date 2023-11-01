using Appli.Xamarin.Carte.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Appli.Xamarin.Carte.Views
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
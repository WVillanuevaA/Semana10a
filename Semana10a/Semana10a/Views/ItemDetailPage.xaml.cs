using System.ComponentModel;
using Semana10a.ViewModels;
using Xamarin.Forms;

namespace Semana10a.Views
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
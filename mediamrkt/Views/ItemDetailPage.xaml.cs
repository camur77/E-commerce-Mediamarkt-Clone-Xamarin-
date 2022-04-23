using mediamrkt.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace mediamrkt.Views
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
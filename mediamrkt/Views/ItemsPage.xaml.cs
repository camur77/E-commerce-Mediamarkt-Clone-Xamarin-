using mediamrkt.Models;
using mediamrkt.ViewModels;
using mediamrkt.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mediamrkt.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

        private async void deneme(object sender,EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        private async void deneme1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Telefon());
        }
        private async void deneme2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TV());
        }
        private async void deneme3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new beyaz());
        }
    }
}
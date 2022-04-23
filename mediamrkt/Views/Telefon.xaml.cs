using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mediamrkt.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Telefon : ContentPage
    {
        public Telefon()
        {
            InitializeComponent();
        }
        private async void telefonbir(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new telefonbir1());
        }
        private async void telefoniki(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new telefoniki2());
        }
    }
}
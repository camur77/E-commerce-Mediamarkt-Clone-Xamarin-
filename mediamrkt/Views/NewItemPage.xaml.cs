using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Timers;
using Xamarin.Forms.Xaml;

namespace mediamrkt.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewItemPage : ContentPage
    {
        

        public NewItemPage()
        {
            InitializeComponent();
            this.BindingContext = this;
           
        }
        public List<Product1> CollectionsList { get => GetCollections(); }

        private List<Product1> GetCollections()
        {
            var trendList = new List<Product1>();
            trendList.Add(new Product1 { Image = "haporlor2.jpeg", Name = "JBL Go 3 Haporlor", Price = "549,-" });
            trendList.Add(new Product1 { Image = "logitek2.jpeg", Name = "LOGITEXH Kulaklık", Price = "799,-" });
            trendList.Add(new Product1 { Image = "galaxy1.jpeg", Name = "Galaxy s21 5G", Price = "10499,-" });
            trendList.Add(new Product1 { Image = "galaxy3.jpeg", Name = "Galaxy Note 20 256 GB", Price = "9999,-" });
            return trendList;
        }

    }
    public class Product1
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
    }
}
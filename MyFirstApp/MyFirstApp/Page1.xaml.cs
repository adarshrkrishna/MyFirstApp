using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        ObservableCollection<Fruits> oc = new ObservableCollection<Fruits>();

        public Page1()
        {
            InitializeComponent();
            oc.Add(new Fruits() { Name = "Apple", NameDetail = "Fruit", page = new Apple() });
            oc.Add(new Fruits() { Name = "Mango", NameDetail = "Fruit", page = new Mango() });
            oc.Add(new Fruits() { Name = "Grapes", NameDetail = "Fruit", page = new Grapes() });
            oc.Add(new Fruits() { Name = "Orange", NameDetail = "Fruit", page = new Orange() });
            oc.Add(new Fruits() { Name = "Banana", NameDetail = "Fruit", page = new Banana() });
            oc.Add(new Fruits() { Name = "Watermelon", NameDetail = "Fruit", page = new Watermelon() });
            oc.Add(new Fruits() { Name = "Cherry", NameDetail = "Fruit", page = new Cherry() });
            Fruits.ItemsSource = oc;
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem == null)
            {
                return;
            }
            Debug.WriteLine(e.SelectedItem.ToString());
            var item = e.SelectedItem as Fruits;
            Navigation.PushAsync(item.page);
            
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(false);
        }

        async void OnLogout(object sender, EventArgs e)
        {
            bool val = await DisplayAlert(" ",
                             " Are You Sure You Want to Log Out","Ok","Cancel");
            Debug.WriteLine(val + " is your answer");
            if (val)
            {
                await Navigation.PopToRootAsync();
            }
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }

    public class Fruits
    {
        public string Name { get; set; }
        public string NameDetail { get; set; }
        public Page page { get; set; }
    }
}
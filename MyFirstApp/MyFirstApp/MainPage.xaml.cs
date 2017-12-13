using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyFirstApp
{
    public partial class MainPage : ContentPage
    { 
        public MainPage()
        {
            InitializeComponent();
        }

        void OnLogin(Object sender, EventArgs e)
        {
            LoginProcess();
            /*if(String.IsNullOrEmpty(Myusername.Text) && String.IsNullOrEmpty(Mypassword.Text))
            {
                await DisplayAlert("Alert", "Enter User Name and Password", "Ok");
            }

            else if(String.IsNullOrEmpty(Myusername.Text))
            {
                await DisplayAlert("Alert", "Enter User Name", "Ok");
                return;
            }

            else if (String.IsNullOrEmpty(Mypassword.Text))
            {
                await DisplayAlert("Alert", "EnterPassword", "Ok");
                return;
            }

            else if (Myusername.Text == "teligenz" && Mypassword.Text == "teligenz")
            {
                await Navigation.PushAsync(new Page1());
                Myusername.Text = "";
                Mypassword.Text = "";
            }

            else
            {
                    await DisplayAlert("Alert", "Invalid username or password", "Ok");
            }*/
            
        }

        void LoginProcess()
        {
            if (String.IsNullOrEmpty(Myusername.Text) && String.IsNullOrEmpty(Mypassword.Text))
            {
                DisplayAlert("Alert", "Enter User Name and Password", "Ok");
            }

            else if (String.IsNullOrEmpty(Myusername.Text))
            {
                DisplayAlert("Alert", "Enter User Name", "Ok");
                return;
            }

            else if (String.IsNullOrEmpty(Mypassword.Text))
            {
                DisplayAlert("Alert", "EnterPassword", "Ok");
                return;
            }

            else if (Myusername.Text == "teligenz" && Mypassword.Text == "teligenz")
            {
                Navigation.PushAsync(new Page1());
                Myusername.Text = "";
                Mypassword.Text = "";
            }

            else
            {
                DisplayAlert("Alert", "Invalid username or password", "Ok");
            }
        }

        void OnCompleted(object sender, EventArgs e)
        {
            Mypassword.Focus();
        }

        void OnEntryTwo(object sender, EventArgs e)
        {
            LoginProcess();
        }
    }
}

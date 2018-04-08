using PuppyLove.ViewModels;
using PuppyLove.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PuppyLove
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
		}

        private async void Handle_Login_Clicked(object sender, System.EventArgs e)
        {
            var answer = await DisplayAlert("Title", "Do you have an account?", "Yes", "No");
            if(answer == true)
            {
                await Navigation.PushModalAsync(new HomePage());
            }
        }

        private void Handle_Signup_Clicked(object sender, System.EventArgs e)
        {
            OnSignup(sender, e);
        }

        private async void OnSignup(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new DisclosurePage());
        }

    }
}

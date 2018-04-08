using PuppyLove.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PuppyLove.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignupPage4 : ContentPage
	{
		public SignupPage4 ()
		{
			InitializeComponent ();
            BindingContext = new SignupPage4ViewModel();
		}

        private void Handle_DoNotOwn_Clicked(object sender, System.EventArgs e)
        {
            OnDoNotOwn(sender, e);
        }

        private async void OnDoNotOwn(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new DoNotOwnPage1());
        }

        private void Handle_Signup4Next_Clicked(object sender, System.EventArgs e)
        {
            OnSignup4Next(sender, e);
        }

        private async void OnSignup4Next(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new DogParkPage1());
        }        
    }
}
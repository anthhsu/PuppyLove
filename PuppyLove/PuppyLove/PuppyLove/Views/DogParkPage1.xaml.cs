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
	public partial class DogParkPage1 : ContentPage
	{
		public DogParkPage1 ()
		{
			InitializeComponent ();
		}

        private void Handle_DogPark1Next_Clicked(object sender, System.EventArgs e)
        {
            OnDogPark1Next(sender, e);
        }

        private async void OnDogPark1Next(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new DogParkPage2());
        }

        private void Handle_DogPark1Cancel_Clicked(object sender, System.EventArgs e)
        {
            OnDogPark1Cancel(sender, e);
        }

        private async void OnDogPark1Cancel(object sender, System.EventArgs e)
        {
            var answer = await DisplayAlert("Cancel", "Are you sure you want to return to the login screen?", "Yes", "No");
            if (answer == true)
            {
                await Navigation.PushAsync(new MainPage());
            }
        }
    }
}
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
	public partial class DogParkPage2 : ContentPage
	{
		public DogParkPage2 ()
		{
			InitializeComponent ();
		}

        private void Handle_DogPark2Continue_Clicked(object sender, System.EventArgs e)
        {
            OnDogPark2Continue(sender, e);
        }

        private async void OnDogPark2Continue(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new DogParkPage3());
        }
    }
}
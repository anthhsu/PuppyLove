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
	public partial class DogParkPage3 : ContentPage
	{
		public DogParkPage3 ()
		{
            InitializeComponent ();
		}

        private void Handle_DogPark3Continue_Clicked(object sender, System.EventArgs e)
        {
            OnDogPark3Continue(sender, e);
        }

        private async void OnDogPark3Continue(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PhotoUploadPage1());
        }        
    }
}
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
	public partial class DoNotOwnPage2 : ContentPage
	{
		public DoNotOwnPage2 ()
		{
			InitializeComponent ();
		}

        private void Handle_DoNotOwn2Yes_Clicked(object sender, System.EventArgs e)
        {
            OnDoNotOwn2Yes(sender, e);
        }

        private async void OnDoNotOwn2Yes(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new DoNotOwnPage3());
        }

        private void Handle_DoNotOwn2No_Clicked(object sender, System.EventArgs e)
        {
            OnDoNotOwn2No(sender, e);
        }

        private async void OnDoNotOwn2No(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
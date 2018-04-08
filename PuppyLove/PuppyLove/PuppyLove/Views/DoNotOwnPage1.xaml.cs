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
	public partial class DoNotOwnPage1 : ContentPage
	{
		public DoNotOwnPage1 ()
		{
			InitializeComponent ();
		}

        private void Handle_DoNotOwn1Continue_Clicked(object sender, System.EventArgs e)
        {
            OnDoNotOwn1Continue(sender, e);
        }

        private async void OnDoNotOwn1Continue(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new DoNotOwnPage2());
        }

        private void Handle_DoNotOwn1Cancel_Clicked(object sender, System.EventArgs e)
        {
            OnDoNotOwn1Cancel(sender, e);
        }

        private async void OnDoNotOwn1Cancel(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

    }
}
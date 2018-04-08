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
	public partial class DoNotOwnPage3 : ContentPage
	{
		public DoNotOwnPage3 ()
		{
			InitializeComponent ();
		}

        private void Handle_DoNotOwn3Continue_Clicked(object sender, System.EventArgs e)
        {
            OnDoNotOwn3Continue(sender, e);
        }

        private async void OnDoNotOwn3Continue(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

    }
}
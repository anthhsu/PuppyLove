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
	public partial class DisclosurePage : ContentPage
	{
		public DisclosurePage ()
		{
			InitializeComponent ();
		}

        public void Handle_Understand_Clicked (object sender, System.EventArgs e)
        {
            OnUnderstand(sender, e);
        }

        private async void OnUnderstand(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SignupPage1());
        }


    }
}
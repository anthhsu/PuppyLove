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
	public partial class SignupPage1 : ContentPage
	{
		public SignupPage1 ()
		{
			InitializeComponent ();
		}

        public void Handle_Signup1Next_Clicked(object sender, System.EventArgs e)
        {
            OnSignup1Next(sender, e);
        }

        private async void OnSignup1Next(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SignupPage2());
        }

    }
}
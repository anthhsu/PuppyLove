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
	public partial class EmailVerification : ContentPage
	{
		public EmailVerification ()
		{
			InitializeComponent ();
		}

        public void Handle_Resend_Clicked(object sender, System.EventArgs e)
        {
            OnResend(sender, e);
        }

        private void OnResend(object sender, System.EventArgs e)
        {
            DisplayAlert("Resend Code", "Code has been resent.", "OK");
        }

        public void Handle_EmailVerificationContinue_Clicked(object sender, System.EventArgs e)
        {
            OnEmailVerificationContinue(sender, e);
        }

        private async void OnEmailVerificationContinue(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SignupPage3());
        }
    }
}
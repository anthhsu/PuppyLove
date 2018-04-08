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
	public partial class SignupPage2 : ContentPage
	{
        public SignupPage2 ()
		{            
            InitializeComponent ();            
		}        

        public void Handle_Signup2Next_Clicked(object sender, System.EventArgs e)
        {
            if (EntryPassword.Text != null && EntryPassword.Text.Length < 6)
            {
                DisplayAlert("Error", "Password must be at least 6 characters!", "Continue");
                return;
            }
            else if (EntryPassword.Text != EntryConfirmPassword.Text)
            {
                DisplayAlert("Error", "Passwords do not match!", "Continue");
                return;
            }
            OnSignup2Next(sender, e);
        }

        private async void OnSignup2Next(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EmailVerification());
        }
    }
}
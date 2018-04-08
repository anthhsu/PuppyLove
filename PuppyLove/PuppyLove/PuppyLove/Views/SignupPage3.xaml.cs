using PuppyLove.ViewModels;
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
	public partial class SignupPage3 : ContentPage
	{
		public SignupPage3 ()
		{
			InitializeComponent ();
            BindingContext = new SignupPage3ViewModel();
		}

        private void Handle_Signup3Next_Clicked(object sender, System.EventArgs e)
        {
            OnSignup3Next(sender, e);
        }

        private async void OnSignup3Next(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SignupPage4());
        }

    }
}
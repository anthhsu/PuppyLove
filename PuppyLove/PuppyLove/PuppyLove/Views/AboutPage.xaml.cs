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
	public partial class AboutPage : ContentPage
	{
		public AboutPage ()
		{
			InitializeComponent ();
		}

        private void Handle_AboutBack_Clicked(object sender, System.EventArgs e)
        {
            OnAboutBack(sender, e);
        }

        private async void OnAboutBack(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

    }
}
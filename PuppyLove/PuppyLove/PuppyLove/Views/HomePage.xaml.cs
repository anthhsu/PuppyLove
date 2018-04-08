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
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
            buttonTutorial.BackgroundColor = Color.Black.MultiplyAlpha(0.75);
        }

        private void Handle_AboutButton_Clicked(object sender, System.EventArgs e)
        {
            OnAbout(sender, e);
        }

        private async void OnAbout(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new AboutPage());
        }

        private void Handle_ChatButton_Clicked(object sender, System.EventArgs e)
        {
            OnChat(sender, e);
        }

        private async void OnChat(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ChatPage());
        }

        private void Handle_MatchButton_Clicked(object sender, System.EventArgs e)
        {
            OnMatch(sender, e);
        }

        private async void OnMatch(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MatchPage());
        }

        private void Handle_ShopButton_Clicked(object sender, System.EventArgs e)
        {
            OnShop(sender, e);
        }

        private async void OnShop(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ShopPage());
        }

        private void Handle_ProfileButton_Clicked(object sender, System.EventArgs e)
        {
            OnProfile(sender, e);
        }

        private async void OnProfile(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ProfilePage());
        }

        private async void Handle_Tutorial_Clicked(object sender, System.EventArgs e)
        {
            await layoutTutorial.FadeTo(0);
            layoutTutorial.IsEnabled = false;
        }

        private async void Handle_ExitTutorial_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }

    }
}
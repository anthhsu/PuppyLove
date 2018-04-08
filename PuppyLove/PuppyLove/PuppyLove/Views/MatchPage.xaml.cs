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
	public partial class MatchPage : ContentPage
	{
        
        public MatchPage ()
		{
            InitializeComponent();
            BindingContext = new MatchPageViewModel();
            buttonTutorial.BackgroundColor = Color.Black.MultiplyAlpha(0.75);
        }

        private void Handle_MatchBack_Clicked(object sender, System.EventArgs e)
        {
            OnMatchBack(sender, e);
        }

        private async void OnMatchBack(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void Handle_Tutorial_Clicked(object sender, System.EventArgs e)
        {
            await layoutTutorial.FadeTo(0);
            layoutTutorial.IsEnabled = false;
        }

    }
}
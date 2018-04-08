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
	public partial class OptionalQuestionsPage : ContentPage
	{
		public OptionalQuestionsPage ()
		{
			InitializeComponent ();
		}

        public void Handle_Complete_Clicked(object sender, System.EventArgs e)
        {
            OnComplete(sender, e);
        }

        private async void OnComplete(object sender, System.EventArgs e)
        {
            Navigation.InsertPageBefore(new HomePage(), Navigation.NavigationStack.First());
            Navigation.PopToRootAsync(true);
        }
    }
}
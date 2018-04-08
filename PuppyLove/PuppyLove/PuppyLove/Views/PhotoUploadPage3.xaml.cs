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
	public partial class PhotoUploadPage3 : ContentPage
	{
		public PhotoUploadPage3 ()
		{
			InitializeComponent ();
		}

        public void Handle_PhotoUpload3Next_Clicked(object sender, System.EventArgs e)
        {
            OnPhotoUpload3Next(sender, e);
        }

        private async void OnPhotoUpload3Next(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new OptionalQuestionsPage());
        }
        
        public void Handle_PhotoUpload3Help_Clicked(object sender, System.EventArgs e)
        {
            OnPhotoUpload3Help(sender, e);
        }

        private async void OnPhotoUpload3Help(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
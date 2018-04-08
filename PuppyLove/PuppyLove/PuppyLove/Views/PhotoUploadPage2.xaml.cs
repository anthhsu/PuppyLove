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
	public partial class PhotoUploadPage2 : ContentPage
	{
		public PhotoUploadPage2 ()
		{
			InitializeComponent ();
		}

        public void Handle_PhotoUpload2Next_Clicked(object sender, System.EventArgs e)
        {
            OnPhotoUpload2Next(sender, e);
        }

        private async void OnPhotoUpload2Next(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PhotoUploadPage3());
        }
    }
}
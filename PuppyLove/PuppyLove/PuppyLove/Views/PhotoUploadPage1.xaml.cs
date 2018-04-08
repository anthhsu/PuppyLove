using Plugin.Media;
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
	public partial class PhotoUploadPage1 : ContentPage
	{
		public PhotoUploadPage1 ()
		{
			InitializeComponent ();
		}

        public void Handle_PhotoUpload1Next_Clicked(object sender, System.EventArgs e)
        {
            OnPhotoUpload1Next(sender, e);
        }

        private async void OnPhotoUpload1Next(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PhotoUploadPage2());
        }

        public async Task Handle_Photo1_ClickedAsync(object sender, System.EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera avaialble.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,
                Directory = "Sample",
                Name = "test.jpg"
            });

            if (file == null)
                return;

            await DisplayAlert("File Location", file.Path, "OK");
        }
    }
}
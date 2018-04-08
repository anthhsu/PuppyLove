using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using static System.Math;

namespace PuppyLove.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {

        public double dblScreenWidth = App.ScreenWidth;
        public double dblScreenHeight = App.ScreenHeight;

        public ProfilePage()
        {
            InitializeComponent();
            InitializeButtons();
            InitializeEntries();
            InitializeMenu();
        }
        
        public void InitializeButtons()
        {
            buttonProfile1.WidthRequest = App.ScreenWidth;
            buttonProfile2.WidthRequest = App.ScreenWidth;
            buttonProfile3.WidthRequest = App.ScreenWidth;
            buttonProfile4.WidthRequest = App.ScreenWidth;
            buttonProfile5.WidthRequest = App.ScreenWidth;
            buttonProfile6.WidthRequest = App.ScreenWidth;
            buttonProfile7.WidthRequest = App.ScreenWidth;
            buttonProfile8.WidthRequest = App.ScreenWidth;

            buttonProfile1.HeightRequest = 20;
            buttonProfile2.HeightRequest = 20;
            buttonProfile3.HeightRequest = 20;
            buttonProfile4.HeightRequest = 20;
            buttonProfile5.HeightRequest = 20;
            buttonProfile6.HeightRequest = 20;
            buttonProfile7.HeightRequest = 20;
            buttonProfile8.HeightRequest = 20;           
        }

        public void InitializeEntries()
        {
            imageProfile.WidthRequest = dblScreenWidth * 0.4;
            imageProfile.HeightRequest = dblScreenWidth * 0.4;

            entryName.WidthRequest = dblScreenWidth * 0.5;
            entryAge.WidthRequest = dblScreenWidth * 0.5;
            entryDogName.WidthRequest = dblScreenWidth * 0.5;
            entryDogAge.WidthRequest = dblScreenWidth * 0.5;

            entryName.HeightRequest = 20;
            entryAge.HeightRequest = 20;
            entryDogName.HeightRequest = 20;
            entryDogAge.HeightRequest = 20;
        }

        public void InitializeMenu()
        {
            buttonAbout.WidthRequest = dblScreenWidth * 0.15;
            buttonShop.WidthRequest = dblScreenWidth * 0.15;
            buttonChat.WidthRequest = dblScreenWidth * 0.15;
            buttonProfile.WidthRequest = dblScreenWidth * 0.15;
            buttonMatch.WidthRequest = dblScreenWidth * 0.2;

            buttonAbout.HeightRequest = dblScreenWidth * 0.15;
            buttonShop.HeightRequest = dblScreenWidth * 0.15;
            buttonChat.HeightRequest = dblScreenWidth * 0.15;
            buttonProfile.HeightRequest = dblScreenWidth * 0.15;
            buttonMatch.HeightRequest = dblScreenWidth * 0.22;
        }

    }
}
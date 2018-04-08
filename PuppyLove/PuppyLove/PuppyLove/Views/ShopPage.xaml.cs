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
	public partial class ShopPage : ContentPage
	{
		public ShopPage ()
		{
			InitializeComponent ();

            // Initialize gridItems            
            InitializeGridItems();

            // Initialize gridVendors
            InitializeGridVendors();

            // Initialize gridShelters
            InitializeGridShelters();
        }

        private void InitializeGridItems()
        {
            // Variables
            int totalItems = 4;        
            int iRows = 4;
            int iCols = totalItems/4;                       

            // Add RowDefinitions
            for (int i = 0; i < iRows; i++)
            {
                gridItems.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }

            // Add ColumnDefinitions
            for (int i = 0; i < iCols; i++)
            {
                gridItems.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }

            // Add Items
            for (int x = 0; x < iRows; x++)
            {
                for (int y = 0; y < iCols; y++)
                {
                    int total = (x * y) + x;
                    gridItems.Children.Add(new Button
                    {
                        HeightRequest = 50,
                        WidthRequest = 50,
                        BorderColor = Color.Black,
                        BorderWidth = 1,
                        Text = total.ToString()                    
                    },
                    x, y);
                }
            }
        }

        private void InitializeGridVendors()
        {
            // Variables
            int totalItems = 8;
            int iRows = 4;
            int iCols = totalItems / 4;

            // Add RowDefinitions
            for (int i = 0; i < iRows; i++)
            {
                gridVendors.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }

            // Add ColumnDefinitions
            for (int i = 0; i < iCols; i++)
            {
                gridVendors.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }

            // Add Vendors
            for (int x = 0; x < iRows; x++)
            {
                for (int y = 0; y < iCols; y++)
                {
                    int total = (x * y) + x;
                    gridVendors.Children.Add(new Button
                    {
                        HeightRequest = 50,
                        WidthRequest = 50,
                        BorderColor = Color.Black,
                        BorderWidth = 1,
                        Text = total.ToString()
                    },
                    x, y);
                }
            }
        }

        private void InitializeGridShelters()
        {
            // Variables
            int totalItems = 4;
            int iRows = 4;
            int iCols = totalItems / 4;

            // Add RowDefinitions
            for (int i = 0; i < iRows; i++)
            {
                gridShelters.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }

            // Add ColumnDefinitions
            for (int i = 0; i < iCols; i++)
            {
                gridShelters.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }

            // Add Vendors
            for (int x = 0; x < iRows; x++)
            {
                for (int y = 0; y < iCols; y++)
                {
                    int total = (x * y) + x;
                    gridShelters.Children.Add(new Button
                    {
                        HeightRequest = 50,
                        WidthRequest = 50,
                        BorderColor = Color.Black,
                        BorderWidth = 1,
                        Text = total.ToString()
                    },
                    x, y);
                }
            }
        }

        private void Handle_ShopBack_Clicked(object sender, System.EventArgs e)
        {
            OnShopBack(sender, e);
        }

        private async void OnShopBack(object sender, System.EventArgs e)
        {            
            await Navigation.PopModalAsync();
        }

    }
}
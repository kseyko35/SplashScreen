using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SplashExample
{
    public partial class SplashScreen : ContentPage
    {
        Image mImage;
        public SplashScreen()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            //InitializeComponent();
            var sub = new AbsoluteLayout();

            mImage = new Image
            {
                Source = "logo.png",
                WidthRequest = 100,
                HeightRequest = 100
            };
            AbsoluteLayout.SetLayoutFlags(mImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(mImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(mImage);

            BackgroundColor = Color.FromHex("#ffffff");
            Content = sub;

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await mImage.ScaleTo(1, 2000);
            await mImage.ScaleTo(1, 1200, Easing.Linear);
            await mImage.ScaleTo(150, 1200, Easing.Linear);

            Application.Current.MainPage = new MainPage();


        }
    }

}
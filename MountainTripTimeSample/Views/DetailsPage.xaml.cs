using System;
using System.Collections.Generic;
using MountainTripTimeSample.Models;
using Xamarin.Forms;

namespace MountainTripTimeSample.Views
{
    public partial class DetailsPage : ContentPage
    {
        public List<Mountains> mountains;

        Frame lastElementSelected;
    
        public DetailsPage()
        {
            InitializeComponent();
            VisualStateManager.GoToState(MountainMenu, "PressedMenu");

            mountains = new List<Mountains>
            {
                new Mountains
                {
                   Picture      = "Mountain1",
                   Description  = "Rocky Mountains"
                },
                new Mountains
                {
                   Picture      = "Mountain1",
                   Description  = "Mount MacKinley"
                },
                new Mountains
                {
                   Picture      = "Mountain1",
                   Description  = "Rocky Mountains"
                },
                new Mountains
                {
                   Picture      = "Mountain1",
                   Description  = "Mount MacKinley"
                },
                new Mountains
                {
                   Picture      = "Mountain1",
                   Description  = "Rocky Mountains"
                }
            };
            
            for (int i = 1; i < mountains.Count; i++)
            {
                StackLayout stackHeader = new StackLayout()
                {
                    Orientation   = StackOrientation.Vertical,
                    Padding       = new Thickness(1,10,1,0) 
                };

                Frame frameImage = new Frame()
                {
                    Content = new Image { Source = $"{mountains[i].Picture}", Aspect = Aspect.Fill, WidthRequest = 10 },
                    CornerRadius = 20,
                    Padding = 0,
                    IsClippedToBounds = true
                };

                Frame frameText = new Frame()
                {
                    Content = new Label { Text = $"{mountains[i].Description}", VerticalTextAlignment = TextAlignment.Center , HorizontalTextAlignment = TextAlignment.Center },
                    CornerRadius = 20,
                    HasShadow = false,
                    TranslationY = -30,
                    BackgroundColor = Color.FromHex("#f8f8f8"),
                    HeightRequest = 50
                };

                var tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += Frame_Tapped;
                frameText.GestureRecognizers.Add(tapGestureRecognizer);


                stackHeader.Children.Add(frameImage);
                stackHeader.Children.Add(frameText);
                mountainLayout.Children.Add(stackHeader);
            } 
        }

        private void Frame_Tapped(object sender, EventArgs e)
        {
            if (lastElementSelected != null)
                VisualStateManager.GoToState(lastElementSelected, "UnSelected");
                VisualStateManager.GoToState((Frame)sender, "Selected"); 
                lastElementSelected = (Frame)sender;
        }

        public void MountainMenu_Clicked(object sender, EventArgs e)
        {
            VisualStateManager.GoToState(MountainMenu, "PressedMenu");
            VisualStateManager.GoToState(BusMenu, "UnPressedMenu");
            VisualStateManager.GoToState(MsgMenu, "UnPressedMenu");
        }

        public void BusMenu_Clicked(object sender, EventArgs e)
        {
            VisualStateManager.GoToState(BusMenu, "PressedMenu");
            VisualStateManager.GoToState(MsgMenu, "UnPressedMenu");
            VisualStateManager.GoToState(MountainMenu, "UnPressedMenu");
        }

        public void MsgMenu_Clicked(object sender, EventArgs e)
        {
            VisualStateManager.GoToState(MsgMenu, "PressedMenu");
            VisualStateManager.GoToState(BusMenu, "UnPressedMenu");
            VisualStateManager.GoToState(MountainMenu, "UnPressedMenu");
        } 

    }
}

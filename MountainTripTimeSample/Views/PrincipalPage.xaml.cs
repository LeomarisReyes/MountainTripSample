using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MountainTripTimeSample.Views
{
    public partial class PrincipalPage : ContentPage
    {
        public PrincipalPage()
        {
            InitializeComponent();
        }

        async void Btn_Tapped(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Views.DetailsPage());
        }
    }
}

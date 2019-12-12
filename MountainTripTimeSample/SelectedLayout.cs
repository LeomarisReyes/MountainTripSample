using System;
using Xamarin.Forms;

namespace MountainTripTimeSample
{
    public class SelectedLayout : TriggerAction<Button>
    {
        protected override void Invoke(Button button)
        {
            button.HeightRequest = 300;
            button.BackgroundColor = Color.White;
        }
    }
}
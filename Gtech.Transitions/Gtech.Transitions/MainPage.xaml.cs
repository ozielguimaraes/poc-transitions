using System;
using Xamarin.Forms;

namespace Gtech.Transitions
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyNewDesign());
        }
    }
}

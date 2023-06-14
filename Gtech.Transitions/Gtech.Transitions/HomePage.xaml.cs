using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Gtech.Transitions
{	
	public partial class HomePage : ContentPage
	{	
		public HomePage ()
		{
			InitializeComponent ();
		}
		
        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}


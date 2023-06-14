using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gtech.Transitions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyNewDesign : ContentPage
    {
        public MyNewDesign()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            //await Navigation.PushAsync(new MainPage());
        }
    }
}
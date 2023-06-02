using Plugin.SharedTransitions;
using Xamarin.Forms;

namespace Gtech.Transitions
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new SharedTransitionNavigationPage(new MainPage());
        }

        //public App(IPlatformInitializer initializer = null) : base(initializer) { }

        //protected override async void OnInitialized()
        //{
        //    InitializeComponent();

        //    //Standard navigationpage
        //    //await NavigationService.NavigateAsync($"{nameof(SharedTransitionNavigationPage)}/{nameof(MainPage)}");

        //    //Tabbed Page
        //    //await NavigationService.NavigateAsync(nameof(MainTabbedPage));

        //    //Master-Detail
        //    //await NavigationService.NavigateAsync(nameof(MainMasterDetailPage));

        //    await NavigationService.NavigateAsync(nameof(MainPage));
        //}


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

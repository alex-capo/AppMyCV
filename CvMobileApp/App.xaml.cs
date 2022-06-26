using Xamarin.Forms;

namespace CvMobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new Views.MainPage();
            MainPage = new AppShell();
        }

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

using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace AppCenterSample
{
    public partial class App : Application
    {
        const string uwpKey = "2b977979-ebbc-40f8-b6d2-cddb98312ac1";
        const string iosKey = "fd48b091-446f-4d58-b99e-da2673218a13";
        const string androidKey = "9247e30e-affe-4d14-8170-4c9a5131d79f";

        public App()
        {
            InitializeComponent();

            MainPage = new AppCenterSamplePage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start($"android={androidKey};ios={iosKey};",
                            typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

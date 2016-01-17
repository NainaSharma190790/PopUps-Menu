using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PopupsMenu
{
    public class App : Application
    {
        public static int ScreenHeight;
        public static int ScreenWidth;

       public App()
        {
                             
            var np = new NavigationPage(new Page1()) { Title = "Navigation Stack" };
			np.Tint = Xamarin.Forms.Color.FromRgb(239, 141, 180);
            // The root page of your application
            MainPage = np;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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

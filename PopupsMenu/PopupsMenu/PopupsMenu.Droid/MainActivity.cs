using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace PopupsMenu.Droid
{
	[Activity (Label = "PopupsMenu", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

            int Width = Convert.ToInt32(Resources.DisplayMetrics.WidthPixels / Resources.DisplayMetrics.Density);
            float HeightF = (Resources.DisplayMetrics.HeightPixels / Resources.DisplayMetrics.Density);
            int Height = Convert.ToInt16(HeightF);
            App.ScreenHeight = Height;
            App.ScreenWidth = Width;
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new PopupsMenu.App());




		}
	}
}


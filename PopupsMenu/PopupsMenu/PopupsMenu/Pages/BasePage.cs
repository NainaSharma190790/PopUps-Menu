using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.ServiceModel.Channels;
using System.Text;
using Xamarin.Forms;

namespace PopupsMenu
{
    public class BasePage : ContentPage
    {
        #region All Fields
        
        public StackLayout popView;
        public Button btn,btn1,btn2;
        public bool isFirst = true;
        public int iClicks = 0;
        #endregion

        public BasePage()
        {

            #region Toolbar Item
            ToolbarItems.Add(new ToolbarItem
            {
                Text = "OOO",
                Order = ToolbarItemOrder.Primary,
                Command = new Command(() => Check()),
            });
			
            #endregion

            #region Items for popview

             btn = new Button
            {
                Text = "Profile",
                HorizontalOptions = LayoutOptions.Start,
                BackgroundColor = Xamarin.Forms.Color.Transparent,
                TextColor = Xamarin.Forms.Color.Black,
            };
             btn1 = new Button
            {
                Text = "Settings",
				HorizontalOptions = LayoutOptions.Start,
                BackgroundColor = Xamarin.Forms.Color.Transparent,
                TextColor = Xamarin.Forms.Color.Black,

            };
             btn2 = new Button
            {
                Text = "Logout",
				HorizontalOptions = LayoutOptions.Start,
                BackgroundColor = Xamarin.Forms.Color.Transparent,
                TextColor = Xamarin.Forms.Color.Black,
            };
            #endregion

        }
        
        #region Popup view

        public StackLayout PopupsView
        {
            get
            {
                popView = new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    WidthRequest = App.ScreenWidth/2,
					HeightRequest=App.ScreenHeight,
					BackgroundColor = Xamarin.Forms.Color.FromRgb(84, 84, 84),
					Opacity=0.7,
					Spacing = 3,
                    Padding = new Thickness(0, 0, 0, 0),
                    Children = 
                    {
                        btn,
                        btn1,
                        btn2,	
                    }
                };
                return popView;
            }
        }
        #endregion

        #region Method for Silde popview
        public void Check()
        {
            if (isFirst == true)
            {

                var eAndN = new Tuple<Easing, string>[]
                {
                    new Tuple<Easing, string> (Easing.Linear, "Linear") 
                };
                double w = App.ScreenWidth;
                double h = App.ScreenHeight;
                var newPos = new Rectangle(w/2, 0, w, h);
                var eAndName = eAndN[iClicks];
                var easing = eAndName.Item1;
                popView.LayoutTo(newPos, 100, easing);
                iClicks %= eAndN.Length;
                isFirst = false;
            }
            else
            {
                var eAndN = new Tuple<Easing, string>[]
                {
                    new Tuple<Easing, string> (Easing.Linear, "Linear") 
                };
                double w = App.ScreenWidth;
                double h = App.ScreenHeight;
                var newPos = new Rectangle(w, 0, w, h);
                var eAndName = eAndN[iClicks];
                var easing = eAndName.Item1;
                popView.LayoutTo(newPos, 100, easing);
                iClicks %= eAndN.Length;
                isFirst = true;
            }
        }
        #endregion

    }
}

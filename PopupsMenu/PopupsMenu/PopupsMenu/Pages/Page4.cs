using System;
using Xamarin.Forms;

namespace PopupsMenu
{
    public class Page4 : BasePage
	{
		public Page4 ()
        {
            #region All controls with click

            var prev = new Button
			{ 
				Text = "Pre Page",
				BackgroundColor=Xamarin.Forms.Color.Transparent,
				TextColor=Xamarin.Forms.Color.FromRgb(219,63,0),
			};
			prev.Clicked += async (sender, e) => {
				await Navigation.PopAsync();
			};		
              #endregion

            #region Main Layout


            Title = "Page 4";
			BackgroundImage="Page4.png";

            var mainLayout = new RelativeLayout
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
            };
            //Initialization of this popview already on base page. Here we just add this popview in current page.
            mainLayout.Children.Add(PopupsView, Constraint.Constant(App.ScreenWidth), Constraint.Constant(0));
            mainLayout.Children.Add(prev, Constraint.Constant(5), Constraint.Constant(15));
            this.Content = mainLayout;		
		    #endregion

		}
	}
}



using System;
using Xamarin.Forms;

namespace PopupsMenu
{
	public class Page3 : BasePage
	{
		public Page3 ()
        {
            #region All controls with click

            var next = new Button 
			{ 
				Text = "Next Page",
				BackgroundColor=Xamarin.Forms.Color.Transparent,
				TextColor=Xamarin.Forms.Color.FromRgb(158,38,8),
			};
			next.Clicked += async (sender, e) => {
				await Navigation.PushAsync (new Page4());
			};
			var prev = new Button
			{ 
				Text = "Pre Page",
				BackgroundColor=Xamarin.Forms.Color.Transparent,
				TextColor=Xamarin.Forms.Color.FromRgb(158,38,8),
			};
			prev.Clicked += async (sender, e) => {
				await Navigation.PopAsync();
			};
            #endregion

            #region Main Layout

            Title = "Page 3";
			BackgroundImage="Page3.png";

            var mainLayout = new RelativeLayout
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
            };
            //Initialization of this popview already on base page. Here we just add this popview in current page.
            mainLayout.Children.Add(PopupsView, Constraint.Constant(App.ScreenWidth), Constraint.Constant(0));
            mainLayout.Children.Add(next, Constraint.Constant(10), Constraint.Constant(15));
            mainLayout.Children.Add(prev, Constraint.Constant(10), Constraint.Constant(55));

            this.Content = mainLayout;		
			#endregion

		}
	}
}



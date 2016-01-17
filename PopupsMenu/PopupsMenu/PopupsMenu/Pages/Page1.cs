using System;
using Xamarin.Forms;

namespace PopupsMenu
{
	public class Page1 : BasePage
	{
      
		public Page1 ()
        {
            int o = App.ScreenHeight;
            int ov = App.ScreenWidth;
            #region All controls with click
            
            var b = new Button
			{ 
				Text = "Next Page",
				BackgroundColor=Xamarin.Forms.Color.Transparent,
				TextColor=Xamarin.Forms.Color.Pink,
			};
            b.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Page2());
            };
            #endregion

            #region Main Layout 

            Title = "Page 1";
			BackgroundImage="Page1.png";
            var mainLayout = new RelativeLayout
            { 
                HorizontalOptions=LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,                
			};
            //Initialization of this popview already on base page. Here we just add this popview in current page.
            mainLayout.Children.Add(PopupsView, Constraint.Constant(App.ScreenWidth), Constraint.Constant(0));
            mainLayout.Children.Add(b, Constraint.Constant(10), Constraint.Constant(15));           
           this. Content= mainLayout;
            #endregion

        }

    }
}



using System;
using Xamarin.QuickUI;
using System.Collections.ObjectModel;

namespace Meetum.Views
{
    public class CustomerMapOptionsView : ContentPage
    {
        public CustomerMapOptionsView ()
        {
            BackgroundColor = Color.FromHex(/*"DDEEFF"*/ "999999");
            var layout = new StackLayout();
            layout.Children.Add(new Label { Text = "Search By" });
            Content = layout;
        }
    }

}


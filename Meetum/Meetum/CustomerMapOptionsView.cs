using System;
using Xamarin.QuickUI;
using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Meetum.Views
{

    public class CustomerMapOptionsView : ContentPage
    {
        static readonly List<OptionItem> OptionItems = new List<OptionItem> {
            new OptionItem { Title = "Zipcode", Subtitle = "94133" },
            new OptionItem { Title = "Region", Subtitle = "Jackson Heights" },
            new OptionItem { Title = "Zone", Subtitle = "5A" },
            new OptionItem { Title = "Distance", Subtitle = "3 miles" },
        };

        public CustomerMapOptionsView ()
        {
            BackgroundColor = Color.FromHex("e5ecee");

            var layout = new RelativeLayout();
            var label = new Label {
                Text = "Search By", 
                BackgroundColor = Color.Transparent, 
                Font = Font.BoldSystemFontOfSize(NamedSize.Large),
                TextColor = Color.FromHex("a4a9aa")
            };

            layout.Children.Add(label, ()=> new Rectangle(new Point(10, 10), new Size(400, 400)));

            var listView = new StripedListView {
                ItemSource = OptionItems,
                VerticalOptions = LayoutOptions.Start
            };

            var cell = new DataTemplate(typeof(StripedViewCell));
            cell.SetBinding(TextCell.TextProperty, "Title");
            cell.SetBinding(TextCell.DetailProperty, "Subtitle");
            listView.ItemTemplate = cell;

            layout.Children.Add(listView, ()=> 0, ()=> label.Y + 40, (Expression<Func<double>>)null, (Expression<Func<double>>)null);
            Content = layout;
        }
    }

}


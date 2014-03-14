using Xamarin.QuickUI;
using System.Collections.ObjectModel;

namespace Meetum.Views
{
    public class CustomerMapDisplayView : TabbedPage
    {
        readonly ObservableCollection<TabItem> buttons = new ObservableCollection<TabItem>();

        public CustomerMapDisplayView()
        {
            buttons.Add(new TabItem { Title = "Store Map", Icon = "map.png" });
            buttons.Add(new TabItem { Title = "Store List", Icon = "list.png" });

            ItemSource = buttons;

            ItemTemplate = new DataTemplate(()=>{
                var page = new ContentPage();
                page.Content = CustomerMap.InitializeMap(page);

                page.SetBinding(Page.TitleProperty, "Title");
                page.SetBinding(Page.IconProperty, "Icon");
//                var navPage = new NavigationPage(page);
//                navPage.SetBinding(Page.TitleProperty, "Title");
//                navPage.SetBinding(Page.IconProperty, "Icon");
//                NavigationPage.SetHasNavigationBar(page, false);
//                NavigationPage.SetHasNavigationBar(navPage, false);
//                return navPage;
                return page;
            });
        }
    }
}

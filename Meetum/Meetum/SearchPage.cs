using System;
using Xamarin.QuickUI;

namespace Meetum.Views
{
    public class SearchPage : MasterDetailPage
    {
        public SearchPage ()
        {
            Title = "Customers Nearby";
            Master = new CustomerMapOptionsView();
            Detail = new CustomerMapDisplayView();
        }
    }
}


using System;
using CSMC.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CSMC.Models
{
    public class NewsListView : ScrollView
    {
        public NewsListView(List<New> list)
        {
            StackLayout sl = new StackLayout();
            foreach(New n in list)
            {
                sl.Children.Add(new Title(n.Text));
                sl.Children.Add(new Image { Source = n.Image });
                sl.Children.Add(new BoxView { HeightRequest = 1, BackgroundColor = Color.Black });
            }
            Content = sl;
        }
    }
}


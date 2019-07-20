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
                TapGestureRecognizer tgr = new TapGestureRecognizer();
                tgr.Tapped += (s, e) => Navigation.PushAsync(new ShowNew(n));
                Title t = new Title(n.Text);
                t.GestureRecognizers.Add(tgr);
                sl.Children.Add(t);
                sl.Children.Add(new Image { Source = n.Image });
                sl.Children.Add(new BoxView { HeightRequest = 1, BackgroundColor = Color.Black });
            }
            Content = sl;
        }
    }
}


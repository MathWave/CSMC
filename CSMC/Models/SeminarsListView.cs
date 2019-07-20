using System;
using Xamarin.Forms;
using System.Collections.Generic;
namespace CSMC.Models
{
    public class SeminarsListView : ScrollView
    {
        public SeminarsListView(List<Seminar> list)
        {
            StackLayout sl = new StackLayout();
            foreach(Seminar s in list)
            {
                sl.Children.Add(new Title(s.Title) { HorizontalOptions = LayoutOptions.Start });
                sl.Children.Add(new Info(s.Text) { HorizontalTextAlignment = TextAlignment.Start });
                sl.Children.Add(new BoxView { HeightRequest = 1, BackgroundColor = Color.Black });
            }
            Content = sl;
        }
    }
}

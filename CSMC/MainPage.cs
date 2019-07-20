using System;
using Xamarin.Forms;

namespace CSMC
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            BarBackgroundColor = Color.Black;
            Title = "НУЛ МУСС";
            Children.Add(new News());
            Children.Add(new About());
            Children.Add(new Seminars());
            Children.Add(new Workers());
            Children.Add(new Publications());
            Children.Add(new Vacancies());
            Children.Add(new Projects());
            ToolbarItems.Add(new ToolbarItem("settings", "", () => Navigation.PushAsync(new Settings())) { IconImageSource = "settings.png" });
        }
    }
}


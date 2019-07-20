using System;
using CSMC.Models;
using System.Net;
using Xamarin.Forms;

namespace CSMC
{
    public class WorkerPage : MyPage
    {
        public WorkerPage(Person p)
        {
            Title = p.Name;
            bool success = true;
            Worker w = new Worker();
            try
            {
                string html = string.Empty;
                string position = string.Empty;
                using (WebClient wc = new WebClient())
                {
                    html = wc.DownloadString($"https://{p.Link}");
                }
                position = html.Split(new string[] { "class=\"person-appointment-title\">" }, StringSplitOptions.RemoveEmptyEntries)[1].Split(new string[] { "</span>" }, StringSplitOptions.RemoveEmptyEntries)[0];
                w.position = position.Substring(0, position.Length - 1);
                w.photo = html.Split(new string[] { "background-image:url" }, StringSplitOptions.RemoveEmptyEntries)[1].Split('\'')[1];
                if (w.photo[0] == '/')
                    w.photo = "http://hse.ru" + w.photo;
                w.email = html.Split(new string[] { "hseEObfuscator" }, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries)[1].Replace("\"-at-\"", "@").Replace("\"", "").Replace(",", "");
            }
            catch { success = false; }
            if (!success)
                Content = new ScrollView
                {
                    Content = new StackLayout
                    {
                        Children =
                        {
                            new Title("Отсутствует подключение к интернету") { VerticalOptions = LayoutOptions.Center },
                            new Image{ Source = "white.jpg", VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center }
                        }
                    }
                };
            else
            {
                MyButton b = new MyButton("Написать");
                b.Clicked += (s, e) => { Device.OpenUri(new Uri($"mailto:{w.email}")); };
                Content = new ScrollView
                {
                    Content = new StackLayout
                    {
                        Children =
                        {
                            new Title(w.position),
                            new Image
                            {
                                Source = w.photo,
                                WidthRequest = 300,
                                HeightRequest = 300,
                            },
                            b
                        }
                    }
                };
            }
        }
    }
}


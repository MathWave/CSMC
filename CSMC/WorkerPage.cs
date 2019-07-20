using System;
using CSMC.Models;
using System.Net;
using Xamarin.Forms;

namespace CSMC
{
    public class WorkerPage : ContentPage
    {
        public WorkerPage(Person p)
        {
            Title = p.Name;
            bool success = true;
            string html = string.Empty;
            string position = string.Empty;
            string photo = string.Empty;
            string email = string.Empty;
            try
            {
                using (WebClient wc = new WebClient())
                {
                    html = wc.DownloadString($"https://{p.Link}");
                }
                position = html.Split(new string[] { "class=\"person-appointment-title\">" }, StringSplitOptions.RemoveEmptyEntries)[1].Split(new string[] { "</span>" }, StringSplitOptions.RemoveEmptyEntries)[0];
                position = position.Substring(0, position.Length - 1);
                photo = html.Split(new string[] { "background-image:url" }, StringSplitOptions.RemoveEmptyEntries)[1].Split('\'')[1];
                if (photo[0] == '/')
                    photo = "http://hse.ru" + photo;
                email = html.Split(new string[] { "hseEObfuscator" }, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries)[1].Replace("\"-at-\"", "@").Replace("\"", "").Replace(",", "");
            }
            catch { success = false; }
            if (!success)
            {
                //Title = "вв";
            }
            MyButton b = new MyButton("Написать");
            b.Clicked += (s, e) => { Device.OpenUri(new Uri($"mailto:{email}")); };
            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Title(position),
                        new Image
                        {
                            Source = photo,
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


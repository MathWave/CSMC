using System;
using CSMC.Models;
using Xamarin.Forms;
using System.Net;
using System.Collections.Generic;

namespace CSMC
{
    public class News : MyPage
    {
        public News() : base()
        {
            Title = "Новости";
			bool success = true;
			string html = string.Empty;
            List<New> list = new List<New>();
            try
            {
                using (WebClient wc = new WebClient())
                {
                    html = wc.DownloadString("https://cs.hse.ru/big-data/csmc/");
                }
                string[] info = html.Split(new string[] { "post__content" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i < info.Length; i++)
                {
                    string[] spl = info[i].Split(new char[] { '>', '<' }, StringSplitOptions.RemoveEmptyEntries);
                    string im = "";
                    try
                    {
                        im = spl.Length > 9 ? "http://hse.ru" + spl[9].Split('\"')[1] : "";
                    }
                    catch
                    {
                        im = "white.jpg";
                    }
                    New n = new New
                    {
                        Text = spl[3],
                        Image = im,
                        Link = spl[2].Split('\"')[3]
                    };
                    list.Add(n);
                }
            }
            catch
            { success = false; }
            if (success)
            {
                SerializationInfo.SerializeNews(list);
                App.NewsDB = list;
            }
            Content = new NewsListView(App.NewsDB);
        }
    }
}


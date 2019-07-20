using System;
using CSMC.Models;
using System.Net;
using Xamarin.Forms;
using System.Collections.Generic;
namespace CSMC
{
    public class Publications : MyPage
    {
        public Publications()
        {
            Title = "Публикации";
            string html = string.Empty;
            List<New> list = new List<New>();
            bool success = true;
            try
            {
                using (WebClient wc = new WebClient())
                {
                    html = wc.DownloadString("https://cs.hse.ru/big-data/csmc/publications?search=15a2d174e97e87863dd28c8cfacb3ee1");
                }
                string[] data = html.Split(new string[] { "pubs-item__title" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i < data.Length; i++)
                {
                    string[] spl = data[i].Split(new char[] { '<', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    New n = new New
                    {
                        Text = spl[2],
                        Link = spl[1].Split('\"')[3]
                    };
                    list.Add(n);
                }
            }
            catch
            {
                success = false;
            }
            if (success)
            {
                SerializationInfo.SerializePublications(list);
                App.PublicationsDB = list;
            }
            Content = new NewsListView(App.PublicationsDB);
        }
    }
}


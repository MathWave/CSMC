using System;
using CSMC.Models;
using Xamarin.Forms;
using System.Net;
using System.Web;
using System.Collections.Generic;
namespace CSMC
{
    public class Seminars : MyPage
    {
        public Seminars()
        {
            Title = "Семинары";
            bool success = true;
            string html = string.Empty;
            List<Seminar> list = new List<Seminar>();
            StackLayout sl = new StackLayout();
            try
            {
                using (WebClient wc = new WebClient())
                {
                    html = wc.DownloadString("https://cs.hse.ru/big-data/csmc/seminars");
                }
                string[] data = html.Split('\n')[73].Split(new string[] { "<h2 class=\"block-title\">", "</h2>" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i < data.Length; i += 2)
                {
                    Seminar s = new Seminar
                    {
                        Title = data[i],
                        Text = MakeString(HttpUtility.HtmlDecode(data[i + 1]))
                    };
                    list.Add(s);
                }
            }
            catch
            {
                success = false;
            }
            if (success)
            {
                SerializationInfo.SerializeSeminars(list);
                App.SeminarsDB = list;
            }
            Content = new SeminarsListView(App.SeminarsDB);
        }

        string MakeString(string line)
        {
            string str = "";
            bool ok = true;
            foreach (char l in line)
            {
                if (l == '<')
                    ok = false;
                else if (l == '>')
                {
                    ok = true;
                    str += '\n';
                }
                else if (ok)
                    str += l;
                else continue;
            }
            return str;
        }
    }
}


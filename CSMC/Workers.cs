using System;
using CSMC.Models;
using System.IO;
using System.Net;
using Xamarin.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CSMC
{
    public class Workers : MyPage
    {
        static string html = string.Empty;
        public Workers() : base()
        {
            Title = "Сотрудники";
            List<Person> work = new List<Person>();
            bool success = true;
            try
            {
                using (WebClient wc = new WebClient())
                {
                    html = wc.DownloadString("https://cs.hse.ru/big-data/csmc/people");
                }
                string need = html.Split('\n')[73].Split(new string[] { "<section>", "</section>" }, StringSplitOptions.RemoveEmptyEntries)[0];
                string[] spl = need.Split(new char[] { '>', '<' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 22; i < spl.Length; i += 15)
                {
                    Person p = new Person
                    {
                        Name = spl[i],
                        Link = spl[i - 1].Split('\"')[3].Substring(2)
                    };
                    work.Add(p);
                }
            }
            catch { success = false; }
            if (success)
            {
                SerializationInfo.SerializePersonList(work);
                App.PersonDB = work;
            }
            Content = new PersonListView(App.PersonDB);
        }

    }
}


using System;
using CSMC.Models;
using System.IO;
using System.Net;
using Xamarin.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace CSMC
{
    public class Workers : MyPage
    {
        static string html = string.Empty;
        public Workers() : base()
        {
            Title = "Сотрудники";
            Content = new Title("Идет загрузка данных...");
            var t = Task.Run(()=>
            {
                try
                {
                    string url = "https://cs.hse.ru/big-data/csmc/people";
                    using (WebClient client = new WebClient())
                    {
                        html = client.DownloadString(url);
                    }
                    if (string.IsNullOrEmpty(html))
                        html = null;
                }
                catch
                {
                    html = null;
                    int a = 5;
                    a++;
                }
            });
            bool IsCompleted = t.Wait(TimeSpan.FromMilliseconds(10000));
            if (IsCompleted)
            {
                Content = new Title("Удачно");
            }
            else
            {
                Content = new Title("Отсутствует подключение к интернету");
            }
        }

        void GetInfo()
        {
            try
            {
                string url = "https://cs.hse.ru/big-data/csmc/people";
                using (WebClient client = new WebClient())
                {
                    html = client.DownloadString(url);
                }
                if (string.IsNullOrEmpty(html))
                    html = null;
            }
            catch
            {
                html = null;
                int a = 5;
                a++;
            }

        }

        async void Change()
        {
            while (true)
            {
                Content = new Title("Идет загрузка данных");
                await Task.Delay(TimeSpan.FromMilliseconds(1000));
                Content = new Title("Идет загрузка данных.");
                await Task.Delay(TimeSpan.FromMilliseconds(1000));
                Content = new Title("Идет загрузка данных..");
                await Task.Delay(TimeSpan.FromMilliseconds(1000));
                Content = new Title("Идет загрузка данных...");
                await Task.Delay(TimeSpan.FromMilliseconds(1000));

            }
        }


    }
}


using System;
using CSMC.Models;
using Xamarin.Forms;

namespace CSMC
{
    public class News : MyPage
    {
        public News() : base()
        {
            Title = "Новости";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello News" }
                }
            };
        }
    }
}


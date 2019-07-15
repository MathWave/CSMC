using System;
using CSMC.Models;
using Xamarin.Forms;

namespace CSMC
{
    public class About : MyPage
    {
        public About() : base()
        {
            Title = "О лаборатории";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello About" }
                }
            };
        }
    }
}


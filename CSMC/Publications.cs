using System;
using CSMC.Models;
using Xamarin.Forms;

namespace CSMC
{
    public class Publications : MyPage
    {
        public Publications() : base()
        {
            Title = "Публикации";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Publications" }
                }
            };
        }
    }
}


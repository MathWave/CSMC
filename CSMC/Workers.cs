using System;
using CSMC.Models;
using Xamarin.Forms;

namespace CSMC
{
    public class Workers : MyPage
    {
        public Workers() : base()
        {
            Title = "Сотрудники";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Workers" }
                }
            };
        }
    }
}


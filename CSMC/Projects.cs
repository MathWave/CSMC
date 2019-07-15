using System;
using CSMC.Models;
using Xamarin.Forms;

namespace CSMC
{
    public class Projects : MyPage
    {
        public Projects() : base()
        {
            Title = "Проекты";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Projects" }
                }
            };
        }
    }
}


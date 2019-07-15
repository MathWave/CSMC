using System;
using CSMC.Models;
using Xamarin.Forms;

namespace CSMC
{
    public class Seminars : MyPage
    {
        public Seminars() : base()
        {
            Title = "Семинары";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Seminars" }
                }
            };
        }
    }
}


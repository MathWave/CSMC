using System;
using Xamarin.Forms;
namespace CSMC.Models
{
    public class MyButton : Button
    {
        public MyButton(string line)
        {
            Text = line;
            BackgroundColor = Color.Black;
            TextColor = Color.White;
            FontSize = 15;
            Margin = 20;
        }
    }
}

using System;
using Xamarin.Forms;
namespace CSMC.Models
{
    public class Info : Label
    {
        public Info(string line)
        {
            Text = line;
            FontSize = 15;
            HorizontalOptions = LayoutOptions.Start;
            TextColor = Color.Black;
            HorizontalTextAlignment = TextAlignment.Start;
            Margin = 20;
        }
    }
}

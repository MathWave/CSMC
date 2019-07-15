using System;
using Xamarin.Forms;
namespace CSMC.Models
{
    public class Title : Label
    {
        public Title(string line)
        {
            Text = line;
            FontAttributes = FontAttributes.Bold;
            HorizontalOptions = LayoutOptions.CenterAndExpand;
            FontSize = 20;
            TextColor = Color.Black;
            Margin = 20;
        }
    }
}

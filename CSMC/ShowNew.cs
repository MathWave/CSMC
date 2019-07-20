using System;
using CSMC.Models;
using Xamarin.Forms;

namespace CSMC
{
    public class ShowNew : ContentPage
    {
        public ShowNew(New n)
        {
            Title = n.Text;
            Content = new WebView
            {
                Source = n.Link
            };
        }
    }
}


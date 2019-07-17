using System;
using Xamarin.Forms;
using System.Collections.Generic;
namespace CSMC.Models
{
    public class PersonListView : ScrollView
    {
        public PersonListView(List<Person> list)
        {
            var stack = new StackLayout();
            foreach(var t in list)
                stack.Children.Add
                (
                    new Button
                    {
                        Text = t.Name,
                        TextColor = Color.Black,
                        FontSize = 15,
                        BackgroundColor = Color.White,
                        HorizontalOptions = LayoutOptions.StartAndExpand
                    }
                );
            Content = stack;
        }
    }
}

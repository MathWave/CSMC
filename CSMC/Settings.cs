using System;

using Xamarin.Forms;

namespace CSMC
{
    public class Settings : ContentPage
    {
        public Settings()
        {
            Title = "Настройки";
            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Label
                                {
                                    Text = "Кэшировать данные",
                                    TextColor = Color.Black,
                                    FontSize = 15,
                                    HorizontalOptions = LayoutOptions.FillAndExpand
                                },
                                new Switch
                                {
                                    OnColor = Color.Black
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}


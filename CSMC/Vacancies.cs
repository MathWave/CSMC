using System;
using CSMC.Models;
using Xamarin.Forms;

namespace CSMC
{
    public class Vacancies : MyPage
    {
        public Vacancies() : base()
        {
            Title = "Вакансии";
            Content = new StackLayout
            {
                Children =
                {
                    new Title("Приглашаем на стажировку"),
                    new Info("Приложите пожалуйста к письму CV, образец написанного текста и / или программного кода.")
                    {
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                    new MyButton("Отправить резюме")
                    {
                        VerticalOptions = LayoutOptions.End
                    }
                }
            };
        }
    }
}


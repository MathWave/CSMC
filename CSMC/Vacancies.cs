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
            MyButton b = new MyButton("Отправить резюме")
            {
                VerticalOptions = LayoutOptions.End
            };
            Content = new StackLayout
            {
                Children =
                {
                    new Title("Приглашаем на стажировку"),
                    new Info("Приложите, пожалуйста, к письму CV, образец написанного текста и / или программного кода.")
                    {
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                    b
                }
            };
            b.Clicked += (object s, EventArgs e) => { Device.OpenUri(new Uri("mailto:ashapoval@hse.ru?subject=Стажировка%20в%20НУЛ%20МУСС")); };
        }

    }
}


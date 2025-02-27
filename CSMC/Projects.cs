﻿using System;
using CSMC.Models;
using Xamarin.Forms;

namespace CSMC
{
    public class Projects : MyPage
    {
        public Projects()
        {
            Title = "Проекты";
            Content = new ScrollView
            {
                Content = new Info("" +
                "В настоящее время сотрудники лаборатории вовлечены в работу над следующими проектами:" +
                "\n\n- Визуальная карта \"Map of Data Science in Russia\"" +
                "\n\n- Восстановление характеристик меридионального потока, перемещающего плазму между экватором Солнца и полюсами" +
                "\n\n- Построение теоретической модели, объясняющей возникновение вынужденных предпринимателей" +
                "\n\n- Прогноз в самоорганизованных критических системах" +
                "\n\n- Разработка интеллектуальных аналитических сервисов" +
                "\n\n- Создание новостного агрегатора(Матвеев Егор, стажер - исследователь лаборатории)")
            };
        }
    }
}


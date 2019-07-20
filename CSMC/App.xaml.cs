using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using System.IO;
using CSMC.Models;

namespace CSMC
{
    public partial class App : Application
    {

        public static List<Person> PersonDB;
        public static List<New> NewsDB;
        public static List<Seminar> SeminarsDB;

        public App()
        {
            if (!File.Exists(SerializationInfo.Path("workers")))
                SerializationInfo.SerializePersonList(new List<Person>());
            if (!File.Exists(SerializationInfo.Path("news")))
                SerializationInfo.SerializeNews(new List<New>());
            if (!File.Exists(SerializationInfo.Path("seminars")))
                SerializationInfo.SerializeSeminars(new List<Seminar>());
            PersonDB = SerializationInfo.DeserializePersonList();
            NewsDB = SerializationInfo.DeserializeNews();
            SeminarsDB = SerializationInfo.DeserializeSeminars();
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.Black);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

    }
}

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

        public App()
        {
            if (!File.Exists(SerializationInfo.Path("workers")))
                SerializationInfo.SerializeWorkers(new List<Person>());
            PersonDB = SerializationInfo.DeseializeWorkers();
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

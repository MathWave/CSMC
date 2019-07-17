using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;
using CSMC.Models;

namespace CSMC
{
    public partial class App : Application
    {

        public static List<Person> PersonDB;

        public App()
        {
            var form = new DataContractJsonSerializer(typeof(List<Person>));
            if (!File.Exists(SerializationInfo.Path("workers")))
            {
                using (FileStream fs = new FileStream(SerializationInfo.Path("workers"), FileMode.Create))
                {
                    form.WriteObject(fs, new List<Person>());
                }
            }
            using (FileStream fs = new FileStream(SerializationInfo.Path("workers"), FileMode.Open))
            {
                PersonDB = (List<Person>)form.ReadObject(fs);
            }
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

using System;
using Xamarin.Forms;
using CSMC.Models;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;
namespace CSMC
{
    public static class SerializationInfo
    {

        public static string Path(string line) => Environment.GetFolderPath(Environment.SpecialFolder.Personal) + line + ".json";

        public static void SerializePersonList(List<Person> list)
        {
            var form = new DataContractJsonSerializer(typeof(List<Person>));
            using (FileStream fs = new FileStream(Path("workers"), FileMode.Create))
            {
                form.WriteObject(fs, list);
            }
        }

        public static List<Person> DeserializePersonList()
        {
            var form = new DataContractJsonSerializer(typeof(List<Person>));
            using (FileStream fs = new FileStream(Path("workers"), FileMode.Open))
            {
                return (List<Person>)form.ReadObject(fs);
            }
        }

        public static void SerializeNews(List<New> list)
        {
            var form = new DataContractJsonSerializer(typeof(List<New>));
            using (FileStream fs = new FileStream(Path("news"), FileMode.Create))
            {
                form.WriteObject(fs, list);
            }
        }

        public static List<New> DeserializeNews()
        {
            var form = new DataContractJsonSerializer(typeof(List<New>));
            using (FileStream fs = new FileStream(Path("news"), FileMode.Open))
            {
                return (List<New>)form.ReadObject(fs);
            }
        }

        public static void SerializeSeminars(List<Seminar> list)
        {
            var form = new DataContractJsonSerializer(typeof(List<Seminar>));
            using (FileStream fs = new FileStream(Path("seminars"), FileMode.Create))
            {
                form.WriteObject(fs, list);
            }
        }

        public static List<Seminar> DeserializeSeminars()
        {
            var form = new DataContractJsonSerializer(typeof(List<Seminar>));
            using (FileStream fs = new FileStream(Path("seminars"), FileMode.Open))
            {
                return (List<Seminar>)form.ReadObject(fs);
            }
        }

    }

}
